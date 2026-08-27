// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.TradingVenueIdentification4Choice
{
    /// <summary>Code used when a transaction on a financial instrument is executed on a Systematic Internaliser.</summary>
    [IsoId("_GrBldYTPEfClBYp_xDbOWg")]
    [DisplayName("Systematic Internaliser")]
    public record SystematicInternaliser : TradingVenueIdentification4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SystmtcIntlr")]
        public required TradingVenue5Code Value { get; init; }
    }
}
