// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption47Choice
{
    /// <summary>Standard code to specify the type of corporate action options.</summary>
    [IsoId("_Rh3a8Q7VEfC-6PbsYHIdig")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption47Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption18Code Value { get; init; }
    }
}
