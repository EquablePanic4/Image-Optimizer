
namespace CodliImageOptimizer
{
    partial class ImageOptimizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageOptimizer));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AppTabHolder = new System.Windows.Forms.TabControl();
            this.SingleFileOperationsTab = new System.Windows.Forms.TabPage();
            this.OverwriteSingleBox = new System.Windows.Forms.CheckBox();
            this.SingleFileOptimizeBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SingleFileHightBox = new System.Windows.Forms.TextBox();
            this.SingleFileWidthBox = new System.Windows.Forms.TextBox();
            this.SingleFileSizeSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SingleFileQualityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SingleFileQualitySlider = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.singleOutputFormatPng = new System.Windows.Forms.RadioButton();
            this.singleOutputFormatJpg = new System.Windows.Forms.RadioButton();
            this.singleOutputFormatJpeg = new System.Windows.Forms.RadioButton();
            this.ImagePreviewGroup = new System.Windows.Forms.GroupBox();
            this.SingleImagePreview = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.SingleFilePathbox = new System.Windows.Forms.TextBox();
            this.DirectoryOperations = new System.Windows.Forms.TabPage();
            this.CodliProgress = new System.Windows.Forms.ProgressBar();
            this.AppTabHolder.SuspendLayout();
            this.SingleFileOperationsTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleFileSizeSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleFileQualitySlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.ImagePreviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleImagePreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(770, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 27);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(736, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 27);
            this.MinimizeBtn.TabIndex = 0;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.ForeColor = System.Drawing.Color.White;
            this.InfoLabel.Location = new System.Drawing.Point(3, 3);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(158, 15);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Codli Image Optimizer [v1.0]";
            // 
            // AppTabHolder
            // 
            this.AppTabHolder.Controls.Add(this.SingleFileOperationsTab);
            this.AppTabHolder.Controls.Add(this.DirectoryOperations);
            this.AppTabHolder.Location = new System.Drawing.Point(12, 31);
            this.AppTabHolder.Name = "AppTabHolder";
            this.AppTabHolder.SelectedIndex = 0;
            this.AppTabHolder.Size = new System.Drawing.Size(776, 560);
            this.AppTabHolder.TabIndex = 2;
            // 
            // SingleFileOperationsTab
            // 
            this.SingleFileOperationsTab.AllowDrop = true;
            this.SingleFileOperationsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SingleFileOperationsTab.Controls.Add(this.OverwriteSingleBox);
            this.SingleFileOperationsTab.Controls.Add(this.SingleFileOptimizeBtn);
            this.SingleFileOperationsTab.Controls.Add(this.groupBox5);
            this.SingleFileOperationsTab.Controls.Add(this.groupBox2);
            this.SingleFileOperationsTab.Controls.Add(this.ImagePreviewGroup);
            this.SingleFileOperationsTab.Controls.Add(this.groupBox1);
            this.SingleFileOperationsTab.ForeColor = System.Drawing.Color.Black;
            this.SingleFileOperationsTab.Location = new System.Drawing.Point(4, 24);
            this.SingleFileOperationsTab.Name = "SingleFileOperationsTab";
            this.SingleFileOperationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SingleFileOperationsTab.Size = new System.Drawing.Size(768, 532);
            this.SingleFileOperationsTab.TabIndex = 0;
            this.SingleFileOperationsTab.Text = "Single files";
            // 
            // OverwriteSingleBox
            // 
            this.OverwriteSingleBox.AutoSize = true;
            this.OverwriteSingleBox.Location = new System.Drawing.Point(11, 463);
            this.OverwriteSingleBox.Name = "OverwriteSingleBox";
            this.OverwriteSingleBox.Size = new System.Drawing.Size(80, 19);
            this.OverwriteSingleBox.TabIndex = 5;
            this.OverwriteSingleBox.Text = "Overwrite";
            this.OverwriteSingleBox.UseVisualStyleBackColor = true;
            // 
            // SingleFileOptimizeBtn
            // 
            this.SingleFileOptimizeBtn.Location = new System.Drawing.Point(11, 488);
            this.SingleFileOptimizeBtn.Name = "SingleFileOptimizeBtn";
            this.SingleFileOptimizeBtn.Size = new System.Drawing.Size(378, 35);
            this.SingleFileOptimizeBtn.TabIndex = 4;
            this.SingleFileOptimizeBtn.Text = "Start";
            this.SingleFileOptimizeBtn.UseVisualStyleBackColor = true;
            this.SingleFileOptimizeBtn.Click += new System.EventHandler(this.SingleFileOptimizeBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.SingleFileHightBox);
            this.groupBox5.Controls.Add(this.SingleFileWidthBox);
            this.groupBox5.Controls.Add(this.SingleFileSizeSlider);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(4, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 139);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // SingleFileHightBox
            // 
            this.SingleFileHightBox.Enabled = false;
            this.SingleFileHightBox.Location = new System.Drawing.Point(141, 52);
            this.SingleFileHightBox.Name = "SingleFileHightBox";
            this.SingleFileHightBox.Size = new System.Drawing.Size(100, 22);
            this.SingleFileHightBox.TabIndex = 1;
            // 
            // SingleFileWidthBox
            // 
            this.SingleFileWidthBox.Enabled = false;
            this.SingleFileWidthBox.Location = new System.Drawing.Point(14, 52);
            this.SingleFileWidthBox.Name = "SingleFileWidthBox";
            this.SingleFileWidthBox.Size = new System.Drawing.Size(100, 22);
            this.SingleFileWidthBox.TabIndex = 1;
            // 
            // SingleFileSizeSlider
            // 
            this.SingleFileSizeSlider.Enabled = false;
            this.SingleFileSizeSlider.Location = new System.Drawing.Point(7, 88);
            this.SingleFileSizeSlider.Maximum = 100;
            this.SingleFileSizeSlider.Minimum = 1;
            this.SingleFileSizeSlider.Name = "SingleFileSizeSlider";
            this.SingleFileSizeSlider.Size = new System.Drawing.Size(359, 45);
            this.SingleFileSizeSlider.TabIndex = 0;
            this.SingleFileSizeSlider.Value = 100;
            this.SingleFileSizeSlider.Scroll += new System.EventHandler(this.SingleFileSizeSlider_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hight (px)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width (px)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(4, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SingleFileQualityBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.SingleFileQualitySlider);
            this.groupBox4.Location = new System.Drawing.Point(7, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 109);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output quality";
            // 
            // SingleFileQualityBox
            // 
            this.SingleFileQualityBox.Location = new System.Drawing.Point(100, 81);
            this.SingleFileQualityBox.Name = "SingleFileQualityBox";
            this.SingleFileQualityBox.Size = new System.Drawing.Size(100, 22);
            this.SingleFileQualityBox.TabIndex = 2;
            this.SingleFileQualityBox.Text = "60";
            this.SingleFileQualityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SingleFileQualityBox.TextChanged += new System.EventHandler(this.SingleFileQualityBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output quality:";
            // 
            // SingleFileQualitySlider
            // 
            this.SingleFileQualitySlider.Location = new System.Drawing.Point(7, 33);
            this.SingleFileQualitySlider.Maximum = 100;
            this.SingleFileQualitySlider.Minimum = 1;
            this.SingleFileQualitySlider.Name = "SingleFileQualitySlider";
            this.SingleFileQualitySlider.Size = new System.Drawing.Size(359, 45);
            this.SingleFileQualitySlider.TabIndex = 0;
            this.SingleFileQualitySlider.Value = 60;
            this.SingleFileQualitySlider.Scroll += new System.EventHandler(this.SingleFileQualitySlider_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.singleOutputFormatPng);
            this.groupBox3.Controls.Add(this.singleOutputFormatJpg);
            this.groupBox3.Controls.Add(this.singleOutputFormatJpeg);
            this.groupBox3.Location = new System.Drawing.Point(7, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output format";
            // 
            // singleOutputFormatPng
            // 
            this.singleOutputFormatPng.AutoSize = true;
            this.singleOutputFormatPng.Location = new System.Drawing.Point(7, 74);
            this.singleOutputFormatPng.Name = "singleOutputFormatPng";
            this.singleOutputFormatPng.Size = new System.Drawing.Size(50, 19);
            this.singleOutputFormatPng.TabIndex = 2;
            this.singleOutputFormatPng.TabStop = true;
            this.singleOutputFormatPng.Text = "PNG";
            this.singleOutputFormatPng.UseVisualStyleBackColor = true;
            // 
            // singleOutputFormatJpg
            // 
            this.singleOutputFormatJpg.AutoSize = true;
            this.singleOutputFormatJpg.Location = new System.Drawing.Point(7, 48);
            this.singleOutputFormatJpg.Name = "singleOutputFormatJpg";
            this.singleOutputFormatJpg.Size = new System.Drawing.Size(46, 19);
            this.singleOutputFormatJpg.TabIndex = 1;
            this.singleOutputFormatJpg.TabStop = true;
            this.singleOutputFormatJpg.Text = "JPG";
            this.singleOutputFormatJpg.UseVisualStyleBackColor = true;
            // 
            // singleOutputFormatJpeg
            // 
            this.singleOutputFormatJpeg.AutoSize = true;
            this.singleOutputFormatJpeg.Location = new System.Drawing.Point(7, 22);
            this.singleOutputFormatJpeg.Name = "singleOutputFormatJpeg";
            this.singleOutputFormatJpeg.Size = new System.Drawing.Size(53, 19);
            this.singleOutputFormatJpeg.TabIndex = 0;
            this.singleOutputFormatJpeg.TabStop = true;
            this.singleOutputFormatJpeg.Text = "JPEG";
            this.singleOutputFormatJpeg.UseVisualStyleBackColor = true;
            // 
            // ImagePreviewGroup
            // 
            this.ImagePreviewGroup.Controls.Add(this.SingleImagePreview);
            this.ImagePreviewGroup.Location = new System.Drawing.Point(395, 69);
            this.ImagePreviewGroup.Name = "ImagePreviewGroup";
            this.ImagePreviewGroup.Size = new System.Drawing.Size(370, 460);
            this.ImagePreviewGroup.TabIndex = 1;
            this.ImagePreviewGroup.TabStop = false;
            this.ImagePreviewGroup.Text = "Image preview";
            // 
            // SingleImagePreview
            // 
            this.SingleImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("SingleImagePreview.Image")));
            this.SingleImagePreview.InitialImage = ((System.Drawing.Image)(resources.GetObject("SingleImagePreview.InitialImage")));
            this.SingleImagePreview.Location = new System.Drawing.Point(6, 21);
            this.SingleImagePreview.Name = "SingleImagePreview";
            this.SingleImagePreview.Size = new System.Drawing.Size(358, 433);
            this.SingleImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SingleImagePreview.TabIndex = 0;
            this.SingleImagePreview.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChooseFile);
            this.groupBox1.Controls.Add(this.SingleFilePathbox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose file";
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(716, 22);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(39, 23);
            this.ChooseFile.TabIndex = 1;
            this.ChooseFile.Text = "...";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // SingleFilePathbox
            // 
            this.SingleFilePathbox.Enabled = false;
            this.SingleFilePathbox.Location = new System.Drawing.Point(7, 22);
            this.SingleFilePathbox.Name = "SingleFilePathbox";
            this.SingleFilePathbox.Size = new System.Drawing.Size(703, 22);
            this.SingleFilePathbox.TabIndex = 0;
            this.SingleFilePathbox.Text = "You can also use drag & drop";
            // 
            // DirectoryOperations
            // 
            this.DirectoryOperations.Location = new System.Drawing.Point(4, 24);
            this.DirectoryOperations.Name = "DirectoryOperations";
            this.DirectoryOperations.Padding = new System.Windows.Forms.Padding(3);
            this.DirectoryOperations.Size = new System.Drawing.Size(768, 532);
            this.DirectoryOperations.TabIndex = 1;
            this.DirectoryOperations.Text = "Directories";
            this.DirectoryOperations.UseVisualStyleBackColor = true;
            // 
            // CodliProgress
            // 
            this.CodliProgress.Location = new System.Drawing.Point(12, 597);
            this.CodliProgress.Name = "CodliProgress";
            this.CodliProgress.Size = new System.Drawing.Size(777, 23);
            this.CodliProgress.TabIndex = 3;
            // 
            // ImageOptimizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.ControlBox = false;
            this.Controls.Add(this.CodliProgress);
            this.Controls.Add(this.AppTabHolder);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageOptimizer";
            this.Text = "Codli Image Optimizer [v1.0]";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageOptimizer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageOptimizer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageOptimizer_MouseUp);
            this.AppTabHolder.ResumeLayout(false);
            this.SingleFileOperationsTab.ResumeLayout(false);
            this.SingleFileOperationsTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleFileSizeSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleFileQualitySlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ImagePreviewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SingleImagePreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TabControl AppTabHolder;
        private System.Windows.Forms.TabPage SingleFileOperationsTab;
        private System.Windows.Forms.TabPage DirectoryOperations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.TextBox SingleFilePathbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton singleOutputFormatPng;
        private System.Windows.Forms.RadioButton singleOutputFormatJpg;
        private System.Windows.Forms.RadioButton singleOutputFormatJpeg;
        private System.Windows.Forms.GroupBox ImagePreviewGroup;
        private System.Windows.Forms.PictureBox SingleImagePreview;
        private System.Windows.Forms.ProgressBar CodliProgress;
        private System.Windows.Forms.CheckBox OverwriteSingleBox;
        private System.Windows.Forms.Button SingleFileOptimizeBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SingleFileHightBox;
        private System.Windows.Forms.TextBox SingleFileWidthBox;
        private System.Windows.Forms.TrackBar SingleFileSizeSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SingleFileQualityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SingleFileQualitySlider;
    }
}

