using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace IDE_test
{
    class Cls_cpp_process
    {
        public String code = "";
        Regex r = new Regex("\\n");
        String[] lines;
        String[] tokens;
        int Current_line = -1;

       // List<String> Class_list = new List<string>();
        List<Cls_cpp_class> Class_list = new List<Cls_cpp_class>();

        private string removeComments(string prgm)
        {
            int n = prgm.Length;
            string res = "";

            bool s_cmt = false;
            bool m_cmt = false;

            for (int i = 0; i < n; i++)
            {
                // If single line comment flag is on, then check for end of it
                if (s_cmt == true && prgm[i] == '\n')
                {
                    s_cmt = false;
                    // res += '\n';

                }
                if (m_cmt == true && prgm[i] == '\n')
                {
                    res += '\n';
                }

                // If multiple line comment is on, then check for end of it
                else if (m_cmt == true && prgm[i] == '*' && prgm[i + 1] == '/')
                { m_cmt = false; i++; }

                // If this character is in a comment, ignore it
                else if (s_cmt || m_cmt)
                    continue;

                // Check for beginning of comments and set the approproate flags
                else if (prgm[i] == '/' && prgm[i + 1] == '/')
                { s_cmt = true; i++; }
                else if (prgm[i] == '/' && prgm[i + 1] == '*')
                { m_cmt = true; i++; }

                // If current character is a non-comment character, append it to res
                else res += prgm[i];
            }
            return res;
        }

        public void Parse()
        {
            String inputLanguage = removeComments(code);
            lines = r.Split(inputLanguage);
            Current_line = 0;
            foreach (string l in lines)
            {
                String line = l.Trim();
                if (line.StartsWith("class"))
                {
                    if (!line.EndsWith(";"))
                    {
                        Regex r1 = new Regex("([ \\t{>=<,[}();])");
                        tokens = r1.Split(line);

                        String[] kk = new String[3];
                        kk[0] = " ";
                        kk[1] = "";
                        tokens = tokens.Except(kk).ToArray();
                        String class_name = tokens[1];
                        int starting_line = 0, ending_line = 0;
                        int bo = 0, bc = 0;
                        String class_body = "";
                        bo = 0; bc = -1;
                        if (line.EndsWith("{"))
                        {
                            bo = 1;
                        }

                        int x = Current_line;
                        int x1 = 0;

                        while (bo != bc)
                        {

                            Regex r2 = new Regex("([ \\t{>=<,[}();])");
                            String[] ftokens = r2.Split(lines[Current_line + x1]);
                            ftokens = ftokens.Except(kk).ToArray();
                            for (int k = x; k < ftokens.Count(); k++)
                            {
                                if (ftokens[k].CompareTo("{") == 0)
                                {
                                    bo++;
                                }
                                if (ftokens[k].CompareTo("}") == 0)
                                {
                                    if (bc == -1)
                                        bc = 0;
                                    bc++;
                                }
                                if (bo == bc && bo != 0)
                                    break;
                            }
                            class_body = class_body + "\n" + lines[Current_line + x1];
                            x1++; x = 0; starting_line = Current_line; ending_line = Current_line + x1;
                        }
                        Cls_cpp_class cpp_class = new Cls_cpp_class();
                        cpp_class.class_name = class_name;
                        cpp_class.starting_line = Current_line;
                        cpp_class.ending_line = Current_line + x1;
                        Class_list.Add(cpp_class);

                        Regex r3 = new Regex("([ \\t\n{>=<,[}();])");
                       // String xx= class_body.Replace("\n","");
                       // String[] ctokens = r3.Split(xx);

                       // String xx = class_body.Replace("\n", "");
                        String[] ctokens = r3.Split(class_body);

                        List<String> temp = new List<string>();
                        for (int i = 0; i < ctokens.Length; i++)
                        {
                            if (ctokens[i].CompareTo("") != 0 && ctokens[i].CompareTo(" ") != 0)
                            {
                                temp.Add(ctokens[i]);
                            }
                        }
                        String member_type = "private";
                        for (int i = 0; i < temp.Count; i++)
                        {
                            if (temp[i].CompareTo("private") == 0 || temp[i].CompareTo("private:") == 0)
                            {
                                member_type = "private";
                            }
                            if (temp[i].CompareTo("protected") == 0 || temp[i].CompareTo("protected:") == 0)
                            {
                                member_type = "protected";
                            }
                            if (temp[i].CompareTo("public") == 0 || temp[i].CompareTo("public:") == 0)
                            {
                                member_type = "public";
                            }

                             String[] keywords = { "NULL", "public", "void", "using", "static", "class", "auto", "double", "int", "struct", "break", "else", "long", "switch", "case", "enum", "register", "typedef", "char", "extern", "return", "union", "continue", "for", "signed", "void", "do", "if", "static", "while", "default", "goto", "sizeof", "volatile", "const", "float", "short", "unsigned" };
                            for (int j = 0; j < keywords.Length; j++)
                            {
                                if (keywords[j] == temp[i])
                                {
                                    goto abc;
                                    break;
                                }
                            }
                            if (temp[i].StartsWith("0") == true || temp[i].StartsWith("1") == true || temp[i].StartsWith("2") == true || temp[i].StartsWith("3") == true || temp[i].StartsWith("4") == true || temp[i].StartsWith("5") == true || temp[i].StartsWith("6") == true || temp[i].StartsWith("7") == true || temp[i].StartsWith("8") == true || temp[i].StartsWith("9") == true)
                            { }
                            else
                            {
                                if (temp[i].Length != 0)
                                {
                                    if (temp[i].Length == 1 && !Char.IsLetter(temp[i][0]))
                                    {

                                    }
                                    else
                                    {
                                        if (!temp[i].StartsWith("\""))
                                        {
                                            
                                            int q = 0;
                                            for (q = 0; q < Class_list.Count; q++)
                                            { 
                                                if(Class_list[q].class_name.CompareTo(class_name)==0)
                                                    break;
                                            }
                                            Class_list[q].tokens_list.Add(temp[i]);
                                            ///
                                            try
                                            {
                                                int index = 1;
                                                while (temp[i + index].CompareTo(" ") == 0 || temp[i + index].CompareTo("\t") == 0)
                                                {
                                                    index++;
                                                }
                                                if (temp[i + index].CompareTo("(") == 0)
                                                {
                                                    Class_list[q].function_list.Add(temp[i]);

                                                }
                                                else
                                                {
                                                    Class_list[q].veriable_list.Add(temp[i]);
                                                }
                                            }
                                            catch (Exception ex)
                                            { }
                                        }
                                    }
                                }
                            }
                        abc:;
                        }


                       
                        ctokens = ctokens.Except(kk).ToArray();

                    }

                }
                Current_line++;
            }
            
        }
        void ParseLine(string line)
        {
            line = line.Trim();
            if (line.StartsWith("#include"))
                goto xyz;
            if (line.StartsWith("#define"))
                goto xyz;
            if (line.Contains("printf"))
                goto xyz;
            if (line.Contains("scanf"))
                goto xyz;
            if (line.Contains("cout<<"))
                goto xyz;
            if (line.Contains("cin<<"))
                goto xyz;
            if (line.Contains("printf"))
                goto xyz;

        xyz: ;

        }
    }
}
