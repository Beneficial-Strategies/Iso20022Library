// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AwaitingAffirmationReason1Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    [IsoId("_A6MM0dokEeC60axPepSq7g_-1583553059")]
    [DisplayName("Code")]
    public partial record Code : AwaitingAffirmationReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction has an awaiting affirmation status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AwaitingAffirmationReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
