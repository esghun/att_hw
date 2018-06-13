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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudHeight = new System.Windows.Forms.NumericUpDown();
            this.BtnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRandomize
            // 
            this.BtnRandomize.Location = new System.Drawing.Point(285, 12);
            this.BtnRandomize.Name = "BtnRandomize";
            this.BtnRandomize.Size = new System.Drawing.Size(106, 50);
            this.BtnRandomize.TabIndex = 0;
            this.BtnRandomize.Text = "Randomize";
            this.BtnRandomize.UseVisualStyleBackColor = true;
            this.BtnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(509, 12);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(106, 50);
            this.BtnSolve.TabIndex = 1;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Enabled = false;
            this.BtnClear.Location = new System.Drawing.Point(397, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 50);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 464);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // NudHeight
            // 
            this.NudHeight.Location = new System.Drawing.Point(67, 40);
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
            this.BtnCreate.Location = new System.Drawing.Point(155, 12);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(78, 50);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 544);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudWidth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSolve);
            this.Controls.Add(this.BtnRandomize);
            this.Name = "FrmMain";
            this.Text = "Att HW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRandomize;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NudWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudHeight;
        private System.Windows.Forms.Button BtnCreate;
    }
}

