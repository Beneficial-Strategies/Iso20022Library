// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// (United States) Clearing House Interbank Payment System (CHIPS) Participant Identifier (ID) - identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
    /// </summary>
    [IsoId("_VwSCabNIEeejueAciesPMA")]
    [DisplayName("CHIPS Participant Identification")]
    public partial record CHIPSParticipantIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// (United States) Clearing House Interbank Payment System (CHIPS) Participant Identifier (ID). Identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
        /// </summary>
        [IsoXmlTag("USCH")]
        [IsoSimpleType(IsoSimpleType.CHIPSParticipantIdentifier)]
        public required IsoCHIPSParticipantIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
