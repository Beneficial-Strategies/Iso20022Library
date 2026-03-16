// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity3Choice
{
    /// <summary>
    /// Proprietary quantity of security format.
    /// </summary>
    [IsoId("_Qz45Hdp-Ed-ak6NoX_4Aeg_-1264625918")]
    [DisplayName("Proprietary Quantity")]
    public record ProprietaryQuantity : Quantity3Choice_
    {
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_Qzl-Kdp-Ed-ak6NoX_4Aeg_-1992680484")]
        [DisplayName("Short Long Position")]
        [IsoXmlTag("ShrtLngPos")]
        public ShortLong1Code? ShortLongPosition { get; init; }

        /// <summary>
        /// Provides the proprietary quantity with a decimal number.
        /// </summary>
        [IsoId("_Qzl-Ktp-Ed-ak6NoX_4Aeg_547321801")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Quantity { get; init; }

        /// <summary>
        /// Identifies the type of proprietary quantity reported.
        /// </summary>
        [IsoId("_QzvvINp-Ed-ak6NoX_4Aeg_547322144")]
        [DisplayName("Quantity Type")]
        [IsoXmlTag("QtyTp")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText QuantityType { get; init; }

        /// <summary>
        /// Provides information related to issuer in free format.
        /// </summary>
        [IsoId("_QzvvIdp-Ed-ak6NoX_4Aeg_547322179")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_QzvvItp-Ed-ak6NoX_4Aeg_547322281")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }
    }
}
