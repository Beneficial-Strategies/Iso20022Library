// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZIAraNp-Ed-ak6NoX_4Aeg_-1055483250")]
[Description(@"Specifies underlying information regarding the type of transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesTransactionType4Code>))]
#endif
public enum SecuritiesTransactionType4Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_ZIKcYNp-Ed-ak6NoX_4Aeg_17864140")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV2Code.BuySellBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BIYI&quot;.
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("_ZIKcYdp-Ed-ak6NoX_4Aeg_342981647")]
    [Description(
        @"Transaction relates to a buy-in by the market following a delivery transaction failure."
    )]
    BuyIn = SecuritiesTransactionTypeV2Code.BuyIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_ZIKcYtp-Ed-ak6NoX_4Aeg_1242883313")]
    [Description(
        @"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations."
    )]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV2Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZIKcY9p-Ed-ak6NoX_4Aeg_1129044247")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral taker or its agent."
    )]
    CollateralIn = SecuritiesTransactionTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZIKcZNp-Ed-ak6NoX_4Aeg_1383015942")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral giver or its agent."
    )]
    CollateralOut = SecuritiesTransactionTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_ZIKcZdp-Ed-ak6NoX_4Aeg_628266068")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV2Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_ZIKcZtp-Ed-ak6NoX_4Aeg_1082353337")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV2Code.FactorUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ZIKcZ9p-Ed-ak6NoX_4Aeg_1071254560")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV2Code.MoveOfStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_ZIKcaNp-Ed-ak6NoX_4Aeg_-620925637")]
    [Description(
        @"Relates to the issuance of a security such as an equity or a depositary receipt."
    )]
    Issuance = SecuritiesTransactionTypeV2Code.Issuance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_ZIKcadp-Ed-ak6NoX_4Aeg_-938702298")]
    [Description(
        @"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned)."
    )]
    MarkDown = SecuritiesTransactionTypeV2Code.MarkDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_ZITmUNp-Ed-ak6NoX_4Aeg_419108658")]
    [Description(
        @"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned)."
    )]
    MarkUp = SecuritiesTransactionTypeV2Code.MarkUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZITmUdp-Ed-ak6NoX_4Aeg_1763973794")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV2Code.Netting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ZITmUtp-Ed-ak6NoX_4Aeg_-645555555")]
    [Description(
        @"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement."
    )]
    NonSyndicated = SecuritiesTransactionTypeV2Code.NonSyndicated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_ZITmU9p-Ed-ak6NoX_4Aeg_821593208")]
    [Description(
        @"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver)."
    )]
    ExternalAccountTransfer = SecuritiesTransactionTypeV2Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_ZITmVNp-Ed-ak6NoX_4Aeg_-1445763580")]
    [Description(
        @"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver)."
    )]
    InternalAccountTransfer = SecuritiesTransactionTypeV2Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZITmVdp-Ed-ak6NoX_4Aeg_-31526958")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    PairOff = SecuritiesTransactionTypeV2Code.PairOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_ZITmVtp-Ed-ak6NoX_4Aeg_-220744407")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV2Code.Placement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_ZITmV9p-Ed-ak6NoX_4Aeg_-334583473")]
    [Description(
        @"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such."
    )]
    PortfolioMove = SecuritiesTransactionTypeV2Code.PortfolioMove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_ZITmWNp-Ed-ak6NoX_4Aeg_1008507337")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV2Code.Realignment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_ZITmWdp-Ed-ak6NoX_4Aeg_-74596499")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV2Code.Withdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ZITmWtp-Ed-ak6NoX_4Aeg_379490770")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV2Code.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_ZIdXUNp-Ed-ak6NoX_4Aeg_-2084553357")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation =
        SecuritiesTransactionTypeV2Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZIdXUdp-Ed-ak6NoX_4Aeg_-617404594")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_ZIdXUtp-Ed-ak6NoX_4Aeg_1809583298")]
    [Description(
        @"Relates to the return of financial instruments resulting from a rejected delivery without matching operation."
    )]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV2Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_ZIdXU9p-Ed-ak6NoX_4Aeg_-83434601")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting = SecuritiesTransactionTypeV2Code.Reporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZIdXVNp-Ed-ak6NoX_4Aeg_-197273667")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_ZIdXVdp-Ed-ak6NoX_4Aeg_1508920693")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV2Code.SellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_ZIdXVtp-Ed-ak6NoX_4Aeg_1497821916")]
    [Description(
        @"Internal reallocation of a borrowed holding from one safekeeping account to another."
    )]
    BorrowingReallocation = SecuritiesTransactionTypeV2Code.BorrowingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZIdXV9p-Ed-ak6NoX_4Aeg_-501036165")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZIdXWNp-Ed-ak6NoX_4Aeg_-512134942")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_ZIdXWdp-Ed-ak6NoX_4Aeg_-236166345")]
    [Description(
        @"Internal reallocation of a holding on loan from one safekeeping account to another."
    )]
    LendingReallocation = SecuritiesTransactionTypeV2Code.LendingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_ZInIUNp-Ed-ak6NoX_4Aeg_-350005411")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV2Code.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ZInIUdp-Ed-ak6NoX_4Aeg_1299763283")]
    [Description(
        @"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager."
    )]
    SyndicateUnderwriters = SecuritiesTransactionTypeV2Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_ZInIUtp-Ed-ak6NoX_4Aeg_-544105706")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV2Code.TBAClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZInIU9p-Ed-ak6NoX_4Aeg_-90018437")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV2Code.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_ZInIVNp-Ed-ak6NoX_4Aeg_1740904732")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV2Code.TripartyRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_ZInIVdp-Ed-ak6NoX_4Aeg_-1086913801")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV2Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_ZInIVtp-Ed-ak6NoX_4Aeg_2066022239")]
    [Description(
        @"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers."
    )]
    Turnaround = SecuritiesTransactionTypeV2Code.Turnaround, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_ZInIV9p-Ed-ak6NoX_4Aeg_-964209460")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV2Code.MarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZInIWNp-Ed-ak6NoX_4Aeg_681057975")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ZInIWdp-Ed-ak6NoX_4Aeg_-2075120879")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV2Code.AutoCollateralisation, // same ordinal as derivation source for type conversions
}
