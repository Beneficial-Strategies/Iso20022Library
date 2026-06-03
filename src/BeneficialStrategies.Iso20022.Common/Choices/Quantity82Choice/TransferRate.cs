// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Quantity82Choice
{
    /// <summary>Specifies the transfer rate.</summary>
    [IsoId("ee5ca458-191a-41e0-be61-3a033e1e3974")]
    [DisplayName("Transfer Rate")]
    public record TransferRate : Quantity82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TrfRate")]
        public required IsoPercentageRate Value { get; init; }
    }
}
