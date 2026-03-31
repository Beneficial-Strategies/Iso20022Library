// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_--ww8CCeEeWJd9HF2tO7BA")]
[Description(@"Specifies a type of organisation.")]
[Derivations(typeof(OrganisationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrganisationTypeCode>))]
#endif
public enum OrganisationTypeCode
{
    /// <summary>
    /// Organisation is a public company.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_EUp3kCCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public company.")]
    Public,

    /// <summary>
    /// Organisation is a private association.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_HN4ugCCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a private association.")]
    PrivateAssociation,

    /// <summary>
    /// Organisation is an investment fund.
    /// Encoded/decoded by serializers as &quot;IFUN&quot;.
    /// </summary>
    [EnumMember(Value = "IFUN")]
    [IsoId("_J_0qoCCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is an investment fund.")]
    InvestmentFund,

    /// <summary>
    /// Organisation is a public fund.
    /// Encoded/decoded by serializers as &quot;PFUN&quot;.
    /// </summary>
    [EnumMember(Value = "PFUN")]
    [IsoId("_O5S7ACCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public fund.")]
    PublicFund,
}
