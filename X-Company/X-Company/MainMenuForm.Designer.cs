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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Administration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.productsButton.Location = new System.Drawing.Point(0, 0);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(180, 90);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "📦 Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.salesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salesButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesButton.Location = new System.Drawing.Point(0, 315);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(180, 90);
            this.salesButton.TabIndex = 1;
            this.salesButton.Text = "🛒 Sales";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.clientsButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientsButton.Location = new System.Drawing.Point(0, 153);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(180, 90);
            this.clientsButton.TabIndex = 2;
            this.clientsButton.Text = "👤 Clients";
            this.clientsButton.UseVisualStyleBackColor = false;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clientsButton);
            this.panel1.Controls.Add(this.salesButton);
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Location = new System.Drawing.Point(260, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 405);
            this.panel1.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(701, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company X - Store Administration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button productsButton;
    }
}

