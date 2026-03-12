// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Small network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
    /// </summary>
    [IsoId("_TDPFgdp-Ed-ak6NoX_4Aeg_1990860942")]
    [DisplayName("Australian Small Network Identification")]
    public partial record AustralianSmallNetworkIdentification : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// The small network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
        /// </summary>
        [IsoXmlTag("AUBSBs")]
        [IsoSimpleType(IsoSimpleType.SmallNetworkIdentifier)]
        public required IsoSmallNetworkIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
