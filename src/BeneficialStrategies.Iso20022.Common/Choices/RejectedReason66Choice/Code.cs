// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason66Choice
{
    /// <summary>Specifies the code.</summary>
    [IsoId("5cc44333-82cf-4dca-af9d-922da5e18a8b")]
    [DisplayName("Code")]
    public record Code : RejectedReason66Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required RejectedStatusReason14Code Value { get; init; }
    }
}
