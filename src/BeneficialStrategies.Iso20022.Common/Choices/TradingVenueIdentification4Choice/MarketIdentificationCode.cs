// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification4Choice
{
    /// <summary>Identification used where reporting entity uses a market identification code (MIC).</summary>
    [IsoId("_GrBlc4TPEfClBYp_xDbOWg")]
    [DisplayName("Market Identification Code")]
    public record MarketIdentificationCode : TradingVenueIdentification4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MktIdCd")]
        public required IsoMICIdentifier Value { get; init; }
    }
}
