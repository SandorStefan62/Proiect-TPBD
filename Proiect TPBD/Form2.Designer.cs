namespace WindowsFormsApplication2
{
    partial class FormPassword
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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirmare = new System.Windows.Forms.Button();
            this.buttonRenuntare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(12, 35);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(259, 20);
            this.textBoxParola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti Parola:";
            // 
            // buttonConfirmare
            // 
            this.buttonConfirmare.Location = new System.Drawing.Point(12, 61);
            this.buttonConfirmare.Name = "buttonConfirmare";
            this.buttonConfirmare.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmare.TabIndex = 2;
            this.buttonConfirmare.Text = "Confirmare";
            this.buttonConfirmare.UseVisualStyleBackColor = true;
            this.buttonConfirmare.Click += new System.EventHandler(this.buttonConfirmare_Click);
            // 
            // buttonRenuntare
            // 
            this.buttonRenuntare.Location = new System.Drawing.Point(196, 61);
            this.buttonRenuntare.Name = "buttonRenuntare";
            this.buttonRenuntare.Size = new System.Drawing.Size(75, 23);
            this.buttonRenuntare.TabIndex = 3;
            this.buttonRenuntare.Text = "Renuntare";
            this.buttonRenuntare.UseVisualStyleBackColor = true;
            this.buttonRenuntare.Click += new System.EventHandler(this.buttonRenuntare_Click);
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.buttonRenuntare);
            this.Controls.Add(this.buttonConfirmare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParola);
            this.Name = "FormPassword";
            this.Text = "Parola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirmare;
        private System.Windows.Forms.Button buttonRenuntare;
    }
}