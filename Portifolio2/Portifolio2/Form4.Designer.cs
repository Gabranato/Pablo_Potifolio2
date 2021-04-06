
namespace Portifolio2
{
    partial class frmConversaoCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversaoCF));
            this.label1 = new System.Windows.Forms.Label();
            this.calcularCF = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.ResultF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // calcularCF
            // 
            this.calcularCF.BackColor = System.Drawing.Color.White;
            this.calcularCF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcularCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularCF.Location = new System.Drawing.Point(323, 96);
            this.calcularCF.Name = "calcularCF";
            this.calcularCF.Size = new System.Drawing.Size(75, 23);
            this.calcularCF.TabIndex = 1;
            this.calcularCF.Text = "Calcular";
            this.calcularCF.UseVisualStyleBackColor = false;
            this.calcularCF.Click += new System.EventHandler(this.calcularCF_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(136, 63);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 20);
            this.textNum1.TabIndex = 2;
            // 
            // ResultF
            // 
            this.ResultF.Location = new System.Drawing.Point(136, 99);
            this.ResultF.Name = "ResultF";
            this.ResultF.Size = new System.Drawing.Size(100, 20);
            this.ResultF.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Farenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conversão de Graus Centígrados em Fahrenheit";
            // 
            // frmConversaoCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portifolio2.Properties.Resources.istockphoto_831558848_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 141);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.calcularCF);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConversaoCF";
            this.Text = "Calcular C em F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcularCF;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox ResultF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}