namespace ReturnDirNames
{
    partial class ReturnDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnDir));
            this.BtnSelectFolder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSaveFile = new Guna.UI2.WinForms.Guna2Button();
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.BtnButtonBackground = new Guna.UI2.WinForms.Guna2Button();
            this.LabelModifiers = new System.Windows.Forms.Label();
            this.LabelSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.AccessibleName = "BtnSelectFolder";
            this.BtnSelectFolder.Animated = true;
            this.BtnSelectFolder.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.BtnSelectFolder.BorderRadius = 8;
            this.BtnSelectFolder.BorderThickness = 1;
            this.BtnSelectFolder.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSelectFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSelectFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.BtnSelectFolder.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.BtnSelectFolder.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.BtnSelectFolder.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSelectFolder.Location = new System.Drawing.Point(20, 20);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(182, 45);
            this.BtnSelectFolder.TabIndex = 10;
            this.BtnSelectFolder.Text = "Select Folder";
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            this.BtnSelectFolder.Enter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSelectFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyDown);
            this.BtnSelectFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyUp);
            this.BtnSelectFolder.MouseEnter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSelectFolder.MouseLeave += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSelectFolder.MouseHover += new System.EventHandler(this.ReturnDir_Enter);
            // 
            // BtnSaveFile
            // 
            this.BtnSaveFile.AccessibleName = "BtnSaveFile";
            this.BtnSaveFile.Animated = true;
            this.BtnSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.BtnSaveFile.BorderRadius = 8;
            this.BtnSaveFile.BorderThickness = 1;
            this.BtnSaveFile.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSaveFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSaveFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSaveFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSaveFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.BtnSaveFile.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSaveFile.ForeColor = System.Drawing.Color.White;
            this.BtnSaveFile.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.BtnSaveFile.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSaveFile.Location = new System.Drawing.Point(20, 75);
            this.BtnSaveFile.Name = "BtnSaveFile";
            this.BtnSaveFile.Size = new System.Drawing.Size(182, 45);
            this.BtnSaveFile.TabIndex = 10;
            this.BtnSaveFile.Text = "Save to File";
            this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            this.BtnSaveFile.Enter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSaveFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyDown);
            this.BtnSaveFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyUp);
            this.BtnSaveFile.MouseEnter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSaveFile.MouseLeave += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnSaveFile.MouseHover += new System.EventHandler(this.ReturnDir_Enter);
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.AccessibleName = "ListBoxFiles";
            this.ListBoxFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ListBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxFiles.ForeColor = System.Drawing.Color.White;
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.Location = new System.Drawing.Point(223, 10);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxFiles.Size = new System.Drawing.Size(509, 119);
            this.ListBoxFiles.TabIndex = 18;
            this.ListBoxFiles.Enter += new System.EventHandler(this.ReturnDir_Enter);
            this.ListBoxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyDown);
            this.ListBoxFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyUp);
            this.ListBoxFiles.MouseEnter += new System.EventHandler(this.ReturnDir_Enter);
            this.ListBoxFiles.MouseLeave += new System.EventHandler(this.ReturnDir_Enter);
            this.ListBoxFiles.MouseHover += new System.EventHandler(this.ReturnDir_Enter);
            // 
            // BtnButtonBackground
            // 
            this.BtnButtonBackground.AccessibleName = "BtnButtonBackground";
            this.BtnButtonBackground.BackColor = System.Drawing.Color.Transparent;
            this.BtnButtonBackground.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.BtnButtonBackground.BorderRadius = 8;
            this.BtnButtonBackground.BorderThickness = 1;
            this.BtnButtonBackground.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.BtnButtonBackground.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnButtonBackground.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.BtnButtonBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnButtonBackground.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnButtonBackground.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnButtonBackground.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnButtonBackground.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnButtonBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnButtonBackground.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnButtonBackground.ForeColor = System.Drawing.Color.White;
            this.BtnButtonBackground.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.BtnButtonBackground.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.BtnButtonBackground.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnButtonBackground.Location = new System.Drawing.Point(10, 10);
            this.BtnButtonBackground.Name = "BtnButtonBackground";
            this.BtnButtonBackground.Size = new System.Drawing.Size(200, 120);
            this.BtnButtonBackground.TabIndex = 19;
            this.BtnButtonBackground.TabStop = false;
            this.BtnButtonBackground.Enter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnButtonBackground.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyDown);
            this.BtnButtonBackground.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyUp);
            this.BtnButtonBackground.MouseEnter += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnButtonBackground.MouseLeave += new System.EventHandler(this.ReturnDir_Enter);
            this.BtnButtonBackground.MouseHover += new System.EventHandler(this.ReturnDir_Enter);
            // 
            // LabelModifiers
            // 
            this.LabelModifiers.AccessibleName = "LabelModifiers";
            this.LabelModifiers.AutoSize = true;
            this.LabelModifiers.BackColor = System.Drawing.Color.Transparent;
            this.LabelModifiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelModifiers.ForeColor = System.Drawing.Color.White;
            this.LabelModifiers.Location = new System.Drawing.Point(46, 2);
            this.LabelModifiers.Name = "LabelModifiers";
            this.LabelModifiers.Size = new System.Drawing.Size(130, 15);
            this.LabelModifiers.TabIndex = 20;
            this.LabelModifiers.Text = "Hold Control For Modifiers";
            // 
            // LabelSelected
            // 
            this.LabelSelected.AccessibleName = "LabelSelected";
            this.LabelSelected.AutoSize = true;
            this.LabelSelected.BackColor = System.Drawing.Color.Transparent;
            this.LabelSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSelected.ForeColor = System.Drawing.Color.White;
            this.LabelSelected.Location = new System.Drawing.Point(556, 2);
            this.LabelSelected.Name = "LabelSelected";
            this.LabelSelected.Size = new System.Drawing.Size(184, 15);
            this.LabelSelected.TabIndex = 20;
            this.LabelSelected.Text = "You can select specific items to save";
            // 
            // ReturnDir
            // 
            this.AccessibleName = "ReturnDir";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(742, 140);
            this.Controls.Add(this.LabelSelected);
            this.Controls.Add(this.LabelModifiers);
            this.Controls.Add(this.BtnSaveFile);
            this.Controls.Add(this.ListBoxFiles);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.BtnButtonBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnDir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnDir";
            this.Enter += new System.EventHandler(this.ReturnDir_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReturnDir_KeyUp);
            this.MouseEnter += new System.EventHandler(this.ReturnDir_Enter);
            this.MouseLeave += new System.EventHandler(this.ReturnDir_Enter);
            this.MouseHover += new System.EventHandler(this.ReturnDir_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnSelectFolder;
        private Guna.UI2.WinForms.Guna2Button BtnSaveFile;
        private System.Windows.Forms.ListBox ListBoxFiles;
        private Guna.UI2.WinForms.Guna2Button BtnButtonBackground;
        private System.Windows.Forms.Label LabelModifiers;
        private System.Windows.Forms.Label LabelSelected;
    }
}

