﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Sql.RecommendedAction.Cmdlet
{
    /// <summary>
    /// Allowed values for updating Recommended Action State
    /// </summary>
    public enum RecommendedActionStateValues
    {
        /// <summary>
        /// To cancel the inititiated recommended action while it's not yet applied, or to un-ignore an ignored recommended action.
        /// </summary>
        Active,

        /// <summary>
        /// To initiate applying recommended action.
        /// </summary>
        Pending,

        /// <summary>
        /// To start reverting the applied recommended action.
        /// </summary>
        PendingRevert,

        /// <summary>
        /// To cancel the initiated revert action.
        /// </summary>
        RevertCancelled,

        /// <summary>
        /// To ignore the recommended action
        /// </summary>
        Ignored,

        /// <summary>
        /// To indicate if customer has manually applied the recommendation and wants to resolve the recommended action.
        /// </summary>
        Resolved
    }
}
