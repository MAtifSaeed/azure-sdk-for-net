namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    public static partial class AvailabilitySetsOperationsExtensions
    {
            /// <summary>
            /// The operation to delete the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static void Delete(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                Task.Factory.StartNew(s => ((IAvailabilitySetsOperations)s).DeleteAsync(resourceGroupName, availabilitySetName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to get the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static AvailabilitySet Get(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                return Task.Factory.StartNew(s => ((IAvailabilitySetsOperations)s).GetAsync(resourceGroupName, availabilitySetName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<AvailabilitySet> GetAsync( this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AvailabilitySet> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to list the availability sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static AvailabilitySetListResult List(this IAvailabilitySetsOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IAvailabilitySetsOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to list the availability sets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<AvailabilitySetListResult> ListAsync( this IAvailabilitySetsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AvailabilitySetListResult> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists virtual-machine-sizes available to be used for an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            public static VirtualMachineSizeListResult ListAvailableSizes(this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName)
            {
                return Task.Factory.StartNew(s => ((IAvailabilitySetsOperations)s).ListAvailableSizesAsync(resourceGroupName, availabilitySetName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists virtual-machine-sizes available to be used for an availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='availabilitySetName'>
            /// The name of the availability set.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineSizeListResult> ListAvailableSizesAsync( this IAvailabilitySetsOperations operations, string resourceGroupName, string availabilitySetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineSizeListResult> result = await operations.ListAvailableSizesWithHttpMessagesAsync(resourceGroupName, availabilitySetName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to create or update the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            public static AvailabilitySet CreateOrUpdate(this IAvailabilitySetsOperations operations, string resourceGroupName, string name, AvailabilitySet parameters)
            {
                return Task.Factory.StartNew(s => ((IAvailabilitySetsOperations)s).CreateOrUpdateAsync(resourceGroupName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the availability set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Availability Set operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<AvailabilitySet> CreateOrUpdateAsync( this IAvailabilitySetsOperations operations, string resourceGroupName, string name, AvailabilitySet parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<AvailabilitySet> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
