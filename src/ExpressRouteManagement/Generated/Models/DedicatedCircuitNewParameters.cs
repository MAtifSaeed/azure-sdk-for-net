// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// The parameters to the New Dedicated Circuit request.
    /// </summary>
    public partial class DedicatedCircuitNewParameters
    {
        private uint _bandwidth;
        
        /// <summary>
        /// Required. Bandwidth requested for the circuit in Mbps.
        /// </summary>
        public uint Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }
        
        private string _circuitName;
        
        /// <summary>
        /// Required. Name of the dedicated circuit.
        /// </summary>
        public string CircuitName
        {
            get { return this._circuitName; }
            set { this._circuitName = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. Location of the dedicated circuit.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _serviceProviderName;
        
        /// <summary>
        /// Required. Service provider chosen to create the dedicated circuit
        /// with.
        /// </summary>
        public string ServiceProviderName
        {
            get { return this._serviceProviderName; }
            set { this._serviceProviderName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DedicatedCircuitNewParameters
        /// class.
        /// </summary>
        public DedicatedCircuitNewParameters()
        {
        }
    }
}
