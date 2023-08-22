using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox07
{
    public delegate void UpdateGpaDelegate();
    public delegate void UpdateGpaDelegate2();
    class Student
    {
        private string name;
        private double gpa;
        public event UpdateGpaDelegate UpdateGpaEvent;
        public event UpdateGpaDelegate2 UpdateGpaEvent2;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double GPA
        {
            get { return gpa; }
            set
            {
               if(value == gpa)
                {
                    gpa = value;
                }
                    else
                    if (value > gpa)
                    {
                    UpdateGpaEvent += onIncrease;
                    gpa = value;
                        UpdateGpaEvent();
                    }
                    
                    else
                    if (value < gpa)
                    {
                    UpdateGpaEvent2 += onDecrease;
                    gpa = value;
                        UpdateGpaEvent2();
                    }
               
            }
        }
        public Student (string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }
        public void onIncrease()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void onDecrease()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public override string ToString()
        {
            string str;
            str = string.Format($"Name: {name} GPA: {gpa}");
            return str;
        }
    }
}
