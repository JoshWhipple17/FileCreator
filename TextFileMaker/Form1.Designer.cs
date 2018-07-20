namespace TextFileMaker
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.btnXMLFile = new System.Windows.Forms.Button();
            this.btnBinaryFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The File Maker";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(10, 62);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject:";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(10, 108);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(61, 20);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(74, 62);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(277, 24);
            this.txtSubject.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(74, 108);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(277, 147);
            this.txtContent.TabIndex = 1;
            // 
            // btnTextFile
            // 
            this.btnTextFile.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFile.Location = new System.Drawing.Point(97, 279);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(198, 42);
            this.btnTextFile.TabIndex = 2;
            this.btnTextFile.Text = "Make a Text File";
            this.btnTextFile.UseVisualStyleBackColor = true;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // btnXMLFile
            // 
            this.btnXMLFile.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLFile.Location = new System.Drawing.Point(97, 337);
            this.btnXMLFile.Name = "btnXMLFile";
            this.btnXMLFile.Size = new System.Drawing.Size(198, 42);
            this.btnXMLFile.TabIndex = 3;
            this.btnXMLFile.Text = "Make a XML File";
            this.btnXMLFile.UseVisualStyleBackColor = true;
            this.btnXMLFile.Click += new System.EventHandler(this.btnXMLFile_Click);
            // 
            // btnBinaryFile
            // 
            this.btnBinaryFile.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryFile.Location = new System.Drawing.Point(97, 394);
            this.btnBinaryFile.Name = "btnBinaryFile";
            this.btnBinaryFile.Size = new System.Drawing.Size(198, 44);
            this.btnBinaryFile.TabIndex = 4;
            this.btnBinaryFile.Text = "Make a Binary File";
            this.btnBinaryFile.UseVisualStyleBackColor = true;
            this.btnBinaryFile.Click += new System.EventHandler(this.btnBinaryFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(363, 472);
            this.Controls.Add(this.btnBinaryFile);
            this.Controls.Add(this.btnXMLFile);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "The File Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.Button btnXMLFile;
        private System.Windows.Forms.Button btnBinaryFile;
    }
}

