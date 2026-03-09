// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if one side or the other of a cross order should be prioritized.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKBiBNp-Ed-ak6NoX_4Aeg_-62106922")]
[Description(@"Indicates if one side or the other of a cross order should be prioritized.")]
[Derivations(typeof(Prioritisation1Code))]
public enum PrioritisationCode
{
    /// <summary>
    /// None of the sides should be prioritised.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_aKBiBdp-Ed-ak6NoX_4Aeg_335004688")]
    [Description(@"None of the sides should be prioritised.")]
    None,
    
    /// <summary>
    /// Buy side is prioritized.
    /// Encoded/decoded by serializers as &quot;BSPR&quot;.
    /// </summary>
    [EnumMember(Value = "BSPR")]
    [IsoId("_aKBiBtp-Ed-ak6NoX_4Aeg_393187379")]
    [Description(@"Buy side is prioritized.")]
    BuySide,
    
    /// <summary>
    /// Sell side is prioritised.
    /// Encoded/decoded by serializers as &quot;SSPR&quot;.
    /// </summary>
    [EnumMember(Value = "SSPR")]
    [IsoId("_aKBiB9p-Ed-ak6NoX_4Aeg_734890661")]
    [Description(@"Sell side is prioritised.")]
    SellSide,
    
}
