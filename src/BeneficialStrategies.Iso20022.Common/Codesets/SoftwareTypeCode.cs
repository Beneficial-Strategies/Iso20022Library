// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify software type
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XMzqYG6gEe6DxcrvCrq6hQ")]
[Description(@"Code to identify software type")]
[Derivations(typeof(SoftwareType1Code), typeof(SoftwareType2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SoftwareTypeCode>))]
public enum SoftwareTypeCode
{
    /// <summary>
    /// Application Software.
    /// Encoded/decoded by serializers as &quot;APSW&quot;.
    /// </summary>
    [EnumMember(Value = "APSW")]
    [IsoId("_4K74UG6gEe6DxcrvCrq6hQ")]
    [Description(@"Application Software.")]
    ApplicationSoftware,

    /// <summary>
    /// Manufacturer Firmware.
    /// Encoded/decoded by serializers as &quot;MFFW&quot;.
    /// </summary>
    [EnumMember(Value = "MFFW")]
    [IsoId("_k4v18G6gEe6DxcrvCrq6hQ")]
    [Description(@"Manufacturer Firmware.")]
    ManufacturerFirmware,

    /// <summary>
    /// Manufacturer Software.
    /// Encoded/decoded by serializers as &quot;MFSW&quot;.
    /// </summary>
    [EnumMember(Value = "MFSW")]
    [IsoId("_wGReUG6gEe6DxcrvCrq6hQ")]
    [Description(@"Manufacturer Software.")]
    ManufacturerSoftware,

    /// <summary>
    /// National code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_BicaQG6hEe6DxcrvCrq6hQ")]
    [Description(@"National code.")]
    OtherNational,

    /// <summary>
    /// Private code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_8GP3UG6gEe6DxcrvCrq6hQ")]
    [Description(@"Private code.")]
    OtherPrivate,
}
