// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wac008EaEea7jLfvGi1PDw")]
[Description(
    @"Specifies the collateral type against which all repurchase agreements are conducted."
)]
[DerivedFrom(typeof(SpecialCollateralCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SpecialCollateral2Code>))]
#endif
public enum SpecialCollateral2Code
{
    /// <summary>
    /// Identifies that all repurchase agreements are conducted against general collateral.
    /// Encoded/decoded by serializers as &quot;GENE&quot;.
    /// </summary>
    [EnumMember(Value = "GENE")]
    [IsoId("_wac01MEaEea7jLfvGi1PDw")]
    [Description(
        @"Identifies that all repurchase agreements are conducted against general collateral."
    )]
    GeneralCollateral = SpecialCollateralCode.GeneralCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies that all repurchase agreements are conducted against special collateral.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_wac01cEaEea7jLfvGi1PDw")]
    [Description(
        @"Identifies that all repurchase agreements are conducted against special collateral."
    )]
    SpecialCollateral = SpecialCollateralCode.SpecialCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash.
    /// Encoded/decoded by serializers as &quot;MRRP&quot;.
    /// </summary>
    [EnumMember(Value = "MRRP")]
    [IsoId("_1CXbIcEaEea7jLfvGi1PDw")]
    [Description(
        @"Identifies that this is a securities lending transaction, made of repurchase agreements and reverse repurchase agreements versus cash."
    )]
    MatchedAndReverseRepurchaseAgreement =
        SpecialCollateralCode.MatchedAndReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
}
