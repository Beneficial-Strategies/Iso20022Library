// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Time expressed in period units.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X6K3wF1sEeeu75xdwwAXQw")]
[Description(@"Time expressed in period units.")]
[DerivedFrom(typeof(PeriodUnitCode))]
public enum PeriodUnit2Code
{
    /// <summary>
    /// Period unit expressed in hours.
    /// Encoded/decoded by serializers as &quot;HOUR&quot;.
    /// </summary>
    [EnumMember(Value = "HOUR")]
    [IsoId("_I1r-sXyYEemfrNOe0zHQyg")]
    [Description(@"Period unit expressed in hours.")]
    Hours = PeriodUnitCode.Hours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Half days
    /// Encoded/decoded by serializers as &quot;HFDA&quot;.
    /// </summary>
    [EnumMember(Value = "HFDA")]
    [IsoId("_I1r-s3yYEemfrNOe0zHQyg")]
    [Description(@"Half days")]
    HalfDays = PeriodUnitCode.HalfDays, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_I1r-tXyYEemfrNOe0zHQyg")]
    [Description(@"Counted in days.")]
    Days = PeriodUnitCode.Days, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_I1r-t3yYEemfrNOe0zHQyg")]
    [Description(@"Counted in weeks.")]
    Weeks = PeriodUnitCode.Weeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_I1r-uXyYEemfrNOe0zHQyg")]
    [Description(@"Counted in months.")]
    Months = PeriodUnitCode.Months, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_I1r-u3yYEemfrNOe0zHQyg")]
    [Description(@"Counted in years.")]
    Years = PeriodUnitCode.Years, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Period unit expressed in minutes
    /// Encoded/decoded by serializers as &quot;MINU&quot;.
    /// </summary>
    [EnumMember(Value = "MINU")]
    [IsoId("_I1r-vXyYEemfrNOe0zHQyg")]
    [Description(@"Period unit expressed in minutes")]
    Minutes = PeriodUnitCode.Minutes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in some other unit.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_I1r-v3yYEemfrNOe0zHQyg")]
    [Description(@"Counted in some other unit.")]
    Other = PeriodUnitCode.Other, // same ordinal as derivation source for type conversions
    
}
