// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice
{
    /// <summary>Specific direct debit mandate data.</summary>
    [IsoId("_RH9EkbvIEfCYYbmqNrQFSg")]
    [DisplayName("Direct Debit Mandate")]
    public record DirectDebitMandate : MandateRelatedData5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DrctDbtMndt")]
        public required MandateRelatedInformation16 Value { get; init; }
    }
}
