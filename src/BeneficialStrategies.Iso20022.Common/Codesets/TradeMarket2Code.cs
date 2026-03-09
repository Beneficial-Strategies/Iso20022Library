// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a code for a trade market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m4hZMJhyEeumhIk_Pv20Lg")]
[Description(@"Specifies a code for a trade market.")]
[DerivedFrom(typeof(TradeMarketCode))]
public enum TradeMarket2Code
{
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_pKLSwZhyEeumhIk_Pv20Lg")]
    [Description(@"Transaction has an origin and a destination in the same country and is made in the currency of that country.")]
    Domestic = TradeMarketCode.Domestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;FRGN&quot;.
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_pRn-kZhyEeumhIk_Pv20Lg")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    Foreign = TradeMarketCode.Foreign, // same ordinal as derivation source for type conversions
    
}
