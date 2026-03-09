// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0Oaigf8qEeCQ-IWv9MUPeQ")]
[Description(@"Specifies underlying information regarding the type of transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
public enum SecuritiesTransactionType10Code
{
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_0Ojsdf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation = SecuritiesTransactionTypeV2Code.CentralBankCollateralOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_0Ojsef8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack = SecuritiesTransactionTypeV2Code.BuySellBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_0Ojsff8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn = SecuritiesTransactionTypeV2Code.CollateralIn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_0Ojsgf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut = SecuritiesTransactionTypeV2Code.CollateralOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_0Ojshf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting = SecuritiesTransactionTypeV2Code.Netting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_0Ojsif8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer = SecuritiesTransactionTypeV2Code.ExternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_0Ojsjf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer = SecuritiesTransactionTypeV2Code.InternalAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_0Ojskf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff = SecuritiesTransactionTypeV2Code.PairOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_0Ojslf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement = SecuritiesTransactionTypeV2Code.Placement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_0Ojsmf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove = SecuritiesTransactionTypeV2Code.PortfolioMove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_0Ojsnf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment = SecuritiesTransactionTypeV2Code.Realignment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_0Ojsof8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption = SecuritiesTransactionTypeV2Code.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_0Ojspf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_0Ojsqf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_0Ojsrf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_0Ojssf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_0Ojstf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription = SecuritiesTransactionTypeV2Code.Subscription, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_0Ojsuf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade = SecuritiesTransactionTypeV2Code.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_0Ojsvf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo = SecuritiesTransactionTypeV2Code.TripartyRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_0Ojswf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo = SecuritiesTransactionTypeV2Code.TripartyReverseRepo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_0Ojsxf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround = SecuritiesTransactionTypeV2Code.Turnaround, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_0Ojsyf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation = SecuritiesTransactionTypeV2Code.AutoCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_0Ojszf8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a market claim.")]
    MarketClaim = SecuritiesTransactionTypeV2Code.MarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_0Ojs0f8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction = SecuritiesTransactionTypeV2Code.CorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_1QIeNv8qEeCQ-IWv9MUPeQ")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds = SecuritiesTransactionTypeV2Code.ExchangeTradedFunds, // same ordinal as derivation source for type conversions
    
}
