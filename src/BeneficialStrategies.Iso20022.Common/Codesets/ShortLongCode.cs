// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOtwVdp-Ed-ak6NoX_4Aeg_-300293738")]
[Description(@"Specifies whether the securities position is short or long, that is, whether the balance is a negative or positive balance.")]
[Derivations(typeof(ShortLong1Code))]
public enum ShortLongCode
{
    /// <summary>
    /// Position is short, that is, the balance is negative.
    /// Encoded/decoded by serializers as &quot;SHOR&quot;.
    /// </summary>
    [EnumMember(Value = "SHOR")]
    [IsoId("_ZOtwVtp-Ed-ak6NoX_4Aeg_39564477")]
    [Description(@"Position is short, that is, the balance is negative.")]
    Short,
    
    /// <summary>
    /// Position is long, that is, the balance is positive.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_ZOtwV9p-Ed-ak6NoX_4Aeg_92203158")]
    [Description(@"Position is long, that is, the balance is positive.")]
    Long,
    
}
