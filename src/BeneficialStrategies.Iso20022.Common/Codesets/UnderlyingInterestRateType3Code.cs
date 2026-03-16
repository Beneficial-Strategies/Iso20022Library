// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an underlying contract for interest rate derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NdyGMICmEea6KOHFXW8q7A")]
[Description(@"Specifies the type of an underlying contract for interest rate derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingInterestRateType3Code
{
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_UWAiQYCmEea6KOHFXW8q7A")]
    [Description(@"Underlying is a bond.")]
    Bond = UnderlyingTypeV3Code.Bond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a bond future.
    /// Encoded/decoded by serializers as &quot;BNDF&quot;.
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_U0WrIYCmEea6KOHFXW8q7A")]
    [Description(@"Underlying is a bond future.")]
    BondFuture = UnderlyingTypeV3Code.BondFuture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is interest rate.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_V2Q0EYCmEea6KOHFXW8q7A")]
    [Description(@"Underlying is interest rate.")]
    InterestRate = UnderlyingTypeV3Code.InterestRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is an interest rate future or a forward rate agreement (FRA).
    /// Encoded/decoded by serializers as &quot;IFUT&quot;.
    /// </summary>
    [EnumMember(Value = "IFUT")]
    [IsoId("_WVWj0YCmEea6KOHFXW8q7A")]
    [Description(@"Underlying is an interest rate future or a forward rate agreement (FRA).")]
    InterestRateFutureFRA = UnderlyingTypeV3Code.InterestRateFutureFRA, // same ordinal as derivation source for type conversions
}
