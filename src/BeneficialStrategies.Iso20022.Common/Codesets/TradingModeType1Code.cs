// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of the trading mode.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-JagcIBEEeSUJZYcWGKkkw")]
[Description(@"Identifies the type of the trading mode.")]
[DerivedFrom(typeof(TradingModeTypeCode))]
public enum TradingModeType1Code
{
    /// <summary>
    /// Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.
    /// Encoded/decoded by serializers as &quot;QUDR&quot;.
    /// </summary>
    [EnumMember(Value = "QUDR")]
    [IsoId("_i_oaQYBFEeSUJZYcWGKkkw")]
    [Description(@"Members could click When market makers quote continuously,or enter RFQ trading process, and make a deal with market makers finally.")]
    QuotationDriven = TradingModeTypeCode.QuotationDriven, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Using matchmaking mechanism to match orders which are submitted by members.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_jFLBkYBFEeSUJZYcWGKkkw")]
    [Description(@"Using matchmaking mechanism to match orders which are submitted by members.")]
    OrderDriven = TradingModeTypeCode.OrderDriven, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.
    /// Encoded/decoded by serializers as &quot;NETR&quot;.
    /// </summary>
    [EnumMember(Value = "NETR")]
    [IsoId("_jKBFUYBFEeSUJZYcWGKkkw")]
    [Description(@"Members send advertisements, and then other members could enter negotiation trade process. In the negotiation trade process, the member completes product elements and submits, and the counterpart just confirms the deal to make a negotiation trade.")]
    NegotiationTrade = TradingModeTypeCode.NegotiationTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When issuer issues the deposits, market members subscribe the deposits.
    /// Encoded/decoded by serializers as &quot;AUCT&quot;.
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_jO6MYYBFEeSUJZYcWGKkkw")]
    [Description(@"When issuer issues the deposits, market members subscribe the deposits.")]
    Auction = TradingModeTypeCode.Auction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trades are executed through matching system.
    /// Encoded/decoded by serializers as &quot;MARC&quot;.
    /// </summary>
    [EnumMember(Value = "MARC")]
    [IsoId("_HLbbQaUrEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed through matching system.")]
    Matching = TradingModeTypeCode.Matching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparties neogiate trading details to execute trades.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_HTB4EaUrEeSgR8TUIX6rXQ")]
    [Description(@"Counterparties neogiate trading details to execute trades.")]
    Bilateral = TradingModeTypeCode.Bilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trades are executed anonymously to each counterparty, based on rule &quot;pritority of price and time&quot; to match trade.
    /// Encoded/decoded by serializers as &quot;ANON&quot;.
    /// </summary>
    [EnumMember(Value = "ANON")]
    [IsoId("_HZXwoaUrEeSgR8TUIX6rXQ")]
    [Description(@"Trades are executed anonymously to each counterparty, based on rule ""pritority of price and time"" to match trade.")]
    Anonymous = TradingModeTypeCode.Anonymous, // same ordinal as derivation source for type conversions
    
}
