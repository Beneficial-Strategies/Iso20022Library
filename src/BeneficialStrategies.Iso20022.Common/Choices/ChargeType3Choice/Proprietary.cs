// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType3Choice
{
    /// <inheritdoc cref="IProprietary"/>
    [IsoId("_tjJEU1kyEeGeoaLUQk__nA_-265813283")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public partial record Proprietary : ChargeType3Choice_
    {
        /// <inheritdoc cref="IProprietary.Identification"/>
        [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <inheritdoc cref="IProprietary.Issuer"/>
        [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
