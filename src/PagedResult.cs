using System.Collections.Generic;

namespace Boring
{
    public class PagedResult<T>
    {
        public ICollection<T> Data { get; set; }
        public bool HasMoreData { get; set; }

        public PagedResult()
        { }

        public PagedResult(ICollection<T> data)
        {
            Data = data;
        }

        public PagedResult(ICollection<T> data, bool hasMoreData)
        {
            Data = data;
            HasMoreData = hasMoreData;
        }
    }
}
