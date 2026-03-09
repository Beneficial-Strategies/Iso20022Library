// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YxqA4tp-Ed-ak6NoX_4Aeg_1257927270")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice13Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_YxqA49p-Ed-ak6NoX_4Aeg_1369674751")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid = TypeOfPriceCode.Bid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_YxqA5Np-Ed-ak6NoX_4Aeg_1369674752")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer = TypeOfPriceCode.Offer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as &quot;NAVL&quot;.
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_YxqA5dp-Ed-ak6NoX_4Aeg_1369674782")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue = TypeOfPriceCode.NetAssetValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_YxqA5tp-Ed-ak6NoX_4Aeg_1369674783")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation = TypeOfPriceCode.Creation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YxqA59p-Ed-ak6NoX_4Aeg_1369674812")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation = TypeOfPriceCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YxqA6Np-Ed-ak6NoX_4Aeg_1369674843")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim = TypeOfPriceCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as &quot;SWNG&quot;.
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_Yxzx4Np-Ed-ak6NoX_4Aeg_1369674844")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing = TypeOfPriceCode.Swing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as &quot;MIDD&quot;.
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_Yxzx4dp-Ed-ak6NoX_4Aeg_1369674874")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid = TypeOfPriceCode.Mid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as &quot;RINV&quot;.
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_Yxzx4tp-Ed-ak6NoX_4Aeg_1369675152")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment = TypeOfPriceCode.Reinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the estimated net asset value for the side pocket.
    /// Encoded/decoded by serializers as &quot;NAVS&quot;.
    /// </summary>
    [EnumMember(Value = "NAVS")]
    [IsoId("_Yxzx49p-Ed-ak6NoX_4Aeg_-2131990206")]
    [Description(@"Price is the estimated net asset value for the side pocket.")]
    SidePocketNAV = TypeOfPriceCode.SidePocketNAV, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_Yxzx5Np-Ed-ak6NoX_4Aeg_1369675153")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch = TypeOfPriceCode.Switch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.
    /// Encoded/decoded by serializers as &quot;GAVL&quot;.
    /// </summary>
    [EnumMember(Value = "GAVL")]
    [IsoId("_Yxzx5dp-Ed-ak6NoX_4Aeg_1381678259")]
    [Description(@"Price is the gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.")]
    GrossAssetValue = TypeOfPriceCode.GrossAssetValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as &quot;DDVR&quot;.
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_Yxzx5tp-Ed-ak6NoX_4Aeg_1714146799")]
    [Description(@"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.")]
    DailyDividendRate = TypeOfPriceCode.DailyDividendRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Yxzx59p-Ed-ak6NoX_4Aeg_1714146830")]
    [Description(@"True offer price.")]
    Actual = TypeOfPriceCode.Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the estimated gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.
    /// Encoded/decoded by serializers as &quot;EGAV&quot;.
    /// </summary>
    [EnumMember(Value = "EGAV")]
    [IsoId("_Yxzx6Np-Ed-ak6NoX_4Aeg_2114955839")]
    [Description(@"Price is the estimated gross asset value per unit and includes the performance fee per share. It is used as the transacting price for a fund with equalisation. GAVL price minus the NAVL price = performance fee.")]
    EstimatedGAV = TypeOfPriceCode.EstimatedGAV, // same ordinal as derivation source for type conversions
    
}
