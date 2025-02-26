namespace EsportsStatTracker
{
    partial class TeamEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameTitle = new System.Windows.Forms.Label();
            this.EditGamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.Location = new System.Drawing.Point(3, 3);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(294, 69);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "Game Title";
            this.GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditGamesButton
            // 
            this.EditGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditGamesButton.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGamesButton.Location = new System.Drawing.Point(828, 3);
            this.EditGamesButton.Name = "EditGamesButton";
            this.EditGamesButton.Size = new System.Drawing.Size(94, 69);
            this.EditGamesButton.TabIndex = 1;
            this.EditGamesButton.Text = "Edit\r\nGames";
            this.EditGamesButton.UseVisualStyleBackColor = true;
            // 
            // TeamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditGamesButton);
            this.Controls.Add(this.GameTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamEntry";
            this.Size = new System.Drawing.Size(925, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Button EditGamesButton;
    }
}
