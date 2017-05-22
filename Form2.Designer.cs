namespace hamsterAAA
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeUpDown = new System.Windows.Forms.NumericUpDown();
            this.clicksUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicksUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.activeUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.clicksUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sizeBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Board size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 58);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of clicks to end:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of active buttons:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activeUpDown
            // 
            this.activeUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeUpDown.Location = new System.Drawing.Point(232, 75);
            this.activeUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.activeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.activeUpDown.Name = "activeUpDown";
            this.activeUpDown.Size = new System.Drawing.Size(192, 26);
            this.activeUpDown.TabIndex = 4;
            this.activeUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // clicksUpDown
            // 
            this.clicksUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clicksUpDown.Location = new System.Drawing.Point(233, 134);
            this.clicksUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clicksUpDown.Name = "clicksUpDown";
            this.clicksUpDown.Size = new System.Drawing.Size(190, 26);
            this.clicksUpDown.TabIndex = 5;
            this.clicksUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // sizeBox
            // 
            this.sizeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "4 x 4",
            "6 x 6",
            "8 x 8"});
            this.sizeBox.Location = new System.Drawing.Point(232, 15);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(193, 28);
            this.sizeBox.TabIndex = 6;
            this.sizeBox.Tag = "";
            this.sizeBox.Text = "4 x 4";
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(324, 190);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(111, 42);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(207, 190);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 42);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(448, 244);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicksUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown activeUpDown;
        private System.Windows.Forms.NumericUpDown clicksUpDown;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
    }
}