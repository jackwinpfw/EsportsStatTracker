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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditTeamButton = new System.Windows.Forms.Button();
            this.EditGamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.Location = new System.Drawing.Point(2, 2);
            this.GameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(498, 56);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "Game Title";
            this.GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.trash;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(504, 2);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(60, 60);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteTeam);
            // 
            // EditTeamButton
            // 
            this.EditTeamButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.pencil;
            this.EditTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTeamButton.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTeamButton.Location = new System.Drawing.Point(568, 2);
            this.EditTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditTeamButton.Name = "EditTeamButton";
            this.EditTeamButton.Size = new System.Drawing.Size(60, 60);
            this.EditTeamButton.TabIndex = 2;
            this.EditTeamButton.UseVisualStyleBackColor = true;
            this.EditTeamButton.Click += new System.EventHandler(this.EditTeam);
            // 
            // EditGamesButton
            // 
            this.EditGamesButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.controller;
            this.EditGamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditGamesButton.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditGamesButton.Location = new System.Drawing.Point(632, 2);
            this.EditGamesButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditGamesButton.Name = "EditGamesButton";
            this.EditGamesButton.Size = new System.Drawing.Size(60, 60);
            this.EditGamesButton.TabIndex = 1;
            this.EditGamesButton.UseVisualStyleBackColor = true;
            // 
            // TeamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditTeamButton);
            this.Controls.Add(this.EditGamesButton);
            this.Controls.Add(this.GameTitle);
            this.Name = "TeamEntry";
            this.Size = new System.Drawing.Size(694, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Button EditGamesButton;
        private System.Windows.Forms.Button EditTeamButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
