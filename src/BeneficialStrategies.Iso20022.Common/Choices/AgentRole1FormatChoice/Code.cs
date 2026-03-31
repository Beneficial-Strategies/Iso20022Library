// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AgentRole1FormatChoice
{
    /// <summary>
    /// Standard code to specify the role of the agent.
    /// </summary>
    [IsoId("_RlgjSNp-Ed-ak6NoX_4Aeg_349250144")]
    [DisplayName("Code")]
    public record Code : AgentRole1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the agent.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AgentRole2Code Value { get; init; }
    }
}
