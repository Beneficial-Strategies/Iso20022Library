// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethodFormat4Choice
{
    /// <summary>
    /// Standard code to specify the method used to compute accruing interest of a financial instrument.
    /// </summary>
    [IsoId("_bMY-4Tm6EeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public partial record Code : InterestComputationMethodFormat4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method used to compute accruing interest of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestComputationMethod2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
