// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus106Choice
{
    /// <summary>Specifies the completed status.</summary>
    [IsoId("_lrsGXaogEfCG2_q2WT-90w")]
    [DisplayName("Completed")]
    public record Completed : ProcessingStatus106Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cmpltd")]
        public required ProprietaryReason4 Value { get; init; }
    }
}
