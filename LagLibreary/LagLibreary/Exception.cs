using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagLibreary
{
    /// <summary>
    /// Vérifier si la valeurs recherché est trouvé
    /// </summary>
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
    /// <summary>
    /// Vérifie si le format de document est correcte
    /// </summary>
    public class DocumentFormatIncorrectException : Exception
    {
        public override string Message
        {
            get
            {
                return "the files format is incorrect";
            }
        }
    }
}
