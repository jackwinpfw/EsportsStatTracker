namespace EsportsStatTracker.Forms
{
    partial class NewGamePrompt
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
            this.PFWLabel = new System.Windows.Forms.Label();
            this.OppNameBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.PFWScore = new System.Windows.Forms.NumericUpDown();
            this.OppScore = new System.Windows.Forms.NumericUpDown();
            this.VSLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PFWScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OppScore)).BeginInit();
            this.SuspendLayout();
            // 
            // PFWLabel
            // 
            this.PFWLabel.AutoSize = true;
            this.PFWLabel.Font = new System.Drawing.Font("Oswald", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFWLabel.Location = new System.Drawing.Point(54, 15);
            this.PFWLabel.Name = "PFWLabel";
            this.PFWLabel.Size = new System.Drawing.Size(64, 46);
            this.PFWLabel.TabIndex = 0;
            this.PFWLabel.Text = "PFW";
            // 
            // OppNameBox
            // 
            this.OppNameBox.Font = new System.Drawing.Font("Oswald", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppNameBox.Location = new System.Drawing.Point(218, 12);
            this.OppNameBox.Name = "OppNameBox";
            this.OppNameBox.Size = new System.Drawing.Size(182, 47);
            this.OppNameBox.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(218, 178);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 38);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Oswald Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(93, 178);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 38);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PFWScore
            // 
            this.PFWScore.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PFWScore.Location = new System.Drawing.Point(56, 69);
            this.PFWScore.Name = "PFWScore";
            this.PFWScore.Size = new System.Drawing.Size(56, 37);
            this.PFWScore.TabIndex = 6;
            // 
            // OppScore
            // 
            this.OppScore.Font = new System.Drawing.Font("Oswald", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppScore.Location = new System.Drawing.Point(277, 69);
            this.OppScore.Name = "OppScore";
            this.OppScore.Size = new System.Drawing.Size(56, 37);
            this.OppScore.TabIndex = 7;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Font = new System.Drawing.Font("Oswald", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSLabel.Location = new System.Drawing.Point(172, 15);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(40, 46);
            this.VSLabel.TabIndex = 8;
            this.VSLabel.Text = "vs";
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(149, 78);
            this.DatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(100, 24);
            this.DatePicker.TabIndex = 9;
            this.DatePicker.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // NewGamePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 225);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.OppScore);
            this.Controls.Add(this.PFWScore);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.OppNameBox);
            this.Controls.Add(this.PFWLabel);
            this.Name = "NewGamePrompt";
            this.Text = "NewGamePrompt";
            ((System.ComponentModel.ISupportInitialize)(this.PFWScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OppScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PFWLabel;
        private System.Windows.Forms.TextBox OppNameBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown PFWScore;
        private System.Windows.Forms.NumericUpDown OppScore;
        private System.Windows.Forms.Label VSLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}