// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InitialPhysicalForm3Choice
{
    /// <summary>
    /// Initial physical form expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_m9IgceLcEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : InitialPhysicalForm3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the physical form of the securities.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InitialPhysicalForm2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
