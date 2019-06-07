using System.Collections;
using System.IO;
using System.Text;

namespace Coder
{
	/// <summary>
	/// Класс-расширение для существующих типов
	/// </summary>
	public static class Extension
	{
		/// <summary>
		/// Определяет, является ли вершина листом дерева.
		/// </summary>
		/// <param name="node">Текущий элемент на дереве.</param>
		/// <returns>true, если вершина является листом.</returns>
		public static bool IsLeaf(this Node node)
		{
			return (node.Left == null && node.Right == null);
		}

		/// <summary>
		/// Конвертирует одинарный массив битов в одномерный массив байтов.
		/// </summary>
		/// <param name="bits">Массив битов</param>
		/// <returns>Конвертированный массив байтов</returns>
		public static byte[] ToBytes(this BitArray bits)
		{
			byte[] bytes = new byte[bits.Length / 8 + (bits.Length % 8 == 0 ? 0 : 1)];
			bits.CopyTo(bytes, 0);

			return bytes;
		}

		/// <summary>
		/// Определяет кодировку файла относительно маркера BOM.
		/// При полном несоответствии возвращается ASCII
		/// </summary>
		/// <param name="filename">Файл, треубемый проанализировать</param>
		/// <returns>Определенную кодировку текста</returns>
		public static Encoding GetEncoding(this string filename)
		{
			if (StreamCoder.encode == null)
			{
				// Read the BOM
				var bom = new byte[4];

				using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
				{
					file.Read(bom, 0, 4);
				}

				// Analyze the BOM
				if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76)
					return Encoding.UTF7;
				if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
					return Encoding.UTF8;
				if (bom[0] == 0xff && bom[1] == 0xfe)
					return Encoding.Unicode; //UTF-16LE
				if (bom[0] == 0xfe && bom[1] == 0xff)
					return Encoding.BigEndianUnicode; //UTF-16BE
				if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff)
					return Encoding.UTF32;

				return Encoding.ASCII;
			}

			return StreamCoder.encode;
		}
	}
}
