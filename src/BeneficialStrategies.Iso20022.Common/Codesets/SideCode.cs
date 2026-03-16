// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPArRNp-Ed-ak6NoX_4Aeg_336257608")]
[Description(@"Side taken by a party on an order.")]
[Derivations(
    typeof(Side3Code),
    typeof(Side1Code),
    typeof(Side5Code),
    typeof(OrderDriverCode),
    typeof(IOISideTypeCode)
)]
public enum SideCode
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_ZPArRdp-Ed-ak6NoX_4Aeg_336257609")]
    [Description(@"Order is buy driven.")]
    Buy,

    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_ZPArRtp-Ed-ak6NoX_4Aeg_336257610")]
    [Description(@"Order is sell driven.")]
    Sell,

    /// <summary>
    /// Identifies an order for which a broker wishes to take the other side and cross with the client.
    /// Encoded/decoded by serializers as &quot;CROS&quot;.
    /// </summary>
    [EnumMember(Value = "CROS")]
    [IsoId("_ZPKcQNp-Ed-ak6NoX_4Aeg_336257611")]
    [Description(
        @"Identifies an order for which a broker wishes to take the other side and cross with the client."
    )]
    Cross,

    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell.
    /// Encoded/decoded by serializers as &quot;CRSH&quot;.
    /// </summary>
    [EnumMember(Value = "CRSH")]
    [IsoId("_ZPKcQdp-Ed-ak6NoX_4Aeg_336257612")]
    [Description(
        @"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell."
    )]
    CrossShort,

    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges.
    /// Encoded/decoded by serializers as &quot;CSHE&quot;.
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("_ZPKcQtp-Ed-ak6NoX_4Aeg_336257620")]
    [Description(
        @"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges."
    )]
    CrossShortExempt,

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_ZPKcQ9p-Ed-ak6NoX_4Aeg_336257621")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument."
    )]
    AsDefined,

    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;OPPO&quot;.
    /// </summary>
    [EnumMember(Value = "OPPO")]
    [IsoId("_ZPKcRNp-Ed-ak6NoX_4Aeg_336257622")]
    [Description(
        @"Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument."
    )]
    Opposite,

    /// <summary>
    /// The side of the indication of interest is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_ZPKcRdp-Ed-ak6NoX_4Aeg_461125107")]
    [Description(@"The side of the indication of interest is not disclosed.")]
    Undisclosed,

    /// <summary>
    /// Indicates that the side refers to both buys and sells.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_ZPKcRtp-Ed-ak6NoX_4Aeg_492524716")]
    [Description(@"Indicates that the side refers to both buys and sells.")]
    TwoSided,

    /// <summary>
    /// A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;BUMI&quot;.
    /// </summary>
    [EnumMember(Value = "BUMI")]
    [IsoId("_ZPKcR9p-Ed-ak6NoX_4Aeg_1585715401")]
    [Description(
        @"A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed."
    )]
    BuyMinus,

    /// <summary>
    /// A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;SEPL&quot;.
    /// </summary>
    [EnumMember(Value = "SEPL")]
    [IsoId("_ZPKcSNp-Ed-ak6NoX_4Aeg_-1707497711")]
    [Description(
        @"A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed."
    )]
    SellPlus,

    /// <summary>
    /// An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.
    /// Encoded/decoded by serializers as &quot;SESH&quot;.
    /// </summary>
    [EnumMember(Value = "SESH")]
    [IsoId("_ZPKcSdp-Ed-ak6NoX_4Aeg_-1491395343")]
    [Description(
        @"An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick."
    )]
    SellShort,

    /// <summary>
    /// Short sale exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("_ZPUNQNp-Ed-ak6NoX_4Aeg_-1167237889")]
    [Description(@"Short sale exempt from short-sale rules.")]
    SellShortExempt,

    /// <summary>
    /// Order is to lend securities.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("__7KYwNojEeC60axPepSq7g_-1786945866")]
    [Description(@"Order is to lend securities.")]
    Lend,

    /// <summary>
    /// Order is to borrow securities.
    /// Encoded/decoded by serializers as &quot;BORW&quot;.
    /// </summary>
    [EnumMember(Value = "BORW")]
    [IsoId("__7KYwdojEeC60axPepSq7g_-1165220588")]
    [Description(@"Order is to borrow securities.")]
    Borrow,

    /// <summary>
    /// Exercise of an option contract.
    /// Encoded/decoded by serializers as &quot;OPEX&quot;.
    /// </summary>
    [EnumMember(Value = "OPEX")]
    [IsoId("__7KYwtojEeC60axPepSq7g_967830081")]
    [Description(@"Exercise of an option contract.")]
    OptionExercise,
}
