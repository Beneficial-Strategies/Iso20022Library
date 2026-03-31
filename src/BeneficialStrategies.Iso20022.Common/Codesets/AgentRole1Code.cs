// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the Issuer agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnmTRtp-Ed-ak6NoX_4Aeg_1217480497")]
[Description(@"Specifies the role of the Issuer agent.")]
[DerivedFrom(typeof(AgentRoleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AgentRole1Code>))]
#endif
public enum AgentRole1Code
{
    /// <summary>
    /// Identification of the agent acting as main agent.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_bnmTR9p-Ed-ak6NoX_4Aeg_1607205276")]
    [Description(@"Identification of the agent acting as main agent.")]
    PrincipalAgent = AgentRoleCode.PrincipalAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the agent acting as co-domicile or sub agent.
    /// Encoded/decoded by serializers as &quot;SUBA&quot;.
    /// </summary>
    [EnumMember(Value = "SUBA")]
    [IsoId("_bnmTSNp-Ed-ak6NoX_4Aeg_1634910933")]
    [Description(@"Identification of the agent acting as co-domicile or sub agent.")]
    SubAgent = AgentRoleCode.SubAgent, // same ordinal as derivation source for type conversions
}
