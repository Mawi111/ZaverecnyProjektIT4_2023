using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class WorkType
    {
        public int IdWorkType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public WorkType(int idWorkType, string name, string description)
        {
            IdWorkType = idWorkType;
            Name = name;
            Description = description;
        }

        //public WorkType(string name, string description)
        //{
        //    Name = name;
        //    Description = description;
        //}
    }
}
