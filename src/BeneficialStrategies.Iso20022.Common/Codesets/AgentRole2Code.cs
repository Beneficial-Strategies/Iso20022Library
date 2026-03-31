// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnwEQNp-Ed-ak6NoX_4Aeg_-79264456")]
[Description(@"Specifies the role of the agent.")]
[DerivedFrom(typeof(AgentRoleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AgentRole2Code>))]
#endif
public enum AgentRole2Code
{
    /// <summary>
    /// The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties.
    /// Encoded/decoded by serializers as &quot;SPAY&quot;.
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_boWhMNp-Ed-ak6NoX_4Aeg_211645175")]
    [Description(
        @"The System Paying Agent (SPA) is the party within the CSD that is responsible for the distribution of cash and security proceeds related to a specific distribution to other CSD Parties."
    )]
    SystemPayingAgent = AgentRoleCode.SystemPayingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as &quot;CODO&quot;.
    /// </summary>
    [EnumMember(Value = "CODO")]
    [IsoId("_boWhMdp-Ed-ak6NoX_4Aeg_211645184")]
    [Description(
        @"Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror."
    )]
    CoDomicile = AgentRoleCode.CoDomicile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// Encoded/decoded by serializers as &quot;ISAG&quot;.
    /// </summary>
    [EnumMember(Value = "ISAG")]
    [IsoId("_boWhMtp-Ed-ak6NoX_4Aeg_211645206")]
    [Description(
        @"Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event."
    )]
    IssuerAgent = AgentRoleCode.IssuerAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// Encoded/decoded by serializers as &quot;REGR&quot;.
    /// </summary>
    [EnumMember(Value = "REGR")]
    [IsoId("_bofrINp-Ed-ak6NoX_4Aeg_-1642045238")]
    [Description(@"Party/agent responsible for maintaining the register of a security.")]
    Registrar = AgentRoleCode.Registrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_bofrIdp-Ed-ak6NoX_4Aeg_-69287984")]
    [Description(
        @"Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror."
    )]
    PayingAgent = AgentRoleCode.PayingAgent, // same ordinal as derivation source for type conversions
}
