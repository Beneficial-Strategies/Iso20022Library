// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZY_tttp-Ed-ak6NoX_4Aeg_878479095")]
[Description(@"Specifies the type of rate.")]
[Derivations(typeof(RateStatus1Code))]
public enum RateStatusCode
{
    /// <summary>
    /// Rate is actual.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_ZY_tt9p-Ed-ak6NoX_4Aeg_626942051")]
    [Description(@"Rate is actual.")]
    ActualRate,
    
    /// <summary>
    /// Rate is indicative.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_ZY_tuNp-Ed-ak6NoX_4Aeg_642642401")]
    [Description(@"Rate is indicative.")]
    IndicativeRate,
    
}
