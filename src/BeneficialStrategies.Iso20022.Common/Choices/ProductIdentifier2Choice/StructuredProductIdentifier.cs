// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProductIdentifier2Choice
{
    /// <summary>
    /// Specifies the type of product identifier.
    /// </summary>
    [IsoId("_Rb1C0dp-Ed-ak6NoX_4Aeg_-1291805271")]
    [DisplayName("Structured Product Identifier")]
    public record StructuredProductIdentifier : ProductIdentifier2Choice_
    {
        /// <summary>
        /// Specifies the type of product identifier by means of a code.
        /// </summary>
        [IsoId("_TRZdUNp-Ed-ak6NoX_4Aeg_-1876396252")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ProductIdentifier2Code Type { get; init; }

        /// <summary>
        /// Specifies the product identifier.
        /// </summary>
        [IsoId("_TRZdUdp-Ed-ak6NoX_4Aeg_-1876396236")]
        [DisplayName("Identifier")]
        [IsoXmlTag("Idr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identifier { get; init; }
    }
}
