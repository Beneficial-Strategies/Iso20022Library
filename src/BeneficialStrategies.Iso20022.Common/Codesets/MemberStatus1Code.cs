// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the live status of a member of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdmYYw93EeGeV5vP7Mvdig_311511603")]
[Description(@"Specifies the live status of a member of a system.")]
[DerivedFrom(typeof(MemberStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MemberStatus1Code>))]
#endif
public enum MemberStatus1Code
{
    /// <summary>
    /// Member is live on the system.
    /// Encoded/decoded by serializers as &quot;ENBL&quot;.
    /// </summary>
    [EnumMember(Value = "ENBL")]
    [IsoId("_zdmYZA93EeGeV5vP7Mvdig_-507442078")]
    [Description(@"Member is live on the system.")]
    Enabled = MemberStatusCode.Enabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Member is temporarily not live on the system.
    /// Encoded/decoded by serializers as &quot;DSBL&quot;.
    /// </summary>
    [EnumMember(Value = "DSBL")]
    [IsoId("_zdmYZQ93EeGeV5vP7Mvdig_943717544")]
    [Description(@"Member is temporarily not live on the system.")]
    Disabled = MemberStatusCode.Disabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Member is no longer live on the system.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_zdmYZg93EeGeV5vP7Mvdig_1865880854")]
    [Description(@"Member is no longer live on the system.")]
    Deleted = MemberStatusCode.Deleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Member is joining and will soon be enabled on the system.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_zdviUA93EeGeV5vP7Mvdig_1111130980")]
    [Description(@"Member is joining and will soon be enabled on the system.")]
    Joining = MemberStatusCode.Joining, // same ordinal as derivation source for type conversions
}
