// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData4Choice
{
    /// <summary>Specific direct debit mandate data.</summary>
    [IsoId("_MPNCYbvHEfCYYbmqNrQFSg")]
    [DisplayName("Direct Debit Mandate")]
    public record DirectDebitMandate : MandateRelatedData4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DrctDbtMndt")]
        public required MandateRelatedInformation15 Value { get; init; }
    }
}
