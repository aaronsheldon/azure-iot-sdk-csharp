﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Client
{
    /// <summary>
    /// The information provided from IoT hub that can be used with the Azure Storage SDK
    /// to upload a file from this client application.
    /// </summary>
    public class FileUploadSasUriResponse
    {
        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        /// <remarks>
        /// This class can be inherited from and set by unit tests for mocking purposes.
        /// </remarks>
        protected internal FileUploadSasUriResponse()
        {
        }

        /// <summary>
        /// The correlation id to use when notifying IoT hub later once this file upload has completed.
        /// </summary>
        [JsonProperty("correlationId")]
        public string CorrelationId { get; protected internal set; }

        /// <summary>
        /// The host name of the storage account that the file can be uploaded to.
        /// </summary>
        [JsonProperty("hostName")]
        public string HostName { get; protected internal set; }

        /// <summary>
        /// The container in the storage account that the file can be uploaded to.
        /// </summary>
        [JsonProperty("containerName")]
        public string ContainerName { get; protected internal set; }

        /// <summary>
        /// The name of the blob in the container that the file can be uploaded to.
        /// </summary>
        [JsonProperty("blobName")]
        public string BlobName { get; protected internal set; }

        /// <summary>
        /// The sas token to use for authentication while using the Azure Storage SDK to upload the file.
        /// </summary>
        [JsonProperty("sasToken")]
        public string SasToken { get; protected internal set; }

        /// <summary>
        /// Get the complete Uri for the blob that can be uploaded to from this device. This Uri includes credentials, too.
        /// </summary>
        /// <returns>The complete Uri for the blob that can be uploaded to from this device</returns>
        public virtual Uri GetBlobUri()
        {
            return new Uri(
                string.Format(
                    CultureInfo.InvariantCulture,
                    "https://{0}/{1}/{2}{3}",
                    HostName,
                    ContainerName,
                    Uri.EscapeDataString(BlobName), // Pass URL encoded device name and blob name to support special characters
                    SasToken));
        }
    }
}
