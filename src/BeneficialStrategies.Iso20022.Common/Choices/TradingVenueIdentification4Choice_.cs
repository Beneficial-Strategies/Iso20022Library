// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification4Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Trade venue related fields.</summary>
    /// <remarks>
    /// Constraints (not separately modeled as properties — enforced by validators):
    /// ValidMICRule: Market Identification code must be an active market at the time of reporting.
    /// </remarks>
    [IsoId("_Gp0EgYTPEfClBYp_xDbOWg")]
    [DisplayName("Trading Venue Identification 4 Choice")]
    [KnownType(typeof(TradingVenueIdentification4Choice.MarketIdentificationCode))]
    [KnownType(typeof(TradingVenueIdentification4Choice.SystematicInternaliser))]
    [JsonDerivedType(typeof(TradingVenueIdentification4Choice.MarketIdentificationCode))]
    [JsonDerivedType(typeof(TradingVenueIdentification4Choice.SystematicInternaliser))]
    public abstract record TradingVenueIdentification4Choice_
    {
    }
}
