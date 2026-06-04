// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement14Choice
{
    /// <summary>Expressed as a status advice.</summary>
    [IsoId("_JgawFaowEfCG2_q2WT-90w")]
    [DisplayName("Status Advice")]
    public record StatusAdvice : StatusOrStatement14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("StsAdvc")]
        public required DocumentNumber22 Value { get; init; }
    }
}
