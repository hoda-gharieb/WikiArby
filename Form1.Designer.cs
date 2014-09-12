namespace Bing_Translator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.URLbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gobut = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.arabicWEB = new System.Windows.Forms.WebBrowser();
            this.webArabic = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Savebutton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.Level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.level5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.bulletedList = new System.Windows.Forms.ToolStripMenuItem();
            this.numberedList = new System.Windows.Forms.ToolStripMenuItem();
            this.indentation = new System.Windows.Forms.ToolStripMenuItem();
            this.noWikiFormating = new System.Windows.Forms.ToolStripMenuItem();
            this.newLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.bigText = new System.Windows.Forms.ToolStripMenuItem();
            this.smallText = new System.Windows.Forms.ToolStripMenuItem();
            this.superscript = new System.Windows.Forms.ToolStripMenuItem();
            this.subscript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.picture = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arMarkup = new System.Windows.Forms.RichTextBox();
            this.editpage = new System.Windows.Forms.WebBrowser();
            this.arhtml = new System.Windows.Forms.TabPage();
            this.EDIT = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditArabicBrowser = new System.Windows.Forms.WebBrowser();
            this.ENGBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.arhtml.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(125, 28);
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(1027, 20);
            this.URLbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The Page URL";
            // 
            // gobut
            // 
            this.gobut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobut.Location = new System.Drawing.Point(1176, 23);
            this.gobut.Name = "gobut";
            this.gobut.Size = new System.Drawing.Size(70, 28);
            this.gobut.TabIndex = 2;
            this.gobut.Text = "Go";
            this.gobut.UseVisualStyleBackColor = true;
            this.gobut.Click += new System.EventHandler(this.gobut_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.arabicWEB);
            this.tabPage3.Controls.Add(this.webArabic);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(699, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arabic Page";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // arabicWEB
            // 
            this.arabicWEB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arabicWEB.Location = new System.Drawing.Point(0, 0);
            this.arabicWEB.MinimumSize = new System.Drawing.Size(20, 20);
            this.arabicWEB.Name = "arabicWEB";
            this.arabicWEB.Size = new System.Drawing.Size(699, 488);
            this.arabicWEB.TabIndex = 1;
            this.arabicWEB.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.arabicWEB_DocumentCompleted);
            // 
            // webArabic
            // 
            this.webArabic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webArabic.Location = new System.Drawing.Point(0, 0);
            this.webArabic.MinimumSize = new System.Drawing.Size(20, 20);
            this.webArabic.Name = "webArabic";
            this.webArabic.Size = new System.Drawing.Size(699, 488);
            this.webArabic.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.arhtml);
            this.tabControl1.Location = new System.Drawing.Point(543, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 514);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Savebutton);
            this.tabPage4.Controls.Add(this.toolStrip1);
            this.tabPage4.Controls.Add(this.arMarkup);
            this.tabPage4.Controls.Add(this.editpage);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(699, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Wiki Markup";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(279, 446);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(137, 31);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Italic,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "B";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Italic.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 22);
            this.Italic.Text = "I";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Level2,
            this.Level3,
            this.level4,
            this.level5});
            this.toolStripSplitButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(75, 22);
            this.toolStripSplitButton2.Text = "Heading";
            // 
            // Level2
            // 
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(117, 22);
            this.Level2.Text = "Level 2";
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // Level3
            // 
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(117, 22);
            this.Level3.Text = "Level 3";
            this.Level3.Click += new System.EventHandler(this.Level3_Click);
            // 
            // level4
            // 
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(117, 22);
            this.level4.Text = "Level 4";
            this.level4.Click += new System.EventHandler(this.level4_Click);
            // 
            // level5
            // 
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(117, 22);
            this.level5.Text = "Level 5";
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulletedList,
            this.numberedList,
            this.indentation,
            this.noWikiFormating,
            this.newLine});
            this.toolStripSplitButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(68, 22);
            this.toolStripSplitButton3.Text = "Format";
            // 
            // bulletedList
            // 
            this.bulletedList.Name = "bulletedList";
            this.bulletedList.Size = new System.Drawing.Size(185, 22);
            this.bulletedList.Text = "Bulleted list";
            this.bulletedList.Click += new System.EventHandler(this.bulletedList_Click);
            // 
            // numberedList
            // 
            this.numberedList.Name = "numberedList";
            this.numberedList.Size = new System.Drawing.Size(185, 22);
            this.numberedList.Text = "Numbered list";
            this.numberedList.Click += new System.EventHandler(this.numberedList_Click);
            // 
            // indentation
            // 
            this.indentation.Name = "indentation";
            this.indentation.Size = new System.Drawing.Size(185, 22);
            this.indentation.Text = "Indentation";
            this.indentation.Click += new System.EventHandler(this.indentation_Click);
            // 
            // noWikiFormating
            // 
            this.noWikiFormating.Name = "noWikiFormating";
            this.noWikiFormating.Size = new System.Drawing.Size(185, 22);
            this.noWikiFormating.Text = "No wiki formating";
            this.noWikiFormating.Click += new System.EventHandler(this.noWikiFormating_Click);
            // 
            // newLine
            // 
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(185, 22);
            this.newLine.Text = "New Line";
            this.newLine.Click += new System.EventHandler(this.newLine_Click);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bigText,
            this.smallText,
            this.superscript,
            this.subscript});
            this.toolStripSplitButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(50, 22);
            this.toolStripSplitButton4.Text = "Text";
            // 
            // bigText
            // 
            this.bigText.Name = "bigText";
            this.bigText.Size = new System.Drawing.Size(144, 22);
            this.bigText.Text = "Big text";
            this.bigText.Click += new System.EventHandler(this.bigText_Click);
            // 
            // smallText
            // 
            this.smallText.Name = "smallText";
            this.smallText.Size = new System.Drawing.Size(144, 22);
            this.smallText.Text = "Small text";
            this.smallText.Click += new System.EventHandler(this.smallText_Click);
            // 
            // superscript
            // 
            this.superscript.Name = "superscript";
            this.superscript.Size = new System.Drawing.Size(144, 22);
            this.superscript.Text = "Superscript";
            this.superscript.Click += new System.EventHandler(this.superscript_Click);
            // 
            // subscript
            // 
            this.subscript.Name = "subscript";
            this.subscript.Size = new System.Drawing.Size(144, 22);
            this.subscript.Text = "Subscript";
            this.subscript.Click += new System.EventHandler(this.subscript_Click);
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picture,
            this.tableToolStripMenuItem,
            this.linkToolStripMenuItem});
            this.toolStripSplitButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(59, 22);
            this.toolStripSplitButton5.Text = "Insert";
            // 
            // picture
            // 
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(118, 22);
            this.picture.Text = "Picture";
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click_1);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // arMarkup
            // 
            this.arMarkup.Location = new System.Drawing.Point(3, 28);
            this.arMarkup.Name = "arMarkup";
            this.arMarkup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arMarkup.Size = new System.Drawing.Size(693, 412);
            this.arMarkup.TabIndex = 1;
            this.arMarkup.Text = "";
            // 
            // editpage
            // 
            this.editpage.Location = new System.Drawing.Point(244, 93);
            this.editpage.MinimumSize = new System.Drawing.Size(20, 20);
            this.editpage.Name = "editpage";
            this.editpage.Size = new System.Drawing.Size(20, 20);
            this.editpage.TabIndex = 0;
            // 
            // arhtml
            // 
            this.arhtml.Controls.Add(this.EDIT);
            this.arhtml.Controls.Add(this.EditButton);
            this.arhtml.Controls.Add(this.EditArabicBrowser);
            this.arhtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arhtml.Location = new System.Drawing.Point(4, 22);
            this.arhtml.Name = "arhtml";
            this.arhtml.Padding = new System.Windows.Forms.Padding(3);
            this.arhtml.Size = new System.Drawing.Size(699, 488);
            this.arhtml.TabIndex = 4;
            this.arhtml.Text = "Editable WebPage";
            this.arhtml.UseVisualStyleBackColor = true;
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(271, 445);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(185, 37);
            this.EDIT.TabIndex = 2;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1144, 335);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // EditArabicBrowser
            // 
            this.EditArabicBrowser.AllowWebBrowserDrop = false;
            this.EditArabicBrowser.IsWebBrowserContextMenuEnabled = false;
            this.EditArabicBrowser.Location = new System.Drawing.Point(4, 3);
            this.EditArabicBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.EditArabicBrowser.Name = "EditArabicBrowser";
            this.EditArabicBrowser.Size = new System.Drawing.Size(694, 436);
            this.EditArabicBrowser.TabIndex = 0;
            this.EditArabicBrowser.TabStop = false;
            // 
            // ENGBrowser1
            // 
            this.ENGBrowser1.Location = new System.Drawing.Point(14, 65);
            this.ENGBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.ENGBrowser1.Name = "ENGBrowser1";
            this.ENGBrowser1.Size = new System.Drawing.Size(523, 507);
            this.ENGBrowser1.TabIndex = 4;
            this.ENGBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ENGBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 588);
            this.Controls.Add(this.ENGBrowser1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gobut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLbox);
            this.Name = "Form1";
            this.Text = "WikiTranslator";
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.arhtml.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gobut;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webArabic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.WebBrowser arabicWEB;
        private System.Windows.Forms.TabPage arhtml;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem Level2;
        private System.Windows.Forms.ToolStripMenuItem Level3;
        private System.Windows.Forms.ToolStripMenuItem level4;
        private System.Windows.Forms.ToolStripMenuItem level5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem bulletedList;
        private System.Windows.Forms.ToolStripMenuItem numberedList;
        private System.Windows.Forms.ToolStripMenuItem indentation;
        private System.Windows.Forms.ToolStripMenuItem noWikiFormating;
        private System.Windows.Forms.ToolStripMenuItem newLine;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem bigText;
        private System.Windows.Forms.ToolStripMenuItem smallText;
        private System.Windows.Forms.ToolStripMenuItem superscript;
        private System.Windows.Forms.ToolStripMenuItem subscript;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripMenuItem picture;
        private System.Windows.Forms.RichTextBox arMarkup;
        private System.Windows.Forms.WebBrowser editpage;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.WebBrowser EditArabicBrowser;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.WebBrowser ENGBrowser1;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button Savebutton;


    }
}

