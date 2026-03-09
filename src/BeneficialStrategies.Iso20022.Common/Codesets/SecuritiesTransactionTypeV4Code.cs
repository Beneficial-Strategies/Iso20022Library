// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XodBUdEZEeiO-eodGv5iKQ")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[Derivations(typeof(SecuritiesTransactionType23Code),typeof(SecuritiesTransactionType27Code),typeof(SecuritiesTransactionType28Code),typeof(SecuritiesTransactionType22Code),typeof(SecuritiesTransactionType25Code),typeof(SecuritiesTransactionType26Code),typeof(SecuritiesTransactionType24Code))]
public enum SecuritiesTransactionTypeV4Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("_XodBcNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,
    
    /// <summary>
    /// Relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_XodBZtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn,
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("_XodBU9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_XodBbNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_XodBctEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut,
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_XodBitEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion,
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("_XodBfdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate,
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_XodBhdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_XodBZ9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance,
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_XodBgdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkDown,
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_XodBe9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceeds of corporate event realigned).")]
    MarkUp,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_XodBa9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_XodBfNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes) under a program and without syndication arrangement.")]
    NonSyndicated,
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_XodBhtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to an account transfer involving more than one instructing party (message sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("_XodBVNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to an account transfer involving one instructing party (message sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_XodBWdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff,
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_XodBdNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("_XodBhNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove,
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("_XodBbdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("_XodBXNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_XodBYtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("_XodBjNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation,
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_XodBjdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("_XodBb9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without a matching operation.")]
    ReturnDeliveryWithoutMatching,
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("_XodBj9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_XodBbtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("_XodBXtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack,
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("_XodBVtEZEeiO-eodGv5iKQ")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation,
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_XodBjtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_XodBd9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("_XodBYNEZEeiO-eodGv5iKQ")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation,
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_XodBiNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_XodBWNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters,
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("_XodBetEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing,
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_XodBVdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("_XodBg9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("_XodBftEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("_XodBc9EZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround,
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_XodBUtEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
    PreAdvice,
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_XodBdtEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_XodBZdEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_XodBaNEZEeiO-eodGv5iKQ")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Transaction is a purchase of financial instrument.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_XodBX9EZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a purchase of financial instrument.")]
    Buy,
    
    /// <summary>
    /// Transaction is a sale of financial instrument.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_XodBZNEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a sale of financial instrument.")]
    Sell,
    
    /// <summary>
    /// Transaction is an Initial Public Offer (IPO) order.
    /// Encoded/decoded by serializers as &quot;IPOO&quot;.
    /// </summary>
    [EnumMember(Value = "IPOO")]
    [IsoId("_XodBXdEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is an Initial Public Offer (IPO) order.")]
    InitialPublicOffer,
    
    /// <summary>
    /// Transaction is a reinvestment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVR&quot;.
    /// </summary>
    [EnumMember(Value = "DIVR")]
    [IsoId("_XodBYdEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a reinvestment of dividends.")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// Indicates that the type of transaction is a cross from.
    /// Encoded/decoded by serializers as &quot;CROF&quot;.
    /// </summary>
    [EnumMember(Value = "CROF")]
    [IsoId("_XodBgNEZEeiO-eodGv5iKQ")]
    [Description(@"Indicates that the type of transaction is a cross from.")]
    CrossFrom,
    
    /// <summary>
    /// Indicates that the type of transaction is a cross to.
    /// Encoded/decoded by serializers as &quot;CROT&quot;.
    /// </summary>
    [EnumMember(Value = "CROT")]
    [IsoId("_XodBV9EZEeiO-eodGv5iKQ")]
    [Description(@"Indicates that the type of transaction is a cross to.")]
    CrossTo,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).
    /// Encoded/decoded by serializers as &quot;SWIF&quot;.
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("_XodBi9EZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (redemption-leg).")]
    SwitchFrom,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_XodBkNEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund (subscription-leg).")]
    SwitchTo,
    
    /// <summary>
    /// A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_XodBddEZEeiO-eodGv5iKQ")]
    [Description(@"A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.")]
    Basket,
    
    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_XodBgtEZEeiO-eodGv5iKQ")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose,
    
    /// <summary>
    /// A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.
    /// Encoded/decoded by serializers as &quot;PROG&quot;.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("_XodBh9EZEeiO-eodGv5iKQ")]
    [Description(@"A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.")]
    Program,
    
    /// <summary>
    /// Transaction relates to employee trade reporting.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_XodBWtEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction relates to employee trade reporting.")]
    EmployeeTradeReporting,
    
    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_XodBW9EZEeiO-eodGv5iKQ")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    Agency,
    
    /// <summary>
    /// A trade from a broker to another broker.
    /// Encoded/decoded by serializers as &quot;BRBR&quot;.
    /// </summary>
    [EnumMember(Value = "BRBR")]
    [IsoId("_XodBf9EZEeiO-eodGv5iKQ")]
    [Description(@"A trade from a broker to another broker.")]
    BrokerToBroker,
    
    /// <summary>
    /// A pre-allocated trade.
    /// Encoded/decoded by serializers as &quot;PRAL&quot;.
    /// </summary>
    [EnumMember(Value = "PRAL")]
    [IsoId("_XodBeNEZEeiO-eodGv5iKQ")]
    [Description(@"A pre-allocated trade.")]
    PreAllocation,
    
    /// <summary>
    /// A trade from an investment fund to another investment fund.
    /// Encoded/decoded by serializers as &quot;FDFD&quot;.
    /// </summary>
    [EnumMember(Value = "FDFD")]
    [IsoId("_XodBY9EZEeiO-eodGv5iKQ")]
    [Description(@"A trade from an investment fund to another investment fund.")]
    FundToFund,
    
    /// <summary>
    /// Transaction is an List order.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_XodBcdEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is an List order.")]
    List,
    
    /// <summary>
    /// Transaction is an Index order.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_XodBadEZEeiO-eodGv5iKQ")]
    [Description(@"Transaction is an Index order.")]
    Index,
    
    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_XodBidEZEeiO-eodGv5iKQ")]
    [Description(@"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.")]
    VWAPGuarantee,
    
    /// <summary>
    /// Trade involving risk.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_XodBedEZEeiO-eodGv5iKQ")]
    [Description(@"Trade involving risk.")]
    RiskTrade,
    
    /// <summary>
    /// Offering issue trade.
    /// Encoded/decoded by serializers as &quot;OFIT&quot;.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("_XodBatEZEeiO-eodGv5iKQ")]
    [Description(@"Offering issue trade.")]
    OfferingIssuingTrade,
    
    /// <summary>
    /// Relates to an ETF creation or redemption.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_i2Qj4dEeEeiO-eodGv5iKQ")]
    [Description(@"Relates to an ETF creation or redemption.")]
    ExchangeTradedFunds,
    
    /// <summary>
    /// Relates to a rebalanced transaction.
    /// Encoded/decoded by serializers as &quot;REBL&quot;.
    /// </summary>
    [EnumMember(Value = "REBL")]
    [IsoId("_04za8NYOEeiHVOfMzoKxnA")]
    [Description(@"Relates to a rebalanced transaction.")]
    Rebalancing,
    
    /// <summary>
    /// Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TRIN&quot;.
    /// </summary>
    [EnumMember(Value = "TRIN")]
    [IsoId("_CPyHANdrEeispNOuywCdbA")]
    [Description(@"Transaction is an incoming credit to an account on the shareholders register, and is not linked to a shift in investment (subscription or switch), but to account management.")]
    TransferIn,
    
    /// <summary>
    /// Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.
    /// Encoded/decoded by serializers as &quot;TOUT&quot;.
    /// </summary>
    [EnumMember(Value = "TOUT")]
    [IsoId("_CXSdMNdrEeispNOuywCdbA")]
    [Description(@"Transaction is a debit to an account on the shareholders register, and is not linked to a shift in investment (redemption or switch), but to account management.")]
    TransferOut,
    
    /// <summary>
    /// Relates to a cash movement resulting from a change in traded interest pursuant to a coupon rate adjustment.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_S-DzEAitEeuQ1MenzX1l-g")]
    [Description(@"Relates to a cash movement resulting from a change in traded interest pursuant to a coupon rate adjustment.")]
    TradedInterestChanged,
    
}
