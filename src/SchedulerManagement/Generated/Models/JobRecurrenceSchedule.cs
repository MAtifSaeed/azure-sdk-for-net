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
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Recurrence schedule for the job.
    /// </summary>
    public partial class JobRecurrenceSchedule
    {
        private IList<JobScheduleDay> _days;
        
        /// <summary>
        /// Optional. Days of the week that the job should execute on.
        /// </summary>
        public IList<JobScheduleDay> Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        
        private IList<int> _hours;
        
        /// <summary>
        /// Optional. Hours of the day that the job should execute at.
        /// </summary>
        public IList<int> Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        
        private IList<int> _minutes;
        
        /// <summary>
        /// Optional. Minutes of the hour that the job should execute at.
        /// </summary>
        public IList<int> Minutes
        {
            get { return this._minutes; }
            set { this._minutes = value; }
        }
        
        private IList<int> _monthDays;
        
        /// <summary>
        /// Optional. Days of the month that the job should execute on.  Must
        /// be between 1 and 31.
        /// </summary>
        public IList<int> MonthDays
        {
            get { return this._monthDays; }
            set { this._monthDays = value; }
        }
        
        private IList<JobScheduleMonthlyOccurrence> _monthlyOccurrences;
        
        /// <summary>
        /// Optional. Occurrences of days within a month.
        /// </summary>
        public IList<JobScheduleMonthlyOccurrence> MonthlyOccurrences
        {
            get { return this._monthlyOccurrences; }
            set { this._monthlyOccurrences = value; }
        }
        
        private IList<int> _months;
        
        /// <summary>
        /// Optional. Months that the job should execute in.  Must be between 1
        /// and 12.
        /// </summary>
        public IList<int> Months
        {
            get { return this._months; }
            set { this._months = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobRecurrenceSchedule class.
        /// </summary>
        public JobRecurrenceSchedule()
        {
            this._days = new List<JobScheduleDay>();
            this._hours = new List<int>();
            this._minutes = new List<int>();
            this._monthDays = new List<int>();
            this._monthlyOccurrences = new List<JobScheduleMonthlyOccurrence>();
            this._months = new List<int>();
        }
    }
}
