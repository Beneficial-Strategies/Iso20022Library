// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References6Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References6Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References6Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References6Choice.PoolIdentification))]
    [KnownType(typeof(References6Choice.CommonIdentification))]
    [KnownType(typeof(References6Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References6Choice.AccountServicerTransactionIdentification),nameof(References6Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.AccountOwnerTransactionIdentification),nameof(References6Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.MarketInfrastructureTransactionIdentification),nameof(References6Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.PoolIdentification),nameof(References6Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References6Choice.CommonIdentification),nameof(References6Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References6Choice.TradeIdentification),nameof(References6Choice.TradeIdentification))]
    [IsoId("_UTGx8Np-Ed-ak6NoX_4Aeg_1758264340")]
    [DisplayName("References 6 Choice")]
    public abstract partial record References6Choice_
    {
    }
}
