// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommissionType1Choice
{
    /// <summary>
    /// Commission type is identified using a code.
    /// </summary>
    [IsoId("_Q-K2d9p-Ed-ak6NoX_4Aeg_-2081035932")]
    [DisplayName("Code")]
    public partial record Code : CommissionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of value of the commission.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CommissionValueType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
