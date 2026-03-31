// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginType2Choice
{
    /// <summary>
    /// Proprietary or institution&apos;s own code that specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
    /// </summary>
    [IsoId("____w8I1rEeet3cKIYK84nw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public record Proprietary : MarginType2Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_ARhDQdokEeC60axPepSq7g_-923710056")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_ARqNMNokEeC60axPepSq7g_-1920782409")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; }

        /// <summary>
        /// Short textual description of the scheme.
        /// </summary>
        [IsoId("_ARqNMdokEeC60axPepSq7g_1669070272")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }
    }
}
