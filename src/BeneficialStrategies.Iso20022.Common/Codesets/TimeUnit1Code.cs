// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of time associated with the contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yl41wdp-Ed-ak6NoX_4Aeg_2073766777")]
[Description(@"Unit of time associated with the contract.")]
[DerivedFrom(typeof(TimeUnitCode))]
public enum TimeUnit1Code
{
    /// <summary>
    /// Time unit is calendar day.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_Yl41wtp-Ed-ak6NoX_4Aeg_-1921054302")]
    [Description(@"Time unit is calendar day.")]
    CalendarDay = TimeUnitCode.CalendarDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is hour.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_Yl41w9p-Ed-ak6NoX_4Aeg_-1921054301")]
    [Description(@"Time unit is hour.")]
    Hour = TimeUnitCode.Hour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is minute.
    /// Encoded/decoded by serializers as &quot;MINU&quot;.
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("_Yl41xNp-Ed-ak6NoX_4Aeg_-1921054284")]
    [Description(@"Time unit is minute.")]
    Minute = TimeUnitCode.Minute, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is month.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Yl41xdp-Ed-ak6NoX_4Aeg_-1921054283")]
    [Description(@"Time unit is month.")]
    Month = TimeUnitCode.Month, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is second.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_Yl41xtp-Ed-ak6NoX_4Aeg_-1921054275")]
    [Description(@"Time unit is second.")]
    Second = TimeUnitCode.Second, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is week.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_Yl41x9p-Ed-ak6NoX_4Aeg_-1921054259")]
    [Description(@"Time unit is week.")]
    Week = TimeUnitCode.Week, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Time unit is year.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_Yl41yNp-Ed-ak6NoX_4Aeg_-1921054258")]
    [Description(@"Time unit is year.")]
    Year = TimeUnitCode.Year, // same ordinal as derivation source for type conversions
}
