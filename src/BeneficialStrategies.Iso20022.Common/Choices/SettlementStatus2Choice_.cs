// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus2Choice.Pending))]
    [KnownType(typeof(SettlementStatus2Choice.Failing))]
    [KnownType(typeof(SettlementStatus2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementStatus2Choice.Pending),
        nameof(SettlementStatus2Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus2Choice.Failing),
        nameof(SettlementStatus2Choice.Failing)
    )]
    [JsonDerivedType(
        typeof(SettlementStatus2Choice.Proprietary),
        nameof(SettlementStatus2Choice.Proprietary)
    )]
    [IsoId("_UZ9n4dp-Ed-ak6NoX_4Aeg_-647907102")]
    [DisplayName("Settlement Status 2 Choice")]
    public abstract record SettlementStatus2Choice_ { }
}
