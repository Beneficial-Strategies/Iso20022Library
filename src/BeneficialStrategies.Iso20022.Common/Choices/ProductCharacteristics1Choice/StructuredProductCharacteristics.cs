// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductCharacteristics1Choice
{
    /// <summary>
    /// Specifies the type of product characteristic.
    /// </summary>
    [IsoId("_RbrR1Np-Ed-ak6NoX_4Aeg_1622931729")]
    [DisplayName("Structured Product Characteristics")]
    public record StructuredProductCharacteristics : ProductCharacteristics1Choice_
    {
        /// <summary>
        /// Specifies the type of product characteristic by means of a code.
        /// </summary>
        [IsoId("_T5L2Fdp-Ed-ak6NoX_4Aeg_1279381373")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ProductCharacteristics1Code Type { get; init; }

        /// <summary>
        /// Specifies the characteristic of a product.
        /// </summary>
        [IsoId("_T5L2Ftp-Ed-ak6NoX_4Aeg_1319095231")]
        [DisplayName("Characteristics")]
        [IsoXmlTag("Chrtcs")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Characteristics { get; init; }
    }
}
