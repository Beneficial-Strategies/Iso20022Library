// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is rejected.</summary>
    [IsoId("bdfe7397-118b-4f7f-bd76-65887215d1ad")]
    [DisplayName("Rejected")]
    public record Rejected : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus14 Value { get; init; }
    }
}
