// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus7Choice
{
    /// <summary>
    /// Provides the status of a cancellation request.
    /// </summary>
    [IsoId("_3bJPkTqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public partial record Code : CancellationProcessingStatus7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of a cancellation request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationProcessingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
