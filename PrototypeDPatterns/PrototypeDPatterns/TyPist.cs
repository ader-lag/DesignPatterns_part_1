using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDPatterns
{
    public class TyPist:IEmployee
    {

        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
