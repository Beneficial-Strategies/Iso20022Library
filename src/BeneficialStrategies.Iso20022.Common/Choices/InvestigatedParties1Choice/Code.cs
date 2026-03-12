// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigatedParties1Choice
{
    /// <summary>
    /// Specifies the investigated parties as a code.
    /// </summary>
    [IsoId("_dCh4RjwTEeGKuZXNQxGH3g")]
    [DisplayName("Code")]
    public partial record Code : InvestigatedParties1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the investigated parties.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestigatedParties1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
