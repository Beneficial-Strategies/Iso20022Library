// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5Y5AxSs8EeySlt9bF77XfA")]
[Description(
    @"Specifies the underlying business area/type of trade causing the collateral movement."
)]
[DerivedFrom(typeof(ExposureTypeV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExposureType14Code>))]
#endif
public enum ExposureType14Code
{
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_5ZCxtSs8EeySlt9bF77XfA")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts."
    )]
    BondForward = ExposureTypeV3Code.BondForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_5ZCxqis8EeySlt9bF77XfA")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeV3Code.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposures related to activity with central banks.
    /// Encoded/decoded by serializers as &quot;CBCO&quot;.
    /// </summary>
    [EnumMember(Value = "CBCO")]
    [IsoId("_5ZCxtis8EeySlt9bF77XfA")]
    [Description(@"Exposures related to activity with central banks.")]
    CentralBankCreditOperations = ExposureTypeV3Code.CentralBankCreditOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_5ZCxpys8EeySlt9bF77XfA")]
    [Description(
        @"Any good exchanged during commerce, which includes goods traded on a commodity exchange."
    )]
    Commodities = ExposureTypeV3Code.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_5Y5AzSs8EeySlt9bF77XfA")]
    [Description(
        @"Swap designed to transfer the credit exposure of fixed income products between parties."
    )]
    CreditDefaultSwap = ExposureTypeV3Code.CreditDefaultSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_5ZCxqys8EeySlt9bF77XfA")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeV3Code.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_5ZCxrys8EeySlt9bF77XfA")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeV3Code.CreditSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_5Y5Axis8EeySlt9bF77XfA")]
    [Description(
        @"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount."
    )]
    CrossCurrencyIRS = ExposureTypeV3Code.CrossCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_5ZCxuCs8EeySlt9bF77XfA")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeV3Code.CrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_5ZCxoys8EeySlt9bF77XfA")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeV3Code.EquityOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_5ZCxuis8EeySlt9bF77XfA")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap = ExposureTypeV3Code.EquitySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_5ZCxoCs8EeySlt9bF77XfA")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeV3Code.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_5ZCxqCs8EeySlt9bF77XfA")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeV3Code.ExoticOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_5ZCxsys8EeySlt9bF77XfA")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeV3Code.FixedIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_5Y5Ayys8EeySlt9bF77XfA")]
    [Description(@"FX trades in general.")]
    ForeignExchange = ExposureTypeV3Code.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_5Y5AySs8EeySlt9bF77XfA")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange = ExposureTypeV3Code.ForwardForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_5ZCxrSs8EeySlt9bF77XfA")]
    [Description(
        @"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date."
    )]
    Futures = ExposureTypeV3Code.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_5ZCxsCs8EeySlt9bF77XfA")]
    [Description(
        @"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time."
    )]
    FXOption = ExposureTypeV3Code.FXOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_5ZCxsSs8EeySlt9bF77XfA")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeV3Code.Liquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_5ZCxsis8EeySlt9bF77XfA")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeV3Code.OTCDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_5ZCxqSs8EeySlt9bF77XfA")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeV3Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_5ZCxpis8EeySlt9bF77XfA")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeV3Code.SecuredLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_5ZCxtys8EeySlt9bF77XfA")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV3Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_5ZCxrCs8EeySlt9bF77XfA")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeV3Code.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_5Y5AzCs8EeySlt9bF77XfA")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV3Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_5ZCxris8EeySlt9bF77XfA")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeV3Code.SingleCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_5Y5Axys8EeySlt9bF77XfA")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeV3Code.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_5ZCxpSs8EeySlt9bF77XfA")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeV3Code.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_5Y5Ayis8EeySlt9bF77XfA")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeV3Code.ToBeAnnounced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_5ZCxuSs8EeySlt9bF77XfA")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct = ExposureTypeV3Code.TreasuryCrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to uncleared derivative margin segregation. This could be for variation or initial margin.
    /// Encoded/decoded by serializers as &quot;UDMS&quot;.
    /// </summary>
    [EnumMember(Value = "UDMS")]
    [IsoId("_5Y5AyCs8EeySlt9bF77XfA")]
    [Description(
        @"Relates to uncleared derivative margin segregation. This could be for variation or initial margin."
    )]
    UnclearedDerivativeMarginSegregation = ExposureTypeV3Code.UnclearedDerivativeMarginSegregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a CCP.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("_5ZCxoSs8EeySlt9bF77XfA")]
    [Description(
        @"Collateral covering the initial margin requirements for OTC trades cleared through a CCP."
    )]
    CCPCollateral = ExposureTypeV3Code.CCPCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_5ZCxois8EeySlt9bF77XfA")]
    [Description(@"Trading of equity.")]
    Equity = ExposureTypeV3Code.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of treasury bonds.
    /// Encoded/decoded by serializers as &quot;TRBD&quot;.
    /// </summary>
    [EnumMember(Value = "TRBD")]
    [IsoId("_5ZCxtCs8EeySlt9bF77XfA")]
    [Description(@"Trading of treasury bonds.")]
    TreasuryBonds = ExposureTypeV3Code.TreasuryBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_5ZCxpCs8EeySlt9bF77XfA")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeV3Code.RepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short sell exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_5ZCxuys8EeySlt9bF77XfA")]
    [Description(@"Short sell exposure.")]
    ShortSell = ExposureTypeV3Code.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin lending transaction.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_A7tR0Ss9EeySlt9bF77XfA")]
    [Description(@"Margin lending transaction. ")]
    MarginLending = ExposureTypeV3Code.MarginLending, // same ordinal as derivation source for type conversions
}
