// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.Reason21Choice
{
    /// <summary>Specifies the denied reason.</summary>
    [IsoId("5fd4ea92-28c9-4a79-8141-db80a7690861")]
    [DisplayName("Denied Reason")]
    public record DeniedReason : Reason21Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DndRsn")]
        public required DeniedReason14Choice_ Value { get; init; }
    }
}
