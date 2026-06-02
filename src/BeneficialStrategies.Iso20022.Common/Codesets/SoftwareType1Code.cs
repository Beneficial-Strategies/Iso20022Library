// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Software type code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IzkegG6hEe6DxcrvCrq6hQ")]
[Description(@"Software type code.")]
[DerivedFrom(typeof(SoftwareTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SoftwareType1Code>))]
public enum SoftwareType1Code
{
    /// <summary>
    /// Application Software.
    /// Encoded/decoded by serializers as &quot;APSW&quot;.
    /// </summary>
    [EnumMember(Value = "APSW")]
    [IsoId("_LeEV5W6hEe6DxcrvCrq6hQ")]
    [Description(@"Application Software.")]
    ApplicationSoftware = SoftwareTypeCode.ApplicationSoftware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturer Firmware.
    /// Encoded/decoded by serializers as &quot;MFFW&quot;.
    /// </summary>
    [EnumMember(Value = "MFFW")]
    [IsoId("_LeEV4W6hEe6DxcrvCrq6hQ")]
    [Description(@"Manufacturer Firmware.")]
    ManufacturerFirmware = SoftwareTypeCode.ManufacturerFirmware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturer Software.
    /// Encoded/decoded by serializers as &quot;MFSW&quot;.
    /// </summary>
    [EnumMember(Value = "MFSW")]
    [IsoId("_LeEV426hEe6DxcrvCrq6hQ")]
    [Description(@"Manufacturer Software.")]
    ManufacturerSoftware = SoftwareTypeCode.ManufacturerSoftware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_LeEV6W6hEe6DxcrvCrq6hQ")]
    [Description(@"National code.")]
    OtherNational = SoftwareTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Private code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_LeEV526hEe6DxcrvCrq6hQ")]
    [Description(@"Private code.")]
    OtherPrivate = SoftwareTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
