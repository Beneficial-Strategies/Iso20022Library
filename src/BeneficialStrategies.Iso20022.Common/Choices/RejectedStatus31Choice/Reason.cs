// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus31Choice
{
    /// <summary>
    /// Reason why the meeting instruction cancellation request message or the individual meeting instruction cancellation request is rejected.
    /// </summary>
    [IsoId("_g_hzS7KgEemux5trsZcCpw")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatus31Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_2ZcXLbKgEemux5trsZcCpw")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason29Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Additional information about the rejection status.
        /// </summary>
        [IsoId("_2ZcXLLKgEemux5trsZcCpw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
