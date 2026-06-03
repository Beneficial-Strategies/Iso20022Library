// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason77Choice
{
    /// <summary>Specifies the reason why a cancellation request sent for the related instruction is pending, in proprietary form.</summary>
    [IsoId("30a69507-11bf-4e1b-b005-1ef4e1315c81")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason77Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
