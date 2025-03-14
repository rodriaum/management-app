using Management.src.Components;

namespace management;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.passwordTextBox = new RoundedTextBox();
        this.emailTextBox = new RoundedTextBox();
        this.backPictureBox = new PictureBox();
        this.emailLabel = new Label();
        this.passwordLabel = new Label();
        this.loginButton = new Button();
        this.loginLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)this.backPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // passwordTextBox
        // 
        this.passwordTextBox.BorderStyle = BorderStyle.None;
        this.passwordTextBox.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.passwordTextBox.Location = new Point(262, 271);
        this.passwordTextBox.Margin = new Padding(3, 2, 3, 2);
        this.passwordTextBox.Multiline = true;
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.Size = new Size(288, 32);
        this.passwordTextBox.TabIndex = 2;
        this.passwordTextBox.TextAlign = HorizontalAlignment.Center;
        this.passwordTextBox.UseSystemPasswordChar = true;
        // 
        // emailTextBox
        // 
        this.emailTextBox.BorderStyle = BorderStyle.None;
        this.emailTextBox.Font = new Font("Barlow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.emailTextBox.Location = new Point(262, 207);
        this.emailTextBox.Margin = new Padding(3, 2, 3, 2);
        this.emailTextBox.Multiline = true;
        this.emailTextBox.Name = "emailTextBox";
        this.emailTextBox.Size = new Size(288, 32);
        this.emailTextBox.TabIndex = 1;
        this.emailTextBox.TextAlign = HorizontalAlignment.Center;
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
        // emailLabel
        // 
        this.emailLabel.AutoSize = true;
        this.emailLabel.BackColor = Color.FromArgb(15, 19, 32);
        this.emailLabel.Font = new Font("Barlow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.emailLabel.Location = new Point(262, 189);
        this.emailLabel.Margin = new Padding(2, 0, 2, 0);
        this.emailLabel.Name = "emailLabel";
        this.emailLabel.Size = new Size(40, 16);
        this.emailLabel.TabIndex = 0;
        this.emailLabel.Text = "E-Mail";
        this.emailLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // passwordLabel
        // 
        this.passwordLabel.AutoSize = true;
        this.passwordLabel.BackColor = Color.FromArgb(15, 19, 32);
        this.passwordLabel.Font = new Font("Barlow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.passwordLabel.Location = new Point(262, 254);
        this.passwordLabel.Margin = new Padding(2, 0, 2, 0);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new Size(59, 16);
        this.passwordLabel.TabIndex = 0;
        this.passwordLabel.Text = "Password";
        this.passwordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // loginButton
        // 
        this.loginButton.FlatStyle = FlatStyle.Flat;
        this.loginButton.Font = new Font("Barlow", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.loginButton.Location = new Point(262, 334);
        this.loginButton.Margin = new Padding(2);
        this.loginButton.Name = "loginButton";
        this.loginButton.Size = new Size(288, 35);
        this.loginButton.TabIndex = 3;
        this.loginButton.Text = "Login";
        this.loginButton.UseVisualStyleBackColor = true;
        this.loginButton.Click += this.loginButton_Click;
        // 
        // loginLabel
        // 
        this.loginLabel.AutoSize = true;
        this.loginLabel.BackColor = Color.FromArgb(15, 19, 32);
        this.loginLabel.Font = new Font("Barlow", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.loginLabel.Location = new Point(305, 108);
        this.loginLabel.Margin = new Padding(2, 0, 2, 0);
        this.loginLabel.Name = "loginLabel";
        this.loginLabel.Size = new Size(210, 37);
        this.loginLabel.TabIndex = 0;
        this.loginLabel.Text = "Olá, novamente!";
        this.loginLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(20, 21, 40);
        this.ClientSize = new Size(784, 541);
        this.Controls.Add(this.loginLabel);
        this.Controls.Add(this.loginButton);
        this.Controls.Add(this.passwordLabel);
        this.Controls.Add(this.emailLabel);
        this.Controls.Add(this.emailTextBox);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.backPictureBox);
        this.ForeColor = Color.White;
        this.Margin = new Padding(3, 2, 3, 2);
        this.MinimumSize = new Size(800, 580);
        this.Name = "LoginForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Login";
        ((System.ComponentModel.ISupportInitialize)this.backPictureBox).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private RoundedTextBox passwordTextBox;
    private RoundedTextBox emailTextBox;
    private PictureBox pictureBox1;
    private Label emailLabel;
    private Label passwordLabel;
    private Button loginButton;
    private Label loginLabel;
    private PictureBox backPictureBox;
}
