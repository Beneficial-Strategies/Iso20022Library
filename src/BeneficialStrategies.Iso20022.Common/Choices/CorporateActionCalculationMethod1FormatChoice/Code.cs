// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionCalculationMethod1FormatChoice
{
    /// <summary>
    /// Standard code to specify the calculation method for drawings.
    /// </summary>
    [IsoId("_Rl9PNNp-Ed-ak6NoX_4Aeg_-550005822")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionCalculationMethod1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the calculation method for drawings.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionCalculationMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
