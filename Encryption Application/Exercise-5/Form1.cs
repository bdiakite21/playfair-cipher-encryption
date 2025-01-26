using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
       private char[,] matrix = new char[5, 5]; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void LoadMatrix(string keyword)
        {
        // Drop duplicates and add keyword letters to the matrix
          keyword = new string(keyword.ToUpper().Distinct().ToArray()).Replace("J", "I");
          string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
         string combined = keyword + string.Concat(alphabet.Except(keyword));

         int index = 0;
         for (int row = 0; row < 5; row++)
            {
            for (int col = 0; col < 5; col++)
              {
             matrix[row, col] = combined[index++];
                }
            }
        }

      private (int, int) GetCoordinates(char letter)
        {
          for (int row = 0; row < 5; row++)
            {
            for (int col = 0; col < 5; col++)
                {
              if (matrix[row, col] == letter)
              return (row, col);
                }
            }
            return (-1, -1);
        }

        private char TranslateLetter(char letter)
        {
          // combine 'J' and 'I'as the letter I
          letter = letter == 'J' ? 'I' : char.ToUpper(letter); 
          var (row, col) = GetCoordinates(letter);
          // Non-letter characters remain unchanged
          if (row == -1 || col == -1) return letter;
           // Swap row and column for the transformation

           return matrix[col, row]; 
        }

        private string EncryptText(string text)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in text)
            {
             if (char.IsLetter(c))
                {
                encryptedText.Append(TranslateLetter(c));
                }
              else
                {
         // Maintain spaces and punctuation
                 encryptedText.Append(c); 
                }
            }

           return encryptedText.ToString();
        }

        private void btnTranslateText_Click(object sender, EventArgs e)
        {
            // Validate input 
            if (string.IsNullOrEmpty(txtCipherSecretWord.Text) || string.IsNullOrEmpty(txtInputText.Text))
            {
             MessageBox.Show("Please enter both a Cipher Secret Word and text to Translate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }

            LoadMatrix(txtCipherSecretWord.Text);
            // Encrypt the input text
            string encryptedText = EncryptText(txtInputText.Text); 
            // Display the result
            txtOutputText.Text = encryptedText; 
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
          txtCipherSecretWord.Clear();
          txtInputText.Clear();
          txtOutputText.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
