// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the generated reason.</summary>
    [IsoId("c3c22dfd-080a-468a-a422-d3b33044250b")]
    [DisplayName("Generated Reason")]
    public record GeneratedReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("GnrtdRsn")]
        public required GeneratedReasons5Choice_ Value { get; init; }
    }
}
