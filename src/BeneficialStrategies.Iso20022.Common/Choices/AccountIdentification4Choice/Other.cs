// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice
{
    /// <inheritdoc cref="IOther"/>
    [IsoId("_Pdwzo9p-Ed-ak6NoX_4Aeg_-1833657786")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public partial record Other : AccountIdentification4Choice_
    {
        /// <inheritdoc cref="IOther.Identification"/>
        [IsoId("_P_u4Rtp-Ed-ak6NoX_4Aeg_2078970799")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public required IsoMax34Text Identification { get; init; }

        /// <inheritdoc cref="IOther.SchemeName"/>
        [IsoId("_P_u4R9p-Ed-ak6NoX_4Aeg_-162653838")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        public AccountSchemeName1Choice_? SchemeName { get; init; }

        /// <inheritdoc cref="IOther.Issuer"/>
        [IsoId("_P_u4SNp-Ed-ak6NoX_4Aeg_-2119026269")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
