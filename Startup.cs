﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(schwetschenau_MIS4200.Startup))]
namespace schwetschenau_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
