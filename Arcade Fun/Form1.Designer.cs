namespace Arcade_Fun
{
    partial class arcadeGame
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
            this.playGame = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGame
            // 
            this.playGame.BackColor = System.Drawing.Color.Black;
            this.playGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.playGame.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.playGame.FlatAppearance.BorderSize = 0;
            this.playGame.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGame.ForeColor = System.Drawing.Color.White;
            this.playGame.Location = new System.Drawing.Point(50, 67);
            this.playGame.Name = "playGame";
            this.playGame.Size = new System.Drawing.Size(192, 55);
            this.playGame.TabIndex = 0;
            this.playGame.Text = "Play Game";
            this.playGame.UseVisualStyleBackColor = false;
            this.playGame.Click += new System.EventHandler(this.playGame_Click);
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.ForeColor = System.Drawing.Color.Black;
            this.game.Location = new System.Drawing.Point(57, 125);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(185, 26);
            this.game.TabIndex = 1;
            this.game.Text = "Game will start in... 3";
            this.game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arcadeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.game);
            this.Controls.Add(this.playGame);
            this.Name = "arcadeGame";
            this.Text = "Arcade Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGame;
        private System.Windows.Forms.Label game;
    }
}

