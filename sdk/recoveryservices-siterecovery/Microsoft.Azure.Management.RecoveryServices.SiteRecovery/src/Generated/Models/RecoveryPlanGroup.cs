// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery plan group details.
    /// </summary>
    public partial class RecoveryPlanGroup
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class.
        /// </summary>
        public RecoveryPlanGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanGroup class.
        /// </summary>
        /// <param name="groupType">The group type. Possible values include:
        /// 'Shutdown', 'Boot', 'Failover'</param>
        /// <param name="replicationProtectedItems">The list of protected
        /// items.</param>
        /// <param name="startGroupActions">The start group actions.</param>
        /// <param name="endGroupActions">The end group actions.</param>
        public RecoveryPlanGroup(string groupType, IList<RecoveryPlanProtectedItem> replicationProtectedItems = default(IList<RecoveryPlanProtectedItem>), IList<RecoveryPlanAction> startGroupActions = default(IList<RecoveryPlanAction>), IList<RecoveryPlanAction> endGroupActions = default(IList<RecoveryPlanAction>))
        {
            GroupType = groupType;
            ReplicationProtectedItems = replicationProtectedItems;
            StartGroupActions = startGroupActions;
            EndGroupActions = endGroupActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the group type. Possible values include: 'Shutdown',
        /// 'Boot', 'Failover'
        /// </summary>
        [JsonProperty(PropertyName = "groupType")]
        public string GroupType { get; set; }

        /// <summary>
        /// Gets or sets the list of protected items.
        /// </summary>
        [JsonProperty(PropertyName = "replicationProtectedItems")]
        public IList<RecoveryPlanProtectedItem> ReplicationProtectedItems { get; set; }

        /// <summary>
        /// Gets or sets the start group actions.
        /// </summary>
        [JsonProperty(PropertyName = "startGroupActions")]
        public IList<RecoveryPlanAction> StartGroupActions { get; set; }

        /// <summary>
        /// Gets or sets the end group actions.
        /// </summary>
        [JsonProperty(PropertyName = "endGroupActions")]
        public IList<RecoveryPlanAction> EndGroupActions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GroupType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupType");
            }
            if (StartGroupActions != null)
            {
                foreach (var element in StartGroupActions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (EndGroupActions != null)
            {
                foreach (var element1 in EndGroupActions)
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