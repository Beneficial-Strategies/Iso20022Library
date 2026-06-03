// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Specifies the compensation for a valuation request.</summary>
    [IsoId("19eaf331-a2f8-401f-a7b5-e885c6d033d0")]
    [DisplayName("Valuation")]
    public record Valuation : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Valtn")]
        public required AdjustmentCompensation1 Value { get; init; }
    }
}
