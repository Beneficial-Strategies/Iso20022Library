// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice
{
    /// <inheritdoc cref="IDirectDebitMandate"/>
    [IsoId("_RH9EkbvIEfCYYbmqNrQFSg")]
    [DisplayName("Direct Debit Mandate")]
    public partial record DirectDebitMandate : MandateRelatedData5Choice_
    {
        /// <inheritdoc cref="IDirectDebitMandate.Value"/>
        [IsoXmlTag("DrctDbtMndt")]
        public required MandateRelatedInformation16 Value { get; init; }
    }
}
