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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the export pipeline target.
    /// </summary>
    public partial class ExportPipelineTargetProperties
    {
        /// <summary>
        /// Initializes a new instance of the ExportPipelineTargetProperties
        /// class.
        /// </summary>
        public ExportPipelineTargetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportPipelineTargetProperties
        /// class.
        /// </summary>
        /// <param name="keyVaultUri">They key vault secret uri to obtain the
        /// target storage SAS token.</param>
        /// <param name="type">The type of target for the export
        /// pipeline.</param>
        /// <param name="uri">The target uri of the export pipeline.
        /// When 'AzureStorageBlob':
        /// "https://accountName.blob.core.windows.net/containerName/blobName"
        /// When 'AzureStorageBlobContainer':
        /// "https://accountName.blob.core.windows.net/containerName"</param>
        public ExportPipelineTargetProperties(string keyVaultUri, string type = default(string), string uri = default(string))
        {
            Type = type;
            Uri = uri;
            KeyVaultUri = keyVaultUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of target for the export pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the target uri of the export pipeline.
        /// When 'AzureStorageBlob':
        /// "https://accountName.blob.core.windows.net/containerName/blobName"
        /// When 'AzureStorageBlobContainer':
        /// "https://accountName.blob.core.windows.net/containerName"
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets they key vault secret uri to obtain the target storage
        /// SAS token.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyVaultUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyVaultUri");
            }
        }
    }
}
