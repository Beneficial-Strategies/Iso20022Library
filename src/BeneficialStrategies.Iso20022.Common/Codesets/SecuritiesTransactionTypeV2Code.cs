// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Transaction is a pre-advice, that is, for matching purposes only.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZJWvNdp-Ed-ak6NoX_4Aeg_-696908624")]
[Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
[Derivations(typeof(SecuritiesTransactionType19Code),typeof(SecuritiesTransactionType4Code),typeof(SecuritiesTransactionType7Code),typeof(SecuritiesTransactionType20Code),typeof(SecuritiesTransactionType8Code),typeof(SecuritiesTransactionType16Code),typeof(SecuritiesTransactionType10Code),typeof(SecuritiesTransactionType3Code),typeof(SecuritiesTransactionType18Code),typeof(SecuritiesTransactionType9Code),typeof(SecuritiesTransactionType17Code),typeof(SecuritiesTransactionType21Code),typeof(SecuritiesTransactionType1Code),typeof(SecuritiesTransactionType5Code),typeof(SecuritiesFinancingTransactionType1Code),typeof(SecuritiesTransactionType6Code),typeof(SecuritiesFinancingTransactionType2Code))]
public enum SecuritiesTransactionTypeV2Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_ZJWvNtp-Ed-ak6NoX_4Aeg_-1601893788")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,
    
    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BIYI&quot;.
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("_ZJWvN9p-Ed-ak6NoX_4Aeg_-1055297921")]
    [Description(@"Transaction relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn,
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_ZJWvONp-Ed-ak6NoX_4Aeg_1517882483")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZJWvOdp-Ed-ak6NoX_4Aeg_-1131817378")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZJf5INp-Ed-ak6NoX_4Aeg_406971064")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut,
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ZJf5Idp-Ed-ak6NoX_4Aeg_-298143551")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion,
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_ZJf5Itp-Ed-ak6NoX_4Aeg_387059821")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate,
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ZJf5I9p-Ed-ak6NoX_4Aeg_-788131204")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZJf5JNp-Ed-ak6NoX_4Aeg_857136231")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance,
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_ZJf5Jdp-Ed-ak6NoX_4Aeg_-1822003922")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).")]
    MarkDown,
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_ZJf5Jtp-Ed-ak6NoX_4Aeg_155943718")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).")]
    MarkUp,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZJf5J9p-Ed-ak6NoX_4Aeg_-1019247307")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ZJf5KNp-Ed-ak6NoX_4Aeg_626020128")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated,
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_ZJf5Kdp-Ed-ak6NoX_4Aeg_-2130158726")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_ZJpqINp-Ed-ak6NoX_4Aeg_1459693955")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZJpqIdp-Ed-ak6NoX_4Aeg_284502930")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff,
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ZJpqItp-Ed-ak6NoX_4Aeg_1929770365")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_ZJpqI9p-Ed-ak6NoX_4Aeg_-826408489")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove,
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_ZJpqJNp-Ed-ak6NoX_4Aeg_-1531523104")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_ZJpqJdp-Ed-ak6NoX_4Aeg_1588253167")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ZJpqJtp-Ed-ak6NoX_4Aeg_-1061446694")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_ZJpqJ9p-Ed-ak6NoX_4Aeg_477341748")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation,
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZJpqKNp-Ed-ak6NoX_4Aeg_-227772867")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_ZJpqKdp-Ed-ak6NoX_4Aeg_-1402963892")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnDeliveryWithoutMatching,
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_ZJpqKtp-Ed-ak6NoX_4Aeg_242303543")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZJzbINp-Ed-ak6NoX_4Aeg_1781091985")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo,
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_ZJzbIdp-Ed-ak6NoX_4Aeg_1075977370")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack,
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_ZJzbItp-Ed-ak6NoX_4Aeg_-99213655")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation,
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZJzbI9p-Ed-ak6NoX_4Aeg_1546053780")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZJzbJNp-Ed-ak6NoX_4Aeg_-1210125074")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_ZJzbJdp-Ed-ak6NoX_4Aeg_-1915239689")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation,
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZJzbJtp-Ed-ak6NoX_4Aeg_1204536582")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ZJzbJ9p-Ed-ak6NoX_4Aeg_-1445163279")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters,
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_ZJ8lENp-Ed-ak6NoX_4Aeg_93625163")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing,
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZJ8lEdp-Ed-ak6NoX_4Aeg_-611489452")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_ZJ8lEtp-Ed-ak6NoX_4Aeg_-1786680477")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_ZJ8lE9p-Ed-ak6NoX_4Aeg_-141413042")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_ZJ8lFNp-Ed-ak6NoX_4Aeg_1397375400")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround,
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_ZJ8lFdp-Ed-ak6NoX_4Aeg_692260785")]
    [Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
    PreAdvice,
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ZJ8lFtp-Ed-ak6NoX_4Aeg_1339198645")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_ZJ8lF9p-Ed-ak6NoX_4Aeg_-949954197")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZJ8lGNp-Ed-ak6NoX_4Aeg_1715274286")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_3yuE4_v3EeCep9mKYQOLkA")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).
    /// Encoded/decoded by serializers as &quot;SWIF&quot;.
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("_BQSJoaUREeeO7MWB4EajhQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).")]
    SwitchFrom,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_FTJiIaUREeeO7MWB4EajhQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).")]
    SwitchTo,
    
}
