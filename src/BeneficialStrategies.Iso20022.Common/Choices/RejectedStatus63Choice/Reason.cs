// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus63Choice
{
    /// <summary>Specifies the reason for the rejected status.</summary>
    [IsoId("_0EZ85d78Ee-NrtAAlrBEgQ")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus63Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rsn")]
        public required RejectedStatusReason62 Value { get; init; }
    }
}
