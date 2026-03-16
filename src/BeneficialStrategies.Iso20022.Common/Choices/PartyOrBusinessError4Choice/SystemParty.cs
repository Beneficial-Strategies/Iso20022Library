// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyOrBusinessError4Choice
{
    /// <summary>
    /// System Party.
    /// </summary>
    [DisplayName("System Party")]
    public partial record SystemParty : PartyOrBusinessError4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("SysPty")]
        public required SystemParty6 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
