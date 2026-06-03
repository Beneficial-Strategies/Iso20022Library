// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus6Choice
{
    /// <summary>Status of the individual order is in repair.</summary>
    [IsoId("fd658f49-e8ab-442d-85b9-8b474ecc179f")]
    [DisplayName("In Repair")]
    public record InRepair : OrderStatus6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InRpr")]
        public required InRepairStatusReason4Choice_ Value { get; init; }
    }
}
