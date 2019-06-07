namespace Coder
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBoxChosedFiles = new System.Windows.Forms.RichTextBox();
			this.labelChosedFiles = new System.Windows.Forms.Label();
			this.buttonCompress = new System.Windows.Forms.Button();
			this.backgroundArchiver = new System.ComponentModel.BackgroundWorker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonUnCompress = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBoxChosedFiles
			// 
			this.richTextBoxChosedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxChosedFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBoxChosedFiles.Location = new System.Drawing.Point(12, 40);
			this.richTextBoxChosedFiles.Name = "richTextBoxChosedFiles";
			this.richTextBoxChosedFiles.ReadOnly = true;
			this.richTextBoxChosedFiles.Size = new System.Drawing.Size(397, 222);
			this.richTextBoxChosedFiles.TabIndex = 1;
			this.richTextBoxChosedFiles.Text = "";
			// 
			// labelChosedFiles
			// 
			this.labelChosedFiles.AutoSize = true;
			this.labelChosedFiles.Location = new System.Drawing.Point(9, 24);
			this.labelChosedFiles.Name = "labelChosedFiles";
			this.labelChosedFiles.Size = new System.Drawing.Size(67, 13);
			this.labelChosedFiles.TabIndex = 2;
			this.labelChosedFiles.Text = "Chosed files:";
			// 
			// buttonCompress
			// 
			this.buttonCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCompress.Enabled = false;
			this.buttonCompress.Location = new System.Drawing.Point(12, 267);
			this.buttonCompress.Name = "buttonCompress";
			this.buttonCompress.Size = new System.Drawing.Size(75, 24);
			this.buttonCompress.TabIndex = 3;
			this.buttonCompress.Text = "Compress";
			this.buttonCompress.UseVisualStyleBackColor = true;
			this.buttonCompress.Click += new System.EventHandler(this.ButtonArchive_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(421, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.archiveToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// textFileToolStripMenuItem
			// 
			this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
			this.textFileToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.textFileToolStripMenuItem.Text = "Text file";
			this.textFileToolStripMenuItem.Click += new System.EventHandler(this.TextFileToolStripMenuItem_Click);
			// 
			// archiveToolStripMenuItem
			// 
			this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
			this.archiveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.archiveToolStripMenuItem.Text = "Compress";
			this.archiveToolStripMenuItem.Click += new System.EventHandler(this.ArchiveToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
			// 
			// buttonUnCompress
			// 
			this.buttonUnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUnCompress.Enabled = false;
			this.buttonUnCompress.Location = new System.Drawing.Point(334, 267);
			this.buttonUnCompress.Name = "buttonUnCompress";
			this.buttonUnCompress.Size = new System.Drawing.Size(75, 23);
			this.buttonUnCompress.TabIndex = 7;
			this.buttonUnCompress.Text = "Uncompress";
			this.buttonUnCompress.UseVisualStyleBackColor = true;
			this.buttonUnCompress.Click += new System.EventHandler(this.ButtonUnCompress_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 303);
			this.Controls.Add(this.buttonUnCompress);
			this.Controls.Add(this.buttonCompress);
			this.Controls.Add(this.labelChosedFiles);
			this.Controls.Add(this.richTextBoxChosedFiles);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(350, 200);
			this.Name = "MainForm";
			this.Text = "Coder";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox richTextBoxChosedFiles;
		private System.Windows.Forms.Label labelChosedFiles;
		private System.Windows.Forms.Button buttonCompress;
		private System.ComponentModel.BackgroundWorker backgroundArchiver;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
		private System.Windows.Forms.Button buttonUnCompress;
	}
}

