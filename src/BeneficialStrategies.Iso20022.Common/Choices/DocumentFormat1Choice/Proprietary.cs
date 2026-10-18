// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_932rtnltEeG7BsjMvd1mEw_-654250826")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public partial record Proprietary : DocumentFormat1Choice_
    {
        /// <inheritdoc cref="IProprietary.Identification"/>
        [IsoId("_QALkONp-Ed-ak6NoX_4Aeg_-1748202217")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <inheritdoc cref="IProprietary.SchemeName"/>
        [IsoId("_QAVVMNp-Ed-ak6NoX_4Aeg_-1748202215")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SchemeName { get; init; }

        /// <inheritdoc cref="IProprietary.Issuer"/>
        [IsoId("_QAVVMdp-Ed-ak6NoX_4Aeg_-1748202216")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
