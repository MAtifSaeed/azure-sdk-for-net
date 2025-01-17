﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Pipeline;

namespace Azure.Storage.Blobs.Specialized
{
    /// <summary>
    /// The x-ms-version header needs to be stripped from batched
    /// sub-operations.
    /// </summary>
    internal class RemoveVersionHeaderPolicy : SynchronousHttpPipelinePolicy
    {
        /// <summary>
        /// Shared instance of the policy.
        /// </summary>
        public static HttpPipelinePolicy Shared { get; } = new RemoveVersionHeaderPolicy();

        /// <summary>
        /// Optionally remove ClientRequestId.  This is a workaround for test
        /// recordings which need repeatable x-ms-client-request-id values in
        /// the sub-operations.
        /// </summary>
        internal bool RemoveClientRequestIdHeaders { get; set; } = false;

        /// <inheritdoc />
        public override void OnSendingRequest(HttpPipelineMessage message)
        {
            base.OnSendingRequest(message);
            message.Request.Headers.Remove(BatchConstants.XmsVersionName);
            if (RemoveClientRequestIdHeaders)
            {
                message.Request.Headers.Remove(BatchConstants.XmsClientRequestIdName);
                message.Request.Headers.Remove(BatchConstants.XmsReturnClientRequestIdName);
            }
        }
    }
}
