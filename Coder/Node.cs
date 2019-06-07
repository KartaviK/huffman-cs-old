using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder
{
	[Serializable]
	public class Node
	{
		private char symbol;
		[NonSerialized]
		private int frequency;
		private Node right;
		private Node left;

		public char Symbol
		{
			get => symbol;
			set => this.symbol = value;
		}

		public int Frequency
		{
			get => this.frequency;
			set => this.frequency = value;
		}

		public Node Right
		{
			get => this.right;
			set => this.right = value;
		}

		public Node Left
		{
			get => this.left;
			set => this.left = value;
		}

		public List<bool> Traverse(char symbol, List<bool> data)
		{
			if (Right == null && Left == null)
			{
				if (symbol.Equals(this.Symbol))
				{
					return data;
				}
				else
				{
					return null;
				}
			}
			else
			{
				List<bool> left = null;
				List<bool> right = null;

				if (Left != null)
				{
					List<bool> leftPath = new List<bool>();
					leftPath.AddRange(data);
					leftPath.Add(false);

					left = Left.Traverse(symbol, leftPath);
				}

				if (Right != null)
				{
					List<bool> rightPath = new List<bool>();
					rightPath.AddRange(data);
					rightPath.Add(true);
					right = Right.Traverse(symbol, rightPath);
				}

				if (left != null)
				{
					return left;
				}
				else
				{
					return right;
				}
			}
		}
	}
}
