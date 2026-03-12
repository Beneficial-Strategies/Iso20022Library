// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType2FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of charge.
    /// </summary>
    [IsoId("_Rl0FRdp-Ed-ak6NoX_4Aeg_-1541781007")]
    [DisplayName("Code")]
    public partial record Code : ChargeType2FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies charges linked to the type of service.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeType14Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
