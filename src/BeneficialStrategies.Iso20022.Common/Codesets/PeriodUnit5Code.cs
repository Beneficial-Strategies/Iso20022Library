// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of period unit to be used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wJ7MXnwEfCmC4yYaU27Kg")]
[Description(@"Type of period unit to be used.")]
[DerivedFrom(typeof(PeriodUnitCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PeriodUnit5Code>))]
public enum PeriodUnit5Code
{
    /// <summary>
    /// Counted in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("__yyYe3nwEfCmC4yYaU27Kg")]
    [Description(@"Counted in days.")]
    Days = PeriodUnitCode.Days, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra Days
    /// Encoded/decoded by serializers as &quot;EXDY&quot;.
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("__yyYfXnwEfCmC4yYaU27Kg")]
    [Description(@"Extra Days")]
    ExtraDays = PeriodUnitCode.ExtraDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Half days
    /// Encoded/decoded by serializers as &quot;HFDA&quot;.
    /// </summary>
    [EnumMember(Value = "HFDA")]
    [IsoId("__yyYgXnwEfCmC4yYaU27Kg")]
    [Description(@"Half days")]
    HalfDays = PeriodUnitCode.HalfDays, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period unit expressed in hours.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("__yyYg3nwEfCmC4yYaU27Kg")]
    [Description(@"Period unit expressed in hours.")]
    Hours = PeriodUnitCode.Hours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period unit expressed in minutes
    /// Encoded/decoded by serializers as &quot;MINU&quot;.
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("__yyYf3nwEfCmC4yYaU27Kg")]
    [Description(@"Period unit expressed in minutes")]
    Minutes = PeriodUnitCode.Minutes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("__yyYdXnwEfCmC4yYaU27Kg")]
    [Description(@"Counted in months.")]
    Months = PeriodUnitCode.Months, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("__yyYd3nwEfCmC4yYaU27Kg")]
    [Description(@"Counted in weeks.")]
    Weeks = PeriodUnitCode.Weeks, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counted in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("__yyYeXnwEfCmC4yYaU27Kg")]
    [Description(@"Counted in years.")]
    Years = PeriodUnitCode.Years, // same ordinal as derivation source for type conversions
}
