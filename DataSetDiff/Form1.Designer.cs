namespace DataSetDiff
{
    partial class Form1
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
            this.TxtDataSet1 = new System.Windows.Forms.TextBox();
            this.TxtDataSet2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.TxtResult1 = new System.Windows.Forms.TextBox();
            this.TxtResult2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDataSet1
            // 
            this.TxtDataSet1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtDataSet1.Location = new System.Drawing.Point(26, 46);
            this.TxtDataSet1.MaxLength = 0;
            this.TxtDataSet1.Multiline = true;
            this.TxtDataSet1.Name = "TxtDataSet1";
            this.TxtDataSet1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDataSet1.Size = new System.Drawing.Size(362, 291);
            this.TxtDataSet1.TabIndex = 0;
            // 
            // TxtDataSet2
            // 
            this.TxtDataSet2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtDataSet2.Location = new System.Drawing.Point(426, 46);
            this.TxtDataSet2.MaxLength = 0;
            this.TxtDataSet2.Multiline = true;
            this.TxtDataSet2.Name = "TxtDataSet2";
            this.TxtDataSet2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDataSet2.Size = new System.Drawing.Size(362, 291);
            this.TxtDataSet2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DataSet 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(430, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataSet 2";
            // 
            // BtnCompare
            // 
            this.BtnCompare.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCompare.Location = new System.Drawing.Point(348, 362);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(102, 33);
            this.BtnCompare.TabIndex = 4;
            this.BtnCompare.Text = "compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // TxtResult1
            // 
            this.TxtResult1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtResult1.Location = new System.Drawing.Point(26, 451);
            this.TxtResult1.MaxLength = 0;
            this.TxtResult1.Multiline = true;
            this.TxtResult1.Name = "TxtResult1";
            this.TxtResult1.ReadOnly = true;
            this.TxtResult1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult1.Size = new System.Drawing.Size(362, 208);
            this.TxtResult1.TabIndex = 5;
            // 
            // TxtResult2
            // 
            this.TxtResult2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtResult2.Location = new System.Drawing.Point(434, 451);
            this.TxtResult2.MaxLength = 0;
            this.TxtResult2.Multiline = true;
            this.TxtResult2.Name = "TxtResult2";
            this.TxtResult2.ReadOnly = true;
            this.TxtResult2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult2.Size = new System.Drawing.Size(362, 208);
            this.TxtResult2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataSet 1 - DataSet 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(430, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "DataSet 2 - DataSet 1";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(26, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(767, 2);
            this.label5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 683);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtResult2);
            this.Controls.Add(this.TxtResult1);
            this.Controls.Add(this.BtnCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDataSet2);
            this.Controls.Add(this.TxtDataSet1);
            this.Name = "Form1";
            this.Text = "Data Set Diff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDataSet1;
        private System.Windows.Forms.TextBox TxtDataSet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCompare;
        private System.Windows.Forms.TextBox TxtResult1;
        private System.Windows.Forms.TextBox TxtResult2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}