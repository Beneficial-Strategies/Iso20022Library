// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionRight2Choice
{
    /// <summary>
    /// Option rights expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_P_xv0ZEjEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public partial record Code : OptionRight2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the option rights.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionRight1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
