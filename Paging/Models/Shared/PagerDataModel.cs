using System.Collections.Generic;

namespace PagingExampleApp.Models.Shared
{
    public class PagerDataModel<T> where T : class
    {
        public PagerDataModel()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }
    }
}
