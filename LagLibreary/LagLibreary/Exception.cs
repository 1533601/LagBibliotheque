using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    public class ReturnValueCannotBeNullException : Exception
    {
        public override string Message
        {
            get
            {
                return "the return value wasn't found";
            }
        }
    }
    public class DocumentFormatIncorrectException : Exception
    {
        public override string Message
        {
            get
            {
                return "the files format is incorrect or cannot be located";
            }
        }
    }
}
