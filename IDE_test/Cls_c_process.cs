using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace IDE_test
{
    class Cls_c_process
    {
        public String code = "";
        List<String> tokens_list = new List<string>();
        List<String> veriable_list = new List<string>();
        List<String> function_list = new List<string>();
       
        private string removeComments(string prgm)
        {
            int n = prgm.Length;
            string res = "";

            // Flags to indicate that single line and multiple line comments
            // have started or not.
            bool s_cmt = false;
            bool m_cmt = false;


            // Traverse the given program
            for (int i = 0; i < n; i++)
            {
                // If single line comment flag is on, then check for end of it
                if (s_cmt == true && prgm[i] == '\n')
                    s_cmt = false;

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
        public String[]  Parse()
        {
            String inputLanguage = removeComments(code);
            Regex r = new Regex("\\n");
            String[] lines = r.Split(inputLanguage);
            tokens_list.Clear();
            veriable_list.Clear();
            function_list.Clear();
          
            foreach (string l in lines)
            {
                String li = l.Trim();
                if (li.StartsWith("#include"))
                    continue;
                if (li.StartsWith("#define"))
                    continue;
                if (li.Contains("printf"))
                    continue;
                if (li.Contains("scanf"))
                    continue;
                if (l.Contains("cout<<"))
                    continue;
                if (li.Contains("cin<<"))
                    continue;
                if (li.Contains("printf"))
                    continue;

                ParseLine(l);
            }
            var DistinctItems = tokens_list.Distinct();
           // String[] abc = DistinctItems.ToArray();
            return DistinctItems.ToArray();
        }
        public String[] get_function()
        {
            var DistinctItems = function_list.Distinct();
            return DistinctItems.ToArray();
        }
        public String[] get_veriable()
        {
            var DistinctItems = veriable_list.Distinct();
            return DistinctItems.ToArray();
        }
      
        void ParseLine(string line)
        {
            Regex r = new Regex("([ \\t{>=<,[}();])");
            //Regex r = new Regex("([ \\t{=,[}();])");
            String[] tokens = r.Split(line);

            foreach (string token in tokens)
            {
                String tokenx = token.Trim();

                // Check for a comment.
                if (tokenx == "//" || tokenx.StartsWith("//"))
                {
                    // Find the start of the comment and then extract the whole comment.
                    int index = line.IndexOf("//");
                    string comment = line.Substring(index, line.Length - index);

                    break;
                }
                if (tokenx.Contains("+"))
                {
                    String[] temp = tokenx.Split('+');
                    tokenx = temp[0];
                }
                if (tokenx.Contains("-"))
                {
                    String[] temp = tokenx.Split('-');
                    tokenx = temp[0];
                }
                if (tokenx.Contains("*"))
                {
                    String[] temp = tokenx.Split('*');
                    tokenx = temp[0];
                }
                if (tokenx.Contains("/"))
                {
                    String[] temp = tokenx.Split('/');
                    tokenx = temp[0];
                }
                // Check whether the token is a keyword. 
                String[] keywords = { "NULL","main", "public", "void", "using", "static", "class", "auto", "double", "int", "struct", "break", "else", "long", "switch", "case", "enum", "register", "typedef", "char", "extern", "return", "union", "continue", "for", "signed", "void", "do", "if", "static", "while", "default", "goto", "sizeof", "volatile", "const", "float", "short", "unsigned" };
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == tokenx)
                    {
                        goto abc;

                        break;
                    }
                }
                // m_rtb.SelectedText = token;
                if (tokenx.StartsWith("0") == true || tokenx.StartsWith("1") == true || tokenx.StartsWith("2") == true || tokenx.StartsWith("3") == true || tokenx.StartsWith("4") == true || tokenx.StartsWith("5") == true || tokenx.StartsWith("6") == true || tokenx.StartsWith("7") == true || tokenx.StartsWith("8") == true || tokenx.StartsWith("9") == true)
                { }
                else
                {
                    if (tokenx.Length != 0)
                    {
                        if (tokenx.Length == 1 && !Char.IsLetter(tokenx[0]))
                        {

                        }
                        else
                        {
                            if (!tokenx.StartsWith("\""))
                            {
                                tokens_list.Add(tokenx);

                                ///
                                try
                                {
                                    int index = line.IndexOf(tokenx) + tokenx.Length;
                                    char xxxx = line[index];
                                    while (line[index] == ' ' || line[index] == '\t')
                                    {
                                        index++;
                                    }
                                    if (line[index] == '(')
                                    {
                                        function_list.Add(tokenx);
                                       
                                    }
                                    else
                                    {
                                        veriable_list.Add(tokenx);
                                        
                                    }
                                }
                                catch (Exception ex)
                                { }
                                ///
                            }

                        }


                    }


                }
            abc: ;
            }


        }
    }
}
