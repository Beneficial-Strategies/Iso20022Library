// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a code for a trade market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tVVDYKcAEeSyQqZ4APDtOA")]
[Description(@"Specifies a code for a trade market.")]
[Derivations(typeof(TradeMarket1Code),typeof(TradeMarket2Code))]
public enum TradeMarketCode
{
    /// <summary>
    /// Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.
    /// Encoded/decoded by serializers as &quot;NFTA&quot;.
    /// </summary>
    [EnumMember(Value = "NFTA")]
    [IsoId("_G-kucKcBEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.")]
    NAFTA,
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;INTL&quot;.
    /// </summary>
    [EnumMember(Value = "INTL")]
    [IsoId("_9ABlMKcBEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    International,
    
    /// <summary>
    /// Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).
    /// Encoded/decoded by serializers as &quot;FRDT&quot;.
    /// </summary>
    [EnumMember(Value = "FRDT")]
    [IsoId("_UnHLQKcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).")]
    FrenchDomTom,
    
    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;EUDM&quot;.
    /// </summary>
    [EnumMember(Value = "EUDM")]
    [IsoId("_hB8UQKcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.")]
    EuroDomestic,
    
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_l1fi0KcCEeSyQqZ4APDtOA")]
    [Description(@"Transaction has an origin and a destination in the same country and is made in the currency of that country.")]
    Domestic,
    
    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;FRGN&quot;.
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_nbNsAJhxEeumhIk_Pv20Lg")]
    [Description(@"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    Foreign,
    
}
