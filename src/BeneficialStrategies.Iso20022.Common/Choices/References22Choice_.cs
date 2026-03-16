// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References22Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References22Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References22Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References22Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(
        typeof(References22Choice.OtherTransactionIdentification),
        nameof(References22Choice.OtherTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References22Choice.SecuritiesFinancingTransactionIdentification),
        nameof(References22Choice.SecuritiesFinancingTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References22Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References22Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References22Choice.IntraPositionMovementIdentification),
        nameof(References22Choice.IntraPositionMovementIdentification)
    )]
    [IsoId("_H4smNk-2EeCKyoyCaiI0rw")]
    [DisplayName("References 22 Choice")]
    public abstract record References22Choice_ { }
}
