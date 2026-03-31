// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the failed settlement status.
    /// </summary>
    [KnownType(typeof(FailedSettlementStatus2Choice.Reason))]
    [KnownType(typeof(FailedSettlementStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(FailedSettlementStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(
        typeof(FailedSettlementStatus2Choice.Reason),
        nameof(FailedSettlementStatus2Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(FailedSettlementStatus2Choice.DataSourceScheme),
        nameof(FailedSettlementStatus2Choice.DataSourceScheme)
    )]
    [JsonDerivedType(
        typeof(FailedSettlementStatus2Choice.NoSpecifiedReason),
        nameof(FailedSettlementStatus2Choice.NoSpecifiedReason)
    )]
    [IsoId("_DOTJ4SY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Failed Settlement Status 2 Choice")]
    public abstract record FailedSettlementStatus2Choice_ { }
}
