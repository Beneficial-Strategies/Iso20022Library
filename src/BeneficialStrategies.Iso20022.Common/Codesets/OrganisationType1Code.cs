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
[IsoId("_g0YAgCCfEeWJd9HF2tO7BA")]
[Description(@"Specifies a type of organisation.")]
[DerivedFrom(typeof(OrganisationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrganisationType1Code>))]
#endif
public enum OrganisationType1Code
{
    /// <summary>
    /// Organisation is an investment fund.
    /// Encoded/decoded by serializers as &quot;IFUN&quot;.
    /// </summary>
    [EnumMember(Value = "IFUN")]
    [IsoId("_jvGFMSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is an investment fund.")]
    InvestmentFund = OrganisationTypeCode.InvestmentFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Organisation is a private association.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_j2YY8SCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a private association.")]
    PrivateAssociation = OrganisationTypeCode.PrivateAssociation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Organisation is a public company.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_j9rTwSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public company.")]
    Public = OrganisationTypeCode.Public, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Organisation is a public fund.
    /// Encoded/decoded by serializers as &quot;PFUN&quot;.
    /// </summary>
    [EnumMember(Value = "PFUN")]
    [IsoId("_kFHYgSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public fund.")]
    PublicFund = OrganisationTypeCode.PublicFund, // same ordinal as derivation source for type conversions
}
