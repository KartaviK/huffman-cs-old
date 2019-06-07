using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Coder
{
	public static class FileIO
	{
		private static Stream stream;
		private static StreamReader reader;
		private static string file;

		/// <summary>
		/// Открывает поток для чтения файлa
		/// </summary>
		/// <param name="path"></param>
		public static void OpenStream(string path = null)
		{
			if (stream == null)
			{
				stream = File.Open(path,FileMode.Open);
				FileIO.file = path;
			}

			try
			{
				CreateStream();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private static void CreateStream()
		{
			stream.Close();
			stream = File.OpenRead(file);

			if (stream.CanRead)
			{
				reader = new StreamReader(stream, Encoding.Default);
			}
		}

		public static string ReadAll()
		{
			string cache = null;

			if (reader != null)
			{
				cache = reader.ReadToEnd();
			}

			return cache;
		}
		
		public static void WriteHuffman(Archive tree, string filename)
		{
			var formatter = new BinaryFormatter();
			filename = filename.Remove(filename.Length - 4);
			FileStream stream = new FileStream($"{filename}.bin", FileMode.Create);
			formatter.Serialize(stream, tree);
			stream.Close();
			stream.Dispose();
			reader.Close();
			reader.Dispose();
		}

		public static void WriteTextFile(StringBuilder source, string filename, Encoding encode)
		{
			filename = filename.Remove(filename.Length - 4);

			using (var writer = new StreamWriter($"{filename}.txt", false, Encoding.Default))
			{
				writer.Write(source.ToString());
			}
		}

		public static Archive ReadDeserialize(string path)
		{
			return
				(Archive)new BinaryFormatter().Deserialize(new FileStream(path, FileMode.Open));
		}
	}
}