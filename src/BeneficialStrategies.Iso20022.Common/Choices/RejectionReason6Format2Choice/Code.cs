// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason6Format2Choice
{
    /// <summary>Rejection reason expressed as a code.</summary>
    [IsoId("_92p3caUoEfCnE_wCEfCqTA")]
    [DisplayName("Code")]
    public record Code : RejectionReason6Format2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required IssuerAgentRejection1Code Value { get; init; }
    }
}
