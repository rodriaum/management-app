using Management.src.Helpers;
using Management.src.Template;

namespace management;

public partial class LoginForm : TemplateForm
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string email = emailTextBox.Text
            .Replace("\n", ""); // Multi-line TextBox

        string password = passwordTextBox.Text
            .Replace("\n", ""); // Multi-line TextBox

        string hashPassword = EncryptionHelper.HashTextToSHA256(password);
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}