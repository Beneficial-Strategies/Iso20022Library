// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderStatus5Choice
{
    /// <summary>
    /// Status of the individual order is partially settled.
    /// </summary>
    [IsoId("_P8YAnUHREeasdbKMiqizqA")]
    [DisplayName("Partially Settled")]
    public record PartiallySettled : OrderStatus5Choice_
    {
        /// <summary>
        /// Reason for the partially settled status.
        /// </summary>
        [IsoId("_I7aOg0HtEeaNSo9he0Belg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required PartiallySettled21Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the partially settled reason.
        /// </summary>
        [IsoId("_I7aOhUHtEeaNSo9he0Belg")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
