// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWaXwYS2Ee-Pv9KR9bv9IA")]
[Description(
    @"Specifies the underlying business area/type of trade causing the collateral movement."
)]
[DerivedFrom(typeof(ExposureTypeV3Code))]
public enum ExposureType15Code
{
    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds and US treasuries.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds and US treasuries."
    )]
    BondForward = ExposureTypeV3Code.BondForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposures related to activity with central banks.
    /// Encoded/decoded by serializers as &quot;CBCO&quot;.
    /// </summary>
    [EnumMember(Value = "CBCO")]
    [IsoId("")]
    [Description(@"Exposures related to activity with central banks.")]
    CentralBankCreditOperations = ExposureTypeV3Code.CentralBankCreditOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified notional principal amount. The interest obligations are denominated in two different currencies.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("")]
    [Description(
        @"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified notional principal amount. The interest obligations are denominated in two different currencies."
    )]
    CrossCurrencyIRS = ExposureTypeV3Code.CrossCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral covering the initial margin requirements for OTC trades cleared through a central counterparty.
    /// Encoded/decoded by serializers as &quot;CCPC&quot;.
    /// </summary>
    [EnumMember(Value = "CCPC")]
    [IsoId("")]
    [Description(
        @"Collateral covering the initial margin requirements for OTC trades cleared through a central counterparty."
    )]
    CCPCollateral = ExposureTypeV3Code.CCPCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("")]
    [Description(
        @"Any good exchanged during commerce, which includes goods traded on a commodity exchange."
    )]
    Commodities = ExposureTypeV3Code.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("")]
    [Description(
        @"Swap designed to transfer the credit exposure of fixed income products between parties."
    )]
    CreditDefaultSwap = ExposureTypeV3Code.CreditDefaultSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeV3Code.CrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeV3Code.CreditSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeV3Code.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeV3Code.EquityOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or floating rate.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or floating rate."
    )]
    EquitySwap = ExposureTypeV3Code.EquitySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeV3Code.ExoticOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeV3Code.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeV3Code.FixedIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange = ExposureTypeV3Code.ForwardForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("")]
    [Description(@"FX trades in general.")]
    ForeignExchange = ExposureTypeV3Code.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("")]
    [Description(
        @"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date."
    )]
    Futures = ExposureTypeV3Code.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeV3Code.Liquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("")]
    [Description(
        @"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time."
    )]
    FXOption = ExposureTypeV3Code.FXOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeV3Code.OTCDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeV3Code.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeV3Code.RepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeV3Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV3Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeV3Code.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeV3Code.SingleCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeV3Code.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short sell exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("")]
    [Description(@"Short sell exposure.")]
    ShortSell = ExposureTypeV3Code.ShortSell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV3Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeV3Code.SecuredLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeV3Code.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeV3Code.ToBeAnnounced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct = ExposureTypeV3Code.TreasuryCrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to uncleared derivative margin segregation. This could be for variation margin or initial margin.
    /// Encoded/decoded by serializers as &quot;UDMS&quot;.
    /// </summary>
    [EnumMember(Value = "UDMS")]
    [IsoId("")]
    [Description(
        @"Relates to uncleared derivative margin segregation. This could be for variation margin or initial margin."
    )]
    UnclearedDerivativeMarginSegregation = ExposureTypeV3Code.UnclearedDerivativeMarginSegregation, // same ordinal as derivation source for type conversions
}
