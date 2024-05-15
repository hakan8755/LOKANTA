namespace LOKANTA
{
    partial class KariyerHesap
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
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(259, 140);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(237, 30);
            txtAd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 140);
            label2.Name = "label2";
            label2.Size = new Size(221, 24);
            label2.TabIndex = 5;
            label2.Text = "Kasiyer Kullanıcı Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 191);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 7;
            label1.Text = "Şifresi :";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(259, 191);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(237, 30);
            txtSifre.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(88, 248);
            button1.Name = "button1";
            button1.Size = new Size(201, 54);
            button1.TabIndex = 8;
            button1.Text = "Hesap Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Silver;
            flowLayoutPanel1.Location = new Point(546, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 462);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(33, 37);
            button2.Name = "button2";
            button2.Size = new Size(201, 54);
            button2.TabIndex = 10;
            button2.Text = "Yenile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(308, 248);
            button3.Name = "button3";
            button3.Size = new Size(201, 54);
            button3.TabIndex = 11;
            button3.Text = "Şifreyi Değiştir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(52, 460);
            button4.Name = "button4";
            button4.Size = new Size(182, 54);
            button4.TabIndex = 28;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // KariyerHesap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1196, 543);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtAd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KariyerHesap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KariyerHesap";
            Load += KariyerHesap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}