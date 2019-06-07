using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coder
{
	/// <summary>
	/// Построение дерева Хаффмана для представления новой битовой ценности символов.
	/// </summary>
	[Serializable]
	public class Archive
	{
		private Encoding encode;
		private Node root;
		private BitArray bitArray;

		[NonSerialized]
		private List<Node> nodes;
		[NonSerialized]
		private Dictionary<char, int> frequencies;
		[NonSerialized]
		private string source;

		/// <summary>
		/// Корень деерва
		/// </summary>
		public Node Root { get => this.root; set => this.root = value; }

		/// <summary>
		/// Кодировка файла архивируемого файла
		/// </summary>
		public Encoding Encoding { get => this.encode; set => this.encode = value; }

		/// <summary>
		/// Стандартный класс для реализации дерева Хаффмана
		/// </summary>
		public Archive(Encoding encode)
		{
			this.source = FileIO.ReadAll();
			this.frequencies = new Dictionary<char, int>();
			this.nodes = new List<Node>();
			this.encode = encode;
			Build();
			this.bitArray = Encode();
		}
		
		private void Build()
		{
			FeelFrequencies();
			CollectNode();
			ConvertTree();
		}
		
		/// <summary>
		/// Кодирует текст 
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public BitArray Encode()
		{
			List<bool> encodedSource = new List<bool>();
			List<bool> symbol = null;

			for (int i = 0; i < source.Length; i++)
			{
				symbol = this.Root.Traverse(source[i], new List<bool>());
				encodedSource.AddRange(symbol);
			}

			return new BitArray(encodedSource.ToArray());
		}

		public StringBuilder Decode()
		{
			Node current = this.Root;
			var decoded = new StringBuilder();

			foreach (bool bit in this.bitArray)
			{
				if (bit)
				{
					if (current.Right != null)
					{
						current = current.Right;
					}
				}
				else
				{
					if (current.Left != null)
					{
						current = current.Left;
					}
				}

				if (current.IsLeaf())
				{
					decoded.Append(current.Symbol);
					current = this.Root;
				}
			}

			return decoded;
		}

		private void FeelFrequencies()
		{
			char key;

			for (int i = 0; i < source.Length; i++)
			{
				key = source[i];

				if (!this.frequencies.ContainsKey(key))
				{
					this.frequencies.Add(key, 0);
				}

				this.frequencies[key]++;
			}
		}

		private void CollectNode()
		{
			foreach (KeyValuePair<char, int> symbol in this.frequencies)
			{
				this.nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
			}
		}

		private void ConvertTree()
		{
			while (nodes.Count > 1)
			{
				List<Node> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();

				if (orderedNodes.Count >= 2)
				{
					List<Node> taken = orderedNodes.Take(2).ToList();

					Node parent = new Node()
					{
						Symbol = '\0',
						Frequency = taken[0].Frequency + taken[1].Frequency,
						Left = taken[0],
						Right = taken[1]
					};

					nodes.Remove(taken[0]);
					nodes.Remove(taken[1]);
					nodes.Add(parent);
				}

				this.Root = nodes.FirstOrDefault();
			}
		}

	}
}
