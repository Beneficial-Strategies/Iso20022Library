// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData4Choice
{
    /// <summary>Specific credit transfer mandate data.</summary>
    [IsoId("_MPNCY7vHEfCYYbmqNrQFSg")]
    [DisplayName("Credit Transfer Mandate")]
    public record CreditTransferMandate : MandateRelatedData4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CdtTrfMndt")]
        public required CreditTransferMandateData1 Value { get; init; }
    }
}
