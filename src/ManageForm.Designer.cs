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
            backPictureBox.BackColor = Color.FromArgb(15, 19, 32);
            backPictureBox.Location = new Point(53, 61);
            backPictureBox.Name = "backPictureBox";
            backPictureBox.Size = new Size(886, 448);
            backPictureBox.TabIndex = 0;
            backPictureBox.TabStop = false;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 21, 40);
            ClientSize = new Size(1000, 562);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MinimumSize = new Size(800, 500);
            Controls.Add(backPictureBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backPictureBox;
    }
}