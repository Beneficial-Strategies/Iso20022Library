// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the renounceable entitlement status.
    /// </summary>
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat4Choice.Code))]
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RenounceableEntitlementStatusTypeFormat4Choice.Code),
        nameof(RenounceableEntitlementStatusTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RenounceableEntitlementStatusTypeFormat4Choice.Proprietary),
        nameof(RenounceableEntitlementStatusTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_c5Lh45KQEeWHWpTQn1FFVg")]
    [DisplayName("Renounceable Entitlement Status Type Format 4 Choice")]
    public abstract record RenounceableEntitlementStatusTypeFormat4Choice_ { }
}
