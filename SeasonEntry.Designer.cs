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
            this.SeasonTitle = new System.Windows.Forms.Label();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TablePanel.ColumnCount = 1;
            this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel.Controls.Add(this.SeasonTitle, 0, 0);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.RowCount = 2;
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel.Size = new System.Drawing.Size(445, 300);
            this.TablePanel.TabIndex = 1;
            // 
            // SeasonTitle
            // 
            this.SeasonTitle.Font = new System.Drawing.Font("Oswald Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonTitle.Location = new System.Drawing.Point(3, 0);
            this.SeasonTitle.Name = "SeasonTitle";
            this.SeasonTitle.Size = new System.Drawing.Size(439, 50);
            this.SeasonTitle.TabIndex = 1;
            this.SeasonTitle.Text = "Season Title";
            this.SeasonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeasonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SeasonEntry";
            this.Size = new System.Drawing.Size(445, 300);
            this.TablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TablePanel;
        private System.Windows.Forms.Label SeasonTitle;
    }
}
