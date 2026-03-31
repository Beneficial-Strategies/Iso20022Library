// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat59Choice
{
    /// <summary>
    /// Price expressed as a percentage.
    /// </summary>
    [IsoId("_ctkvA5KQEeWHWpTQn1FFVg")]
    [DisplayName("Percentage Price")]
    [IsoXmlTag("PctgPric")]
    public record PercentagePrice : PriceFormat59Choice_
    {
        /// <summary>
        /// Specifies the type of percentage price.
        /// </summary>
        [IsoId("_QaaCENp-Ed-ak6NoX_4Aeg_724274055")]
        [DisplayName("Percentage Price Type")]
        [IsoXmlTag("PctgPricTp")]
        public required PriceRateType3Code PercentagePriceType { get; init; }

        /// <summary>
        /// Specifies the value of price.
        /// </summary>
        [IsoId("_QaaCEdp-Ed-ak6NoX_4Aeg_724274080")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate PriceValue { get; init; }
    }
}
