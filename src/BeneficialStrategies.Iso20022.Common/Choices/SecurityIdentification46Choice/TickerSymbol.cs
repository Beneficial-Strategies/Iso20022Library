// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification46Choice
{
    /// <summary>Ticker symbol identifier assigned by a stock exchange.</summary>
    [IsoId("00afed4a-51d6-4330-b026-bdb61d7776b9")]
    [DisplayName("Ticker Symbol")]
    public record TickerSymbol : SecurityIdentification46Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TckrSymb")]
        public required IsoTickerIdentifier Value { get; init; }
    }
}
