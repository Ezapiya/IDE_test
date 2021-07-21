using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_test
{
    class function_
    {
       public  String return_type { get; set; }
       public String function_name { get; set; }
       public String function_prototype { get; set; }
       public String function_declaration { get; set; }
       public String function_body { get; set; }
       public int Strging_line { get; set; }
       public int Ending_line { get; set; }
       public List<String> variables = new List<string>();

    }
}
