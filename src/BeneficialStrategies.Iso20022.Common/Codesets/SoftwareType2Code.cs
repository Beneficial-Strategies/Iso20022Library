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
[IsoId("_eSWK0Xn0EfCmC4yYaU27Kg")]
[Description(@"Software type code.")]
[DerivedFrom(typeof(SoftwareTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SoftwareType2Code>))]
public enum SoftwareType2Code
{
    /// <summary>
    /// Application Software.
    /// Encoded/decoded by serializers as &quot;APSW&quot;.
    /// </summary>
    [EnumMember(Value = "APSW")]
    [IsoId("_eU2FNXn0EfCmC4yYaU27Kg")]
    [Description(@"Application Software.")]
    ApplicationSoftware = SoftwareTypeCode.ApplicationSoftware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturer Firmware.
    /// Encoded/decoded by serializers as &quot;MFFW&quot;.
    /// </summary>
    [EnumMember(Value = "MFFW")]
    [IsoId("_eU2FMXn0EfCmC4yYaU27Kg")]
    [Description(@"Manufacturer Firmware.")]
    ManufacturerFirmware = SoftwareTypeCode.ManufacturerFirmware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manufacturer Software.
    /// Encoded/decoded by serializers as &quot;MFSW&quot;.
    /// </summary>
    [EnumMember(Value = "MFSW")]
    [IsoId("_eU2FM3n0EfCmC4yYaU27Kg")]
    [Description(@"Manufacturer Software.")]
    ManufacturerSoftware = SoftwareTypeCode.ManufacturerSoftware, // same ordinal as derivation source for type conversions
}
