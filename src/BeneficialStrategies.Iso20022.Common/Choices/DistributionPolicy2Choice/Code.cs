// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DistributionPolicy2Choice
{
    /// <summary>
    /// Distribution policy expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_HzKCoeLaEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : DistributionPolicy2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies if income is to be paid out (distributed) or retained (accumulated).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DistributionPolicy1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
