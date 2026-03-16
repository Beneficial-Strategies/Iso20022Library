// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References4Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References4Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References4Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References4Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(
        typeof(References4Choice.OtherTransactionIdentification),
        nameof(References4Choice.OtherTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References4Choice.SecuritiesFinancingTransactionIdentification),
        nameof(References4Choice.SecuritiesFinancingTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References4Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References4Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References4Choice.IntraPositionMovementIdentification),
        nameof(References4Choice.IntraPositionMovementIdentification)
    )]
    [IsoId("_UR6fK9p-Ed-ak6NoX_4Aeg_1775353480")]
    [DisplayName("References 4 Choice")]
    public abstract record References4Choice_ { }
}
