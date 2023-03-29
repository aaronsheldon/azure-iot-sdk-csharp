﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Azure.Devices.E2ETests
{
    public static class VerboseTestLogger
    {
        public static void WriteLine(string message)
        {
            if (EventSourceTestLogger.Log.IsEnabled())
            {
                EventSourceTestLogger.Log.TestVerboseMessage(message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
