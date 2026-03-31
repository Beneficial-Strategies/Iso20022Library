// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the side of the quote request, from the buy-side perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZO3hUNp-Ed-ak6NoX_4Aeg_336258183")]
[Description(@"Indicates the side of the quote request, from the buy-side perspective.")]
[DerivedFrom(typeof(SideCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Side1Code>))]
#endif
public enum Side1Code
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_ZO3hUdp-Ed-ak6NoX_4Aeg_336258192")]
    [Description(@"Order is buy driven.")]
    Buy = SideCode.Buy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZO3hUtp-Ed-ak6NoX_4Aeg_336258193")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the side refers to both buys and sells.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_ZO3hU9p-Ed-ak6NoX_4Aeg_336258194")]
    [Description(@"Indicates that the side refers to both buys and sells.")]
    TwoSided = SideCode.TwoSided, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;BUMI&quot;.
    /// </summary>
    [EnumMember(Value = "BUMI")]
    [IsoId("_ZO3hVNp-Ed-ak6NoX_4Aeg_953165368")]
    [Description(
        @"A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed."
    )]
    BuyMinus = SideCode.BuyMinus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;SEPL&quot;.
    /// </summary>
    [EnumMember(Value = "SEPL")]
    [IsoId("_ZO3hVdp-Ed-ak6NoX_4Aeg_953165771")]
    [Description(
        @"A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed."
    )]
    SellPlus = SideCode.SellPlus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.
    /// Encoded/decoded by serializers as &quot;SESH&quot;.
    /// </summary>
    [EnumMember(Value = "SESH")]
    [IsoId("_ZO3hVtp-Ed-ak6NoX_4Aeg_953165891")]
    [Description(
        @"An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick."
    )]
    SellShort = SideCode.SellShort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short sale exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("_ZO3hV9p-Ed-ak6NoX_4Aeg_953166228")]
    [Description(@"Short sale exempt from short-sale rules.")]
    SellShortExempt = SideCode.SellShortExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies an order for which a broker wishes to take the other side and cross with the client.
    /// Encoded/decoded by serializers as &quot;CROS&quot;.
    /// </summary>
    [EnumMember(Value = "CROS")]
    [IsoId("_ZO3hWNp-Ed-ak6NoX_4Aeg_2013366401")]
    [Description(
        @"Identifies an order for which a broker wishes to take the other side and cross with the client."
    )]
    Cross = SideCode.Cross, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell.
    /// Encoded/decoded by serializers as &quot;CRSH&quot;.
    /// </summary>
    [EnumMember(Value = "CRSH")]
    [IsoId("_ZO3hWdp-Ed-ak6NoX_4Aeg_2013366805")]
    [Description(
        @"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell."
    )]
    CrossShort = SideCode.CrossShort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges.
    /// Encoded/decoded by serializers as &quot;CSHE&quot;.
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("_ZPArQNp-Ed-ak6NoX_4Aeg_2013366943")]
    [Description(
        @"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges."
    )]
    CrossShortExempt = SideCode.CrossShortExempt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_ZPArQdp-Ed-ak6NoX_4Aeg_2013367073")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument."
    )]
    AsDefined = SideCode.AsDefined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;OPPO&quot;.
    /// </summary>
    [EnumMember(Value = "OPPO")]
    [IsoId("_ZPArQtp-Ed-ak6NoX_4Aeg_2013367427")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument."
    )]
    Opposite = SideCode.Opposite, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The side of the indication of interest is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_ZPArQ9p-Ed-ak6NoX_4Aeg_2013367778")]
    [Description(@"The side of the indication of interest is not disclosed.")]
    Undisclosed = SideCode.Undisclosed, // same ordinal as derivation source for type conversions
}
