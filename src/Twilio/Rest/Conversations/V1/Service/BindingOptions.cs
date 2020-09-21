/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteBindingOptions
    /// </summary>
    public class DeleteBindingOptions : IOptions<BindingResource>
    {
        /// <summary>
        /// The chat_service_sid
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The SID of the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteBindingOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The chat_service_sid </param>
        /// <param name="pathSid"> The SID of the resource to delete </param>
        public DeleteBindingOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchBindingOptions
    /// </summary>
    public class FetchBindingOptions : IOptions<BindingResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchBindingOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchBindingOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadBindingOptions
    /// </summary>
    public class ReadBindingOptions : ReadOptions<BindingResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The push technology used by the Binding resources to read.
        /// </summary>
        public List<BindingResource.BindingTypeEnum> BindingType { get; set; }
        /// <summary>
        /// The identity of Conversation User associated with this binding.
        /// </summary>
        public List<string> Identity { get; set; }

        /// <summary>
        /// Construct a new ReadBindingOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        public ReadBindingOptions(string pathChatServiceSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            BindingType = new List<BindingResource.BindingTypeEnum>();
            Identity = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (BindingType != null)
            {
                p.AddRange(BindingType.Select(prop => new KeyValuePair<string, string>("BindingType", prop.ToString())));
            }

            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}