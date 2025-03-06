namespace EsportsStatTracker
{
    partial class SeasonEntry
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
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditSeasonButton = new System.Windows.Forms.Button();
            this.NewTeamButton = new System.Windows.Forms.Button();
            this.SeasonTitle = new System.Windows.Forms.Label();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TablePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.SystemColors.Control;
            this.TablePanel.ColumnCount = 1;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.TablePanel.Controls.Add(this.FlowPanel, 0, 1);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(712, 300);
            this.TablePanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.DeleteButton);
            this.HeaderPanel.Controls.Add(this.EditSeasonButton);
            this.HeaderPanel.Controls.Add(this.NewTeamButton);
            this.HeaderPanel.Controls.Add(this.SeasonTitle);
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(695, 162);
            this.HeaderPanel.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.trash;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(542, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(60, 60);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteSeason);
            // 
            // EditSeasonButton
            // 
            this.EditSeasonButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.pencil;
            this.EditSeasonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditSeasonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSeasonButton.Font = new System.Drawing.Font("Oswald Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSeasonButton.Location = new System.Drawing.Point(632, 3);
            this.EditSeasonButton.Name = "EditSeasonButton";
            this.EditSeasonButton.Size = new System.Drawing.Size(60, 60);
            this.EditSeasonButton.TabIndex = 3;
            this.EditSeasonButton.UseVisualStyleBackColor = true;
            this.EditSeasonButton.Click += new System.EventHandler(this.EditSeasonClick);
            // 
            // NewTeamButton
            // 
            this.NewTeamButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.plus;
            this.NewTeamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTeamButton.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamButton.Location = new System.Drawing.Point(632, 93);
            this.NewTeamButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewTeamButton.Name = "NewTeamButton";
            this.NewTeamButton.Size = new System.Drawing.Size(60, 60);
            this.NewTeamButton.TabIndex = 2;
            this.NewTeamButton.Text = "+";
            this.NewTeamButton.UseVisualStyleBackColor = true;
            this.NewTeamButton.Click += new System.EventHandler(this.NewTeam);
            // 
            // SeasonTitle
            // 
            this.SeasonTitle.Font = new System.Drawing.Font("Oswald SemiBold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonTitle.Location = new System.Drawing.Point(1, 0);
            this.SeasonTitle.Name = "SeasonTitle";
            this.SeasonTitle.Size = new System.Drawing.Size(525, 162);
            this.SeasonTitle.TabIndex = 1;
            this.SeasonTitle.Text = "Season Title";
            this.SeasonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSize = true;
            this.FlowPanel.Location = new System.Drawing.Point(2, 170);
            this.FlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(0, 0);
            this.FlowPanel.TabIndex = 3;
            // 
            // SeasonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SeasonEntry";
            this.Size = new System.Drawing.Size(712, 300);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Label SeasonTitle;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button EditSeasonButton;
        private System.Windows.Forms.Button NewTeamButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Button DeleteButton;
    }
}
