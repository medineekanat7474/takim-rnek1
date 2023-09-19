namespace takimörnek1
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
            this.btnGalatasaray = new System.Windows.Forms.Button();
            this.btnBesiktas = new System.Windows.Forms.Button();
            this.btnfenerbahce = new System.Windows.Forms.Button();
            this.btnTrabzontakim = new System.Windows.Forms.Button();
            this.lbltakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGalatasaray
            // 
            this.btnGalatasaray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGalatasaray.Location = new System.Drawing.Point(53, 46);
            this.btnGalatasaray.Name = "btnGalatasaray";
            this.btnGalatasaray.Size = new System.Drawing.Size(134, 23);
            this.btnGalatasaray.TabIndex = 0;
            this.btnGalatasaray.Text = "GALATASARAY";
            this.btnGalatasaray.UseVisualStyleBackColor = true;
            this.btnGalatasaray.Click += new System.EventHandler(this.btnGalatasaray_Click);
            // 
            // btnBesiktas
            // 
            this.btnBesiktas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBesiktas.Location = new System.Drawing.Point(53, 104);
            this.btnBesiktas.Name = "btnBesiktas";
            this.btnBesiktas.Size = new System.Drawing.Size(112, 23);
            this.btnBesiktas.TabIndex = 1;
            this.btnBesiktas.Text = "BEŞİKTAŞ";
            this.btnBesiktas.UseVisualStyleBackColor = true;
            this.btnBesiktas.Click += new System.EventHandler(this.btnBesiktas_Click);
            // 
            // btnfenerbahce
            // 
            this.btnfenerbahce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfenerbahce.Location = new System.Drawing.Point(53, 75);
            this.btnfenerbahce.Name = "btnfenerbahce";
            this.btnfenerbahce.Size = new System.Drawing.Size(134, 23);
            this.btnfenerbahce.TabIndex = 2;
            this.btnfenerbahce.Text = "FENERBAHÇE";
            this.btnfenerbahce.UseVisualStyleBackColor = true;
            this.btnfenerbahce.Click += new System.EventHandler(this.btnfenerbahce_Click);
            // 
            // btnTrabzontakim
            // 
            this.btnTrabzontakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrabzontakim.Location = new System.Drawing.Point(53, 17);
            this.btnTrabzontakim.Name = "btnTrabzontakim";
            this.btnTrabzontakim.Size = new System.Drawing.Size(148, 23);
            this.btnTrabzontakim.TabIndex = 3;
            this.btnTrabzontakim.Text = "TRABZONTAKİM";
            this.btnTrabzontakim.UseVisualStyleBackColor = true;
            this.btnTrabzontakim.Click += new System.EventHandler(this.btnTrabzontakim_Click);
            // 
            // lbltakim
            // 
            this.lbltakim.AutoSize = true;
            this.lbltakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltakim.Location = new System.Drawing.Point(53, 152);
            this.lbltakim.Name = "lbltakim";
            this.lbltakim.Size = new System.Drawing.Size(68, 25);
            this.lbltakim.TabIndex = 4;
            this.lbltakim.Text = "takım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltakim);
            this.Controls.Add(this.btnTrabzontakim);
            this.Controls.Add(this.btnfenerbahce);
            this.Controls.Add(this.btnBesiktas);
            this.Controls.Add(this.btnGalatasaray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGalatasaray;
        private System.Windows.Forms.Button btnBesiktas;
        private System.Windows.Forms.Button btnfenerbahce;
        private System.Windows.Forms.Button btnTrabzontakim;
        private System.Windows.Forms.Label lbltakim;
    }
}

