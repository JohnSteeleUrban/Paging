using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagingExampleApp.Models.Shared
{
    public class Search
    {
        public string Action { get; set; }

        public string Controller { get; set; }
        public string TextPlaceHolder { get; set; }
    }
}
