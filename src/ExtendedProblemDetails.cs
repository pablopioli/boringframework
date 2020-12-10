using System.Collections.Generic;
using System.Text;

namespace Boring
{
    public class ExtendedProblemDetails
    {
        public string Detail { get; set; }
        public int? Status { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();

        public string GetErrorMessage()
        {
            var result = Title;

            if (Errors.Count > 0)
            {
                var sb = new StringBuilder();
                foreach (var error in Errors)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" - ");
                    }
                    sb.Append(string.Join(" - ", error.Value));
                }

                result = sb.ToString();
            }

            return result;
        }
    }
}
