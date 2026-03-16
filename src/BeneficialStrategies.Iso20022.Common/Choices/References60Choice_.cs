// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References60Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References60Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References60Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References60Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References60Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References60Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References60Choice.SecuritiesFinancingTransactionIdentification),
        nameof(References60Choice.SecuritiesFinancingTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References60Choice.IntraPositionMovementIdentification),
        nameof(References60Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References60Choice.OtherTransactionIdentification),
        nameof(References60Choice.OtherTransactionIdentification)
    )]
    [IsoId("_8T7An5NLEeWGlc8L7oPDIg")]
    [DisplayName("References 60 Choice")]
    public abstract record References60Choice_ { }
}
