// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommissionType2Choice
{
    /// <summary>
    /// Commission type is identified using a code.
    /// </summary>
    [IsoId("_Ac_Tc9okEeC60axPepSq7g_1841496758")]
    [DisplayName("Code")]
    public partial record Code : CommissionType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which the commission is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommissionType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
