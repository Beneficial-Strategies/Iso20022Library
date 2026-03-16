// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Italian Domestic Identification Code - identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
    /// </summary>
    [IsoId("_TC8KmNp-Ed-ak6NoX_4Aeg_1989940263")]
    [DisplayName("Italian Domestic Identification Code")]
    public record ItalianDomesticIdentificationCode : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Italian Domestic Identification Code. Identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
        /// </summary>
        [IsoXmlTag("ITNCC")]
        [IsoSimpleType(IsoSimpleType.ItalianDomesticIdentifier)]
        public required IsoItalianDomesticIdentifier Value { get; init; }
    }
}
