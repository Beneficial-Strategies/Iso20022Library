// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice
{
    /// <summary>Specific credit transfer mandate data.</summary>
    [IsoId("_RH9Ek7vIEfCYYbmqNrQFSg")]
    [DisplayName("Credit Transfer Mandate")]
    public record CreditTransferMandate : MandateRelatedData5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfMndt")]
        public required CreditTransferMandateData1 Value { get; init; }
    }
}
