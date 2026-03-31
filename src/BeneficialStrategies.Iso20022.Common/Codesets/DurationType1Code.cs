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
[IsoId("_fLDx4A3eEeW9YKj3GUmIEw")]
[Description(@"Specifies the duration of the delivery period.")]
[DerivedFrom(typeof(DurationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DurationType1Code>))]
#endif
public enum DurationType1Code
{
    /// <summary>
    /// Duration is a year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_J_AT8RVqEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a year.")]
    Year = DurationTypeCode.Year, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_KNSAgRVqEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every week.")]
    Week = DurationTypeCode.Week, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every six months or two times a year.
    /// Encoded/decoded by serializers as &quot;SEAS&quot;.
    /// </summary>
    [EnumMember(Value = "SEAS")]
    [IsoId("_KTiZgRVqEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every six months or two times a year.")]
    Season = DurationTypeCode.Season, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every three months or four times a year.
    /// Encoded/decoded by serializers as &quot;QURT&quot;.
    /// </summary>
    [EnumMember(Value = "QURT")]
    [IsoId("_KfbgcRVqEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every three months or four times a year.")]
    Quarter = DurationTypeCode.Quarter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event takes place every month or once a month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Kta5IRVqEeWkV7eOBXXT7Q")]
    [Description(@"Event takes place every month or once a month.")]
    Month = DurationTypeCode.Month, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duration is a minute.
    /// Encoded/decoded by serializers as &quot;MNUT&quot;.
    /// </summary>
    [EnumMember(Value = "MNUT")]
    [IsoId("_Kxb2cRVqEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a minute.")]
    Minute = DurationTypeCode.Minute, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duration is an hour.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_K9euYRVqEeWkV7eOBXXT7Q")]
    [Description(@"Duration is an hour.")]
    Hour = DurationTypeCode.Hour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duration is a day.
    /// Encoded/decoded by serializers as &quot;DASD&quot;.
    /// </summary>
    [EnumMember(Value = "DASD")]
    [IsoId("_LLdgARVqEeWkV7eOBXXT7Q")]
    [Description(@"Duration is a day.")]
    Day = DurationTypeCode.Day, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duration is expressed in another unit.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_g4ZDwUDeEeWt96EosbOZ-w")]
    [Description(@"Duration is expressed in another unit.")]
    Other = DurationTypeCode.Other, // same ordinal as derivation source for type conversions
}
