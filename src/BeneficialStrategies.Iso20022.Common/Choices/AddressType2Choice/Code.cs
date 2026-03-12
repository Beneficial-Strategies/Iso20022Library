// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AddressType2Choice
{
    /// <summary>
    /// Type of address expressed as a code.
    /// </summary>
    [IsoId("_MZfdYCFzEeW9XJWqfgXIIA")]
    [DisplayName("Code")]
    public partial record Code : AddressType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of address.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AddressType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
