// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus4Choice
{
    /// <summary>
    /// Status of the switch order is rejected.
    /// </summary>
    [IsoId("_9wxHx0H8EeaV3ab_pHzFIQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : OrderStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_TJYC4EHjEea8I67lh6qdSQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public RejectedReason20Choice_? Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the rejected reason.
        /// </summary>
        [IsoId("_IsU1OUHjEea8I67lh6qdSQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
