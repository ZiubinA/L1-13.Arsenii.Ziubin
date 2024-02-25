namespace L1_13.Arsenii.Ziubin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.Operations = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColPostcardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectorWithMoreThanOneCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByYearAscAlphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUnknownYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1859, 1111);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(120, 57);
            this.close.TabIndex = 0;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 31;
            this.Result.Location = new System.Drawing.Point(63, 185);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1916, 903);
            this.Result.TabIndex = 2;
            // 
            // Operations
            // 
            this.Operations.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Operations.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.Operations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem});
            this.Operations.Location = new System.Drawing.Point(0, 0);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(2024, 52);
            this.Operations.TabIndex = 3;
            this.Operations.Text = "Operations";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.OpenFile2,
            this.ColPostcardsToolStripMenuItem,
            this.collectorWithMoreThanOneCopyToolStripMenuItem,
            this.sortByYearAscAlphToolStripMenuItem,
            this.removeUnknownYearToolStripMenuItem,
            this.insertToContainerToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(189, 48);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // OpenFile2
            // 
            this.OpenFile2.Name = "OpenFile2";
            this.OpenFile2.Size = new System.Drawing.Size(1034, 54);
            this.OpenFile2.Text = "OpenFile2";
            this.OpenFile2.Click += new System.EventHandler(this.OpenFile2_Click);
            // 
            // ColPostcardsToolStripMenuItem
            // 
            this.ColPostcardsToolStripMenuItem.Name = "ColPostcardsToolStripMenuItem";
            this.ColPostcardsToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.ColPostcardsToolStripMenuItem.Text = "Which Collector has more collored postcards by specific country";
            this.ColPostcardsToolStripMenuItem.Click += new System.EventHandler(this.ColPostcardsToolStripMenuItem_Click);
            // 
            // collectorWithMoreThanOneCopyToolStripMenuItem
            // 
            this.collectorWithMoreThanOneCopyToolStripMenuItem.Name = "collectorWithMoreThanOneCopyToolStripMenuItem";
            this.collectorWithMoreThanOneCopyToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.collectorWithMoreThanOneCopyToolStripMenuItem.Text = "Collector with more than one copy";
            this.collectorWithMoreThanOneCopyToolStripMenuItem.Click += new System.EventHandler(this.collectorWithMoreThanOneCopyToolStripMenuItem_Click);
            // 
            // sortByYearAscAlphToolStripMenuItem
            // 
            this.sortByYearAscAlphToolStripMenuItem.Name = "sortByYearAscAlphToolStripMenuItem";
            this.sortByYearAscAlphToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.sortByYearAscAlphToolStripMenuItem.Text = "Sort by year asc alph";
            this.sortByYearAscAlphToolStripMenuItem.Click += new System.EventHandler(this.sortByYearAscAlphToolStripMenuItem_Click);
            // 
            // removeUnknownYearToolStripMenuItem
            // 
            this.removeUnknownYearToolStripMenuItem.Name = "removeUnknownYearToolStripMenuItem";
            this.removeUnknownYearToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.removeUnknownYearToolStripMenuItem.Text = "Remove unknown year";
            this.removeUnknownYearToolStripMenuItem.Click += new System.EventHandler(this.removeUnknownYearToolStripMenuItem_Click);
            // 
            // insertToContainerToolStripMenuItem
            // 
            this.insertToContainerToolStripMenuItem.Name = "insertToContainerToolStripMenuItem";
            this.insertToContainerToolStripMenuItem.Size = new System.Drawing.Size(1034, 54);
            this.insertToContainerToolStripMenuItem.Text = "Insert to Container";
            this.insertToContainerToolStripMenuItem.Click += new System.EventHandler(this.insertToContainerToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 16);
            this.label.TabIndex = 5;
            this.label.Text = "Country Name";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Operations);
            this.MainMenuStrip = this.Operations;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operations.ResumeLayout(false);
            this.Operations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.MenuStrip Operations;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColPostcardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectorWithMoreThanOneCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByYearAscAlphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToContainerToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem OpenFile2;
        private System.Windows.Forms.ToolStripMenuItem removeUnknownYearToolStripMenuItem;

    }
}

