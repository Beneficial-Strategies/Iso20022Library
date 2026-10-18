// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <inheritdoc cref="INameAndAddress"/>
    [IsoId("_TFnrINp-Ed-ak6NoX_4Aeg_426657982")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public partial record NameAndAddress : FinancialInstitutionIdentification5Choice_
    {
        /// <inheritdoc cref="INameAndAddress.Name"/>
        [IsoId("_PZleQtp-Ed-ak6NoX_4Aeg_1385273243")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public required IsoMax70Text Name { get; init; }

        /// <inheritdoc cref="INameAndAddress.PostalAddress"/>
        [IsoId("_PZleQ9p-Ed-ak6NoX_4Aeg_1385275042")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public required PostalAddress1 PostalAddress { get; init; }
    }
}
