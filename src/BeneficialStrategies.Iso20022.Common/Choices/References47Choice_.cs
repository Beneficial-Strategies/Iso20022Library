// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References47Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References47Choice.PoolIdentification))]
    [KnownType(typeof(References47Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References47Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References47Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References47Choice.SecuritiesSettlementTransactionIdentification),nameof(References47Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References47Choice.PoolIdentification),nameof(References47Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References47Choice.IntraPositionMovementIdentification),nameof(References47Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References47Choice.AccountServicerTransactionIdentification),nameof(References47Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References47Choice.OtherTransactionIdentification),nameof(References47Choice.OtherTransactionIdentification))]
    [IsoId("_JqlFATzbEeWeNtT0s2RbkQ")]
    [DisplayName("References 47 Choice")]
    public abstract partial record References47Choice_
    {
    }
}
