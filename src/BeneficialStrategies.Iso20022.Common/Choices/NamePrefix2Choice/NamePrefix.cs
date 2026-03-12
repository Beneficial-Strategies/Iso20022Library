// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NamePrefix2Choice
{
    /// <summary>
    /// Prefix for name.
    /// </summary>
    [IsoId("_M0Pz0A2fEeSNWNtJlXOAhg")]
    [DisplayName("Name Prefix")]
    public partial record NamePrefix : NamePrefix2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoXmlTag("NmPrfx")]
        public required NamePrefix1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
