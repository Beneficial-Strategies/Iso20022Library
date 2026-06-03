// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason75Choice
{
    /// <summary>Specifies the reason why the instruction has a pending status in a proprietary form.</summary>
    [IsoId("_YQ2EaeSkEe-qVZLXW4RRBw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason75Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
