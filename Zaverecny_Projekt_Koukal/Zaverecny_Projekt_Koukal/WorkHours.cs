using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class WorkHours
    {
        public int IdWorkHours { get; set; }
        public Employee Employee { get; set; }
        public Contract Contract { get; set; }
        public WorkType WorkType { get; set; }
        public int Hours { get; set; }
        public DateTime InsertDate { get; set; }
        public User InsertUser { get; set; }

        public WorkHours(int idWorkHours, Employee employee, Contract contract, WorkType workType, int hours, DateTime insertDate, User insertUser)
        {
            IdWorkHours = idWorkHours;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            InsertDate = insertDate;
            InsertUser = insertUser;
        }

        public WorkHours(Employee employee, Contract contract, WorkType workType, int hours, User insertUser)
        {
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            InsertDate = DateTime.Now;
            InsertUser = insertUser;
        }
    }
}
