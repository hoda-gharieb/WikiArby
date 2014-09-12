using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using mshtml;
namespace Bing_Translator
{
    public partial class Form1 : Form
    {
        public string ArabicWebPageHTML;

        public Form1()
        {
            InitializeComponent();
        }
       

        public static string SourceOUT(string SOURCE)
        {
            string OUT = SOURCE.Replace("src=\"", "src=\"http:");
            OUT = OUT.Replace("href=\"", "href=\"http://en.wikipedia.org");
            return OUT;
        }


        public static string translate_Wiki_Markup(string source)
        {
            
            string AR = "";
        
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                int Max = source.Length / 8;
                if (Max > 8000)
                    Max = 8000;
                int i;
                for (i = 0; i < source.Length; i += Max)
                {
                    AR += client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", source.Substring(i, Max), "en", "ar");
                }
                if (i - Max < source.Length - 1)
                {
                    AR += client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", source.Substring(i - Max, source.Length - i - 1 + Max), "en", "ar");
                }
            }
            catch (Exception ex)
            {
                // AR = AR.Replace("الطبقة = \"wikitable قابل للفرز\"", "class=\"wikitable sortable\"");
                return AR;
                MessageBox.Show(ex.Message);
            }

            return AR;
           
        }
        

        private void gobut_Click(object sender, EventArgs e)
        {
            string URL = URLbox.Text;
            MessageBox.Show(URL);
            ENGBrowser1.Navigate(URL);
        }
        
        private bool TEXTLENGTH()
        {
            return arMarkup.SelectionLength == 0;
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "'''Bold text'''";
            else
                arMarkup.SelectedText = "'''" + arMarkup.SelectedText.ToString() + "'''";
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "''Italic text''";
            else
                arMarkup.SelectedText = "''" + arMarkup.SelectedText.ToString() + "''";
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "== Heading text ==";
            else
                arMarkup.SelectedText = "== " + arMarkup.SelectedText.ToString() + " ==";
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "=== Heading text ===";
            else
                arMarkup.SelectedText = "=== " + arMarkup.SelectedText.ToString() + " ===";
        }

        private void level4_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "==== Heading text ====";
            else
                arMarkup.SelectedText = "==== " + arMarkup.SelectedText.ToString() + " ====";
        }

        private void level5_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "===== eading text =====";
            else
                arMarkup.SelectedText = "===== " + arMarkup.SelectedText.ToString() + " =====";
        }

        private void bulletedList_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "* Bulleted list item";
            else
            {
                arMarkup.SelectedText = "* " + arMarkup.SelectedText.ToString();
                arMarkup.SelectedText = arMarkup.SelectedText.Replace("\n", "\n* ");
            }
        }

        private void numberedList_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "# Numbered list item";
            else
            {
                arMarkup.SelectedText = "# " + arMarkup.SelectedText.ToString();
                arMarkup.SelectedText = arMarkup.SelectedText.Replace("\n", "\n# ");
            }
        }

        private void indentation_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = ": Indented line";
            else
            {
                arMarkup.SelectedText = ": " + arMarkup.SelectedText.ToString();
                arMarkup.SelectedText = arMarkup.SelectedText.Replace("\n", "\n: ");
            }
        }

        private void noWikiFormating_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "<nowiki>Insert non-formatted text here</nowiki>";
            else
                arMarkup.SelectedText = "<nowiki>" + arMarkup.SelectedText.ToString() + "</nowiki>";
        }

        private void newLine_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "\n<br />\n";
            else
                arMarkup.SelectedText = "\n<br />\n" + arMarkup.SelectedText.ToString();
        }

        private void bigText_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "<big>Big text</big>";
            else
                arMarkup.SelectedText = "<big>" + arMarkup.SelectedText.ToString() + "</big>";
        }

        private void smallText_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "<small>Small text</small>";
            else
                arMarkup.SelectedText = "<small>" + arMarkup.SelectedText.ToString() + "</small>";
        }

        private void superscript_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "<sup>Superscript text</sup>";
            else
                arMarkup.SelectedText = "<sup>" + arMarkup.SelectedText.ToString() + "</sup>";
        }

        private void subscript_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                arMarkup.SelectedText = "<sup>Superscript text</sup>";
            else
                arMarkup.SelectedText = "<sup>" + arMarkup.SelectedText.ToString() + "</sup>";
        }

        private void picture_Click(object sender, EventArgs e)
        {
            arMarkup.SelectionStart += arMarkup.SelectionLength;
            arMarkup.SelectionLength = 0;
            arMarkup.SelectedText = "<gallery>\nFile:Example.jpg|Caption1\nFile:Example.jpg|Caption2\n</gallery>\n";
        }

      
        public void Make()
        {
            string TranlsatedMarkup = System.IO.File.ReadAllText(Path.GetFullPath("TranslatedMarkup.html"));
            // MessageBox.Show(TranlsatedMarkup);
            //TranlsatedMarkup = Editing_Markup(TranlsatedMarkup);
            string HTML_arabic = WikiToHTML(TranlsatedMarkup);
            HTML_arabic = Forming_Translated_Page(HTML_arabic);
            HTML_arabic = rightToLeft(HTML_arabic);
            HTML_arabic = changeLanguage(HTML_arabic, "en", "ar");

            //MessageBox.Show(HTML_arabic);
            ArabicWebPageHTML = HTML_arabic;

            arabicWEB.DocumentText = HTML_arabic;
            arabicWEB.Document.Encoding = "UTF-8";

            EditArabicBrowser.DocumentText = HTML_arabic;
            EditArabicBrowser.Document.Encoding = "UTF-8";
        }

        private void ENGBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string SourceEngPage = SourceOUT(ENGBrowser1.DocumentText);
            Form4.token_making(SourceEngPage);
            string Source = Form4.Write_To_Markup(false);
            string TranlsatedMarkup = Editing_Markup(translate_Wiki_Markup(Source));
            //string TranlsatedMarkup = translate_Wiki_Markup(Source);
            // string TranlsatedMarkup = Source;
            //MessageBox.Show(TranlsatedMarkup);
            arMarkup.Text = TranlsatedMarkup;
            TextWriter WriteTranslatedMarkup = new StreamWriter("TranslatedMarkup.html");
            WriteTranslatedMarkup.WriteLine(TranlsatedMarkup);
            WriteTranslatedMarkup.Close();
            Make();

        }

        private void arabicWEB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (arabicWEB.DocumentText != ArabicWebPageHTML)
            {
                //MessageBox.Show("krim");
                ENGBrowser1.Navigate(arabicWEB.Url);
                return;
            }
            
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            TextWriter WriteTranslatedMarkup = new StreamWriter("TranslatedMarkup.html");
            WriteTranslatedMarkup.WriteLine(arMarkup.Text);
            WriteTranslatedMarkup.Close();
            Make();
        }


        private void tableToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string Table = "{|";
                    if (form2.C2 && form2.C3)
                        Table += " class=\"wikitable sortable\"";
                    else if (form2.C2)
                        Table += " class=\"wikitable\"";
                    else if (form2.C3)
                        Table += " class=\"sortable\"";
                    if (form2.C1)
                    {
                        Table += "\n|-\n";
                        for (int i = 0; i < form2.ROW; i++)
                        {
                            if (i == 0)
                                Table += "!";
                            else
                                Table += "!!";
                            Table += " Header text ";
                        }
                    }
                    for (int i = 0; i < form2.COL; i++)
                    {
                        Table += "\n|-\n";
                        for (int I = 0; I < form2.ROW; I++)
                        {
                            if (I == 0)
                                Table += "|";
                            else
                                Table += "||";
                            Table += " Example ";
                        }
                    }
                    Table += "\n|}";
                    arMarkup.SelectedText = Table;
                }
            }
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                if (form3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (form3.R1)
                    {
                        arMarkup.SelectedText = "[[" + form3.URL + "|" + form3.TEXT + "]]";
                    }
                    else if (form3.R2)
                    {
                        arMarkup.SelectedText = "[http://" + form3.URL + " " + form3.TEXT + "]";
                    }
                }
            }
        }
        

        private void EDIT_Click(object sender, EventArgs e)
        {
            IHTMLDocument2 htmlDocument = EditArabicBrowser.Document.DomDocument as IHTMLDocument2;

            IHTMLSelectionObject currentSelection = htmlDocument.selection;

            if (currentSelection != null)
            {
                IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;

                if (range != null)
                {
                    using (Form4 form4 = new Form4())
                    {
                        form4.ArHTML = Capital_Small(range.htmlText);
                        //Form4.token_making(form4.ArHTML);
                        form4.Set();

                        if (form4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            arMarkup.Text = arMarkup.Text.Replace(form4.OldMarkup, form4.NewMarkup);
                            TextWriter WriteTranslatedMarkup = new StreamWriter("TranslatedMarkup.html");
                            WriteTranslatedMarkup.WriteLine(arMarkup.Text.ToString());
                            WriteTranslatedMarkup.Close();
                            Make();
                        }
                    }
                }
            }
        }

        
        //-------------- Capital to small in translated html ------------------//
        public static string Capital_Small(string source)
        {
            string line;
            List<string> Capital = new List<string>();
            List<string> Small = new List<string>();
            TextReader tr = new StreamReader("tags.txt");
            int n = 0, index;
            while ((line = tr.ReadLine()) != null)
            {
                Capital.Add(line);
                line = line.ToLower();
                Small.Add(line);
                n++;
            }
            for (int i = 0; i < n; i++)
            {
                while (source.IndexOf(Capital[i]) != -1)
                {
                    index = source.IndexOf(Capital[i]);
                    source = source.Remove(index, Capital[i].Length);
                    source = source.Insert(index, Small[i]);
                }
            }
            tr.Close();
            return source;
        }

        //---------------- forming translated page --------------//
        public string Forming_Translated_Page(string translated_html)
        {
            TextReader tr = new StreamReader("ToBeTranslated.txt");
            TextReader trr = new StreamReader("html_2.txt");
            //---- targmli elstring da bs ----//
            string translation = translate_Wiki_Markup(tr.ReadToEnd().ToString()), line, source = "";
            //translation = translate_Wiki_Markup(translation);
            tr.Close();
            while ((line = trr.ReadLine()) != null)
            {
                if (line == "<!-- bodyContent -->")
                {
                    source = source + line;
                    while ((line = trr.ReadLine()) != null)
                    {
                        if (line == "<!-- /bodyContent -->")
                        {
                            source = source + line;
                            break;
                        }
                    }
                }
                else if (line == "<script>")
                {
                    source = source + line;
                    while ((line = trr.ReadLine()) != null)
                    {
                        source = source + line;
                        if (line == "</script>")
                        {
                            break;
                        }
                    }
                }
                else if (0 == line.IndexOf("<style"))
                {
                    source = source + line;
                    while ((line = trr.ReadLine()) != null)
                    {
                        source = source + line;
                        if (line == "</style>")
                        {
                            break;
                        }
                    }
                }
                else if (line == "<!-- LANGUAGES -->")
                {
                    source = source + line;
                    while ((line = trr.ReadLine()) != null)
                    {
                        source = source + line;
                        if (line == "<!-- /LANGUAGES -->")
                        {
                            break;
                        }
                        else if (line == "<h3>")
                        {
                            line = trr.ReadLine();
                            int last = translation.IndexOf('\n');
                            if (last != -1)
                                source = source + translation.Substring(0, last);
                            else
                                source = source + translation;
                            translation = translation.Remove(0, last + 1);
                        }
                    }
                }
                else if (line != "" && line[0] != '<' && line[0] != '\t' && line[0] != '\r' && line[0] != '\n')
                {
                    int last = translation.IndexOf('\n');
                    if (last != -1)
                        source = source + translation.Substring(0, last);
                    else
                        source = source + translation;
                    translation = translation.Remove(0, last + 1);
                }
                else
                {
                    source = source + line; ;
                }
            }
            int first = source.IndexOf("<!-- bodyContent -->") + "<!-- bodyContent -->".Length;
            source = source.Insert(first, translated_html);
            return source;
        }

        //------ change directory of page to ( right to left) ------//
        public static string rightToLeft(string source)
        {
            int index;
            while (source.IndexOf("dir=\"ltr") != -1)
            {
                index = source.IndexOf("dir=\"ltr");
                index += 5;
                source = source.Remove(index, 3);
                source = source.Insert(index, "rtl");
            }
            return source;
        }

        //--------------------- change language of webpage -------------------------//
        public static string changeLanguage(string source, string Nlang, string Tlang)
        {
            int index;
            while (source.IndexOf("lang=\"" + Nlang) != -1)
            {
                index = source.IndexOf("lang=\"" + Nlang);
                index += 6;
                source = source.Remove(index, Nlang.Length);
                source = source.Insert(index, Tlang);
            }
            return source;
        }


        public static string Editing_Markup(string markup)
        {
            int index;
            while (markup.IndexOf("= = = = =") != -1)
            {
                index = markup.IndexOf("= = = = =");
                markup = markup.Remove(index, 9);
                markup = markup.Insert(index, " ===== ");
            }
            while (markup.IndexOf("= = = =") != -1)
            {
                index = markup.IndexOf("= = = =");
                markup = markup.Remove(index, 7);
                markup = markup.Insert(index, " ==== ");
            }
            while (markup.IndexOf("= = =") != -1)
            {
                index = markup.IndexOf("= = =");
                markup = markup.Remove(index, 5);
                markup = markup.Insert(index, " === ");
            }
            while (markup.IndexOf("= =") != -1)
            {
                index = markup.IndexOf("= =");
                markup = markup.Remove(index, 3);
                markup = markup.Insert(index, " == ");
            }
            while (markup.IndexOf("\' \'\'") != -1)
            {
                index = markup.IndexOf("\' \'\'");
                markup = markup.Remove(index, 4);
                markup = markup.Insert(index, " \'\'\' ");
            }

            bool header = false, list = false, table = false;
            for (int i = 0; i < markup.Length; i++)
            {
                if (i + 4 < markup.Length && markup.Substring(i, 5) == "=====" && !(header))
                {
                    markup = markup.Insert(i, "\n");
                    i += 4;
                    header = true;
                }
                else if (i + 4 < markup.Length && markup.Substring(i, 5) == "=====" && header)
                {
                    markup = markup.Insert(i + 5, "\n");
                    i += 5;
                    header = false;
                }
                //----------
                else if (i + 3 < markup.Length && markup.Substring(i, 4) == "====" && !(header))
                {
                    markup = markup.Insert(i, "\n");
                    i += 3;
                    header = true;
                }
                else if (i + 3 < markup.Length && markup.Substring(i, 4) == "====" && header)
                {
                    markup = markup.Insert(i + 4, "\n");
                    i += 4;
                    header = false;
                }
                //---------
                else if (i + 2 < markup.Length && markup.Substring(i, 3) == "===" && !(header))
                {
                    markup = markup.Insert(i, "\n");
                    i += 2;
                    header = true;
                }
                else if (i + 2 < markup.Length && markup.Substring(i, 3) == "===" && header)
                {
                    markup.Insert(i + 3, "\n");
                    i += 3;
                    header = false;
                }
                //--------------
                else if (i + 1 < markup.Length && markup.Substring(i, 2) == "==" && !(header))
                {
                    markup = markup.Insert(i, "\n");
                    i += 1;
                    header = true;
                }
                else if (i + 1 < markup.Length && markup.Substring(i, 2) == "==" && header)
                {
                    markup.Insert(i + 2, "\n");
                    i += 2;
                    header = false;
                }
                else if (markup[i] == '*' && (i == 0 || (markup[i - 1] != '*' && i != 0)))
                {
                    markup = markup.Insert(i, "\n");
                    i++;
                    list = true;
                }
                else if (markup[i] == '#' && (i == 0 || (markup[i - 1] != '#' && i != 0)))
                {
                    markup = markup.Insert(i, "\n");
                    i++;
                    list = true;
                }
                else if (markup[i] != '*' && markup[i] != '#' && markup[i] != ':' && list)
                {
                    markup = markup.Insert(0, " ");
                    i++;
                    list = false;
                }
                if (markup[i] == '{' && markup[i + 1] == '|')
                {
                    table = true;
                    markup = markup.Insert(i, "\n");
                    markup = markup.Insert(i + 3, "\n");
                    i += 3;
                }
                else if (markup[i] == '|' && table)
                {
                    markup = markup.Insert(i, "\n");
                    i++;
                }
                else if (markup[i] == '|' && markup[i + 1] == '}' && table)
                {
                    table = false;
                    markup = markup.Insert(i + 2, "\n");
                    i += 2;
                }
            }
            return markup;
        }

        enum CurrentWikiTag
        {                       //HTML Tags:
            BoldTag,            //<b>
            ItalicsTag,         //<i>
            BoldItalicTag,      //<b><i>
            LinkTag,            //<a href="url">Link text</a>
            Heading2Tag,        //<h2>
            Heading3Tag,        //<h3>
            Heading4Tag,        //<h4>
            Heading5Tag,        //<h5>
            BulletListTag,      //<ul>
            NumberListTag,      //<ol>
            ListTag,            //<li>
            DefinitionListTag,  //<dt>
            IndentTag,          //<dl>
            IndentTextTag,      //<dd>
            ImageTag,           //<img src="url" alt="some_text">
            TableTag,           //<table>
            TableCaptionTag,    //<caption>
            TableRowTag,        //<tr>
            TableHeadingTag,    //<th>
            TableDataTag,       //<td>
            SupTag,             //<ref>
            MathTag             //<math>

        };


        public static string WikiToHTML(string textIn)
        {
            // Use a stack to keep track of our level.
            Stack<CurrentWikiTag> tagStack = new Stack<CurrentWikiTag>();

            // Store results in the StringBuilder.
            StringBuilder builder = new StringBuilder();

            // Examine each character in our string.           
            for (int s = 0; s < textIn.Length; s++)
            {
                /* For Headings */
                #region Headings
                if (textIn[s] == '=')
                {
                    int count = 1, index = s + 1;
                    while (textIn[index] == '=')
                    {
                        count++;
                        index++;
                        if (index == textIn.Length)
                            break;
                    }
                    s = index - 1;

                    if (count == 2)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.Heading2Tag)
                        {
                            tagStack.Pop();
                            builder.Append("</h2>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.Heading2Tag);
                            builder.Append("<h2>");
                        }
                    }
                    else if (count == 3)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.Heading3Tag)
                        {
                            tagStack.Pop();
                            builder.Append("</h3>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.Heading3Tag);
                            builder.Append("<h3>");
                        }
                    }
                    else if (count == 4)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.Heading4Tag)
                        {
                            tagStack.Pop();
                            builder.Append("</h4>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.Heading4Tag);
                            builder.Append("<h4>");
                        }
                    }
                    else if (count == 5)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.Heading5Tag)
                        {
                            tagStack.Pop();
                            builder.Append("</h5>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.Heading5Tag);
                            builder.Append("<h5>");
                        }
                    }

                }
                #endregion

                /* For Bold, Italics and Bold with Italic */
                #region bold,italics
                else if (textIn[s] == '\'')
                {
                    int count = 1, index = s + 1;
                    while (textIn[index] == '\'')
                    {
                        count++;
                        index++;
                        if (index == textIn.Length)
                            break;
                    }
                    s = index - 1;

                    if (count == 2)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ItalicsTag)
                        {
                            tagStack.Pop();
                            builder.Append("</i>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.ItalicsTag);
                            builder.Append("<i>");
                        }
                    }
                    else if (count == 3)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BoldTag)
                        {
                            tagStack.Pop();
                            builder.Append("</b>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.BoldTag);
                            builder.Append("<b>");
                        }
                    }
                    else if (count == 5)
                    {
                        if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BoldItalicTag)
                        {
                            tagStack.Pop();
                            builder.Append("</i></b>");
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.BoldItalicTag);
                            builder.Append("<b><i>");
                        }
                    }
                }
                #endregion

                /* For Bulleted list */         //Still contains bugs
                #region bulleted list
                else if (textIn[s] == '*')
                {
                    // To find the end of the unorderd list
                    int endList = 0;
                    int start = s;
                    for (int i = start; i < textIn.Length; i++)
                    {
                        if (i == textIn.Length - 1)
                        {
                            endList = i;
                            break;
                        }
                        if (textIn[i] == '\n')
                        {
                            if (textIn[i + 1] != '*')
                            {
                                endList = i;
                                break;
                            }
                        }
                    }
                    /*******************************************************************/

                    int count = 0;
                    Stack<int> listCountStack = new Stack<int>();
                    listCountStack.Push(0);
                    for (int j = s; j <= endList; j++)
                    {
                        if (j == endList)
                        {
                            builder.Append(textIn[j]);
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dd>");
                            }
                            while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dl>");
                            }
                            for (int remove = 0; remove < listCountStack.Count; remove++)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</li>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BulletListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</ul>");
                                    listCountStack.Pop();
                                }
                            }
                            while (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BulletListTag)
                            {
                                tagStack.Pop();
                                builder.Append("</ul>");
                            }
                        }
                        else if (textIn[j] == '\n')
                        {
                            if (textIn[j + 1] == '*')
                            {
                                count = 0;
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                }
                                while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dl>");
                                }
                            }
                            else
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                }
                                while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dl>");
                                }
                                for (int remove = 0; remove < listCountStack.Count; remove++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                        listCountStack.Pop();
                                    }
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BulletListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</ul>");
                                        listCountStack.Pop();
                                    }

                                }
                            }
                        }
                        else if (textIn[j] == '*' && (textIn[j + 1] == ' ' || textIn[j + 1] == ':'))
                        {
                            count++;
                            listCountStack.Push(count);
                            int top = listCountStack.Peek();
                            listCountStack.Pop();
                            int prevTop = listCountStack.Peek();
                            int diff = top - prevTop;
                            listCountStack.Push(top);

                            if (prevTop == 0)
                            {
                                for (int d = 0; d < diff; d++)
                                {
                                    tagStack.Push(CurrentWikiTag.BulletListTag);
                                    builder.Append("<ul>");
                                }
                                if (textIn[j + 1] != ':')
                                {
                                    tagStack.Push(CurrentWikiTag.ListTag);
                                    builder.Append("<li>");
                                }
                            }
                            else if (top == prevTop)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</li>");
                                    listCountStack.Pop();
                                }
                                if (textIn[j + 1] != ':')
                                {
                                    tagStack.Push(CurrentWikiTag.ListTag);
                                    builder.Append("<li>");
                                }
                            }
                            else if (top > prevTop)
                            {
                                for (int d = 0; d < diff; d++)
                                {
                                    tagStack.Push(CurrentWikiTag.BulletListTag);
                                    builder.Append("<ul>");
                                }
                                if (textIn[j + 1] != ':')
                                {
                                    tagStack.Push(CurrentWikiTag.ListTag);
                                    builder.Append("<li>");
                                }
                            }
                            else if (prevTop > top)
                            {
                                diff *= -1;
                                int newTop = listCountStack.Peek();
                                listCountStack.Pop();
                                for (int r = 0; r < diff; r++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                    }
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.BulletListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</ul>");

                                        listCountStack.Pop();
                                    }
                                }
                                if (textIn[j + 1] != ':')
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                    }
                                    listCountStack.Push(newTop);
                                    tagStack.Push(CurrentWikiTag.ListTag);
                                    builder.Append("<li>");
                                }
                            }

                            if (textIn[j + 1] == ' ')
                                j++;
                        }
                        else if (textIn[j] == ':')
                        {
                            int countIndent = 0;
                            for (int I = j; I < textIn.Length; I++)
                            {
                                if (textIn[I] == ' ')
                                {
                                    for (int add = 0; add < countIndent; add++)
                                    {
                                        tagStack.Push(CurrentWikiTag.IndentTag);
                                        builder.Append("<dl>");
                                    }
                                    tagStack.Push(CurrentWikiTag.IndentTextTag);
                                    builder.Append("<dd>");
                                    break;
                                }
                                else
                                {
                                    countIndent++;
                                }

                                j = I + 1;
                            }
                        }
                        else if (textIn[j] == '*' && textIn[j + 1] == '*')
                        {
                            count++;
                        }
                        //law 7at headings fel satr bta3 el list
                        else if (textIn[j] == '=')
                        {

                        }
                        else
                            // Simply append any non-markup characters.
                            builder.Append(textIn[j]);
                    }
                    s = endList;
                }
                #endregion

                /* For Numbered list */
                #region numbered list
                else if (textIn[s] == '#')
                {
                    // To find the end of the unorderd list
                    int endList = 0;
                    int start = s;
                    for (int i = start; i < textIn.Length; i++)
                    {
                        if (i == textIn.Length - 1)
                        {
                            endList = i;
                            break;
                        }
                        if (textIn[i] == '\n')
                        {
                            if (textIn[i + 1] != '#')
                            {
                                endList = i;
                                break;
                            }
                        }
                    }
                    /*******************************************************************/

                    int count = 0;
                    Stack<int> listCountStack = new Stack<int>();
                    listCountStack.Push(0);
                    for (int j = s; j <= endList; j++)
                    {
                        if (j == endList)
                        {
                            builder.Append(textIn[j]);
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dd>");
                            }
                            while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dl>");
                            }
                            for (int remove = 0; remove < listCountStack.Count; remove++)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</li>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.NumberListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</ol>");
                                    listCountStack.Pop();
                                }

                            }
                        }
                        else if (textIn[j] == '\n')
                        {
                            if (textIn[j + 1] == '#')
                            {
                                count = 0;
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                }
                                while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dl>");
                                }
                            }
                            else
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                }
                                while (tagStack.Peek() == CurrentWikiTag.IndentTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dl>");
                                }
                                for (int remove = 0; remove < listCountStack.Count; remove++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                        listCountStack.Pop();
                                    }
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.NumberListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</ol>");
                                        listCountStack.Pop();
                                    }

                                }
                            }
                        }
                        else if (textIn[j] == '#' && (textIn[j + 1] == ' ' || textIn[j + 1] == ':'))
                        {
                            count++;
                            listCountStack.Push(count);
                            int top = listCountStack.Peek();
                            listCountStack.Pop();
                            int prevTop = listCountStack.Peek();
                            int diff = top - prevTop;
                            listCountStack.Push(top);

                            if (prevTop == 0)
                            {
                                for (int d = 0; d < diff; d++)
                                {
                                    tagStack.Push(CurrentWikiTag.NumberListTag);
                                    builder.Append("<ol>");
                                }
                                tagStack.Push(CurrentWikiTag.ListTag);
                                builder.Append("<li>");
                            }
                            else if (top == prevTop)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</li>");
                                    listCountStack.Pop();
                                }
                                tagStack.Push(CurrentWikiTag.ListTag);
                                builder.Append("<li>");
                            }
                            else if (top > prevTop)
                            {
                                for (int d = 0; d < diff; d++)
                                {
                                    tagStack.Push(CurrentWikiTag.NumberListTag);
                                    builder.Append("<ol>");
                                }
                                tagStack.Push(CurrentWikiTag.ListTag);
                                builder.Append("<li>");
                            }
                            else if (prevTop > top)
                            {
                                diff *= -1;
                                int newTop = listCountStack.Peek();
                                listCountStack.Pop();
                                for (int r = 0; r < diff; r++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                    }
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.NumberListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</ol>");

                                        listCountStack.Pop();
                                    }
                                }
                                if (textIn[j + 1] != ':')
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</li>");
                                    }
                                    listCountStack.Push(newTop);
                                    tagStack.Push(CurrentWikiTag.ListTag);
                                    builder.Append("<li>");
                                }
                            }

                            if (textIn[j + 1] == ' ')
                                j++;
                        }
                        else if (textIn[j] == ':')
                        {
                            int countIndent = 0;
                            for (int I = j; I < textIn.Length; I++)
                            {
                                if (textIn[I] == ' ')
                                {
                                    for (int add = 0; add < countIndent; add++)
                                    {
                                        tagStack.Push(CurrentWikiTag.IndentTag);
                                        builder.Append("<dl>");
                                    }
                                    tagStack.Push(CurrentWikiTag.IndentTextTag);
                                    builder.Append("<dd>");
                                    break;
                                }
                                else
                                {
                                    countIndent++;
                                }

                                j = I + 1;
                            }
                        }
                        else if (textIn[j] == '#' && textIn[j + 1] == '#')
                        {
                            count++;
                        }
                        else
                            // Simply append any non-markup characters.
                            builder.Append(textIn[j]);
                    }
                    s = endList;
                }
                #endregion

                /* For Definition list */
                #region definition list
                else if (textIn[s] == ';' && textIn[s + 1] == ' ')
                {
                    // To find the end of the definition list
                    int endList = 0;
                    int start = s;
                    for (int i = start; i < textIn.Length; i++)
                    {
                        if (i == textIn.Length - 1)
                        {
                            endList = i;
                            break;
                        }
                        if (textIn[i] == '\n')
                        {
                            if (textIn[i + 1] != ';')
                            {
                                if (textIn[i + 1] != ':')
                                {
                                    endList = i;
                                    break;
                                }
                            }
                            else if (textIn[i + 1] != ':')
                            {
                                if (textIn[i + 1] != ';')
                                {
                                    endList = i;
                                    break;
                                }
                            }
                        }
                    }
                    /*******************************************************************/

                    tagStack.Push(CurrentWikiTag.IndentTag);
                    builder.Append("<dl>");
                    for (int j = s; j <= endList; j++)
                    {
                        if (j == endList)
                        {
                            builder.Append(textIn[j]);
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dd>");
                            }
                            while (tagStack.Peek() == CurrentWikiTag.DefinitionListTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dt>");
                            }
                            if (tagStack.Peek() == CurrentWikiTag.IndentTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dl>");
                            }
                        }
                        else if (textIn[j] == ';')
                        {
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dd>");
                            }
                            tagStack.Push(CurrentWikiTag.DefinitionListTag);
                            builder.Append("<dt>");

                            j++;
                        }
                        else if (textIn[j] == ':')
                        {
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.DefinitionListTag)
                            {
                                tagStack.Pop();
                                builder.Append("</dt>");
                            }
                            tagStack.Push(CurrentWikiTag.IndentTextTag);
                            builder.Append("<dd>");

                            j++;
                        }
                        else
                            builder.Append(textIn[j]);

                    }

                    s = endList;
                }
                #endregion

                /* For Indentation */
                #region indented text
                else if (textIn[s] == ':')
                {
                    // To find the end of the indent lines
                    int endList = 0;
                    for (int i = s; i < textIn.Length; i++)
                    {
                        if (i == textIn.Length - 1)
                        {
                            endList = i;
                            break;
                        }
                        if (textIn[i] == '\n')
                        {
                            if (textIn[i + 1] != ':')
                            {
                                endList = i;
                                break;
                            }
                        }
                    }
                    /*******************************************************************/

                    int count = 0;
                    Stack<int> indentCountStack = new Stack<int>();
                    indentCountStack.Push(0);
                    for (int j = s; j <= endList; j++)
                    {
                        if (j == endList)
                        {
                            builder.Append(textIn[j]);
                            for (int remove = 0; remove < indentCountStack.Count; remove++)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dl>");
                                    indentCountStack.Pop();
                                }

                            }
                        }
                        else if (textIn[j] == '\n')
                        {
                            if (textIn[j + 1] == ':')
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</dd>");
                                    count = 0;
                                }
                            }
                            else
                            {

                                for (int remove = 0; remove < indentCountStack.Count; remove++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTextTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</dd>");
                                    }
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</dl>");
                                        indentCountStack.Pop();
                                    }

                                }
                            }
                        }
                        else if (textIn[j] == ':' && textIn[j + 1] == ' ')
                        {
                            count++;
                            indentCountStack.Push(count);
                            int top = indentCountStack.Peek();
                            indentCountStack.Pop();
                            int diff = top - indentCountStack.Peek();
                            indentCountStack.Push(top);

                            if (diff > 0)
                            {
                                for (int d = 0; d < diff; d++)
                                {
                                    tagStack.Push(CurrentWikiTag.IndentTag);
                                    builder.Append("<dl>");
                                }
                                tagStack.Push(CurrentWikiTag.IndentTextTag);
                                builder.Append("<dd>");
                            }
                            else if (diff < 0)
                            {
                                diff *= -1;
                                for (int d = 0; d < diff; d++)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.IndentTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</dl>");
                                    }
                                }
                                tagStack.Push(CurrentWikiTag.IndentTextTag);
                                builder.Append("<dd>");
                            }
                            else
                            {
                                tagStack.Push(CurrentWikiTag.IndentTextTag);
                                builder.Append("<dd>");
                            }

                            j++;
                        }
                        else if (textIn[j] == ':' && textIn[j + 1] == ':')
                        {
                            count++;
                        }
                        else
                            // Simply append any non-markup characters.
                            builder.Append(textIn[j]);
                    }
                    s = endList;
                }
                #endregion

                /* For Links and Image*/
                else if (textIn[s] == '[')
                {
                    /* For Internal link */
                    #region internal link
                    if (textIn[s + 1] == '[')
                    {
                        // To find the end of the link
                        int endLink = 0;
                        bool flag = true;
                        for (int i = s + 2; i < textIn.Length; i++)
                        {
                            if (i == textIn.Length - 1)
                            {
                                endLink = i;
                                break;
                            }
                            if (textIn[i] == '|')
                            {
                                flag = false;
                            }
                            if (textIn[i] == ']')
                            {
                                if (textIn[i + 1] == ']')
                                {
                                    endLink = i;
                                    break;
                                }
                            }
                        }
                        /*******************************************************************/
                        if (flag == false)
                        {
                            tagStack.Push(CurrentWikiTag.ListTag);
                            builder.Append("<a href=\"");
                            for (int j = s + 2; j <= endLink; j++)
                            {
                                if (j == endLink)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</a>");
                                    }
                                }
                                else if (textIn[j] == '|')
                                {
                                    builder.Append("\">");
                                }
                                else
                                {
                                    builder.Append(textIn[j]);
                                }
                            }
                        }
                        else
                        {
                            tagStack.Push(CurrentWikiTag.ListTag);
                            builder.Append("<a>");
                            for (int j = s + 2; j <= endLink; j++)
                            {
                                if (j == endLink)
                                {
                                    if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                    {
                                        tagStack.Pop();
                                        builder.Append("</a>");
                                    }
                                }
                                else
                                {
                                    builder.Append(textIn[j]);
                                }
                            }
                        }

                        s = endLink + 1;
                    }
                    #endregion
                    /* For external link */
                    #region external link
                    else if (textIn[s + 1] == 'h')
                    {
                        // To find the end of the link
                        int endLink = 0;
                        for (int i = s + 1; i < textIn.Length; i++)
                        {
                            if (i == textIn.Length - 1)
                            {
                                endLink = i;
                                break;
                            }
                            if (textIn[i] == ']')
                            {
                                endLink = i;
                                break;
                            }
                        }
                        /*******************************************************************/

                        tagStack.Push(CurrentWikiTag.ListTag);
                        builder.Append("<a href=\"");
                        bool flag = true;
                        for (int j = s + 1; j <= endLink; j++)
                        {
                            if (j == endLink)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ListTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</a>");
                                }
                            }
                            else if (flag == true)
                            {
                                if (textIn[j] == ' ')
                                {
                                    flag = false;
                                    builder.Append("\">");
                                }
                                else
                                {
                                    builder.Append(textIn[j]);
                                }
                            }
                            else
                            {
                                builder.Append(textIn[j]);
                            }
                        }

                        s = endLink;
                    }
                    #endregion
                    /* For image*/
                    #region image
                    else if (textIn[s + 1] == '[' && textIn[s + 2] == 'I')
                    {
                        // To find the end of the link
                        int endImage = 0, varIndex = 0;
                        for (int i = s + 2; i < textIn.Length; i++)
                        {
                            if (i == textIn.Length - 1)
                            {
                                endImage = i;
                                break;
                            }
                            if (textIn[i] == ']')
                            {
                                if (textIn[i + 1] == ']')
                                {
                                    endImage = i;
                                    break;
                                }
                            }
                            if (textIn[i] == ':')
                                varIndex = i;
                        }
                        /*******************************************************************/

                        tagStack.Push(CurrentWikiTag.ImageTag);
                        //builder.Append("<img src=\"");
                        builder.Append("<img ");
                        for (int j = varIndex + 1; j <= endImage; j++)
                        {
                            if (j == endImage)
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.ImageTag)
                                {
                                    tagStack.Pop();
                                    //builder.Append("\">");
                                    builder.Append(">");
                                }
                            }
                            //else if (textIn[j] == '|')
                            //{
                            //builder.Append("\" alt=\"");
                            //}
                            else
                            {
                                builder.Append(textIn[j]);
                            }
                        }

                        s = endImage + 1;
                    }
                    #endregion
                }

                /* For tables */
                #region tables
                else if (textIn[s] == '{' && textIn[s + 1] == '|')
                {
                    int endTable = 0;
                    for (int i = s + 2; i < textIn.Length; i++)
                    {
                        if (i == textIn.Length - 1)
                        {
                            endTable = i;
                            break;
                        }
                        if (textIn[i] == '|')
                        {
                            if (textIn[i + 1] == '}')
                            {
                                endTable = i + 1;
                                break;
                            }
                        }
                    }
                    /***********************************************************/

                    tagStack.Push(CurrentWikiTag.TableTag);
                    builder.Append("<table");
                    int begin = s + 2;
                    if (textIn[begin] != '\n')
                    {
                        for (begin = s + 2; begin <= endTable; begin++)
                        {
                            if (textIn[begin] == '|')
                            {
                                builder.Append(">");
                                tagStack.Push(CurrentWikiTag.TableRowTag);
                                builder.Append("<tr>");
                                if (textIn[begin + 1] == '-')
                                    begin = begin + 2;

                                break;
                            }
                            else
                            {
                                builder.Append(textIn[begin]);
                            }
                        }
                    }
                    else
                    {
                        builder.Append(">");
                    }
                    s = begin;
                    for (int j = begin; j <= endTable; j++)
                    {
                        if (j == endTable)
                        {
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableTag)
                            {
                                tagStack.Pop();
                                builder.Append("</table>");
                            }
                        }
                        else if (textIn[j] == '!')
                        {
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableHeadingTag)
                            {
                                tagStack.Pop();
                                builder.Append("</th>");
                            }
                            tagStack.Push(CurrentWikiTag.TableHeadingTag);
                            builder.Append("<th>");

                            if (textIn[j + 1] == '!')
                                j = j + 2;
                            else if (textIn[j + 1] == ' ')
                                j++;
                        }
                        else if (textIn[j] == '|')
                        {
                            if (textIn[j + 1] == '+')
                            {
                                tagStack.Push(CurrentWikiTag.TableCaptionTag);
                                builder.Append("<caption>");
                                j++;
                            }
                            else if (textIn[j + 1] == '-')
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableCaptionTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</caption>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableHeadingTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</th>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableDataTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</td>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableRowTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</tr>");
                                }
                                tagStack.Push(CurrentWikiTag.TableRowTag);
                                builder.Append("<tr>");

                                j = j + 2;
                            }
                            else if (textIn[j + 1] == ' ')
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableDataTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</td>");
                                }
                                tagStack.Push(CurrentWikiTag.TableDataTag);
                                builder.Append("<td>");

                                j++;
                            }
                            else if (textIn[j + 1] == '}')
                            {
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableDataTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</td>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableRowTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</tr>");
                                }
                                if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.TableTag)
                                {
                                    tagStack.Pop();
                                    builder.Append("</table>");
                                }
                                j++;
                            }
                        }
                        else
                        {
                            builder.Append(textIn[j]);
                        }

                    }

                    s = endTable;
                }
                #endregion

                /* For sub */
                #region sub
                else if (textIn[s] == '<' && textIn[s + 1] == 'r')
                {
                    int endSub = 0;
                    for (int i = s + 5; i < textIn.Length; i++)
                    {
                        if (textIn[i] == '>')
                        {
                            endSub = i;
                        }
                    }
                    bool flag = true;
                    for (int j = s; j < endSub; j++)
                    {
                        if (textIn[j] == '<' && textIn[j + 1] == 'r')
                        {
                            tagStack.Push(CurrentWikiTag.SupTag);
                            builder.Append("<sup");
                            j = j + 4;
                        }
                        else if (textIn[j] == '/' && textIn[j + 1] == '/')
                        {
                            if (flag == false)
                                builder.Append(">");
                            else
                                flag = false;

                            j++;
                        }
                        else if (textIn[j] == '<' && textIn[j + 1] == '/')
                        {
                            if (tagStack.Count > 0 && tagStack.Peek() == CurrentWikiTag.SupTag)
                            {
                                tagStack.Pop();
                                builder.Append("</sup>");
                            }
                            j = j + 5;
                        }
                        else
                            builder.Append(textIn[j]);
                    }

                    s = endSub;
                }
                #endregion

                /* For math */
                #region math
                else if (textIn[s] == '<' && textIn[s + 1] == 'm')
                {
                    int endSub = 0;
                    for (int i = s + 6; i < textIn.Length; i++)
                    {
                        if (textIn[i] == '>')
                        {
                            endSub = i;
                        }
                    }
                    for (int j = s; j < endSub; j++)
                    {
                        tagStack.Push(CurrentWikiTag.MathTag);
                        builder.Append("<img class='\'tex'\'>");
                        j = endSub;
                    }
                    s = endSub;
                }
                #endregion

                else
                    // Simply append any non-markup characters.
                    builder.Append(textIn[s]);
            }
            return builder.ToString();
        }

    }
}
