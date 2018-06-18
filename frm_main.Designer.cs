namespace att_hw
{
    partial class FrmMain
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
            this.BtnRandomize = new System.Windows.Forms.Button();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.NudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudHeight = new System.Windows.Forms.NumericUpDown();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NudWhiteBlackRatio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWhiteBlackRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRandomize
            // 
            this.BtnRandomize.Location = new System.Drawing.Point(641, 9);
            this.BtnRandomize.Name = "BtnRandomize";
            this.BtnRandomize.Size = new System.Drawing.Size(106, 31);
            this.BtnRandomize.TabIndex = 0;
            this.BtnRandomize.Text = "Randomize";
            this.BtnRandomize.UseVisualStyleBackColor = true;
            this.BtnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(865, 9);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(106, 31);
            this.BtnSolve.TabIndex = 1;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Enabled = false;
            this.BtnClear.Location = new System.Drawing.Point(753, 9);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 31);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // PbImage
            // 
            this.PbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImage.Location = new System.Drawing.Point(13, 46);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(1225, 686);
            this.PbImage.TabIndex = 3;
            this.PbImage.TabStop = false;
            // 
            // NudWidth
            // 
            this.NudWidth.Location = new System.Drawing.Point(67, 12);
            this.NudWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudWidth.Name = "NudWidth";
            this.NudWidth.Size = new System.Drawing.Size(82, 22);
            this.NudWidth.TabIndex = 4;
            this.NudWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // NudHeight
            // 
            this.NudHeight.Location = new System.Drawing.Point(226, 12);
            this.NudHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudHeight.Name = "NudHeight";
            this.NudHeight.Size = new System.Drawing.Size(82, 22);
            this.NudHeight.TabIndex = 6;
            this.NudHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(323, 7);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(78, 31);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(978, 10);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 17);
            this.LblRes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "White/Black Ratio";
            // 
            // NudWhiteBlackRatio
            // 
            this.NudWhiteBlackRatio.Location = new System.Drawing.Point(569, 14);
            this.NudWhiteBlackRatio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudWhiteBlackRatio.Name = "NudWhiteBlackRatio";
            this.NudWhiteBlackRatio.Size = new System.Drawing.Size(66, 22);
            this.NudWhiteBlackRatio.TabIndex = 10;
            this.NudWhiteBlackRatio.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 744);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudWhiteBlackRatio);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudWidth);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSolve);
            this.Controls.Add(this.BtnRandomize);
            this.Name = "FrmMain";
            this.Text = "Att HW";
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWhiteBlackRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRandomize;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.NumericUpDown NudWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudHeight;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudWhiteBlackRatio;
    }
}

