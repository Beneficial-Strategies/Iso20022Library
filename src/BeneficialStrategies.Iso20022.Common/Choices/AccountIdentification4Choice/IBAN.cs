// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice
{
    /// <inheritdoc cref="IIBAN"/>
    [IsoId("_Pdwzotp-Ed-ak6NoX_4Aeg_-1833658189")]
    [DisplayName("IBAN")]
    public partial record IBAN : AccountIdentification4Choice_
    {
        /// <inheritdoc cref="IIBAN.Value"/>
        [IsoXmlTag("IBAN")]
        [IsoSimpleType(IsoSimpleType.IBAN2007Identifier)]
        public required IsoIBAN2007Identifier Value { get; init; }
    }
}
