// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <inheritdoc cref="IIBAN"/>
    [IsoId("_PdnCptp-Ed-ak6NoX_4Aeg_638115990")]
    [DisplayName("IBAN")]
    public partial record IBAN : AccountIdentification3Choice_
    {
        /// <inheritdoc cref="IIBAN.Value"/>
        [IsoXmlTag("IBAN")]
        [IsoSimpleType(IsoSimpleType.IBANIdentifier)]
        public required IsoIBANIdentifier Value { get; init; }
    }
}
