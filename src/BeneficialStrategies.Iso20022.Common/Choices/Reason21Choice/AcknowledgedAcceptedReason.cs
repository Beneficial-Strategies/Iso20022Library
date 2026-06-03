// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the acknowledged accepted reason.</summary>
    [IsoId("d1db825f-7005-43fa-8f2d-e17becbfe391")]
    [DisplayName("Acknowledged Accepted Reason")]
    public record AcknowledgedAcceptedReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AckdAccptdRsn")]
        public required AcknowledgementReason12Choice_ Value { get; init; }
    }
}
