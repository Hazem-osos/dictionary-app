//Omar Mohamed mahmoud El Gohary 211004064
//Hazem Osama  211006314
//Omar Adel 211006752
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUI_application
{
    sealed partial class Form1 : Form
    {
        private MyDictionary mydictionary;
        public MyDictionary Mydictionaryy
        {
            get { return mydictionary; }
            set { mydictionary = value; }
        }
        public Form1()
        {
            InitializeComponent();
            mydictionary = new MyDictionary();
        }
        private void btnadd_Click(object sender, EventArgs e) //The add method
        {
            if (txtword.Text.Trim() == "") //making sure the textbox isn't empty
            {
                MessageBox.Show("Enter a word");
                return;
            }
            StreamReader sr = new StreamReader("Dictionary.txt"); //reading the data in the txt file
            string check = sr.ReadToEnd();
            sr.Close();
            if (check.Contains(txtword.Text)) //check first if the word already exists or not
            {
                MessageBox.Show("This word already exists");
                txtword.Focus();
                txtword.SelectAll();
            }
            else //if the word doesn't exists then we add it
            {
                StreamWriter sw = new StreamWriter("Dictionary.txt", true);
                string word = txtword.Text + ".";
                sw.WriteLine(word);
                sw.Close();
                MessageBox.Show("Word is added");
                foreach (Control i in this.Controls) //bring the textbox back empty after the add operation
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
                txtword.Focus();
            }
        }
        private void btnupdate_Click(object sender, EventArgs e) //The update method
        {
            if (txtword.Text.Trim() == "") //making sure the word text box isn't empty
            {
                MessageBox.Show("Enter first the word you want to update");
                return;
            }
            else if (txtupdate.Text.Trim() == "") //making sure the update text box isn't empty
            {
                MessageBox.Show("Enter first the update of the word");
            }
            else
            {
                string path = "Dictionary.txt";
                string word = txtword.Text + '.';
                string update_word = txtupdate.Text + '.';
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();
                    reader.Close();
                    if (content.Contains(update_word))
                    {
                        MessageBox.Show("The update word already exists");
                    }
                    else if (!content.Contains(word))
                    {
                        MessageBox.Show("The word doesn't exist to be replaced");
                    }
                    else
                    {
                        content = content.Replace(word, update_word);

                        using (StreamWriter writer = new StreamWriter(path))
                        {
                            writer.Write(content);
                            writer.Close();
                        }
                        MessageBox.Show("The word is updated");
                    }
                }
                foreach (Control i in this.Controls)
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
                txtupdate.Focus();
                txtword.Focus();
            }
        }
        private void btndelete_Click(object sender, EventArgs e) //The delete method
        {
            if (txtword.Text.Trim() == "") //making sure the textbox isn't empty
            {
                MessageBox.Show("Enter the word you want to delete");
                txtword.Focus();
            }
            StreamReader sr = new StreamReader("Dictionary.txt");
            string check = sr.ReadToEnd();
            sr.Close();

            if (check.Contains(txtword.Text))//Making sure the word exists first
            {
                string filePath = "Dictionary.txt";
                string wordToDelete = txtword.Text;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    reader.Close();
                    content = content.Replace(wordToDelete + '.', string.Empty);

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(content);
                        writer.Close();
                    }
                }
                MessageBox.Show("Word is deleted");
                foreach (Control i in this.Controls) //Let the text box empty
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
                txtword.Focus();
            }
            else
            {
                MessageBox.Show("The word doesn't exists in the dictionary");
                txtword.Focus();
            }
        }
        private void btnsearch_Click(object sender, EventArgs e) //The search method
        {
            if (txtword.Text.Trim() != "") //making sure the textbox isn't empty
            {
                StreamReader sr = new StreamReader("Dictionary.txt");
                string line = "";
                bool found = false;
                do
                {
                    line = sr.ReadLine();// reading the data in the txt file, but line by line
                    if (line != null)
                    {
                        string s = line;
                        if (s == txtword.Text + '.')
                        {
                            MessageBox.Show("The word is found");
                            found = true;
                            txtword.Focus();
                            break;
                        }
                    }
                } while (line != null);
                sr.Close();
                if (!found)
                {
                    MessageBox.Show("The word isn't found");
                }
            }
            else
            {
                MessageBox.Show("Enter a word in the text box");
                txtword.Focus();
            }
        }

        private void btndfindlength_Click(object sender, EventArgs e)//The find length method
        {
            if(txtword.Text.Trim()=="") //making sure the text box isn't empty
            {
                MessageBox.Show("Enter word first");
            }
            else
            {
                string w = txtword.Text;
                int count = 0;
                for(int i = 0; i<w.Length; i++) 
                {
                    count++;
                }
                MessageBox.Show("The lengh of the word is " + count);
            }
            foreach (Control i in this.Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
            txtword.Focus();
        }

        private void btnreverse_Click(object sender, EventArgs e) //Reverse operation
        {
            if (txtword.Text.Trim() == "") //Making sure that the box isn't empty
            {
                MessageBox.Show("Enter word first");
            }
            else //reversing the word in the text box
            {
                string r = txtword.Text;
                string fpath = "Dictionary.txt";
                using (StreamReader sr = new StreamReader(fpath)) //Reading all data inside the file
                {
                    string c = sr.ReadToEnd();
                    sr.Close();
                    string t = ReverseString(r); //calling the reverse method and sending the word to it
                    MessageBox.Show("The reversed word is " + t);
                }
            }
        }
        private string ReverseString(string input) //Reverse method
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string (arr);
        }
        
    }
    public class MyDictionary 
    {
        private Dictionary<string,string> dictionary;
        public MyDictionary() //constructor
        {
            dictionary = new Dictionary<string,string>();
        }
    }
}

