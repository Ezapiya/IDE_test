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
        int Current_char = 0;
        int Current_line = -1;
        int Current_token = 0;
        List<String> tokens_list = new List<string>();
        List<String> veriable_list = new List<string>();
        List<String> function_list = new List<string>();
        List<function_> function_list_1 = new List<function_>();

        Regex r = new Regex("\\n");
        String[] lines;
        String[] tokens;
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
                { s_cmt = true; i++; res += '\n'; }
                else if (prgm[i] == '/' && prgm[i + 1] == '*')
                { m_cmt = true; i++; res += '\n'; }

                // If current character is a non-comment character, append it to res
                else res += prgm[i];
            }
            return res;
        }
        public String[]  Parse()
        {
            Cls_c_process temp_process = new Cls_c_process();
            String inputLanguage = removeComments(code);
            lines = r.Split(inputLanguage);
            tokens_list.Clear();
            veriable_list.Clear();
            function_list.Clear();
          
            foreach (string l in lines)
            {
                Current_line++;
                /*String li = l.Trim();
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
                    continue;*/

                ParseLine(l);
                Current_char = Current_char + l.Length;
               
            }
            var xxx = function_list_1.ToArray();
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
        public String check_function(String line,String function_name,int index)
        {
            String result = "Calling";
            String p_token, n_token;
            String function_body = "";
            int starting_line = 0;
            int ending_line = 0;
            int bo = 0, bc = 0;
            try {
                p_token = tokens[Current_token - 1];
                n_token = tokens[Current_token + 1];
                int i = Current_token + 1;
                for (; i < tokens.Count(); i++)
                {
                    if (tokens[i].CompareTo(")") == 0)
                        break;
                }
                if ((i == tokens.Count() - 1) || tokens[i+1].CompareTo("{") == 0)
                {
                    
                    result = "Create";
                    function_body = "";
                    bo = 0; bc = -1;
                   
                    int x = i;
                    int x1=0;

                    while (bo != bc)
                    {

                        Regex r1 = new Regex("([ \\t{>=<,[}();])");
                        String[] ftokens = r1.Split(lines[Current_line + x1]);
                        String[] kk = new String[3];
                        kk[0] = " ";
                        kk[1] = "";
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
                            if (bo == bc && bo!=0)
                                break;
                        }
                        function_body = function_body + "\n" + lines[Current_line + x1];
                        x1++; x = 0; starting_line = Current_line; ending_line = Current_line + x1;
                    } 


                }
                else
                {
                    if (tokens[i + 1].CompareTo(";") == 0)
                    {
                        String[] datatypes = {"int", "char", "float", "double","void","short" };
                            // prototype or calling
                        if (datatypes.Contains(p_token) == true || veriable_list.ToArray().Contains(p_token) == true)
                        {
                            // prototype 
                            result = "Prototype";
                        }
                        else
                        { 
                            //calling 
                            result = "Calling";
                        }
                    }
                }
                int j = 0;
                for (; j < function_list_1.Count; j++)
                {
                    if (function_list_1[j].function_name.CompareTo(function_name) == 0)
                        break;
                }
                if (j == function_list_1.Count)
                {
                    function_ f = new function_();
                    f.function_name = function_name;
                    if (result.CompareTo("Prototype") == 0)
                    {
                        f.function_prototype = line;
                    }
                    if (result.CompareTo("Create") == 0)
                    {
                        f.function_declaration = line;
                        f.function_body = function_body;
                        f.Strging_line = starting_line;
                        f.Ending_line = ending_line;

                    }
                    function_list_1.Add(f);
                }
                else
                {
                    if (result.CompareTo("Prototype") == 0)
                    {
                        function_list_1[j].function_prototype = line;
                    }
                    if (result.CompareTo("Create") == 0)
                    {
                        function_list_1[j].function_declaration = line;
                        function_list_1[j].function_body = function_body;
                        function_list_1[j].Strging_line = starting_line;
                        function_list_1[j].Ending_line = ending_line;
                    }

                }
            }
            catch { }
            
            return result;
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

            Regex r1 = new Regex("([ \\t{>=<,[}();])");
            tokens = r1.Split(line);
            
            String[] kk = new String[3];
            kk[0] = " ";
            kk[1] = "";
            tokens = tokens.Except(kk).ToArray();
            Current_token = -1;
            foreach (string token in tokens)
            {
                Current_token++;
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

                                        check_function(line, tokenx, index);
                                       
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
        xyz: ;

        }

        /////////
    }
}
