// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Containerregistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The event response message received from the service URI.
    /// </summary>
    public partial class EventResponseMessage
    {
        /// <summary>
        /// Initializes a new instance of the EventResponseMessage class.
        /// </summary>
        public EventResponseMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventResponseMessage class.
        /// </summary>
        /// <param name="content">The content of the event response
        /// message.</param>
        /// <param name="headers">The headers of the event response
        /// message.</param>
        /// <param name="reasonPhrase">The reason phrase of the event response
        /// message.</param>
        /// <param name="statusCode">The status code of the event response
        /// message.</param>
        /// <param name="version">The HTTP message version.</param>
        public EventResponseMessage(string content = default(string), IDictionary<string, string> headers = default(IDictionary<string, string>), string reasonPhrase = default(string), string statusCode = default(string), string version = default(string))
        {
            Content = content;
            Headers = headers;
            ReasonPhrase = reasonPhrase;
            StatusCode = statusCode;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the content of the event response message.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the headers of the event response message.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the reason phrase of the event response message.
        /// </summary>
        [JsonProperty(PropertyName = "reasonPhrase")]
        public string ReasonPhrase { get; set; }

        /// <summary>
        /// Gets or sets the status code of the event response message.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the HTTP message version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}