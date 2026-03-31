// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
    /// </summary>
    [IsoId("_TDPFgNp-Ed-ak6NoX_4Aeg_1990860899")]
    [DisplayName("Australian Extensive Branch Network Identification")]
    public record AustralianExtensiveBranchNetworkIdentification
        : ClearingSystemMemberIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// The extensive branch network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
        /// </summary>
        [IsoXmlTag("AUBSBx")]
        [IsoSimpleType(IsoSimpleType.ExtensiveBranchNetworkIdentifier)]
        public required IsoExtensiveBranchNetworkIdentifier Value { get; init; }
    }
}
