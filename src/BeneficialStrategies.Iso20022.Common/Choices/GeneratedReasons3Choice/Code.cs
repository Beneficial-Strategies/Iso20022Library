// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeneratedReasons3Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_DOVSsSRhEeO8sskhVI3IDA")]
    [DisplayName("Code")]
    public partial record Code : GeneratedReasons3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the transaction was generated.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GeneratedReason3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
