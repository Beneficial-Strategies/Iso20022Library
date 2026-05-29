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
[IsoId("_hhG8MXbbEfCmC4yYaU27Kg")]
[Description(@"Type of device identification.")]
[DerivedFrom(typeof(DeviceIdentificationTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<DeviceIdentificationType2Code>))]
public enum DeviceIdentificationType2Code
{
    /// <summary>
    /// International Mobile Equipment Identity.
    /// Encoded/decoded by serializers as &quot;IMEI&quot;.
    /// </summary>
    [EnumMember(Value = "IMEI")]
    [IsoId("_hjs9MXbbEfCmC4yYaU27Kg")]
    [Description(@"International Mobile Equipment Identity.")]
    IMEI = DeviceIdentificationTypeCode.IMEI,

    /// <summary>
    /// Secure element ID.
    /// Encoded/decoded by serializers as &quot;SEID&quot;.
    /// </summary>
    [EnumMember(Value = "SEID")]
    [IsoId("_hjs9N3bbEfCmC4yYaU27Kg")]
    [Description(@"Secure element ID.")]
    SecureElementIdentification = DeviceIdentificationTypeCode.SecureElementIdentification,

    /// <summary>
    /// Device serial number.
    /// Encoded/decoded by serializers as &quot;SENU&quot;.
    /// </summary>
    [EnumMember(Value = "SENU")]
    [IsoId("_hjs9OXbbEfCmC4yYaU27Kg")]
    [Description(@"Device serial number.")]
    SerialNumber = DeviceIdentificationTypeCode.SerialNumber,
}
