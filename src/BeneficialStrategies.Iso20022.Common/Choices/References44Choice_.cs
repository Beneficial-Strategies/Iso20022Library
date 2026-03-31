// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References44Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References44Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References44Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References44Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(
        typeof(References44Choice.OtherTransactionIdentification),
        nameof(References44Choice.OtherTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References44Choice.SecuritiesFinancingTransactionIdentification),
        nameof(References44Choice.SecuritiesFinancingTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References44Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References44Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References44Choice.IntraPositionMovementIdentification),
        nameof(References44Choice.IntraPositionMovementIdentification)
    )]
    [IsoId("_Hoo5QTqoEeWyoP0PbocV1Q")]
    [DisplayName("References 44 Choice")]
    public abstract record References44Choice_ { }
}
