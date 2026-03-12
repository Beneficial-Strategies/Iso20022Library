// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RiskLevel2Choice
{
    /// <summary>
    /// Risk level expressed as code.
    /// </summary>
    [IsoId("_BtuioSGREeWO8_xZKx-MFg")]
    [DisplayName("Code")]
    public partial record Code : RiskLevel2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the risk level.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RiskLevel1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
