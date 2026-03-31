// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YyZnxtp-Ed-ak6NoX_4Aeg_-1063876985")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfPrice9Code>))]
#endif
public enum TypeOfPrice9Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_YyZnx9p-Ed-ak6NoX_4Aeg_-571640820")]
    [Description(
        @"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor."
    )]
    Bid = TypeOfPriceCode.Bid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_YyZnyNp-Ed-ak6NoX_4Aeg_-571640795")]
    [Description(
        @"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor."
    )]
    Offer = TypeOfPriceCode.Offer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as &quot;NAVL&quot;.
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_YyjYwNp-Ed-ak6NoX_4Aeg_-571640778")]
    [Description(
        @"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices."
    )]
    NetAssetValue = TypeOfPriceCode.NetAssetValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_YyjYwdp-Ed-ak6NoX_4Aeg_-571640718")]
    [Description(
        @"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher."
    )]
    Creation = TypeOfPriceCode.Creation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YyjYwtp-Ed-ak6NoX_4Aeg_-571640700")]
    [Description(
        @"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher."
    )]
    Cancellation = TypeOfPriceCode.Cancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_YyjYw9p-Ed-ak6NoX_4Aeg_-571640640")]
    [Description(
        @"Price is the non-official interim price given to an investor before the executed price."
    )]
    Interim = TypeOfPriceCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as &quot;SWNG&quot;.
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_YyjYxNp-Ed-ak6NoX_4Aeg_-571640623")]
    [Description(
        @"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy."
    )]
    Swing = TypeOfPriceCode.Swing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as &quot;MIDD&quot;.
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_YyjYxdp-Ed-ak6NoX_4Aeg_-571640328")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid = TypeOfPriceCode.Mid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as &quot;RINV&quot;.
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_YyjYxtp-Ed-ak6NoX_4Aeg_-571640311")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment = TypeOfPriceCode.Reinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_YyjYx9p-Ed-ak6NoX_4Aeg_-571639908")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch = TypeOfPriceCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as &quot;DDVR&quot;.
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_YyjYyNp-Ed-ak6NoX_4Aeg_-571639830")]
    [Description(
        @"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day."
    )]
    DailyDividendRate = TypeOfPriceCode.DailyDividendRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_YyjYydp-Ed-ak6NoX_4Aeg_-571639770")]
    [Description(@"True offer price.")]
    Actual = TypeOfPriceCode.Actual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The original NAV before the price of the investment fund was swung.
    /// Encoded/decoded by serializers as &quot;NAUP&quot;.
    /// </summary>
    [EnumMember(Value = "NAUP")]
    [IsoId("_YyjYytp-Ed-ak6NoX_4Aeg_-571639735")]
    [Description(@"The original NAV before the price of the investment fund was swung.")]
    NonAdjustedUnpublished = TypeOfPriceCode.NonAdjustedUnpublished, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a guaranteed price.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_YytJwNp-Ed-ak6NoX_4Aeg_52660274")]
    [Description(@"Price is a guaranteed price.")]
    Guaranteed = TypeOfPriceCode.Guaranteed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is an estimated net asset value per unit.
    /// Encoded/decoded by serializers as &quot;ENAV&quot;.
    /// </summary>
    [EnumMember(Value = "ENAV")]
    [IsoId("_YytJwdp-Ed-ak6NoX_4Aeg_52660299")]
    [Description(@"Price is an estimated net asset value per unit.")]
    EstimatedNAV = TypeOfPriceCode.EstimatedNAV, // same ordinal as derivation source for type conversions
}
