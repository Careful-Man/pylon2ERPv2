using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pylon2ERP.dataClasses
{
    public class Article
    {
        //stathera pedia gia kathe arthro. Prepei na einai ellinikoi xaraktires kai kefalaioi
        public static readonly string CALENDAR = "002"; 
        public static readonly string DOCUMENT_TYPE = "ΣΥ";
        public static readonly char PAYMENT_METHOD = 'Α';
        public static readonly string MHNOS = "ΜΗΝΟΣ";
        public static readonly char XRHSH = 'Χ';
        //stathera strings keimenou pou typonontai stin konsola
        public static readonly string LOGARIASMOS = "Λογαριασμός ";
        public static readonly string KODIKOS_LOGARIASMOU = "Kωδικός: ";
        public static readonly string POSO_LOGARIASMOU = "Ποσό: ";
        public static readonly string KENA_PISTOSIS = "                                                 ";

        //metavlita pedia arthrou poy i timi toys diaferei analoga me to ti arthro kataxoro
        private string articleDate;
        public string ArticleDate { get { return articleDate; } }

        private string articleAX;
        public string ArticleAX { get { return articleAX; } }

        private string articleType;
        public string ArticleType { get { return articleType; } }

        private string articleDescription;
        public string ArticleDescription { get { return articleDescription; } }

        private List<Account> articleAccounts;//domi me tous logariasmous tou arthrou
        public List<Account> ArticleAccounts { get { return articleAccounts; } }

        private double debitTotal = 6.2d;
        private double creditTotal = 6.2d;

        //constructor
        public Article(string articleDate, string articleBranch, string articleType, string articleMonth, MainForm mw)
        {
            this.articleDate = articleDate;
            this.articleAX = articleBranch;
            this.articleType = articleType;

            if (this.articleType == "ΔΩΡΟ ΠΑΣΧΑ" || this.articleType == "ΔΩΡΟ ΧΡΙΣΤΟΥΓΕΝΝΩΝ" || this.articleType == "ΑΠΟΖ. ΑΠΟΛΥΣΗΣ" || this.articleType == "ΑΠΟΖ. ΣΥΝΤΑΞΙΟΔΟΤΗΣΗΣ")
            {//an to arthro einai doro h apoz apolisis h suntaksis min grapseis "mhnos tade" sthn aitiologia toy
                this.articleDescription = articleType + " " + DataClass.BranchesDictionary[articleBranch];
            }
            else
            {//allios grapse 
                this.articleDescription = articleType + " " + DataClass.BranchesDictionary[articleBranch] + " " + MHNOS + " " + articleMonth;
            }
            mw.appendToConsoleText(ReadPylonFile.AITIOLOGIA + articleDescription + "\n");

            this.articleAccounts = new List<Account>();
        }

        //other methods
        public void addAccountToThisArticleList(Account someAccount)
        {//vazei ena logariasmo sto arthro
            this.articleAccounts.Add(someAccount);
        }

        public void printArticlesAccounts(MainForm mw)
        {//typonei minimata stin konsola
            bool warning = false;
            bool branchWarning = false;

            debitTotal = 0;
            creditTotal = 0;

            foreach (Account acc in this.articleAccounts)
            {
                if (acc.AccountIsDebit) {
                    //tipose minimata stin othoni
                    mw.appendToConsoleText("\n" + LOGARIASMOS + "χρέωσης");
                    mw.appendToConsoleText(KODIKOS_LOGARIASMOU + acc.AccountCodeCorrected);
                    //elegxos gia to an iparxei mono 1 dekadiko stin aksia tou logariasmou 
                    //epeidi einai pedio double an to poso einai px 69,10 afto krataei 69,1
                    //ara an exei 1 dekadiko pao kai vazo ena miden sto telos
                    string accountBalancedStringed = getAccountBalanceStringed(acc.AccountBalance);
                    mw.appendToConsoleText(POSO_LOGARIASMOU + accountBalancedStringed + "€");
                    debitTotal += acc.AccountBalance;
                } else {
                    //tipose minimata stin othoni
                    mw.appendToConsoleText("\n" + KENA_PISTOSIS + LOGARIASMOS + "πίστωσης");
                    mw.appendToConsoleText(KENA_PISTOSIS + KODIKOS_LOGARIASMOU + acc.AccountCodeCorrected);
                    //elegxos gia to an iparxei mono 1 dekadiko stin aksia tou logariasmou 
                    //epeidi einai pedio double an to poso einai px 69,10 afto krataei 69,1
                    //ara an exei 1 dekadiko pao kai vazo ena miden sto telos
                    string accountBalancedStringed = getAccountBalanceStringed(acc.AccountBalance);
                    mw.appendToConsoleText(KENA_PISTOSIS + POSO_LOGARIASMOU + accountBalancedStringed + "€");
                    creditTotal += acc.AccountBalance;
                }
                
                if (acc.Warning)
                    warning = true;

                if (acc.BranchWarning) 
                    branchWarning = true;
            }
            mw.appendToConsoleText("\n");
            //grafei sto telos tou arthrou mia grammi pou leei ta sinola. to substring apla kanei align ta athroismata me tis pistoseis
            mw.appendToConsoleText("Σύνολο χρέωσης: " + getAccountBalanceStringed(debitTotal) + "€" + KENA_PISTOSIS.Substring(("| Σύνολο χρέωσης: " + getAccountBalanceStringed(debitTotal)).Length-1) + "Σύνολο πίστωσης: " + getAccountBalanceStringed(creditTotal) + "€");


            if (warning)
            //an vrike proeidopoiisi, deikse analogo minima
                mw.appendToConsoleColoredText("Προειδοποίηση: Το άρθρο αυτό ενδέχεται να μην είναι άρθρο " + this.ArticleType + ".", Color.Black, Color.Yellow);  

            if(branchWarning)
                mw.appendToConsoleColoredText("Προειδοποίηση: Αυτό το άρθρο ενδέχεται να μην είναι άρθρο του καταστήματος \"" + DataClass.BranchesDictionary[this.articleAX] + "\".", Color.Black, Color.Yellow);
        }

        public void reduceAccounts()
        {//methodos pou vriskei logariasmous tou arthrou me ton idio kodiko kai athroizei tis aksies tous
            int count = this.articleAccounts.Count;
            for (int i=0; i<count; i++)
            {
                try
                {
                    Account tempAccount = this.articleAccounts[i];
                    Account tempAccountPlusOne = this.articleAccounts[i + 1];
                    if ((tempAccount.AccountCodeCorrected == tempAccountPlusOne.AccountCodeCorrected))
                    {//ama einai idioi oi logariasmoi, ftiakse enan neo kai athroise tous
                        Account concatenatedAccount = new Account(tempAccount.AccountDescription,
                                                                    tempAccount.AccountCode,
                                                                    tempAccount.AccountCodeCorrected,
                                                                    tempAccount.AccountIsDebit,
                                                                    Math.Round((tempAccount.AccountBalance + tempAccountPlusOne.AccountBalance), 2),
                                                                    tempAccount.Warning);
                        this.articleAccounts.RemoveAt(i + 1);
                        this.articleAccounts.RemoveAt(i);

                        this.articleAccounts.Insert(i, concatenatedAccount);
                        i--;
                    }
                    if(this.articleAccounts[i].AccountCodeCorrected == "54-03-01-0000" || this.articleAccounts[i].AccountCode == "54-03-01-0000")
                    {//afairese afton to logariasmo sigkekrimena, gt den ton thelo vromaei
                        this.articleAccounts.RemoveAt(i);
                    }
                } catch(ArgumentOutOfRangeException aoore)
                {

                }
            }
        }

        public string getAccountBalanceStringed(double accountBalance)
        {//methodos pou kanei to poso logariasmou string. an einai px 69,1 to kanei 69,10
            string accountBalancedStringed = Math.Round(accountBalance, 2).ToString();
            if (accountBalancedStringed.Substring(accountBalancedStringed.IndexOf(',') + 1).Length < 2)
                accountBalancedStringed += "0";
            else if (!accountBalancedStringed.Contains(','))
                accountBalancedStringed += ",00";
            return accountBalancedStringed;
        }
    }
}
