// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of operating system deployed on device, as published separately in an external device operating system type code set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExternalDeviceOperatingSystemType1Code")]
[Description(
    @"Type of operating system deployed on device, as published separately in an external device operating system type code set."
)]
[DerivedFrom(typeof(ExternalDeviceOperatingSystemTypeCode))]
public enum ExternalDeviceOperatingSystemType1Code
{
    /// <summary>
    /// Blackberry operating system.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_ExternalDeviceOperatingSystemType1Code_Blackberry")]
    [Description(@"Blackberry operating system.")]
    Blackberry = ExternalDeviceOperatingSystemTypeCode.Blackberry,

    /// <summary>
    /// Android operating system.
    /// Encoded/decoded by serializers as &quot;DROI&quot;.
    /// </summary>
    [EnumMember(Value = "DROI")]
    [IsoId("_ExternalDeviceOperatingSystemType1Code_Android")]
    [Description(@"Android operating system.")]
    Android = ExternalDeviceOperatingSystemTypeCode.Android,

    /// <summary>
    /// iOS operating System.
    /// Encoded/decoded by serializers as &quot;IOSS&quot;.
    /// </summary>
    [EnumMember(Value = "IOSS")]
    [IsoId("_ExternalDeviceOperatingSystemType1Code_iOS")]
    [Description(@"iOS operating System.")]
    iOS = ExternalDeviceOperatingSystemTypeCode.iOS,

    /// <summary>
    /// Tizen operating system.
    /// Encoded/decoded by serializers as &quot;TIZN&quot;.
    /// </summary>
    [EnumMember(Value = "TIZN")]
    [IsoId("_ExternalDeviceOperatingSystemType1Code_Tizen")]
    [Description(@"Tizen operating system.")]
    Tizen = ExternalDeviceOperatingSystemTypeCode.Tizen,

    /// <summary>
    /// Windows operating system.
    /// Encoded/decoded by serializers as &quot;WIND&quot;.
    /// </summary>
    [EnumMember(Value = "WIND")]
    [IsoId("_ExternalDeviceOperatingSystemType1Code_Windows")]
    [Description(@"Windows operating system.")]
    Windows = ExternalDeviceOperatingSystemTypeCode.Windows,
}
