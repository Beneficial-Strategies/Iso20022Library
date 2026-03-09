// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the day of the week of the delivery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vVeyEA3eEeW9YKj3GUmIEw")]
[Description(@"Specifies the day of the week of the delivery.")]
[Derivations(typeof(WeekDay2Code),typeof(WeekDay3Code))]
public enum WeekDayCode
{
    /// <summary>
    /// Weekdays.
    /// Encoded/decoded by serializers as &quot;WDAY&quot;.
    /// </summary>
    [EnumMember(Value = "WDAY")]
    [IsoId("_xLwXMA3eEeW9YKj3GUmIEw")]
    [Description(@"Weekdays.")]
    Weekdays,
    
    /// <summary>
    /// Weekend.
    /// Encoded/decoded by serializers as &quot;WEND&quot;.
    /// </summary>
    [EnumMember(Value = "WEND")]
    [IsoId("_nCYr8BVcEeWLrt6TQWUeiw")]
    [Description(@"Weekend.")]
    Weekend,
    
    /// <summary>
    /// Monday.
    /// Encoded/decoded by serializers as &quot;MOND&quot;.
    /// </summary>
    [EnumMember(Value = "MOND")]
    [IsoId("_nKkXkBVcEeWLrt6TQWUeiw")]
    [Description(@"Monday.")]
    Monday,
    
    /// <summary>
    /// Tuesday.
    /// Encoded/decoded by serializers as &quot;TUED&quot;.
    /// </summary>
    [EnumMember(Value = "TUED")]
    [IsoId("_nKkXkRVcEeWLrt6TQWUeiw")]
    [Description(@"Tuesday.")]
    Tuesday,
    
    /// <summary>
    /// Wednesday.
    /// Encoded/decoded by serializers as &quot;WEDD&quot;.
    /// </summary>
    [EnumMember(Value = "WEDD")]
    [IsoId("_nKkXkhVcEeWLrt6TQWUeiw")]
    [Description(@"Wednesday.")]
    Wednesday,
    
    /// <summary>
    /// Thursday.
    /// Encoded/decoded by serializers as &quot;THUD&quot;.
    /// </summary>
    [EnumMember(Value = "THUD")]
    [IsoId("_nKkXkxVcEeWLrt6TQWUeiw")]
    [Description(@"Thursday.")]
    Thursday,
    
    /// <summary>
    /// Friday.
    /// Encoded/decoded by serializers as &quot;FRID&quot;.
    /// </summary>
    [EnumMember(Value = "FRID")]
    [IsoId("_nTC-IBVcEeWLrt6TQWUeiw")]
    [Description(@"Friday.")]
    Friday,
    
    /// <summary>
    /// Saturday.
    /// Encoded/decoded by serializers as &quot;SATD&quot;.
    /// </summary>
    [EnumMember(Value = "SATD")]
    [IsoId("_nTC-IRVcEeWLrt6TQWUeiw")]
    [Description(@"Saturday.")]
    Saturday,
    
    /// <summary>
    /// Sunday.
    /// Encoded/decoded by serializers as &quot;SUND&quot;.
    /// </summary>
    [EnumMember(Value = "SUND")]
    [IsoId("_na7u0BVcEeWLrt6TQWUeiw")]
    [Description(@"Sunday.")]
    Sunday,
    
    /// <summary>
    /// All Days of the week.
    /// Encoded/decoded by serializers as &quot;ALLD&quot;.
    /// </summary>
    [EnumMember(Value = "ALLD")]
    [IsoId("_vbnBQJDoEeiZrojxmnmDSQ")]
    [Description(@"All Days of the week.")]
    AllDays,
    
    /// <summary>
    /// Days of the week Including bank holidays.
    /// Encoded/decoded by serializers as &quot;IBHL&quot;.
    /// </summary>
    [EnumMember(Value = "IBHL")]
    [IsoId("__ggBMJDoEeiZrojxmnmDSQ")]
    [Description(@"Days of the week Including bank holidays.")]
    DaysIncludingBankHolidays,
    
    /// <summary>
    /// Days of the week excluding bank holidays.
    /// Encoded/decoded by serializers as &quot;XBHL&quot;.
    /// </summary>
    [EnumMember(Value = "XBHL")]
    [IsoId("_feUBoZDpEeiZrojxmnmDSQ")]
    [Description(@"Days of the week excluding bank holidays.")]
    DaysExcludingBankHolidays,
    
}
