
namespace Portifolio2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.calculosRapidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converçãoDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusParaKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeFreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaDasNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosRapidosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(275, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // calculosRapidosToolStripMenuItem
            // 
            this.calculosRapidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeIMCToolStripMenuItem,
            this.converçãoDeTemperaturaToolStripMenuItem,
            this.calculoDeFreteToolStripMenuItem,
            this.mediaDasNotasToolStripMenuItem,
            this.tabuadaToolStripMenuItem});
            this.calculosRapidosToolStripMenuItem.Name = "calculosRapidosToolStripMenuItem";
            this.calculosRapidosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.calculosRapidosToolStripMenuItem.Text = "Calculos Rapidos";
            // 
            // calculoDeIMCToolStripMenuItem
            // 
            this.calculoDeIMCToolStripMenuItem.Name = "calculoDeIMCToolStripMenuItem";
            this.calculoDeIMCToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.calculoDeIMCToolStripMenuItem.Text = "Calculo de IMC";
            this.calculoDeIMCToolStripMenuItem.Click += new System.EventHandler(this.calculoDeIMCToolStripMenuItem_Click);
            // 
            // converçãoDeTemperaturaToolStripMenuItem
            // 
            this.converçãoDeTemperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ceToolStripMenuItem,
            this.celsiusParaKToolStripMenuItem});
            this.converçãoDeTemperaturaToolStripMenuItem.Name = "converçãoDeTemperaturaToolStripMenuItem";
            this.converçãoDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.converçãoDeTemperaturaToolStripMenuItem.Text = "Converção de Temperatura";
            // 
            // ceToolStripMenuItem
            // 
            this.ceToolStripMenuItem.Name = "ceToolStripMenuItem";
            this.ceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ceToolStripMenuItem.Text = "Celsius para Fahrenheit";
            this.ceToolStripMenuItem.Click += new System.EventHandler(this.ceToolStripMenuItem_Click);
            // 
            // celsiusParaKToolStripMenuItem
            // 
            this.celsiusParaKToolStripMenuItem.Name = "celsiusParaKToolStripMenuItem";
            this.celsiusParaKToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.celsiusParaKToolStripMenuItem.Text = "Celsius para Kelvin";
            this.celsiusParaKToolStripMenuItem.Click += new System.EventHandler(this.celsiusParaKToolStripMenuItem_Click);
            // 
            // calculoDeFreteToolStripMenuItem
            // 
            this.calculoDeFreteToolStripMenuItem.Name = "calculoDeFreteToolStripMenuItem";
            this.calculoDeFreteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.calculoDeFreteToolStripMenuItem.Text = "Calculo de Frete";
            this.calculoDeFreteToolStripMenuItem.Click += new System.EventHandler(this.calculoDeFreteToolStripMenuItem_Click);
            // 
            // mediaDasNotasToolStripMenuItem
            // 
            this.mediaDasNotasToolStripMenuItem.Name = "mediaDasNotasToolStripMenuItem";
            this.mediaDasNotasToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mediaDasNotasToolStripMenuItem.Text = "Media das Notas";
            this.mediaDasNotasToolStripMenuItem.Click += new System.EventHandler(this.mediaDasNotasToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "V 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Portifolio2.Properties.Resources.istockphoto_831558848_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(275, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem calculosRapidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converçãoDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celsiusParaKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeFreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaDasNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

