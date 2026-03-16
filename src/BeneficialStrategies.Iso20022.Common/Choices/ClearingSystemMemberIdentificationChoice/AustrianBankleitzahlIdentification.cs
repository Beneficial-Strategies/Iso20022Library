// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Austrian Bankleitzahl - identifies Austrian financial institutions on the Austrian national clearing system.
    /// </summary>
    [IsoId("_TDY2iNp-Ed-ak6NoX_4Aeg_-896562588")]
    [DisplayName("Austrian Bankleitzahl Identification")]
    public record AustrianBankleitzahlIdentification : ClearingSystemMemberIdentificationChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Austrian Bankleitzahl. Identifies Austrian financial institutions on the Austrian national clearing system.
        /// </summary>
        [IsoXmlTag("ATBLZ")]
        [IsoSimpleType(IsoSimpleType.AustrianBankleitzahlIdentifier)]
        public required IsoAustrianBankleitzahlIdentifier Value { get; init; }
    }
}
