using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class InvalidParam: Exception
    {
        private string message;

        public InvalidParam(string message)
        {
            this.message = message;
        }

        public string What()
        {
            return message;
        }
    }
}
