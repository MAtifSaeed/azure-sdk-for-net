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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Scheduler;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure
{
    public static partial class JobOperationsExtensions
    {
        /// <summary>
        /// Creates a new Job, allowing the service to generate a job id. Use
        /// CreateOrUpdate if a user-chosen job id is required.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters specifying the job definition for a Create Job
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        public static JobCreateResponse Create(this IJobOperations operations, JobCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Creates a new Job, allowing the service to generate a job id. Use
        /// CreateOrUpdate if a user-chosen job id is required.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters specifying the job definition for a Create Job
        /// operation.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        public static Task<JobCreateResponse> CreateAsync(this IJobOperations operations, JobCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new Job with a user-provided job id, or updates an
        /// existing job, replacing its definition with that specified.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters specifying the job definition for a
        /// CreateOrUpdate Job operation.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate Job operation response.
        /// </returns>
        public static JobCreateOrUpdateResponse CreateOrUpdate(this IJobOperations operations, string jobId, JobCreateOrUpdateParameters parameters)
        {
            try
            {
                return operations.CreateOrUpdateAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Creates a new Job with a user-provided job id, or updates an
        /// existing job, replacing its definition with that specified.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters specifying the job definition for a
        /// CreateOrUpdate Job operation.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate Job operation response.
        /// </returns>
        public static Task<JobCreateOrUpdateResponse> CreateOrUpdateAsync(this IJobOperations operations, string jobId, JobCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IJobOperations operations, string jobId)
        {
            try
            {
                return operations.DeleteAsync(jobId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IJobOperations operations, string jobId)
        {
            return operations.DeleteAsync(jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the definition and status of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        public static JobGetResponse Get(this IJobOperations operations, string jobId)
        {
            try
            {
                return operations.GetAsync(jobId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get the definition and status of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        public static Task<JobGetResponse> GetAsync(this IJobOperations operations, string jobId)
        {
            return operations.GetAsync(jobId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the execution history of a Job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Job History operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static JobGetHistoryResponse GetHistory(this IJobOperations operations, string jobId, JobGetHistoryParameters parameters)
        {
            try
            {
                return operations.GetHistoryAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get the execution history of a Job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Job History operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static Task<JobGetHistoryResponse> GetHistoryAsync(this IJobOperations operations, string jobId, JobGetHistoryParameters parameters)
        {
            return operations.GetHistoryAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the execution history of a Job with a filter on the job Status.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Job History With Filter
        /// operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static JobGetHistoryResponse GetHistoryWithFilter(this IJobOperations operations, string jobId, JobGetHistoryWithFilterParameters parameters)
        {
            try
            {
                return operations.GetHistoryWithFilterAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get the execution history of a Job with a filter on the job Status.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Get Job History With Filter
        /// operation.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        public static Task<JobGetHistoryResponse> GetHistoryWithFilterAsync(this IJobOperations operations, string jobId, JobGetHistoryWithFilterParameters parameters)
        {
            return operations.GetHistoryWithFilterAsync(jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all jobs in a job collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Jobs operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static JobListResponse List(this IJobOperations operations, JobListParameters parameters)
        {
            try
            {
                return operations.ListAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get the list of all jobs in a job collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Jobs operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static Task<JobListResponse> ListAsync(this IJobOperations operations, JobListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of jobs in a job collection matching a filter on job
        /// state.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Jobs with filter
        /// operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static JobListResponse ListWithFilter(this IJobOperations operations, JobListWithFilterParameters parameters)
        {
            try
            {
                return operations.ListWithFilterAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get the list of jobs in a job collection matching a filter on job
        /// state.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the List Jobs with filter
        /// operation.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        public static Task<JobListResponse> ListWithFilterAsync(this IJobOperations operations, JobListWithFilterParameters parameters)
        {
            return operations.ListWithFilterAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Update the state of all jobs in a job collections.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        public static JobCollectionJobsUpdateStateResponse UpdateJobCollectionState(this IJobOperations operations, PatchJobCollectionJobsUpdateStateParameters parameters)
        {
            try
            {
                return operations.UpdateJobCollectionStateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Update the state of all jobs in a job collections.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        public static Task<JobCollectionJobsUpdateStateResponse> UpdateJobCollectionStateAsync(this IJobOperations operations, PatchJobCollectionJobsUpdateStateParameters parameters)
        {
            return operations.UpdateJobCollectionStateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Update the state of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Job State operation.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        public static JobUpdateStateResponse UpdateState(this IJobOperations operations, string jobId, JobUpdateStateParameters parameters)
        {
            try
            {
                return operations.UpdateStateAsync(jobId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Update the state of a job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.WindowsAzure.Scheduler.IJobOperations.
        /// </param>
        /// <param name='jobId'>
        /// Required. Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Job State operation.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        public static Task<JobUpdateStateResponse> UpdateStateAsync(this IJobOperations operations, string jobId, JobUpdateStateParameters parameters)
        {
            return operations.UpdateStateAsync(jobId, parameters, CancellationToken.None);
        }
    }
}
