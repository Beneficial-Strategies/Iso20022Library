// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethod1Choice
{
    /// <summary>
    /// Code is used to determine the interest computation method.
    /// </summary>
    [IsoId("_Q-eYctp-Ed-ak6NoX_4Aeg_-477937109")]
    [DisplayName("Code")]
    public partial record Code : InterestComputationMethod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method used to compute accruing interest of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestComputationMethod1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
