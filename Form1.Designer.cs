namespace Compresson
{
    partial class frmCompressorForm
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
            this.btnFiles = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblByte1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblLinesRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(13, 13);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(1106, 21);
            this.btnFiles.TabIndex = 0;
            this.btnFiles.Text = "Get File";
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1106, 184);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lblByte1
            // 
            this.lblByte1.AutoSize = true;
            this.lblByte1.Location = new System.Drawing.Point(10, 37);
            this.lblByte1.Name = "lblByte1";
            this.lblByte1.Size = new System.Drawing.Size(73, 13);
            this.lblByte1.TabIndex = 8;
            this.lblByte1.Text = "Bytes of File 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bytes of File 1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(13, 258);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1106, 184);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(12, 445);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(73, 13);
            this.lblTimeElapsed.TabIndex = 11;
            this.lblTimeElapsed.Text = "Bytes of File 1";
            // 
            // lblLinesRead
            // 
            this.lblLinesRead.AutoSize = true;
            this.lblLinesRead.Location = new System.Drawing.Point(236, 445);
            this.lblLinesRead.Name = "lblLinesRead";
            this.lblLinesRead.Size = new System.Drawing.Size(73, 13);
            this.lblLinesRead.TabIndex = 12;
            this.lblLinesRead.Text = "Bytes of File 1";
            // 
            // frmCompressorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 467);
            this.Controls.Add(this.lblLinesRead);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lblByte1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFiles);
            this.Name = "frmCompressorForm";
            this.ShowIcon = false;
            this.Text = "Compressor Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblByte1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblLinesRead;

    }
}

