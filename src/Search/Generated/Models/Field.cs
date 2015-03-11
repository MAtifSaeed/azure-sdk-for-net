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

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Represents a field in an index definition in Azure Search, which
    /// describes the name, data type, and search behavior of a field.  (see
    /// https://msdn.microsoft.com/en-us/library/azure/dn798941.aspx for more
    /// information)
    /// </summary>
    public partial class Field
    {
        private string _analyzer;
        
        /// <summary>
        /// Optional. Name of the text analyzer to use.  (see
        /// https://msdn.microsoft.com/en-us/library/azure/dn879793.aspx for
        /// more information)
        /// </summary>
        public string Analyzer
        {
            get { return this._analyzer; }
            set { this._analyzer = value; }
        }
        
        private bool _isFacetable;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether it is possible to
        /// facet on this field. Not valid for geo-point fields. Default is
        /// false.
        /// </summary>
        public bool IsFacetable
        {
            get { return this._isFacetable; }
            set { this._isFacetable = value; }
        }
        
        private bool _isFilterable;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether the field can be
        /// used in filter expressions. Default is false.
        /// </summary>
        public bool IsFilterable
        {
            get { return this._isFilterable; }
            set { this._isFilterable = value; }
        }
        
        private bool _isKey;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether the field is the
        /// key of the index. Valid only for string fields. Every index must
        /// have exactly one key field.
        /// </summary>
        public bool IsKey
        {
            get { return this._isKey; }
            set { this._isKey = value; }
        }
        
        private bool _isRetrievable;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether the field can be
        /// returned in a search result. Default is true.
        /// </summary>
        public bool IsRetrievable
        {
            get { return this._isRetrievable; }
            set { this._isRetrievable = value; }
        }
        
        private bool _isSearchable;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether the field is
        /// included in full-text searches. Valid only forstring or string
        /// collection fields. Default is false.
        /// </summary>
        public bool IsSearchable
        {
            get { return this._isSearchable; }
            set { this._isSearchable = value; }
        }
        
        private bool _isSortable;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether the field can be
        /// used in orderby expressions. Not valid for string collection
        /// fields. Default is false.
        /// </summary>
        public bool IsSortable
        {
            get { return this._isSortable; }
            set { this._isSortable = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the field.  (see
        /// https://msdn.microsoft.com/en-us/library/azure/dn857353.aspx for
        /// more information)
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Gets or sets the data type of the field.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Field class.
        /// </summary>
        public Field()
        {
            this.IsRetrievable = true;
        }
        
        /// <summary>
        /// Initializes a new instance of the Field class with required
        /// arguments.
        /// </summary>
        public Field(string name, string type)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.Name = name;
            this.Type = type;
        }
    }
}
