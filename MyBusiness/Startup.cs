﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="">
//   
// </copyright>
// <summary>
//   The startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Owin;

[assembly: OwinStartup(typeof(MyBusiness.Startup))]

namespace MyBusiness
{
    using Owin;

    /// <summary>The startup.</summary>
    public partial class Startup
    {
        /// <summary>The configuration.</summary>
        /// <param name="app">The app.</param>
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}