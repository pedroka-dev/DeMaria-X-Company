﻿namespace X_Company.View
{
    partial class SaleUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleUpdateForm));
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            productComboBox = new ComboBox();
            label2 = new Label();
            panel4 = new Panel();
            quantityNumericUpDown = new NumericUpDown();
            label4 = new Label();
            panel5 = new Panel();
            clientComboBox = new ComboBox();
            label3 = new Label();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 112);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(701, 58);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Edit Sale ";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(submitButton, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 170);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(701, 533);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(productComboBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(108, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 100);
            panel1.TabIndex = 0;
            // 
            // productComboBox
            // 
            productComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productComboBox.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(0, 30);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(484, 40);
            productComboBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(130, 33);
            label2.TabIndex = 0;
            label2.Text = "Product:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(quantityNumericUpDown);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(108, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 100);
            panel4.TabIndex = 2;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityNumericUpDown.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityNumericUpDown.Location = new Point(0, 31);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(484, 39);
            quantityNumericUpDown.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(138, 33);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(clientComboBox);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(108, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(484, 100);
            panel5.TabIndex = 1;
            // 
            // clientComboBox
            // 
            clientComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientComboBox.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(0, 31);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(484, 40);
            clientComboBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(93, 33);
            label3.TabIndex = 3;
            label3.Text = "Client";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            submitButton.BackColor = Color.Black;
            submitButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(255, 439);
            submitButton.Margin = new Padding(150, 15, 150, 15);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(190, 79);
            submitButton.TabIndex = 3;
            submitButton.Text = "✔️ Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            // 
            // SaleUpdateForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(701, 703);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SaleUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company X - Edit Sale";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Button submitButton;
        private Panel panel1;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private NumericUpDown quantityNumericUpDown;
        private ComboBox clientComboBox;
        private ComboBox productComboBox;
    }
}