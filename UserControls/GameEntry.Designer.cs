namespace EsportsStatTracker.UserControls
{
    partial class GameEntry
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
            this.Title = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditMatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Oswald", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(506, 65);
            this.Title.TabIndex = 0;
            this.Title.Text = "MatchTitle";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.trash;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(634, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(60, 60);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditMatchButton
            // 
            this.EditMatchButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.pencil;
            this.EditMatchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditMatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditMatchButton.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMatchButton.Location = new System.Drawing.Point(700, 2);
            this.EditMatchButton.Name = "EditMatchButton";
            this.EditMatchButton.Size = new System.Drawing.Size(60, 60);
            this.EditMatchButton.TabIndex = 5;
            this.EditMatchButton.UseVisualStyleBackColor = true;
            // 
            // GameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditMatchButton);
            this.Controls.Add(this.Title);
            this.Name = "GameEntry";
            this.Size = new System.Drawing.Size(800, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditMatchButton;
    }
}
