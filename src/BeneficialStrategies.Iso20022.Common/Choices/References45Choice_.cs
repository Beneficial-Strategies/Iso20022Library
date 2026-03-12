// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References45Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References45Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References45Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References45Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References45Choice.SecuritiesSettlementTransactionIdentification),nameof(References45Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References45Choice.SecuritiesFinancingTransactionIdentification),nameof(References45Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References45Choice.IntraPositionMovementIdentification),nameof(References45Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References45Choice.OtherTransactionIdentification),nameof(References45Choice.OtherTransactionIdentification))]
    [IsoId("_RbgB0ztpEeWHYdqXF6YZmg")]
    [DisplayName("References 45 Choice")]
    public abstract partial record References45Choice_
    {
    }
}
