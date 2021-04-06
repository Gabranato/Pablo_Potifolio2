
namespace Portifolio2
{
    partial class frmConversaoCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversaoCK));
            this.label3 = new System.Windows.Forms.Label();
            this.ResultK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.calcularCF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Conversão de Graus Centígrados em Kelvin";
            // 
            // ResultK
            // 
            this.ResultK.Location = new System.Drawing.Point(93, 103);
            this.ResultK.Name = "ResultK";
            this.ResultK.Size = new System.Drawing.Size(100, 20);
            this.ResultK.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kelvin";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(93, 60);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 20);
            this.textNum1.TabIndex = 8;
            // 
            // calcularCF
            // 
            this.calcularCF.BackColor = System.Drawing.Color.White;
            this.calcularCF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcularCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularCF.Location = new System.Drawing.Point(275, 103);
            this.calcularCF.Name = "calcularCF";
            this.calcularCF.Size = new System.Drawing.Size(75, 23);
            this.calcularCF.TabIndex = 7;
            this.calcularCF.Text = "Calcular";
            this.calcularCF.UseVisualStyleBackColor = false;
            this.calcularCF.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Celsius";
            // 
            // frmConversaoCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portifolio2.Properties.Resources.istockphoto_831558848_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.calcularCF);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConversaoCK";
            this.Text = "Calcular C em K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Button calcularCF;
        private System.Windows.Forms.Label label1;
    }
}