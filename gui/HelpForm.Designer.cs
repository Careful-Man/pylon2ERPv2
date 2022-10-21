namespace Pylon2ERP.gui {
    partial class HelpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Σε αυτό το πεδίο ο χρήστης εισάγει την διαδρομή του αρχείου Pylon που θα διαβαστε" +
        "ί. ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Η τιμή του πεδίου αυτού αλλάζει μόνο από το πλήκτρο \"...\". ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Δεν επιτρέπει στον χρήστη να αλλάξει την τιμή του από το πεδίο αυτό καθαυτό.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Το όνομα και η διαδρομή του αρχείου δεν παίζουν κανένα ρόλο στον σχηματισμό του ά" +
        "ρθρου που θα κάνει το πρόγραμμα. Το αρχείο χρησιμοποιείται μόνο για να διαβαστού" +
        "ν τα δεδομένα του.");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Το πρόγραμμα μπορεί να καταλάβει αν το αρχείο που διαβάζεται είναι αρχείο που εξή" +
        "χθη από το Pylon.");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Αν ένα αρχείο δεν αναγνωριστεί ως αρχείο Pylon, το πρόγραμμα εμφανίζει σχετικό μή" +
        "νυμα στην κονσόλα μηνυμάτων.");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Πεδίο \"Διαδρομή αρχείου\"", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ο χρήστης μπορεί να πατήσει στο βελάκι για να ανοίξει το μενού που του επιτρέπει " +
        "να διαλέξει μία ημερομηνία.");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Επιτρέπει επίσης στον χρήστη να πληκτρολογήσει την ημερομηνία που θέλει αν πατήσε" +
        "ι κλικ επάνω στην ημερομηνία.");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Προτού διαβάσει το άρθρο, το πρόγραμμα ελέγχει την ορθότητα της ημερομηνίας για τ" +
        "ον επιλεγμένο τύπο άρθρου και αν είναι λανθασμένη, εμφανίζει σχετικό μήνυμα.");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Πεδίο \"Ημ/νία Άρθρου\"", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να πληκτρολογεί μόνο αριθμούς.");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να πληκτρολογήσει μόνο 2 αριθμούς,\r\n");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("εκτός αν πληκτρολογήσει \"00\". Σε αυτή την περίπτωση επιτρέπει στον χρήστη να πληκ" +
        "τρολογήσει έναν ακόμη αριμό, 0 ή 1.");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Αν ο κωδικός καταστήματος είναι ορθός, θα εμφανιστεί δεξιά από το πεδίο το όνομα " +
        "του καταστήματος.");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ΕΝΗΜΕΡΩΣΗ 12/10/22: Επιτρέπει την επιλογή κειμένου στο πεδίο και την εισαγωγή αρι" +
        "θμών χωρίς να χρειαστεί να πατηθεί το πλήκτρο backspace.");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("ΕΝΗΜΕΡΩΣΗ 12/10/22: Μετονομασία του πεδίου από \"ΑΧ\" σε \"Κατάστημα\".");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Πεδίο \"Κατάστημα\"", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να διαλέξει τον τύπο του άρθρου που εισάγεται.");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να εισάγει τιμές μόνο από την αναδυόμενη λίστα.");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Κάθε τύπος άρθρου χρειάζεται συγκεκριμένη ημερομηνία άρθρου. ");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Αν η ημερομηνία είναι εσφαλμένη για ένα δεδομένο τύπο άρθρου το πρόγραμμα εμφανίζ" +
        "ει σχετικό μήνυμα στην κονσόλα μηνυμάτων και δεν διαβάζει το άρθρο.");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Πεδίο \"Τύπος Άρθρου\"", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Πεδία", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11,
            treeNode18,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Ότι άρθρο διαβαστεί εισάγεται σε αυτή την δενδρική δομή.");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Περιέχει τα άρθρα που θα εξαχθούν στο αρχείο που δημιουργεί το πλήκτρο \"Εξαγωγή Ό" +
        "λων\".");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να διαγράψει κάποιο άρθρο, επιλέγοντάς το και πιέζοντας το " +
        "πλήκτρο \"Εκκαθάριση Επιλογής\".");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Επιτρέπει μόνο την διαγραφή άρθρων και όχι την διαγραφή λογαριασμών, ποσών κλπ.");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Επιτρέπει στον χρήστη να διαγράψει όλα τα άρθρα που έχουν διαβαστεί από το πρόγρα" +
        "μμα πιέζοντας το πλήκτρο \"Εκκαθάριση Όλων\".");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Ότι κίνηση και να έχει γίνει από διάβασμα/διαγραφή άρθρων, όταν ο χρήστης πατήσει" +
        " εξαγωγή όλων, το πρόγραμμα εξάγει μόνο τα άρθρα που φαίνονται στην δομή \"Άρθρα " +
        "προς εξαγωγή\".");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Άρθρα προς εξαγωγή", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Γενικότερα, εμφανίζει ότι συμβαίνει στο παρασκήνιο.");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Εμφανίζει προειδοποιητικά μηνύματα ή μηνύματα λάθους, όπου αυτά χρειάζονται.");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Εμφανίζει διάφορες λεπτομέρειες σχετικά με τα άρθρα που διαβάζει, όπως πχ περιγρα" +
        "φή άρθρου, κωδικούς λογαριασμών, ποσά λογαριασμών κλπ.");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Το κείμενο της κονσόλας δεν επηρρεάζει το τι θα εξάγει το πρόγραμμα όταν ο χρήστη" +
        "ς πιέσει το πλήκτρο \"Εξαγωγή Όλων\".");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Κονσόλα μηνυμάτων", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Άρθρα και Κονσόλα", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Ελέγχει την ορθότητα των δεδομένων που έχει εισάγει ο χρήστης.");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Αν υπάρχουν σφάλματα, εμφανίζει σχετικό μήνυμα στην κονσόλα ή σε παράθυρο διαλόγο" +
        "υ");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Αν δεν βρει σφάλμα, ανοίγει το αρχείο προς ανάγνωση.");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Η πορεία της ανάγνωσης του αρχείου φαίνεται στην κονσόλα μηνυμάτων.");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Είναι το μόνο πλήκτρο το οποίο όσες φορές και να πατηθεί και ότι και να γίνει αφο" +
        "ύ πατηθεί, η πράξη που κάνει μπορεί να διορθωθεί/αντιστραφεί.");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Είναι το μόνο πλήκτρο που δεν εμφανίζει παράθυρο διαλόγου όταν πατηθεί.");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Τα υπόλοιπα πλήκτρα εμφανίζουν παράθυρα διαλόγου όταν πατηθούν και κάνουν μη αντι" +
        "στέψιμες πράξεις.");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Πλήκτρο \"Εκκίνηση\"", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Αφού πατηθεί εμφανίζει παράθυρο διαλόγου για το αν θέλει ο χρήστης να κάνει εξαγω" +
        "γή των άρθρων που διαβάστηκαν.");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Μόνο αν πατήσει \"Ναι\", ο χρήστης προχωράει στην εξαγωγή των άρθρων.");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαβάζει όλα τα άρθρα που βρίσκονται στη" +
        "ν δομή \"Άρθρα προς εξαγωγή\".");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Αν έχουν διαβαστεί άρθρα τα οποία στην πορεία διαγράφηκαν από τον χρήστη, δεν θα " +
        "συμπεριληφθουν στην εξαγωγή.");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("με όνομα κάτι.txt");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Το πρόγραμμα δημιουργεί ένα αρχείο με όλα τα άρθρα που εξήχθησαν.", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("με όνομα κάτι_ASCII.txt");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Μετά, το πρόγραμμα παίρνει το αρχείο που μόλις δημιούργησε και αλλάζει την κωδικο" +
        "ποίησή του ώστε να μπορεί να το διαβάσει το ERP.", new System.Windows.Forms.TreeNode[] {
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Αφού ολοκληρωθεί αυτή η διαδικασία επιτυχώς, το πρόγραμμα εμφανίζει σχετικό παράθ" +
        "υρο διαλόγου.");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Διαγράφει το αρχείο κάτι.txt και αφήνει το κάτι_ASCII.txt προς καταχώρηση στο ERP" +
        "");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("ΕΝΗΜΕΡΩΣΗ 12/10/22: Αφού δημιουργήσει τα 2 αρχεία, το πρόγραμμα διαγράφει το αρχε" +
        "ίο που δεν προορίζεται προς εισαγωγή στο ERP.", new System.Windows.Forms.TreeNode[] {
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Πλήκτρο \"Εξαγωγή Όλων\"", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode52,
            treeNode54,
            treeNode55,
            treeNode57});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode(resources.GetString("helpTreeView.Nodes"));
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Μόνο αν πατήσει \"Ναι\" ο χρήστης, προχωράει στην διαγραφή όλων αυτών των δεδομένων" +
        ".");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαγράφει όλα τα δεδομένα που διάβασε κα" +
        "ι τα αρχεία που δημιούργησε για καταχώρηση στο ERP.");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Πλήκτρο \"Εκκαθάριση Όλων\"", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Αφού πατηθεί εμφανίζει παράθυρο διαλόγου για το αν θέλει ο χρήστης να κάνει διαγρ" +
        "αφή του επιλεγμένου άρθρου από την δομή \"Άρθρα προς εξαγωγή\".");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Το πρόγραμμα δεν επιτρέπει διαγραφή άλλων δεδομένων από την δομή, παρά μόνο άρθρα" +
        ".");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Μόνο αν πατήσει \"Ναι\" ο χρήστης, προχωράει στην διαγραφή του άρθρου.");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαγράφει το άρθρο απ\' την δομή και όταν" +
        " ο χρήστης πιέσει το πλήκτρο \"Εξαγωγή Όλων\" το διαγραμμένο άρθρο δεν θα συμπεριλ" +
        "ηφθεί στην εξαγωγή. ");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Πλήκτρο \"Εκκαθάριση Επιλογής\"", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Εμφανίζει αυτό το παράθυρο.");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Εξηγεί αναλυτικά την λειτουργεία του προγράμματος.");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Περιέχει τις διάφορες αλλαγές που γίνονται στο πρόγραμμα που επηρρεάζουν την εμπε" +
        "ιρία χρήστη.");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Πλήκτρο \"Βοήθεια\"", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Πλήκτρα", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode58,
            treeNode63,
            treeNode69,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Για καταχώρηση: ");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Τύπος εγγραφών: Γενική (προεπιλεγμένο)");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Κωδικός Λογ/σμού: 13");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Αιτιολογία: 55");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Περιοχή: επιλογή του αρχείου κάτι_ASCII.txt");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Προσοχή! Στο παράθυρο επιλογής αρχείου πρέπει να οριστεί ως τύπος αρχείου ο .txt " +
        "(προεπιλογή είναι ο .pni), αλλιώς δεν θα φαίνεται το αρχείο που δημιούργησε το π" +
        "ρόγραμμα.");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Αν η καταχώρηση είναι επιτυχής το ERP δεν εμφανίζει κάποιο μήνυμα.");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Αν η καταχώρηση είναι επιτυχής, το αρχείο καταχώρησης διαγράφεται.");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Εισαγωγή δεδομένων από αρχείο ASCII", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Βοηθητικές εργασίες", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Περιοδικές εργασίες", new System.Windows.Forms.TreeNode[] {
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Καταχώρηση αρχείου στο ERP", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode(resources.GetString("helpTreeView.Nodes1"));
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Λοιπές σημειώσεις", new System.Windows.Forms.TreeNode[] {
            treeNode87});
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpTreeView = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 761);
            this.panel1.TabIndex = 0;
            // 
            // helpTreeView
            // 
            this.helpTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpTreeView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.helpTreeView.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpTreeView.Indent = 20;
            this.helpTreeView.ItemHeight = 25;
            this.helpTreeView.Location = new System.Drawing.Point(12, 49);
            this.helpTreeView.Name = "helpTreeView";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Σε αυτό το πεδίο ο χρήστης εισάγει την διαδρομή του αρχείου Pylon που θα διαβαστε" +
    "ί. ";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Η τιμή του πεδίου αυτού αλλάζει μόνο από το πλήκτρο \"...\". ";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Δεν επιτρέπει στον χρήστη να αλλάξει την τιμή του από το πεδίο αυτό καθαυτό.";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Το όνομα και η διαδρομή του αρχείου δεν παίζουν κανένα ρόλο στον σχηματισμό του ά" +
    "ρθρου που θα κάνει το πρόγραμμα. Το αρχείο χρησιμοποιείται μόνο για να διαβαστού" +
    "ν τα δεδομένα του.";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Το πρόγραμμα μπορεί να καταλάβει αν το αρχείο που διαβάζεται είναι αρχείο που εξή" +
    "χθη από το Pylon.";
            treeNode6.Name = "Node12";
            treeNode6.Text = "Αν ένα αρχείο δεν αναγνωριστεί ως αρχείο Pylon, το πρόγραμμα εμφανίζει σχετικό μή" +
    "νυμα στην κονσόλα μηνυμάτων.";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Πεδίο \"Διαδρομή αρχείου\"";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Ο χρήστης μπορεί να πατήσει στο βελάκι για να ανοίξει το μενού που του επιτρέπει " +
    "να διαλέξει μία ημερομηνία.";
            treeNode9.Name = "Node8";
            treeNode9.Text = "Επιτρέπει επίσης στον χρήστη να πληκτρολογήσει την ημερομηνία που θέλει αν πατήσε" +
    "ι κλικ επάνω στην ημερομηνία.";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Προτού διαβάσει το άρθρο, το πρόγραμμα ελέγχει την ορθότητα της ημερομηνίας για τ" +
    "ον επιλεγμένο τύπο άρθρου και αν είναι λανθασμένη, εμφανίζει σχετικό μήνυμα.";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Πεδίο \"Ημ/νία Άρθρου\"";
            treeNode12.Name = "Node13";
            treeNode12.Text = "Επιτρέπει στον χρήστη να πληκτρολογεί μόνο αριθμούς.";
            treeNode13.Name = "Node14";
            treeNode13.Text = "Επιτρέπει στον χρήστη να πληκτρολογήσει μόνο 2 αριθμούς,\r\n";
            treeNode14.Name = "Node15";
            treeNode14.Text = "εκτός αν πληκτρολογήσει \"00\". Σε αυτή την περίπτωση επιτρέπει στον χρήστη να πληκ" +
    "τρολογήσει έναν ακόμη αριμό, 0 ή 1.";
            treeNode15.Name = "Node16";
            treeNode15.Text = "Αν ο κωδικός καταστήματος είναι ορθός, θα εμφανιστεί δεξιά από το πεδίο το όνομα " +
    "του καταστήματος.";
            treeNode16.Name = "Node17";
            treeNode16.Text = "ΕΝΗΜΕΡΩΣΗ 12/10/22: Επιτρέπει την επιλογή κειμένου στο πεδίο και την εισαγωγή αρι" +
    "θμών χωρίς να χρειαστεί να πατηθεί το πλήκτρο backspace.";
            treeNode17.Name = "Node18";
            treeNode17.Text = "ΕΝΗΜΕΡΩΣΗ 12/10/22: Μετονομασία του πεδίου από \"ΑΧ\" σε \"Κατάστημα\".";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Πεδίο \"Κατάστημα\"";
            treeNode19.Name = "Node19";
            treeNode19.Text = "Επιτρέπει στον χρήστη να διαλέξει τον τύπο του άρθρου που εισάγεται.";
            treeNode20.Name = "Node20";
            treeNode20.Text = "Επιτρέπει στον χρήστη να εισάγει τιμές μόνο από την αναδυόμενη λίστα.";
            treeNode21.Name = "Node21";
            treeNode21.Text = "Κάθε τύπος άρθρου χρειάζεται συγκεκριμένη ημερομηνία άρθρου. ";
            treeNode22.Name = "Node22";
            treeNode22.Text = "Αν η ημερομηνία είναι εσφαλμένη για ένα δεδομένο τύπο άρθρου το πρόγραμμα εμφανίζ" +
    "ει σχετικό μήνυμα στην κονσόλα μηνυμάτων και δεν διαβάζει το άρθρο.";
            treeNode23.Name = "Node3";
            treeNode23.Text = "Πεδίο \"Τύπος Άρθρου\"";
            treeNode24.Name = "fieldsNode";
            treeNode24.Text = "Πεδία";
            treeNode25.Name = "Node25";
            treeNode25.Text = "Ότι άρθρο διαβαστεί εισάγεται σε αυτή την δενδρική δομή.";
            treeNode26.Name = "Node26";
            treeNode26.Text = "Περιέχει τα άρθρα που θα εξαχθούν στο αρχείο που δημιουργεί το πλήκτρο \"Εξαγωγή Ό" +
    "λων\".";
            treeNode27.Name = "Node27";
            treeNode27.Text = "Επιτρέπει στον χρήστη να διαγράψει κάποιο άρθρο, επιλέγοντάς το και πιέζοντας το " +
    "πλήκτρο \"Εκκαθάριση Επιλογής\".";
            treeNode28.Name = "Node28";
            treeNode28.Text = "Επιτρέπει μόνο την διαγραφή άρθρων και όχι την διαγραφή λογαριασμών, ποσών κλπ.";
            treeNode29.Name = "Node29";
            treeNode29.Text = "Επιτρέπει στον χρήστη να διαγράψει όλα τα άρθρα που έχουν διαβαστεί από το πρόγρα" +
    "μμα πιέζοντας το πλήκτρο \"Εκκαθάριση Όλων\".";
            treeNode30.Name = "Node30";
            treeNode30.Text = "Ότι κίνηση και να έχει γίνει από διάβασμα/διαγραφή άρθρων, όταν ο χρήστης πατήσει" +
    " εξαγωγή όλων, το πρόγραμμα εξάγει μόνο τα άρθρα που φαίνονται στην δομή \"Άρθρα " +
    "προς εξαγωγή\".";
            treeNode31.Name = "Node23";
            treeNode31.Text = "Άρθρα προς εξαγωγή";
            treeNode32.Name = "Node31";
            treeNode32.Text = "Γενικότερα, εμφανίζει ότι συμβαίνει στο παρασκήνιο.";
            treeNode33.Name = "Node32";
            treeNode33.Text = "Εμφανίζει προειδοποιητικά μηνύματα ή μηνύματα λάθους, όπου αυτά χρειάζονται.";
            treeNode34.Name = "Node33";
            treeNode34.Text = "Εμφανίζει διάφορες λεπτομέρειες σχετικά με τα άρθρα που διαβάζει, όπως πχ περιγρα" +
    "φή άρθρου, κωδικούς λογαριασμών, ποσά λογαριασμών κλπ.";
            treeNode35.Name = "Node34";
            treeNode35.Text = "Το κείμενο της κονσόλας δεν επηρρεάζει το τι θα εξάγει το πρόγραμμα όταν ο χρήστη" +
    "ς πιέσει το πλήκτρο \"Εξαγωγή Όλων\".";
            treeNode36.Name = "Node24";
            treeNode36.Text = "Κονσόλα μηνυμάτων";
            treeNode37.Name = "articlesAndConsoleNode";
            treeNode37.Text = "Άρθρα και Κονσόλα";
            treeNode38.Name = "Node42";
            treeNode38.Text = "Ελέγχει την ορθότητα των δεδομένων που έχει εισάγει ο χρήστης.";
            treeNode39.Name = "Node43";
            treeNode39.Text = "Αν υπάρχουν σφάλματα, εμφανίζει σχετικό μήνυμα στην κονσόλα ή σε παράθυρο διαλόγο" +
    "υ";
            treeNode40.Name = "Node44";
            treeNode40.Text = "Αν δεν βρει σφάλμα, ανοίγει το αρχείο προς ανάγνωση.";
            treeNode41.Name = "Node45";
            treeNode41.Text = "Η πορεία της ανάγνωσης του αρχείου φαίνεται στην κονσόλα μηνυμάτων.";
            treeNode42.Name = "Node46";
            treeNode42.Text = "Είναι το μόνο πλήκτρο το οποίο όσες φορές και να πατηθεί και ότι και να γίνει αφο" +
    "ύ πατηθεί, η πράξη που κάνει μπορεί να διορθωθεί/αντιστραφεί.";
            treeNode43.Name = "Node47";
            treeNode43.Text = "Είναι το μόνο πλήκτρο που δεν εμφανίζει παράθυρο διαλόγου όταν πατηθεί.";
            treeNode44.Name = "Node48";
            treeNode44.Text = "Τα υπόλοιπα πλήκτρα εμφανίζουν παράθυρα διαλόγου όταν πατηθούν και κάνουν μη αντι" +
    "στέψιμες πράξεις.";
            treeNode45.Name = "Node35";
            treeNode45.Text = "Πλήκτρο \"Εκκίνηση\"";
            treeNode46.Name = "Node49";
            treeNode46.Text = "Αφού πατηθεί εμφανίζει παράθυρο διαλόγου για το αν θέλει ο χρήστης να κάνει εξαγω" +
    "γή των άρθρων που διαβάστηκαν.";
            treeNode47.Name = "Node50";
            treeNode47.Text = "Μόνο αν πατήσει \"Ναι\", ο χρήστης προχωράει στην εξαγωγή των άρθρων.";
            treeNode48.Name = "Node51";
            treeNode48.Text = "Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.";
            treeNode49.Name = "Node52";
            treeNode49.Text = "Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαβάζει όλα τα άρθρα που βρίσκονται στη" +
    "ν δομή \"Άρθρα προς εξαγωγή\".";
            treeNode50.Name = "Node53";
            treeNode50.Text = "Αν έχουν διαβαστεί άρθρα τα οποία στην πορεία διαγράφηκαν από τον χρήστη, δεν θα " +
    "συμπεριληφθουν στην εξαγωγή.";
            treeNode51.Name = "Node58";
            treeNode51.Text = "με όνομα κάτι.txt";
            treeNode52.Name = "Node54";
            treeNode52.Text = "Το πρόγραμμα δημιουργεί ένα αρχείο με όλα τα άρθρα που εξήχθησαν.";
            treeNode53.Name = "Node59";
            treeNode53.Text = "με όνομα κάτι_ASCII.txt";
            treeNode54.Name = "Node55";
            treeNode54.Text = "Μετά, το πρόγραμμα παίρνει το αρχείο που μόλις δημιούργησε και αλλάζει την κωδικο" +
    "ποίησή του ώστε να μπορεί να το διαβάσει το ERP.";
            treeNode55.Name = "Node56";
            treeNode55.Text = "Αφού ολοκληρωθεί αυτή η διαδικασία επιτυχώς, το πρόγραμμα εμφανίζει σχετικό παράθ" +
    "υρο διαλόγου.";
            treeNode56.Name = "Node60";
            treeNode56.Text = "Διαγράφει το αρχείο κάτι.txt και αφήνει το κάτι_ASCII.txt προς καταχώρηση στο ERP" +
    "";
            treeNode57.Name = "Node57";
            treeNode57.Text = "ΕΝΗΜΕΡΩΣΗ 12/10/22: Αφού δημιουργήσει τα 2 αρχεία, το πρόγραμμα διαγράφει το αρχε" +
    "ίο που δεν προορίζεται προς εισαγωγή στο ERP.";
            treeNode58.Name = "Node36";
            treeNode58.Text = "Πλήκτρο \"Εξαγωγή Όλων\"";
            treeNode59.Name = "Node73";
            treeNode59.Text = resources.GetString("treeNode59.Text");
            treeNode60.Name = "Node74";
            treeNode60.Text = "Μόνο αν πατήσει \"Ναι\" ο χρήστης, προχωράει στην διαγραφή όλων αυτών των δεδομένων" +
    ".";
            treeNode61.Name = "Node75";
            treeNode61.Text = "Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.";
            treeNode62.Name = "Node76";
            treeNode62.Text = "Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαγράφει όλα τα δεδομένα που διάβασε κα" +
    "ι τα αρχεία που δημιούργησε για καταχώρηση στο ERP.";
            treeNode63.Name = "Node37";
            treeNode63.Text = "Πλήκτρο \"Εκκαθάριση Όλων\"";
            treeNode64.Name = "Node77";
            treeNode64.Text = "Αφού πατηθεί εμφανίζει παράθυρο διαλόγου για το αν θέλει ο χρήστης να κάνει διαγρ" +
    "αφή του επιλεγμένου άρθρου από την δομή \"Άρθρα προς εξαγωγή\".";
            treeNode65.Name = "Node78";
            treeNode65.Text = "Το πρόγραμμα δεν επιτρέπει διαγραφή άλλων δεδομένων από την δομή, παρά μόνο άρθρα" +
    ".";
            treeNode66.Name = "Node79";
            treeNode66.Text = "Μόνο αν πατήσει \"Ναι\" ο χρήστης, προχωράει στην διαγραφή του άρθρου.";
            treeNode67.Name = "Node80";
            treeNode67.Text = "Οποιοδήποτε άλλο πλήκτρο στο παράθυρο διαλόγου ακυρώνει την πράξη.";
            treeNode68.Name = "Node81";
            treeNode68.Text = "Αν ο χρήστης πατήσει \"Ναι\", το πρόγραμμα διαγράφει το άρθρο απ\' την δομή και όταν" +
    " ο χρήστης πιέσει το πλήκτρο \"Εξαγωγή Όλων\" το διαγραμμένο άρθρο δεν θα συμπεριλ" +
    "ηφθεί στην εξαγωγή. ";
            treeNode69.Name = "Node38";
            treeNode69.Text = "Πλήκτρο \"Εκκαθάριση Επιλογής\"";
            treeNode70.Name = "Node40";
            treeNode70.Text = "Εμφανίζει αυτό το παράθυρο.";
            treeNode71.Name = "Node82";
            treeNode71.Text = "Εξηγεί αναλυτικά την λειτουργεία του προγράμματος.";
            treeNode72.Name = "Node41";
            treeNode72.Text = "Περιέχει τις διάφορες αλλαγές που γίνονται στο πρόγραμμα που επηρρεάζουν την εμπε" +
    "ιρία χρήστη.";
            treeNode73.Name = "Node39";
            treeNode73.Text = "Πλήκτρο \"Βοήθεια\"";
            treeNode74.Name = "buttonsNode";
            treeNode74.Text = "Πλήκτρα";
            treeNode75.Name = "Node62";
            treeNode75.Text = "Για καταχώρηση: ";
            treeNode76.Name = "Node66";
            treeNode76.Text = "Τύπος εγγραφών: Γενική (προεπιλεγμένο)";
            treeNode77.Name = "Node67";
            treeNode77.Text = "Κωδικός Λογ/σμού: 13";
            treeNode78.Name = "Node68";
            treeNode78.Text = "Αιτιολογία: 55";
            treeNode79.Name = "Node69";
            treeNode79.Text = "Περιοχή: επιλογή του αρχείου κάτι_ASCII.txt";
            treeNode80.Name = "Node70";
            treeNode80.Text = "Προσοχή! Στο παράθυρο επιλογής αρχείου πρέπει να οριστεί ως τύπος αρχείου ο .txt " +
    "(προεπιλογή είναι ο .pni), αλλιώς δεν θα φαίνεται το αρχείο που δημιούργησε το π" +
    "ρόγραμμα.";
            treeNode81.Name = "Node71";
            treeNode81.Text = "Αν η καταχώρηση είναι επιτυχής το ERP δεν εμφανίζει κάποιο μήνυμα.";
            treeNode82.Name = "Node72";
            treeNode82.Text = "Αν η καταχώρηση είναι επιτυχής, το αρχείο καταχώρησης διαγράφεται.";
            treeNode83.Name = "Node65";
            treeNode83.Text = "Εισαγωγή δεδομένων από αρχείο ASCII";
            treeNode84.Name = "Node64";
            treeNode84.Text = "Βοηθητικές εργασίες";
            treeNode85.Name = "Node63";
            treeNode85.Text = "Περιοδικές εργασίες";
            treeNode86.Name = "Node61";
            treeNode86.Text = "Καταχώρηση αρχείου στο ERP";
            treeNode87.Name = "Node84";
            treeNode87.Text = resources.GetString("treeNode87.Text");
            treeNode88.Name = "Node83";
            treeNode88.Text = "Λοιπές σημειώσεις";
            this.helpTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode37,
            treeNode74,
            treeNode86,
            treeNode88});
            this.helpTreeView.Size = new System.Drawing.Size(560, 700);
            this.helpTreeView.TabIndex = 0;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pylon2ERP - Βοήθεια";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TreeView helpTreeView;
    }
}