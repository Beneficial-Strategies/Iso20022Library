// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZIwSQtp-Ed-ak6NoX_4Aeg_-1421887384")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[Derivations(typeof(SecuritiesTransactionType11Code), typeof(SecuritiesTransactionType2Code))]
public enum SecuritiesTransactionTypeCode
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_ZIwSQ9p-Ed-ak6NoX_4Aeg_-835940358")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,

    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BIYI&quot;.
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("_ZIwSRNp-Ed-ak6NoX_4Aeg_809327077")]
    [Description(
        @"Transaction relates to a buy-in by the market following a delivery transaction failure."
    )]
    BuyIn,

    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_ZIwSRdp-Ed-ak6NoX_4Aeg_-187745276")]
    [Description(
        @"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations."
    )]
    CentralBankCollateralOperation,

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZIwSRtp-Ed-ak6NoX_4Aeg_1351043166")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral taker or its agent."
    )]
    CollateralIn,

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZIwSR9p-Ed-ak6NoX_4Aeg_286338526")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral giver or its agent."
    )]
    CollateralOut,

    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ZIwSSNp-Ed-ak6NoX_4Aeg_-418776089")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion,

    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_ZI6DQNp-Ed-ak6NoX_4Aeg_1226491346")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate,

    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ZI6DQdp-Ed-ak6NoX_4Aeg_-1529687508")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock,

    /// <summary>
    /// Relates to issue of a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZI6DQtp-Ed-ak6NoX_4Aeg_1590088763")]
    [Description(@"Relates to issue of a depositary receipt.")]
    DepositoryReceiptIssue,

    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_ZI6DQ9p-Ed-ak6NoX_4Aeg_593016410")]
    [Description(
        @"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned)."
    )]
    MarkDown,

    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_ZI6DRNp-Ed-ak6NoX_4Aeg_2113503764")]
    [Description(
        @"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned)."
    )]
    MarkUp,

    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZI6DRdp-Ed-ak6NoX_4Aeg_1408389149")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,

    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ZI6DRtp-Ed-ak6NoX_4Aeg_-1241310712")]
    [Description(
        @"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement."
    )]
    NonSyndicated,

    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_ZI6DR9p-Ed-ak6NoX_4Aeg_297477730")]
    [Description(
        @"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver)."
    )]
    ExternalAccountTransfer,

    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_ZI6DSNp-Ed-ak6NoX_4Aeg_-877713295")]
    [Description(
        @"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver)."
    )]
    InternalAccountTransfer,

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZI6DSdp-Ed-ak6NoX_4Aeg_-811485456")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    PairOff,

    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ZI6DStp-Ed-ak6NoX_4Aeg_833781979")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,

    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_ZJDNMNp-Ed-ak6NoX_4Aeg_-1922396875")]
    [Description(
        @"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such."
    )]
    PortfolioMove,

    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_ZJDNMdp-Ed-ak6NoX_4Aeg_1197379396")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,

    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_ZJDNMtp-Ed-ak6NoX_4Aeg_492264781")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal,

    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ZJDNM9p-Ed-ak6NoX_4Aeg_2137532216")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,

    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_ZJDNNNp-Ed-ak6NoX_4Aeg_-618646638")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation,

    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZJDNNdp-Ed-ak6NoX_4Aeg_-1793837663")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,

    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_ZJDNNtp-Ed-ak6NoX_4Aeg_1796015018")]
    [Description(
        @"Relates to the return of financial instruments resulting from a rejected delivery without matching operation."
    )]
    ReturnDeliveryWithoutMatching,

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_ZJDNN9p-Ed-ak6NoX_4Aeg_-853684843")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZJDNONp-Ed-ak6NoX_4Aeg_685103599")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo,

    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_ZJDNOdp-Ed-ak6NoX_4Aeg_-490087426")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack,

    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_ZJM-MNp-Ed-ak6NoX_4Aeg_905598647")]
    [Description(
        @"Internal reallocation of a borrowed holding from one safekeeping account to another."
    )]
    BorrowingReallocation,

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZJM-Mdp-Ed-ak6NoX_4Aeg_-269592378")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZJM-Mtp-Ed-ak6NoX_4Aeg_-974706993")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,

    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_ZJM-M9p-Ed-ak6NoX_4Aeg_670560442")]
    [Description(
        @"Internal reallocation of a holding on loan from one safekeeping account to another."
    )]
    LendingReallocation,

    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZJM-NNp-Ed-ak6NoX_4Aeg_-2085618412")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,

    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ZJM-Ndp-Ed-ak6NoX_4Aeg_1034157859")]
    [Description(
        @"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager."
    )]
    SyndicateUnderwriters,

    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_ZJM-Ntp-Ed-ak6NoX_4Aeg_329043244")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing,

    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZJM-N9p-Ed-ak6NoX_4Aeg_1974310679")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,

    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_ZJM-ONp-Ed-ak6NoX_4Aeg_-781868175")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,

    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_ZJM-Odp-Ed-ak6NoX_4Aeg_-1957059200")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,

    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_ZJWvMNp-Ed-ak6NoX_4Aeg_1632793481")]
    [Description(
        @"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers."
    )]
    Turnaround,

    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_ZJWvMdp-Ed-ak6NoX_4Aeg_-1016906380")]
    [Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
    PreAdvice,

    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ZJWvMtp-Ed-ak6NoX_4Aeg_521882062")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,

    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_ZJWvM9p-Ed-ak6NoX_4Aeg_2132310183")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,

    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZJWvNNp-Ed-ak6NoX_4Aeg_1135237830")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
}
