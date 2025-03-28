namespace MaiaeLeo
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
            this.btngerar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(273, 230);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(264, 69);
            this.btngerar.TabIndex = 0;
            this.btngerar.Text = "gerar";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(313, 160);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtnumero.Size = new System.Drawing.Size(51, 64);
            this.txtnumero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btngerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.TextBox txtnumero;
    }
}

