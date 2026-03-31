// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of device identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ssun0JfOEeuqNYk2TG3bTg")]
[Description(@"Type of device identification.")]
[DerivedFrom(typeof(DeviceIdentificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeviceIdentificationType1Code>))]
#endif
public enum DeviceIdentificationType1Code
{
    /// <summary>
    /// International Mobile Equipment Identity.
    /// Encoded/decoded by serializers as &quot;IMEI&quot;.
    /// </summary>
    [EnumMember(Value = "IMEI")]
    [IsoId("_XS0CIZfOEeuqNYk2TG3bTg")]
    [Description(@"International Mobile Equipment Identity.")]
    IMEI = DeviceIdentificationTypeCode.IMEI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_XaxrUZfOEeuqNYk2TG3bTg")]
    [Description(@"Other nationally assigned code.")]
    OtherNational = DeviceIdentificationTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_X8TrEZfOEeuqNYk2TG3bTg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate = DeviceIdentificationTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure element ID.
    /// Encoded/decoded by serializers as &quot;SEID&quot;.
    /// </summary>
    [EnumMember(Value = "SEID")]
    [IsoId("_X9ZQMZfOEeuqNYk2TG3bTg")]
    [Description(@"Secure element ID.")]
    SecureElementIdentification = DeviceIdentificationTypeCode.SecureElementIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device serial number.
    /// Encoded/decoded by serializers as &quot;SENU&quot;.
    /// </summary>
    [EnumMember(Value = "SENU")]
    [IsoId("_X-KsQZfOEeuqNYk2TG3bTg")]
    [Description(@"Device serial number.")]
    SerialNumber = DeviceIdentificationTypeCode.SerialNumber, // same ordinal as derivation source for type conversions
}
