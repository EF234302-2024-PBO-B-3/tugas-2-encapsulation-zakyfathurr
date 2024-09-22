using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName="Unknown";
        private string _lastName = "Unknown";
        private double _monthlySalary;

        public string FirstName
        {
            get{ return _firstName; }
            set{ _firstName = value; }
        }
        public string LastName
        {
            get{ return _lastName; }
            set{ _lastName = value; }
        }
        public double MonthlySalary
        {
            get{return _monthlySalary;}
            set{
                if(value<0 && _monthlySalary>0)return;
                else if(value<0)_monthlySalary=0;
                else _monthlySalary=value;
                }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = (firstName==null || firstName=="")?"Unknown":firstName;
            LastName = (lastName==null || lastName=="")?"Unknown":lastName;
            MonthlySalary = monthlySalary<0.0?0.0:monthlySalary;
        }
        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage>0 && raisePercentage<=20)
            {
                MonthlySalary=(MonthlySalary+ raisePercentage*MonthlySalary/100);
            }
        }
        public double GetYearlySalary()
        {
            return MonthlySalary*12;
        }
    }
}