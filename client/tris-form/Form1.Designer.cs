
namespace tris_form {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.genGame = new System.Windows.Forms.Button();
            this.joinGame = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // genGame
            // 
            this.genGame.Location = new System.Drawing.Point(121, 420);
            this.genGame.Name = "genGame";
            this.genGame.Size = new System.Drawing.Size(277, 107);
            this.genGame.TabIndex = 0;
            this.genGame.Text = "crea una partita";
            this.genGame.UseVisualStyleBackColor = true;
            this.genGame.Click += new System.EventHandler(this.genGame_Click);
            // 
            // joinGame
            // 
            this.joinGame.Location = new System.Drawing.Point(554, 420);
            this.joinGame.Name = "joinGame";
            this.joinGame.Size = new System.Drawing.Size(277, 107);
            this.joinGame.TabIndex = 1;
            this.joinGame.Text = "entra nella partita";
            this.joinGame.UseVisualStyleBackColor = true;
            this.joinGame.Click += new System.EventHandler(this.joinGame_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(554, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 368);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 591);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.joinGame);
            this.Controls.Add(this.genGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genGame;
        private System.Windows.Forms.Button joinGame;
        private System.Windows.Forms.ListBox listBox1;
    }
}

