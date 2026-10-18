// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <inheritdoc cref="IProprietaryAccount"/>
    [IsoId("_PdwzoNp-Ed-ak6NoX_4Aeg_-1485477198")]
    [DisplayName("Proprietary Account")]
    public partial record ProprietaryAccount : AccountIdentification3Choice_
    {
        /// <inheritdoc cref="IProprietaryAccount.Identification"/>
        [IsoId("_P_u4QNp-Ed-ak6NoX_4Aeg_618188642")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public required IsoMax34Text Identification { get; init; }
    }
}
