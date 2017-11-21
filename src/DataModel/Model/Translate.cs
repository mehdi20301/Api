using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Data.Model
{
    public class Translate
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Translit { get; set; }
        public string Format { get; set; }
    }
}
