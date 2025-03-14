using management.Components;

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
        passwordTextBox = new RoundedTextBox();
        emailTextBox = new RoundedTextBox();
        backPictureBox = new PictureBox();
        emailLabel = new Label();
        passwordLabel = new Label();
        loginButton = new Button();
        loginLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)backPictureBox).BeginInit();
        SuspendLayout();
        // 
        // passwordTextBox
        // 
        passwordTextBox.BorderStyle = BorderStyle.None;
        passwordTextBox.Location = new Point(364, 317);
        passwordTextBox.Margin = new Padding(4);
        passwordTextBox.Multiline = true;
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(300, 34);
        passwordTextBox.TabIndex = 2;
        // 
        // emailTextBox
        // 
        emailTextBox.BorderStyle = BorderStyle.None;
        emailTextBox.Location = new Point(364, 227);
        emailTextBox.Margin = new Padding(4);
        emailTextBox.Multiline = true;
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(300, 34);
        emailTextBox.TabIndex = 1;
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
        // emailLabel
        // 
        emailLabel.AutoSize = true;
        emailLabel.BackColor = Color.FromArgb(15, 19, 32);
        emailLabel.Location = new Point(364, 198);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(45, 25);
        emailLabel.TabIndex = 0;
        emailLabel.Text = "Mail";
        emailLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.BackColor = Color.FromArgb(15, 19, 32);
        passwordLabel.Location = new Point(364, 288);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(87, 25);
        passwordLabel.TabIndex = 0;
        passwordLabel.Text = "Password";
        passwordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // loginButton
        // 
        loginButton.FlatStyle = FlatStyle.Flat;
        loginButton.Location = new Point(364, 393);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(300, 41);
        loginButton.TabIndex = 3;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        // 
        // loginLabel
        // 
        loginLabel.AutoSize = true;
        loginLabel.BackColor = Color.FromArgb(15, 19, 32);
        loginLabel.Font = new Font("Barlow", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        loginLabel.Location = new Point(447, 104);
        loginLabel.Name = "loginLabel";
        loginLabel.Size = new Size(133, 54);
        loginLabel.TabIndex = 0;
        loginLabel.Text = "LOGIN";
        loginLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(20, 21, 40);
        ClientSize = new Size(1000, 562);
        Controls.Add(loginLabel);
        Controls.Add(loginButton);
        Controls.Add(passwordLabel);
        Controls.Add(emailLabel);
        Controls.Add(emailTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(backPictureBox);
        ForeColor = Color.White;
        Margin = new Padding(4);
        MinimumSize = new Size(800, 500);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        Load += LoginForm_Load;
        Resize += LoginForm_Resize;
        ((System.ComponentModel.ISupportInitialize)backPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
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
