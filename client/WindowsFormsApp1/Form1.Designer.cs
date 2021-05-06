
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.genGame = new System.Windows.Forms.Button();
            this.joinGame = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // genGame
            // 
            this.genGame.Location = new System.Drawing.Point(90, 433);
            this.genGame.Name = "genGame";
            this.genGame.Size = new System.Drawing.Size(284, 100);
            this.genGame.TabIndex = 0;
            this.genGame.Text = "crea partita";
            this.genGame.UseVisualStyleBackColor = true;
            // 
            // joinGame
            // 
            this.joinGame.Location = new System.Drawing.Point(481, 433);
            this.joinGame.Name = "joinGame";
            this.joinGame.Size = new System.Drawing.Size(298, 100);
            this.joinGame.TabIndex = 1;
            this.joinGame.Text = "entra la partita";
            this.joinGame.UseVisualStyleBackColor = true;
            // 
            // games
            // 
            this.games.FormattingEnabled = true;
            this.games.Location = new System.Drawing.Point(481, 70);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(298, 355);
            this.games.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 581);
            this.Controls.Add(this.games);
            this.Controls.Add(this.joinGame);
            this.Controls.Add(this.genGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genGame;
        private System.Windows.Forms.Button joinGame;
        private System.Windows.Forms.ListBox games;
    }
}

