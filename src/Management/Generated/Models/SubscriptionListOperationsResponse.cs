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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Subscription Operations operation response.
    /// </summary>
    public partial class SubscriptionListOperationsResponse : OperationResponse
    {
        private string _continuationToken;
        
        /// <summary>
        /// Optional. The string that can be used to return the rest of the
        /// list. Subsequent requests must include this parameter to continue
        /// listing operations from where the last response left off. This
        /// element exists only if the complete list of subscription
        /// operations was not returned.
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }
        
        private IList<SubscriptionListOperationsResponse.SubscriptionOperation> _subscriptionOperations;
        
        /// <summary>
        /// Optional. The list of operations that have been performed on the
        /// subscription during the specified timeframe.
        /// </summary>
        public IList<SubscriptionListOperationsResponse.SubscriptionOperation> SubscriptionOperations
        {
            get { return this._subscriptionOperations; }
            set { this._subscriptionOperations = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionListOperationsResponse class.
        /// </summary>
        public SubscriptionListOperationsResponse()
        {
            this._subscriptionOperations = new List<SubscriptionListOperationsResponse.SubscriptionOperation>();
        }
        
        /// <summary>
        /// A collection of attributes that identifies the source of the
        /// operation.
        /// </summary>
        public partial class OperationCallerDetails
        {
            private string _clientIPAddress;
            
            /// <summary>
            /// Optional. The IP address of the client computer that initiated
            /// the operation. This element is returned only if
            /// UsedServiceManagementApi is true.
            /// </summary>
            public string ClientIPAddress
            {
                get { return this._clientIPAddress; }
                set { this._clientIPAddress = value; }
            }
            
            private string _subscriptionCertificateThumbprint;
            
            /// <summary>
            /// Optional. The thumbprint of the subscription certificate used
            /// to initiate the operation.
            /// </summary>
            public string SubscriptionCertificateThumbprint
            {
                get { return this._subscriptionCertificateThumbprint; }
                set { this._subscriptionCertificateThumbprint = value; }
            }
            
            private bool _usedServiceManagementApi;
            
            /// <summary>
            /// Optional. Indicates whether the operation was initiated by
            /// using the Service Management API. False if it was initiated by
            /// another source, such as the Management Portal.
            /// </summary>
            public bool UsedServiceManagementApi
            {
                get { return this._usedServiceManagementApi; }
                set { this._usedServiceManagementApi = value; }
            }
            
            private string _userEmailAddress;
            
            /// <summary>
            /// Optional. The email associated with the Windows Live ID of the
            /// user who initiated the operation from the Management Portal.
            /// This element is returned only if UsedServiceManagementApi is
            /// false.
            /// </summary>
            public string UserEmailAddress
            {
                get { return this._userEmailAddress; }
                set { this._userEmailAddress = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the OperationCallerDetails class.
            /// </summary>
            public OperationCallerDetails()
            {
            }
        }
        
        /// <summary>
        /// An operation that has been performed on the subscription during the
        /// specified timeframe.
        /// </summary>
        public partial class SubscriptionOperation
        {
            private SubscriptionListOperationsResponse.OperationCallerDetails _operationCaller;
            
            /// <summary>
            /// Optional. A collection of attributes that identifies the source
            /// of the operation.
            /// </summary>
            public SubscriptionListOperationsResponse.OperationCallerDetails OperationCaller
            {
                get { return this._operationCaller; }
                set { this._operationCaller = value; }
            }
            
            private DateTime _operationCompletedTime;
            
            /// <summary>
            /// Optional. The time that the operation finished executing.
            /// </summary>
            public DateTime OperationCompletedTime
            {
                get { return this._operationCompletedTime; }
                set { this._operationCompletedTime = value; }
            }
            
            private string _operationId;
            
            /// <summary>
            /// Optional. The globally unique identifier (GUID) of the
            /// operation.
            /// </summary>
            public string OperationId
            {
                get { return this._operationId; }
                set { this._operationId = value; }
            }
            
            private string _operationName;
            
            /// <summary>
            /// Optional. The name of the performed operation.
            /// </summary>
            public string OperationName
            {
                get { return this._operationName; }
                set { this._operationName = value; }
            }
            
            private string _operationObjectId;
            
            /// <summary>
            /// Optional. The target object for the operation. This value is
            /// equal to the URL for performing an HTTP GET on the object, and
            /// corresponds to the same values for the ObjectIdFilter in the
            /// request.
            /// </summary>
            public string OperationObjectId
            {
                get { return this._operationObjectId; }
                set { this._operationObjectId = value; }
            }
            
            private IDictionary<string, string> _operationParameters;
            
            /// <summary>
            /// Optional. The collection of parameters for the performed
            /// operation.
            /// </summary>
            public IDictionary<string, string> OperationParameters
            {
                get { return this._operationParameters; }
                set { this._operationParameters = value; }
            }
            
            private DateTime _operationStartedTime;
            
            /// <summary>
            /// Optional. The time that the operation started to execute.
            /// </summary>
            public DateTime OperationStartedTime
            {
                get { return this._operationStartedTime; }
                set { this._operationStartedTime = value; }
            }
            
            private string _operationStatus;
            
            /// <summary>
            /// Optional. An object that contains information on the current
            /// status of the operation. The object returned has the following
            /// XML format: <OperationStatus>
            /// <ID>339c6c13-1f81-412f-9bc6-00e9c5876695</ID>
            /// <Status>Succeeded</Status>
            /// <HttpStatusCode>200</HttpStatusCode> </OperationStatus>
            /// Possible values of the Status element, whichholds the
            /// operation status, are: Succeeded, Failed, InProgress.
            /// </summary>
            public string OperationStatus
            {
                get { return this._operationStatus; }
                set { this._operationStatus = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the SubscriptionOperation class.
            /// </summary>
            public SubscriptionOperation()
            {
                this._operationParameters = new Dictionary<string, string>();
            }
        }
    }
}
