
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lab4ATTMMT11
{
    public partial class Form1 : Form
    {
        string sSourceData;
        string sFormat;
        public Form1()
        {
            InitializeComponent();
            sSourceData = textData.Text;
            sFormat = textFormat.Text;
        }

        public string GenerateMD5(string input)
        {
            byte[] data;

            if (checkHexString(input) && checkboxHex.Checked)
            {
                // Convert hex string to byte array
                data = Enumerable.Range(0, input.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(input.Substring(x, 2), 16))
                                 .ToArray();
            }
            else
            {
                // Convert the input string to a byte array
                data = Encoding.Default.GetBytes(input);
            }

            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();
            // Compute the hash.
            byte[] hashData = md5Hasher.ComputeHash(data);
            // Create a new StringBuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < hashData.Length; i++)
            {
                sBuilder.Append(hashData[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public string GenerateSHA1(string input)
        {
            byte[] data;

            if (checkHexString(input) && checkboxHex.Checked)
            {
                // Convert hex string to byte array
                data = Enumerable.Range(0, input.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(input.Substring(x, 2), 16))
                                 .ToArray();
            }
            else
            {
                // Convert the input string to a byte array
                data = Encoding.Default.GetBytes(input);
            }
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(data);
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x2"));
            }
            return hashSb.ToString();
        }

        public string SHA256(string input)
        {
            byte[] data;

            if (checkHexString(input) && checkboxHex.Checked)
            {
                // Convert hex string to byte array
                data = Enumerable.Range(0, input.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(input.Substring(x, 2), 16))
                                 .ToArray();
            }
            else
            {
                // Convert the input string to a byte array
                data = Encoding.Default.GetBytes(input);
            }
            SHA256Managed sha256 = new SHA256Managed();
            StringBuilder hashSb = new StringBuilder();
            byte[] hash = sha256.ComputeHash(data);
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x2"));
            }
            return hashSb.ToString();
        }

        public string SHA384(string input)
        {
            byte[] data;

            if (checkHexString(input) && checkboxHex.Checked)
            {
                // Convert hex string to byte array
                data = Enumerable.Range(0, input.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(input.Substring(x, 2), 16))
                                 .ToArray();
            }
            else
            {
                // Convert the input string to a byte array
                data = Encoding.Default.GetBytes(input);
            }
            SHA384Managed sha384 = new SHA384Managed();
            StringBuilder hashSb = new StringBuilder();
            byte[] hash = sha384.ComputeHash(data);
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x2"));
            }
            return hashSb.ToString();
        }



        private void Calculate_Click(object sender, EventArgs e)
        {
            if (checkboxHex.Checked)
            {
                if (textData != null && !checkHexString(textData.Text))
                {
                    MessageBox.Show("Invalid hex string");
                    button3.Enabled = false;
                    disableComponents();
                }
            }

                sSourceData = textData.Text;
                enableComponents();
           
            if (checkMD5.Checked)
            {
                textMD5.Text = GenerateMD5(sSourceData);
            }

            if (checkSHA1.Checked)
            {
                textSHA1.Text = GenerateSHA1(sSourceData);
            }

            if (checkSHA2.Checked)
            {
                textSHA2.Text = SHA256(sSourceData);
            }

            if (checkSHA3.Checked)
            {
                textSHA3.Text = SHA384(sSourceData);
            }

        }

        private bool checkHexString(string input)
        {
            // Size of string 
            int n = input.Length;

            // Iterate over string 
            for (int i = 0; i < n; i++)
            {
                char ch = input[i];

                // Check if the character is invalid 
                if ((ch < '0' || ch > '9') &&
                    (ch < 'A' || ch > 'F') &&
                    (ch < 'a' || ch > 'f'))
                {
                    return false;
                }
            }

            // Return true if all characters are valid 
            return true;
        }


        private void dislayHashChecked(object sender, EventArgs e)
        {
            hashText();
            if (checkMD5.Checked)
            {
                textMD5.Visible = true;
            }
            else
            {
                textMD5.Visible = false;
            }

            if (checkSHA1.Checked)
            {
                textSHA1.Visible = true;
            }
            else
            {
                textSHA1.Visible = false;
            }

            if (checkSHA2.Checked)
            {
                textSHA2.Visible = true;
            }
            else
            {
                textSHA2.Visible = false;
            }

            if (checkSHA3.Checked)
            {
                textSHA3.Visible = true;
            }
            else
            {
                textSHA3.Visible = false;
            }
        }

        private void hashText()
        {
            textMD5.Text = GenerateMD5(sSourceData);
            textSHA1.Text = GenerateSHA1(sSourceData);
            textSHA2.Text = SHA256(sSourceData);
            textSHA3.Text = SHA384(sSourceData);
        }

        private void textFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (textFormat.Text == "File")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt);|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    string line = sr.ReadToEnd();
                    if (line == null)
                        MessageBox.Show("File is empty");
                    else
                    {
                        textData.Text = line;
                        sSourceData = line;
                    }
                }
            }
            else
            {
                textMD5.Text = "";
                textSHA1.Text = "";
                textSHA2.Text = "";
                textSHA3.Text = "";
                textData.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textMD5.Text = "";
            textSHA1.Text = "";
            textSHA2.Text = "";
            textSHA3.Text = "";
            textData.Text = ""; 
            textData = null;
        }

        private void checkboxHex_CheckedChanged(object sender, EventArgs e)
        {
            enableComponents();
            if (checkboxHex.Checked)
            {
                if (textData != null && !checkHexString(textData.Text))
                {
                    MessageBox.Show("Invalid hex string");
                    disableComponents();
                }
            }
            else
            {
                enableComponents();
            }
        }

        private void textData_TextChanged(object sender, EventArgs e)
        {
            textMD5.Text = "";
            textSHA1.Text = "";
            textSHA2.Text = "";
            textSHA3.Text = "";

            if (checkboxHex.Checked)
            {
                if (textData != null && !checkHexString(textData.Text))
                {
                    MessageBox.Show("Invalid hex string");
                    button3.Enabled = false;
                    disableComponents();
                }
            }
            else 
                button3.Enabled = true;
        }
        private void enableComponents()
        {

            textMD5.Text = "";
            textSHA1.Text = "";
            textSHA2.Text = "";
            textSHA3.Text = "";
            button3.Enabled = true;
        }

        private void disableComponents()
        {
            button3.Enabled = false;
        }
    }
}


