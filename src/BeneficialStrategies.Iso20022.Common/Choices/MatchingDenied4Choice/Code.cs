// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingDenied4Choice
{
    /// <summary>
    /// Specifies the execution of a matching denial process.
    /// </summary>
    [IsoId("_6GWWD5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : MatchingDenied4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the action to be performed on the matching process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MatchingProcess1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
