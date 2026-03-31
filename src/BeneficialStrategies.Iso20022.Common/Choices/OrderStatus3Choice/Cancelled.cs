// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus3Choice
{
    /// <summary>
    /// Status of all the orders in the order message is cancelled. This status is used for orders that have been accepted or that have been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_vIDnY0H7EeaV3ab_pHzFIQ")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public record Cancelled : OrderStatus3Choice_
    {
        /// <summary>
        /// Reason for the cancelled status.
        /// </summary>
        [IsoId("_YZCuGUHVEeasdbKMiqizqA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public CancelledReason12Choice_? Reason { get; init; }

        /// <summary>
        /// Additional information about the cancelled status.
        /// </summary>
        [IsoId("_YZDVI0HVEeasdbKMiqizqA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
