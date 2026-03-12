// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status14Choice
{
    /// <summary>
    /// Status of the order is rejected.
    /// </summary>
    [IsoId("_Hri4Mx6rEeODgY9qxg6TFA")]
    [DisplayName("Rejected")]
    public partial record Rejected : Status14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_w8B4ESP0EeO-CsDf20Q5hg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectedReason4Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the rejected status reason.
        /// </summary>
        [IsoId("_w8B4GSP0EeO-CsDf20Q5hg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
