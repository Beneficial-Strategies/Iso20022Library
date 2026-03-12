// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the renounceable entitlement status.
    /// </summary>
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat3Choice.Code))]
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(RenounceableEntitlementStatusTypeFormat3Choice.Code),nameof(RenounceableEntitlementStatusTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(RenounceableEntitlementStatusTypeFormat3Choice.Proprietary),nameof(RenounceableEntitlementStatusTypeFormat3Choice.Proprietary))]
    [IsoId("_63QroUEBEeWVgfuHGaKtRQ")]
    [DisplayName("Renounceable Entitlement Status Type Format 3 Choice")]
    public abstract partial record RenounceableEntitlementStatusTypeFormat3Choice_
    {
    }
}
