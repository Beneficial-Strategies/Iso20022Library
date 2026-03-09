// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function that the agent is performing (for example, event agent, information agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mchEjL3EeKU9IrkkToqcw_-1193321661")]
[Description(@"Specifies the function that the agent is performing (for example, event agent, information agent).")]
[Derivations(typeof(AgentType1Code))]
public enum AgentTypeCode
{
    /// <summary>
    /// Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities.
    /// Encoded/decoded by serializers as &quot;DAGB&quot;.
    /// </summary>
    [EnumMember(Value = "DAGB")]
    [IsoId("_1mchEzL3EeKU9IrkkToqcw_-898443522")]
    [Description(@"Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities.")]
    DropAgentBearer,
    
    /// <summary>
    /// Agent that cannot be classified as any listed type of agent.
    /// Encoded/decoded by serializers as &quot;OTAG&quot;.
    /// </summary>
    [EnumMember(Value = "OTAG")]
    [IsoId("_1mchFDL3EeKU9IrkkToqcw_1288946460")]
    [Description(@"Agent that cannot be classified as any listed type of agent.")]
    Other,
    
}
