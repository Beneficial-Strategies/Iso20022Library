// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RateFormat31Choice
{
    /// <summary>Specifies the not specified rate.</summary>
    [IsoId("__Ha5SajtEfCG_LQaXOxwew")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RateFormat31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType5Code Value { get; init; }
    }
}
