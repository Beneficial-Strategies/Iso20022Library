// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice
{
    /// <summary>
    /// Status of all the orders in the order message is rejected. This status is used for orders that have not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_vIDnZ0H7EeaV3ab_pHzFIQ")]
    [DisplayName("Rejected")]
    public record Rejected : OrderStatus3Choice_
    {
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
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
