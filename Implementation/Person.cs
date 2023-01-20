using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Person
    {
        public int Id { get; set; }
        public string  Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{Id}, {Firstname}, {Lastname}, {City}";
            }
        }

    }

    public class Table
    {
        public string TableName { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{TableName}";
            }
        }
    }
}
