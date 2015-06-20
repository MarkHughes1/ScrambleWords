using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;


namespace ScrambleWords
{
    public partial class Form1 : Form
    {
        List<string> Dictionary = new List<string>();        

        public Form1()
        {
            InitializeComponent();

            //Loads up all the words we will compare against.
            PopulateDictionary();
        }


        private void btn_Go_Click(object sender, EventArgs e)
        {

            Stopwatch timer1 = new Stopwatch();
            // Recover the letters from the dialog box
            var Letters = txt_Word.Text.ToString();
            //split the dialog string into individual letters
            var letters = SplitString(Letters);
            //find all the words with those letters in
            var WordsWithTheseLetters = ReturnAllWordsWithTheseLettersIn(letters);
            //find all the words that contain only those letters and no others.
            var WordsWithONLYTheseLetters = ReturnAllWordsWithONLYTheseLettersIn(letters);

            var frequency = SetupLetterFrequencyDictionary(letters);

            timer1.Start();
            var AllLettersDifferent = AreAllTheLettersSelectedDifferent(letters);
            timer1.Stop();

            MessageBox.Show(timer1.ElapsedMilliseconds.ToString());

            // if (AllLettersDifferent)
            //{
            //    MessageBox.Show("Found no duplicate letters");
            //}
            //else
            //{
            //    MessageBox.Show("Found duplicate letters");
            
            //}

            //MessageBox.Show("I found " + WordsWithTheseLetters.Count + " Words with these letters");
            //MessageBox.Show("I found " + WordsWithONLYTheseLetters.Count + " Words with ONLY these letters");

        }

        private Dictionary<char, int> SetupLetterFrequencyDictionary(List<char> letters)
        {
            var letterFrequency = new Dictionary<char, int>();

            foreach (char letter in letters)
            {
                if (letterFrequency.ContainsKey(letter))
                {
                    letterFrequency[letter] += 1;
                }
                else
                {
                    letterFrequency.Add(letter, 1);
                }
            }

            return letterFrequency;
        }

        /// <summary>
        /// Find out if a list of letters contains a duplicate letter
        /// </summary>
        /// <param name="letters"></param>
        /// <returns></returns>
        public bool AreAllTheLettersSelectedDifferent(List<char> letters)
        {

            Dictionary<char, int> frequency = SetupLetterFrequencyDictionary(letters); 

            foreach (KeyValuePair<char,int> kvp in frequency)
            {
                if (kvp.Value > 1)
                {
                    return false;
                }
            }
            
            return true;

        }

        public List<string> ReturnAllWordsWithTheseLettersIn(List<char> letters)
        {
            List<string> WordsWithTheseLetters = new List<string>();

            foreach (string TestString in Dictionary)
            {
                var Pass = true;
                foreach (char Letter in letters)
                {
                    if (!TestString.Contains(Letter))
                    {
                        Pass = false;
                    }

                }
                if (Pass == true)
                {
                    WordsWithTheseLetters.Add(TestString);
                }
            }
            return WordsWithTheseLetters;
        }

        public List<string> ReturnAllWordsWithONLYTheseLettersIn(List<char> letters)
        {
            List<string> WordsWithTheseLetters = new List<string>();

            foreach (string TestString in Dictionary)
            {
                var Pass = true;
                foreach (char Letter in letters)
                {
                    if (!TestString.Contains(Letter))
                    {
                        Pass = false;
                    }

                }
                if (Pass == true && TestString.Length == letters.Count)
                {
                    WordsWithTheseLetters.Add(TestString);
                }
            }
            return WordsWithTheseLetters;
        }


        public List<char> SplitString(string inputLetters)
        {
            var letters = new List<char>();

            for (int n = 0; n < inputLetters.Length; n++)
            {
                letters.Add(inputLetters[n]);
            }
            return letters;
        }





        void PopulateDictionary()
        {
            List<string> duplicates = new List<string>();
            string line = "";
            //need to load file here
           // System.IO.StreamReader file = new System.IO.StreamReader(MyDirectory() + @"\WordList_Eng_UK.txt");
           // System.IO.StreamReader file = new System.IO.StreamReader(MyDirectory() + @"\wordsEn.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(MyDirectory() + @"\SmallWordList.txt");
          
            while (!string.IsNullOrWhiteSpace(line = file.ReadLine()))
            {
                if (Dictionary.Contains(line))
                {
                    duplicates.Add(line);
                }
                else
                {
                    Dictionary.Add(line);
                }
            }
            if (duplicates.Count > 0)
            {
                //MessageBox.Show("Duplicate words found " + duplicates.Count);
            }
            file.Close();


        }

        private string MyDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
