// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a code for a trade market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2jl30KcCEeSyQqZ4APDtOA")]
[Description(@"Specifies a code for a trade market.")]
[DerivedFrom(typeof(TradeMarketCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeMarket1Code>))]
#endif
public enum TradeMarket1Code
{
    /// <summary>
    /// Transaction has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_6oIEQKcCEeSyQqZ4APDtOA")]
    [Description(
        @"Transaction has an origin and a destination in the same country and is made in the currency of that country."
    )]
    Domestic = TradeMarketCode.Domestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;EUDM&quot;.
    /// </summary>
    [EnumMember(Value = "EUDM")]
    [IsoId("_6uJzw6cCEeSyQqZ4APDtOA")]
    [Description(
        @"Transaction is a credit transfer in Euro with its country of origin and country of destination within the European Union. Origin and destination countries may be one and the same country."
    )]
    EuroDomestic = TradeMarketCode.EuroDomestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included).
    /// Encoded/decoded by serializers as &quot;FRDT&quot;.
    /// </summary>
    [EnumMember(Value = "FRDT")]
    [IsoId("_6zg046cCEeSyQqZ4APDtOA")]
    [Description(
        @"Transaction is between a French Overseas Departments and Territories (Dom/Tom) and some country in the European Union (France included)."
    )]
    FrenchDomTom = TradeMarketCode.FrenchDomTom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;INTL&quot;.
    /// </summary>
    [EnumMember(Value = "INTL")]
    [IsoId("_6432A6cCEeSyQqZ4APDtOA")]
    [Description(
        @"Transaction has an origin in one country and a destination in another and is made in the currency of either the origin or destination country."
    )]
    International = TradeMarketCode.International, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area.
    /// Encoded/decoded by serializers as &quot;NFTA&quot;.
    /// </summary>
    [EnumMember(Value = "NFTA")]
    [IsoId("_6-hyE6cCEeSyQqZ4APDtOA")]
    [Description(
        @"Transaction is a North American Free Trade Association (NAFTA) transaction, ie, the first and final agent are both located in the NAFTA area."
    )]
    NAFTA = TradeMarketCode.NAFTA, // same ordinal as derivation source for type conversions
}
