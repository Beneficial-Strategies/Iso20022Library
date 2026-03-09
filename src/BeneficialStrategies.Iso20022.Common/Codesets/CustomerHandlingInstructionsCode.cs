// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Codes that apply special information that the Broker / Dealer needs to report, as specified by the customer. Firms that are taking in orders manually but routing for execution electronically and for compliance reporting must capture the client&apos;s handling instructions.This is intended for reporting only ( OATS = Order Audit Trail System - Phase III regulatory requirement).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axg_2dp-Ed-ak6NoX_4Aeg_-38390159")]
[Description(@"Codes that apply special information that the Broker / Dealer needs to report, as specified by the customer. Firms that are taking in orders manually but routing for execution electronically and for compliance reporting must capture the client's handling instructions.This is intended for reporting only ( OATS = Order Audit Trail System - Phase III regulatory requirement).")]
[Derivations(typeof(CustomerHandlingInstructions1Code))]
public enum CustomerHandlingInstructionsCode
{
    /// <summary>
    /// Market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.
    /// Encoded/decoded by serializers as &quot;FIKI&quot;.
    /// </summary>
    [EnumMember(Value = "FIKI")]
    [IsoId("_axqJwNp-Ed-ak6NoX_4Aeg_206077101")]
    [Description(@"Market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.")]
    FillOrKill,
    
    /// <summary>
    /// Market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.
    /// Encoded/decoded by serializers as &quot;IOCA&quot;.
    /// </summary>
    [EnumMember(Value = "IOCA")]
    [IsoId("_axqJwdp-Ed-ak6NoX_4Aeg_218082984")]
    [Description(@"Market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.")]
    ImmediateOrCancel,
    
    /// <summary>
    /// Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, All Or None orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.
    /// Encoded/decoded by serializers as &quot;ALON&quot;.
    /// </summary>
    [EnumMember(Value = "ALON")]
    [IsoId("_axqJwtp-Ed-ak6NoX_4Aeg_338140206")]
    [Description(@"Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, All Or None orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.")]
    AllOrNone,
    
    /// <summary>
    /// Order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_axqJw9p-Ed-ak6NoX_4Aeg_405556725")]
    [Description(@"Order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.")]
    Scale,
    
    /// <summary>
    /// Make the order active until notified.
    /// Encoded/decoded by serializers as &quot;WORK&quot;.
    /// </summary>
    [EnumMember(Value = "WORK")]
    [IsoId("_axqJxNp-Ed-ak6NoX_4Aeg_649365926")]
    [Description(@"Make the order active until notified.")]
    Work,
    
    /// <summary>
    /// Add on another order.
    /// Encoded/decoded by serializers as &quot;ADOO&quot;.
    /// </summary>
    [EnumMember(Value = "ADOO")]
    [IsoId("_axqJxdp-Ed-ak6NoX_4Aeg_1265355178")]
    [Description(@"Add on another order.")]
    AddOnOrder,
    
    /// <summary>
    /// Indicates that a position in the underlying is traded for a futures position in the physical commodity markets.
    /// Encoded/decoded by serializers as &quot;EFPH&quot;.
    /// </summary>
    [EnumMember(Value = "EFPH")]
    [IsoId("_axqJxtp-Ed-ak6NoX_4Aeg_1507318655")]
    [Description(@"Indicates that a position in the underlying is traded for a futures position in the physical commodity markets.")]
    ExchangeForPhysicalTransaction,
    
    /// <summary>
    /// Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.
    /// Encoded/decoded by serializers as &quot;IMBO&quot;.
    /// </summary>
    [EnumMember(Value = "IMBO")]
    [IsoId("_axqJx9p-Ed-ak6NoX_4Aeg_1533174858")]
    [Description(@"Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.")]
    ImbalanceOnly,
    
    /// <summary>
    /// Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).
    /// Encoded/decoded by serializers as &quot;PGGD&quot;.
    /// </summary>
    [EnumMember(Value = "PGGD")]
    [IsoId("_axqJyNp-Ed-ak6NoX_4Aeg_1952453905")]
    [Description(@"Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).")]
    Pegged,
    
    /// <summary>
    /// Indicates an order which may be executed in partials or outside the hours of the exchange or other exchange rules.
    /// Encoded/decoded by serializers as &quot;NOHE&quot;.
    /// </summary>
    [EnumMember(Value = "NOHE")]
    [IsoId("_axqJydp-Ed-ak6NoX_4Aeg_-54293973")]
    [Description(@"Indicates an order which may be executed in partials or outside the hours of the exchange or other exchange rules.")]
    NotHeld,
    
}
