// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the day of the week of the delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ybdoIJDpEeiZrojxmnmDSQ")]
[Description(@"Specifies the day of the week of the delivery.")]
[DerivedFrom(typeof(WeekDayCode))]
public enum WeekDay3Code
{
    /// <summary>
    /// All Days of the week.
    /// Encoded/decoded by serializers as &quot;ALLD&quot;.
    /// </summary>
    [EnumMember(Value = "ALLD")]
    [IsoId("_2ZZdUZDpEeiZrojxmnmDSQ")]
    [Description(@"All Days of the week.")]
    AllDays = WeekDayCode.AllDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Days of the week excluding bank holidays.
    /// Encoded/decoded by serializers as &quot;XBHL&quot;.
    /// </summary>
    [EnumMember(Value = "XBHL")]
    [IsoId("_2iXMEZDpEeiZrojxmnmDSQ")]
    [Description(@"Days of the week excluding bank holidays.")]
    DaysExcludingBankHolidays = WeekDayCode.DaysExcludingBankHolidays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Days of the week Including bank holidays.
    /// Encoded/decoded by serializers as &quot;IBHL&quot;.
    /// </summary>
    [EnumMember(Value = "IBHL")]
    [IsoId("_2jueAZDpEeiZrojxmnmDSQ")]
    [Description(@"Days of the week Including bank holidays.")]
    DaysIncludingBankHolidays = WeekDayCode.DaysIncludingBankHolidays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Friday.
    /// Encoded/decoded by serializers as &quot;FRID&quot;.
    /// </summary>
    [EnumMember(Value = "FRID")]
    [IsoId("_25D00ZDpEeiZrojxmnmDSQ")]
    [Description(@"Friday.")]
    Friday = WeekDayCode.Friday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Monday.
    /// Encoded/decoded by serializers as &quot;MOND&quot;.
    /// </summary>
    [EnumMember(Value = "MOND")]
    [IsoId("_26Z4oZDpEeiZrojxmnmDSQ")]
    [Description(@"Monday.")]
    Monday = WeekDayCode.Monday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Saturday.
    /// Encoded/decoded by serializers as &quot;SATD&quot;.
    /// </summary>
    [EnumMember(Value = "SATD")]
    [IsoId("_27wjgZDpEeiZrojxmnmDSQ")]
    [Description(@"Saturday.")]
    Saturday = WeekDayCode.Saturday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sunday.
    /// Encoded/decoded by serializers as &quot;SUND&quot;.
    /// </summary>
    [EnumMember(Value = "SUND")]
    [IsoId("_29GnUZDpEeiZrojxmnmDSQ")]
    [Description(@"Sunday.")]
    Sunday = WeekDayCode.Sunday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Thursday.
    /// Encoded/decoded by serializers as &quot;THUD&quot;.
    /// </summary>
    [EnumMember(Value = "THUD")]
    [IsoId("_3HItEZDpEeiZrojxmnmDSQ")]
    [Description(@"Thursday.")]
    Thursday = WeekDayCode.Thursday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tuesday.
    /// Encoded/decoded by serializers as &quot;TUED&quot;.
    /// </summary>
    [EnumMember(Value = "TUED")]
    [IsoId("_3KAa4ZDpEeiZrojxmnmDSQ")]
    [Description(@"Tuesday.")]
    Tuesday = WeekDayCode.Tuesday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Wednesday.
    /// Encoded/decoded by serializers as &quot;WEDD&quot;.
    /// </summary>
    [EnumMember(Value = "WEDD")]
    [IsoId("_3gdzEZDpEeiZrojxmnmDSQ")]
    [Description(@"Wednesday.")]
    Wednesday = WeekDayCode.Wednesday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Weekdays.
    /// Encoded/decoded by serializers as &quot;WDAY&quot;.
    /// </summary>
    [EnumMember(Value = "WDAY")]
    [IsoId("_3h-2AZDpEeiZrojxmnmDSQ")]
    [Description(@"Weekdays.")]
    Weekdays = WeekDayCode.Weekdays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Weekend.
    /// Encoded/decoded by serializers as &quot;WEND&quot;.
    /// </summary>
    [EnumMember(Value = "WEND")]
    [IsoId("_3jSdkZDpEeiZrojxmnmDSQ")]
    [Description(@"Weekend.")]
    Weekend = WeekDayCode.Weekend, // same ordinal as derivation source for type conversions
}
