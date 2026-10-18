// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <inheritdoc cref="IProprietaryIdentification"/>
    [IsoId("_TFnrIdp-Ed-ak6NoX_4Aeg_1988349475")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public partial record ProprietaryIdentification : FinancialInstitutionIdentification5Choice_
    {
        /// <inheritdoc cref="IProprietaryIdentification.Identification"/>
        [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <inheritdoc cref="IProprietaryIdentification.Issuer"/>
        [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
