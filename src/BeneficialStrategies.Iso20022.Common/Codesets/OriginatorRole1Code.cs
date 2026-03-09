// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies in what capacity (role) the originator of a quote is acting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw1l89p-Ed-ak6NoX_4Aeg_144300492")]
[Description(@"Specifies in what capacity (role) the originator of a quote is acting.")]
[DerivedFrom(typeof(OriginatorRoleCode))]
public enum OriginatorRole1Code
{
    /// <summary>
    /// Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI&apos;s will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as &quot;mini&quot;exchanges.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_Zw1l9Np-Ed-ak6NoX_4Aeg_1072441670")]
    [Description(@"Firms which, on an organised, frequent and systematic basis deal on their own account by executing client orders outside a regulated market or a Multilateral Trading Facility. SI's will have the obligation to provide, and make public, a definite bid and offer quote for liquid securities. They act as ""mini""exchanges.")]
    SystematicInternaliser = OriginatorRoleCode.SystematicInternaliser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_Zw1l9dp-Ed-ak6NoX_4Aeg_1072441706")]
    [Description(@"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.")]
    MultilateralTradingFacility = OriginatorRoleCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_Zw1l9tp-Ed-ak6NoX_4Aeg_1072441731")]
    [Description(@"Market on which financial instruments can be traded according to rules defined by the stock exchange.")]
    RegulatedMarket = OriginatorRoleCode.RegulatedMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.
    /// Encoded/decoded by serializers as &quot;MKTM&quot;.
    /// </summary>
    [EnumMember(Value = "MKTM")]
    [IsoId("_Zw1l99p-Ed-ak6NoX_4Aeg_1072441748")]
    [Description(@"Dealer or specialist that is trading for their own account in the OTC market. Market makers are expected to maintain an orderly market by being available to buy or sell.")]
    MarketMaker = OriginatorRoleCode.MarketMaker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Zw1l-Np-Ed-ak6NoX_4Aeg_1072442008")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = OriginatorRoleCode.Investor, // same ordinal as derivation source for type conversions
    
}
