using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagingExampleApp.Models.Shared
{
    public class Pager
    {
        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public string Action { get; set; }

        public string Search { get; set; }

        public bool EnableSearch { get; set; }

        public int MaxPages { get; set; } = 10;
    }
}
