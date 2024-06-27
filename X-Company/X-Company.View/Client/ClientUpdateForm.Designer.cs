namespace X_Company.View
{
    partial class ClientUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUpdateForm));
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            nameTextBox = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            emailTextBox = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            phoneTextBox = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            addressTextBox = new TextBox();
            label3 = new Label();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            titleLabel.Text = "Edit Client ";
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
            tableLayoutPanel1.Controls.Add(panel3, 1, 3);
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
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(108, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 100);
            panel1.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(0, 33);
            nameTextBox.MaxLength = 250;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(484, 39);
            nameTextBox.TabIndex = 0;
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
            label2.Size = new Size(103, 33);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(emailTextBox);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(108, 321);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 100);
            panel3.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(0, 31);
            emailTextBox.MaxLength = 250;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(484, 39);
            emailTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(102, 33);
            label5.TabIndex = 5;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(phoneTextBox);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(108, 215);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 100);
            panel4.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneTextBox.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneTextBox.Location = new Point(0, 31);
            phoneTextBox.MaxLength = 250;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(484, 39);
            phoneTextBox.TabIndex = 5;
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
            label4.Size = new Size(100, 33);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(addressTextBox);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(108, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(484, 100);
            panel5.TabIndex = 1;
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressTextBox.Location = new Point(0, 33);
            addressTextBox.MaxLength = 250;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(484, 39);
            addressTextBox.TabIndex = 1;
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
            label3.Size = new Size(135, 33);
            label3.TabIndex = 3;
            label3.Text = "Address:";
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
            submitButton.TabIndex = 4;
            submitButton.Text = "✔️ Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;
            // 
            // ClientUpdateForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(701, 703);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ClientUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company X - Edit Client";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private Button submitButton;
        private Panel panel1;
        private TextBox nameTextBox;
        private Label label2;
        private Panel panel4;
        private TextBox addressTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
    }
}