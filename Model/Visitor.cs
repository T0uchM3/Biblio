using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Visitor
    {
        private String name;
        private int age;
        private DateTime visitDay;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public DateTime VisitDay
        {
            get => visitDay;
            set => visitDay = value;
        }
    }
}