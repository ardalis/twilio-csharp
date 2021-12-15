/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Media.V1
{

    /// <summary>
    /// CreateMediaProcessorOptions
    /// </summary>
    public class CreateMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
        /// <summary>
        /// The Media Extension name or URL
        /// </summary>
        public string Extension { get; }
        /// <summary>
        /// The Media Extension context
        /// </summary>
        public string ExtensionContext { get; }
        /// <summary>
        /// The Media Extension environment
        /// </summary>
        public object ExtensionEnvironment { get; set; }
        /// <summary>
        /// The URL to send MediaProcessor event updates to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The HTTP method Twilio should use to call the `status_callback` URL
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Maximum MediaProcessor duration in minutes
        /// </summary>
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Construct a new CreateMediaProcessorOptions
        /// </summary>
        /// <param name="extension"> The Media Extension name or URL </param>
        /// <param name="extensionContext"> The Media Extension context </param>
        public CreateMediaProcessorOptions(string extension, string extensionContext)
        {
            Extension = extension;
            ExtensionContext = extensionContext;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Extension != null)
            {
                p.Add(new KeyValuePair<string, string>("Extension", Extension));
            }

            if (ExtensionContext != null)
            {
                p.Add(new KeyValuePair<string, string>("ExtensionContext", ExtensionContext));
            }

            if (ExtensionEnvironment != null)
            {
                p.Add(new KeyValuePair<string, string>("ExtensionEnvironment", Serializers.JsonObject(ExtensionEnvironment)));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (MaxDuration != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxDuration", MaxDuration.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Returns a single MediaProcessor resource identified by a SID.
    /// </summary>
    public class FetchMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMediaProcessorOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchMediaProcessorOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Updates a MediaProcessor resource identified by a SID.
    /// </summary>
    public class UpdateMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
        /// <summary>
        /// The SID that identifies the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The status of the MediaProcessor
        /// </summary>
        public MediaProcessorResource.UpdateStatusEnum Status { get; }

        /// <summary>
        /// Construct a new UpdateMediaProcessorOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="status"> The status of the MediaProcessor </param>
        public UpdateMediaProcessorOptions(string pathSid, MediaProcessorResource.UpdateStatusEnum status)
        {
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Returns a list of MediaProcessors.
    /// </summary>
    public class ReadMediaProcessorOptions : ReadOptions<MediaProcessorResource>
    {
        /// <summary>
        /// The sort order of the list
        /// </summary>
        public MediaProcessorResource.OrderEnum Order { get; set; }
        /// <summary>
        /// Status to filter by
        /// </summary>
        public MediaProcessorResource.StatusEnum Status { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}