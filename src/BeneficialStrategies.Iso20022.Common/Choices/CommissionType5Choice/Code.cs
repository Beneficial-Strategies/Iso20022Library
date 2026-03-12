// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommissionType5Choice
{
    /// <summary>
    /// Commission type expressed as a code.
    /// </summary>
    [IsoId("_ssJ7k2W6EeSHcOWXSsMhqw")]
    [DisplayName("Code")]
    public partial record Code : CommissionType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investment fund commission.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommissionType6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
