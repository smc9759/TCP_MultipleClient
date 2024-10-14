namespace TCP_MultipleClient
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
            this.components = new System.ComponentModel.Container();
            this.Base_Theme_Manager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            this.kryptonListBox2 = new Krypton.Toolkit.KryptonListBox();
            this.SuspendLayout();
            // 
            // Base_Theme_Manager
            // 
            this.Base_Theme_Manager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365BlackDarkMode;
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Location = new System.Drawing.Point(86, 68);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Size = new System.Drawing.Size(259, 321);
            this.kryptonListBox1.TabIndex = 0;
            // 
            // kryptonListBox2
            // 
            this.kryptonListBox2.Location = new System.Drawing.Point(449, 68);
            this.kryptonListBox2.Name = "kryptonListBox2";
            this.kryptonListBox2.Size = new System.Drawing.Size(270, 321);
            this.kryptonListBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonListBox2);
            this.Controls.Add(this.kryptonListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonManager Base_Theme_Manager;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox2;
    }
}

