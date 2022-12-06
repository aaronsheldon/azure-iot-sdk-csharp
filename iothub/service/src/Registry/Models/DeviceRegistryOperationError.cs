﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;

namespace Microsoft.Azure.Devices
{
    /// <summary>
    /// Encapsulates device registry operation error details.
    /// </summary>
    public sealed class DeviceRegistryOperationError
    {
        /// <summary>
        /// The Id of the device that indicated the error.
        /// </summary>
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; internal set; }

        /// <summary>
        /// Module Id on the device that indicated the error.
        /// </summary>
        [JsonProperty("moduleId", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; internal set; }

        /// <summary>
        /// Error code associated with the error.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public IotHubServiceErrorCode ErrorCode { get; internal set; }

        /// <summary>
        /// Additional details associated with the error.
        /// </summary>
        [JsonProperty("errorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorStatus { get; internal set; }
    }
}
