namespace Uygulama20230925_1
{
    partial class Form1
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
            this.txtMeyve = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lboxMeyveler = new System.Windows.Forms.ListBox();
            this.lblMeyveler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMeyve
            // 
            this.txtMeyve.Location = new System.Drawing.Point(25, 68);
            this.txtMeyve.Name = "txtMeyve";
            this.txtMeyve.Size = new System.Drawing.Size(100, 20);
            this.txtMeyve.TabIndex = 0;
            this.txtMeyve.Click += new System.EventHandler(this.txtMeyve_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(25, 122);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 31);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(25, 159);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 33);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Sepeti Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lboxMeyveler
            // 
            this.lboxMeyveler.FormattingEnabled = true;
            this.lboxMeyveler.Location = new System.Drawing.Point(190, 70);
            this.lboxMeyveler.Name = "lboxMeyveler";
            this.lboxMeyveler.Size = new System.Drawing.Size(120, 173);
            this.lboxMeyveler.TabIndex = 3;
            // 
            // lblMeyveler
            // 
            this.lblMeyveler.AutoSize = true;
            this.lblMeyveler.Location = new System.Drawing.Point(187, 52);
            this.lblMeyveler.Name = "lblMeyveler";
            this.lblMeyveler.Size = new System.Drawing.Size(50, 13);
            this.lblMeyveler.TabIndex = 4;
            this.lblMeyveler.Text = "Meyveler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekleyeck Meyveler";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(25, 198);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Seçili öğeyi sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMeyveler);
            this.Controls.Add(this.lboxMeyveler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMeyve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMeyve;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lboxMeyveler;
        private System.Windows.Forms.Label lblMeyveler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}

