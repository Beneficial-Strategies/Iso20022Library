// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemStatus3Choice
{
    /// <summary>
    /// Status of the system, in a coded form.
    /// </summary>
    [IsoId("_1iyv8YpbEeiaB-4Hjqs8aw")]
    [DisplayName("Code")]
    public partial record Code : SystemStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemStatus3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
