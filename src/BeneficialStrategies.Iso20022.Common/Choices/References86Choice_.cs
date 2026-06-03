// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.References86Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between transaction reference identifications.</summary>
    [IsoId("59f62404-eed2-4203-a9be-b65e7a4df2dc")]
    [DisplayName("References 86 Choice")]
    [KnownType(typeof(References86Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References86Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References86Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References86Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References86Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References86Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References86Choice.PoolIdentification))]
    [KnownType(typeof(References86Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References86Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References86Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References86Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References86Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References86Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References86Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References86Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References86Choice.OtherTransactionIdentification))]
    public abstract record References86Choice_
    {
    }
}
