// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the trading party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw1l-dp-Ed-ak6NoX_4Aeg_-30528564")]
[Description(@"Specifies the role of the trading party in the transaction.")]
[DerivedFrom(typeof(OriginatorRoleCode))]
public enum OriginatorRole2Code
{
    /// <summary>
    /// Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI&apos;s will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as &quot;mini&quot;exchanges.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_Zw_W8Np-Ed-ak6NoX_4Aeg_-1595967242")]
    [Description(@"Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI's will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as ""mini""exchanges.")]
    SystematicInternaliser = OriginatorRoleCode.SystematicInternaliser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_Zw_W8dp-Ed-ak6NoX_4Aeg_-1595967241")]
    [Description(@"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.")]
    MultilateralTradingFacility = OriginatorRoleCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_Zw_W8tp-Ed-ak6NoX_4Aeg_-1595966959")]
    [Description(@"Market on which financial instruments can be traded according to rules defined by the stock exchange.")]
    RegulatedMarket = OriginatorRoleCode.RegulatedMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.
    /// Encoded/decoded by serializers as &quot;MKTM&quot;.
    /// </summary>
    [EnumMember(Value = "MKTM")]
    [IsoId("_Zw_W89p-Ed-ak6NoX_4Aeg_-1595966882")]
    [Description(@"Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.")]
    MarketMaker = OriginatorRoleCode.MarketMaker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Zw_W9Np-Ed-ak6NoX_4Aeg_-1595966822")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = OriginatorRoleCode.Investor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party appointed by the fund management company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor&apos;s intermediary. It responds to inquiries concerning account status, and processes the income distribution.
    /// Encoded/decoded by serializers as &quot;TAGT&quot;.
    /// </summary>
    [EnumMember(Value = "TAGT")]
    [IsoId("_Zw_W9dp-Ed-ak6NoX_4Aeg_-1595966821")]
    [Description(@"Party appointed by the fund management company. It updates records of investor accounts to reflect the daily investor purchases, redemptions, switches, transfers, and re-registrations. It ensures the timely settlement of transactions, and may provide tax information to the investor and/or to its intermediaries. It may calculate, collect, and rebate commissions. It prepares and distributes confirmations reflecting transactions, resulting in unit or cash account movements to the investor or the investor's intermediary. It responds to inquiries concerning account status, and processes the income distribution.")]
    TransfertAgent = OriginatorRoleCode.TransfertAgent, // same ordinal as derivation source for type conversions
    
}
