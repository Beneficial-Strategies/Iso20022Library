// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason80Choice
{
    /// <summary>Specifies the reason code why the instruction or request is pending, in proprietary form.</summary>
    [IsoId("_lyBX0aogEfCG2_q2WT-90w")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason80Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
