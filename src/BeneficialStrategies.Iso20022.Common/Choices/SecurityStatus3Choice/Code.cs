// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityStatus3Choice
{
    /// <summary>
    /// Security status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_GHDbQeLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : SecurityStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecurityStatus2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
