// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the pending settlement status.
    /// </summary>
    [KnownType(typeof(PendingSettlementStatus3Choice.Reason))]
    [KnownType(typeof(PendingSettlementStatus3Choice.ExtendedReason))]
    [KnownType(typeof(PendingSettlementStatus3Choice.DataSourceScheme))]
    [KnownType(typeof(PendingSettlementStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(
        typeof(PendingSettlementStatus3Choice.Reason),
        nameof(PendingSettlementStatus3Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(PendingSettlementStatus3Choice.ExtendedReason),
        nameof(PendingSettlementStatus3Choice.ExtendedReason)
    )]
    [JsonDerivedType(
        typeof(PendingSettlementStatus3Choice.DataSourceScheme),
        nameof(PendingSettlementStatus3Choice.DataSourceScheme)
    )]
    [JsonDerivedType(
        typeof(PendingSettlementStatus3Choice.NoSpecifiedReason),
        nameof(PendingSettlementStatus3Choice.NoSpecifiedReason)
    )]
    [IsoId("_LPufISY4EeW_ZNn8gbfY7Q")]
    [DisplayName("Pending Settlement Status 3 Choice")]
    public abstract record PendingSettlementStatus3Choice_ { }
}
