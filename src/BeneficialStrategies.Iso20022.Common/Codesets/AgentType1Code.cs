// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function the agent is performing (for example, event agent, information agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1sQOIzL3EeKU9IrkkToqcw_1983837671")]
[Description(
    @"Specifies the function the agent is performing (for example, event agent, information agent)."
)]
[DerivedFrom(typeof(AgentTypeCode))]
public enum AgentType1Code
{
    /// <summary>
    /// Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities.
    /// Encoded/decoded by serializers as &quot;DAGB&quot;.
    /// </summary>
    [EnumMember(Value = "DAGB")]
    [IsoId("_1sQOJDL3EeKU9IrkkToqcw_38160419")]
    [Description(
        @"Trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person. Specific to bearer securities."
    )]
    DropAgentBearer = AgentTypeCode.DropAgentBearer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent that cannot be classified as any listed type of agent.
    /// Encoded/decoded by serializers as &quot;OTAG&quot;.
    /// </summary>
    [EnumMember(Value = "OTAG")]
    [IsoId("_1sQOJTL3EeKU9IrkkToqcw_108929944")]
    [Description(@"Agent that cannot be classified as any listed type of agent.")]
    Other = AgentTypeCode.Other, // same ordinal as derivation source for type conversions
}
