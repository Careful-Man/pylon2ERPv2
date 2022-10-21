using Pylon2ERP.dataClasses;
using Pylon2ERP.gui;
using Pylon2ERP.Properties;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pylon2ERP
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFilePicker;
        private bool error;
        private string errorMessages;
        //aftes oi 2 domes me voithoyn na ftiakso to string tis
        //perigrafis toy arthrou
        private Dictionary<string, string> branchDictionary;
        private Dictionary<string, string> monthDictionary;
        //domi pou xrisimopoio gia na grapso ta arthra sto arxeio
        private List<Article> treeArticles;

        public static readonly string SEPERATOR = "###################################################################################################";
        public static readonly string DASHES = "\n---------------------------------------------------------------------------------------------------";
        

        //constructor
        public MainForm()
        {
            this.error = false;
            //arxikopoihsh twn leksikwn
            this.branchDictionary = DataClass.populateBranchesDictionary();
            this.monthDictionary = DataClass.populateMonthsDictionary();
            //arxikopoihsh tis listas arthron
            treeArticles = new List<Article>();
            //arxikopoihsh twn paths tou arxeiou export
            new WriteToText();

            this.InitializeComponent();
        }
        




        //my methods
        public void setFilePathToTextBox(String s)
        {
            this.filePathTextBox.Text = s;
        }

        private string getWrongDateMessage(String type)
        {//methodos pou morfopoiei to minima lathous gia tin hm/nia
            return "Σφάλμα: Λανθασμένη ημερομηνία για τον δεδομένο τύπο άρθρου (" + type + ").\n";
        }

        public void appendToConsoleText(string s)
        {//grafei stin konsola kanontas append, xoris na svinei to ti egrafe prin
                this.consoleRichTextBox.AppendText(s + "\n");
        }

        public void appendToConsoleColoredText(string s, Color fc, Color bc)
        {//methodos pou kanei format to text kefalidon
            consoleRichTextBox.SelectionFont = new Font(consoleRichTextBox.Font, FontStyle.Bold);
            consoleRichTextBox.SelectionColor = fc;
            consoleRichTextBox.SelectionBackColor = bc;
            consoleRichTextBox.SelectedText = "\n" + s + "\n";
            consoleRichTextBox.SelectionFont = new Font(consoleRichTextBox.Font, FontStyle.Regular);
        }

        public void appendToConsoleRichTextBoxFormattedTextData(string s, string CONSTANT)
        {//methodos pou kanei format ta posa kai tous kodikous ton logariasmon
            try
            {//bold ksebold, italic kseitalic
                if (s.Substring(0, CONSTANT.Length) == CONSTANT)
                {
                    consoleRichTextBox.SelectedText = CONSTANT;
                    consoleRichTextBox.SelectedText += s.Substring(CONSTANT.Length, s.Length - CONSTANT.Length);
                }
                else
                {
                    this.consoleRichTextBox.AppendText(s);
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                this.consoleRichTextBox.AppendText(s);
            }
        }

        public void clearConsoleRichTextBoxText()
        {//grafei stin konsola svinontas to ti egrafe prin, oste meta na grafei mono to string s
            this.consoleRichTextBox.Text = "";
        }

        public void addArticleToTreeView(Article theArticle)
        {//methodos pou vazei antikeimena sto tree
            TreeNode root = new TreeNode(theArticle.ArticleDescription, new TreeNode[] {});
            root.Text = theArticle.ArticleDescription;

            
            bool found = false;
            foreach(Article art in treeArticles)
            {//psaxnei na vrei an iparxei idi arthro me afti tin aitiologia
                if(art.ArticleDescription == theArticle.ArticleDescription)
                {
                    found = true;
                }
            }
            if (!found)
            {//an to arthro iparxei idi min to valeis
                foreach (Account acc in theArticle.ArticleAccounts)
                {
                    TreeNode accCodeLeaf = new TreeNode();
                    TreeNode accBalanceLeaf = new TreeNode();
                    TreeNode accIsDebitLeaf = new TreeNode();

                    accCodeLeaf.Text = acc.AccountCodeCorrected;
                    accBalanceLeaf.Text = "Ποσό: " + theArticle.getAccountBalanceStringed(acc.AccountBalance) + "€";
                    if (acc.AccountIsDebit)
                        accIsDebitLeaf.Text = "Χρεωστικός λογαριασμός";
                    else
                        accIsDebitLeaf.Text = "Πιστωτικός λογαριασμός";
                    accCodeLeaf.Nodes.Add(accIsDebitLeaf);
                    accCodeLeaf.Nodes.Add(accBalanceLeaf);
                    root.Nodes.Add(accCodeLeaf);
                }
                this.articleTreeView.Nodes.AddRange(new TreeNode[] { root });
                this.treeArticles.Add(theArticle);
                theArticle.printArticlesAccounts(this);//tiponei tous logariasmous tou arthrou stin konsola
            } else
            {
                this.appendToConsoleColoredText("Σφάλμα: Δεν μπορούν να εισαχθούν 2 άρθρα την φορά με την ίδια αιτιολογία.", Color.White, Color.Red);
            }
        }

        public void clearCoast()
        {//katharizei ta panta, avles katharizo ipogeia katharizo
            this.filePathTextBox.Text = "";
            this.articleDatePicker.Value = DateTime.Now;
            this.axTextBox.Text = "";
            this.articleTypeComboBox.SelectedIndex = -1;
            this.clearConsoleRichTextBoxText();
            this.articleTreeView.Nodes.Clear();
            this.treeArticles.Clear();
        }









        //Event handling
        private void openFileDialogButton_Click(object sender, EventArgs e)
        {//otan patao to ... anoigei file explorer
            openFilePicker = new OpenFileDialog();
            openFilePicker.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFilePicker.Title = "Επιλέξτε ένα αρχείο εξαγωγής Pylon";

            if (openFilePicker.ShowDialog() == DialogResult.OK)
            {
                this.setFilePathToTextBox(openFilePicker.FileName);
            }
        }

        private void axTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//me afini na grapso mono noumera sto pedio "AX"
            if (e.KeyChar == (char)Keys.Enter)
                startButton.PerformClick();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {//!char.IsControl(e.KeyChar) = me afini na patiso backspace, ctrl+c,v klp
                e.Handled = true;
            }
            //den ksero pos doulevei afto to pragma. afini ton xristi na grapsei mono 2 noumera
            //kai an grapsei 00 ton afinei na grapse ena epipleon 0 h 1 
            //epishs afinei na kanei select kai na grapsei pano apo to select, xoris na ton afinei
            //na grapsei kati pou den prepei.
            //an pas na to allakseis kai den eisai o thomas, yea good luck with that
            if (!char.IsControl(e.KeyChar) && axTextBox.Text.Length > 1) {
                if (!(axTextBox.Text == "00"))
                    e.Handled = true;//an to pedio den grafei 00, den afinei na grapsei kati allo
                else if (e.KeyChar != '0' && e.KeyChar != '1')
                    e.Handled = true;//an grafei 00, afinei na grapsei 0 h 1

                if (axTextBox.SelectedText == axTextBox.Text) {//an dialeksei olous xaraktires tou pediou
                    if(char.IsDigit(e.KeyChar))//an grapsei noumero kai oxi xaraktira, ton afinei na to grapsei
                        axTextBox.Text = e.KeyChar.ToString();
                    axTextBox.Select(axTextBox.Text.Length, 0);
                } else if (axTextBox.SelectedText.Length == 1) {//an dialeksei 1 xaraktira
                    if (axTextBox.Text.Length < 3) {//an den milame gia edra (dld oxi 000 h 001)
                        if (char.IsDigit(e.KeyChar))//an grapsei noumero kai oxi xaraktira, ton afinei na to grapsei
                            axTextBox.SelectedText = e.KeyChar.ToString();//allazei to selection se oti pliktrologisi o xristis
                        //elegxoi gia to pou na valei ton kersora
                        if (axTextBox.SelectedText == axTextBox.Text.Substring(0, 1)) {//an dialekse ton 1o xaraktira
                            axTextBox.Select(axTextBox.SelectedText.Length + 1, 0);
                        } else if (axTextBox.SelectedText == axTextBox.Text.Substring(1, 1)) {//an dialekse ton 2o xaraktira
                            axTextBox.Select(axTextBox.SelectedText.Length + 2, 0);
                        }
                    } else {//an milame gia edra, dld 000 h 001
                        if ((e.KeyChar == '0' || e.KeyChar == '1') && axTextBox.SelectedText == axTextBox.Text.Substring(2, 1)) {//an exei 3 xaraktires to pedio, afinei na grapsei mono 0 h 1
                            if (char.IsDigit(e.KeyChar))//an grapsei noumero kai oxi xaraktira, ton afinei na to grapsei
                                axTextBox.SelectedText = e.KeyChar.ToString();
                            if (axTextBox.Text != "000" && axTextBox.Text != "001") {//an paei na grapsei kati periergo px grafei to pedio 000 dialeksei to 1o mideniko kai grapsei 1 kai grapsei 100, adeiazei to pedio
                                axTextBox.Text = "";
                            }
                        }
                        axTextBox.Select(3, 0);//stelnei ton kersora sto telos
                    }
                } else if (axTextBox.SelectedText.Length == 2) {//stin periptosi tou 000 h 001 
                    if (axTextBox.Text.Length == 3) {
                        if (char.IsDigit(e.KeyChar))//an grapsei noumero kai oxi xaraktira, ton afinei na to grapsei
                            axTextBox.SelectedText = e.KeyChar.ToString();
                    }
                }
                if (e.KeyChar == (char)Keys.Back)//an ta dialeksei ola kai patisei backspace, ta svinei ola. Nai, einai aparaitito afto to kommati kodika
                    axNameLabel.Text = "";

                

            }
        }

        private void axTextBox_TextChanged(object sender, EventArgs e)
        {//emfanizei to onoma tou AX
            try
            {//an vreis ton ax, grapse poios einai 
                axNameLabel.Text = branchDictionary[axTextBox.Text];
            }
            catch (NullReferenceException nre)
            {//allios min grapseis kati
                axNameLabel.Text = "";
            }
            catch (KeyNotFoundException knfe)
            {//allios min grapseis kati
                axNameLabel.Text = "";
            }
        }

        private void consoleRichTextBox_TextChanged(object sender, EventArgs e)
        {//methodos pou kanei scrolldown aftomata sto rich text box kathe fora poy allazei to text toy
            // set the current caret position to the end
            consoleRichTextBox.SelectionStart = consoleRichTextBox.Text.Length;
            // scroll it automatically
            consoleRichTextBox.ScrollToCaret();
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {//methodos pou paei kai diagrafei apo tin lista ton arthron, to arthro pou diagrafei o xristis apo to dentro
            DialogResult drYesNo = MessageBox.Show(
                "Διαγραφή του επιλεγμένου άρθρου;",
                "Pylon2ERP - Μήνυμα",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            if (drYesNo == DialogResult.Yes)
            {
                try
                {
                    bool found = false;
                    foreach(Article art in treeArticles)
                    {
                        if(art.ArticleDescription == articleTreeView.SelectedNode.Text)
                        {
                            found = false;
                            TreeNodeCollection tnc = articleTreeView.SelectedNode.Nodes;
                            foreach(TreeNode tn in tnc)
                            {
                                foreach(Account acc in art.ArticleAccounts)
                                {
                                    if(tn.Text == acc.AccountCodeCorrected)
                                        found = true;
                                }
                                break;
                            }
                            if (found)
                            {
                                if (treeArticles.Remove(art))//edo afaireitai apo tin lista ton arthron
                                {
                                    //edo afaireitai apo to treeview
                                    this.articleTreeView.Nodes.Remove(this.articleTreeView.SelectedNode);
                                    this.articleTreeView.SelectedNode = null;
                                    this.articleTreeView.TabStop = false;

                                    DialogResult drOk = MessageBox.Show(
                                        "Διαγραφή άρθρου επιτυχής. Διαγράφηκε το άρθρο:\n" + art.ArticleDescription + ".",
                                        "Pylon2ERP - Μήνυμα",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information,
                                         MessageBoxDefaultButton.Button2);
                                    break;
                                }
                            }
                        }
                    }
                    if (!found)
                    {
                        DialogResult drOk = MessageBox.Show(
                                        "Δεν είναι δυνατή η διαγραφή τις επιλογής \n" + articleTreeView.SelectedNode.Text + "\nΕπιτρέπεται μόνο η διαγραφή άρθρων.",
                                        "Pylon2ERP - Μήνυμα",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information,
                                         MessageBoxDefaultButton.Button2);
                    }
                }
                catch (NullReferenceException nre)
                {
                    DialogResult drOk = MessageBox.Show(
                        "Δεν έχει επιλεχθεί άρθρο.",
                        "Pylon2ERP - Μήνυμα",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button2);
                }
                catch (InvalidOperationException ioe)
                {
                    DialogResult drOk = MessageBox.Show(
                        "\n" + ioe.Message,
                        "Pylon2ERP - Μήνυμα",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error,
                         MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {//katharizei ta panta plires wipe xxx tha pethanoume oloi
            DialogResult drYesNo = MessageBox.Show(
                "Διαγραφή των αρχείων καταχώρησης και του περιεχομένου της κονσόλας;\n" +
                "Αυτή η πράξη είναι μη αντιστρέψιμη.",
                "Pylon2ERP - Μήνυμα",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Warning);
            if (drYesNo == DialogResult.Yes)
                WriteToText.deleteP2ERPTextFile(this);
        }

        private void extractAllButton_Click(object sender, EventArgs e)
        {//otan o xristis pataei eksagogi olon, eksagei ta arthra tis voithitikis listas aftis tis klasis, sto arxeio
            DialogResult drYesNo = MessageBox.Show(
                "Εξαγωγή των άρθρων σε αρχείο .txt;",
                "Pylon2ERP - Μήνυμα",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            if (drYesNo == DialogResult.Yes && articleTreeView.Nodes.Count != 0)
            {//an patisei o xristis nai kai iparxoun arthra pros kataxorisi, kataxorise ta
                WriteToText.appendGLArticlesToP2ERPtxt(this.treeArticles, this);
            } else if(drYesNo == DialogResult.Yes && articleTreeView.Nodes.Count == 0)
            {//an patisi nai kai den iparxoun arthra pros kataxorisi, emfanise sxetiko minima
                DialogResult drOk = MessageBox.Show(
                    "Δεν υπάρχουν άρθρα προς εξαγωγή.",
                    "Pylon2ERP - Μήνυμα",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button2);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {//otan o xristis pataei "Ekkinhsh"
            this.appendToConsoleText(SEPERATOR);
            error = false;
            errorMessages = "";
            try
            {//prospathise na diavaseis to arxeio pou eisigage o xrhsths
                StreamReader reader = new StreamReader(filePathTextBox.Text);
                reader.Close();
            }
            catch (ArgumentException ae)
            {
                error = true;
                errorMessages += "Σφάλμα: Το αρχείο δεν βρέθηκε.\n";
            }
            if (!branchDictionary.ContainsKey(axTextBox.Text))
            {//an den vrei ton apothikeftiko xoro
                error = true;
                errorMessages += "Σφάλμα: Ο δεδομένος αποθηκευτικός χώρος δεν υπάρχει.\n";
            }
            if (articleTypeComboBox.Text == "")
            {//an den epilegei tipos arthrou
                error = true;
                errorMessages += "Σφάλμα: Δεν έχει επιλεχθεί τύπος άρθρου.\n";
            }
            //periorismoi hmeromhnias
            try
            {//prospathise na elegkseis tin hmeromhnia poy eisigage o xrhsths se sinartisi me ton typo arthrou
                string date = articleDatePicker.Text;
                int dayPicked = Int32.Parse(date.Substring(0, 2));//h hmera apo to date pou dialekse
                int monthPicked = Int32.Parse(date.Substring(3, 2));//o minas apo to date pou dialekse
                //poses meres exei o minas pou dialekse
                int daysInMonth = DateTime.DaysInMonth(Int32.Parse("20" + date.Substring(date.Length - 2, 2)), monthPicked);
                if (articleTypeComboBox.Text == "ΜΙΣΘΟΔΟΣΙΑ")
                {//arthra misthodosias kataxoroyntai panta teleftea mera toy mina
                    if (dayPicked != daysInMonth)
                    {
                        error = true;
                        errorMessages = getWrongDateMessage(articleTypeComboBox.Text) +
                                        "        Ένα άρθρο " + articleTypeComboBox.Text + " μπορεί να καταχωρηθεί μόνο την τελευταία μέρα του μήνα.\n";
                    }
                }
                else if (articleTypeComboBox.Text == "ΕΠΙΔ. ΑΔΕΙΑΣ")
                {//arthra epidomatos adeias kataxoroyntai panta proteleftea mera toy mina
                    if (dayPicked != daysInMonth - 1)
                    {
                        error = true;
                        errorMessages = getWrongDateMessage(articleTypeComboBox.Text) +
                                        "        Ένα άρθρο " + articleTypeComboBox.Text + " μπορεί να καταχωρηθεί μόνο την προτελευταία μέρα του μήνα.\n";
                    }
                }
                else if (articleTypeComboBox.Text == "ΑΠΟΖ. ΑΔΕΙΑΣ")
                {//arthra apozimiosis adeias kataxorountai panta pro proteleftea mera toy mina
                    if (dayPicked != daysInMonth - 2)
                    {
                        error = true;
                        errorMessages = getWrongDateMessage(articleTypeComboBox.Text) +
                                        "        Ένα άρθρο " + articleTypeComboBox.Text + " μπορεί να καταχωρηθεί μόνο την προ-προτελευταία μέρα του μήνα.\n";
                    }
                }
                else if (articleTypeComboBox.Text == "ΔΩΡΟ ΠΑΣΧΑ")
                {//to pasxa einai kiniti eorti. Pasxa einai i kiriaki meta tin panselino tou martiou,
                 //ara peftei aprilio. mporei omos na pesei kai maio epeidi giati oxi
                    if (monthPicked != 4 && monthPicked != 5)
                    {//ara afino na kataxorisei se aprilio kai maio
                        error = true;
                        errorMessages = getWrongDateMessage(articleTypeComboBox.Text) +
                                        "        Ένα άρθρο " + articleTypeComboBox.Text + " μπορεί να καταχωρηθεί μόνο στους μήνες Απρίλιο ή Μάιο.\n";
                    }
                }
                else if (articleTypeComboBox.Text == "ΔΩΡΟ ΧΡΙΣΤΟΥΓΕΝΝΩΝ")
                {//eutuxos xristougenna einai mono ton dekemvrio
                    if (monthPicked != 12)
                    {//ara afino na kataxorisei se dekemvrio
                        error = true;
                        errorMessages = getWrongDateMessage(articleTypeComboBox.Text) +
                                        "        Ένα άρθρο " + articleTypeComboBox.Text + " μπορεί να καταχωρηθεί μόνο στον μήνα Δεκέμβριο.\n";
                    }
                }
            }
            catch (Exception exc)
            {//an ginei kati poli fail me tin hmeromhnia pias to edo
                error = true;
                errorMessages += "Σφάλμα: Υπήρξε σφάλμα με την ημερομηνία.\n" + exc.Message;
            }
            //an meta apo tous elegxous vrike lathos, ektipose ta minimata lathous
            if (error)
                appendToConsoleColoredText(errorMessages, Color.White, Color.Red);
            else
            {//allios diavase to arxeio
                new ReadPylonFile(filePathTextBox,
                                    articleDatePicker,
                                    axTextBox,
                                    articleTypeComboBox,
                                    this);
            }
        }


        private void helpToolStripStatusLabel_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            new HelpForm().ShowDialog();
        }

        private void helpToolStripStatusLabel_MouseHover(object sender, EventArgs e) {
            helpToolStripStatusLabel.BackColor = Color.Transparent;
        }

        private void helpToolStripStatusLabel_MouseDown(object sender, MouseEventArgs e) {
            helpToolStripStatusLabel.BackColor = Color.Gray;
        }

        private void helpToolStripStatusLabel_MouseUp(object sender, MouseEventArgs e) {
            helpToolStripStatusLabel.BackColor = Color.Silver;
        }

        private void helpToolStripStatusLabel_MouseLeave(object sender, EventArgs e) {
            Cursor.Current = Cursors.Default;
            helpToolStripStatusLabel.BackColor = Color.Silver;
        }

    }
}