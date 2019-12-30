﻿#if NETSTANDARD2_0 || NETSTANDARD2_1
using Microsoft.AspNetCore.Hosting;
#endif 
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.CO2NET
{
    public static class AspNetConfig
    {

#if NETSTANDARD2_0
        /// <summary>
        /// Web hosting environment
        /// </summary>
        public static IHostingEnvironment HostingEnvironment { get; set; }
#elif NETSTANDARD2_1
        /// <summary>
        /// Web hosting environment
        /// </summary>
        public static IHostingEnvironment/*IWebHostEnvironment*/ HostingEnvironment { get; set; }
#endif
    }
}
