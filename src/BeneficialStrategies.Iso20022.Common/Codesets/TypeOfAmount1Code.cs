// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the amount associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUJ9MwEcEeCQm6a_G2yO_w_-427781044")]
[Description(@"Qualifies the amount associated with the transaction.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfAmount1Code>))]
#endif
public enum TypeOfAmount1Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_TUJ9NAEcEeCQm6a_G2yO_w_1589618959")]
    [Description(@"Actual amount.")]
    Actual = TypeOfAmountCode.Actual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_TUJ9NQEcEeCQm6a_G2yO_w_-630255646")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated = TypeOfAmountCode.Estimated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_TUJ9NgEcEeCQm6a_G2yO_w_1200667523")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_TUJ9NwEcEeCQm6a_G2yO_w_-1157074600")]
    [Description(@"Default amount.")]
    Default = TypeOfAmountCode.Default, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacement amount.
    /// Encoded/decoded by serializers as &quot;RPLT&quot;.
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_TUJ9OAEcEeCQm6a_G2yO_w_-952745682")]
    [Description(@"Replacement amount.")]
    Replacement = TypeOfAmountCode.Replacement, // same ordinal as derivation source for type conversions
}
