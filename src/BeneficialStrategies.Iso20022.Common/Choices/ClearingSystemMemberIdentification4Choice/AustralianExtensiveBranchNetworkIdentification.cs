// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// Extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
    /// </summary>
    [IsoId("_VwSCg7NIEeejueAciesPMA")]
    [DisplayName("Australian Extensive Branch Network Identification")]
    public partial record AustralianExtensiveBranchNetworkIdentification : ClearingSystemMemberIdentification4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// The extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
        /// </summary>
        [IsoXmlTag("AUBSBx")]
        [IsoSimpleType(IsoSimpleType.ExtensiveBranchNetworkIdentifier)]
        public required IsoExtensiveBranchNetworkIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
