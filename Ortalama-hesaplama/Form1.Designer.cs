namespace Ortalama_hesaplama
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
            this.y1 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // y1
            // 
            this.y1.AutoSize = true;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y1.Location = new System.Drawing.Point(34, 22);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(55, 20);
            this.y1.TabIndex = 0;
            this.y1.Text = "Yazılı1";
            // 
            // y2
            // 
            this.y2.AutoSize = true;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y2.Location = new System.Drawing.Point(34, 63);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(55, 20);
            this.y2.TabIndex = 1;
            this.y2.Text = "Yazılı2";
            // 
            // y3
            // 
            this.y3.AutoSize = true;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y3.Location = new System.Drawing.Point(34, 154);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(74, 20);
            this.y3.TabIndex = 2;
            this.y3.Text = "Ortalama";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Yellow;
            this.btnHesapla.Location = new System.Drawing.Point(112, 102);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 33);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrtalama.Location = new System.Drawing.Point(112, 150);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 24);
            this.txtOrtalama.TabIndex = 4;
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtY2.Location = new System.Drawing.Point(112, 63);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 24);
            this.txtY2.TabIndex = 5;
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtY1.Location = new System.Drawing.Point(112, 22);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 24);
            this.txtY1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(489, 277);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Name = "Form1";
            this.Text = "Ortalama Hesplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label y1;
        private System.Windows.Forms.Label y2;
        private System.Windows.Forms.Label y3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtY1;
    }
}

