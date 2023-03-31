using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_Projekt_Koukal
{
    public class Contract
    {
        public int IdContract { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public Contract(int idContract, string customer, string description)
        {
            IdContract = idContract;
            Customer = customer;
            Description = description;
        }
    }
}
