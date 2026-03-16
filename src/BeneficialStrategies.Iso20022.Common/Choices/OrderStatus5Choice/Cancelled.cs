// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice
{
    /// <summary>
    /// Status of the individual order is cancelled. This status is used for an order that has been accepted or that has been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_3MEL0UHUEeasdbKMiqizqA")]
    [DisplayName("Cancelled")]
    public record Cancelled : OrderStatus5Choice_
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
