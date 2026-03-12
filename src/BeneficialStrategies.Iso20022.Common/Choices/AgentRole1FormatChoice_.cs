// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the role of the agent.
    /// </summary>
    [KnownType(typeof(AgentRole1FormatChoice.Code))]
    [KnownType(typeof(AgentRole1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(AgentRole1FormatChoice.Code),nameof(AgentRole1FormatChoice.Code))]
    [JsonDerivedType(typeof(AgentRole1FormatChoice.Proprietary),nameof(AgentRole1FormatChoice.Proprietary))]
    [IsoId("_RlgjR9p-Ed-ak6NoX_4Aeg_1472150836")]
    [DisplayName("Agent Role 1 Format Choice")]
    public abstract partial record AgentRole1FormatChoice_
    {
    }
}
