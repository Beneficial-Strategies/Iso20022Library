// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus8Choice
{
    /// <summary>Status of the order is rejected.</summary>
    [IsoId("9c5c0fdc-1ec7-46bc-a610-db82e7b6913f")]
    [DisplayName("Rejected")]
    public record Rejected : OrderStatus8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus14 Value { get; init; }
    }
}
