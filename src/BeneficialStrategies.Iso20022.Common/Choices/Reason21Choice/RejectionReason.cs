// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the rejection reason.</summary>
    [IsoId("1623dc95-f527-45c8-8272-d82447669f66")]
    [DisplayName("Rejection Reason")]
    public record RejectionReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RjctnRsn")]
        public required RejectionReason45Choice_ Value { get; init; }
    }
}
