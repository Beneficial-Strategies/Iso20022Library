// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.References82Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between transaction reference identifications.</summary>
    [IsoId("_4KL_EeSlEe-qVZLXW4RRBw")]
    [DisplayName("References 82 Choice")]
    [KnownType(typeof(References82Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References82Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References82Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References82Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References82Choice.ProcessorTransactionIdentification))]
    [KnownType(typeof(References82Choice.PoolIdentification))]
    [KnownType(typeof(References82Choice.CorporateActionEventIdentification))]
    [JsonDerivedType(typeof(References82Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References82Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References82Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References82Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References82Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(typeof(References82Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References82Choice.CorporateActionEventIdentification))]
    public abstract record References82Choice_
    {
    }
}
