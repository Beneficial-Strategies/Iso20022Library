// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice
{
    /// <summary>
    /// Status of the individual order is rejected. This status is used for an order that has not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_P8YAmkHREeasdbKMiqizqA")]
    [DisplayName("Rejected")]
    public partial record Rejected : OrderStatus5Choice_
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
