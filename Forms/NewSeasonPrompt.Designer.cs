namespace EsportsStatTracker
{
    partial class NewSeasonPrompt
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
            this.PromptLabel = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.yearSelector = new System.Windows.Forms.NumericUpDown();
            this.radioFall = new System.Windows.Forms.RadioButton();
            this.radioSpring = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.yearSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Font = new System.Drawing.Font("Oswald Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.Location = new System.Drawing.Point(9, 10);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(186, 27);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "Enter the semester and year";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(47, 83);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 38);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(161, 83);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 38);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // yearSelector
            // 
            this.yearSelector.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearSelector.Location = new System.Drawing.Point(161, 45);
            this.yearSelector.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearSelector.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yearSelector.Name = "yearSelector";
            this.yearSelector.Size = new System.Drawing.Size(75, 24);
            this.yearSelector.TabIndex = 4;
            this.yearSelector.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // radioFall
            // 
            this.radioFall.AutoSize = true;
            this.radioFall.Location = new System.Drawing.Point(34, 49);
            this.radioFall.Name = "radioFall";
            this.radioFall.Size = new System.Drawing.Size(41, 17);
            this.radioFall.TabIndex = 5;
            this.radioFall.TabStop = true;
            this.radioFall.Text = "Fall";
            this.radioFall.UseVisualStyleBackColor = true;
            // 
            // radioSpring
            // 
            this.radioSpring.AutoSize = true;
            this.radioSpring.Location = new System.Drawing.Point(81, 49);
            this.radioSpring.Name = "radioSpring";
            this.radioSpring.Size = new System.Drawing.Size(55, 17);
            this.radioSpring.TabIndex = 6;
            this.radioSpring.TabStop = true;
            this.radioSpring.Text = "Spring";
            this.radioSpring.UseVisualStyleBackColor = true;
            // 
            // NewSeasonPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.radioSpring);
            this.Controls.Add(this.radioFall);
            this.Controls.Add(this.yearSelector);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.PromptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSeasonPrompt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.yearSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown yearSelector;
        private System.Windows.Forms.RadioButton radioFall;
        private System.Windows.Forms.RadioButton radioSpring;
    }
}