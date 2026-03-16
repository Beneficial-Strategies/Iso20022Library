// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceSourceFormatChoice
{
    /// <summary>
    /// Source of a price quotation when it is not the local market.
    /// </summary>
    [IsoId("_RCDQ5dp-Ed-ak6NoX_4Aeg_1149070716")]
    [DisplayName("Non Local Market Place")]
    public record NonLocalMarketPlace : PriceSourceFormatChoice_
    {
        /// <summary>
        /// Source of the price.
        /// </summary>
        [IsoXmlTag("PricSrc")]
        public required PriceSource1Code Value { get; init; }

        /// <summary>
        /// Additional information about the source of a price.
        /// </summary>
        [IsoId("_QelXcdp-Ed-ak6NoX_4Aeg_404714109")]
        [DisplayName("Narrative")]
        [IsoXmlTag("Nrrtv")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Narrative { get; init; }
    }
}
