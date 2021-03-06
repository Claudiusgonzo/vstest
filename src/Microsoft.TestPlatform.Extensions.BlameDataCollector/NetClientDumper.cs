﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.TestPlatform.Extensions.BlameDataCollector
{
    using Microsoft.Diagnostics.NETCore.Client;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    internal class NetClientDumper : IHangDumper
    {
        public void Dump(int processId, string outputFile, DumpTypeOption type)
        {
            var client = new DiagnosticsClient(processId);

            // Connecting the dump generation logging to verbose output to avoid changing the interfaces again
            // before we test this on some big repo.
            client.WriteDump(type == DumpTypeOption.Full ? DumpType.Full : DumpType.Normal, outputFile, logDumpGeneration: EqtTrace.IsVerboseEnabled);
        }
    }
}
