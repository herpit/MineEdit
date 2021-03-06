﻿namespace MineEdit
{
    partial class dlgTerrainGen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHellMode = new System.Windows.Forms.CheckBox();
            this.chkTrees = new System.Windows.Forms.CheckBox();
            this.chkDungeons = new System.Windows.Forms.CheckBox();
            this.chkGenOres = new System.Windows.Forms.CheckBox();
            this.chkGenWater = new System.Windows.Forms.CheckBox();
            this.chkCaves = new System.Windows.Forms.CheckBox();
            this.chkRegen = new System.Windows.Forms.CheckBox();
            this.pgMapGen = new System.Windows.Forms.PropertyGrid();
            this.cmbMapGenSel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHellMode);
            this.groupBox1.Controls.Add(this.chkTrees);
            this.groupBox1.Controls.Add(this.chkDungeons);
            this.groupBox1.Controls.Add(this.chkGenOres);
            this.groupBox1.Controls.Add(this.chkGenWater);
            this.groupBox1.Controls.Add(this.chkCaves);
            this.groupBox1.Controls.Add(this.chkRegen);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common Settings";
            // 
            // chkHellMode
            // 
            this.chkHellMode.AutoSize = true;
            this.chkHellMode.Enabled = false;
            this.chkHellMode.Location = new System.Drawing.Point(6, 196);
            this.chkHellMode.Name = "chkHellMode";
            this.chkHellMode.Size = new System.Drawing.Size(74, 17);
            this.chkHellMode.TabIndex = 6;
            this.chkHellMode.Text = "Hell Mode";
            this.chkHellMode.UseVisualStyleBackColor = true;
            this.chkHellMode.CheckedChanged += new System.EventHandler(this.chkHellMode_CheckedChanged);
            // 
            // chkTrees
            // 
            this.chkTrees.AutoSize = true;
            this.chkTrees.Enabled = false;
            this.chkTrees.Location = new System.Drawing.Point(6, 173);
            this.chkTrees.Name = "chkTrees";
            this.chkTrees.Size = new System.Drawing.Size(75, 17);
            this.chkTrees.TabIndex = 5;
            this.chkTrees.Text = "Add Trees";
            this.chkTrees.UseVisualStyleBackColor = true;
            this.chkTrees.CheckedChanged += new System.EventHandler(this.chkTrees_CheckedChanged);
            // 
            // chkDungeons
            // 
            this.chkDungeons.AutoSize = true;
            this.chkDungeons.Enabled = false;
            this.chkDungeons.Location = new System.Drawing.Point(6, 150);
            this.chkDungeons.Name = "chkDungeons";
            this.chkDungeons.Size = new System.Drawing.Size(122, 17);
            this.chkDungeons.TabIndex = 4;
            this.chkDungeons.Text = "Generate Dungeons";
            this.chkDungeons.UseVisualStyleBackColor = true;
            this.chkDungeons.CheckedChanged += new System.EventHandler(this.chkDungeons_CheckedChanged);
            // 
            // chkGenOres
            // 
            this.chkGenOres.AutoSize = true;
            this.chkGenOres.Enabled = false;
            this.chkGenOres.Location = new System.Drawing.Point(6, 127);
            this.chkGenOres.Name = "chkGenOres";
            this.chkGenOres.Size = new System.Drawing.Size(135, 17);
            this.chkGenOres.TabIndex = 3;
            this.chkGenOres.Text = "Generate Ores/Springs";
            this.chkGenOres.UseVisualStyleBackColor = true;
            this.chkGenOres.CheckedChanged += new System.EventHandler(this.chkGenOres_CheckedChanged);
            // 
            // chkGenWater
            // 
            this.chkGenWater.AutoSize = true;
            this.chkGenWater.Enabled = false;
            this.chkGenWater.Location = new System.Drawing.Point(6, 65);
            this.chkGenWater.Name = "chkGenWater";
            this.chkGenWater.Size = new System.Drawing.Size(194, 56);
            this.chkGenWater.TabIndex = 2;
            this.chkGenWater.Text = "Generate Water\r\n\r\n(Will still add random springs unless \r\n\"Generate Ores\" is unch" +
                "ecked)";
            this.chkGenWater.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkGenWater.UseVisualStyleBackColor = true;
            this.chkGenWater.CheckedChanged += new System.EventHandler(this.chkGenWater_CheckedChanged);
            // 
            // chkCaves
            // 
            this.chkCaves.AutoSize = true;
            this.chkCaves.Enabled = false;
            this.chkCaves.Location = new System.Drawing.Point(6, 42);
            this.chkCaves.Name = "chkCaves";
            this.chkCaves.Size = new System.Drawing.Size(103, 17);
            this.chkCaves.TabIndex = 1;
            this.chkCaves.Text = "Generate Caves";
            this.chkCaves.UseVisualStyleBackColor = true;
            this.chkCaves.CheckedChanged += new System.EventHandler(this.chkCaves_CheckedChanged);
            // 
            // chkRegen
            // 
            this.chkRegen.AutoSize = true;
            this.chkRegen.Enabled = false;
            this.chkRegen.Location = new System.Drawing.Point(6, 19);
            this.chkRegen.Name = "chkRegen";
            this.chkRegen.Size = new System.Drawing.Size(158, 17);
            this.chkRegen.TabIndex = 0;
            this.chkRegen.Text = "Regenerate EVERYTHING.";
            this.chkRegen.UseVisualStyleBackColor = true;
            this.chkRegen.CheckedChanged += new System.EventHandler(this.chkRegen_CheckedChanged);
            // 
            // pgMapGen
            // 
            this.pgMapGen.Location = new System.Drawing.Point(294, 73);
            this.pgMapGen.Name = "pgMapGen";
            this.pgMapGen.Size = new System.Drawing.Size(370, 313);
            this.pgMapGen.TabIndex = 2;
            // 
            // cmbMapGenSel
            // 
            this.cmbMapGenSel.FormattingEnabled = true;
            this.cmbMapGenSel.Location = new System.Drawing.Point(12, 73);
            this.cmbMapGenSel.Name = "cmbMapGenSel";
            this.cmbMapGenSel.Size = new System.Drawing.Size(276, 21);
            this.cmbMapGenSel.TabIndex = 3;
            this.cmbMapGenSel.SelectedIndexChanged += new System.EventHandler(this.cmbMapGenSel_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 67);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MineEdit.Properties.Resources.Terragen_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create your own terrain.  Fight the power etc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terrain Generation Setup";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(589, 407);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(508, 407);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // dlgTerrainGen
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(676, 442);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmbMapGenSel);
            this.Controls.Add(this.pgMapGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgTerrainGen";
            this.ShowIcon = false;
            this.Text = "Terrain Generation Setup";
            this.Load += new System.EventHandler(this.dlgTerrainGen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHellMode;
        private System.Windows.Forms.CheckBox chkTrees;
        private System.Windows.Forms.CheckBox chkDungeons;
        private System.Windows.Forms.CheckBox chkGenOres;
        private System.Windows.Forms.CheckBox chkGenWater;
        private System.Windows.Forms.CheckBox chkCaves;
        private System.Windows.Forms.CheckBox chkRegen;
        private System.Windows.Forms.ComboBox cmbMapGenSel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        public System.Windows.Forms.PropertyGrid pgMapGen;

    }
}