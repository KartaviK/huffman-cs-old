using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Coder
{
	public partial class MainForm : Form
	{
		List<FileInfo> files;
		bool isText = false;
		bool isArchive = false;

		public MainForm()
		{
			InitializeComponent();
			files = new List<FileInfo>();
			Directory.CreateDirectory("Archives");
		}

		private void DoVisible()
		{
			richTextBoxChosedFiles.Visible = true;
			labelChosedFiles.Visible = true;
			buttonCompress.Visible = true;
		}

		private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TextFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
				Multiselect = true
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string[] paths = openFileDialog.FileNames;

					foreach (var file in paths)
					{
						this.files.Add(new FileInfo(file));
						this.richTextBoxChosedFiles.AppendText($"{file}{Environment.NewLine}");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}

			this.buttonCompress.Enabled = true;
		}
		
		private void ArchiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "bin files (*.bin)|*.bin",
				Multiselect = true
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string[] paths = openFileDialog.FileNames;

					foreach (var file in paths)
					{
						this.files.Add(new FileInfo(file));
						this.richTextBoxChosedFiles.AppendText($"{file}{Environment.NewLine}");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}

			this.buttonUnCompress.Enabled = true;
		}

		#region Compress/UnCompress
		private void ButtonArchive_Click(object sender, EventArgs e)
		{
			foreach (var file in this.files)
			{
				StreamCoder.Compress(file.FullName);
			}

			this.richTextBoxChosedFiles.Clear();
			this.files.Clear();
			this.buttonCompress.Enabled = false;
			MessageBox.Show("All files are compresed!");
		}

		private void ButtonUnCompress_Click(object sender, EventArgs e)
		{
			foreach (var file in this.files)
			{
				StreamCoder.DeCompress(FileIO.ReadDeserialize(file.FullName), file.FullName);
			}

			this.richTextBoxChosedFiles.Clear();
			this.files.Clear();
			this.buttonUnCompress.Enabled = false;
			MessageBox.Show("All files was decompressed!");
		}
		#endregion
	}
}