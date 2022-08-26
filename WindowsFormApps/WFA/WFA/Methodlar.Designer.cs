namespace WFA
{
    partial class Methodlar
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
            this.btnSavasci = new System.Windows.Forms.Button();
            this.btnOkcu = new System.Windows.Forms.Button();
            this.btnBüyücü = new System.Windows.Forms.Button();
            this.btnBerserk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSavasci
            // 
            this.btnSavasci.Location = new System.Drawing.Point(61, 129);
            this.btnSavasci.Name = "btnSavasci";
            this.btnSavasci.Size = new System.Drawing.Size(94, 28);
            this.btnSavasci.TabIndex = 0;
            this.btnSavasci.Text = "Savaşçı";
            this.btnSavasci.UseVisualStyleBackColor = true;
            this.btnSavasci.Click += new System.EventHandler(this.btnSavasci_Click);
            // 
            // btnOkcu
            // 
            this.btnOkcu.Location = new System.Drawing.Point(216, 129);
            this.btnOkcu.Name = "btnOkcu";
            this.btnOkcu.Size = new System.Drawing.Size(94, 28);
            this.btnOkcu.TabIndex = 0;
            this.btnOkcu.Text = "Okçu";
            this.btnOkcu.UseVisualStyleBackColor = true;
            this.btnOkcu.Click += new System.EventHandler(this.btnOkcu_Click);
            // 
            // btnBüyücü
            // 
            this.btnBüyücü.Location = new System.Drawing.Point(378, 129);
            this.btnBüyücü.Name = "btnBüyücü";
            this.btnBüyücü.Size = new System.Drawing.Size(94, 28);
            this.btnBüyücü.TabIndex = 0;
            this.btnBüyücü.Text = "Büyücü";
            this.btnBüyücü.UseVisualStyleBackColor = true;
            this.btnBüyücü.Click += new System.EventHandler(this.btnBüyücü_Click);
            // 
            // btnBerserk
            // 
            this.btnBerserk.Location = new System.Drawing.Point(545, 129);
            this.btnBerserk.Name = "btnBerserk";
            this.btnBerserk.Size = new System.Drawing.Size(94, 28);
            this.btnBerserk.TabIndex = 0;
            this.btnBerserk.Text = "Vahşi";
            this.btnBerserk.UseVisualStyleBackColor = true;
            this.btnBerserk.Click += new System.EventHandler(this.btnBerserk_Click);
            // 
            // Methodlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 459);
            this.Controls.Add(this.btnBerserk);
            this.Controls.Add(this.btnBüyücü);
            this.Controls.Add(this.btnOkcu);
            this.Controls.Add(this.btnSavasci);
            this.Name = "Methodlar";
            this.Text = "Methodlar";
            this.Load += new System.EventHandler(this.Methodlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavasci;
        private System.Windows.Forms.Button btnOkcu;
        private System.Windows.Forms.Button btnBüyücü;
        private System.Windows.Forms.Button btnBerserk;
    }
}