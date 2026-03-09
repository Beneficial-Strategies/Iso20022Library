// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__WpdESglEey2k_sfZmJz4g")]
[Description(@"Specifies the underlying business area/type of trade causing the collateral movement.")]
[DerivedFrom(typeof(ExposureTypeV3Code))]
public enum ExposureType12Code
{
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_07NG4SgnEeyxa-IROls2IA")]
    [Description(@"Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.")]
    BondForward = ExposureTypeV3Code.BondForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_07NG4ygnEeyxa-IROls2IA")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeV3Code.CashSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_07NG5SgnEeyxa-IROls2IA")]
    [Description(@"Collateral covering the initial margin requirements for OTC trades cleared through a CCP.")]
    CCPCollateral = ExposureTypeV3Code.CCPCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_07NG5ygnEeyxa-IROls2IA")]
    [Description(@"Any good exchanged during commerce, which includes goods traded on a commodity exchange.")]
    Commodities = ExposureTypeV3Code.Commodities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_07NG6SgnEeyxa-IROls2IA")]
    [Description(@"Swap designed to transfer the credit exposure of fixed income products between parties.")]
    CreditDefaultSwap = ExposureTypeV3Code.CreditDefaultSwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_07NG6ygnEeyxa-IROls2IA")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeV3Code.CreditLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_07NG7SgnEeyxa-IROls2IA")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeV3Code.CreditSupport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_07NG7ygnEeyxa-IROls2IA")]
    [Description(@"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.")]
    CrossCurrencyIRS = ExposureTypeV3Code.CrossCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_07NG8SgnEeyxa-IROls2IA")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeV3Code.CrossProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_07NG8ygnEeyxa-IROls2IA")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeV3Code.EquityOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_07NG9SgnEeyxa-IROls2IA")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeV3Code.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_07NG9ygnEeyxa-IROls2IA")]
    [Description(@"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.")]
    EquitySwap = ExposureTypeV3Code.EquitySwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_07NG-SgnEeyxa-IROls2IA")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeV3Code.ExoticOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_07NG-ygnEeyxa-IROls2IA")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeV3Code.FixedIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_07NG_SgnEeyxa-IROls2IA")]
    [Description(@"FX trades in general.")]
    ForeignExchange = ExposureTypeV3Code.ForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_07NG_ygnEeyxa-IROls2IA")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange = ExposureTypeV3Code.ForwardForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_07NHASgnEeyxa-IROls2IA")]
    [Description(@"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.")]
    Futures = ExposureTypeV3Code.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_07NHAygnEeyxa-IROls2IA")]
    [Description(@"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.")]
    FXOption = ExposureTypeV3Code.FXOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_07NHBSgnEeyxa-IROls2IA")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeV3Code.Liquidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_07NHBygnEeyxa-IROls2IA")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeV3Code.OTCDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_07NHCSgnEeyxa-IROls2IA")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeV3Code.RepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_07NHCygnEeyxa-IROls2IA")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeV3Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_07NHDSgnEeyxa-IROls2IA")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeV3Code.SecuredLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_07NHDygnEeyxa-IROls2IA")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV3Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_07NHESgnEeyxa-IROls2IA")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeV3Code.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_07NHEygnEeyxa-IROls2IA")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV3Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Short sell exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_07NHFSgnEeyxa-IROls2IA")]
    [Description(@"Short sell exposure.")]
    ShortSell = ExposureTypeV3Code.ShortSell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_07NHFygnEeyxa-IROls2IA")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeV3Code.SingleCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_07NHGSgnEeyxa-IROls2IA")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeV3Code.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_07NHGygnEeyxa-IROls2IA")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeV3Code.Swaption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_07NHHSgnEeyxa-IROls2IA")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeV3Code.ToBeAnnounced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to uncleared derivative margin segregation. This could be for variation or initial margin.
    /// Encoded/decoded by serializers as &quot;UDMS&quot;.
    /// </summary>
    [EnumMember(Value = "UDMS")]
    [IsoId("_1-QfUSgnEeyxa-IROls2IA")]
    [Description(@"Relates to uncleared derivative margin segregation. This could be for variation or initial margin.")]
    UnclearedDerivativeMarginSegregation = ExposureTypeV3Code.UnclearedDerivativeMarginSegregation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_5bdwkSgoEeyB747fKu7_rw")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct = ExposureTypeV3Code.TreasuryCrossProduct, // same ordinal as derivation source for type conversions
    
}
