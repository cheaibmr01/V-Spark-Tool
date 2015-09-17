namespace V_Spark_Provision
{
    partial class CopyPage
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
            this.txtSourceDest = new System.Windows.Forms.TextBox();
            this.txtFinalDest = new System.Windows.Forms.TextBox();
            this.cmdSelectSource = new System.Windows.Forms.Button();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdSelectDestination = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSourceDest
            // 
            this.txtSourceDest.Location = new System.Drawing.Point(170, 53);
            this.txtSourceDest.Name = "txtSourceDest";
            this.txtSourceDest.Size = new System.Drawing.Size(268, 20);
            this.txtSourceDest.TabIndex = 0;
            // 
            // txtFinalDest
            // 
            this.txtFinalDest.Location = new System.Drawing.Point(170, 89);
            this.txtFinalDest.Name = "txtFinalDest";
            this.txtFinalDest.Size = new System.Drawing.Size(268, 20);
            this.txtFinalDest.TabIndex = 3;
            // 
            // cmdSelectSource
            // 
            this.cmdSelectSource.Location = new System.Drawing.Point(12, 50);
            this.cmdSelectSource.Name = "cmdSelectSource";
            this.cmdSelectSource.Size = new System.Drawing.Size(144, 23);
            this.cmdSelectSource.TabIndex = 4;
            this.cmdSelectSource.Text = "Select Source Folder";
            this.cmdSelectSource.UseVisualStyleBackColor = true;
            this.cmdSelectSource.Click += new System.EventHandler(this.cmdSelectSource_Click);
            // 
            // cmdSelectDestination
            // 
            this.cmdSelectDestination.Location = new System.Drawing.Point(12, 86);
            this.cmdSelectDestination.Name = "cmdSelectDestination";
            this.cmdSelectDestination.Size = new System.Drawing.Size(144, 23);
            this.cmdSelectDestination.TabIndex = 5;
            this.cmdSelectDestination.Text = "Select Destination Folder";
            this.cmdSelectDestination.UseVisualStyleBackColor = true;
            this.cmdSelectDestination.Click += new System.EventHandler(this.cmdSelectDestination_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdSelectDestination);
            this.Controls.Add(this.cmdSelectSource);
            this.Controls.Add(this.txtFinalDest);
            this.Controls.Add(this.txtSourceDest);
            this.Name = "CopyPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CopyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDest;
        private System.Windows.Forms.TextBox txtFinalDest;
        private System.Windows.Forms.Button cmdSelectSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.Button cmdSelectDestination;
        private System.Windows.Forms.Button button1;
    }
}