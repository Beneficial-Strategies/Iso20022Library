// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rate basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ro2ZMc5IEeSc85GUbgBycw")]
[Description(@"Specifies the rate basis.")]
[Derivations(typeof(RateBasis1Code))]
public enum RateBasisCode
{
    /// <summary>
    /// Rate is reported in years.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_ro3AHc5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in years.")]
    Years,
    
    /// <summary>
    /// Rate is reported in months.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ro3AFs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in months.")]
    Months,
    
    /// <summary>
    /// Rate is reported in weeks.
    /// Encoded/decoded by serializers as &quot;WEEK&quot;.
    /// </summary>
    [EnumMember(Value = "WEEK")]
    [IsoId("_ro2ZNs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in weeks.")]
    Weeks,
    
    /// <summary>
    /// Rate is reported in days.
    /// Encoded/decoded by serializers as &quot;DAYS&quot;.
    /// </summary>
    [EnumMember(Value = "DAYS")]
    [IsoId("_ro2ZMs5IEeSc85GUbgBycw")]
    [Description(@"Rate is reported in days.")]
    Days,
    
}
