﻿using System.Web;
using System.Web.Mvc;

namespace schwetschenau_MIS4200
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
