
namespace Portifolio2
{
    partial class frmCalculoIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoIMC));
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoIMC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularIMC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.calculoIMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resultado";
            // 
            // resultadoIMC
            // 
            this.resultadoIMC.Location = new System.Drawing.Point(99, 166);
            this.resultadoIMC.Name = "resultadoIMC";
            this.resultadoIMC.Size = new System.Drawing.Size(144, 20);
            this.resultadoIMC.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Peso";
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(99, 95);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(77, 20);
            this.textNum2.TabIndex = 11;
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(99, 58);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(77, 20);
            this.textNum1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cálculo do IMC do Aluno";
            // 
            // CalcularIMC
            // 
            this.CalcularIMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcularIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularIMC.Location = new System.Drawing.Point(182, 56);
            this.CalcularIMC.Name = "CalcularIMC";
            this.CalcularIMC.Size = new System.Drawing.Size(75, 23);
            this.CalcularIMC.TabIndex = 8;
            this.CalcularIMC.Text = "Calcular";
            this.CalcularIMC.UseVisualStyleBackColor = true;
            this.CalcularIMC.Click += new System.EventHandler(this.CalcularIMC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "IMC";
            // 
            // calculoIMC
            // 
            this.calculoIMC.Location = new System.Drawing.Point(99, 130);
            this.calculoIMC.Name = "calculoIMC";
            this.calculoIMC.Size = new System.Drawing.Size(77, 20);
            this.calculoIMC.TabIndex = 16;
            // 
            // frmCalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Portifolio2.Properties.Resources.istockphoto_831558848_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(267, 207);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculoIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultadoIMC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularIMC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculoIMC";
            this.Text = "Calculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultadoIMC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularIMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox calculoIMC;
    }
}