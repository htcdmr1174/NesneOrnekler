
namespace KutuphaneProjesi
{
    partial class formOdunckitap
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
            this.gridKitap = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnkitapVer = new System.Windows.Forms.Button();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtogrencino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboKitap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridKitap
            // 
            this.gridKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridKitap.Location = new System.Drawing.Point(22, 329);
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKitap.Size = new System.Drawing.Size(789, 169);
            this.gridKitap.TabIndex = 10;
            this.gridKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKitap_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnkitapVer);
            this.groupBox3.Controls.Add(this.btnKitapAl);
            this.groupBox3.Location = new System.Drawing.Point(442, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 112);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 2;
            this.btnSil.Location = new System.Drawing.Point(121, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 82);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnkitapVer
            // 
            this.btnkitapVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkitapVer.ImageIndex = 0;
            this.btnkitapVer.Location = new System.Drawing.Point(17, 24);
            this.btnkitapVer.Name = "btnkitapVer";
            this.btnkitapVer.Size = new System.Drawing.Size(98, 82);
            this.btnkitapVer.TabIndex = 1;
            this.btnkitapVer.Text = "KİTAP VER";
            this.btnkitapVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkitapVer.UseVisualStyleBackColor = true;
            this.btnkitapVer.Click += new System.EventHandler(this.btnkitapVer_Click);
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapAl.ImageIndex = 1;
            this.btnKitapAl.Location = new System.Drawing.Point(227, 24);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(96, 82);
            this.btnKitapAl.TabIndex = 2;
            this.btnKitapAl.Text = "KİTAP AL";
            this.btnKitapAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOgrenciAra);
            this.groupBox2.Location = new System.Drawing.Point(43, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 112);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ögrenci Adı";
            // 
            // txtOgrenciAra
            // 
            this.txtOgrenciAra.Location = new System.Drawing.Point(101, 33);
            this.txtOgrenciAra.Name = "txtOgrenciAra";
            this.txtOgrenciAra.Size = new System.Drawing.Size(138, 20);
            this.txtOgrenciAra.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.txtogrencino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboKitap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Giriş";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(513, 39);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(116, 20);
            this.txtaciklama.TabIndex = 14;
            // 
            // txtogrencino
            // 
            this.txtogrencino.Location = new System.Drawing.Point(96, 42);
            this.txtogrencino.Name = "txtogrencino";
            this.txtogrencino.Size = new System.Drawing.Size(100, 20);
            this.txtogrencino.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kitap adı :";
            // 
            // comboKitap
            // 
            this.comboKitap.FormattingEnabled = true;
            this.comboKitap.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.comboKitap.Location = new System.Drawing.Point(74, 94);
            this.comboKitap.Name = "comboKitap";
            this.comboKitap.Size = new System.Drawing.Size(121, 21);
            this.comboKitap.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ögrenci no :";
            // 
            // formOdunckitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridKitap);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formOdunckitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOdunckitap";
            this.Load += new System.EventHandler(this.formOdunckitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKitap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnkitapVer;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtogrencino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboKitap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}