// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is negotiated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNJuiNp-Ed-ak6NoX_4Aeg_1309549909")]
[Description(@"Specifies whether the trade is negotiated.")]
[Derivations(typeof(NegotiatedTrade1Code))]
public enum NegotiatedTradeCode
{
    /// <summary>
    /// Trade is negotiated.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_aNJuidp-Ed-ak6NoX_4Aeg_1435150328")]
    [Description(@"Trade is negotiated.")]
    Negotiated,
    
    /// <summary>
    /// Trade is not negotiated.
    /// Encoded/decoded by serializers as &quot;NNGO&quot;.
    /// </summary>
    [EnumMember(Value = "NNGO")]
    [IsoId("_aNTfgNp-Ed-ak6NoX_4Aeg_1468396094")]
    [Description(@"Trade is not negotiated.")]
    NotNegotiated,
    
    /// <summary>
    /// Whether the trade is negotiated or not is unknown.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_aNTfgdp-Ed-ak6NoX_4Aeg_1480402761")]
    [Description(@"Whether the trade is negotiated or not is unknown.")]
    Unknown,
    
}
