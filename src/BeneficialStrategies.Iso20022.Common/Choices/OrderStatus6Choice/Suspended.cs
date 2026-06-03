// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is suspended.</summary>
    [IsoId("a816b339-a8db-4b4d-928c-8aa8c7502eec")]
    [DisplayName("Suspended")]
    public record Suspended : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Sspd")]
        public required SuspendedStatusReason4Choice_ Value { get; init; }
    }
}
