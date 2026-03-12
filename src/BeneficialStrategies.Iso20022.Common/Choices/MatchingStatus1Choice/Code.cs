// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MatchingStatus1Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_UaaT3Np-Ed-ak6NoX_4Aeg_-1299790832")]
    [DisplayName("Code")]
    public partial record Code : MatchingStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the matching status of the instruction at the time the settlement instruction was sent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MatchingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
