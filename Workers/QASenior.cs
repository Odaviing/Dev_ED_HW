using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class QASenior : Worker
    {
        private string _name;
        private int _salary;
        private int _subordinates;

        public QASenior(string name, int salary, int subordinates)
        {
            _name = name;
            _salary = salary;
            _subordinates = subordinates;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetPosition()
        {
            return "Senior QA Engineer";
        }

        public override int GetSalary()
        {
            return _salary;
        }

        public override int GetNumberOfSubordinates()
        {
            return _subordinates;
        }

        public override string GetResponsibilityLevel()
        {
            return "High";
        }
    }
}
