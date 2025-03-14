namespace Management.src
{
    partial class ManageForm
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
            backPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
            SuspendLayout();
            this.components = new System.ComponentModel.Container();
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = Color.FromArgb(15, 19, 32);
            this.backPictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.backPictureBox.Location = new Point(67, 53);
            this.backPictureBox.Margin = new Padding(2);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new Size(657, 435);
            this.backPictureBox.TabIndex = 0;
            this.backPictureBox.TabStop = false;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(20, 21, 40);
            this.ClientSize = new Size(784, 541);
            this.Controls.Add(this.backPictureBox);
            this.ForeColor = Color.White;
            this.Margin = new Padding(3, 2, 3, 2);
            this.MinimumSize = new Size(800, 580);
            this.Name = "ManageForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gerenciar";
            ((System.ComponentModel.ISupportInitialize)this.backPictureBox).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private PictureBox backPictureBox;
    }
}