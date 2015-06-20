﻿using Orchard;
using Orchard.Logging;

namespace IDeliverable.Licensing.Orchard
{
    public interface ILicensedProductManifest : IDependency
    {
        string ProductId { get; }
        string ProductName { get; }
        string ExtensionId { get; }
        bool SkipValidationForLocalRequests { get; }
        string LicenseKey { get; }
        ILogger Logger { get; }
    }
}