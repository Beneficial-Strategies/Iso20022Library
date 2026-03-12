// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cleared4Choice
{
    /// <summary>
    /// Specifies that the contract has not been cleared.
    /// </summary>
    [IsoId("_kdVNQCUMEeeDvf1E8-5blA")]
    [DisplayName("Non Cleared")]
    public partial record NonCleared : Cleared4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("NonClrd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
