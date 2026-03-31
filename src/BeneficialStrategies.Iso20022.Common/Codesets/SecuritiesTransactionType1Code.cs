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
[IsoId("_ZGXsoNp-Ed-ak6NoX_4Aeg_2037048643")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesTransactionType1Code>))]
#endif
public enum SecuritiesTransactionType1Code
{
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_ZGXsodp-Ed-ak6NoX_4Aeg_-612651218")]
    [Description(
        @"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations."
    )]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV2Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_ZGXsotp-Ed-ak6NoX_4Aeg_1039976290")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV2Code.BuySellBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZGXso9p-Ed-ak6NoX_4Aeg_748018552")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral taker or its agent."
    )]
    CollateralIn = SecuritiesTransactionTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZGXspNp-Ed-ak6NoX_4Aeg_926137224")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral giver or its agent."
    )]
    CollateralOut = SecuritiesTransactionTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ZGXspdp-Ed-ak6NoX_4Aeg_-1609723571")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV2Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_ZGXsptp-Ed-ak6NoX_4Aeg_42903937")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV2Code.FactorUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ZGXsp9p-Ed-ak6NoX_4Aeg_-249053801")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV2Code.MoveOfStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZGXsqNp-Ed-ak6NoX_4Aeg_-70935129")]
    [Description(
        @"Relates to the issuance of a security such as an equity or a depositary receipt."
    )]
    Issuance = SecuritiesTransactionTypeV2Code.Issuance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_ZGXsqdp-Ed-ak6NoX_4Aeg_1688171372")]
    [Description(
        @"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned)."
    )]
    MarkDown = SecuritiesTransactionTypeV2Code.MarkDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_ZGXsqtp-Ed-ak6NoX_4Aeg_-954168416")]
    [Description(
        @"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned)."
    )]
    MarkUp = SecuritiesTransactionTypeV2Code.MarkUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZGhdoNp-Ed-ak6NoX_4Aeg_-1246126154")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV2Code.Netting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ZGhdodp-Ed-ak6NoX_4Aeg_-1068007482")]
    [Description(
        @"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement."
    )]
    NonSyndicated = SecuritiesTransactionTypeV2Code.NonSyndicated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_ZGhdotp-Ed-ak6NoX_4Aeg_691099019")]
    [Description(
        @"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver)."
    )]
    ExternalAccountTransfer = SecuritiesTransactionTypeV2Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_ZGhdo9p-Ed-ak6NoX_4Aeg_-185258326")]
    [Description(
        @"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver)."
    )]
    InternalAccountTransfer = SecuritiesTransactionTypeV2Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZGhdpNp-Ed-ak6NoX_4Aeg_-477216064")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    PairOff = SecuritiesTransactionTypeV2Code.PairOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ZGhdpdp-Ed-ak6NoX_4Aeg_-299097392")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV2Code.Placement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_ZGhdptp-Ed-ak6NoX_4Aeg_1460009109")]
    [Description(
        @"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such."
    )]
    PortfolioMove = SecuritiesTransactionTypeV2Code.PortfolioMove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_ZGhdp9p-Ed-ak6NoX_4Aeg_-1182330679")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV2Code.Realignment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_ZGhdqNp-Ed-ak6NoX_4Aeg_-1474288417")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV2Code.Withdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ZGhdqdp-Ed-ak6NoX_4Aeg_-1296169745")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV2Code.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_ZGqnkNp-Ed-ak6NoX_4Aeg_462936756")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation =
        SecuritiesTransactionTypeV2Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZGqnkdp-Ed-ak6NoX_4Aeg_2115564264")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_ZGqnktp-Ed-ak6NoX_4Aeg_1823606526")]
    [Description(
        @"Relates to the return of financial instruments resulting from a rejected delivery without matching operation."
    )]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV2Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_ZGqnk9p-Ed-ak6NoX_4Aeg_2001725198")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SecuritiesTransactionTypeV2Code.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZGqnlNp-Ed-ak6NoX_4Aeg_-534135597")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_ZGqnldp-Ed-ak6NoX_4Aeg_1118491911")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV2Code.SellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_ZGqnltp-Ed-ak6NoX_4Aeg_826534173")]
    [Description(
        @"Internal reallocation of a borrowed holding from one safekeeping account to another."
    )]
    BorrowingReallocation = SecuritiesTransactionTypeV2Code.BorrowingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZGqnl9p-Ed-ak6NoX_4Aeg_1004652845")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZGqnmNp-Ed-ak6NoX_4Aeg_-1531207950")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_ZGqnmdp-Ed-ak6NoX_4Aeg_121419558")]
    [Description(
        @"Internal reallocation of a holding on loan from one safekeeping account to another."
    )]
    LendingReallocation = SecuritiesTransactionTypeV2Code.LendingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZG0YkNp-Ed-ak6NoX_4Aeg_-170538180")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV2Code.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ZG0Ykdp-Ed-ak6NoX_4Aeg_7580492")]
    [Description(
        @"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager."
    )]
    SyndicateUnderwriters = SecuritiesTransactionTypeV2Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_ZG0Yktp-Ed-ak6NoX_4Aeg_1766686993")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV2Code.TBAClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZG0Yk9p-Ed-ak6NoX_4Aeg_-875652795")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV2Code.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_ZG0YlNp-Ed-ak6NoX_4Aeg_-1167610533")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV2Code.TripartyRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_ZG0Yldp-Ed-ak6NoX_4Aeg_-989491861")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV2Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_ZG0Yltp-Ed-ak6NoX_4Aeg_769614640")]
    [Description(
        @"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers."
    )]
    Turnaround = SecuritiesTransactionTypeV2Code.Turnaround, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZG0Yl9p-Ed-ak6NoX_4Aeg_864813990")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_ZG0YmNp-Ed-ak6NoX_4Aeg_-424216101")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV2Code.MarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ZG0Ymdp-Ed-ak6NoX_4Aeg_-1166131081")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV2Code.AutoCollateralisation, // same ordinal as derivation source for type conversions
}
