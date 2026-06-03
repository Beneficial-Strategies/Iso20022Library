// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RateFormat32Choice
{
    /// <summary>Specifies the rate.</summary>
    [IsoId("_k8O_8akHEfCG_LQaXOxwew")]
    [DisplayName("Rate")]
    public record Rate : RateFormat32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rate")]
        public required IsoPercentage14Rate Value { get; init; }
    }
}
