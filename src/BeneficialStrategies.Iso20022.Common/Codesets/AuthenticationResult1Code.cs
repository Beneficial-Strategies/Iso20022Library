// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the result of authentication done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rETL4Pm3EeaYndR2y_Ep9g")]
[Description(@"Specifies the result of authentication done.")]
[DerivedFrom(typeof(AuthenticationResultCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthenticationResult1Code>))]
#endif
public enum AuthenticationResult1Code
{
    /// <summary>
    /// The authentication didn’t succeed.
    /// Encoded/decoded by serializers as &quot;DENY&quot;.
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_vwOIcfm3EeaYndR2y_Ep9g")]
    [Description(@"The authentication didn’t succeed.")]
    Denial = AuthenticationResultCode.Denial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant not enrolled in the authentication programme.
    /// Encoded/decoded by serializers as &quot;MRCH&quot;.
    /// </summary>
    [EnumMember(Value = "MRCH")]
    [IsoId("_v3DwQfm3EeaYndR2y_Ep9g")]
    [Description(@"Merchant not enrolled in the authentication programme.")]
    MerchantNotEnroled = AuthenticationResultCode.MerchantNotEnroled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The card does not participate in the authentication programme.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_v9wOIfm3EeaYndR2y_Ep9g")]
    [Description(@"The card does not participate in the authentication programme.")]
    NonParticipation = AuthenticationResultCode.NonParticipation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The authentication couldn’t be carried out.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_wHR9kfm3EeaYndR2y_Ep9g")]
    [Description(@"The authentication couldn’t be carried out.")]
    UnableToAuthenticate = AuthenticationResultCode.UnableToAuthenticate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication succeeded with a cryptogram.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_wMfNsfm3EeaYndR2y_Ep9g")]
    [Description(@"Authentication succeeded with a cryptogram.")]
    WithCryptogram = AuthenticationResultCode.WithCryptogram, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication succeeded without a cryptogram.
    /// Encoded/decoded by serializers as &quot;UCRP&quot;.
    /// </summary>
    [EnumMember(Value = "UCRP")]
    [IsoId("_wR_Ywfm3EeaYndR2y_Ep9g")]
    [Description(@"Authentication succeeded without a cryptogram.")]
    WithoutCryptogram = AuthenticationResultCode.WithoutCryptogram, // same ordinal as derivation source for type conversions
}
