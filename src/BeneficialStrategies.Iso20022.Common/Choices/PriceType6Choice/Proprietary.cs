// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceType6Choice
{
    /// <summary>Specifies the price type as a proprietary value.</summary>
    [IsoId("50248a8f-4efa-4d13-8a2e-76d62fe0be71")]
    [DisplayName("Proprietary")]
    public record Proprietary : PriceType6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
