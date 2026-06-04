// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus64Choice
{
    /// <summary>Specifies the reason for the rejected status.</summary>
    [IsoId("_5CDhCaKsEfCHi7w3_0pcpw")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus64Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason63 Value { get; init; }
    }
}
