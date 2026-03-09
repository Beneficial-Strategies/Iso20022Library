// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pricing calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIreM9p-Ed-ak6NoX_4Aeg_-1724055279")]
[Description(@"Specifies the type of pricing calculation method.")]
[Derivations(typeof(PriceMethod1Code))]
public enum PriceMethodCode
{
    /// <summary>
    /// Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_aIreNNp-Ed-ak6NoX_4Aeg_-1724055278")]
    [Description(@"Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.")]
    ForwardPrice,
    
    /// <summary>
    /// Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_aIreNdp-Ed-ak6NoX_4Aeg_-1724055277")]
    [Description(@"Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.")]
    HistoricalPrice,
    
}
