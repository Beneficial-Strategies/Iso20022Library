// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.References83Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between transaction reference identifications.</summary>
    [IsoId("_WqDHEagzEfCXwLUUylXgrQ")]
    [DisplayName("References 83 Choice")]
    [KnownType(typeof(References83Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References83Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References83Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References83Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References83Choice.ProcessorTransactionIdentification))]
    [KnownType(typeof(References83Choice.PoolIdentification))]
    [KnownType(typeof(References83Choice.CommonIdentification))]
    [KnownType(typeof(References83Choice.TradeIdentification))]
    [KnownType(typeof(References83Choice.CorporateActionEventIdentification))]
    [JsonDerivedType(typeof(References83Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References83Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References83Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References83Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References83Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(typeof(References83Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References83Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References83Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References83Choice.CorporateActionEventIdentification))]
    public abstract record References83Choice_
    {
    }
}
