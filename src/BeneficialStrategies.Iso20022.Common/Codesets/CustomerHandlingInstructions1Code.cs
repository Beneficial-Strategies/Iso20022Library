// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Firms that are taking in orders manually but routing for execution electronically and for reporting to OATS must capture the client&apos;s handling instructions.This is intended for compliance reporting only ( OATS Phase III regulatory requirement).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUhmSdp-Ed-ak6NoX_4Aeg_-1415296832")]
[Description(@"Firms that are taking in orders manually but routing for execution electronically and for reporting to OATS must capture the client's handling instructions.This is intended for compliance reporting only ( OATS Phase III regulatory requirement).")]
[DerivedFrom(typeof(CustomerHandlingInstructionsCode))]
public enum CustomerHandlingInstructions1Code
{
    /// <summary>
    /// Market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.
    /// Encoded/decoded by serializers as &quot;FIKI&quot;.
    /// </summary>
    [EnumMember(Value = "FIKI")]
    [IsoId("_bUrXQNp-Ed-ak6NoX_4Aeg_-981242480")]
    [Description(@"Market or limit order that is to be executed in its entirety as soon as it is submitted; if not so executed, the order is to be cancelled.")]
    FillOrKill = CustomerHandlingInstructionsCode.FillOrKill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.
    /// Encoded/decoded by serializers as &quot;IOCA&quot;.
    /// </summary>
    [EnumMember(Value = "IOCA")]
    [IsoId("_bUrXQdp-Ed-ak6NoX_4Aeg_-981241376")]
    [Description(@"Market or limit order to be executed in whole or in part as soon as it is submitted; any portion not so executed is to be cancelled.")]
    ImmediateOrCancel = CustomerHandlingInstructionsCode.ImmediateOrCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, All Or None orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.
    /// Encoded/decoded by serializers as &quot;ALON&quot;.
    /// </summary>
    [EnumMember(Value = "ALON")]
    [IsoId("_bUrXQtp-Ed-ak6NoX_4Aeg_-980320723")]
    [Description(@"Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, All Or None orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.")]
    AllOrNone = CustomerHandlingInstructionsCode.AllOrNone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.
    /// Encoded/decoded by serializers as &quot;SCAL&quot;.
    /// </summary>
    [EnumMember(Value = "SCAL")]
    [IsoId("_bUrXQ9p-Ed-ak6NoX_4Aeg_-980319827")]
    [Description(@"Order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.")]
    Scale = CustomerHandlingInstructionsCode.Scale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Make the order active until notified.
    /// Encoded/decoded by serializers as &quot;WORK&quot;.
    /// </summary>
    [EnumMember(Value = "WORK")]
    [IsoId("_bUrXRNp-Ed-ak6NoX_4Aeg_-980318802")]
    [Description(@"Make the order active until notified.")]
    Work = CustomerHandlingInstructionsCode.Work, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Add on another order.
    /// Encoded/decoded by serializers as &quot;ADOO&quot;.
    /// </summary>
    [EnumMember(Value = "ADOO")]
    [IsoId("_bUrXRdp-Ed-ak6NoX_4Aeg_-980318742")]
    [Description(@"Add on another order.")]
    AddOnOrder = CustomerHandlingInstructionsCode.AddOnOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that a position in the underlying is traded for a futures position in the physical commodity markets.
    /// Encoded/decoded by serializers as &quot;EFPH&quot;.
    /// </summary>
    [EnumMember(Value = "EFPH")]
    [IsoId("_bUrXRtp-Ed-ak6NoX_4Aeg_-979397175")]
    [Description(@"Indicates that a position in the underlying is traded for a futures position in the physical commodity markets.")]
    ExchangeForPhysicalTransaction = CustomerHandlingInstructionsCode.ExchangeForPhysicalTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.
    /// Encoded/decoded by serializers as &quot;IMBO&quot;.
    /// </summary>
    [EnumMember(Value = "IMBO")]
    [IsoId("_bUrXR9p-Ed-ak6NoX_4Aeg_-979396227")]
    [Description(@"Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.")]
    ImbalanceOnly = CustomerHandlingInstructionsCode.ImbalanceOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).
    /// Encoded/decoded by serializers as &quot;PGGD&quot;.
    /// </summary>
    [EnumMember(Value = "PGGD")]
    [IsoId("_bU1IQNp-Ed-ak6NoX_4Aeg_-979394349")]
    [Description(@"Limit order, where the limit price fluctuates relative to another quantity, such as the last sale, midpoint, opening price, bid, offer, or VWAP (Volume Weighted Average Price).")]
    Pegged = CustomerHandlingInstructionsCode.Pegged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates an order which may be executed in partials or outside the hours of the exchange or other exchange rules.
    /// Encoded/decoded by serializers as &quot;NOHE&quot;.
    /// </summary>
    [EnumMember(Value = "NOHE")]
    [IsoId("_bU1IQdp-Ed-ak6NoX_4Aeg_-1216084428")]
    [Description(@"Indicates an order which may be executed in partials or outside the hours of the exchange or other exchange rules.")]
    NotHeld = CustomerHandlingInstructionsCode.NotHeld, // same ordinal as derivation source for type conversions
    
}
