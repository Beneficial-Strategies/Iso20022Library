// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__xLWUdojEeC60axPepSq7g_852299890")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementTransactionType7Code>))]
#endif
public enum SettlementTransactionType7Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("__xLWUtojEeC60axPepSq7g_1321107305")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV3Code.BuySellBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("__xLWU9ojEeC60axPepSq7g_998617269")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral taker or its agent."
    )]
    CollateralIn = SecuritiesTransactionTypeV3Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("__xLWVNojEeC60axPepSq7g_-1772281731")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral giver or its agent."
    )]
    CollateralOut = SecuritiesTransactionTypeV3Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("__xLWVdojEeC60axPepSq7g_987518492")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV3Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("__xUgQNojEeC60axPepSq7g_-1783380508")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV3Code.FactorUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("__xUgQdojEeC60axPepSq7g_2038651564")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV3Code.MoveOfStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("__xUgQtojEeC60axPepSq7g_194782575")]
    [Description(
        @"Relates to the issuance of a security such as an equity or a depositary receipt."
    )]
    Issuance = SecuritiesTransactionTypeV3Code.Issuance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("__xUgQ9ojEeC60axPepSq7g_1718850871")]
    [Description(
        @"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned)."
    )]
    MarkDown = SecuritiesTransactionTypeV3Code.MarkDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("__xUgRNojEeC60axPepSq7g_1609019197")]
    [Description(
        @"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned)."
    )]
    MarkUp = SecuritiesTransactionTypeV3Code.MarkUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("__xUgRdojEeC60axPepSq7g_-1161879803")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV3Code.Netting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("__xUgRtojEeC60axPepSq7g_973987351")]
    [Description(
        @"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement."
    )]
    NonSyndicated = SecuritiesTransactionTypeV3Code.NonSyndicated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("__xeRQNojEeC60axPepSq7g_-400937661")]
    [Description(
        @"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver)."
    )]
    ExternalAccountTransfer = SecuritiesTransactionTypeV3Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("__xeRQdojEeC60axPepSq7g_1123130635")]
    [Description(
        @"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver)."
    )]
    InternalAccountTransfer = SecuritiesTransactionTypeV3Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("__xeRQtojEeC60axPepSq7g_-412036438")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    PairOff = SecuritiesTransactionTypeV3Code.PairOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("__xeRQ9ojEeC60axPepSq7g_42050831")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV3Code.Placement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("__xeRRNojEeC60axPepSq7g_1566119127")]
    [Description(
        @"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such."
    )]
    PortfolioMove = SecuritiesTransactionTypeV3Code.PortfolioMove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("__xeRRdojEeC60axPepSq7g_1399861787")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV3Code.Realignment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("__xeRRtojEeC60axPepSq7g_-1371037213")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV3Code.Withdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("__xoCQNojEeC60axPepSq7g_713440447")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation =
        SecuritiesTransactionTypeV3Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("__xoCQdojEeC60axPepSq7g_-2057458553")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV3Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("__xoCQtojEeC60axPepSq7g_306857")]
    [Description(
        @"Relates to the return of financial instruments resulting from a rejected delivery without matching operation."
    )]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV3Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("__xoCQ9ojEeC60axPepSq7g_1524375153")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SecuritiesTransactionTypeV3Code.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("__xoCRNojEeC60axPepSq7g_-634724989")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement = SecuritiesTransactionTypeV3Code.ReverseRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("__xoCRdojEeC60axPepSq7g_-1389474863")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV3Code.SellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("__xoCRtojEeC60axPepSq7g_599478746")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV3Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("__xxMMNojEeC60axPepSq7g_2123547042")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV3Code.SecuritiesLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("__xxMMdojEeC60axPepSq7g_420268068")]
    [Description(
        @"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager."
    )]
    SyndicateUnderwriters = SecuritiesTransactionTypeV3Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("__xxMMtojEeC60axPepSq7g_-1421576889")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV3Code.TBAClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("__xxMM9ojEeC60axPepSq7g_-63765933")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV3Code.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("__xxMNNojEeC60axPepSq7g_1460302363")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV3Code.TripartyRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("__xxMNdojEeC60axPepSq7g_-1907634922")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV3Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("__xxMNtojEeC60axPepSq7g_-383566626")]
    [Description(
        @"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers."
    )]
    Turnaround = SecuritiesTransactionTypeV3Code.Turnaround, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("__x69MNojEeC60axPepSq7g_-1846627040")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose = SecuritiesTransactionTypeV3Code.GuaranteedClose, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offering issue trade.
    /// Encoded/decoded by serializers as &quot;OFIT&quot;.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("__x69MdojEeC60axPepSq7g_1653301135")]
    [Description(@"Offering issue trade.")]
    OfferingIssuingTrade = SecuritiesTransactionTypeV3Code.OfferingIssuingTrade, // same ordinal as derivation source for type conversions
}
