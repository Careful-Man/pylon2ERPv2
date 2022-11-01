using System.Text;

namespace Pylon2ERP.dataClasses {
    public class WriteToText
    {
        public static string p2erpExportPath;
        public static string p2erpExportASCIIPath;

        public static readonly string BINARY_FILE = "L:\\ΤΟΜ\\Visual Studio IDE Workspace\\Pylon2ERP\\bin\\Debug\\net6.0-windows\\research_charge.bin";
        //public static readonly string BINARY_FILE = "\\\\mantis_new\\usersB\\ΓΚΕΝΤΣΙΟΥ\\Pylon2ERP\\research_charge.bin";
        public static readonly string PYLON2ERP_MINIMA = "Pylon2ERP - Μήνυμα";

        //constructor
        public WriteToText()
        {
            try
            {//diavaze apo to diadiko arxeio to pou apothikeftikan ta arxeia teleftea fora
                BinaryReader br = new BinaryReader(File.Open(BINARY_FILE, FileMode.Open));//br goes brrr
                p2erpExportPath = br.ReadString();
                p2erpExportASCIIPath = getp2erpExportASCIIPathFromP2ERPExport(p2erpExportPath);
                br.Close();
            }
            catch(Exception e)
            {
                promptInitializationError();
            }
        }

        //helping methods
        private static void saveP2ERPExportPathToBinaryFile(string thePath)
        {//grafei se diadiko arxeio to pou apothikeftikan ta arxeia teleftea fora
            try
            {
                BinaryWriter bw = new BinaryWriter(File.Open(BINARY_FILE, FileMode.Create));
                bw.Write(p2erpExportPath);
                bw.Close();
            }catch (Exception e)
            {
                promptInitializationError();
            }
            
        }

        private static string getp2erpExportASCIIPathFromP2ERPExport(string p2erpExportPath)
        {//vres to onoma tou arxikou arxeiou kai vale ena _ASCII sto telos gia na fainetai pxio einai pxio
            return p2erpExportPath.Substring(0, p2erpExportPath.Count() - 4) + "_ASCII.txt";
        }

        private static void promptInitializationError()
        {//emfanizei intialization error an den brei to research_charge.bin
            DialogResult drOk = MessageBox.Show(
                     "Σφάλμα αρχικοποίησης. Δεν βρέθηκε το αρχείο research_charge.bin",
                     PYLON2ERP_MINIMA,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button2);
        }

        //create, write, delete P2ERP_export methods
        public static void appendGLArticlesToP2ERPtxt(List<Article> artList, MainForm mf)
        {//grafei sto prototypo arxeio
            //kseklidonei ola ta encodings gia to Encoding.GetEncoding(..)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            SaveFileDialog saveP2ERP = new SaveFileDialog();
            saveP2ERP.Filter = "Txt files (*.txt)|*.txt";
            saveP2ERP.FileName = "P2ERP_EXPORTS";
            saveP2ERP.Title = "Επιλέξτε την διαδρομή αποθήκευσης του αρχείου P2ERP";
            if (saveP2ERP.ShowDialog() == DialogResult.OK)
            {
                p2erpExportPath = saveP2ERP.FileName;
                saveP2ERPExportPathToBinaryFile(p2erpExportPath);
                
                StreamWriter writer = new StreamWriter(File.Open(p2erpExportPath, FileMode.Create), Encoding.GetEncoding("utf-8"));

                //to string afto ftiaxnei tin grammi pou tha eisago sto arxeio.
                //prepei na exei para poli sigkekrimeni morfi kai mikos
                string lineToAppend;
                string descriptionSpaces = "                                                       ";//55 kena
                string balanceSpaces = "                    ";//20 kena
                char debitOrCreditText;
                string accountBalancedStringed;

                //H kefalida prepei na einai ena string stin proti grammi kai meta mia keni grammi. 
                //To ERP ksekinaei na diavazei meta apo tin keni grammi afti.
                writer.Write("PYLON2ERP ZEALOTS - START\n");

                foreach (Article theArticleToAppend in artList)
                {
                    writer.Write("\n");
                    List<Account> listOfAccounts = theArticleToAppend.ArticleAccounts;
                    foreach (Account acc in listOfAccounts)
                    {
                        //elegxos gia to an einai pistotikos h xreostikos logariasmos
                        if (acc.AccountIsDebit)
                            debitOrCreditText = 'Χ';
                        else
                            debitOrCreditText = 'Π';
                        //elegxos gia to an iparxei mono 1 dekadiko stin aksia tou logariasmou 
                        //epeidi einai pedio double an to poso einai px 69,10 afto krataei 69,1
                        //ara an exei 1 dekadiko pao kai vazo ena miden sto telos
                        accountBalancedStringed = theArticleToAppend.getAccountBalanceStringed(acc.AccountBalance);

                        lineToAppend = Article.CALENDAR +
                                      theArticleToAppend.ArticleDate +
                                      "  " +
                                      acc.AccountCodeCorrected +
                                      "              " +
                                      Article.DOCUMENT_TYPE +
                                      "           " +
                                      theArticleToAppend.ArticleDescription +
                                      descriptionSpaces.Substring(theArticleToAppend.ArticleDescription.Length) + //simplironei osa kena xreazetai gia na ginei i perigrafi 55 xaraktires akrivos. Max size perigrafis = 52, opote pare doro kai 3 kena
                                      Article.PAYMENT_METHOD +
                                      theArticleToAppend.ArticleDate +
                                      debitOrCreditText +
                                      balanceSpaces.Substring(accountBalancedStringed.Length) +
                                      accountBalancedStringed +
                                      Article.XRHSH;

                        writer.Write(lineToAppend + "\n");
                    }
                }
                writer.Close();
                convertP2ERPtoASCII();//oli i mageia.
                //des ta arthra pou perastikan kai emfanise ta se messagedialog
                string messageBoxString = "";
                foreach (Article art in artList)
                {
                    messageBoxString += art.ArticleDescription + ".\n";
                }
                DialogResult drOk = MessageBox.Show(
                     "Εξαγωγή επιτυχής. Άρθρα που εξήχθησαν:\n\n" + messageBoxString,
                     PYLON2ERP_MINIMA,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button2);
                //adeiase tis domes kataxorisis
                mf.clearCoast();
            }
        }

        public static void deleteP2ERPTextFile(MainForm mf)
        {//diagrafei ta arxeia .txt pou dimiourgei to programma
            try
            {
                File.Delete(p2erpExportPath);
                File.Delete(p2erpExportASCIIPath);
                mf.clearCoast();
                DialogResult drOk = MessageBox.Show(
                     "Διαγραφή επιτυχής.",
                     PYLON2ERP_MINIMA,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button2);
            }
            catch(Exception e)
            {
                promptInitializationError();
            }
        }

        public static void convertP2ERPtoASCII()
        {//to zoumi tis ipothesis. vgazei to arxeio pou diavazei to erp
            try
            {
                //kseklidonei ola ta encodings gia to Encoding.GetEncoding(..)
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                p2erpExportASCIIPath = getp2erpExportASCIIPathFromP2ERPExport(p2erpExportPath);
                //diavazi olo to arxiko arxeio kai to kanei ascii
                string fileContent = File.ReadAllText(p2erpExportPath);
                StreamWriter writer = new StreamWriter(File.Open(p2erpExportASCIIPath, FileMode.Create),
                                                       Encoding.GetEncoding("IBM737"));
                writer.Write(fileContent);
                writer.Close();
                File.Delete(p2erpExportPath);
            }
            catch (Exception e)
            {
                promptInitializationError();
            }
        }
    }
}
