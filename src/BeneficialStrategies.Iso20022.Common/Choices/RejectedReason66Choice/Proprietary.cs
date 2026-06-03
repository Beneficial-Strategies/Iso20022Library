// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason66Choice
{
    /// <summary>Specifies the proprietary value.</summary>
    [IsoId("89a7a1e4-288a-4942-b7ca-a509f9a68136")]
    [DisplayName("Proprietary")]
    public record Proprietary : RejectedReason66Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
