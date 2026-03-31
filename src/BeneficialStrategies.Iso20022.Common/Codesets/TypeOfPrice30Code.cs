// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m88a4fNBEeCuA5Tr22BnwA_1249105833")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfPrice30Code>))]
#endif
public enum TypeOfPrice30Code
{
    /// <summary>
    /// Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_m88a4vNBEeCuA5Tr22BnwA_1291473582")]
    [Description(
        @"Price is the calculated bid price of a dual-priced fund (offer-bid prices), that is, the selling price of the units for the investor."
    )]
    Bid = TypeOfPriceCode.Bid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_m88a4_NBEeCuA5Tr22BnwA_-1066268541")]
    [Description(
        @"Price is the calculated offer price of a dual-priced investment fund (offer-bid prices), that is, the buying price of the units for an investor."
    )]
    Offer = TypeOfPriceCode.Offer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices.
    /// Encoded/decoded by serializers as &quot;NAVL&quot;.
    /// </summary>
    [EnumMember(Value = "NAVL")]
    [IsoId("_m88a5PNBEeCuA5Tr22BnwA_1877420608")]
    [Description(
        @"Price is the net asset value per unit that is used either as a transacting price for a single-priced investment fund class, or as a notional price for the calculation of other prices."
    )]
    NetAssetValue = TypeOfPriceCode.NetAssetValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher.
    /// Encoded/decoded by serializers as &quot;CREA&quot;.
    /// </summary>
    [EnumMember(Value = "CREA")]
    [IsoId("_m88a5fNBEeCuA5Tr22BnwA_498737665")]
    [Description(
        @"Price is the calculated creation price of a dual-priced investment fund (creation-cancellation prices) and the highest possible buying price of the units before the initial charge. The actual buying or offer price, which includes charges, will be higher."
    )]
    Creation = TypeOfPriceCode.Creation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_m9GL4PNBEeCuA5Tr22BnwA_-1859004458")]
    [Description(
        @"Price is the calculated cancellation price of a dual-priced investment fund (creation-cancellation price), and the lowest possible valuation of the units on any one-day. The actual selling or bid price is usually higher."
    )]
    Cancellation = TypeOfPriceCode.Cancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the non-official interim price given to an investor before the executed price.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_m9GL4fNBEeCuA5Tr22BnwA_1259502818")]
    [Description(
        @"Price is the non-official interim price given to an investor before the executed price."
    )]
    Interim = TypeOfPriceCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy.
    /// Encoded/decoded by serializers as &quot;SWNG&quot;.
    /// </summary>
    [EnumMember(Value = "SWNG")]
    [IsoId("_m9GL4vNBEeCuA5Tr22BnwA_1248404041")]
    [Description(
        @"Price is the calculated net asset value price of a single-priced investment fund. The price is adjusted to take into account the dealing costs due to individual large deals, or due to a significant imbalance in volumes of subscriptions vs redemptions, as an alternative to dilution levy."
    )]
    Swing = TypeOfPriceCode.Swing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the average price between the bid and offer prices.
    /// Encoded/decoded by serializers as &quot;MIDD&quot;.
    /// </summary>
    [EnumMember(Value = "MIDD")]
    [IsoId("_m9GL4_NBEeCuA5Tr22BnwA_1186771133")]
    [Description(@"Price is the average price between the bid and offer prices.")]
    Mid = TypeOfPriceCode.Mid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the price used when reinvesting units after distribution.
    /// Encoded/decoded by serializers as &quot;RINV&quot;.
    /// </summary>
    [EnumMember(Value = "RINV")]
    [IsoId("_m9GL5PNBEeCuA5Tr22BnwA_-761552817")]
    [Description(@"Price is the price used when reinvesting units after distribution.")]
    Reinvestment = TypeOfPriceCode.Reinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the price used when transferring units between products.
    /// Encoded/decoded by serializers as &quot;SWIC&quot;.
    /// </summary>
    [EnumMember(Value = "SWIC")]
    [IsoId("_m9GL5fNBEeCuA5Tr22BnwA_652683805")]
    [Description(@"Price is the price used when transferring units between products.")]
    Switch = TypeOfPriceCode.Switch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day.
    /// Encoded/decoded by serializers as &quot;DDVR&quot;.
    /// </summary>
    [EnumMember(Value = "DDVR")]
    [IsoId("_m9GL5vNBEeCuA5Tr22BnwA_-1705058318")]
    [Description(
        @"Price is the net income of a financial instrument, calculated on each dealing day, and divided by all the units outstanding on that day."
    )]
    DailyDividendRate = TypeOfPriceCode.DailyDividendRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_m9P84PNBEeCuA5Tr22BnwA_-810327413")]
    [Description(@"True offer price.")]
    Actual = TypeOfPriceCode.Actual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The original NAV before the price of the investment fund was swung.
    /// Encoded/decoded by serializers as &quot;NAUP&quot;.
    /// </summary>
    [EnumMember(Value = "NAUP")]
    [IsoId("_m9P84fNBEeCuA5Tr22BnwA_912382864")]
    [Description(@"The original NAV before the price of the investment fund was swung.")]
    NonAdjustedUnpublished = TypeOfPriceCode.NonAdjustedUnpublished, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is a guaranteed price.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_m9P84vNBEeCuA5Tr22BnwA_1990403202")]
    [Description(@"Price is a guaranteed price.")]
    Guaranteed = TypeOfPriceCode.Guaranteed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is an estimated net asset value per unit.
    /// Encoded/decoded by serializers as &quot;ENAV&quot;.
    /// </summary>
    [EnumMember(Value = "ENAV")]
    [IsoId("_m9P84_NBEeCuA5Tr22BnwA_-473640925")]
    [Description(@"Price is an estimated net asset value per unit.")]
    EstimatedNAV = TypeOfPriceCode.EstimatedNAV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net Asset Value (NAV) applicable to redemptions.
    /// Encoded/decoded by serializers as &quot;REDN&quot;.
    /// </summary>
    [EnumMember(Value = "REDN")]
    [IsoId("_m9P85PNBEeCuA5Tr22BnwA_-122528641")]
    [Description(@"Net Asset Value (NAV) applicable to redemptions.")]
    RedemptionNAV = TypeOfPriceCode.RedemptionNAV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net Asset Value (NAV) applicable to subscriptions.
    /// Encoded/decoded by serializers as &quot;SUBN&quot;.
    /// </summary>
    [EnumMember(Value = "SUBN")]
    [IsoId("_m9P85fNBEeCuA5Tr22BnwA_320459851")]
    [Description(@"Net Asset Value (NAV) applicable to subscriptions.")]
    SubscriptionNAV = TypeOfPriceCode.SubscriptionNAV, // same ordinal as derivation source for type conversions
}
