// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A type of quantity of financial instrument expressed in a relative size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsEat9p-Ed-ak6NoX_4Aeg_-1769491331")]
[Description(@"A type of quantity of financial instrument expressed in a relative size.")]
[DerivedFrom(typeof(RelativeSizeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RelativeSize1Code>))]
#endif
public enum RelativeSize1Code
{
    /// <summary>
    /// Indicates that the relative size is small.
    /// Encoded/decoded by serializers as &quot;SMAL&quot;.
    /// </summary>
    [EnumMember(Value = "SMAL")]
    [IsoId("_ZsEauNp-Ed-ak6NoX_4Aeg_-1702072394")]
    [Description(@"Indicates that the relative size is small.")]
    Small = RelativeSizeCode.Small, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the relative size is medium.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_ZsEaudp-Ed-ak6NoX_4Aeg_-1702072377")]
    [Description(@"Indicates that the relative size is medium.")]
    Medium = RelativeSizeCode.Medium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the relative size is large.
    /// Encoded/decoded by serializers as &quot;LARG&quot;.
    /// </summary>
    [EnumMember(Value = "LARG")]
    [IsoId("_ZsOLsNp-Ed-ak6NoX_4Aeg_-1702072334")]
    [Description(@"Indicates that the relative size is large.")]
    Large = RelativeSizeCode.Large, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the quantity is undisclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_ZsOLsdp-Ed-ak6NoX_4Aeg_-1702072317")]
    [Description(@"Indicates that the quantity is undisclosed.")]
    Undisclosed = RelativeSizeCode.Undisclosed, // same ordinal as derivation source for type conversions
}
