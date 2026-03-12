// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethod3Choice
{
    /// <summary>
    /// Code is used to determine the interest computation method.
    /// </summary>
    [IsoId("_x33EkZEjEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : InterestComputationMethod3Choice_
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
