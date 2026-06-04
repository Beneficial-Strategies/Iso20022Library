// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status43Choice
{
    /// <summary>Status expressed as a proprietary code.</summary>
    [IsoId("c16daf04-aac4-41ec-b817-edbf8fbf9f81")]
    [DisplayName("Proprietary")]
    public record Proprietary : Status43Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required ProprietaryStatusAndReason6 Value { get; init; }
    }
}
