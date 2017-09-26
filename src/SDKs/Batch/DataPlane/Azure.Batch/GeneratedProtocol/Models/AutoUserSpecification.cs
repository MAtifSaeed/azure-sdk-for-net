// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the parameters for the auto user that runs a task on the
    /// Batch service.
    /// </summary>
    public partial class AutoUserSpecification
    {
        /// <summary>
        /// Initializes a new instance of the AutoUserSpecification class.
        /// </summary>
        public AutoUserSpecification()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoUserSpecification class.
        /// </summary>
        /// <param name="scope">The scope for the auto user</param>
        /// <param name="elevationLevel">The elevation level of the auto
        /// user.</param>
        public AutoUserSpecification(AutoUserScope? scope = default(AutoUserScope?), ElevationLevel? elevationLevel = default(ElevationLevel?))
        {
            Scope = scope;
            ElevationLevel = elevationLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scope for the auto user
        /// </summary>
        /// <remarks>
        /// Values are:
        ///
        /// pool - specifies that the task runs as the common auto user account
        /// which is created on every node in a pool.
        /// task - specifies that the service should create a new user for the
        /// task.
        /// The default value is task. Possible values include: 'task', 'pool'
        /// </remarks>
        [JsonProperty(PropertyName = "scope")]
        public AutoUserScope? Scope { get; set; }

        /// <summary>
        /// Gets or sets the elevation level of the auto user.
        /// </summary>
        /// <remarks>
        /// nonAdmin - The auto user is a standard user without elevated
        /// access. admin - The auto user is a user with elevated access and
        /// operates with full Administrator permissions. The default value is
        /// nonAdmin. Possible values include: 'nonAdmin', 'admin'
        /// </remarks>
        [JsonProperty(PropertyName = "elevationLevel")]
        public ElevationLevel? ElevationLevel { get; set; }

    }
}