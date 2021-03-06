﻿namespace MineEdit
{
    partial class dlgReplace
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
            this.tabModes = new System.Windows.Forms.TabControl();
            this.tabBlocks = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadBlockReplacement = new System.Windows.Forms.ToolStripButton();
            this.blkReplace = new MineEdit.BlockSelector();
            this.blkWith = new MineEdit.BlockSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.Replacements = new System.Windows.Forms.ListBox();
            this.tsbSaveBlockReplacement = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radAllChunks = new System.Windows.Forms.RadioButton();
            this.radSingleChunk = new System.Windows.Forms.RadioButton();
            this.numBlkCX = new System.Windows.Forms.NumericUpDown();
            this.numBlkCY = new System.Windows.Forms.NumericUpDown();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.numAreaX = new System.Windows.Forms.NumericUpDown();
            this.numAreaY = new System.Windows.Forms.NumericUpDown();
            this.numAreaZ = new System.Windows.Forms.NumericUpDown();
            this.numBlkEndX = new System.Windows.Forms.NumericUpDown();
            this.numBlkEndY = new System.Windows.Forms.NumericUpDown();
            this.numBlkEndZ = new System.Windows.Forms.NumericUpDown();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.tabModes.SuspendLayout();
            this.tabBlocks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkCY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndZ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabModes
            // 
            this.tabModes.Controls.Add(this.tabBlocks);
            this.tabModes.Controls.Add(this.tabPage2);
            this.tabModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModes.Location = new System.Drawing.Point(0, 0);
            this.tabModes.Name = "tabModes";
            this.tabModes.SelectedIndex = 0;
            this.tabModes.Size = new System.Drawing.Size(640, 385);
            this.tabModes.TabIndex = 0;
            // 
            // tabBlocks
            // 
            this.tabBlocks.Controls.Add(this.groupBox3);
            this.tabBlocks.Controls.Add(this.toolStrip1);
            this.tabBlocks.Controls.Add(this.groupBox2);
            this.tabBlocks.Controls.Add(this.groupBox1);
            this.tabBlocks.Location = new System.Drawing.Point(4, 22);
            this.tabBlocks.Name = "tabBlocks";
            this.tabBlocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlocks.Size = new System.Drawing.Size(632, 359);
            this.tabBlocks.TabIndex = 0;
            this.tabBlocks.Text = "Blocks";
            this.tabBlocks.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdOK);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 54);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Controls.Add(this.blkWith);
            this.groupBox1.Controls.Add(this.blkReplace);
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace Blocks";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsbLoadBlockReplacement,
            this.tsbSaveBlockReplacement});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.toolStripLabel1.Text = "Templates";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadBlockReplacement
            // 
            this.tsbLoadBlockReplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadBlockReplacement.Image = global::MineEdit.Properties.Resources.document_open;
            this.tsbLoadBlockReplacement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadBlockReplacement.Name = "tsbLoadBlockReplacement";
            this.tsbLoadBlockReplacement.Size = new System.Drawing.Size(23, 22);
            this.tsbLoadBlockReplacement.Text = "toolStripButton1";
            // 
            // blkReplace
            // 
            this.blkReplace.BlocksOnly = false;
            this.blkReplace.DisplayMember = "Name";
            this.blkReplace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.blkReplace.FormattingEnabled = true;
            this.blkReplace.Location = new System.Drawing.Point(74, 18);
            this.blkReplace.Name = "blkReplace";
            this.blkReplace.Size = new System.Drawing.Size(236, 21);
            this.blkReplace.TabIndex = 0;
            this.blkReplace.ValueMember = "ID";
            // 
            // blkWith
            // 
            this.blkWith.BlocksOnly = false;
            this.blkWith.DisplayMember = "Name";
            this.blkWith.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.blkWith.FormattingEnabled = true;
            this.blkWith.Location = new System.Drawing.Point(74, 45);
            this.blkWith.Name = "blkWith";
            this.blkWith.Size = new System.Drawing.Size(236, 21);
            this.blkWith.TabIndex = 0;
            this.blkWith.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "With:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdClear);
            this.groupBox2.Controls.Add(this.cmdRemove);
            this.groupBox2.Controls.Add(this.Replacements);
            this.groupBox2.Location = new System.Drawing.Point(337, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacements";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(210, 48);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(210, 19);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(75, 23);
            this.cmdRemove.TabIndex = 5;
            this.cmdRemove.Text = "Remove";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(235, 72);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // Replacements
            // 
            this.Replacements.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Replacements.Location = new System.Drawing.Point(6, 19);
            this.Replacements.Name = "Replacements";
            this.Replacements.Size = new System.Drawing.Size(198, 82);
            this.Replacements.TabIndex = 2;
            this.Replacements.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Replacements_DrawItem);
            // 
            // tsbSaveBlockReplacement
            // 
            this.tsbSaveBlockReplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveBlockReplacement.Image = global::MineEdit.Properties.Resources.document_save;
            this.tsbSaveBlockReplacement.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbSaveBlockReplacement.Name = "tsbSaveBlockReplacement";
            this.tsbSaveBlockReplacement.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveBlockReplacement.Text = "toolStripButton1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numBlkEndZ);
            this.groupBox3.Controls.Add(this.numAreaZ);
            this.groupBox3.Controls.Add(this.numBlkEndY);
            this.groupBox3.Controls.Add(this.numBlkEndX);
            this.groupBox3.Controls.Add(this.numAreaY);
            this.groupBox3.Controls.Add(this.numAreaX);
            this.groupBox3.Controls.Add(this.radArea);
            this.groupBox3.Controls.Add(this.numBlkCY);
            this.groupBox3.Controls.Add(this.numBlkCX);
            this.groupBox3.Controls.Add(this.radSingleChunk);
            this.groupBox3.Controls.Add(this.radAllChunks);
            this.groupBox3.Location = new System.Drawing.Point(8, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement Options";
            // 
            // radAllChunks
            // 
            this.radAllChunks.AutoSize = true;
            this.radAllChunks.Checked = true;
            this.radAllChunks.Location = new System.Drawing.Point(21, 19);
            this.radAllChunks.Name = "radAllChunks";
            this.radAllChunks.Size = new System.Drawing.Size(75, 17);
            this.radAllChunks.TabIndex = 0;
            this.radAllChunks.TabStop = true;
            this.radAllChunks.Text = "All Chunks";
            this.radAllChunks.UseVisualStyleBackColor = true;
            this.radAllChunks.CheckedChanged += new System.EventHandler(this.radAllChunks_CheckedChanged);
            // 
            // radSingleChunk
            // 
            this.radSingleChunk.AutoSize = true;
            this.radSingleChunk.Location = new System.Drawing.Point(21, 42);
            this.radSingleChunk.Name = "radSingleChunk";
            this.radSingleChunk.Size = new System.Drawing.Size(82, 17);
            this.radSingleChunk.TabIndex = 1;
            this.radSingleChunk.Text = "One Chunk:";
            this.radSingleChunk.UseVisualStyleBackColor = true;
            // 
            // numBlkCX
            // 
            this.numBlkCX.Location = new System.Drawing.Point(109, 42);
            this.numBlkCX.Name = "numBlkCX";
            this.numBlkCX.Size = new System.Drawing.Size(58, 20);
            this.numBlkCX.TabIndex = 2;
            // 
            // numBlkCY
            // 
            this.numBlkCY.Location = new System.Drawing.Point(173, 42);
            this.numBlkCY.Name = "numBlkCY";
            this.numBlkCY.Size = new System.Drawing.Size(58, 20);
            this.numBlkCY.TabIndex = 2;
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(21, 65);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(50, 17);
            this.radArea.TabIndex = 3;
            this.radArea.Text = "Area:";
            this.radArea.UseVisualStyleBackColor = true;
            // 
            // numAreaX
            // 
            this.numAreaX.Location = new System.Drawing.Point(109, 68);
            this.numAreaX.Name = "numAreaX";
            this.numAreaX.Size = new System.Drawing.Size(58, 20);
            this.numAreaX.TabIndex = 4;
            // 
            // numAreaY
            // 
            this.numAreaY.Location = new System.Drawing.Point(173, 68);
            this.numAreaY.Name = "numAreaY";
            this.numAreaY.Size = new System.Drawing.Size(58, 20);
            this.numAreaY.TabIndex = 4;
            // 
            // numAreaZ
            // 
            this.numAreaZ.Location = new System.Drawing.Point(237, 68);
            this.numAreaZ.Name = "numAreaZ";
            this.numAreaZ.Size = new System.Drawing.Size(58, 20);
            this.numAreaZ.TabIndex = 4;
            // 
            // numBlkEndX
            // 
            this.numBlkEndX.Location = new System.Drawing.Point(109, 94);
            this.numBlkEndX.Name = "numBlkEndX";
            this.numBlkEndX.Size = new System.Drawing.Size(58, 20);
            this.numBlkEndX.TabIndex = 4;
            // 
            // numBlkEndY
            // 
            this.numBlkEndY.Location = new System.Drawing.Point(173, 94);
            this.numBlkEndY.Name = "numBlkEndY";
            this.numBlkEndY.Size = new System.Drawing.Size(58, 20);
            this.numBlkEndY.TabIndex = 4;
            // 
            // numBlkEndZ
            // 
            this.numBlkEndZ.Location = new System.Drawing.Point(237, 94);
            this.numBlkEndZ.Name = "numBlkEndZ";
            this.numBlkEndZ.Size = new System.Drawing.Size(58, 20);
            this.numBlkEndZ.TabIndex = 4;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(558, 19);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(477, 19);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // dlgReplace
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(640, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabModes);
            this.Name = "dlgReplace";
            this.Text = "Replace Stuff";
            this.tabModes.ResumeLayout(false);
            this.tabBlocks.ResumeLayout(false);
            this.tabBlocks.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkCY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAreaZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlkEndZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabModes;
        private System.Windows.Forms.TabPage tabBlocks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadBlockReplacement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BlockSelector blkWith;
        private BlockSelector blkReplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ListBox Replacements;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numBlkEndZ;
        private System.Windows.Forms.NumericUpDown numAreaZ;
        private System.Windows.Forms.NumericUpDown numBlkEndY;
        private System.Windows.Forms.NumericUpDown numBlkEndX;
        private System.Windows.Forms.NumericUpDown numAreaY;
        private System.Windows.Forms.NumericUpDown numAreaX;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.NumericUpDown numBlkCY;
        private System.Windows.Forms.NumericUpDown numBlkCX;
        private System.Windows.Forms.RadioButton radSingleChunk;
        private System.Windows.Forms.RadioButton radAllChunks;
        private System.Windows.Forms.ToolStripButton tsbSaveBlockReplacement;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
    }
}