// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the role of the agent.
    /// </summary>
    [KnownType(typeof(AgentRole1FormatChoice.Code))]
    [KnownType(typeof(AgentRole1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AgentRole1FormatChoice.Code),nameof(AgentRole1FormatChoice.Code))]
    [JsonDerivedType(typeof(AgentRole1FormatChoice.Proprietary),nameof(AgentRole1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RlgjR9p-Ed-ak6NoX_4Aeg_1472150836")]
    [DisplayName("Agent Role 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AgentRole1FormatChoice_
    #else
    public abstract partial class AgentRole1FormatChoice_
    #endif
    {
    }
}
