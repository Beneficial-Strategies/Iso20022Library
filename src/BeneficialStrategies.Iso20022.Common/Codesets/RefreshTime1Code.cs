// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines when to refresh.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zaydddp-Ed-ak6NoX_4Aeg_761872038")]
[Description(@"Defines when to refresh.")]
[DerivedFrom(typeof(RefreshTimeCode))]
public enum RefreshTime1Code
{
    /// <summary>
    /// After each fill.
    /// Encoded/decoded by serializers as &quot;IMME&quot;.
    /// </summary>
    [EnumMember(Value = "IMME")]
    [IsoId("_Zayddtp-Ed-ak6NoX_4Aeg_820053979")]
    [Description(@"After each fill.")]
    Immediate = RefreshTimeCode.Immediate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When quantity to be displayed equals 0.
    /// Encoded/decoded by serializers as &quot;EXHA&quot;.
    /// </summary>
    [EnumMember(Value = "EXHA")]
    [IsoId("_Zaydd9p-Ed-ak6NoX_4Aeg_820054304")]
    [Description(@"When quantity to be displayed equals 0.")]
    Exhaust = RefreshTimeCode.Exhaust, // same ordinal as derivation source for type conversions
    
}
