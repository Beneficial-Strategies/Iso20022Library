// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason67Choice
{
    /// <summary>Specifies the proprietary value.</summary>
    [IsoId("a6f96671-1d11-4a93-8e8b-dad4bfb5e076")]
    [DisplayName("Proprietary")]
    public record Proprietary : RejectedReason67Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
