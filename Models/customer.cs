using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace schwetschenau_MIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<order> orders { get; set; }
    }
}