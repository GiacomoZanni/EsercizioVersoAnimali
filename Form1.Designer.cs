namespace EsercizioVersoAnimali
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Mucca = new Button();
            Cane = new Button();
            Capra = new Button();
            Gatto = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 207);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(167, 61);
            label1.Name = "label1";
            label1.Size = new Size(464, 50);
            label1.TabIndex = 0;
            label1.Text = "IL VERSO DEGLI ANIMALI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Mucca, 1, 0);
            tableLayoutPanel1.Controls.Add(Cane, 0, 0);
            tableLayoutPanel1.Controls.Add(Capra, 0, 1);
            tableLayoutPanel1.Controls.Add(Gatto, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 207);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 416);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Mucca
            // 
            Mucca.Dock = DockStyle.Fill;
            Mucca.Image = (Image)resources.GetObject("Mucca.Image");
            Mucca.Location = new Point(403, 3);
            Mucca.Name = "Mucca";
            Mucca.Size = new Size(394, 202);
            Mucca.TabIndex = 0;
            Mucca.UseVisualStyleBackColor = true;
            // 
            // Cane
            // 
            Cane.Dock = DockStyle.Fill;
            Cane.Image = (Image)resources.GetObject("Cane.Image");
            Cane.Location = new Point(3, 3);
            Cane.Name = "Cane";
            Cane.Size = new Size(394, 202);
            Cane.TabIndex = 1;
            Cane.UseVisualStyleBackColor = true;
            // 
            // Capra
            // 
            Capra.Dock = DockStyle.Fill;
            Capra.Image = (Image)resources.GetObject("Capra.Image");
            Capra.Location = new Point(3, 211);
            Capra.Name = "Capra";
            Capra.Size = new Size(394, 202);
            Capra.TabIndex = 2;
            Capra.Text = "\r\n";
            Capra.UseVisualStyleBackColor = true;
            // 
            // Gatto
            // 
            Gatto.Dock = DockStyle.Fill;
            Gatto.Image = (Image)resources.GetObject("Gatto.Image");
            Gatto.Location = new Point(403, 211);
            Gatto.Name = "Gatto";
            Gatto.Size = new Size(394, 202);
            Gatto.TabIndex = 3;
            Gatto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 623);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Mucca;
        private Button Cane;
        private Button Capra;
        private Button Gatto;
    }
}