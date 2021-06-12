
namespace ProjetoVetor
{
    partial class FrmVetor
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
            this.LstInteiros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstInteiros
            // 
            this.LstInteiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstInteiros.FormattingEnabled = true;
            this.LstInteiros.ItemHeight = 31;
            this.LstInteiros.Location = new System.Drawing.Point(32, 34);
            this.LstInteiros.Name = "LstInteiros";
            this.LstInteiros.Size = new System.Drawing.Size(167, 314);
            this.LstInteiros.TabIndex = 0;
            // 
            // FrmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstInteiros);
            this.Name = "FrmVetor";
            this.Text = "Vetor";
            this.Load += new System.EventHandler(this.FrmVetor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstInteiros;
    }
}

