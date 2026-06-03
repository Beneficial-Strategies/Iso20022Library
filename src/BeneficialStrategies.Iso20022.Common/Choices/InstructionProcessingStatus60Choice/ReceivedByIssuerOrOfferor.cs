// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus60Choice
{
    /// <summary>Instruction has been received and accepted by the issuer or offeror.</summary>
    [IsoId("_rt3LRY74EfCbNJ3GwkFTcw")]
    [DisplayName("Received By Issuer Or Offeror")]
    public record ReceivedByIssuerOrOfferor : InstructionProcessingStatus60Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RcvdByIssrOrOfferr")]
        public required ReceivedByIssuerOrOfferorStatus1 Value { get; init; }
    }
}
