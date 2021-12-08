using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    abstract class Worker
    {
        public abstract string GetName();
        public abstract string GetPosition();
        public abstract int GetSalary();
        public abstract int GetNumberOfSubordinates();
        public abstract string GetResponsibilityLevel();


    }
}
