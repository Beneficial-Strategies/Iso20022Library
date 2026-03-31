// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// German Bankleitzahl - identifies German financial institutions on the German national clearing systems.
    /// </summary>
    [IsoId("_TDF7ktp-Ed-ak6NoX_4Aeg_1989940790")]
    [DisplayName("German Bankleitzahl Identification")]
    public record GermanBankleitzahlIdentification : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// German Bankleitzahl. Identifies German financial institutions on the German national clearing systems.
        /// </summary>
        [IsoXmlTag("DEBLZ")]
        [IsoSimpleType(IsoSimpleType.GermanBankleitzahlIdentifier)]
        public required IsoGermanBankleitzahlIdentifier Value { get; init; }
    }
}
