// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of identification for the device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KxndUJfMEeuqNYk2TG3bTg")]
[Description(@"Type of identification for the device.")]
[Derivations(typeof(DeviceIdentificationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeviceIdentificationTypeCode>))]
#endif
public enum DeviceIdentificationTypeCode
{
    /// <summary>
    /// International Mobile Equipment Identity.
    /// Encoded/decoded by serializers as &quot;IMEI&quot;.
    /// </summary>
    [EnumMember(Value = "IMEI")]
    [IsoId("_VFsVMJfMEeuqNYk2TG3bTg")]
    [Description(@"International Mobile Equipment Identity.")]
    IMEI,

    /// <summary>
    /// Device serial number.
    /// Encoded/decoded by serializers as &quot;SENU&quot;.
    /// </summary>
    [EnumMember(Value = "SENU")]
    [IsoId("_mqqAwJfMEeuqNYk2TG3bTg")]
    [Description(@"Device serial number.")]
    SerialNumber,

    /// <summary>
    /// Secure element ID.
    /// Encoded/decoded by serializers as &quot;SEID&quot;.
    /// </summary>
    [EnumMember(Value = "SEID")]
    [IsoId("_Fh1JQJfNEeuqNYk2TG3bTg")]
    [Description(@"Secure element ID.")]
    SecureElementIdentification,

    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_MVjf0JfNEeuqNYk2TG3bTg")]
    [Description(@"Other nationally assigned code.")]
    OtherNational,

    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_YTPZ0JfNEeuqNYk2TG3bTg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate,
}
