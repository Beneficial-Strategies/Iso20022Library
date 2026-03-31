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
[IsoId("__18hkdojEeC60axPepSq7g_133029952")]
[Description(
    @"Specifies the underlying business area/type of trade causing the collateral movement."
)]
[DerivedFrom(typeof(ExposureTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExposureType3Code>))]
#endif
public enum ExposureType3Code
{
    /// <summary>
    /// Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount.
    /// Encoded/decoded by serializers as &quot;CCIR&quot;.
    /// </summary>
    [EnumMember(Value = "CCIR")]
    [IsoId("__18hktojEeC60axPepSq7g_2123046849")]
    [Description(
        @"Cross currency agreement between two parties (known as counterparties) where one stream of future interest payments is exchanged for another based on a specified principal amount."
    )]
    CrossCurrencyIRS = ExposureTypeV2Code.CrossCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any good exchanged during commerce, which includes goods traded on a commodity exchange.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("__18hk9ojEeC60axPepSq7g_-704771684")]
    [Description(
        @"Any good exchanged during commerce, which includes goods traded on a commodity exchange."
    )]
    Commodities = ExposureTypeV2Code.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swap designed to transfer the credit exposure of fixed income products between parties.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("__18hlNojEeC60axPepSq7g_-27500024")]
    [Description(
        @"Swap designed to transfer the credit exposure of fixed income products between parties."
    )]
    CreditDefaultSwap = ExposureTypeV2Code.CreditDefaultSwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of various types of trades.
    /// Encoded/decoded by serializers as &quot;CRPR&quot;.
    /// </summary>
    [EnumMember(Value = "CRPR")]
    [IsoId("__18hldojEeC60axPepSq7g_733265129")]
    [Description(@"Combination of various types of trades.")]
    CrossProduct = ExposureTypeV2Code.CrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash lending/borrowing; letter of credit; signing of master agreement.
    /// Encoded/decoded by serializers as &quot;CRSP&quot;.
    /// </summary>
    [EnumMember(Value = "CRSP")]
    [IsoId("__2FrgNojEeC60axPepSq7g_-2094553404")]
    [Description(@"Cash lending/borrowing; letter of credit; signing of master agreement.")]
    CreditSupport = ExposureTypeV2Code.CreditSupport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening of a credit line before trading.
    /// Encoded/decoded by serializers as &quot;CRTL&quot;.
    /// </summary>
    [EnumMember(Value = "CRTL")]
    [IsoId("__2FrgdojEeC60axPepSq7g_722166352")]
    [Description(@"Opening of a credit line before trading.")]
    CreditLine = ExposureTypeV2Code.CreditLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of equity option (also known as stock options).
    /// Encoded/decoded by serializers as &quot;EQPT&quot;.
    /// </summary>
    [EnumMember(Value = "EQPT")]
    [IsoId("__2FrgtojEeC60axPepSq7g_-2105652181")]
    [Description(@"Trading of equity option (also known as stock options).")]
    EquityOption = ExposureTypeV2Code.EquityOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest.
    /// Encoded/decoded by serializers as &quot;EQUS&quot;.
    /// </summary>
    [EnumMember(Value = "EQUS")]
    [IsoId("__2Frg9ojEeC60axPepSq7g_-1276691729")]
    [Description(
        @"Equity swap trades where the return of an equity is exchanged for either a fixed or a floating rate of interest."
    )]
    EquitySwap = ExposureTypeV2Code.EquitySwap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exotic option, for example, a non standard option.
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("__2FrhNojEeC60axPepSq7g_1436625509")]
    [Description(@"Trading of exotic option, for example, a non standard option.")]
    ExoticOption = ExposureTypeV2Code.ExoticOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of exchanged traded derivatives in general.
    /// Encoded/decoded by serializers as &quot;EXTD&quot;.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("__2FrhdojEeC60axPepSq7g_-1391193024")]
    [Description(@"Trading of exchanged traded derivatives in general.")]
    ExchangeTradedDerivatives = ExposureTypeV2Code.ExchangeTradedDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading of fixed income instruments.
    /// Encoded/decoded by serializers as &quot;FIXI&quot;.
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("__2FrhtojEeC60axPepSq7g_126446116")]
    [Description(@"Trading of fixed income instruments.")]
    FixedIncome = ExposureTypeV2Code.FixedIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward FX trades.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("__2PcgNojEeC60axPepSq7g_88460073")]
    [Description(@"Forward FX trades.")]
    ForwardForeignExchange = ExposureTypeV2Code.ForwardForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FX trades in general.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("__2PcgdojEeC60axPepSq7g_1555608836")]
    [Description(@"FX trades in general.")]
    ForeignExchange = ExposureTypeV2Code.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("__2PcgtojEeC60axPepSq7g_881115626")]
    [Description(
        @"Agreement to buy or sell a specific amount of a commodity or financial instrument at a particular price on a stipulated future date."
    )]
    Futures = ExposureTypeV2Code.Futures, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of settlement via an RTGS or other clearing system.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("__2Pcg9ojEeC60axPepSq7g_246083780")]
    [Description(@"In support of settlement via an RTGS or other clearing system.")]
    Liquidity = ExposureTypeV2Code.Liquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("__2PchNojEeC60axPepSq7g_1713232543")]
    [Description(
        @"A contract that grants the holder the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time."
    )]
    FXOption = ExposureTypeV2Code.FXOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// OTC derivatives trading.
    /// Encoded/decoded by serializers as &quot;OTCD&quot;.
    /// </summary>
    [EnumMember(Value = "OTCD")]
    [IsoId("__2PchdojEeC60axPepSq7g_1324104118")]
    [Description(@"OTC derivatives trading.")]
    OTCDerivatives = ExposureTypeV2Code.OTCDerivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of any type of cash settlement.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("__2PchtojEeC60axPepSq7g_-1503714415")]
    [Description(@"In support of any type of cash settlement.")]
    CashSettlement = ExposureTypeV2Code.CashSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__2Pch9ojEeC60axPepSq7g_-368076079")]
    [Description(@"Relates to repurchase agreement trading.")]
    Repo = ExposureTypeV2Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("__2ZNgNojEeC60axPepSq7g_849013600")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV2Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exotic single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIE&quot;.
    /// </summary>
    [EnumMember(Value = "SCIE")]
    [IsoId("__2ZNgdojEeC60axPepSq7g_-1978804933")]
    [Description(@"Exotic single currency interest rate swap.")]
    SingleCurrencyIRSExotic = ExposureTypeV2Code.SingleCurrencyIRSExotic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single currency interest rate swap.
    /// Encoded/decoded by serializers as &quot;SCIR&quot;.
    /// </summary>
    [EnumMember(Value = "SCIR")]
    [IsoId("__2ZNgtojEeC60axPepSq7g_-2088142740")]
    [Description(@"Single currency interest rate swap.")]
    SingleCurrencyIRS = ExposureTypeV2Code.SingleCurrencyIRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of securities related exposure types.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("__2ZNg9ojEeC60axPepSq7g_-1079493888")]
    [Description(@"Combination of securities related exposure types.")]
    SecuritiesCrossProducts = ExposureTypeV2Code.SecuritiesCrossProducts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("__2ZNhNojEeC60axPepSq7g_387654875")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV2Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a secured loan.
    /// Encoded/decoded by serializers as &quot;SLOA&quot;.
    /// </summary>
    [EnumMember(Value = "SLOA")]
    [IsoId("__2ZNhdojEeC60axPepSq7g_-1711664315")]
    [Description(@"Exposure is linked to a secured loan.")]
    SecuredLoan = ExposureTypeV2Code.SecuredLoan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option on interest rate swap.
    /// Encoded/decoded by serializers as &quot;SWPT&quot;.
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("__2ZNhtojEeC60axPepSq7g_-244515552")]
    [Description(@"Option on interest rate swap.")]
    Swaption = ExposureTypeV2Code.Swaption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Combination of treasury related exposure types.
    /// Encoded/decoded by serializers as &quot;TRCP&quot;.
    /// </summary>
    [EnumMember(Value = "TRCP")]
    [IsoId("__2iXcNojEeC60axPepSq7g_-1386546808")]
    [Description(@"Combination of treasury related exposure types.")]
    TreasuryCrossProduct = ExposureTypeV2Code.TreasuryCrossProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts.
    /// Encoded/decoded by serializers as &quot;BFWD&quot;.
    /// </summary>
    [EnumMember(Value = "BFWD")]
    [IsoId("__2iXcdojEeC60axPepSq7g_573346123")]
    [Description(
        @"Any securities traded out beyond 3 days which include treasury notes, Japanese Governement Bonds (JGBs) and Gilts."
    )]
    BondForward = ExposureTypeV2Code.BondForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In support of a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("__2iXctojEeC60axPepSq7g_2040494886")]
    [Description(@"In support of a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = ExposureTypeV2Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To be announced (TBA) related collateral.
    /// Encoded/decoded by serializers as &quot;TBAS&quot;.
    /// </summary>
    [EnumMember(Value = "TBAS")]
    [IsoId("__2iXc9ojEeC60axPepSq7g_898463630")]
    [Description(@"To be announced (TBA) related collateral.")]
    ToBeAnnounced = ExposureTypeV2Code.ToBeAnnounced, // same ordinal as derivation source for type conversions
}
