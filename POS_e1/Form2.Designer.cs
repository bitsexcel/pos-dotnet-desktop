namespace POS_e1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPOS
            // 
            this.buttonPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPOS.BackgroundImage")));
            this.buttonPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPOS.Location = new System.Drawing.Point(131, 89);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Size = new System.Drawing.Size(114, 55);
            this.buttonPOS.TabIndex = 0;
            this.buttonPOS.Text = "Punto Venta";
            this.buttonPOS.UseVisualStyleBackColor = true;
            this.buttonPOS.Click += new System.EventHandler(this.buttonPOS_Click);
            // 
            // buttonInv
            // 
            this.buttonInv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInv.BackgroundImage")));
            this.buttonInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInv.Location = new System.Drawing.Point(290, 89);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(115, 55);
            this.buttonInv.TabIndex = 1;
            this.buttonInv.Text = "Inventario";
            this.buttonInv.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 250);
            this.Controls.Add(this.buttonInv);
            this.Controls.Add(this.buttonPOS);
            this.Name = "Form2";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonInv;
    }
}