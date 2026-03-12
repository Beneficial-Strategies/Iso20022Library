// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettleStyle2Choice
{
    /// <summary>
    /// Settle style expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_ra2T0eLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : SettleStyle2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when the option contract settles.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettleStyle1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
