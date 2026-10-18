// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AddressType3Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_C7IDQxb-EeiyVv5j1vf1VQ")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public partial record Proprietary : AddressType3Choice_
    {
        /// <inheritdoc cref="IProprietary.Identification"/>
        [IsoId("_P-Pqg9p-Ed-ak6NoX_4Aeg_-2101736418")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Identification { get; init; }

        /// <inheritdoc cref="IProprietary.Issuer"/>
        [IsoId("_P-PqhNp-Ed-ak6NoX_4Aeg_1196158525")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Issuer { get; init; }

        /// <inheritdoc cref="IProprietary.SchemeName"/>
        [IsoId("_P-Pqhdp-Ed-ak6NoX_4Aeg_491043910")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }
    }
}
