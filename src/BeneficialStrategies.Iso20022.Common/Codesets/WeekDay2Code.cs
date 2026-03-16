// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the day of the week of the delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AgPzYS-pEeWvZpCvNOLJLQ")]
[Description(@"Specifies the day of the week of the delivery.")]
[DerivedFrom(typeof(WeekDayCode))]
public enum WeekDay2Code
{
    /// <summary>
    /// Wednesday.
    /// Encoded/decoded by serializers as &quot;WEDD&quot;.
    /// </summary>
    [EnumMember(Value = "WEDD")]
    [IsoId("_ArjrhS-pEeWvZpCvNOLJLQ")]
    [Description(@"Wednesday.")]
    Wednesday = WeekDayCode.Wednesday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tuesday.
    /// Encoded/decoded by serializers as &quot;TUED&quot;.
    /// </summary>
    [EnumMember(Value = "TUED")]
    [IsoId("_Arjrhy-pEeWvZpCvNOLJLQ")]
    [Description(@"Tuesday.")]
    Tuesday = WeekDayCode.Tuesday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Thursday.
    /// Encoded/decoded by serializers as &quot;THUD&quot;.
    /// </summary>
    [EnumMember(Value = "THUD")]
    [IsoId("_ArjriS-pEeWvZpCvNOLJLQ")]
    [Description(@"Thursday.")]
    Thursday = WeekDayCode.Thursday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sunday.
    /// Encoded/decoded by serializers as &quot;SUND&quot;.
    /// </summary>
    [EnumMember(Value = "SUND")]
    [IsoId("_Arjriy-pEeWvZpCvNOLJLQ")]
    [Description(@"Sunday.")]
    Sunday = WeekDayCode.Sunday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Saturday.
    /// Encoded/decoded by serializers as &quot;SATD&quot;.
    /// </summary>
    [EnumMember(Value = "SATD")]
    [IsoId("_ArjrjS-pEeWvZpCvNOLJLQ")]
    [Description(@"Saturday.")]
    Saturday = WeekDayCode.Saturday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Monday.
    /// Encoded/decoded by serializers as &quot;MOND&quot;.
    /// </summary>
    [EnumMember(Value = "MOND")]
    [IsoId("_Arjrjy-pEeWvZpCvNOLJLQ")]
    [Description(@"Monday.")]
    Monday = WeekDayCode.Monday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Friday.
    /// Encoded/decoded by serializers as &quot;FRID&quot;.
    /// </summary>
    [EnumMember(Value = "FRID")]
    [IsoId("_ArjrkS-pEeWvZpCvNOLJLQ")]
    [Description(@"Friday.")]
    Friday = WeekDayCode.Friday, // same ordinal as derivation source for type conversions
}
