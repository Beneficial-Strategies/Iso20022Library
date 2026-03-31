// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the civil status of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Dog4YCChEeWJd9HF2tO7BA")]
[Description(@"Specifies the civil status of a person.")]
[Derivations(typeof(CivilStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CivilStatusCode>))]
#endif
public enum CivilStatusCode
{
    /// <summary>
    /// Person is single.
    /// Encoded/decoded by serializers as &quot;SING&quot;.
    /// </summary>
    [EnumMember(Value = "SING")]
    [IsoId("_L0NugCChEeWJd9HF2tO7BA")]
    [Description(@"Person is single.")]
    Single,

    /// <summary>
    /// Person is married.
    /// Encoded/decoded by serializers as &quot;MARR&quot;.
    /// </summary>
    [EnumMember(Value = "MARR")]
    [IsoId("_POxw4CChEeWJd9HF2tO7BA")]
    [Description(@"Person is married.")]
    Married,

    /// <summary>
    /// Person is legally divorced.
    /// Encoded/decoded by serializers as &quot;LDIV&quot;.
    /// </summary>
    [EnumMember(Value = "LDIV")]
    [IsoId("_SKFrcCChEeWJd9HF2tO7BA")]
    [Description(@"Person is legally divorced.")]
    LegallyDivorced,

    /// <summary>
    /// Person is divorced.
    /// Encoded/decoded by serializers as &quot;DIVO&quot;.
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_WeEpICChEeWJd9HF2tO7BA")]
    [Description(@"Person is divorced.")]
    Divorced,

    /// <summary>
    /// Person is a widower.
    /// Encoded/decoded by serializers as &quot;WIDO&quot;.
    /// </summary>
    [EnumMember(Value = "WIDO")]
    [IsoId("_cXFD4CChEeWJd9HF2tO7BA")]
    [Description(@"Person is a widower.")]
    Widow,

    /// <summary>
    /// Person is in a stable union.
    /// Encoded/decoded by serializers as &quot;UNIO&quot;.
    /// </summary>
    [EnumMember(Value = "UNIO")]
    [IsoId("_hRvnECChEeWJd9HF2tO7BA")]
    [Description(@"Person is in a stable union.")]
    StableUnion,

    /// <summary>
    /// Person is separated.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_kwBEwCChEeWJd9HF2tO7BA")]
    [Description(@"Person is separated.")]
    Separated,
}
