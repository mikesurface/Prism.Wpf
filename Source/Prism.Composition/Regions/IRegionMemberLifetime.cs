// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.Regions
{
    /// <summary>
    /// When implemented, allows an instance placed in a <see cref="IRegion"/>
    /// that uses a <see cref="RegionMemberLifetimeBehavior"/> to indicate
    /// it should be removed when it transitions from an activated to deactived state.
    /// </summary>
    public interface IRegionMemberLifetime
    {
        /// <summary>
        /// Gets a value indicating whether this instance should be kept-alive upon deactivation.
        /// </summary>
        bool KeepAlive { get; }
    }
}
