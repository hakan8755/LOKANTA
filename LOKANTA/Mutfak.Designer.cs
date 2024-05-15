namespace LOKANTA
{
    partial class Mutfak
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
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            label8 = new Label();
            siparisGoruntule = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(siparisGoruntule);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 1041);
            panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 29);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Sadece Paketler";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(3, 296);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 29);
            dateTimePicker1.TabIndex = 30;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(3, 351);
            button2.Name = "button2";
            button2.Size = new Size(211, 51);
            button2.TabIndex = 28;
            button2.Text = "Sipariş Görüntüle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 39);
            label1.Name = "label1";
            label1.Size = new Size(266, 15);
            label1.TabIndex = 27;
            label1.Text = "- - - - - - - - - - - - - - - - - - -  - - - - - - - - -  - - - -\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(43, 934);
            button1.Name = "button1";
            button1.Size = new Size(182, 54);
            button1.TabIndex = 26;
            button1.Text = "Anasayfa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(0, 152);
            label8.Name = "label8";
            label8.Size = new Size(266, 15);
            label8.TabIndex = 25;
            label8.Text = "- - - - - - - - - - - - - - - - - - -  - - - - - - - - -  - - - -\r\n";
            // 
            // siparisGoruntule
            // 
            siparisGoruntule.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            siparisGoruntule.Location = new Point(32, 75);
            siparisGoruntule.Name = "siparisGoruntule";
            siparisGoruntule.Size = new Size(211, 74);
            siparisGoruntule.TabIndex = 1;
            siparisGoruntule.Text = "Tüm Siparişleri Görüntüle";
            siparisGoruntule.UseVisualStyleBackColor = true;
            siparisGoruntule.Click += siparisGoruntule_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Location = new Point(312, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1501, 946);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 17.25F);
            label6.Location = new Point(337, 993);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(254, 27);
            label6.TabIndex = 32;
            label6.Text = "Toplam Sipariş Sayısı: ";
            // 
            // Mutfak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mutfak";
            Text = "Mutfak";
            WindowState = FormWindowState.Maximized;
            Load += Mutfak_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button siparisGoruntule;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Button button1;
        private Label label1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Label label6;
    }
}