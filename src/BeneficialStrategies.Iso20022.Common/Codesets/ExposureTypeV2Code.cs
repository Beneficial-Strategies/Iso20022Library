// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__saLE9ojEeC60axPepSq7g_1734395228")]
[Description(
    @"Specifies the underlying business area/type of trade causing the collateral movement."
)]
[Derivations(typeof(ExposureType3Code), typeof(ExposureType10Code))]
public enum ExposureTypeV2Code
{
    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("__saLFNojEeC60axPepSq7g_1620556162")]
    [Description(
        @"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount."
    )]
    CrossCurrencyIRS,

    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("__sjVANojEeC60axPepSq7g_915441547")]
    [Description(
        @"Any good exchanged during commerce, which includes goods traded on a commodity exchange."
    )]
    Commodities,

    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("__sjVAdojEeC60axPepSq7g_-259749478")]
    [Description(
        @"Swap designed to transfer the credit exposure of fixed income products between parties."
    )]
    CreditDefaultSwap,

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("__sjVAtojEeC60axPepSq7g_1385517957")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct,

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("__sjVA9ojEeC60axPepSq7g_-1370660897")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport,

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("__sjVBNojEeC60axPepSq7g_-2075775512")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine,

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("__sjVBdojEeC60axPepSq7g_1044000759")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption,

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("__sjVBtojEeC60axPepSq7g_-1605699102")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap,

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("__stGANojEeC60axPepSq7g_-66910660")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption,

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("__stGAdojEeC60axPepSq7g_-772025275")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives,

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("__stGAtojEeC60axPepSq7g_-1947216300")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome,

    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("__stGA9ojEeC60axPepSq7g_-301948865")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange,

    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("__stGBNojEeC60axPepSq7g_1236839577")]
    [Description(@"FX trades in general.")]
    ForeignExchange,

    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("__stGBdojEeC60axPepSq7g_-1155741860")]
    [Description(
        @"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date."
    )]
    Futures,

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("__s23ANojEeC60axPepSq7g_1964034411")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity,

    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("__s23AdojEeC60axPepSq7g_-685665450")]
    [Description(
        @"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time."
    )]
    FXOption,

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("__s23AtojEeC60axPepSq7g_853122992")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives,

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("__s23A9ojEeC60axPepSq7g_148008377")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement,

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__s23BNojEeC60axPepSq7g_-1027182648")]
    [Description(@"Relates to repurchase agreement trading.")]
    Repo,

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("__s23BdojEeC60axPepSq7g_618084787")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack,

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("__s23BtojEeC60axPepSq7g_-2138094067")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic,

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("__tAA8NojEeC60axPepSq7g_1451758614")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS,

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("__tAA8dojEeC60axPepSq7g_276567589")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts,

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("__tAA8tojEeC60axPepSq7g_1921835024")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing,

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("__tAA89ojEeC60axPepSq7g_-834343830")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan,

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("__tAA9NojEeC60axPepSq7g_-1539458445")]
    [Description(@"Option on interest rate swap.")]
    Swaption,

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("__tAA9dojEeC60axPepSq7g_1580317826")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct,

    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("__tAA9tojEeC60axPepSq7g_-1069382035")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts."
    )]
    BondForward,

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("__tJx8NojEeC60axPepSq7g_-2066454388")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement,

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("__tJx8dojEeC60axPepSq7g_1231440555")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced,

    /// <summary>
    /// Exposures related to activity with central banks.
    /// Encoded/decoded by serializers as &quot;CBCO&quot;.
    /// </summary>
    [EnumMember(Value = "CBCO")]
    [IsoId("_NgzTALy2EeivTd4NUfCi2g")]
    [Description(@"Exposures related to activity with central banks.")]
    CentralBankCreditOperations,

    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_pBzXoLy7EeivTd4NUfCi2g")]
    [Description(
        @"Collateral covering the initial margin requirements for OTC trades cleared through a CCP."
    )]
    CCPCollateral,

    /// <summary>
    /// Short sale exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_FCEkcLy8EeivTd4NUfCi2g")]
    [Description(@"Short sale exposure.")]
    ShortSale,

    /// <summary>
    /// Relates to uncleared derivative margin segregation. This could be for variation or initial margin.
    /// Encoded/decoded by serializers as &quot;UDMS&quot;.
    /// </summary>
    [EnumMember(Value = "UDMS")]
    [IsoId("_wxcnIGeTEeu47f5b1oImTg")]
    [Description(
        @"Relates to uncleared derivative margin segregation. This could be for variation or initial margin."
    )]
    UnclearedDerivativeMarginSegregation,

    /// <summary>
    /// Trading of equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_eNjtgeMLEeuy-L_xpKAN3w")]
    [Description(@"Trading of equity.")]
    Equity,

    /// <summary>
    /// Trading of treasury bonds.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_tO17YeMLEeuy-L_xpKAN3w")]
    [Description(@"Trading of treasury bonds.")]
    TreasuryBonds,

    /// <summary>
    /// Margin lending transaction.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_vRK_geMLEeuy-L_xpKAN3w")]
    [Description(@"Margin lending transaction. ")]
    MarginLending,

    /// <summary>
    /// Total open market credit operations.
    /// Encoded/decoded by serializers as &quot;EOMO&quot;.
    /// </summary>
    [EnumMember(Value = "EOMO")]
    [IsoId("_zmFKQeMLEeuy-L_xpKAN3w")]
    [Description(@"Total open market credit operations.|||")]
    TotalOpenMarketCreditOperations,

    /// <summary>
    /// Total initial margin on outstanding liquidity providing open market operations.
    /// Encoded/decoded by serializers as &quot;EOIM&quot;.
    /// </summary>
    [EnumMember(Value = "EOIM")]
    [IsoId("_1ozP8eMLEeuy-L_xpKAN3w")]
    [Description(
        @"Total initial margin on outstanding liquidity providing open market operations."
    )]
    TotalInitialMarginOnOutstandingLiquidity,

    /// <summary>
    /// Total open market credit operations interest.
    /// Encoded/decoded by serializers as &quot;EOMI&quot;.
    /// </summary>
    [EnumMember(Value = "EOMI")]
    [IsoId("_3m1C4eMLEeuy-L_xpKAN3w")]
    [Description(@"Total open market credit operations interest.")]
    TotalOpenMarketCreditOperationsInterest,

    /// <summary>
    /// Total credit freezing.
    /// Encoded/decoded by serializers as &quot;ECFR&quot;.
    /// </summary>
    [EnumMember(Value = "ECFR")]
    [IsoId("_6R5iAeMLEeuy-L_xpKAN3w")]
    [Description(@"Total credit freezing.")]
    TotalCreditFreezing,

    /// <summary>
    /// Total marginal lending.
    /// Encoded/decoded by serializers as &quot;EMLO&quot;.
    /// </summary>
    [EnumMember(Value = "EMLO")]
    [IsoId("_8IkIseMLEeuy-L_xpKAN3w")]
    [Description(@"Total marginal lending.")]
    TotalMarginalLending,

    /// <summary>
    /// Total marginal lending interest.
    /// Encoded/decoded by serializers as &quot;EMLI&quot;.
    /// </summary>
    [EnumMember(Value = "EMLI")]
    [IsoId("__QRggeMLEeuy-L_xpKAN3w")]
    [Description(@"Total marginal lending interest.")]
    TotalMarginalLendingInterest,

    /// <summary>
    /// Total credit.
    /// Encoded/decoded by serializers as &quot;ECRT&quot;.
    /// </summary>
    [EnumMember(Value = "ECRT")]
    [IsoId("_WznPAeMMEeuy-L_xpKAN3w")]
    [Description(@"Total credit.|")]
    TotalCredit,

    /// <summary>
    /// Suggested credit line.
    /// Encoded/decoded by serializers as &quot;ESCL&quot;.
    /// </summary>
    [EnumMember(Value = "ESCL")]
    [IsoId("_Yw6CIeMMEeuy-L_xpKAN3w")]
    [Description(@"Suggested credit line.")]
    SuggestedCreditLine,
}
