// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the tenor of the interest rate index (when the interest rate is paid out).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mDriYI9GEeqMo4JxiuZGSw")]
[Description(@"Specifies the tenor of the interest rate index (when the interest rate is paid out).")]
public enum InterestRateIndexTenor2Code
{
    /// <summary>
    /// Tenor is IntraDay.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_fwbwwo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is IntraDay.")]
    IntraDay = 0,

    /// <summary>
    /// Tenor is 1 month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_f5keoo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 1 month.")]
    Month1 = 1,

    /// <summary>
    /// Tenor is 12 months.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_gA0WIo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 12 months.")]
    Month12 = 2,

    /// <summary>
    /// Tenor is 2 months.
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_gGHs4o9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 2 months.")]
    Month2 = 3,

    /// <summary>
    /// Tenor is 3 months.
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_gMgowo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 3 months.")]
    Month3 = 4,

    /// <summary>
    /// Tenor is 4 months.
    /// Encoded/decoded by serializers as &quot;FOMN&quot;.
    /// </summary>
    [EnumMember(Value = "FOMN")]
    [IsoId("_gSt-cI9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 4 months.")]
    Month4 = 5,

    /// <summary>
    /// Tenor is 6 months.
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_ga2mwo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 6 months.")]
    Month6 = 6,

    /// <summary>
    /// Tenor is overnght.
    /// Encoded/decoded by serializers as &quot;OVNG&quot;.
    /// </summary>
    [EnumMember(Value = "OVNG")]
    [IsoId("_grH3Yo9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is overnght.")]
    Overnight = 7,

    /// <summary>
    /// Tenor is 1 week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_gzVYMY9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 1 week.	")]
    Week1 = 8,

    /// <summary>
    /// Tenor is 2 weeks.
    /// Encoded/decoded by serializers as &quot;TOWK&quot;.
    /// </summary>
    [EnumMember(Value = "TOWK")]
    [IsoId("_g5Ok0Y9IEeqMo4JxiuZGSw")]
    [Description(@"Tenor is 2 weeks.")]
    Week2 = 9,

}
