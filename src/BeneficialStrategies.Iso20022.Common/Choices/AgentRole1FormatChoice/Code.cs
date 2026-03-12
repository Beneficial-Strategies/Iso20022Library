// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AgentRole1FormatChoice
{
    /// <summary>
    /// Standard code to specify the role of the agent.
    /// </summary>
    [IsoId("_RlgjSNp-Ed-ak6NoX_4Aeg_349250144")]
    [DisplayName("Code")]
    public partial record Code : AgentRole1FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the agent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AgentRole2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
