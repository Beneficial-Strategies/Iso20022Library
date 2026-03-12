// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reference2Choice
{
    /// <summary>
    /// Choice between the identification of the MarginCallRequest message, the MarginCallResponse message, the CollateralProposal message, the CollateralProposalResponse message, the CollateralSubstitutionRequest message, the CollateralSubstitutionResponse message, the CollateralSubstitutionConfirmation message, the InterestPaymentRequest message, the InterestPaymentResponse message, the InterestPaymentStatement message or the MarginCallDisputeNotification message.
    /// </summary>
    [IsoId("_TYW3lKerEeCq2KR6DaC1kQ_1953851275")]
    [DisplayName("Collateral Substitution Request Identification")]
    public partial record CollateralSubstitutionRequestIdentification : Reference2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("CollSbstitnReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
