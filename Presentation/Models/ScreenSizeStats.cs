﻿using System;

namespace Domain
{
    public class ScreenSizeStats
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPhones { get; set; }
        public int LargePhonesSmallTablets { get; set; }
        public int TabletsSmallLaptops { get; set; }
        public int ComputerMonitors { get; set; }
        public int ComputerMonitors4K { get; set; }
        public int WebSiteId { get; set; }
        public WebSites WebSite { get; set; }
    }
}
