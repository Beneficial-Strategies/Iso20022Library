// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of period unit to be used.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1APuIPS3Eeife6veM7daYw")]
[Description(@"Type of period unit to be used.")]
[DerivedFrom(typeof(PeriodUnitCode))]
public enum PeriodUnit3Code
{
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Lp06QXyYEemfrNOe0zHQyg")]
    [Description(@"Other Private")]
    OtherPrivate = PeriodUnitCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Lp06Q3yYEemfrNOe0zHQyg")]
    [Description(@"Other National")]
    OtherNational = PeriodUnitCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_Lp06RXyYEemfrNOe0zHQyg")]
    [Description(@"Counted in months.")]
    Months = PeriodUnitCode.Months, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_Lp06R3yYEemfrNOe0zHQyg")]
    [Description(@"Counted in weeks.")]
    Weeks = PeriodUnitCode.Weeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_Lp06SXyYEemfrNOe0zHQyg")]
    [Description(@"Counted in years.")]
    Years = PeriodUnitCode.Years, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counted in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_Lp06S3yYEemfrNOe0zHQyg")]
    [Description(@"Counted in days.")]
    Days = PeriodUnitCode.Days, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra Days
    /// Encoded/decoded by serializers as &quot;EXDY&quot;.
    /// </summary>
    [EnumMember(Value = "EXDY")]
    [IsoId("_Lp06TXyYEemfrNOe0zHQyg")]
    [Description(@"Extra Days")]
    ExtraDays = PeriodUnitCode.ExtraDays, // same ordinal as derivation source for type conversions
    
}
