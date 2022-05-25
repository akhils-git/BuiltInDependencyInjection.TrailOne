using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    internal class Responce<T>
    {
        public int ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public T Model { get; set; }
    }
}
