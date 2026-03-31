// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of value used for a loyalty programme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IZ8fYF_CEee_oqB7UglxLw")]
[Description(@"Type of value used for a loyalty programme.")]
[DerivedFrom(typeof(LoyaltyValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LoyaltyValueType1Code>))]
#endif
public enum LoyaltyValueType1Code
{
    /// <summary>
    /// Value expressed in miles.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_NAqL0V_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in miles.")]
    Miles = LoyaltyValueTypeCode.Miles, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value expressed in monetary units.
    /// Encoded/decoded by serializers as &quot;MONE&quot;.
    /// </summary>
    [EnumMember(Value = "MONE")]
    [IsoId("_NUmbgV_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in monetary units.")]
    Monetary = LoyaltyValueTypeCode.Monetary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value expressed in any other type of loyalty value.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Nk0BwV_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in any other type of loyalty value.")]
    Other = LoyaltyValueTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value expressed in points.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_NzPfUV_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in points.")]
    Points = LoyaltyValueTypeCode.Points, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value expressed in a private currency.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_OBhy8V_CEee_oqB7UglxLw")]
    [Description(@"Value expressed in a private currency.")]
    PrivateCurrency = LoyaltyValueTypeCode.PrivateCurrency, // same ordinal as derivation source for type conversions
}
