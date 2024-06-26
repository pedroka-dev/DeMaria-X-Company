namespace X_Company
{
    partial class ProductViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            editButton = new Button();
            newButton = new Button();
            reportButton = new Button();
            deleteButton = new Button();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ProductsDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 186);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 128);
            label1.Name = "label1";
            label1.Size = new Size(1092, 58);
            label1.TabIndex = 2;
            label1.Text = "Products Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1092, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 664);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 125);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(editButton, 1, 0);
            tableLayoutPanel1.Controls.Add(newButton, 0, 0);
            tableLayoutPanel1.Controls.Add(reportButton, 3, 0);
            tableLayoutPanel1.Controls.Add(deleteButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1092, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editButton.BackColor = SystemColors.WindowText;
            editButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.ForeColor = SystemColors.ControlLight;
            editButton.Location = new Point(323, 25);
            editButton.Margin = new Padding(50, 25, 50, 25);
            editButton.Name = "editButton";
            editButton.Size = new Size(173, 75);
            editButton.TabIndex = 2;
            editButton.Text = "✏️ Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newButton.BackColor = SystemColors.WindowText;
            newButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newButton.ForeColor = SystemColors.ControlLight;
            newButton.Location = new Point(50, 25);
            newButton.Margin = new Padding(50, 25, 50, 25);
            newButton.Name = "newButton";
            newButton.Size = new Size(173, 75);
            newButton.TabIndex = 1;
            newButton.Text = "➕ New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // reportButton
            // 
            reportButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportButton.BackColor = SystemColors.WindowText;
            reportButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportButton.ForeColor = SystemColors.ControlLight;
            reportButton.Location = new Point(869, 25);
            reportButton.Margin = new Padding(50, 25, 50, 25);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(173, 75);
            reportButton.TabIndex = 3;
            reportButton.Text = "📄 Report";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteButton.BackColor = SystemColors.WindowText;
            deleteButton.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = SystemColors.ControlLight;
            deleteButton.Location = new Point(596, 25);
            deleteButton.Margin = new Padding(50, 25, 50, 25);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(173, 75);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "🗑️ Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 186);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1092, 478);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(ProductsDataGridView, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1092, 478);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Dock = DockStyle.Fill;
            ProductsDataGridView.Location = new Point(57, 4);
            ProductsDataGridView.Margin = new Padding(3, 4, 3, 4);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 51;
            ProductsDataGridView.RowTemplate.Height = 24;
            ProductsDataGridView.Size = new Size(976, 470);
            ProductsDataGridView.TabIndex = 0;
            // 
            // ProductViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1092, 789);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1110, 836);
            Name = "ProductViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X Company - Products Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
    }
}