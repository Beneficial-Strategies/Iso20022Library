// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat32Choice
{
    /// <summary>Proprietary identification of the features that may apply to a corporate action option.</summary>
    [IsoId("6815f721-35ee-4796-9ec2-efe38e5c96eb")]
    [DisplayName("Proprietary")]
    public record Proprietary : OptionFeaturesFormat32Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
