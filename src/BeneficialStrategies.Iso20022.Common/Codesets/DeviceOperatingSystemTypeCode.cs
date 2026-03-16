// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of operating system deployed on device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KCcGUJfQEeuqNYk2TG3bTg")]
[Description(@"Type of operating system deployed on device.")]
[Derivations(typeof(DeviceOperatingSystemType1Code))]
public enum DeviceOperatingSystemTypeCode
{
    /// <summary>
    /// Android operating system.
    /// Encoded/decoded by serializers as &quot;DROI&quot;.
    /// </summary>
    [EnumMember(Value = "DROI")]
    [IsoId("_V5SYgJfQEeuqNYk2TG3bTg")]
    [Description(@"Android operating system.")]
    Android,

    /// <summary>
    /// iOS operating system.
    /// Encoded/decoded by serializers as &quot;IOSS&quot;.
    /// </summary>
    [EnumMember(Value = "IOSS")]
    [IsoId("_cBa0YJfQEeuqNYk2TG3bTg")]
    [Description(@"iOS operating system.")]
    iOS,

    /// <summary>
    /// Windows operating system.
    /// Encoded/decoded by serializers as &quot;WIND&quot;.
    /// </summary>
    [EnumMember(Value = "WIND")]
    [IsoId("_xg0VMJfQEeuqNYk2TG3bTg")]
    [Description(@"Windows operating system.")]
    Windows,

    /// <summary>
    /// Blackberry operating system.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_Wcn5oJfREeuqNYk2TG3bTg")]
    [Description(@"Blackberry operating system.")]
    Blackberry,

    /// <summary>
    /// Tizen operating system.
    /// Encoded/decoded by serializers as &quot;TIZN&quot;.
    /// </summary>
    [EnumMember(Value = "TIZN")]
    [IsoId("_cmnWsJfREeuqNYk2TG3bTg")]
    [Description(@"Tizen operating system.")]
    Tizen,

    /// <summary>
    /// Other nationally defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_in48oJfREeuqNYk2TG3bTg")]
    [Description(@"Other nationally defined code.")]
    OtherNational,

    /// <summary>
    /// Other privately defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_roPi0JfREeuqNYk2TG3bTg")]
    [Description(@"Other privately defined code.")]
    OtherPrivate,
}
