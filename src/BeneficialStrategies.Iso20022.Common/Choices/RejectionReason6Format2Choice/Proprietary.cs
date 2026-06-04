// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason6Format2Choice
{
    /// <summary>Rejection reason expressed as a proprietary code.</summary>
    [IsoId("_92p3c6UoEfCnE_wCEfCqTA")]
    [DisplayName("Proprietary")]
    public record Proprietary : RejectionReason6Format2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
