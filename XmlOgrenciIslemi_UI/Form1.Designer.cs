
namespace FormOrnek3
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
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_DogumTarihii = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.DateTimePicker_Dogum = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Sınıf = new System.Windows.Forms.ComboBox();
            this.lbl_SınıfSecimi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.İslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLileDisariAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIleIceriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OgrEkle = new System.Windows.Forms.Button();
            this.lbl_DogumTarihi = new System.Windows.Forms.Label();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.btn_SagaGönder = new System.Windows.Forms.Button();
            this.btn_HepsiniSagaGöner = new System.Windows.Forms.Button();
            this.btn_SolaGöner = new System.Windows.Forms.Button();
            this.btn_HepsiniSolaGönder = new System.Windows.Forms.Button();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.GroupBoxBilgi = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ad.Location = new System.Drawing.Point(53, 38);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(37, 23);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "AD:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Soyad.Location = new System.Drawing.Point(53, 77);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(57, 23);
            this.lbl_Soyad.TabIndex = 1;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // lbl_DogumTarihii
            // 
            this.lbl_DogumTarihii.AutoSize = true;
            this.lbl_DogumTarihii.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DogumTarihii.Location = new System.Drawing.Point(53, 112);
            this.lbl_DogumTarihii.Name = "lbl_DogumTarihii";
            this.lbl_DogumTarihii.Size = new System.Drawing.Size(112, 23);
            this.lbl_DogumTarihii.TabIndex = 3;
            this.lbl_DogumTarihii.Text = "Doğum Tarihi";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(175, 23);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(221, 27);
            this.txt_Ad.TabIndex = 0;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(175, 70);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(221, 27);
            this.txt_Soyad.TabIndex = 1;
            // 
            // DateTimePicker_Dogum
            // 
            this.DateTimePicker_Dogum.Location = new System.Drawing.Point(175, 112);
            this.DateTimePicker_Dogum.Name = "DateTimePicker_Dogum";
            this.DateTimePicker_Dogum.Size = new System.Drawing.Size(221, 27);
            this.DateTimePicker_Dogum.TabIndex = 2;
            // 
            // comboBox_Sınıf
            // 
            this.comboBox_Sınıf.FormattingEnabled = true;
            this.comboBox_Sınıf.Location = new System.Drawing.Point(175, 159);
            this.comboBox_Sınıf.Name = "comboBox_Sınıf";
            this.comboBox_Sınıf.Size = new System.Drawing.Size(221, 28);
            this.comboBox_Sınıf.TabIndex = 3;
            this.comboBox_Sınıf.Text = "Sınıfınızı Seçiniz";
            // 
            // lbl_SınıfSecimi
            // 
            this.lbl_SınıfSecimi.AutoSize = true;
            this.lbl_SınıfSecimi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SınıfSecimi.Location = new System.Drawing.Point(53, 161);
            this.lbl_SınıfSecimi.Name = "lbl_SınıfSecimi";
            this.lbl_SınıfSecimi.Size = new System.Drawing.Size(97, 23);
            this.lbl_SınıfSecimi.TabIndex = 8;
            this.lbl_SınıfSecimi.Text = "Sınıf Seçimi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.İslemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // İslemlerToolStripMenuItem
            // 
            this.İslemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.İslemlerToolStripMenuItem.Name = "İslemlerToolStripMenuItem";
            this.İslemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.İslemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLileDisariAktarToolStripMenuItem,
            this.XMLIleIceriAlToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // XMLileDisariAktarToolStripMenuItem
            // 
            this.XMLileDisariAktarToolStripMenuItem.Name = "XMLileDisariAktarToolStripMenuItem";
            this.XMLileDisariAktarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.XMLileDisariAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            this.XMLileDisariAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLileDisariAktarToolStripMenuItem_Click);
            // 
            // XMLIleIceriAlToolStripMenuItem
            // 
            this.XMLIleIceriAlToolStripMenuItem.Name = "XMLIleIceriAlToolStripMenuItem";
            this.XMLIleIceriAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.XMLIleIceriAlToolStripMenuItem.Text = "XML ile içeri al";
            this.XMLIleIceriAlToolStripMenuItem.Click += new System.EventHandler(this.XMLIleIceriAlToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btn_OgrEkle
            // 
            this.btn_OgrEkle.BackColor = System.Drawing.Color.Aqua;
            this.btn_OgrEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OgrEkle.Location = new System.Drawing.Point(455, 38);
            this.btn_OgrEkle.Name = "btn_OgrEkle";
            this.btn_OgrEkle.Size = new System.Drawing.Size(122, 139);
            this.btn_OgrEkle.TabIndex = 12;
            this.btn_OgrEkle.Text = "Öğrenci Ekle";
            this.btn_OgrEkle.UseVisualStyleBackColor = false;
            this.btn_OgrEkle.Click += new System.EventHandler(this.btn_OgrEkle_Click);
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.AutoSize = true;
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(133, 471);
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(0, 20);
            this.lbl_DogumTarihi.TabIndex = 2;
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 23;
            this.listBoxBSinifi.Location = new System.Drawing.Point(510, 441);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(217, 211);
            this.listBoxBSinifi.TabIndex = 10;
            // 
            // btn_SagaGönder
            // 
            this.btn_SagaGönder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SagaGönder.Location = new System.Drawing.Point(348, 466);
            this.btn_SagaGönder.Name = "btn_SagaGönder";
            this.btn_SagaGönder.Size = new System.Drawing.Size(94, 29);
            this.btn_SagaGönder.TabIndex = 13;
            this.btn_SagaGönder.Text = ">";
            this.btn_SagaGönder.UseVisualStyleBackColor = true;
            this.btn_SagaGönder.Click += new System.EventHandler(this.btn_SagaGönder_Click);
            // 
            // btn_HepsiniSagaGöner
            // 
            this.btn_HepsiniSagaGöner.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HepsiniSagaGöner.Location = new System.Drawing.Point(348, 501);
            this.btn_HepsiniSagaGöner.Name = "btn_HepsiniSagaGöner";
            this.btn_HepsiniSagaGöner.Size = new System.Drawing.Size(94, 29);
            this.btn_HepsiniSagaGöner.TabIndex = 14;
            this.btn_HepsiniSagaGöner.Text = ">>";
            this.btn_HepsiniSagaGöner.UseVisualStyleBackColor = true;
            this.btn_HepsiniSagaGöner.Click += new System.EventHandler(this.btn_HepsiniSagaGöner_Click);
            // 
            // btn_SolaGöner
            // 
            this.btn_SolaGöner.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SolaGöner.Location = new System.Drawing.Point(348, 536);
            this.btn_SolaGöner.Name = "btn_SolaGöner";
            this.btn_SolaGöner.Size = new System.Drawing.Size(94, 29);
            this.btn_SolaGöner.TabIndex = 15;
            this.btn_SolaGöner.Text = "<";
            this.btn_SolaGöner.UseVisualStyleBackColor = true;
            this.btn_SolaGöner.Click += new System.EventHandler(this.btn_SolaGöner_Click);
            // 
            // btn_HepsiniSolaGönder
            // 
            this.btn_HepsiniSolaGönder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HepsiniSolaGönder.Location = new System.Drawing.Point(348, 571);
            this.btn_HepsiniSolaGönder.Name = "btn_HepsiniSolaGönder";
            this.btn_HepsiniSolaGönder.Size = new System.Drawing.Size(94, 29);
            this.btn_HepsiniSolaGönder.TabIndex = 16;
            this.btn_HepsiniSolaGönder.Text = "<<";
            this.btn_HepsiniSolaGönder.UseVisualStyleBackColor = true;
            this.btn_HepsiniSolaGönder.Click += new System.EventHandler(this.btn_HepsiniSolaGönder_Click);
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 23;
            this.listBoxASinifi.Location = new System.Drawing.Point(74, 445);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(217, 211);
            this.listBoxASinifi.TabIndex = 17;
            // 
            // GroupBoxBilgi
            // 
            this.GroupBoxBilgi.Controls.Add(this.checkBox1);
            this.GroupBoxBilgi.Controls.Add(this.txt_Soyad);
            this.GroupBoxBilgi.Controls.Add(this.lbl_Ad);
            this.GroupBoxBilgi.Controls.Add(this.lbl_Soyad);
            this.GroupBoxBilgi.Controls.Add(this.lbl_DogumTarihii);
            this.GroupBoxBilgi.Controls.Add(this.txt_Ad);
            this.GroupBoxBilgi.Controls.Add(this.DateTimePicker_Dogum);
            this.GroupBoxBilgi.Controls.Add(this.btn_OgrEkle);
            this.GroupBoxBilgi.Controls.Add(this.comboBox_Sınıf);
            this.GroupBoxBilgi.Controls.Add(this.lbl_SınıfSecimi);
            this.GroupBoxBilgi.Location = new System.Drawing.Point(48, 41);
            this.GroupBoxBilgi.Name = "GroupBoxBilgi";
            this.GroupBoxBilgi.Size = new System.Drawing.Size(672, 333);
            this.GroupBoxBilgi.TabIndex = 18;
            this.GroupBoxBilgi.TabStop = false;
            this.GroupBoxBilgi.Text = "Öğrenci Bilgileri";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(175, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(241, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Seçmeli ders almak ister misiniz";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(849, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçmeli dersler";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "İnsan kaynakları",
            "toplum hizmetleri",
            "italyanca",
            "evrim teorisi"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(250, 246);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1111, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxBilgi);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.btn_HepsiniSolaGönder);
            this.Controls.Add(this.btn_SolaGöner);
            this.Controls.Add(this.btn_HepsiniSagaGöner);
            this.Controls.Add(this.btn_SagaGönder);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.lbl_DogumTarihi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxBilgi.ResumeLayout(false);
            this.GroupBoxBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_DogumTarihii;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Dogum;
        private System.Windows.Forms.ComboBox comboBox_Sınıf;
        private System.Windows.Forms.Label lbl_SınıfSecimi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem İslemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btn_OgrEkle;
        private System.Windows.Forms.Label lbl_DogumTarihi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.Button btn_SagaGönder;
        private System.Windows.Forms.Button btn_HepsiniSagaGöner;
        private System.Windows.Forms.Button btn_SolaGöner;
        private System.Windows.Forms.Button btn_HepsiniSolaGönder;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.GroupBox GroupBoxBilgi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLileDisariAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIleIceriAlToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

