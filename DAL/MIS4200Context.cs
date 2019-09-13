using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using schwetschenau_MIS4200.Models;
using System.Data.Entity;

namespace schwetschenau_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
    }
}