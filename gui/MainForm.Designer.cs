using System.Windows.Forms;

namespace Pylon2ERP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.consoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.thePanel = new System.Windows.Forms.Panel();
            this.articlesAndConsoleSplitContainer = new System.Windows.Forms.SplitContainer();
            this.articlesToExtractLabel = new System.Windows.Forms.Label();
            this.articleTreeView = new System.Windows.Forms.TreeView();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.consoleMessagesLabel = new System.Windows.Forms.Label();
            this.extractAllButton = new System.Windows.Forms.Button();
            this.consolePanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.footerStatusStrip = new System.Windows.Forms.StatusStrip();
            this.afroditiToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.parametersGroupBox = new System.Windows.Forms.GroupBox();
            this.axNameLabel = new System.Windows.Forms.Label();
            this.axTextBox = new System.Windows.Forms.TextBox();
            this.axLabel = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.articleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.articleTypeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.articleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.thePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesAndConsoleSplitContainer)).BeginInit();
            this.articlesAndConsoleSplitContainer.Panel1.SuspendLayout();
            this.articlesAndConsoleSplitContainer.Panel2.SuspendLayout();
            this.articlesAndConsoleSplitContainer.SuspendLayout();
            this.consolePanel.SuspendLayout();
            this.footerStatusStrip.SuspendLayout();
            this.parametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleRichTextBox
            // 
            this.consoleRichTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.consoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleRichTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consoleRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleRichTextBox.Name = "consoleRichTextBox";
            this.consoleRichTextBox.ReadOnly = true;
            this.consoleRichTextBox.Size = new System.Drawing.Size(481, 287);
            this.consoleRichTextBox.TabIndex = 9;
            this.consoleRichTextBox.Text = "";
            this.consoleRichTextBox.WordWrap = false;
            this.consoleRichTextBox.TextChanged += new System.EventHandler(this.consoleRichTextBox_TextChanged);
            // 
            // thePanel
            // 
            this.thePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thePanel.Controls.Add(this.articlesAndConsoleSplitContainer);
            this.thePanel.Controls.Add(this.footerStatusStrip);
            this.thePanel.Controls.Add(this.parametersGroupBox);
            this.thePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thePanel.Location = new System.Drawing.Point(0, 0);
            this.thePanel.Name = "thePanel";
            this.thePanel.Size = new System.Drawing.Size(834, 511);
            this.thePanel.TabIndex = 0;
            // 
            // articlesAndConsoleSplitContainer
            // 
            this.articlesAndConsoleSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articlesAndConsoleSplitContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.articlesAndConsoleSplitContainer.Location = new System.Drawing.Point(3, 104);
            this.articlesAndConsoleSplitContainer.Name = "articlesAndConsoleSplitContainer";
            // 
            // articlesAndConsoleSplitContainer.Panel1
            // 
            this.articlesAndConsoleSplitContainer.Panel1.Controls.Add(this.articlesToExtractLabel);
            this.articlesAndConsoleSplitContainer.Panel1.Controls.Add(this.articleTreeView);
            this.articlesAndConsoleSplitContainer.Panel1.Controls.Add(this.clearAllButton);
            this.articlesAndConsoleSplitContainer.Panel1.Controls.Add(this.clearSelectionButton);
            this.articlesAndConsoleSplitContainer.Panel1MinSize = 275;
            // 
            // articlesAndConsoleSplitContainer.Panel2
            // 
            this.articlesAndConsoleSplitContainer.Panel2.Controls.Add(this.consoleMessagesLabel);
            this.articlesAndConsoleSplitContainer.Panel2.Controls.Add(this.extractAllButton);
            this.articlesAndConsoleSplitContainer.Panel2.Controls.Add(this.consolePanel);
            this.articlesAndConsoleSplitContainer.Panel2.Controls.Add(this.startButton);
            this.articlesAndConsoleSplitContainer.Panel2MinSize = 400;
            this.articlesAndConsoleSplitContainer.Size = new System.Drawing.Size(827, 375);
            this.articlesAndConsoleSplitContainer.SplitterDistance = 324;
            this.articlesAndConsoleSplitContainer.SplitterWidth = 10;
            this.articlesAndConsoleSplitContainer.TabIndex = 6;
            this.articlesAndConsoleSplitContainer.TabStop = false;
            // 
            // articlesToExtractLabel
            // 
            this.articlesToExtractLabel.AutoSize = true;
            this.articlesToExtractLabel.Location = new System.Drawing.Point(6, 9);
            this.articlesToExtractLabel.Name = "articlesToExtractLabel";
            this.articlesToExtractLabel.Size = new System.Drawing.Size(127, 15);
            this.articlesToExtractLabel.TabIndex = 14;
            this.articlesToExtractLabel.Text = "Άρθρα προς εξαγωγή:";
            // 
            // articleTreeView
            // 
            this.articleTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.articleTreeView.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.articleTreeView.Location = new System.Drawing.Point(6, 30);
            this.articleTreeView.Name = "articleTreeView";
            this.articleTreeView.Size = new System.Drawing.Size(318, 289);
            this.articleTreeView.TabIndex = 8;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearAllButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clearAllButton.FlatAppearance.BorderSize = 2;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAllButton.Location = new System.Drawing.Point(151, 331);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(114, 26);
            this.clearAllButton.TabIndex = 11;
            this.clearAllButton.Text = "Εκκαθάριση όλων";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearSelectionButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearSelectionButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.clearSelectionButton.FlatAppearance.BorderSize = 2;
            this.clearSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSelectionButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearSelectionButton.Location = new System.Drawing.Point(6, 331);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(130, 26);
            this.clearSelectionButton.TabIndex = 10;
            this.clearSelectionButton.Text = "Εκκαθάριση επιλογής";
            this.clearSelectionButton.UseVisualStyleBackColor = false;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // consoleMessagesLabel
            // 
            this.consoleMessagesLabel.AutoSize = true;
            this.consoleMessagesLabel.Location = new System.Drawing.Point(3, 9);
            this.consoleMessagesLabel.Name = "consoleMessagesLabel";
            this.consoleMessagesLabel.Size = new System.Drawing.Size(124, 15);
            this.consoleMessagesLabel.TabIndex = 15;
            this.consoleMessagesLabel.Text = "Κονσόλα μηνυμάτων:";
            // 
            // extractAllButton
            // 
            this.extractAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.extractAllButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.extractAllButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.extractAllButton.FlatAppearance.BorderSize = 2;
            this.extractAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extractAllButton.Location = new System.Drawing.Point(302, 331);
            this.extractAllButton.Name = "extractAllButton";
            this.extractAllButton.Size = new System.Drawing.Size(97, 26);
            this.extractAllButton.TabIndex = 12;
            this.extractAllButton.Text = "Εξαγωγή όλων";
            this.extractAllButton.UseVisualStyleBackColor = false;
            this.extractAllButton.Click += new System.EventHandler(this.extractAllButton_Click);
            // 
            // consolePanel
            // 
            this.consolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consolePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consolePanel.Controls.Add(this.consoleRichTextBox);
            this.consolePanel.Location = new System.Drawing.Point(0, 30);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Size = new System.Drawing.Size(483, 289);
            this.consolePanel.TabIndex = 16;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(414, 331);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(69, 26);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Εκκίνηση";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // footerStatusStrip
            // 
            this.footerStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afroditiToolStripStatusLabel,
            this.helpToolStripStatusLabel});
            this.footerStatusStrip.Location = new System.Drawing.Point(0, 482);
            this.footerStatusStrip.Name = "footerStatusStrip";
            this.footerStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.footerStatusStrip.ShowItemToolTips = true;
            this.footerStatusStrip.Size = new System.Drawing.Size(834, 29);
            this.footerStatusStrip.TabIndex = 1;
            this.footerStatusStrip.Text = "statusStrip1";
            // 
            // afroditiToolStripStatusLabel
            // 
            this.afroditiToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.afroditiToolStripStatusLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afroditiToolStripStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("afroditiToolStripStatusLabel.Image")));
            this.afroditiToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.afroditiToolStripStatusLabel.Name = "afroditiToolStripStatusLabel";
            this.afroditiToolStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.afroditiToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(2);
            this.afroditiToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.afroditiToolStripStatusLabel.Size = new System.Drawing.Size(119, 25);
            this.afroditiToolStripStatusLabel.Text = "Αφροδίτη ΑΕΕ";
            // 
            // helpToolStripStatusLabel
            // 
            this.helpToolStripStatusLabel.AutoToolTip = true;
            this.helpToolStripStatusLabel.BackColor = System.Drawing.Color.Silver;
            this.helpToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.helpToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.helpToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripStatusLabel.Margin = new System.Windows.Forms.Padding(29, 3, 0, 2);
            this.helpToolStripStatusLabel.Name = "helpToolStripStatusLabel";
            this.helpToolStripStatusLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.helpToolStripStatusLabel.Size = new System.Drawing.Size(64, 24);
            this.helpToolStripStatusLabel.Text = "Βοήθεια";
            this.helpToolStripStatusLabel.ToolTipText = "Για βοήθεια πατήστε εδώ.";
            this.helpToolStripStatusLabel.Click += new System.EventHandler(this.helpToolStripStatusLabel_Click);
            this.helpToolStripStatusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helpToolStripStatusLabel_MouseDown);
            this.helpToolStripStatusLabel.MouseLeave += new System.EventHandler(this.helpToolStripStatusLabel_MouseLeave);
            this.helpToolStripStatusLabel.MouseHover += new System.EventHandler(this.helpToolStripStatusLabel_MouseHover);
            this.helpToolStripStatusLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.helpToolStripStatusLabel_MouseUp);
            // 
            // parametersGroupBox
            // 
            this.parametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parametersGroupBox.Controls.Add(this.axNameLabel);
            this.parametersGroupBox.Controls.Add(this.axTextBox);
            this.parametersGroupBox.Controls.Add(this.axLabel);
            this.parametersGroupBox.Controls.Add(this.filePathLabel);
            this.parametersGroupBox.Controls.Add(this.articleDatePicker);
            this.parametersGroupBox.Controls.Add(this.articleTypeLabel);
            this.parametersGroupBox.Controls.Add(this.dateLabel);
            this.parametersGroupBox.Controls.Add(this.articleTypeComboBox);
            this.parametersGroupBox.Controls.Add(this.filePathTextBox);
            this.parametersGroupBox.Controls.Add(this.openFileDialogButton);
            this.parametersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.parametersGroupBox.Name = "parametersGroupBox";
            this.parametersGroupBox.Size = new System.Drawing.Size(827, 95);
            this.parametersGroupBox.TabIndex = 0;
            this.parametersGroupBox.TabStop = false;
            this.parametersGroupBox.Text = "Παράμετροι Άρθρου";
            // 
            // axNameLabel
            // 
            this.axNameLabel.AutoSize = true;
            this.axNameLabel.Location = new System.Drawing.Point(366, 65);
            this.axNameLabel.Name = "axNameLabel";
            this.axNameLabel.Size = new System.Drawing.Size(0, 15);
            this.axNameLabel.TabIndex = 8;
            // 
            // axTextBox
            // 
            this.axTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axTextBox.Location = new System.Drawing.Point(327, 62);
            this.axTextBox.Name = "axTextBox";
            this.axTextBox.Size = new System.Drawing.Size(33, 23);
            this.axTextBox.TabIndex = 6;
            this.axTextBox.TextChanged += new System.EventHandler(this.axTextBox_TextChanged);
            this.axTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.axTextBox_KeyPress);
            // 
            // axLabel
            // 
            this.axLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axLabel.AutoSize = true;
            this.axLabel.Location = new System.Drawing.Point(250, 65);
            this.axLabel.Name = "axLabel";
            this.axLabel.Size = new System.Drawing.Size(71, 15);
            this.axLabel.TabIndex = 5;
            this.axLabel.Text = "Κατάστημα:";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(6, 25);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(108, 15);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "Διαδρομή αρχείου:";
            // 
            // articleDatePicker
            // 
            this.articleDatePicker.CustomFormat = "dd/MM/yy";
            this.articleDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.articleDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.articleDatePicker.Location = new System.Drawing.Point(105, 62);
            this.articleDatePicker.Name = "articleDatePicker";
            this.articleDatePicker.Size = new System.Drawing.Size(116, 23);
            this.articleDatePicker.TabIndex = 4;
            // 
            // articleTypeLabel
            // 
            this.articleTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTypeLabel.AutoSize = true;
            this.articleTypeLabel.Location = new System.Drawing.Point(500, 65);
            this.articleTypeLabel.Name = "articleTypeLabel";
            this.articleTypeLabel.Size = new System.Drawing.Size(90, 15);
            this.articleTypeLabel.TabIndex = 0;
            this.articleTypeLabel.Text = "Τύπος Άρθρου:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(93, 15);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Ημ/νία Άρθρου:";
            // 
            // articleTypeComboBox
            // 
            this.articleTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTypeComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.articleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleTypeComboBox.FormattingEnabled = true;
            this.articleTypeComboBox.Items.AddRange(new object[] {
            "ΜΙΣΘΟΔΟΣΙΑ",
            "ΕΠΙΔ. ΑΔΕΙΑΣ",
            "ΑΠΟΖ. ΑΔΕΙΑΣ",
            "ΔΩΡΟ ΠΑΣΧΑ",
            "ΔΩΡΟ ΧΡΙΣΤΟΥΓΕΝΝΩΝ",
            "ΑΠΟΖ. ΑΠΟΛΥΣΗΣ",
            "ΑΠΟΖ. ΣΥΝΤΑΞΙΟΔΟΤΗΣΗΣ"});
            this.articleTypeComboBox.Location = new System.Drawing.Point(596, 62);
            this.articleTypeComboBox.Name = "articleTypeComboBox";
            this.articleTypeComboBox.Size = new System.Drawing.Size(227, 23);
            this.articleTypeComboBox.TabIndex = 7;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.filePathTextBox.Location = new System.Drawing.Point(120, 22);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(651, 23);
            this.filePathTextBox.TabIndex = 1;
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileDialogButton.Location = new System.Drawing.Point(777, 22);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(46, 22);
            this.openFileDialogButton.TabIndex = 2;
            this.openFileDialogButton.Text = ". . .";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.thePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pylon2ERP";
            this.thePanel.ResumeLayout(false);
            this.thePanel.PerformLayout();
            this.articlesAndConsoleSplitContainer.Panel1.ResumeLayout(false);
            this.articlesAndConsoleSplitContainer.Panel1.PerformLayout();
            this.articlesAndConsoleSplitContainer.Panel2.ResumeLayout(false);
            this.articlesAndConsoleSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesAndConsoleSplitContainer)).EndInit();
            this.articlesAndConsoleSplitContainer.ResumeLayout(false);
            this.consolePanel.ResumeLayout(false);
            this.footerStatusStrip.ResumeLayout(false);
            this.footerStatusStrip.PerformLayout();
            this.parametersGroupBox.ResumeLayout(false);
            this.parametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel thePanel;
        private GroupBox parametersGroupBox;
        private ComboBox articleTypeComboBox;
        private TextBox filePathTextBox;
        private Button openFileDialogButton;
        private DateTimePicker articleDatePicker;
        private Label articleTypeLabel;
        private Label dateLabel;
        private StatusStrip footerStatusStrip;
        private ToolStripStatusLabel afroditiToolStripStatusLabel;
        private Label filePathLabel;
        private TextBox axTextBox;
        private Label axLabel;
        private Button startButton;
        private Label axNameLabel;
        private Button clearAllButton;
        private RichTextBox consoleRichTextBox;
        private TreeView articleTreeView;
        private Button clearSelectionButton;
        private Button extractAllButton;
        private Label consoleMessagesLabel;
        private Label articlesToExtractLabel;
        private ToolStripStatusLabel helpToolStripStatusLabel;
        private SplitContainer articlesAndConsoleSplitContainer;
        private Panel consolePanel;
    }
}