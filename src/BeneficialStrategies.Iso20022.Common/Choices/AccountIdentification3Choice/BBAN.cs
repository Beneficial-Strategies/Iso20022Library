// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <inheritdoc cref="IBBAN"/>
    [IsoId("_PdnCp9p-Ed-ak6NoX_4Aeg_639037244")]
    [DisplayName("BBAN")]
    public partial record BBAN : AccountIdentification3Choice_
    {
        /// <inheritdoc cref="IBBAN.Value"/>
        [IsoXmlTag("BBAN")]
        [IsoSimpleType(IsoSimpleType.BBANIdentifier)]
        public required IsoBBANIdentifier Value { get; init; }
    }
}
