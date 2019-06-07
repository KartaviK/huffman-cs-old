using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Text;

namespace Coder
{
	public static class StreamCoder
	{
		public static Encoding encode;

		/// <summary>
		/// Запускает архивацию текстового файла.
		/// </summary>
		/// <param name="file">Путь к архивируемому файлу</param>
		public static void Compress(string file)
		{
			encode = file.GetEncoding();
			FileIO.OpenStream(file);
			Archive tree = new Archive(encode);
			FileIO.WriteHuffman(tree, file);
			encode = null;
		}

		/// <summary>
		/// Десериализирует данные из файла для разархивирования файла
		/// </summary>
		/// <param name="tree">Дерефво Хаффмана для декодирования</param>
		/// <param name="file">Имя файла или путь к файлу</param>
		public static void DeCompress(Archive tree, string file)
		{
			StringBuilder decoded = tree.Decode();
			FileIO.WriteTextFile(decoded, file, tree.Encoding);
		}
	}
}