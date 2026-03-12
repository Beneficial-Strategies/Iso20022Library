// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingReason3Choice
{
    /// <summary>
    /// Specifies the reason of the RejectedStatus.
    /// </summary>
    [IsoId("_yJDK4warEe2phaVG0lYKTw")]
    [DisplayName("Reason")]
    public partial record Reason : InstructionProcessingReason3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected status.
        /// </summary>
        [IsoId("_yZlhQAarEe2phaVG0lYKTw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason52Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_yZlhSAarEe2phaVG0lYKTw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
