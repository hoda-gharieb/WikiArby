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
    public partial class Form4 : Form
    {
        public string ArHTML;
        public string OldMarkup;
        public string NewMarkup;
        public Form4()
        {
            InitializeComponent();

        }
        public void Set()
        {
            token_making(ArHTML);
            SelectedMarkup.Text = Write_To_A_Markup();
            OldMarkup = SelectedMarkup.Text;
        }
        private bool TEXTLENGTH()
        {
            return SelectedMarkup.SelectionLength == 0;
        }
        private void Bold_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "'''Bold text'''";
            else
                SelectedMarkup.SelectedText = "'''" + SelectedMarkup.SelectedText.ToString() + "'''";
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "''Italic text''";
            else
                SelectedMarkup.SelectedText = "''" + SelectedMarkup.SelectedText.ToString() + "''";
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "== Heading text ==";
            else
                SelectedMarkup.SelectedText = "== " + SelectedMarkup.SelectedText.ToString() + " ==";
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "=== Heading text ===";
            else
                SelectedMarkup.SelectedText = "=== " + SelectedMarkup.SelectedText.ToString() + " ===";
        }
        private void level4_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "==== Heading text ====";
            else
                SelectedMarkup.SelectedText = "==== " + SelectedMarkup.SelectedText.ToString() + " ====";
        }

        private void level5_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "===== eading text =====";
            else
                SelectedMarkup.SelectedText = "===== " + SelectedMarkup.SelectedText.ToString() + " =====";
        }

        private void bulletedList_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "* Bulleted list item";
            else
            {
                SelectedMarkup.SelectedText = "* " + SelectedMarkup.SelectedText.ToString();
                SelectedMarkup.SelectedText = SelectedMarkup.SelectedText.Replace("\n", "\n* ");
            }

        }

        private void numberedList_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "# Numbered list item";
            else
            {
                SelectedMarkup.SelectedText = "# " + SelectedMarkup.SelectedText.ToString();
                SelectedMarkup.SelectedText = SelectedMarkup.SelectedText.Replace("\n", "\n# ");
            }

        }

        private void indentation_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = ": Indented line";
            else
            {
                SelectedMarkup.SelectedText = ": " + SelectedMarkup.SelectedText.ToString();
                SelectedMarkup.SelectedText = SelectedMarkup.SelectedText.Replace("\n", "\n: ");
            }

        }

        private void noWikiFormating_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "<nowiki>Insert non-formatted text here</nowiki>";
            else
                SelectedMarkup.SelectedText = "<nowiki>" + SelectedMarkup.SelectedText.ToString() + "</nowiki>";
        }

        private void newLine_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "\n<br />\n";
            else
                SelectedMarkup.SelectedText = "\n<br />\n" + SelectedMarkup.SelectedText.ToString();
        }

        private void bigText_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "<big>Big text</big>";
            else
                SelectedMarkup.SelectedText = "<big>" + SelectedMarkup.SelectedText.ToString() + "</big>";
        }

        private void smallText_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "<small>Small text</small>";
            else
                SelectedMarkup.SelectedText = "<small>" + SelectedMarkup.SelectedText.ToString() + "</small>";
        }

        private void superscript_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "<sup>Superscript text</sup>";
            else
                SelectedMarkup.SelectedText = "<sup>" + SelectedMarkup.SelectedText.ToString() + "</sup>";
        }

        private void subscript_Click(object sender, EventArgs e)
        {
            if (TEXTLENGTH())
                SelectedMarkup.SelectedText = "<sup>Superscript text</sup>";
            else
                SelectedMarkup.SelectedText = "<sup>" + SelectedMarkup.SelectedText.ToString() + "</sup>";
        }

        private void picture_Click(object sender, EventArgs e)
        {
            SelectedMarkup.SelectionStart += SelectedMarkup.SelectionLength;
            SelectedMarkup.SelectionLength = 0;
            SelectedMarkup.SelectedText = "<gallery>\nFile:Example.jpg|Caption1\nFile:Example.jpg|Caption2\n</gallery>\n";
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
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
                    SelectedMarkup.SelectedText = Table;
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
                        SelectedMarkup.SelectedText = "[[" + form3.URL + "|" + form3.TEXT + "]]";
                    }
                    else if (form3.R2)
                    {
                        SelectedMarkup.SelectedText = "[http://" + form3.URL + " " + form3.TEXT + "]";
                    }
                }
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            NewMarkup = SelectedMarkup.Text;
            //MessageBox.Show(ArHTML);
            //Form1.html_ch_entities("kairm");
        }



        //----------- change html char enteties to ordinary char ----------//
        public static string html_ch_entities(string line)
        {
            int first;
            //------------- ' ' --------------//
            while (line.IndexOf("&#160;") != -1)
            {
                first = line.IndexOf("&#160;");
                line = line.Remove(first, 6);
                line = line.Insert(first, " ");
            }
            while (line.IndexOf("&nbsp;") != -1)
            {
                first = line.IndexOf("&nbsp;");
                line = line.Remove(first, 6);
                line = line.Insert(first, " ");
            }
            //------------- & --------------//
            while (line.IndexOf("&#38;") != -1)
            {
                first = line.IndexOf("&#38;");
                line = line.Remove(first, 5);
                line = line.Insert(first, "&");
            }
            while (line.IndexOf("&amp;") != -1)
            {
                first = line.IndexOf("&amp;");
                line = line.Remove(first, 5);
                line = line.Insert(first, "&");
            }
            //------------ > --------------//
            while (line.IndexOf("&#62;") != -1)
            {
                first = line.IndexOf("&#62;");
                line = line.Remove(first, 5);
                line = line.Insert(first, ">");
            }
            while (line.IndexOf("&gt;") != -1)
            {
                first = line.IndexOf("&gt;");
                line = line.Remove(first, 4);
                line = line.Insert(first, ">");
            }
            //------------ < ---------------//
            while (line.IndexOf("&#60;") != -1)
            {
                first = line.IndexOf("&#60;");
                line = line.Remove(first, 5);
                line = line.Insert(first, "<");
            }
            while (line.IndexOf("&lt;") != -1)
            {
                first = line.IndexOf("&lt;");
                line = line.Remove(first, 4);
                line = line.Insert(first, "<");
            }
            //------------- cent ------------//
            while (line.IndexOf("&#162;") != -1)
            {
                first = line.IndexOf("&#162;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "¢");
            }
            while (line.IndexOf("&cent;") != -1)
            {
                first = line.IndexOf("&lt;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "¢");
            }
            //------------- pound ------------//
            while (line.IndexOf("&#163;") != -1)
            {
                first = line.IndexOf("&#163;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "£");
            }
            while (line.IndexOf("&pound;") != -1)
            {
                first = line.IndexOf("&pound;");
                line = line.Remove(first, 7);
                line = line.Insert(first, "£");
            }
            //------------- yen ------------//
            while (line.IndexOf("&#165;") != -1)
            {
                first = line.IndexOf("&#165;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "¥");
            }
            while (line.IndexOf("&yen;") != -1)
            {
                first = line.IndexOf("&yen;");
                line = line.Remove(first, 5);
                line = line.Insert(first, "¥");
            }
            //------------- euro ------------//
            while (line.IndexOf("&#8346;") != -1)
            {
                first = line.IndexOf("&#8346;");
                line = line.Remove(first, 7);
                line = line.Insert(first, "€");
            }
            while (line.IndexOf("&euro;") != -1)
            {
                first = line.IndexOf("&euro;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "€");
            }
            //------------- section ------------//
            while (line.IndexOf("&#167;") != -1)
            {
                first = line.IndexOf("&#167;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "§");
            }
            while (line.IndexOf("&sect;") != -1)
            {
                first = line.IndexOf("&sect;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "§");
            }
            //------------- copyright ------------//
            while (line.IndexOf("&#169;") != -1)
            {
                first = line.IndexOf("&#169;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "©");
            }
            while (line.IndexOf("&copy;") != -1)
            {
                first = line.IndexOf("&copy;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "©");
            }
            //----------- reg_trademark -----------//
            while (line.IndexOf("&#174;") != -1)
            {
                first = line.IndexOf("&#174;");
                line = line.Remove(first, 6);
                line = line.Insert(first, "®");
            }
            while (line.IndexOf("&reg;") != -1)
            {
                first = line.IndexOf("&reg;");
                line = line.Remove(first, 5);
                line = line.Insert(first, "®");
            }
            //----------- trademark -----------//
            while (line.IndexOf("&#8482;") != -1)
            {
                first = line.IndexOf("&#8482;");
                line = line.Remove(first, 7);
                line = line.Insert(first, "™");
            }
            while (line.IndexOf("&trade;") != -1)
            {
                first = line.IndexOf("&trade;");
                line = line.Remove(first, 7);
                line = line.Insert(first, "™");
            }
            return line;
        }

        //----------------- form the markup text --------------------------//
        public static string Write_To_Markup(bool ccheck)
        {
            TextReader tr = new StreamReader("html.txt");
            TextWriter tw = new StreamWriter("ToBeTranslated.txt");
            string line;
            string wiki = "";
            int U_List = 0, O_List = 0, Indent = 0;
            int first, last;
            bool check = false, inn = false, span = false, img = false, indent = false, sup = false, reff = false; ;
            while ((line = tr.ReadLine()) != null)
            {
                if (line == "<!-- bodyContent -->")
                {
                    check = true;
                    continue;
                }
                else if (line == "<!-- /bodycontent -->")
                {
                    check = false;
                    continue;
                }
                if (check || ccheck)
                {
                    if (line == "<!-- " || line == "<!--")
                    {
                        while (line != "-->")
                        {
                            line = tr.ReadLine();
                        }
                        continue;
                    }
                    if (line == "<i>" || line == "<b>" || 0 == line.IndexOf("<a") || line == "<sub>" || 0 == line.IndexOf("<sup>"))
                    {
                        wiki = wiki + " ";
                    }
                    if (line == "<h2>" || line == "<h3>" || line == "<h4>" || line == "<h5>" || line == "</ul>" || (U_List > 0 && 0 == line.IndexOf("<li")))
                    {
                        wiki = wiki + "\n";
                    }
                    if (line == "<ul>")
                    {
                        U_List++;
                    }
                    else if (line == "</ul>")
                    {
                        if (U_List > 0)
                        {
                            U_List--;
                        }
                    }
                    else if (U_List > 0 && 0 == line.IndexOf("<li"))
                    {
                        for (int i = 0; i < U_List; i++)
                        {
                            wiki = wiki + "*";
                        }
                        wiki = wiki + " ";
                    }
                    else if (line == "<ol>")
                    {
                        O_List++;
                    }
                    else if (line == "</ol>")
                    {
                        if (O_List > 0)
                        {
                            O_List--;
                        }
                    }
                    else if (O_List > 0 && 0 == line.IndexOf("<li"))
                    {
                        for (int i = 0; i < U_List; i++)
                        {
                            wiki = wiki + "#";
                        }
                        wiki = wiki + " ";
                    }
                    else if (line == "<dl>")
                    {
                        Indent++;
                    }
                    else if (line == "</dl>")
                    {
                        Indent--;
                    }
                    else if (line == "<dd>")
                    {
                        indent = true;
                        if (U_List > 0)
                        {
                            for (int i = 0; i < U_List - 1; i++)
                            {
                                wiki = wiki + "*";
                            }
                        }
                        if (O_List > 0)
                        {
                            for (int i = 0; i < U_List - 1; i++)
                            {
                                wiki = wiki + "#";
                            }
                        }
                        for (int i = 0; i < Indent; i++)
                        {
                            wiki = wiki + ":";
                        }
                        wiki = wiki + " ";
                    }
                    else if (line == "<dt>")
                    {
                        wiki = wiki + ";";
                    }
                    else if (line == "<caption>")
                    {
                        wiki = wiki + "|+ ";
                    }
                    else if (0 == line.IndexOf("<table"))
                    {
                        wiki = wiki + "{|";
                        if (line.IndexOf("class") != -1)
                        {
                            first = line.IndexOf("class");
                            last = line.IndexOf(">");
                            wiki = wiki + " " + line.Substring(first, last - first);
                        }
                        wiki = wiki + "\n";
                    }
                    else if (line == "</table>")
                    {
                        wiki = wiki + "|}\n";
                    }
                    else if (line == "<tr>")
                    {
                        wiki = wiki + "|-" + "\n";
                    }
                    else if (line == "<td>")
                    {
                        wiki = wiki + "| ";
                    }
                    else if (line == "</td>")
                    {
                        wiki = wiki + "\n";
                    }
                    else if (line == "<th>")
                    {
                        wiki = wiki + "! ";
                    }
                    else if (line == "</th>")
                    {
                        wiki = wiki + "\n";
                    }
                    else if (line == "<sub>" || line == "</sub>" || line == "<small>" || line == "</small>" || line == "<big>" || line == "</big>")
                    {
                        wiki = wiki + line;
                    }
                    else if (line == "<sup>")
                    {
                        sup = true;
                        wiki = wiki + line;
                    }
                    else if (line == "</sup>" && sup)
                    {
                        sup = false;
                        wiki = wiki + line;
                    }
                    else if (0 == line.IndexOf("<sup"))
                    {
                        reff = true;
                        wiki = wiki + "<ref> //" + line.Substring(4, line.Length - 6) + "// ";
                    }
                    else if (line == "</sup>" && reff)
                    {
                        reff = false;
                        wiki = wiki + "</ref>";
                    }
                    else if (0 == line.IndexOf("<span style=\"color"))
                    {
                        wiki = wiki + line;
                        span = true;
                    }
                    else if (span && line == "</span>")
                    {
                        wiki = wiki + line;
                        span = false;
                    }
                    else if (0 == line.IndexOf("<img class=\"tex\""))
                    {
                        line = html_ch_entities(line);
                        first = line.IndexOf("alt=\"") + 5;
                        last = line.IndexOf("\" src");
                        if (last != -1)
                        {
                            wiki = wiki + "<math>" + line.Substring(first, last - first) + "</math>";
                        }
                        else
                        {
                            img = true;
                            wiki = wiki + "<math>" + line.Substring(first, line.Length - first) + "\n";
                        }
                    }
                    else if (0 == line.IndexOf("<img "))
                    {
                        wiki = wiki + "Image:" + line.Substring(5, line.IndexOf("/>") - 5);
                    }
                    else if (line == "<p>" || line == "</p>")
                    {
                        wiki = wiki + "\n";
                    }
                    else if (line == "<i>" || line == "</i>" || line == "<em>" || line == "</em>")
                    {
                        wiki = wiki + "\'\'";
                    }
                    else if (line == "<b>" || line == "</b>" || line == "<strong>" || line == "</strong>")
                    {
                        wiki = wiki + "\'\'\'";
                    }
                    else if (line == "<h2>" || line == "</h2>")
                    {
                        wiki = wiki + "==";
                    }
                    else if (line == "<h3>" || line == "</h3>")
                    {
                        wiki = wiki + "===";
                    }
                    else if (line == "<h4>" || line == "</h4>")
                    {
                        wiki = wiki + "====";
                    }
                    else if (line == "<h5>" || line == "</h5>")
                    {
                        wiki = wiki + "=====";
                    }
                    else if (0 == line.IndexOf("<a"))
                    {
                        if (0 == line.IndexOf("<a href=\"/") || 0 == line.IndexOf("<a href=\"#") || line.IndexOf("href=\"//") != -1)
                        {
                            wiki = wiki + "[[";
                            inn = true;
                        }
                        else
                        {
                            wiki = wiki + "[";
                        }
                        if (0 == line.IndexOf("<a href=\"#"))
                        {
                            first = line.IndexOf('#');
                            last = line.IndexOf("\">");
                            wiki = wiki + line.Substring(first, last - first) + "|";
                        }
                        if (line.IndexOf("href=\"/") != -1)
                        {
                            first = line.IndexOf("href=") + 5;
                            last = line.IndexOf("\">");
                            wiki = wiki + line.Substring(first, last - first) + "|";
                        }
                        if (line.IndexOf("href=\"//") != -1)
                        {
                            first = line.IndexOf("href=") + 5;
                            last = line.IndexOf("\">");
                            wiki = wiki + line.Substring(first, last - first) + "|";
                        }
                    }
                    else if (line == "</a>")
                    {
                        if (inn)
                        {
                            wiki = wiki + "]]";
                            inn = false;
                        }
                        else
                        {
                            wiki = wiki + "]";
                        }
                    }
                    else if (line == "" || line[0] != '<' && (line[0] != '\t' && line[0] != '\r' && line[0] != '\n'))
                    {
                        line = html_ch_entities(line);
                        if (img && line.IndexOf("src=") != -1)
                        {
                            img = false;
                            wiki = wiki + line.Substring(0, line.IndexOf('\"')) + "</math>\n";
                        }
                        else if (img || indent)
                        {
                            wiki = wiki + line + "\n";
                            indent = false;
                        }
                        else
                        {
                            wiki = wiki + line;
                        }
                    }
                    if (line == "</i>" || line == "</b>" || line == "</a>" || line == "</sub>" || line == "</sup>" || line == "</caption>")
                    {
                        wiki = wiki + " ";
                    }
                    if (line == "</h2>" || line == "</h3>" || line == "</h4" || line == "/h5")
                    {
                        wiki = wiki + "\n";
                    }
                }
                else
                {
                    if (line == "<script>")
                    {
                        while ((line = tr.ReadLine()) != null)
                        {
                            if (line == "</script>")
                            {
                                break;
                            }
                        }
                    }
                    else if (0 == line.IndexOf("<style"))
                    {
                        while ((line = tr.ReadLine()) != null)
                        {
                            if (line == "</style>")
                            {
                                break;
                            }
                        }
                    }
                    else if (line == "<!-- LANGUAGES -->")
                    {
                        while ((line = tr.ReadLine()) != null)
                        {
                            if (line == "<!-- /LANGUAGES -->")
                            {
                                break;
                            }
                            else if (line == "<h3>")
                            {
                                line = tr.ReadLine();
                                tw.WriteLine(line);
                            }
                        }
                    }
                    else if (line != "" && line[0] != '<' && line[0] != '\t' && line[0] != '\r' && line[0] != '\n')
                    {
                        tw.WriteLine(line);
                    }
                }
            }
            tr.Close();
            tw.Close();
            return wiki;
        }

        //----------------- form the markup text --------------------------//
        public static string Write_To_A_Markup()
        {
            TextReader tr = new StreamReader("html.txt");
            string line;
            string wiki = "";
            int U_List = 0, O_List = 0, Indent = 0;
            int first, last;
            bool inn = false, span = false, img = false, indent = false, sup = false, reff = false; ;
            while ((line = tr.ReadLine()) != null)
            {
                if (line == "<!-- " || line == "<!--")
                {
                    while (line != "-->")
                    {
                        line = tr.ReadLine();
                    }
                    continue;
                }
                if (line == "<i>" || line == "<b>" || 0 == line.IndexOf("<a") || line == "<sub>" || 0 == line.IndexOf("<sup>"))
                {
                    wiki = " " + wiki;
                }
                if (line == "<h2>" || line == "<h3>" || line == "<h4>" || line == "<h5>" || line == "</ul>" || (U_List > 0 && 0 == line.IndexOf("<li")))
                {
                    wiki = "\n" + wiki;
                }
                if (line == "<ul>")
                {
                    U_List++;
                }
                else if (line == "</ul>")
                {
                    if (U_List > 0)
                    {
                        U_List--;
                    }
                }
                else if (U_List > 0 && 0 == line.IndexOf("<li"))
                {
                    for (int i = 0; i < U_List; i++)
                    {
                        wiki = "*" + wiki;
                    }
                    wiki = " " + wiki;
                }
                else if (line == "<ol>")
                {
                    O_List++;
                }
                else if (line == "</ol>")
                {
                    if (O_List > 0)
                    {
                        O_List--;
                    }
                }
                else if (O_List > 0 && 0 == line.IndexOf("<li"))
                {
                    for (int i = 0; i < U_List; i++)
                    {
                        wiki = "#" + wiki;
                    }
                    wiki = " " + wiki;
                }
                else if (line == "<dl>")
                {
                    Indent++;
                }
                else if (line == "</dl>")
                {
                    Indent--;
                }
                else if (line == "<dd>")
                {
                    indent = true;
                    if (U_List > 0)
                    {
                        for (int i = 0; i < U_List - 1; i++)
                        {
                            wiki = "*" + wiki;
                        }
                    }
                    if (O_List > 0)
                    {
                        for (int i = 0; i < U_List - 1; i++)
                        {
                            wiki = "#" + wiki;
                        }
                    }
                    for (int i = 0; i < Indent; i++)
                    {
                        wiki = ":" + wiki;
                    }
                    wiki = " " + wiki;
                }
                else if (line == "<dt>")
                {
                    wiki = ";" + wiki;
                }
                else if (line == "<caption>")
                {
                    wiki = " +|" + wiki;
                }
                else if (0 == line.IndexOf("<table"))
                {
                    wiki = "|}" + wiki;
                    if (line.IndexOf("class") != -1)
                    {
                        first = line.IndexOf("class");
                        last = line.IndexOf(">");
                        wiki = line.Substring(first, last - first) + " " + wiki;
                    }
                    wiki = "\n" + wiki;
                }
                else if (line == "</table>")
                {
                    wiki = "\n{|" + wiki;
                }
                else if (line == "<tr>")
                {
                    wiki = "\n" + "-|" + wiki;
                }
                else if (line == "<td>")
                {
                    wiki = " |" + wiki;
                }
                else if (line == "</td>")
                {
                    wiki = "\n" + wiki;
                }
                else if (line == "<th>")
                {
                    wiki = " !" + wiki;
                }
                else if (line == "</th>")
                {
                    wiki = "\n" + wiki;
                }
                else if (line == "<sub>" || line == "</sub>" || line == "<small>" || line == "</small>" || line == "<big>" || line == "</big>")
                {
                    wiki = line + wiki;
                }
                else if (line == "<sup>")
                {
                    sup = true;
                    wiki = line + wiki;
                }
                else if (line == "</sup>" && sup)
                {
                    sup = false;
                    wiki = line + wiki;
                }
                else if (0 == line.IndexOf("<sup"))
                {
                    reff = true;
                    wiki = "// " + line.Substring(4, line.Length - 6) + "// <ref>" + wiki;
                }
                else if (line == "</sup>" && reff)
                {
                    reff = false;
                    wiki = "</ref>" + wiki;
                }
                else if (0 == line.IndexOf("<span style=\"color"))
                {
                    wiki = line + wiki;
                    span = true;
                }
                else if (span && line == "</span>")
                {
                    wiki = line + wiki;
                    span = false;
                }
                else if (0 == line.IndexOf("<img class=\"tex\""))
                {
                    line = html_ch_entities(line);
                    first = line.IndexOf("alt=\"") + 5;
                    last = line.IndexOf("\" src");
                    if (last != -1)
                    {
                        wiki = line.Substring(first, last - first) + "</math>" + "<math>" + wiki;
                    }
                    else
                    {
                        img = true;
                        wiki = "\n" + line.Substring(first, line.Length - first) + "<math>" + wiki;
                    }
                }
                else if (0 == line.IndexOf("<img "))
                {
                    wiki = line.Substring(5, line.IndexOf("/>") - 5) + ":Image" + wiki;
                }
                else if (line == "<p>" || line == "</p>")
                {
                    wiki = "\n" + wiki;
                }
                else if (line == "<i>" || line == "</i>" || line == "<em>" || line == "</em>")
                {
                    wiki = "\'\'" + wiki;
                }
                else if (line == "<b>" || line == "</b>" || line == "<strong>" || line == "</strong>")
                {
                    wiki = "\'\'\'" + wiki;
                }
                else if (line == "<h2>" || line == "</h2>")
                {
                    wiki = "==" + wiki;
                }
                else if (line == "<h3>" || line == "</h3>")
                {
                    wiki = "===" + wiki;
                }
                else if (line == "<h4>" || line == "</h4>")
                {
                    wiki = "====" + wiki;
                }
                else if (line == "<h5>" || line == "</h5>")
                {
                    wiki = "=====" + wiki;
                }
                else if (0 == line.IndexOf("<a"))
                {
                    if (0 == line.IndexOf("<a href=\"/") || 0 == line.IndexOf("<a href=\"#") || line.IndexOf("href=\"//") != -1)
                    {
                        wiki = "]]" + wiki;
                        inn = true;
                    }
                    else
                    {
                        wiki = "]" + wiki;
                    }
                    if (0 == line.IndexOf("<a href=\"#"))
                    {
                        first = line.IndexOf('#');
                        last = line.IndexOf("\">");
                        wiki = "|" + line.Substring(first, last - first) + wiki;
                    }
                    if (line.IndexOf("href=\"//") != -1)
                    {
                        first = line.IndexOf("href=") + 5;
                        last = line.IndexOf("\">");
                        wiki = "|" + line.Substring(first, last - first) + wiki;
                    }
                    if (line.IndexOf("href=\"/") != -1)
                    {
                        first = line.IndexOf("href=") + 5;
                        last = line.IndexOf("\">");
                        wiki = "|" + line.Substring(first, last - first) + wiki;
                    }
                }
                else if (line == "</a>")
                {
                    if (inn)
                    {
                        wiki = "[[" + wiki;
                        inn = false;
                    }
                    else
                    {
                        wiki = "[" + wiki;
                    }
                }
                else if (line == "" || line[0] != '<' && (line[0] != '\t' && line[0] != '\r' && line[0] != '\n'))
                {
                    line = html_ch_entities(line);
                    if (img && line.IndexOf("src=") != -1)
                    {
                        img = false;
                        wiki = "</math>\n" + line.Substring(0, line.IndexOf('\"')) + wiki;
                    }
                    else if (img || indent)
                    {
                        wiki = "\n" + line + wiki;
                        indent = false;
                    }
                    else
                    {
                        wiki = line + wiki;
                    }
                }
                if (line == "</i>" || line == "</b>" || line == "</a>" || line == "</sub>" || line == "</sup>" || line == "</caption>")
                {
                    wiki = " " + wiki;
                }
                if (line == "</h2>" || line == "</h3>" || line == "</h4" || line == "/h5")
                {
                    wiki = "\n" + wiki;
                }
            }
            tr.Close();
            return wiki;
        }

        //--------------- cutting html into tokens ------------------------//
        public static void token_making(string html_source)
        {
            int index;
            TextWriter tw;
            tw = new StreamWriter("html.txt");
            while (html_source.Length != 0)
            {
                if (html_source.IndexOf('<') == -1)
                {
                    tw.WriteLine(html_source);
                    html_source = "";
                }
                else if (html_source[0] == '<')
                {
                    index = html_source.IndexOf('>');
                    tw.WriteLine(html_source.Substring(0, index + 1));
                    html_source = html_source.Remove(0, index + 1);
                }
                else
                {
                    index = html_source.IndexOf('<');
                    tw.WriteLine(html_source.Substring(0, index));
                    html_source = html_source.Remove(0, index);
                }
            }

            tw.Close();
        }
    }
}
