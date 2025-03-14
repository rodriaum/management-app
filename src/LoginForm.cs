using management.Helpers;

namespace management;

public partial class LoginForm : Form
{
    private Size originalFormSize;
    private Dictionary<Control, Rectangle> originalControlData = new Dictionary<Control, Rectangle>();

    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        originalFormSize = this.Size;

        foreach (Control control in this.Controls)
        {
            originalControlData.Add(control, new Rectangle(control.Location, control.Size));

            if (control is Label label && label.AutoSize)
            {
                label.Tag = label.Font.Size;
            }
        }
    }

    private void LoginForm_Resize(object sender, EventArgs e)
    {
        ResizeAllControls();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string email = emailTextBox.Text
            .Replace("\n", ""); // Multi-line TextBox

        string password = passwordTextBox.Text
            .Replace("\n", ""); // Multi-line TextBox

        string hashPassword = EncryptionHelper.HashTextToSHA256(password);
    }

    private void ResizeAllControls()
    {
        float widthRatio = (float)this.Width / originalFormSize.Width;
        float heightRatio = (float)this.Height / originalFormSize.Height;

        foreach (Control control in this.Controls)
        {
            if (originalControlData.TryGetValue(control, out Rectangle originalRect))
            {
                int newX = (int)(originalRect.X * widthRatio);
                int newY = (int)(originalRect.Y * heightRatio);
                int newWidth = (int)(originalRect.Width * widthRatio);
                int newHeight = (int)(originalRect.Height * heightRatio);

                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);

                if (control is Label label && label.Tag != null)
                {
                    float originalFontSize = (float)label.Tag;
                    float scaleFactor = Math.Min(widthRatio, heightRatio);
                    label.Font = new Font(label.Font.FontFamily, originalFontSize * scaleFactor, label.Font.Style);
                }

                if (control is TextBox textBox)
                {
                    if (textBox.Tag == null)
                        textBox.Tag = textBox.Font.Size;

                    float originalFontSize = (float)textBox.Tag;
                    float scaleFactor = Math.Min(widthRatio, heightRatio);
                    textBox.Font = new Font(textBox.Font.FontFamily, originalFontSize * scaleFactor, textBox.Font.Style);
                }

                if (control is Button button)
                {
                    if (button.Tag == null)
                        button.Tag = button.Font.Size;

                    float originalFontSize = (float)button.Tag;
                    float scaleFactor = Math.Min(widthRatio, heightRatio);
                    button.Font = new Font(button.Font.FontFamily, originalFontSize * scaleFactor, button.Font.Style);
                }
            }
        }
    }
}
