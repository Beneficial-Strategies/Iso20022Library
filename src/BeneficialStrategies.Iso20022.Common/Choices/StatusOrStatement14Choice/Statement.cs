// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement14Choice
{
    /// <summary>Expressed as a statement.</summary>
    [IsoId("_JgawG6owEfCG2_q2WT-90w")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Stmt")]
        public required DocumentNumber13 Value { get; init; }
    }
}
