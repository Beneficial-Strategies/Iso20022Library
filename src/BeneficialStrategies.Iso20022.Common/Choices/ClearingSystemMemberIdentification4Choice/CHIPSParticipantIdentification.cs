// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// (United States) Clearing House Interbank Payment System (CHIPS) Participant Identifier (ID) - identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_VwSCabNIEeejueAciesPMA")]
    [DisplayName("CHIPS Participant Identification")]
    public record CHIPSParticipantIdentification : ClearingSystemMemberIdentification4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// (United States) Clearing House Interbank Payment System (CHIPS) Participant Identifier (ID). Identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
        /// </summary>
        [IsoXmlTag("USCH")]
        [IsoSimpleType(IsoSimpleType.CHIPSParticipantIdentifier)]
        public required IsoCHIPSParticipantIdentifier Value { get; init; }
    }
}
