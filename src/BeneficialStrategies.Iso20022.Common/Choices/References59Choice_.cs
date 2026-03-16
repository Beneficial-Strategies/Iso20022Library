// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References59Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References59Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References59Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References59Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(
        typeof(References59Choice.OtherTransactionIdentification),
        nameof(References59Choice.OtherTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References59Choice.SecuritiesFinancingTransactionIdentification),
        nameof(References59Choice.SecuritiesFinancingTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References59Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References59Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References59Choice.IntraPositionMovementIdentification),
        nameof(References59Choice.IntraPositionMovementIdentification)
    )]
    [IsoId("_8ScaD5NLEeWGlc8L7oPDIg")]
    [DisplayName("References 59 Choice")]
    public abstract record References59Choice_ { }
}
