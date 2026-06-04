// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.StatusReason7Choice
{
    /// <summary>Status reason expressed as a code.</summary>
    [IsoId("_nLSClqkxEeynsLtPxJMJTQ")]
    [DisplayName("Code")]
    public record Code : StatusReason7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalCollateralReferenceDataStatusReason1Code Value { get; init; }
    }
}
