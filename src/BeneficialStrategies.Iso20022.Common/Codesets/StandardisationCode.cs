// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPnIM9p-Ed-ak6NoX_4Aeg_953734386")]
[Description(
    @"Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined."
)]
[Derivations(typeof(Standardisation1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StandardisationCode>))]
#endif
public enum StandardisationCode
{
    /// <summary>
    /// The underlying instruments, expiration date and contract size of the derivatives are standardised.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_ZPnINNp-Ed-ak6NoX_4Aeg_1629753755")]
    [Description(
        @"The underlying instruments, expiration date and contract size of the derivatives are standardised."
    )]
    Standardised,

    /// <summary>
    /// Custom-made instrument between two parties. Underlying|instruments, expiration date and contract size of the derivatives are not standardised.
    /// Encoded/decoded by serializers as &quot;NSTA&quot;.
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_ZPnINdp-Ed-ak6NoX_4Aeg_1637142377")]
    [Description(
        @"Custom-made instrument between two parties. Underlying|instruments, expiration date and contract size of the derivatives are not standardised."
    )]
    NonStandardised,

    /// <summary>
    /// Derivatives defined according to exchange specifications, but certain characteristics can be user defined.
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_ZPnINtp-Ed-ak6NoX_4Aeg_1638987000")]
    [Description(
        @"Derivatives defined according to exchange specifications, but certain characteristics can be user defined."
    )]
    Flexible,
}
