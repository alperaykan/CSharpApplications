namespace WFA
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnBirinci = new System.Windows.Forms.Button();
            this.btnİkinci = new System.Windows.Forms.Button();
            this.btnUcuncu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(398, 22);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 32);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            this.btnClick.MouseHover += new System.EventHandler(this.btnClick_MouseHover);
            // 
            // btnBirinci
            // 
            this.btnBirinci.Location = new System.Drawing.Point(85, 116);
            this.btnBirinci.Name = "btnBirinci";
            this.btnBirinci.Size = new System.Drawing.Size(152, 69);
            this.btnBirinci.TabIndex = 1;
            this.btnBirinci.UseVisualStyleBackColor = true;
            this.btnBirinci.Click += new System.EventHandler(this.button1_Click);
            this.btnBirinci.MouseEnter += new System.EventHandler(this.btnBirinci_MouseEnter);
            // 
            // btnİkinci
            // 
            this.btnİkinci.Location = new System.Drawing.Point(666, 116);
            this.btnİkinci.Name = "btnİkinci";
            this.btnİkinci.Size = new System.Drawing.Size(152, 69);
            this.btnİkinci.TabIndex = 2;
            this.btnİkinci.UseVisualStyleBackColor = true;
            this.btnİkinci.MouseEnter += new System.EventHandler(this.btnİkinci_MouseEnter);
            // 
            // btnUcuncu
            // 
            this.btnUcuncu.Location = new System.Drawing.Point(398, 116);
            this.btnUcuncu.Name = "btnUcuncu";
            this.btnUcuncu.Size = new System.Drawing.Size(117, 69);
            this.btnUcuncu.TabIndex = 3;
            this.btnUcuncu.UseVisualStyleBackColor = true;
            this.btnUcuncu.MouseEnter += new System.EventHandler(this.btnUcuncu_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 527);
            this.Controls.Add(this.btnUcuncu);
            this.Controls.Add(this.btnİkinci);
            this.Controls.Add(this.btnBirinci);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnBirinci;
        private System.Windows.Forms.Button btnİkinci;
        private System.Windows.Forms.Button btnUcuncu;
    }
}

