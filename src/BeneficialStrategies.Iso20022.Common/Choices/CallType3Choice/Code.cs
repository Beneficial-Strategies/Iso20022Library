// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CallType3Choice
{
    /// <summary>
    /// Call type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_fNbCweLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : CallType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the type of execution of the call feature.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CallType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
