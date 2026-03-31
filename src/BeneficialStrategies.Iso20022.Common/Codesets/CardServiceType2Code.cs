// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of network management service (correspond to the ISO 8583 field 24).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Xg9gcHvEEeSKFIcWw3l4Yw")]
[Description(@"Type of network management service (correspond to the ISO 8583 field 24).")]
[DerivedFrom(typeof(CardServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardServiceType2Code>))]
#endif
public enum CardServiceType2Code
{
    /// <summary>
    /// Close communication at application level to stop store and forward process.
    /// Encoded/decoded by serializers as &quot;SFDS&quot;.
    /// </summary>
    [EnumMember(Value = "SFDS")]
    [IsoId("_gNOtAXvEEeSKFIcWw3l4Yw")]
    [Description(@"Close communication at application level to stop store and forward process.")]
    DisableStoreForward = CardServiceTypeCode.DisableStoreForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Detection whether communication at application level is still active.
    /// Encoded/decoded by serializers as &quot;ECHO&quot;.
    /// </summary>
    [EnumMember(Value = "ECHO")]
    [IsoId("_gYs9M3vEEeSKFIcWw3l4Yw")]
    [Description(@"Detection whether communication at application level is still active.")]
    EchoTest = CardServiceTypeCode.EchoTest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Establish communication at application level to start store and forward process.
    /// Encoded/decoded by serializers as &quot;SFEN&quot;.
    /// </summary>
    [EnumMember(Value = "SFEN")]
    [IsoId("_gkU-Y3vEEeSKFIcWw3l4Yw")]
    [Description(
        @"Establish communication at application level to start store and forward process."
    )]
    EnableStoreForward = CardServiceTypeCode.EnableStoreForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminate communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNF&quot;.
    /// </summary>
    [EnumMember(Value = "SGNF")]
    [IsoId("_gxJSY3vEEeSKFIcWw3l4Yw")]
    [Description(@"Terminate communication at application level.")]
    SignOff = CardServiceTypeCode.SignOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Establish communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNN&quot;.
    /// </summary>
    [EnumMember(Value = "SGNN")]
    [IsoId("_g6ro43vEEeSKFIcWw3l4Yw")]
    [Description(@"Establish communication at application level.")]
    SignOn = CardServiceTypeCode.SignOn, // same ordinal as derivation source for type conversions
}
