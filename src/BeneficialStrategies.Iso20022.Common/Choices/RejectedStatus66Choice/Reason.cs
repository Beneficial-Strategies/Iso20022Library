// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus66Choice
{
    /// <summary>Specifies the reason for the rejected status.</summary>
    [IsoId("_EMRclajVEfCzuLlmLrhIvA")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus66Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason65 Value { get; init; }
    }
}
