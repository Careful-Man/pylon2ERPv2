using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pylon2ERP.dataClasses
{
    public class Account {
        private string accountDescription;
        public string AccountDescription { get { return accountDescription; } }

        private string accountCode;
        public string AccountCode { get { return accountCode; } }

        private string accountCodeCorrected;
        public string AccountCodeCorrected { get { return accountCodeCorrected; } }

        private bool accountIsDebit;
        public bool AccountIsDebit { get { return accountIsDebit; } }

        private double accountBalance = 6.2d;
        public double AccountBalance { get { return accountBalance; } }

        private bool articleWarning;//pedio pou me voithaei na emfaniso proeidopoihtiko minima eisagogis lathos arthrou
        public bool Warning { get { return articleWarning; } }

        private bool branchWarning;//pedio pou me voithaei na emfaniso proeidopoihtiko minima eisagogis lathos katastimatos
        public bool BranchWarning { get { return branchWarning; } }

        //pedia pou spao ton logariasmo, analoga me ton vathmo tou
        private string firstDegree;
        private string secondDegree;
        private string thirdDegree;
        private string fourthDegree;

        //voithitiko pedio pou xrhsimopoio gia na allakso ton 4o-vathmio logariasmo
        private bool isDioik;

        //stathero string sigkrisis perigrafis arthrou gia logariasmo 55-00-00-0000
        public static readonly string EPIKOYRIKA_TAMEIA = "Επικουρικά Ταμεία";

        //stathera strings gia thn epilogi arthrou
        public static readonly string MISTHODOSIA = "ΜΙΣΘΟΔΟΣΙΑ";
        public static readonly string EPID_ADEIAS = "ΕΠΙΔ. ΑΔΕΙΑΣ";
        public static readonly string APOZ_ADEIAS = "ΑΠΟΖ. ΑΔΕΙΑΣ";
        public static readonly string DORO = "ΔΩΡΟ ΠΑΣΧΑ " + "ΔΩΡΟ ΧΡΙΣΤΟΥΓΕΝΝΩΝ";
        public static readonly string APOZIMIOSI = "ΑΠΟΖ. ΣΥΝΤΑΞΙΟΔΟΤΗΣΗΣ " + "ΑΠΟΖ. ΑΠΟΛΥΣΗΣ";



        //contructor gia antikeimena apo to arxeio
        public Account(string thisLine, Article theAccountsArticle) {
            this.getValuesFrom(thisLine);//diorthosi logariasmwn se methodo
            this.generateCorrectAccountCode(theAccountsArticle);//diorthosi logariasmou
            theAccountsArticle.addAccountToThisArticleList(this);//vale sto arthro ton diorthomeno logariasmo
        }

        //constructor gia antikeimena apo enomenous logariasmous
        public Account(string accountDescription, string accountCode, string accountCodeCorrected, bool accountIsDebit, double accountBalance, bool warning, bool branchWarning) {
            this.accountDescription = accountDescription;
            this.accountCode = accountCode;
            this.accountCodeCorrected = accountCodeCorrected;
            this.accountIsDebit = accountIsDebit;
            this.accountBalance = accountBalance;
            this.articleWarning = warning;
            this.branchWarning = branchWarning;
        }


        //mehtods
        public void getValuesFrom(string thisLine) {//voithitiki methodos pou diavazei tis times tis grammis pou diavazetai tora
            string[] lineItems = thisLine.Split("  ");
            string deadSpace = "";
            string deadWhiteSpace = " ";

            //afairo stoixeia tou pinaka pou einai kena
            lineItems = lineItems.Where(val => val != deadSpace).ToArray();
            lineItems = lineItems.Where(val => val != deadWhiteSpace).ToArray();

            //ti diavazei ap to arxeio
            //0) trash - πχ ΑΦΡΟΔΙΤΗ
            //1) trash - πχ ΑΕΕ
            //2) not so trash - πχ ΙΚΑ Λογαριασμός τρέχουσας κινήσεως
            //3) kodikos logariasmou - πχ 55-00-00-0000
            //4) poso xreosis - πχ 0.00
            //5) poso pistosis - πχ 1967,26
            for (int i = 2; i < lineItems.Length; i++) {
                lineItems[i] = lineItems[i].Trim();//kourevo whitespaces apo arxi kai telos
                lineItems[i] = lineItems[i].Replace(".", "");//afairo diaxoristiko xiliadon
            }
            //arxikopoiisi pediwn (ektos kataskevasti trolololo)
            this.accountDescription = lineItems[2];
            this.accountCode = lineItems[3];
            try {
                double debitAmount = 6.2d;
                double creditAmount = 6.2d;
                debitAmount = Double.Parse(lineItems[4]);
                creditAmount = Double.Parse(lineItems[5]);
                if (debitAmount == 0) {
                    this.accountIsDebit = false;
                    this.accountBalance = creditAmount;
                } else {
                    this.accountIsDebit = true;
                    this.accountBalance = debitAmount;
                }
            } catch (FormatException fe) {
                this.accountBalance = 0;
                this.accountIsDebit = true;
            }
        }

        public void generateCorrectAccountCode(Article theArticle) {//the magic happens here.
            //epeidi kapoioi logariasmoi pou vgazei to pylon einai fail gia to ERP mas
            //kai den tous xrisimopoioume, prepei na tous diorthoso
            try {
                string[] accountString = this.accountCode.Split("-");

                try {
                    firstDegree = accountString[0];
                    secondDegree = accountString[1];
                    thirdDegree = accountString[2];
                    fourthDegree = accountString[3];
                } catch (Exception e) {
                    firstDegree = accountString[0];
                    secondDegree = accountString[1];
                    thirdDegree = accountString[2];
                    fourthDegree = "1000";
                }
                //an einai arthro dioikisis
                isDioik = theArticle.ArticleAX == "000";

                if (theArticle.ArticleType == MISTHODOSIA) {//arthro misthodosias
                    generateCorrectAccountCodeForArticleMISTHODOSIA(theArticle);
                } else if (theArticle.ArticleType == EPID_ADEIAS) {//arthro epidoma adeias
                    generateCorrectAccountCodeForArticleEPID_ADEIAS(theArticle);
                } else if (theArticle.ArticleType == APOZ_ADEIAS) {//arthro apozimiosi adeias
                    generateCorrectAccountCodeForArticleAPOZ_ADEIAS(theArticle);
                } else if (DORO.Contains(theArticle.ArticleType)) {//arthro doro pasxa h doro xristougennon
                    generateCorrectAccountCodeForArticleDORO(theArticle);
                } else if (APOZIMIOSI.Contains(theArticle.ArticleType)) {//arthro apoz apolisis h apoz syntaksis
                    generateCorrectAccountCodeForArticleAPOZIMIOSI(theArticle);
                }

                //edo ginontai eidikoi elegxoi
                if (this.accountDescription == EPIKOYRIKA_TAMEIA && !this.accountIsDebit) {//elegxos epikourikwn tameiwn
                    fourthDegree = "0003";
                }
                if (!this.accountIsDebit && firstDegree == "33") {//pistotikos logariasmos. oi pistotikoi logariasmoi einai eniaioi gia ola ta AX
                    if (secondDegree == "01") {
                        firstDegree = "53";
                        secondDegree = "00";
                    }
                }


                //ftiaxno to string tou logariasmou
                this.accountCodeCorrected = (firstDegree + "-" + secondDegree + "-" + thirdDegree + "-" + fourthDegree).Trim();

            } catch (ArgumentOutOfRangeException aoore) {
                this.accountCodeCorrected = this.accountCode;
            }
        }


        //methodoi pou xeirizontai tous logariasmoys gia tous diaforoys typous arthrou
        //arthro misthodosias
        public void generateCorrectAccountCodeForArticleMISTHODOSIA(Article theArticle) {//arthro misthodosias
            if (this.accountIsDebit && firstDegree == "60") {//xreostikos logariasmos
                if (theArticle.ArticleAX.Count() == 2) {
                    if (theArticle.ArticleAX != thirdDegree)
                        this.branchWarning = true;
                    thirdDegree = theArticle.ArticleAX;
                } else if (theArticle.ArticleAX.Count() == 3) {
                    if (theArticle.ArticleAX.Substring(0, 2) != thirdDegree)//an einai gia edra diath kai den einai 00 to thirdDegree
                        this.branchWarning = true;
                    thirdDegree = "00";//gia tin diath to kano 00 epeidi to ax einai 001
                }
                if (secondDegree == "00") {//allagi 4o-vathmiou gia taktikes apodoxes
                    if (fourthDegree == "1000" || fourthDegree == "1500" ||
                        fourthDegree == "1600" || fourthDegree == "0000" ||
                        fourthDegree == "00" || fourthDegree == "0500" ||
                        fourthDegree == "0000")
                        if (!isDioik)
                            fourthDegree = "1000";
                        else if (isDioik || theArticle.ArticleAX == "26")
                            fourthDegree = "0000";
                        else
                            this.articleWarning = true;
                } else if (secondDegree == "03" || secondDegree == "04") {//allagh 4o-vathmiou gia ergodotikes eisfores
                    secondDegree = "03";
                    if (!isDioik)
                        fourthDegree = "1000";
                    else
                        fourthDegree = "0000";
                }
            }
        }

        //arthro epidoma adeias
        public void generateCorrectAccountCodeForArticleEPID_ADEIAS(Article theArticle) {//arthro epidoma adeias
            if (this.accountIsDebit && firstDegree == "60") {//xreostikos logariasmos
                if (theArticle.ArticleAX.Count() == 2) {
                    if (theArticle.ArticleAX != thirdDegree)
                        this.branchWarning = true;
                    thirdDegree = theArticle.ArticleAX;
                } else if (theArticle.ArticleAX.Count() == 3) {
                    if (theArticle.ArticleAX.Substring(0, 2) != thirdDegree)//an einai gia edra diath kai den einai 00 to thirdDegree
                        this.branchWarning = true;
                    thirdDegree = "00";//gia tin diath to kano 00 epeidi to ax einai 001
                }
                if (secondDegree == "00") {
                    if (fourthDegree == "0700" || fourthDegree == "1700") {
                        if(!isDioik)
                            fourthDegree = "1700";
                        else
                            fourthDegree = "0700";
                    } else
                        this.articleWarning = true;
                } else if (secondDegree == "03" || secondDegree == "04") {//allagh 4o-vathmiou gia ergodotikes eisfores
                    secondDegree = "03";
                    if (!isDioik)
                        fourthDegree = "1000";
                    else
                        fourthDegree = "0000";
                }
            }
        }

        //arthro apozimiosi adeias
        public void generateCorrectAccountCodeForArticleAPOZ_ADEIAS(Article theArticle) {//arthro apozimiosi adeias
            if (this.accountIsDebit && firstDegree == "60") {//xreostikos logariasmos
                if (theArticle.ArticleAX.Count() == 2) {
                    if (theArticle.ArticleAX != thirdDegree)
                        this.branchWarning = true;
                    thirdDegree = theArticle.ArticleAX;
                } else if (theArticle.ArticleAX.Count() == 3) {
                    if (theArticle.ArticleAX.Substring(0, 2) != thirdDegree)//an einai gia edra diath kai den einai 00 to thirdDegree
                        this.branchWarning = true;
                    thirdDegree = "00";//gia tin diath to kano 00 epeidi to ax einai 001
                }
                if (secondDegree == "00") {
                    if (fourthDegree == "1800" || fourthDegree == "1600" ||
                        fourthDegree == "0800" || fourthDegree == "0600") {
                        if (!isDioik) {
                            fourthDegree = "1800";
                        } else {
                            fourthDegree = "0800";
                        }
                    } else {
                        this.articleWarning = true;
                    }
                }
            }
        }

        //arthro doro pasxa h doro xristougennon
        public void generateCorrectAccountCodeForArticleDORO(Article theArticle) {//arthro doro pasxa h doro xristougennon
            if (this.accountIsDebit && firstDegree == "60") {//xreostikos logariasmos
                if (theArticle.ArticleAX.Count() == 2) {
                    if (theArticle.ArticleAX != thirdDegree)
                        this.branchWarning = true;
                    thirdDegree = theArticle.ArticleAX;
                } else if (theArticle.ArticleAX.Count() == 3) {
                    if (theArticle.ArticleAX.Substring(0, 2) != thirdDegree)//an einai gia edra diath kai den einai 00 to thirdDegree
                        this.branchWarning = true;
                    thirdDegree = "00";//gia tin diath to kano 00 epeidi to ax einai 001
                }
                if (secondDegree == "00") {
                    if (fourthDegree == "0300" || fourthDegree == "1300") {
                        if (!isDioik) 
                            fourthDegree = "1300";
                        else
                            fourthDegree = "0300";
                    } else
                        this.articleWarning = true;
                } else if (secondDegree == "03" || secondDegree == "04") {//allagh 4o-vathmiou gia ergodotikes eisfores
                    secondDegree = "03";
                    if(!isDioik)
                        fourthDegree = "1000";
                    else
                        fourthDegree = "0000";
                }
            }
        }

        //arthro apoz apolisis h apoz syntaksis
        public void generateCorrectAccountCodeForArticleAPOZIMIOSI(Article theArticle) {//arthro apoz apolisis h apoz syntaksis
            if (this.accountIsDebit && firstDegree == "60") {//xreostikos logariasmos
                if (theArticle.ArticleAX.Count() == 2)
                    thirdDegree = theArticle.ArticleAX;
                else if (theArticle.ArticleAX.Count() == 3)
                    thirdDegree = "00";//gia tin diath to kano 00 epeidi to ax einai 001

                if (secondDegree == "05" || secondDegree.Length >= 3) {//sad logariasmoi tou sad pylon
                    secondDegree = "05";
                    if(!isDioik)
                        fourthDegree = "1000";
                    else
                        fourthDegree = "0000";
                } else
                    this.articleWarning = true;
            }
        }
    }
}