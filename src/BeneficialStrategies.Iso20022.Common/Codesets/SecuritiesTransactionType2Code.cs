// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZG-JkNp-Ed-ak6NoX_4Aeg_519121104")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeCode))]
public enum SecuritiesTransactionType2Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_ZG-Jkdp-Ed-ak6NoX_4Aeg_519121413")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeCode.BuySellBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_ZG-Jktp-Ed-ak6NoX_4Aeg_519121414")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation = SecuritiesTransactionTypeCode.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZG-Jk9p-Ed-ak6NoX_4Aeg_519121444")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn = SecuritiesTransactionTypeCode.CollateralIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZG-JlNp-Ed-ak6NoX_4Aeg_519121445")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut = SecuritiesTransactionTypeCode.CollateralOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ZG-Jldp-Ed-ak6NoX_4Aeg_519121474")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeCode.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_ZG-Jltp-Ed-ak6NoX_4Aeg_519121475")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeCode.FactorUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ZG-Jl9p-Ed-ak6NoX_4Aeg_519121505")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeCode.MoveOfStock, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to issue of a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZG-JmNp-Ed-ak6NoX_4Aeg_519121506")]
    [Description(@"Relates to issue of a depositary receipt.")]
    DepositoryReceiptIssue = SecuritiesTransactionTypeCode.DepositoryReceiptIssue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_ZG-Jmdp-Ed-ak6NoX_4Aeg_519121507")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).")]
    MarkDown = SecuritiesTransactionTypeCode.MarkDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_ZHHTgNp-Ed-ak6NoX_4Aeg_519121535")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).")]
    MarkUp = SecuritiesTransactionTypeCode.MarkUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZHHTgdp-Ed-ak6NoX_4Aeg_519121536")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeCode.Netting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ZHHTgtp-Ed-ak6NoX_4Aeg_519121566")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated = SecuritiesTransactionTypeCode.NonSyndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_ZHHTg9p-Ed-ak6NoX_4Aeg_519121567")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer = SecuritiesTransactionTypeCode.ExternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_ZHHThNp-Ed-ak6NoX_4Aeg_519121568")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer = SecuritiesTransactionTypeCode.InternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZHHThdp-Ed-ak6NoX_4Aeg_519121597")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff = SecuritiesTransactionTypeCode.PairOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ZHHThtp-Ed-ak6NoX_4Aeg_519121598")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeCode.Placement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_ZHHTh9p-Ed-ak6NoX_4Aeg_519121620")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove = SecuritiesTransactionTypeCode.PortfolioMove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_ZHHTiNp-Ed-ak6NoX_4Aeg_519121628")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeCode.Realignment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_ZHHTidp-Ed-ak6NoX_4Aeg_519121629")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ZHHTitp-Ed-ak6NoX_4Aeg_519121651")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_ZHREgNp-Ed-ak6NoX_4Aeg_519121659")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation = SecuritiesTransactionTypeCode.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZHREgdp-Ed-ak6NoX_4Aeg_519121899")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeCode.Repo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_ZHREgtp-Ed-ak6NoX_4Aeg_519121907")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeCode.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_ZHREg9p-Ed-ak6NoX_4Aeg_519121929")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SecuritiesTransactionTypeCode.Reporting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZHREhNp-Ed-ak6NoX_4Aeg_519121930")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeCode.ReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_ZHREhdp-Ed-ak6NoX_4Aeg_519121938")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeCode.SellBuyBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_ZHREhtp-Ed-ak6NoX_4Aeg_519121960")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation = SecuritiesTransactionTypeCode.BorrowingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZHREh9p-Ed-ak6NoX_4Aeg_519121961")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeCode.SecuritiesBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZHa1gNp-Ed-ak6NoX_4Aeg_519121990")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeCode.SecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_ZHa1gdp-Ed-ak6NoX_4Aeg_519121991")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation = SecuritiesTransactionTypeCode.LendingReallocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZHa1gtp-Ed-ak6NoX_4Aeg_519121992")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeCode.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ZHa1g9p-Ed-ak6NoX_4Aeg_519122021")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters = SecuritiesTransactionTypeCode.SyndicateUnderwriters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_ZHa1hNp-Ed-ak6NoX_4Aeg_519122022")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeCode.TBAClosing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZHa1hdp-Ed-ak6NoX_4Aeg_519122023")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeCode.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_ZHa1htp-Ed-ak6NoX_4Aeg_519122052")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeCode.TripartyRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_ZHa1h9p-Ed-ak6NoX_4Aeg_519122053")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeCode.TripartyReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_ZHa1iNp-Ed-ak6NoX_4Aeg_519122330")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround = SecuritiesTransactionTypeCode.Turnaround, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_ZHa1idp-Ed-ak6NoX_4Aeg_-1616895538")]
    [Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
    PreAdvice = SecuritiesTransactionTypeCode.PreAdvice, // same ordinal as derivation source for type conversions
    
}
