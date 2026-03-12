// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References58Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References58Choice.PoolIdentification))]
    [KnownType(typeof(References58Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References58Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References58Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References58Choice.SecuritiesSettlementTransactionIdentification),nameof(References58Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References58Choice.PoolIdentification),nameof(References58Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References58Choice.IntraPositionMovementIdentification),nameof(References58Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References58Choice.AccountServicerTransactionIdentification),nameof(References58Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References58Choice.OtherTransactionIdentification),nameof(References58Choice.OtherTransactionIdentification))]
    [IsoId("_61RR85NLEeWGlc8L7oPDIg")]
    [DisplayName("References 58 Choice")]
    public abstract partial record References58Choice_
    {
    }
}
