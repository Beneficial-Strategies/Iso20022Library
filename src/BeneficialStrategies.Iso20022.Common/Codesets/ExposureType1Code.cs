// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_alShsdp-Ed-ak6NoX_4Aeg_1953265627")]
[Description(@"Specifies the underlying business area/type of trade causing the collateral movement.")]
[DerivedFrom(typeof(ExposureTypeCode))]
public enum ExposureType1Code
{
    /// <summary>
    /// Cross currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_alShstp-Ed-ak6NoX_4Aeg_-802736238")]
    [Description(@"Cross currency interest rate swap.")]
    CrossCurrencyIRS = ExposureTypeCode.CrossCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exchanged traded commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_alShs9p-Ed-ak6NoX_4Aeg_-348648969")]
    [Description(@"Trading of exchanged traded commodities.")]
    Commodities = ExposureTypeCode.Commodities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of credit default swap.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_alShtNp-Ed-ak6NoX_4Aeg_-359747746")]
    [Description(@"Trading of credit default swap.")]
    CreditDefaultSwap = ExposureTypeCode.CreditDefaultSwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_alShtdp-Ed-ak6NoX_4Aeg_691385326")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeCode.CrossProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_alShttp-Ed-ak6NoX_4Aeg_-816267379")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeCode.CreditSupport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_alSht9p-Ed-ak6NoX_4Aeg_1120957794")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeCode.CreditLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_alShuNp-Ed-ak6NoX_4Aeg_261752959")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeCode.EquityOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_alShudp-Ed-ak6NoX_4Aeg_-373278887")]
    [Description(@"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.")]
    EquitySwap = ExposureTypeCode.EquitySwap, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_alcSsNp-Ed-ak6NoX_4Aeg_-1748203899")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeCode.ExoticOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_alcSsdp-Ed-ak6NoX_4Aeg_189021274")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeCode.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_alcSstp-Ed-ak6NoX_4Aeg_-987438746")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeCode.FixedIncome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Forward foreign exchange trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_alcSs9p-Ed-ak6NoX_4Aeg_229650933")]
    [Description(@"Forward foreign exchange trades.")]
    ForwardForeignExchange = ExposureTypeCode.ForwardForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign exchange trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_alcStNp-Ed-ak6NoX_4Aeg_1587461889")]
    [Description(@"Foreign exchange trades in general.")]
    ForeignExchange = ExposureTypeCode.ForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Related to futures trading activity.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_alcStdp-Ed-ak6NoX_4Aeg_-563084984")]
    [Description(@"Related to futures trading activity.")]
    Futures = ExposureTypeCode.Futures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_alcSttp-Ed-ak6NoX_4Aeg_1374140189")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeCode.Liquidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Related to options trading activity.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_alcSt9p-Ed-ak6NoX_4Aeg_197680169")]
    [Description(@"Related to options trading activity.")]
    FXOption = ExposureTypeCode.FXOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_alcSuNp-Ed-ak6NoX_4Aeg_2134905342")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeCode.OTCDerivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_alcSudp-Ed-ak6NoX_4Aeg_186581392")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeCode.CashSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_almDsNp-Ed-ak6NoX_4Aeg_2123806565")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeCode.RepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_almDsdp-Ed-ak6NoX_4Aeg_-1812276689")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeCode.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_almDstp-Ed-ak6NoX_4Aeg_124948484")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeCode.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_almDs9p-Ed-ak6NoX_4Aeg_-1487159182")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeCode.SingleCurrencyIRS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_almDtNp-Ed-ak6NoX_4Aeg_450065991")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeCode.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_almDtdp-Ed-ak6NoX_4Aeg_187906959")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeCode.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_almDttp-Ed-ak6NoX_4Aeg_249089754")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeCode.SecuredLoan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_almDt9p-Ed-ak6NoX_4Aeg_-2108652369")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeCode.Swaption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_almDuNp-Ed-ak6NoX_4Aeg_1327110092")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCorssProduct = ExposureTypeCode.TreasuryCorssProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_almDudp-Ed-ak6NoX_4Aeg_-1030632031")]
    [Description(@"Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.")]
    BondForward = ExposureTypeCode.BondForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_almDutp-Ed-ak6NoX_4Aeg_1781197361")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeCode.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_alvNoNp-Ed-ak6NoX_4Aeg_-576544762")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeCode.ToBeAnnounced, // same ordinal as derivation source for type conversions
    
}
