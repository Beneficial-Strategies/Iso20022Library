// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Disclosure2Choice
{
    /// <summary>
    /// Shareholding information is not disclosed.
    /// </summary>
    [IsoId("_MM9hYfNyEeqRfth943bvEA")]
    [DisplayName("No Disclosure")]
    public partial record NoDisclosure : Disclosure2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NoDsclsr")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
