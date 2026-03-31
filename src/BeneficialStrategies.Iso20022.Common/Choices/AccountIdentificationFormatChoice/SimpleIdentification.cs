// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationFormatChoice
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RBvu5tp-Ed-ak6NoX_4Aeg_1757395821")]
    [DisplayName("Simple Identification")]
    public record SimpleIdentification : AccountIdentificationFormatChoice_
    {
        /// <summary>
        /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
        /// </summary>
        [IsoId("_PdnCpNp-Ed-ak6NoX_4Aeg_-1749118142")]
        [DisplayName("Proprietary")]
        [IsoXmlTag("Prtry")]
        public required SimpleIdentificationInformation Proprietary { get; init; }
    }
}
