// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of trading method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o1oPMIBDEeSUJZYcWGKkkw")]
[Description(@"Identifies the type of trading method.")]
[DerivedFrom(typeof(TradingMethodTypeCode))]
public enum TradingMethodType1Code
{
    /// <summary>
    /// Taker submits a bilateral request, maker replys the quotation, and taker accepts the quotation to complete a bilateral trade.
    /// Encoded/decoded by serializers as &quot;BITR&quot;.
    /// </summary>
    [EnumMember(Value = "BITR")]
    [IsoId("_Anv-cYHiEeSY3ulMDfpmvA")]
    [Description(@"Taker submits a bilateral request, maker replys the quotation, and taker accepts the quotation to complete a bilateral trade.")]
    BilateralTrade = TradingMethodTypeCode.BilateralTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Members submit orders, and trading system uses matchmaking mechanism of Centralized Price Bidding to match orders.
    /// Encoded/decoded by serializers as &quot;CERB&quot;.
    /// </summary>
    [EnumMember(Value = "CERB")]
    [IsoId("_Ask0EYHiEeSY3ulMDfpmvA")]
    [Description(@"Members submit orders, and trading system uses matchmaking mechanism of Centralized Price Bidding to match orders.|")]
    CentralizedPriceBidding = TradingMethodTypeCode.CentralizedPriceBidding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Members submit orders, and trading system uses continuous matchmaking mechanism to match orders.
    /// Encoded/decoded by serializers as &quot;CUMA&quot;.
    /// </summary>
    [EnumMember(Value = "CUMA")]
    [IsoId("_AxX0gYHiEeSY3ulMDfpmvA")]
    [Description(@"Members submit orders, and trading system uses continuous matchmaking mechanism to match orders.|")]
    ContinuousMatching = TradingMethodTypeCode.ContinuousMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member activate an order, and if order matches with market maker&apos;s quotationa, the order will be filled automatically.
    /// Encoded/decoded by serializers as &quot;LIOR&quot;.
    /// </summary>
    [EnumMember(Value = "LIOR")]
    [IsoId("_A3UrgYHiEeSY3ulMDfpmvA")]
    [Description(@"Member activate an order, and if order matches with market maker's quotationa, the order will be filled automatically.")]
    LimitOrder = TradingMethodTypeCode.LimitOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member completes product elements and submits, and the counterpart just confirms the deal to complete a negotiation trade.
    /// Encoded/decoded by serializers as &quot;NETR&quot;.
    /// </summary>
    [EnumMember(Value = "NETR")]
    [IsoId("_A8opUYHiEeSY3ulMDfpmvA")]
    [Description(@"Member completes product elements and submits, and the counterpart just confirms the deal to complete a negotiation trade.")]
    NegotiationTrade = TradingMethodTypeCode.NegotiationTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When market makers quote continuously, members could just click the quotation to make a deal with market makers.
    /// Encoded/decoded by serializers as &quot;ONCT&quot;.
    /// </summary>
    [EnumMember(Value = "ONCT")]
    [IsoId("_B2gQkYHiEeSY3ulMDfpmvA")]
    [Description(@"When market makers quote continuously, members could just click the quotation to make a deal with market makers.")]
    OneClickTrade = TradingMethodTypeCode.OneClickTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market members can click the predetermined price setted by issuer to make a deal， and then the subscription amount will deduct in time.
    /// Encoded/decoded by serializers as &quot;QUAU&quot;.
    /// </summary>
    [EnumMember(Value = "QUAU")]
    [IsoId("_B4DvwYHiEeSY3ulMDfpmvA")]
    [Description(@"Market members can click the predetermined price setted by issuer to make a deal， and then the subscription amount will deduct in time.|")]
    QuotationAuction = TradingMethodTypeCode.QuotationAuction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Administrator reviews the deposit that filled by issuer, and sends it to the tenderers as reference. Atfer this, the issuer confirms the tendering result.
    /// Encoded/decoded by serializers as &quot;TEAU&quot;.
    /// </summary>
    [EnumMember(Value = "TEAU")]
    [IsoId("_CATFwYHiEeSY3ulMDfpmvA")]
    [Description(@"Administrator reviews the deposit that filled by issuer, and sends it to the tenderers as reference. Atfer this, the issuer confirms the tendering result.|")]
    TenderingAuction = TradingMethodTypeCode.TenderingAuction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trades are executed any click anonymously.
    /// Encoded/decoded by serializers as &quot;ANCL&quot;.
    /// </summary>
    [EnumMember(Value = "ANCL")]
    [IsoId("_I2Ls4aUrEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed any click anonymously.")]
    AnonymousClick = TradingMethodTypeCode.AnonymousClick, // same ordinal as derivation source for type conversions
    
}
