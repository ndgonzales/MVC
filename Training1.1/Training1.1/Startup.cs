﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Training1._1.Startup))]
namespace Training1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
