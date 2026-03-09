// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a rate basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_N0uXAM5KEeSc85GUbgBycw")]
[Description(@"Specifies a rate basis.")]
[DerivedFrom(typeof(RateBasisCode))]
public enum RateBasis1Code
{
    /// <summary>
    /// Rate is reported in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_Oxb24c5KEeSc85GUbgBycw")]
    [Description(@"Rate is reported in days.")]
    Days = RateBasisCode.Days, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is reported in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_O4WXMc5KEeSc85GUbgBycw")]
    [Description(@"Rate is reported in months.")]
    Months = RateBasisCode.Months, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is reported in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_O9mqoc5KEeSc85GUbgBycw")]
    [Description(@"Rate is reported in weeks.")]
    Weeks = RateBasisCode.Weeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate is reported in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_PCi1Ac5KEeSc85GUbgBycw")]
    [Description(@"Rate is reported in years.")]
    Years = RateBasisCode.Years, // same ordinal as derivation source for type conversions
    
}
