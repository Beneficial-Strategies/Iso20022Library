// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the exposure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4keZoALtEeutW5-TpeYJhA")]
[Description(@"Specifies the underlying business area/type of trade causing the exposure.")]
[DerivedFrom(typeof(ExposureTypeCode))]
public enum ExposureType8Code
{
    /// <summary>
    /// Cross currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_6eBVMQLtEeutW5-TpeYJhA")]
    [Description(@"Cross currency interest rate swap.")]
    CrossCurrencyIRS = ExposureTypeCode.CrossCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_6nZTogLtEeutW5-TpeYJhA")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeCode.CrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_6swUwgLtEeutW5-TpeYJhA")]
    [Description(@"Trading of equity.")]
    Equity = ExposureTypeCode.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_6z43ggLtEeutW5-TpeYJhA")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeCode.EquityOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_69am8gLtEeutW5-TpeYJhA")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap = ExposureTypeCode.EquitySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_7DNs8gLtEeutW5-TpeYJhA")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeCode.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_7JBaAgLtEeutW5-TpeYJhA")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeCode.ExoticOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_7UBwIgLtEeutW5-TpeYJhA")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeCode.FixedIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_7abTEgLtEeutW5-TpeYJhA")]
    [Description(@"Foreign exchange trades in general.")]
    ForeignExchange = ExposureTypeCode.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward foreign exchange trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_7grFAgLtEeutW5-TpeYJhA")]
    [Description(@"Forward foreign exchange trades.")]
    ForwardForeignExchange = ExposureTypeCode.ForwardForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Related to futures trading activity.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_7mxtAgLtEeutW5-TpeYJhA")]
    [Description(@"Related to futures trading activity.")]
    Futures = ExposureTypeCode.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Related to options trading activity.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_7r-9IgLtEeutW5-TpeYJhA")]
    [Description(@"Related to options trading activity.")]
    FXOption = ExposureTypeCode.FXOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_7xoSIgLtEeutW5-TpeYJhA")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeCode.Liquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin lending transaction.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_73lJIgLtEeutW5-TpeYJhA")]
    [Description(@"Margin lending transaction. ")]
    MarginLending = ExposureTypeCode.MarginLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_79rxIgLtEeutW5-TpeYJhA")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeCode.OTCDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_8EYPAgLtEeutW5-TpeYJhA")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeCode.RepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_8M21kgLtEeutW5-TpeYJhA")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeCode.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_8UJwYgLtEeutW5-TpeYJhA")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeCode.SecuredLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_8aisQQLtEeutW5-TpeYJhA")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeCode.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_8hisIgLtEeutW5-TpeYJhA")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeCode.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_8orO4gLtEeutW5-TpeYJhA")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeCode.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short sale exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_8ux24gLtEeutW5-TpeYJhA")]
    [Description(@"Short sale exposure.")]
    ShortSell = ExposureTypeCode.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_85WIIgLtEeutW5-TpeYJhA")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeCode.SingleCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_8-siMgLtEeutW5-TpeYJhA")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeCode.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suggested credit line.
    /// Encoded/decoded by serializers as &quot;ESCL&quot;.
    /// </summary>
    [EnumMember(Value = "ESCL")]
    [IsoId("_9F1sAgLtEeutW5-TpeYJhA")]
    [Description(@"Suggested credit line.")]
    SuggestedCreditLine = ExposureTypeCode.SuggestedCreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_9MPO8gLtEeutW5-TpeYJhA")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeCode.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_9TYYwgLtEeutW5-TpeYJhA")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeCode.ToBeAnnounced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total credit.
    /// Encoded/decoded by serializers as &quot;ECRT&quot;.
    /// </summary>
    [EnumMember(Value = "ECRT")]
    [IsoId("_9ZxUogLtEeutW5-TpeYJhA")]
    [Description(@"Total credit.|")]
    TotalCredit = ExposureTypeCode.TotalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total credit freezing.
    /// Encoded/decoded by serializers as &quot;ECFR&quot;.
    /// </summary>
    [EnumMember(Value = "ECFR")]
    [IsoId("_9f38ogLtEeutW5-TpeYJhA")]
    [Description(@"Total credit freezing.")]
    TotalCreditFreezing = ExposureTypeCode.TotalCreditFreezing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total marginal lending.
    /// Encoded/decoded by serializers as &quot;EMLO&quot;.
    /// </summary>
    [EnumMember(Value = "EMLO")]
    [IsoId("_9sElkgLtEeutW5-TpeYJhA")]
    [Description(@"Total marginal lending.")]
    TotalMarginalLending = ExposureTypeCode.TotalMarginalLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total marginal lending interest.
    /// Encoded/decoded by serializers as &quot;EMLI&quot;.
    /// </summary>
    [EnumMember(Value = "EMLI")]
    [IsoId("_943rcgLtEeutW5-TpeYJhA")]
    [Description(@"Total marginal lending interest.")]
    TotalMarginalLendingInterest = ExposureTypeCode.TotalMarginalLendingInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total initial margin on outstanding liquidity providing open market operations.
    /// Encoded/decoded by serializers as &quot;EOIM&quot;.
    /// </summary>
    [EnumMember(Value = "EOIM")]
    [IsoId("_-BMhAgLtEeutW5-TpeYJhA")]
    [Description(
        @"Total initial margin on outstanding liquidity providing open market operations."
    )]
    TotalInitialMarginOnOutstandingLiquidity =
        ExposureTypeCode.TotalInitialMarginOnOutstandingLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total open market credit operations interest.
    /// Encoded/decoded by serializers as &quot;EOMI&quot;.
    /// </summary>
    [EnumMember(Value = "EOMI")]
    [IsoId("_-OcS0gLtEeutW5-TpeYJhA")]
    [Description(@"Total open market credit operations interest.")]
    TotalOpenMarketCreditOperationsInterest =
        ExposureTypeCode.TotalOpenMarketCreditOperationsInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_-wzZAgLtEeutW5-TpeYJhA")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCorssProduct = ExposureTypeCode.TreasuryCorssProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of treasury bonds.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_-4_EogLtEeutW5-TpeYJhA")]
    [Description(@"Trading of treasury bonds.")]
    TreasuryBonds = ExposureTypeCode.TreasuryBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("__snhAgLtEeutW5-TpeYJhA")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts."
    )]
    BondForward = ExposureTypeCode.BondForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("__zKN4gLtEeutW5-TpeYJhA")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeCode.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("__5s6wgLtEeutW5-TpeYJhA")]
    [Description(
        @"Collateral covering the initial margin requirements for OTC trades cleared through a CCP."
    )]
    CCPCollateral = ExposureTypeCode.CCPCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("___9TwgLtEeutW5-TpeYJhA")]
    [Description(@"Trading of exchanged traded commodities.")]
    Commodities = ExposureTypeCode.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of credit default swap.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_AGDUsgLuEeutW5-TpeYJhA")]
    [Description(@"Trading of credit default swap.")]
    CreditDefaultSwap = ExposureTypeCode.CreditDefaultSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_AMTGogLuEeutW5-TpeYJhA")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeCode.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_AVFPMgLuEeutW5-TpeYJhA")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeCode.CreditSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total open market credit operations.
    /// Encoded/decoded by serializers as &quot;EOMO&quot;.
    /// </summary>
    [EnumMember(Value = "EOMO")]
    [IsoId("_AchT8gLuEeutW5-TpeYJhA")]
    [Description(@"Total open market credit operations.|||")]
    TotalOpenMarketCreditOperations = ExposureTypeCode.TotalOpenMarketCreditOperations, // same ordinal as derivation source for type conversions
}
