namespace EsportsStatTracker.Forms
{
    partial class TeamGames
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
            this.Title = new System.Windows.Forms.Label();
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TablePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Oswald Medium", 30F);
            this.Title.Location = new System.Drawing.Point(3, -3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(204, 68);
            this.Title.TabIndex = 0;
            this.Title.Text = "Team name";
            // 
            // TablePanel
            // 
            this.TablePanel.ColumnCount = 1;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.TablePanel.Controls.Add(this.FlowPanel, 0, 1);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(800, 461);
            this.TablePanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.NewGameButton);
            this.HeaderPanel.Controls.Add(this.Title);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(794, 64);
            this.HeaderPanel.TabIndex = 1;
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackgroundImage = global::EsportsStatTracker.Properties.Resources.plus;
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(700, 1);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(60, 60);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "+";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGame);
            // 
            // FlowPanel
            // 
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(3, 73);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(794, 385);
            this.FlowPanel.TabIndex = 2;
            // 
            // TeamGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.TablePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamGames";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TablePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
    }
}