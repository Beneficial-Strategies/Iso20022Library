// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__x69MtojEeC60axPepSq7g_1543095306")]
[Description(@"Side taken by a party on an order.")]
[DerivedFrom(typeof(SideCode))]
public enum Side3Code
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__x69M9ojEeC60axPepSq7g_122274848")]
    [Description(@"Order is buy driven.")]
    Buy = SideCode.Buy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__x69NNojEeC60axPepSq7g_743775553")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies an order for which a broker wishes to take the other side and cross with the client.
    /// Encoded/decoded by serializers as &quot;CROS&quot;.
    /// </summary>
    [EnumMember(Value = "CROS")]
    [IsoId("__x69NdojEeC60axPepSq7g_851331516")]
    [Description(@"Identifies an order for which a broker wishes to take the other side and cross with the client.")]
    Cross = SideCode.Cross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell.
    /// Encoded/decoded by serializers as &quot;CRSH&quot;.
    /// </summary>
    [EnumMember(Value = "CRSH")]
    [IsoId("__x69NtojEeC60axPepSq7g_1523848265")]
    [Description(@"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position, and sends a Sell Short order to the broker. Many exchanges have tick rules needing to be enforced, and the order getting converted from Sell Short to Cross (instead of Cross Short) could result in an illegal short sell.")]
    CrossShort = SideCode.CrossShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges.
    /// Encoded/decoded by serializers as &quot;CSHE&quot;.
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("__yEHINojEeC60axPepSq7g_366683231")]
    [Description(@"Identifies a type of order for which a broker wants to cross with the client in the case a client wants to establish a short position and is exempt from the uptick restriction. Used as audit trail on exchanges.")]
    CrossShortExempt = SideCode.CrossShortExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("__yEHIdojEeC60axPepSq7g_559940981")]
    [Description(@"Indicates, in the case of a multileg instrument,that the sides of the legs are the same as defined at the creation of the multileg instrument.")]
    AsDefined = SideCode.AsDefined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument.
    /// Encoded/decoded by serializers as &quot;OPPO&quot;.
    /// </summary>
    [EnumMember(Value = "OPPO")]
    [IsoId("__yEHItojEeC60axPepSq7g_1170342909")]
    [Description(@"Indicates, in the case of a multileg instrument,that the sides of the legs are the opposite of their definition at the creation of the multileg instrument.")]
    Opposite = SideCode.Opposite, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The side of the indication of interest is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("__yEHI9ojEeC60axPepSq7g_1613331401")]
    [Description(@"The side of the indication of interest is not disclosed.")]
    Undisclosed = SideCode.Undisclosed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the side refers to both buys and sells.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("__yEHJNojEeC60axPepSq7g_-2142210308")]
    [Description(@"Indicates that the side refers to both buys and sells.")]
    TwoSided = SideCode.TwoSided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;BUMI&quot;.
    /// </summary>
    [EnumMember(Value = "BUMI")]
    [IsoId("__yEHJdojEeC60axPepSq7g_1701859093")]
    [Description(@"A round-lot market order to buy minus is an order to buy a stated amount of a stock provided that its price is: |- not higher than the last sale if the last sale was a minus or zero minus tick and|- not higher than the last sale minus the minimum fractional change in the stock if the last sale was a plus or zero plus tick.|A limit price order to buy minus also states the highest price at which it can be executed.")]
    BuyMinus = SideCode.BuyMinus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed.
    /// Encoded/decoded by serializers as &quot;SEPL&quot;.
    /// </summary>
    [EnumMember(Value = "SEPL")]
    [IsoId("__yEHJtojEeC60axPepSq7g_17019742")]
    [Description(@"A round-lot market order to sell plus is an order to sell a stated amount of a stock provided that its price is: |- not lower than the last sale if the last sale was a plus or zero plus tick and|- not lower than the last sale minus the minimum fractional change in the stock if the last sale was a minus or zero minus tick.|A limit-price order to sell plus also states the lowest price at which it can be executed.")]
    SellPlus = SideCode.SellPlus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.
    /// Encoded/decoded by serializers as &quot;SESH&quot;.
    /// </summary>
    [EnumMember(Value = "SESH")]
    [IsoId("__yN4INojEeC60axPepSq7g_-1707652695")]
    [Description(@"An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.")]
    SellShort = SideCode.SellShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Short sale exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("__yN4IdojEeC60axPepSq7g_-1414505952")]
    [Description(@"Short sale exempt from short-sale rules.")]
    SellShortExempt = SideCode.SellShortExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is to lend securities.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("__yN4ItojEeC60axPepSq7g_1948524824")]
    [Description(@"Order is to lend securities.")]
    Lend = SideCode.Lend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is to borrow securities.
    /// Encoded/decoded by serializers as &quot;BORW&quot;.
    /// </summary>
    [EnumMember(Value = "BORW")]
    [IsoId("__yN4I9ojEeC60axPepSq7g_1706333362")]
    [Description(@"Order is to borrow securities.")]
    Borrow = SideCode.Borrow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exercise of an option contract.
    /// Encoded/decoded by serializers as &quot;OPEX&quot;.
    /// </summary>
    [EnumMember(Value = "OPEX")]
    [IsoId("__yN4JNojEeC60axPepSq7g_-1497145414")]
    [Description(@"Exercise of an option contract.")]
    OptionExercise = SideCode.OptionExercise, // same ordinal as derivation source for type conversions
    
}
