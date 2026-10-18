// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice
{
    /// <inheritdoc cref="ICreditTransferMandate"/>
    [IsoId("_RH9Ek7vIEfCYYbmqNrQFSg")]
    [DisplayName("Credit Transfer Mandate")]
    public partial record CreditTransferMandate : MandateRelatedData5Choice_
    {
        /// <inheritdoc cref="ICreditTransferMandate.Value"/>
        [IsoXmlTag("CdtTrfMndt")]
        public required CreditTransferMandateData1 Value { get; init; }
    }
}
