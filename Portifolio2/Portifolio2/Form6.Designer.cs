
namespace Portifolio2
{
    partial class frmFrete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrete));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textValorT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPesoT = new System.Windows.Forms.TextBox();
            this.textQtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularF = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Peso Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor Total";
            // 
            // textValorT
            // 
            this.textValorT.Location = new System.Drawing.Point(339, 122);
            this.textValorT.Name = "textValorT";
            this.textValorT.Size = new System.Drawing.Size(77, 20);
            this.textValorT.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantidade";
            // 
            // textPesoT
            // 
            this.textPesoT.Location = new System.Drawing.Point(116, 122);
            this.textPesoT.Name = "textPesoT";
            this.textPesoT.Size = new System.Drawing.Size(77, 20);
            this.textPesoT.TabIndex = 21;
            // 
            // textQtde
            // 
            this.textQtde.Location = new System.Drawing.Point(116, 78);
            this.textQtde.Name = "textQtde";
            this.textQtde.Size = new System.Drawing.Size(77, 20);
            this.textQtde.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cálculo de Frete de produto";
            // 
            // CalcularF
            // 
            this.CalcularF.BackColor = System.Drawing.Color.White;
            this.CalcularF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcularF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularF.Location = new System.Drawing.Point(20, 168);
            this.CalcularF.Name = "CalcularF";
            this.CalcularF.Size = new System.Drawing.Size(75, 23);
            this.CalcularF.TabIndex = 18;
            this.CalcularF.Text = "Calcular";
            this.CalcularF.UseVisualStyleBackColor = false;
            this.CalcularF.UseWaitCursor = true;
            this.CalcularF.Click += new System.EventHandler(this.CalcularF_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "-NORTE-",
            "AC",
            "AP",
            "AM",
            "PA",
            "RO",
            "RR",
            "RO",
            "-NORDESTE-",
            "AL",
            "BH",
            "CE",
            "MA",
            "PB",
            "PE",
            "PI",
            "RN",
            "SG",
            "-CENTRO - OESTE-",
            "DF",
            "GO",
            "MT",
            "MS",
            "-SUDESTE-",
            "ES",
            "MG",
            "RJ",
            "SP",
            "-SUL-",
            "PR",
            "RS",
            "SC"});
            this.cbEstado.Location = new System.Drawing.Point(339, 78);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(77, 21);
            this.cbEstado.TabIndex = 28;
            // 
            // frmFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portifolio2.Properties.Resources.istockphoto_831558848_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 215);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textValorT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPesoT);
            this.Controls.Add(this.textQtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFrete";
            this.Text = "Calculo de Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValorT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPesoT;
        private System.Windows.Forms.TextBox textQtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularF;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}