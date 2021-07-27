using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DirectoryChar
{
    /// <summary>
    /// Interaction logic for DeleteWordPage.xaml
    /// </summary>
    public partial class DeleteWordPage : Page
    {
        String Location; //Holds location of main directory

        String[] TempDirectories; //Temporarily stores subdirectories in array

        string Word; //Stores characters that will be deleted

        //Stores subdirectories in Collection for listbox
        ObservableCollection<string> Directories = new ObservableCollection<string>();

        string LastLocation; //Stores the last directory opened
        public DeleteWordPage()
        {
            InitializeComponent();
            WordTxtBox.MaxLength = 1000;
        }

        private void Choose_DirectoryButt_Click(object sender, RoutedEventArgs e)
        {
            Directories.Clear();
            ListOfDirectories.DataContext = null; //Clear Listbox
            DirectoryNameTxtBox.Text = ""; //Clear textbox
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (LastLocation != null)
            {
                //Sets path to last directory location
                FBD.SelectedPath = LastLocation;
            }
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.MessageBox.Show(FBD.SelectedPath);

                //Sets LastLocation to path
                LastLocation = FBD.SelectedPath;

                Location = FBD.SelectedPath;

                TempDirectories = System.IO.Directory.GetDirectories

                (Location, "*", System.IO.SearchOption.AllDirectories); //Gets subdirectory names in directory
                int count = TempDirectories.Count(); //Gets the amount of directories inside of the array

                if (count < 1) //If the array has 0 directories, than throw a this check
                {
                    System.Windows.MessageBox.Show("This directory has no subdirectories to rename!");
                    return;
                }

                //Add all the directories into observable collection/

                foreach (string s in TempDirectories)
                {
                    Directories.Add(s);
                }
                ListOfDirectories.DataContext = Directories; //Set listbox data context
                DirectoryNameTxtBox.Text = Location; //Set textbox text
            }
        }

        private void DeleteCharactersButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if there are any directories to delete characters from
            if (TempDirectories == null || TempDirectories.Length == 0)
            {
                System.Windows.MessageBox.Show("You must select a directory with sub directories.");
                return;
            }

            //Checks to see if there are any Characters to delete
            else if (CharactersToBeDeleted.Text == "" || CharactersToBeDeleted.Text == null)
            {
                System.Windows.MessageBox.Show("You need to enter a word to delete first..");
                return;
            }

            ObservableCollection<string> TempReplaceAfter = new ObservableCollection<string>();

            foreach (string s in Directories)
            {
                //Extract directoryname from current path
                string subdirectoryname = new System.IO.DirectoryInfo(s).Name;
                string iterable = s; // Stores original path and makes it changeable
                
                    //if the subdirectoryname contains a character we want to delete
                    if (subdirectoryname.Contains(Word))
                    {

                    //create an array of splitted words from the subdirectory names
                    string[] splittedStringArray = subdirectoryname.Split(' ');

                    //set subdirectory name = to nothing
                    subdirectoryname = "";

                    //rebuild subdirectory name by adding each name back EXCEPT
                    //the word we want to delete
                    foreach(string oldwords in splittedStringArray)
                    {
                        if(oldwords == Word)
                        {
                            continue;
                        }
                        subdirectoryname = subdirectoryname + " " + oldwords;
                    }

                    //Extracting path from the directory name so we can combine
                    string TempDirectName = System.IO.Path.GetDirectoryName(iterable) + "\\";
                        //At the end, set subdirectory name equal to our new built name

                        //Combine our new path with our new name
                        string FinalRenaming = TempDirectName + subdirectoryname;
                        TempReplaceAfter.Add(FinalRenaming);

                        #region Prevents file same name conflict
                        int Append = 0; //Create append variable

                        //While FinalRenaming directory exists, append a number and
                        //keep appending until it doesn't exist anymore
                        while (System.IO.Directory.Exists(FinalRenaming) == true)
                        {
                            Append++;
                            FinalRenaming = FinalRenaming + Append;
                        }
                        #endregion


                        //Finally, change name of directory.
                        System.IO.Directory.Move(iterable, FinalRenaming);

                        /*Sets iterable variable equal to new path so we can check
                         * that new path for the remaining characters we want gone*/
                        iterable = FinalRenaming;
                    }
            }
            //Clear directory list
            Directories.Clear();
            TempDirectories = System.IO.Directory.GetDirectories
            (Location, "*", System.IO.SearchOption.AllDirectories); //Gets subdirectory names in directory
            int count = TempDirectories.Count(); //Gets the amount of directories inside of the array

            if (count < 1) //If the array has 0 directories, than throw a this check
            {
                System.Windows.MessageBox.Show("This directory has no directories to name!");
                return;
            }

            //Add all the directories into observable collection/
            foreach (string s in TempDirectories)
            {
                Directories.Add(s);
            }

            //Clears the listbox of all items
            ListOfDirectories.ItemsSource = null;
            ListOfDirectories.Items.Clear();

            //Resets data context 
            ListOfDirectories.ItemsSource = Directories;

        }

        private void EntersCharacters_Click(object sender, RoutedEventArgs e)
        {
            //Checks if a character is inside of textbox

            if (String.IsNullOrEmpty(WordTxtBox.Text))
            {
                System.Windows.MessageBox.Show("Enter a word to delete");
                return;
            }

            //Add word
            Word = WordTxtBox.Text;

            //Set textbox = to Characters
            CharactersToBeDeleted.Text = Word;

            //Clear textbox
            WordTxtBox.Clear();
        }

        private void ClearCharactersButt_Click(object sender, RoutedEventArgs e)
        {
            Word = null; //Clears characters
            CharactersToBeDeleted.Text = Word; //Resets textbox content

            WordTxtBox.Clear();
        }

        

        private void BackButt_Click(object sender, RoutedEventArgs e)
        {
            TypeSelectionPage newpage = new TypeSelectionPage();
            this.NavigationService.Navigate(newpage);
        }
    }
}
