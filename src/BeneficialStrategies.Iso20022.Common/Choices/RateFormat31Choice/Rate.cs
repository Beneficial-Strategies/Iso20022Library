// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RateFormat31Choice
{
    /// <summary>Specifies the rate.</summary>
    [IsoId("__Ha5QajtEfCG_LQaXOxwew")]
    [DisplayName("Rate")]
    public record Rate : RateFormat31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rate")]
        public required IsoPercentage14Rate Value { get; init; }
    }
}
