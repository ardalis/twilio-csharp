using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Twilio.Converters
{
    /// <summary>
    /// Serialization methods for various datatypes before making requests to the API
    /// </summary>
    public class Serializers
    {

        /// <summary>
        /// Produce a json string from input if possible
        /// </summary>
        /// <param name="input">Object to serialize to json</param>
        /// <returns>A json string</returns>
        public static string JsonObject(object input)
        {
            return (input is string) ? (string) input : JsonConvert.SerializeObject(input);
        }

        /// <summary>
        /// Produce a ISO 8601 UTC compatible string from input if possible
        /// </summary>
        /// <param name="input">DateTime instance to serialize to string</param>
        /// <returns>A string</returns>
        public static string DateTimeIso8601(DateTime input)
        {
              return input.ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        /// <summary>
        /// Produce a ISO 8601 UTC compatible string from input if possible
        /// </summary>
        /// <param name="input">string representation of a time which will be converted to an iso8601 UTC string</param>
        /// <returns>A string</returns>
        public static string DateTimeIso8601(string input)
        {
            if (input == null) return null;

            var enUS = new CultureInfo("en-US");
            var utc = DateTimeStyles.AdjustToUniversal;
            DateTime parsedDateTime;

            return DateTime.TryParse(input, enUS, utc, out parsedDateTime) ? DateTimeIso8601(parsedDateTime) : input;
        }
    }
}
