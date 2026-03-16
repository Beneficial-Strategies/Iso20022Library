// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice
{
    /// <summary>
    /// The ratio is expressed as a quantity per another quantity.
    /// </summary>
    [IsoId("_Rj3khNp-Ed-ak6NoX_4Aeg_1125895682")]
    [DisplayName("Quantity To Quantity")]
    public record QuantityToQuantity : RatioFormat2Choice_
    {
        /// <summary>
        /// Numerator of the quotient of quantities.
        /// </summary>
        [IsoId("_UMtPANp-Ed-ak6NoX_4Aeg_110025386")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty1")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity1 { get; init; }

        /// <summary>
        /// Denominator of the quotient of quantities.
        /// </summary>
        [IsoId("_UMtPAdp-Ed-ak6NoX_4Aeg_154352706")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty2")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity2 { get; init; }
    }
}
