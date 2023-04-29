using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace pizza
{
    public static class Helpers
    {
        public static List<string> ParseMultipleSelectValue(IFormCollection data, string key)
        {
            List<string> values = new List<string>();

            foreach(KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> datum in data.ToList()) {
                if(datum.Key.Equals(key)) {
                    string value = datum.Value;

                    if(value.Length == 0) return values;
                    foreach(string val in value.Split(",")) {
                        values.Add(val);
                    }

                    break;
                }
            }

            return values;
        }
    }
}