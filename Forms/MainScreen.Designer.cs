namespace EsportsStatTracker
{
    partial class MainScreen
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
            this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.NewSeasonButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.seasonEntry1 = new EsportsStatTracker.SeasonEntry();
            this.TablePanel.SuspendLayout();
            this.FlowPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePanel.ColumnCount = 1;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.Controls.Add(this.FlowPanel, 0, 1);
            this.TablePanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(738, 565);
            this.TablePanel.TabIndex = 1;
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanel.AutoScroll = true;
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.Controls.Add(this.seasonEntry1);
            this.FlowPanel.Location = new System.Drawing.Point(3, 103);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(732, 462);
            this.FlowPanel.TabIndex = 2;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HeaderPanel.Controls.Add(this.NewSeasonButton);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(738, 100);
            this.HeaderPanel.TabIndex = 3;
            // 
            // NewSeasonButton
            // 
            this.NewSeasonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSeasonButton.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSeasonButton.Location = new System.Drawing.Point(625, 25);
            this.NewSeasonButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewSeasonButton.Name = "NewSeasonButton";
            this.NewSeasonButton.Size = new System.Drawing.Size(100, 50);
            this.NewSeasonButton.TabIndex = 2;
            this.NewSeasonButton.Text = "New Season";
            this.NewSeasonButton.UseVisualStyleBackColor = true;
            this.NewSeasonButton.Click += new System.EventHandler(this.NewSeason);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Oswald Medium", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, -15);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(596, 120);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Esports Data Tracker";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seasonEntry1
            // 
            this.seasonEntry1.AutoSize = true;
            this.seasonEntry1.Location = new System.Drawing.Point(0, 0);
            this.seasonEntry1.Margin = new System.Windows.Forms.Padding(0);
            this.seasonEntry1.Name = "seasonEntry1";
            this.seasonEntry1.Size = new System.Drawing.Size(0, 0);
            this.seasonEntry1.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.TablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TablePanel.ResumeLayout(false);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button NewSeasonButton;
        private SeasonEntry seasonEntry1;
    }
}

