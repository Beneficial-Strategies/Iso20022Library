// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat25Choice
{
    /// <summary>Standard code to specify the additional business process linked to a corporate action event.</summary>
    [IsoId("_beEykaNYEfC9id413JK-Ig")]
    [DisplayName("Code")]
    public record Code : AdditionalBusinessProcessFormat25Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess13Code Value { get; init; }
    }
}
