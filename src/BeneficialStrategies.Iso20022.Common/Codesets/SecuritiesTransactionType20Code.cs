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
[IsoId("_W2SfiqUqEee4_75LDmHZiQ")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesTransactionType20Code>))]
#endif
public enum SecuritiesTransactionType20Code
{
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_W2SfoqUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations."
    )]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV2Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_W2SfjKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV2Code.BuySellBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_W2SfsaUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral taker or its agent."
    )]
    CollateralIn = SecuritiesTransactionTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_W2SfmqUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a collateral transaction, from the point of view of the collateral giver or its agent."
    )]
    CollateralOut = SecuritiesTransactionTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_W2SfnKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion = SecuritiesTransactionTypeV2Code.DepositoryReceiptConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_W2SflKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate = SecuritiesTransactionTypeV2Code.FactorUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_W2Sfj6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock = SecuritiesTransactionTypeV2Code.MoveOfStock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_W2SfoaUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the issuance of a security such as an equity or a depositary receipt."
    )]
    Issuance = SecuritiesTransactionTypeV2Code.Issuance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_W2Sfp6UqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned)."
    )]
    MarkDown = SecuritiesTransactionTypeV2Code.MarkDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_W2SfmaUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned)."
    )]
    MarkUp = SecuritiesTransactionTypeV2Code.MarkUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_W2Sfs6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV2Code.Netting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_W2SfjqUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement."
    )]
    NonSyndicated = SecuritiesTransactionTypeV2Code.NonSyndicated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_W2SfsqUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver)."
    )]
    ExternalAccountTransfer = SecuritiesTransactionTypeV2Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_W2Sfn6UqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver)."
    )]
    InternalAccountTransfer = SecuritiesTransactionTypeV2Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_W2SfrqUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    PairOff = SecuritiesTransactionTypeV2Code.PairOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_W2SfqaUqEee4_75LDmHZiQ")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV2Code.Placement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_W2SfpKUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such."
    )]
    PortfolioMove = SecuritiesTransactionTypeV2Code.PortfolioMove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_W2SfqKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV2Code.Realignment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_W2Sfk6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal = SecuritiesTransactionTypeV2Code.Withdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_W2SfrKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV2Code.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_W2SfpqUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation =
        SecuritiesTransactionTypeV2Code.DepositoryReceiptReleaseCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_W2SfqqUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_W2Sfl6UqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the return of financial instruments resulting from a rejected delivery without matching operation."
    )]
    ReturnDeliveryWithoutMatching = SecuritiesTransactionTypeV2Code.ReturnDeliveryWithoutMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_W2SfsKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_W2Sfi6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack = SecuritiesTransactionTypeV2Code.SellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_W2SflqUqEee4_75LDmHZiQ")]
    [Description(
        @"Internal reallocation of a borrowed holding from one safekeeping account to another."
    )]
    BorrowingReallocation = SecuritiesTransactionTypeV2Code.BorrowingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_W2SfraUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_W2Sfm6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_W2Sfq6UqEee4_75LDmHZiQ")]
    [Description(
        @"Internal reallocation of a holding on loan from one safekeeping account to another."
    )]
    LendingReallocation = SecuritiesTransactionTypeV2Code.LendingReallocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_W2Sfr6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV2Code.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_W2SfkKUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager."
    )]
    SyndicateUnderwriters = SecuritiesTransactionTypeV2Code.SyndicateUnderwriters, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_W2SfkqUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing = SecuritiesTransactionTypeV2Code.TBAClosing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_W2SfmKUqEee4_75LDmHZiQ")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV2Code.Trade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_W2SfpaUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV2Code.TripartyRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_W2SfnqUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV2Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_W2SfoKUqEee4_75LDmHZiQ")]
    [Description(
        @"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers."
    )]
    Turnaround = SecuritiesTransactionTypeV2Code.Turnaround, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_W2SfnaUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV2Code.CorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_W2SflaUqEee4_75LDmHZiQ")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV2Code.MarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_W2SfjaUqEee4_75LDmHZiQ")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV2Code.AutoCollateralisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_W2Sfo6UqEee4_75LDmHZiQ")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds = SecuritiesTransactionTypeV2Code.ExchangeTradedFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BIYI&quot;.
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("_W2SfkaUqEee4_75LDmHZiQ")]
    [Description(
        @"Transaction relates to a buy-in by the market following a delivery transaction failure."
    )]
    BuyIn = SecuritiesTransactionTypeV2Code.BuyIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).
    /// Encoded/decoded by serializers as &quot;SWIF&quot;.
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("_UzBxsaUrEee4_75LDmHZiQ")]
    [Description(
        @"Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg)."
    )]
    SwitchFrom = SecuritiesTransactionTypeV2Code.SwitchFrom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_U9Sg8aUrEee4_75LDmHZiQ")]
    [Description(
        @"Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg)."
    )]
    SwitchTo = SecuritiesTransactionTypeV2Code.SwitchTo, // same ordinal as derivation source for type conversions
}
