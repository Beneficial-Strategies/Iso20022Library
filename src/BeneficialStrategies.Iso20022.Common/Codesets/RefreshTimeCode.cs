// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines when to refresh.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Za7nYNp-Ed-ak6NoX_4Aeg_-1515530100")]
[Description(@"Defines when to refresh.")]
[Derivations(typeof(RefreshTime1Code))]
public enum RefreshTimeCode
{
    /// <summary>
    /// After each fill.
    /// Encoded/decoded by serializers as &quot;IMME&quot;.
    /// </summary>
    [EnumMember(Value = "IMME")]
    [IsoId("_Za7nYdp-Ed-ak6NoX_4Aeg_-1468432665")]
    [Description(@"After each fill.")]
    Immediate,
    
    /// <summary>
    /// When quantity to be displayed equals 0.
    /// Encoded/decoded by serializers as &quot;EXHA&quot;.
    /// </summary>
    [EnumMember(Value = "EXHA")]
    [IsoId("_Za7nYtp-Ed-ak6NoX_4Aeg_-1027912177")]
    [Description(@"When quantity to be displayed equals 0.")]
    Exhaust,
    
}
