using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class WorkHours
    {
        public int IdWorkHour { get; set; }
        public int Employee { get; set; }
        public int Contract { get; set; }
        public int WorkType { get; set; }
        public int Hours { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUser { get; set; }

        public WorkHours(int idWorkHour, int employee, int contract, int workType, int hours, DateTime insertDate, int insertUser)
        {
            IdWorkHour = idWorkHour;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            InsertDate = insertDate;
            InsertUser = insertUser;
        }

        public WorkHours(int employee, int contract, int workType, int hours, DateTime insertDate, int insertUser)
        {
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            InsertDate = insertDate;
            InsertUser = insertUser;
        }
    }
}
