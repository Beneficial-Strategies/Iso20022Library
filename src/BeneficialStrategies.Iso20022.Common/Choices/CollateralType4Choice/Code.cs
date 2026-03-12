// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralType4Choice
{
    /// <summary>
    /// Type of collateral expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Dydo85EkEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : CollateralType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of collateral.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CollateralType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
