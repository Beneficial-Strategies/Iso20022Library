// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Fedwire Routing Number - identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
    /// </summary>
    [IsoId("_TC8Kldp-Ed-ak6NoX_4Aeg_1989940168")]
    [DisplayName("Fedwire Routing Number Identification")]
    public partial record FedwireRoutingNumberIdentification : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Fedwire Routing Number. Identifies financial institutions, in the US, on the FedWire system. The routing number is assigned by the American Bankers Association (ABA).
        /// </summary>
        [IsoXmlTag("USFW")]
        [IsoSimpleType(IsoSimpleType.FedwireRoutingNumberIdentifier)]
        public required IsoFedwireRoutingNumberIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
