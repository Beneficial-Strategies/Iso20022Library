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
[IsoId("_PRmHYdtkEd-RF5yaMAVhAw")]
[Description(
    @"Specifies the underlying business area/type of trade causing the collateral movement."
)]
[DerivedFrom(typeof(ExposureTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExposureType2Code>))]
#endif
public enum ExposureType2Code
{
    /// <summary>
    /// Cross currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("_q3yFdWtdEeCY4-KZ9JEyUQ_-1443065405")]
    [Description(@"Cross currency interest rate swap.")]
    CrossCurrencyIRS = ExposureTypeCode.CrossCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_q37PYGtdEeCY4-KZ9JEyUQ_1854829538")]
    [Description(@"Trading of exchanged traded commodities.")]
    Commodities = ExposureTypeCode.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of credit default swap.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_q37PYWtdEeCY4-KZ9JEyUQ_768142787")]
    [Description(@"Trading of credit default swap.")]
    CreditDefaultSwap = ExposureTypeCode.CreditDefaultSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("_q37PYmtdEeCY4-KZ9JEyUQ_2125953743")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeCode.CrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("_q37PY2tdEeCY4-KZ9JEyUQ_1128881390")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeCode.CreditSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("_q37PZGtdEeCY4-KZ9JEyUQ_282084754")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeCode.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("_q37PZWtdEeCY4-KZ9JEyUQ_736172023")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeCode.EquityOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("_q37PZmtdEeCY4-KZ9JEyUQ_-260900330")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap = ExposureTypeCode.EquitySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_q37PZ2tdEeCY4-KZ9JEyUQ_1061289530")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeCode.ExoticOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_q4FAYGtdEeCY4-KZ9JEyUQ_-1273784835")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeCode.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_q4FAYWtdEeCY4-KZ9JEyUQ_-948667328")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeCode.FixedIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward foreign exchange trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_q4FAYmtdEeCY4-KZ9JEyUQ_-1945739681")]
    [Description(@"Forward foreign exchange trades.")]
    ForwardForeignExchange = ExposureTypeCode.ForwardForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_q4FAY2tdEeCY4-KZ9JEyUQ_129353010")]
    [Description(@"Foreign exchange trades in general.")]
    ForeignExchange = ExposureTypeCode.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Related to futures trading activity.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_q4FAZGtdEeCY4-KZ9JEyUQ_1180486082")]
    [Description(@"Related to futures trading activity.")]
    Futures = ExposureTypeCode.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_q4FAZWtdEeCY4-KZ9JEyUQ_183413729")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeCode.Liquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Related to options trading activity.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_q4FAZmtdEeCY4-KZ9JEyUQ_-663382907")]
    [Description(@"Related to options trading activity.")]
    FXOption = ExposureTypeCode.FXOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("_q4OxYGtdEeCY4-KZ9JEyUQ_97382246")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeCode.OTCDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_q4OxYWtdEeCY4-KZ9JEyUQ_-899690107")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeCode.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_q4OxYmtdEeCY4-KZ9JEyUQ_-220394415")]
    [Description(@"Relates to repurchase agreement trading.")]
    RepurchaseAgreement = ExposureTypeCode.RepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_q4OxY2tdEeCY4-KZ9JEyUQ_-1912574612")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeCode.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("_q4OxZGtdEeCY4-KZ9JEyUQ_-1458487343")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeCode.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("_q4OxZWtdEeCY4-KZ9JEyUQ_1839407600")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeCode.SingleCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_q4OxZmtdEeCY4-KZ9JEyUQ_-1469586120")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeCode.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_q4OxZ2tdEeCY4-KZ9JEyUQ_-547422810")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeCode.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("_q4X7UGtdEeCY4-KZ9JEyUQ_-1544495163")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeCode.SecuredLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_q4X7UWtdEeCY4-KZ9JEyUQ_-574855215")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeCode.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("_q4X7UmtdEeCY4-KZ9JEyUQ_-249737708")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCorssProduct = ExposureTypeCode.TreasuryCorssProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("_q4X7U2tdEeCY4-KZ9JEyUQ_-1246810061")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Government Bonds (JGBs) and Gilts."
    )]
    BondForward = ExposureTypeCode.BondForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_q4X7VGtdEeCY4-KZ9JEyUQ_828282630")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeCode.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("_q4X7VWtdEeCY4-KZ9JEyUQ_-1170575451")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeCode.ToBeAnnounced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short sale exposure.
    /// Encoded/decoded by serializers as &quot;SHSL&quot;.
    /// </summary>
    [EnumMember(Value = "SHSL")]
    [IsoId("_q4X7VmtdEeCY4-KZ9JEyUQ_2127319492")]
    [Description(@"Short sale exposure.")]
    ShortSell = ExposureTypeCode.ShortSell, // same ordinal as derivation source for type conversions
}
