﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    /// <summary>
    /// The JSON object for bulk individual enrollment operations.
    /// </summary>
    internal sealed class IndividualEnrollmentBulkOperation
    {
        /// <summary>
        /// Operation mode
        /// </summary>
        [JsonProperty("mode", Required = Required.Always)]
        internal BulkOperationMode Mode { get; set; }

        /// <summary>
        /// Enrollments for bulk operation
        /// </summary>
        [JsonProperty("enrollments", Required = Required.Always)]
        internal IList<IndividualEnrollment> Enrollments { get; set; }
    }
}
