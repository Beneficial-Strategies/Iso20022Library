// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AwaitingCancellationReason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_A4QTINokEeC60axPepSq7g_358058758")]
    [DisplayName("Code")]
    public partial record Code : AwaitingCancellationReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction has an awaiting cancellation status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AwaitingCancellationReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
