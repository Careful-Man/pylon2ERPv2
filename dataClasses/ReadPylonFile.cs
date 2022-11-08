using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pylon2ERP.dataClasses
{
    class ReadPylonFile
    {
        public static readonly string PYLON_FILE_CONST_1 = "Εταιρεία";
        public static readonly string PYLON_FILE_CONST_2 = "Περιγραφή";
        public static readonly string PYLON_FILE_CONST_3 = "Λογαριασμού";
        public static readonly string PYLON_FILE_CONST_4 = "Λογαριασμός";
        public static readonly string PYLON_FILE_CONST_5 = "Χρέωση";
        public static readonly string PYLON_FILE_CONST_6 = "Πίστωση";
        public static readonly string AITIOLOGIA = "\nΑιτιολογία άρθρου: ";

        //constructor
        public ReadPylonFile(   TextBox filePathTextBox, 
                                DateTimePicker articleDatePicker, 
                                TextBox axTextBox, 
                                ComboBox articleTypeComboBox, 
                                MainForm mf)
        {
            bool isPylonFile = false;
            StreamReader reader = new StreamReader(filePathTextBox.Text);
            Article someGLArticle;

            string[] fileLines = File.ReadAllLines(filePathTextBox.Text);
            string line = reader.ReadLine();
            string lastLine;
            

            isPylonFile = checkIfIsPylonFile(line);

            if(line != null)
            {//an den einai adeio to arxeio
                if (isPylonFile)
                {//an einai arxeio me kefalides pylon
                    try
                    {//an exei apla kefalides pylon den einai aparaitita arxeio pylon. Catch an den einai
                        string[] debitAndCredit = File.ReadLines(filePathTextBox.Text).Last().Trim().Split("  ");
                        debitAndCredit[0] = debitAndCredit[0].Trim();
                        debitAndCredit[1] = debitAndCredit[1].Trim();
                        if (debitAndCredit[0] == debitAndCredit[1] && fileLines.Length > 2)
                        {//an i xreosi kai i pistosi tou arthrou einai ises
                            mf.appendToConsoleText(MainForm.DASHES);
                            mf.appendToConsoleText("\nΆνοιγμα του αρχείου  " + filePathTextBox.Text);
                            mf.appendToConsoleText("Τύπος άρθρου: " + articleTypeComboBox.Text);
                            mf.appendToConsoleText("Ημερομηνία άρθρου: " + articleDatePicker.Text);
                            mf.appendToConsoleText("Κατάστημα άρθρου: " + DataClass.BranchesDictionary[axTextBox.Text] + " (" + axTextBox.Text + ")");
                            mf.appendToConsoleText(MainForm.DASHES);
                            //diavase to arthro
                            someGLArticle = new Article(articleDatePicker.Text.Replace("/", ""),
                                axTextBox.Text,
                                articleTypeComboBox.Text,
                                DataClass.MonthsDictionary[articleDatePicker.Text.Substring(3, 2)],
                                mf);

                            while (line != null)
                            {
                                lastLine = line;
                                line = reader.ReadLine();
                                if (line != null && line != File.ReadLines(filePathTextBox.Text).Last())//an den exo ftasei stin teleftea grammi
                                {//tin proti grammi tin exo diavasei idi, exei kefalides, ara den moy xreiazetai edo
                                 //diavase ton logariasmo
                                    new Account(line, someGLArticle);
                                }
                            }
                            someGLArticle.reduceAccounts();//kalo tin methodo pou athrizei tous logariasmous me ton idio kodiko
                            mf.addArticleToTreeView(someGLArticle);//vazei to arthro sto dentro
                            mf.appendToConsoleText(MainForm.DASHES);
                            mf.appendToConsoleText("\n");
                        }
                        else if(debitAndCredit[0] != debitAndCredit[1])
                        {
                            mf.appendToConsoleColoredText("Σφάλμα: Η χρέωση και η πίστωση του άρθρου δεν είναι ίσες.", Color.White, Color.Red);
                        }else 
                        {
                            printNotPylonFileMessageToConsole(mf);
                        }
                    }catch(Exception e)
                    {
                        DialogResult drOk = MessageBox.Show(
                                "Σφάλμα ανάγνωσης αρχείου.\nΑυτό το αρχείο δεν αναγνωρίζεται ως αρχείο που εξήχθη από το Pylon.\n" + e.Message,
                                "Pylon2ERP - Μήνυμα",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error,
                                 MessageBoxDefaultButton.Button2);
                    }
                }
                else
                {
                    printNotPylonFileMessageToConsole(mf);
                }
            }
            else
            {//an to arxeio einai adeio tote sigoura den einai pylon
                printNotPylonFileMessageToConsole(mf);
            }
            reader.Close();
        }

        //methods
        private bool checkIfIsPylonFile(String line)
        {
            try
            {
                return line.Contains(PYLON_FILE_CONST_1) &&
                   line.Contains(PYLON_FILE_CONST_2) &&
                   line.Contains(PYLON_FILE_CONST_3) &&
                   line.Contains(PYLON_FILE_CONST_4) &&
                   line.Contains(PYLON_FILE_CONST_5) &&
                   line.Contains(PYLON_FILE_CONST_6);
            } catch (Exception e)
            {
                return false;
            }
        }
        private void printNotPylonFileMessageToConsole(MainForm mf)
        {
            mf.appendToConsoleColoredText("Σφάλμα: Αυτό το αρχείο δεν αναγνωρίζεται ως αρχείο Pylon.", Color.White, Color.Red);
        }
    }
}