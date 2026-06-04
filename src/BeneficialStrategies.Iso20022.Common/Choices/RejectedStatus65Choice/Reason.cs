// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus65Choice
{
    /// <summary>Specifies the reason for the rejected status.</summary>
    [IsoId("_V1Ri2aKvEfCHi7w3_0pcpw")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus65Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason64 Value { get; init; }
    }
}
