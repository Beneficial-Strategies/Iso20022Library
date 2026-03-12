// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Portuguese National Clearing Code - identifies Portuguese financial institutions on the Portuguese national clearing system.
    /// </summary>
    [IsoId("_TC8Kltp-Ed-ak6NoX_4Aeg_1989940211")]
    [DisplayName("Portuguese NCC Identification")]
    public partial record PortugueseNCCIdentification : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Portuguese National Clearing Code. Identifies Portuguese financial institutions on the Portuguese national clearing system.
        /// </summary>
        [IsoXmlTag("PTNCC")]
        [IsoSimpleType(IsoSimpleType.PortugueseNCCIdentifier)]
        public required IsoPortugueseNCCIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
