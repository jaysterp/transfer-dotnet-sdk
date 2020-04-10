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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network rule set for a container registry.
    /// </summary>
    public partial class NetworkRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public NetworkRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="defaultAction">The default action of allow or deny
        /// when no other rules match. Possible values include: 'Allow',
        /// 'Deny'</param>
        /// <param name="virtualNetworkRules">The virtual network
        /// rules.</param>
        /// <param name="ipRules">The IP ACL rules.</param>
        public NetworkRuleSet(string defaultAction, IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), IList<IPRule> ipRules = default(IList<IPRule>))
        {
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IpRules = ipRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the default action of allow or deny when no other
        /// rules match. Possible values include: 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "defaultAction")]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Gets or sets the virtual network rules.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets the IP ACL rules.
        /// </summary>
        [JsonProperty(PropertyName = "ipRules")]
        public IList<IPRule> IpRules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DefaultAction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultAction");
            }
            if (VirtualNetworkRules != null)
            {
                foreach (var element in VirtualNetworkRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (IpRules != null)
            {
                foreach (var element1 in IpRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
