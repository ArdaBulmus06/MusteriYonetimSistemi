namespace Project1_AdonetProject
{
    partial class FrmMap
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
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.Location = new System.Drawing.Point(23, 25);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(222, 88);
            this.btnOpenCityForm.TabIndex = 0;
            this.btnOpenCityForm.Text = "Şehir İşlemleri";
            this.btnOpenCityForm.UseVisualStyleBackColor = true;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 373);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpenCityForm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCityForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}