using System;
using System.Windows.Forms;
using System.Drawing;

public class EmojiBoard : Form
{
    private Button[] sectionButtons;
    private int currentSection = 0;

    // Emojis for the sections
    private string[] section1 = { "😊", "😂", "😎", "🗿", "❤️", "🔥", "💀", "🤣", "😅", "😉", "🖕", "😭" };
    private string[] section2 = { "🙏", "🙌", "😆", "🤪", "💩", "😜", "🤷‍♂️", "😍", "😏", "🌹", "✨", "🎉" };
    // Section 3 (12 emojis)
    private string[] section3 = { "💥", "🎃", "👑", "🎯", "🐍", "💎", "🌈", "🦄", "🐲", "🎶", "🦋", "🌻" };

    // Section 4 (12 emojis)
    private string[] section4 = { "🥇", "🏆", "🎁", "🍀", "🍒", "🍉", "🍌", "🍓", "🍍", "🥥", "🍆", "🥑" };

    // Section 5 (12 emojis)
    private string[] section5 = { "🌹", "🌸", "🌺", "💐", "💋", "🥀", "🌼", "🌻", "💝", "🌷", "🍃", "🌱" };

    // Section 6 (12 emojis)
    private string[] section6 = { "👀", "💋", "👄", "👂", "👃", "🧠", "🦷", "👣", "🦻", "🦴", "🦷", "💀" };

    // Section 7 (12 emojis)
    private string[] section7 = { "🥶", "🥵", "😇", "😈", "👹", "👺", "👻", "👽", "🤖", "👾", "🛸", "💣" };
        
    private Button leftArrowButton;
    private Button rightArrowButton;

    public EmojiBoard()
    {
        // Set up form
        this.Text = "Emoji Board";
        this.Width = 400;
        this.Height = 300;
        
        // Always on top
        this.TopMost = true;

        // Initializing buttons
        leftArrowButton = new Button();
        leftArrowButton.Text = "Prev";
        leftArrowButton.Location = new Point(20, 10);
        leftArrowButton.Click += LeftArrowButton_Click;

        rightArrowButton = new Button();
        rightArrowButton.Text = "Next";
        rightArrowButton.Location = new Point(300, 10);
        rightArrowButton.Click += RightArrowButton_Click;

        // Add arrow buttons to form
        this.Controls.Add(leftArrowButton);
        this.Controls.Add(rightArrowButton);

        // Create buttons for emojis based on current section
        CreateSectionButtons();

        // Adjust button size (width and height)
        int buttonWidth = 50;
        int buttonHeight = 50;

        // Update buttons with the emojis of the current section
        UpdateSection();
    }

    private void CreateSectionButtons()
    {
        sectionButtons = new Button[12];  // Max emojis in a section (12)

        for (int i = 0; i < sectionButtons.Length; i++)
        {
            Button btn = new Button();
            btn.Font = new Font("Segoe UI Emoji", 12);
            btn.Width = 50;  // Set uniform width
            btn.Height = 50; // Set uniform height
            btn.Location = new Point(20 + (i % 4) * 60, 60 + (i / 4) * 60);  // Grid-like layout

            sectionButtons[i] = btn;
            this.Controls.Add(btn);
        }
    }

    private void UpdateSection()
    {
        // Array of all sections
        string[][] allSections = new string[][]
        {
            section1, section2, section3, section4, section5, section6, section7
        };

        // Get the current section emojis
        string[] emojis = allSections[currentSection];

        // Update the buttons with the emojis of the current section
        for (int i = 0; i < emojis.Length; i++)
        {
            sectionButtons[i].Text = emojis[i];
            sectionButtons[i].Click += (sender, e) => Clipboard.SetText(((Button)sender).Text); // Copy to clipboard
        }
    }
   
    private void LeftArrowButton_Click(object sender, EventArgs e)
    {
        // Go to previous section (wrap around)
        currentSection = (currentSection == 0) ? 6 : currentSection - 1;  // 6 is the last section index
        UpdateSection();
    }

    private void RightArrowButton_Click(object sender, EventArgs e)
    {
        // Go to next section (wrap around)
        currentSection = (currentSection == 6) ? 0 : currentSection + 1;  // 6 is the last section index
        UpdateSection();
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new EmojiBoard());
    }
}

