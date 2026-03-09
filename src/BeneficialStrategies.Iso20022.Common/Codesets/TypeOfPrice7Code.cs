// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vgl4xtp-Ed-ak6NoX_4Aeg_1127883385")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice7Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_Vgl4x9p-Ed-ak6NoX_4Aeg_1172212096")]
    [Description(@"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.")]
    Bid = TypeOfPriceCode.Bid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_Vgl4yNp-Ed-ak6NoX_4Aeg_1172212097")]
    [Description(@"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.")]
    Offer = TypeOfPriceCode.Offer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as &quot;NAVL&quot;.
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_VgvpwNp-Ed-ak6NoX_4Aeg_1172212113")]
    [Description(@"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.")]
    NetAssetValue = TypeOfPriceCode.NetAssetValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_Vgvpwdp-Ed-ak6NoX_4Aeg_1172212131")]
    [Description(@"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.")]
    Creation = TypeOfPriceCode.Creation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Vgvpwtp-Ed-ak6NoX_4Aeg_1172212148")]
    [Description(@"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.")]
    Cancellation = TypeOfPriceCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Vgvpw9p-Ed-ak6NoX_4Aeg_1172212383")]
    [Description(@"Price is the non-official interim price given to an investor before the executed price.")]
    Interim = TypeOfPriceCode.Interim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as &quot;SWNG&quot;.
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_VgvpxNp-Ed-ak6NoX_4Aeg_1172212408")]
    [Description(@"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.")]
    Swing = TypeOfPriceCode.Swing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is another type of price, which is not explicitly defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vgvpxdp-Ed-ak6NoX_4Aeg_1172212425")]
    [Description(@"Price is another type of price, which is not explicitly defined.")]
    Other = TypeOfPriceCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as &quot;MIDD&quot;.
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_Vgvpxtp-Ed-ak6NoX_4Aeg_1172212485")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid = TypeOfPriceCode.Mid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as &quot;RINV&quot;.
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_Vgvpx9p-Ed-ak6NoX_4Aeg_1172212503")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment = TypeOfPriceCode.Reinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_VgvpyNp-Ed-ak6NoX_4Aeg_1172212520")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch = TypeOfPriceCode.Switch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as &quot;DDVR&quot;.
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_Vgvpydp-Ed-ak6NoX_4Aeg_1189760905")]
    [Description(@"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.")]
    DailyDividendRate = TypeOfPriceCode.DailyDividendRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Vg5awNp-Ed-ak6NoX_4Aeg_1189760923")]
    [Description(@"True offer price.")]
    Actual = TypeOfPriceCode.Actual, // same ordinal as derivation source for type conversions
    
}
