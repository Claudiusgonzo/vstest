// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel.Client
{
    /// <summary>
    /// Interface contract for handling multi test run finalization events
    /// </summary>
    public interface IMultiTestRunFinalizationEventsHandler : ITestMessageEventHandler
    {
        /// <summary>
        /// Dispatch MultiTestRunFinalizationComplete event to listeners.
        /// </summary>
        /// <param name="finalizationCompleteEventArgs">Finalization Complete event args.</param>
        /// <param name="attachments">Last set of processed attachment sets.</param>
        void HandleMultiTestRunFinalizationComplete(MultiTestRunFinalizationCompleteEventArgs finalizationCompleteEventArgs, IEnumerable<AttachmentSet> lastChunk);

        /// <summary>
        /// Dispatch ProcessedAttachmentsChunk event to listeners.
        /// </summary>
        /// <param name="attachments">Processed attachment sets.</param>
        void HandleProcessedAttachmentsChunk(IEnumerable<AttachmentSet> attachments);

        /// <summary>
        /// Dispatch MultiTestRunFinalizationProgress event to listeners.
        /// </summary>
        /// <param name="finalizationProgressEventArgs">Finalization Progress event args.</param>
        void HandleMultiTestRunFinalizationProgress(MultiTestRunFinalizationProgressEventArgs finalizationProgressEventArgs);
    }
}