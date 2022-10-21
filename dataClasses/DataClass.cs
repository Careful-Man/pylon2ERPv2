using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pylon2ERP.dataClasses
{
    internal class DataClass
    {
        protected static Dictionary<string, string> branchesDictionary = new();
        protected static Dictionary<string, string> monthsDictionary = new();


        public static Dictionary<string, string> populateBranchesDictionary()
        {
            branchesDictionary.Add("01", "ΥΠ. ΧΑΙΡΙΑΝΩΝ");
            branchesDictionary.Add("02", "ΥΠ. ΠΕΡΙΚΛΕΟΥΣ");
            branchesDictionary.Add("03", "ΥΠ. ΚΑΡΑΚΑΣΗ");
            branchesDictionary.Add("04", "ΥΠ. ΠΟΥΛΑΝΤΖΑΚΗ");
            branchesDictionary.Add("05", "ΥΠ. ΚΗΦΙΣΙΑΣ");//5

            branchesDictionary.Add("06", "ΥΠ. ΛΑΜΠΡΑΚΗ");
            branchesDictionary.Add("07", "ΥΠ. ΠΛΑΓΙΩΝ");
            branchesDictionary.Add("09", "ΥΠ. ΜΑΡΤΙΟΥ");
            branchesDictionary.Add("10", "ΥΠ. ΕΓΝΑΤΙΑΣ");
            branchesDictionary.Add("11", "ΥΠ. ΘΕΡΜΗΣ");//10

            branchesDictionary.Add("13", "ΥΠ. ΝΙΚΟΠΟΛΗΣ");
            branchesDictionary.Add("15", "ΥΠ. ΜΑΡΑΣΛΗ");
            branchesDictionary.Add("16", "ΥΠ. ΙΘΑΚΗΣ");
            branchesDictionary.Add("19", "ΥΠ. ΠΑΡ/ΛΟΥ");
            branchesDictionary.Add("20", "ΥΠ. ΕΠΤΑΛΟΦΟΥ");//15

            branchesDictionary.Add("21", "ΥΠ. ΠΥΛΑΙΑΣ");
            branchesDictionary.Add("22", "ΥΠ. ΑΙΓΑΙΟΥ");
            branchesDictionary.Add("23", "ΥΠ. ΒΙΘΥΝΙΑΣ");
            branchesDictionary.Add("24", "ΥΠ. ΠΟΝΤΟΥ");
            branchesDictionary.Add("25", "ΥΠ. ΧΑΛΚΙΔΙΚΗΣ");//20

            branchesDictionary.Add("26", "ΥΠ. ΕΓΝ-ΠΥΛΑΙΑΣ");


            branchesDictionary.Add("000", "ΕΔΡΑ-ΔΙΟΙΚ.");
            branchesDictionary.Add("001", "ΕΔΡΑ-ΔΙΑΘ.");


            return branchesDictionary;
        }


        public static Dictionary<string, string> populateMonthsDictionary()
        {
            monthsDictionary.Add("01", "ΙΑΝΟΥΑΡΙΟΥ");
            monthsDictionary.Add("02", "ΦΕΒΡΟΥΑΡΙΟΥ");
            monthsDictionary.Add("03", "ΜΑΡΤΙΟΥ");
            monthsDictionary.Add("04", "ΑΠΡΙΛΙΟΥ");
            monthsDictionary.Add("05", "ΜΑΙΟΥ");
            monthsDictionary.Add("06", "ΙΟΥΝΙΟΥ");
            monthsDictionary.Add("07", "ΙΟΥΛΙΟΥ");
            monthsDictionary.Add("08", "ΑΥΓΟΥΣΤΟΥ");
            monthsDictionary.Add("09", "ΣΕΠΤΕΜΒΡΙΟΥ");
            monthsDictionary.Add("10", "ΟΚΤΩΒΡΙΟΥ");
            monthsDictionary.Add("11", "ΝΟΕΜΒΡΙΟΥ");
            monthsDictionary.Add("12", "ΔΕΚΕΜΒΡΙΟΥ");


            return monthsDictionary;
        }
        

        public static Dictionary<string, string> getBranchesDictionary()
        {
            return branchesDictionary;
        }

        public static Dictionary<string, string> getMonthsDictionary()
        {
            return monthsDictionary;
        }
    }
}
