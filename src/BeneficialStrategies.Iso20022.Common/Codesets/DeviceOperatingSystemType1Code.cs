// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of operating system deployed on device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1J-XwJfREeuqNYk2TG3bTg")]
[Description(@"Type of operating system deployed on device.")]
[DerivedFrom(typeof(DeviceOperatingSystemTypeCode))]
public enum DeviceOperatingSystemType1Code
{
    /// <summary>
    /// Android operating system.
    /// Encoded/decoded by serializers as &quot;DROI&quot;.
    /// </summary>
    [EnumMember(Value = "DROI")]
    [IsoId("_6BpRUZfREeuqNYk2TG3bTg")]
    [Description(@"Android operating system.")]
    Android = DeviceOperatingSystemTypeCode.Android, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Blackberry operating system.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_6JoIoZfREeuqNYk2TG3bTg")]
    [Description(@"Blackberry operating system.")]
    Blackberry = DeviceOperatingSystemTypeCode.Blackberry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// iOS operating system.
    /// Encoded/decoded by serializers as &quot;IOSS&quot;.
    /// </summary>
    [EnumMember(Value = "IOSS")]
    [IsoId("_6sbTsZfREeuqNYk2TG3bTg")]
    [Description(@"iOS operating system.")]
    iOS = DeviceOperatingSystemTypeCode.iOS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other nationally defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6tJscZfREeuqNYk2TG3bTg")]
    [Description(@"Other nationally defined code.")]
    OtherNational = DeviceOperatingSystemTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other privately defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6t2QAZfREeuqNYk2TG3bTg")]
    [Description(@"Other privately defined code.")]
    OtherPrivate = DeviceOperatingSystemTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tizen operating system.
    /// Encoded/decoded by serializers as &quot;TIZN&quot;.
    /// </summary>
    [EnumMember(Value = "TIZN")]
    [IsoId("_6uizkZfREeuqNYk2TG3bTg")]
    [Description(@"Tizen operating system.")]
    Tizen = DeviceOperatingSystemTypeCode.Tizen, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Windows operating system.
    /// Encoded/decoded by serializers as &quot;WIND&quot;.
    /// </summary>
    [EnumMember(Value = "WIND")]
    [IsoId("_6vU2sZfREeuqNYk2TG3bTg")]
    [Description(@"Windows operating system.")]
    Windows = DeviceOperatingSystemTypeCode.Windows, // same ordinal as derivation source for type conversions
    
}
