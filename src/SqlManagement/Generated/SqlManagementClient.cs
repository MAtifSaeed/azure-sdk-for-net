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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Management.Sql;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The SQL Database Management API is a REST API for managing SQL Database
    /// servers and the firewall rules associated with SQL Database servers.
    /// (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715283.aspx for
    /// more information)
    /// </summary>
    public partial class SqlManagementClient : ServiceClient<SqlManagementClient>, ISqlManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all SQL requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IDacOperations _dac;
        
        /// <summary>
        /// Includes operations for importing and exporting SQL Databases into
        /// and out of Windows Azure blob storage.
        /// </summary>
        public virtual IDacOperations Dac
        {
            get { return this._dac; }
        }
        
        private IDatabaseOperationOperations _databaseOperations;
        
        /// <summary>
        /// The SQL Database Management API includes operations for get/stop
        /// SQL Databases' operations for a subscription.
        /// </summary>
        public virtual IDatabaseOperationOperations DatabaseOperations
        {
            get { return this._databaseOperations; }
        }
        
        private IDatabaseOperations _databases;
        
        /// <summary>
        /// The SQL Database Management API includes operations for managing
        /// SQL Databases for a subscription.
        /// </summary>
        public virtual IDatabaseOperations Databases
        {
            get { return this._databases; }
        }
        
        private IFirewallRuleOperations _firewallRules;
        
        /// <summary>
        /// The Windows Azure SQL Database Management API includes operations
        /// for managing the server-level firewall rules for SQL Database
        /// servers.You cannot manage the database-level firewall rules using
        /// the Windows Azure SQL Database Management API; they can only be
        /// managed by running the  Transact-SQL statements against the master
        /// or individual user databases.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715276.aspx
        /// for more information)
        /// </summary>
        public virtual IFirewallRuleOperations FirewallRules
        {
            get { return this._firewallRules; }
        }
        
        private IServerOperations _servers;
        
        /// <summary>
        /// The SQL Database Management API includes operations for managing
        /// SQL Database servers for a subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715271.aspx
        /// for more information)
        /// </summary>
        public virtual IServerOperations Servers
        {
            get { return this._servers; }
        }
        
        private IServiceObjectiveOperations _serviceObjectives;
        
        /// <summary>
        /// The SQL Database Management API includes operations for getting
        /// Service Objective for a subscription.
        /// </summary>
        public virtual IServiceObjectiveOperations ServiceObjectives
        {
            get { return this._serviceObjectives; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        private SqlManagementClient()
            : base()
        {
            this._dac = new DacOperations(this);
            this._databaseOperations = new DatabaseOperationOperations(this);
            this._databases = new DatabaseOperations(this);
            this._firewallRules = new FirewallRuleOperations(this);
            this._servers = new ServerOperations(this);
            this._serviceObjectives = new ServiceObjectiveOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Required. The URI used as the base for all SQL requests.
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        public SqlManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
    }
}
