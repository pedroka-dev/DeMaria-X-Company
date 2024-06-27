namespace X_Company
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            productsButton = new Button();
            salesButton = new Button();
            clientsButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 160);
            label1.Name = "label1";
            label1.Size = new Size(701, 46);
            label1.TabIndex = 1;
            label1.Text = "Store Administration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productsButton
            // 
            productsButton.BackColor = SystemColors.WindowText;
            productsButton.Dock = DockStyle.Top;
            productsButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsButton.ForeColor = SystemColors.ControlLight;
            productsButton.Location = new Point(0, 0);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(200, 90);
            productsButton.TabIndex = 0;
            productsButton.Text = "📦 Products";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += ProductsButton_Click;
            // 
            // salesButton
            // 
            salesButton.BackColor = SystemColors.WindowText;
            salesButton.Dock = DockStyle.Bottom;
            salesButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesButton.ForeColor = SystemColors.ControlLightLight;
            salesButton.Location = new Point(0, 315);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(200, 90);
            salesButton.TabIndex = 2;
            salesButton.Text = "\U0001f6d2 Sales";
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += SalesButton_Click;
            // 
            // clientsButton
            // 
            clientsButton.BackColor = SystemColors.WindowText;
            clientsButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientsButton.ForeColor = SystemColors.ControlLightLight;
            clientsButton.Location = new Point(0, 153);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(200, 90);
            clientsButton.TabIndex = 1;
            clientsButton.Text = "👤 Clients";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += ClientsButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(clientsButton);
            panel1.Controls.Add(salesButton);
            panel1.Controls.Add(productsButton);
            panel1.Location = new Point(247, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 405);
            panel1.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(701, 703);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company X - Store Administration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Button productsButton;
        private Button salesButton;
        private Button clientsButton;
        private Panel panel1;
    }
}

