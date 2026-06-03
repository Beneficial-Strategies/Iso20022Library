// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus7Choice
{
    /// <summary>Status of the switch order is rejected.</summary>
    [IsoId("5597f78a-e863-4e81-ac60-aacd9a8812b0")]
    [DisplayName("Rejected")]
    public record Rejected : OrderStatus7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus14 Value { get; init; }
    }
}
