// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the duration of the delivery period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SuhYsA3eEeW9YKj3GUmIEw")]
[Description(@"Specifies the duration of the delivery period.")]
[Derivations(typeof(DurationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DurationTypeCode>))]
#endif
public enum DurationTypeCode
{
    /// <summary>
    /// Duration is a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ZymlABVpEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a year.")]
    Year,

    /// <summary>
    /// Duration is a day.
    /// Encoded/decoded by serializers as &quot;DASD&quot;.
    /// </summary>
    [EnumMember(Value = "DASD")]
    [IsoId("_ZymlBxVpEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a day.")]
    Day,

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ZymlEBVpEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every month or once a month.")]
    Month,

    /// <summary>
    /// Duration is a minute.
    /// Encoded/decoded by serializers as &quot;MNUT&quot;.
    /// </summary>
    [EnumMember(Value = "MNUT")]
    [IsoId("_ZymlFxVpEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a minute.")]
    Minute,

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_ZymlGBVpEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarter,

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEAS&quot;.
    /// </summary>
    [EnumMember(Value = "SEAS")]
    [IsoId("_ZymlHxVpEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every six months or two times a year.")]
    Season,

    /// <summary>
    /// Event takes place every week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ZymlJRVpEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every week.")]
    Week,

    /// <summary>
    /// Duration is an hour.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_85z_UBVpEeWkV7eOBXXT7Q")]
    [Description(@"Duration is an hour.")]
    Hour,

    /// <summary>
    /// Duration is expressed in another unit.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_c0MOgEDeEeWt96EosbOZ-w")]
    [Description(@"Duration is expressed in another unit.")]
    Other,
}
