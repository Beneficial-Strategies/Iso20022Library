// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason82Choice
{
    /// <summary>Pending reason in a proprietary form.</summary>
    [IsoId("_jGVR2bMZEfCEXew4g5B5oA")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
