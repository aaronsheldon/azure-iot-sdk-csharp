﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Azure;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    /// <summary>
    /// Registration status.
    /// </summary>
    public class DeviceRegistrationState
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="registrationId">Registration Id</param>
        public DeviceRegistrationState(string registrationId)
        {
            RegistrationId = registrationId;
        }

        /// <summary>
        /// Registration Id.
        /// </summary>
        [JsonProperty("registrationId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegistrationId { get; protected internal set; }

        /// <summary>
        /// Registration create date time (in UTC).
        /// </summary>
        [JsonProperty("createdDateTimeUtc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? CreatedOnUtc { get; protected internal set; }

        /// <summary>
        /// Last updated date time (in UTC).
        /// </summary>
        [JsonProperty("lastUpdatedDateTimeUtc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? LastUpdatedOnUtc { get; protected internal set; }

        /// <summary>
        /// Assigned IoT hub.
        /// </summary>
        [JsonProperty("assignedHub", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AssignedHub { get; protected internal set; }

        /// <summary>
        /// Device Id.
        /// </summary>
        [JsonProperty("deviceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DeviceId { get; protected internal set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("status")]
        public EnrollmentStatus Status { get; protected internal set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty("errorCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ErrorCode { get; protected internal set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("errorMessage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ErrorMessage { get; protected internal set; }

        /// <summary>
        /// Registration status ETag.
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(NewtonsoftJsonETagConverter))] // NewtonsoftJsonETagConverter is used here because otherwise the ETag isn't serialized properly
        public ETag ETag { get; protected internal set; }
    }
}
