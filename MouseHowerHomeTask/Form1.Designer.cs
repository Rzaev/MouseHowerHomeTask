
namespace MouseHowerHomeTask
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
            this.FemaleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FemaleBtn
            // 
            this.FemaleBtn.BackgroundImage = global::MouseHowerHomeTask.Properties.Resources.Femalee;
            this.FemaleBtn.Location = new System.Drawing.Point(217, 310);
            this.FemaleBtn.Name = "FemaleBtn";
            this.FemaleBtn.Size = new System.Drawing.Size(100, 100);
            this.FemaleBtn.TabIndex = 2;
            this.FemaleBtn.UseVisualStyleBackColor = true;
            this.FemaleBtn.MouseHover += new System.EventHandler(this.FemaleBtn_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FemaleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FemaleBtn;
    }
}

