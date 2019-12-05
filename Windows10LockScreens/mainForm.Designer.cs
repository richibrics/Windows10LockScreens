namespace Windows10LockScreens
{
    partial class mainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBtn = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.filesList = new System.Windows.Forms.ListView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.widthMinResolutionBox = new System.Windows.Forms.NumericUpDown();
            this.heightMinResolutionBox = new System.Windows.Forms.NumericUpDown();
            this.filterBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthMinResolutionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightMinResolutionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(963, 521);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save as..";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPictureBox.Location = new System.Drawing.Point(312, 7);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(751, 506);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 1;
            this.previewPictureBox.TabStop = false;
            // 
            // filesList
            // 
            this.filesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filesList.HideSelection = false;
            this.filesList.Location = new System.Drawing.Point(9, 7);
            this.filesList.Margin = new System.Windows.Forms.Padding(4);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(293, 541);
            this.filesList.TabIndex = 2;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.View = System.Windows.Forms.View.Tile;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileName = "Backgroud";
            this.saveFileDialog1.Filter = "Immagine JPG|*.jpg|Tutti i file|*.*";
            this.saveFileDialog1.Title = "Save Wallpaper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mininum Resolution (WxH - px): ";
            // 
            // widthMinResolutionBox
            // 
            this.widthMinResolutionBox.Enabled = false;
            this.widthMinResolutionBox.Location = new System.Drawing.Point(519, 522);
            this.widthMinResolutionBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.widthMinResolutionBox.Name = "widthMinResolutionBox";
            this.widthMinResolutionBox.Size = new System.Drawing.Size(67, 22);
            this.widthMinResolutionBox.TabIndex = 4;
            this.widthMinResolutionBox.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.widthMinResolutionBox.ValueChanged += new System.EventHandler(this.widthMinResolutionBox_ValueChanged);
            // 
            // heightMinResolutionBox
            // 
            this.heightMinResolutionBox.Enabled = false;
            this.heightMinResolutionBox.Location = new System.Drawing.Point(592, 522);
            this.heightMinResolutionBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.heightMinResolutionBox.Name = "heightMinResolutionBox";
            this.heightMinResolutionBox.Size = new System.Drawing.Size(67, 22);
            this.heightMinResolutionBox.TabIndex = 5;
            this.heightMinResolutionBox.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.heightMinResolutionBox.ValueChanged += new System.EventHandler(this.heightMinResolutionBox_ValueChanged);
            // 
            // filterBox
            // 
            this.filterBox.AutoSize = true;
            this.filterBox.Location = new System.Drawing.Point(673, 523);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(90, 21);
            this.filterBox.TabIndex = 6;
            this.filterBox.Text = "Use Filter";
            this.filterBox.UseVisualStyleBackColor = true;
            this.filterBox.CheckedChanged += new System.EventHandler(this.filterBox_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.heightMinResolutionBox);
            this.Controls.Add(this.widthMinResolutionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.previewPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(661, 481);
            this.Name = "mainForm";
            this.Text = "Windows10LockScreen";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthMinResolutionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightMinResolutionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthMinResolutionBox;
        private System.Windows.Forms.NumericUpDown heightMinResolutionBox;
        private System.Windows.Forms.CheckBox filterBox;
    }
}

