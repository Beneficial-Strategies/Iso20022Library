// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of period unit to be used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cEV6kZmhEe6Qpd-x8YgzaA")]
[Description(@"Type of period unit to be used.")]
[DerivedFrom(typeof(PeriodUnitCode))]
public enum PeriodUnit4Code
{
    /// <summary>
    /// Counted in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("")]
    [Description(@"Counted in days.")]
    Days = PeriodUnitCode.Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra Days
    /// Encoded/decoded by serializers as &quot;EXDY&quot;.
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("")]
    [Description(@"Extra Days")]
    ExtraDays = PeriodUnitCode.ExtraDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Half days
    /// Encoded/decoded by serializers as &quot;HFDA&quot;.
    /// </summary>
    [EnumMember(Value = "HFDA")]
    [IsoId("")]
    [Description(@"Half days")]
    HalfDays = PeriodUnitCode.HalfDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period unit expressed in hours.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("")]
    [Description(@"Period unit expressed in hours.")]
    Hours = PeriodUnitCode.Hours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period unit expressed in minutes
    /// Encoded/decoded by serializers as &quot;MINU&quot;.
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("")]
    [Description(@"Period unit expressed in minutes")]
    Minutes = PeriodUnitCode.Minutes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("")]
    [Description(@"Counted in months.")]
    Months = PeriodUnitCode.Months, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("")]
    [Description(@"Other National")]
    OtherNational = PeriodUnitCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("")]
    [Description(@"Other Private")]
    OtherPrivate = PeriodUnitCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in some other unit.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Counted in some other unit.")]
    Other = PeriodUnitCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("")]
    [Description(@"Counted in weeks.")]
    Weeks = PeriodUnitCode.Weeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("")]
    [Description(@"Counted in years.")]
    Years = PeriodUnitCode.Years, // same ordinal as derivation source for type conversions
}
