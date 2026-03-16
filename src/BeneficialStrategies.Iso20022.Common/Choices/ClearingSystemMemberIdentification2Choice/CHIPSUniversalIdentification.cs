// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_TCzAq9p-Ed-ak6NoX_4Aeg_1989939470")]
    [DisplayName("CHIPS Universal Identification")]
    public record CHIPSUniversalIdentification : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID). Identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
        /// </summary>
        [IsoXmlTag("USCHU")]
        [IsoSimpleType(IsoSimpleType.CHIPSUniversalIdentifier)]
        public required IsoCHIPSUniversalIdentifier Value { get; init; }
    }
}
