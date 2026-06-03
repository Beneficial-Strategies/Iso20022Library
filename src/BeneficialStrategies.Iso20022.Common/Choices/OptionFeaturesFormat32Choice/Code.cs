// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat32Choice
{
    /// <summary>Standard code to specify the features that may apply to a corporate action option.</summary>
    [IsoId("60111b9d-7b5e-4d0c-95f4-aa7b383ad3ab")]
    [DisplayName("Code")]
    public record Code : OptionFeaturesFormat32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required OptionFeatures15Code Value { get; init; }
    }
}
