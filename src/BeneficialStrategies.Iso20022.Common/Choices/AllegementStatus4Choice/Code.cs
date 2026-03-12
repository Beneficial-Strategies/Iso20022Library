// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AllegementStatus4Choice
{
    /// <summary>
    /// Status of the allegement reported.
    /// </summary>
    [IsoId("_6MjsL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : AllegementStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an allegement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllegementStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
