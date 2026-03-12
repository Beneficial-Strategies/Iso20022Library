// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus44Choice
{
    /// <summary>
    /// Reason why the meeting instruction message or the individual meeting instruction is rejected.
    /// </summary>
    [IsoId("_iCQ4aRrpEeyhRdHRjakS2w")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatus44Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_iW99ExrpEeyhRdHRjakS2w")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason44Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Additional information about the rejection status.
        /// </summary>
        [IsoId("_iW99GxrpEeyhRdHRjakS2w")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
