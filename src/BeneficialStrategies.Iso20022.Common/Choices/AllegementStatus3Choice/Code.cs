// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AllegementStatus3Choice
{
    /// <summary>
    /// Status of the allegement reported.
    /// </summary>
    [IsoId("_UHLhwTqhEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : AllegementStatus3Choice_
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
