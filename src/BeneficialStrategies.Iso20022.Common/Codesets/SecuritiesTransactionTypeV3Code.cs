// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__tS74tojEeC60axPepSq7g_738239406")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[Derivations(typeof(SettlementTransactionType7Code),typeof(SecuritiesTransactionType15Code))]
public enum SecuritiesTransactionTypeV3Code
{
    /// <summary>
    /// Relates to a buy sell back transaction.
    /// Encoded/decoded by serializers as &quot;BSBK&quot;.
    /// </summary>
    [EnumMember(Value = "BSBK")]
    [IsoId("__tS749ojEeC60axPepSq7g_624400340")]
    [Description(@"Relates to a buy sell back transaction.")]
    BuySellBack,
    
    /// <summary>
    /// Transaction relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BIYI&quot;.
    /// </summary>
    [EnumMember(Value = "BIYI")]
    [IsoId("__tS75NojEeC60axPepSq7g_-550790685")]
    [Description(@"Transaction relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn,
    
    /// <summary>
    /// Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.
    /// Encoded/decoded by serializers as &quot;CNCB&quot;.
    /// </summary>
    [EnumMember(Value = "CNCB")]
    [IsoId("__tS75dojEeC60axPepSq7g_-1547863038")]
    [Description(@"Relates to a collateral delivery/receipt to a national central bank for central bank credit operations.")]
    CentralBankCollateralOperation,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral taker or its agent.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("__tS75tojEeC60axPepSq7g_2041989643")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral taker or its agent.")]
    CollateralIn,
    
    /// <summary>
    /// Relates to a collateral transaction, from the point of view of the collateral giver or its agent.
    /// Encoded/decoded by serializers as &quot;COLO&quot;.
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("__tcs4NojEeC60axPepSq7g_-1020867095")]
    [Description(@"Relates to a collateral transaction, from the point of view of the collateral giver or its agent.")]
    CollateralOut,
    
    /// <summary>
    /// Relates to a depository receipt conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("__tcs4dojEeC60axPepSq7g_931078224")]
    [Description(@"Relates to a depository receipt conversion.")]
    DepositoryReceiptConversion,
    
    /// <summary>
    /// Relates to a factor update.
    /// Encoded/decoded by serializers as &quot;FCTA&quot;.
    /// </summary>
    [EnumMember(Value = "FCTA")]
    [IsoId("__tcs4tojEeC60axPepSq7g_-244112801")]
    [Description(@"Relates to a factor update.")]
    FactorUpdate,
    
    /// <summary>
    /// Relates to a movement of shares into or out of a pooled account.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("__tcs49ojEeC60axPepSq7g_1658273058")]
    [Description(@"Relates to a movement of shares into or out of a pooled account.")]
    MoveOfStock,
    
    /// <summary>
    /// Relates to the issuance of a security such as an equity or a depositary receipt.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("__tcs5NojEeC60axPepSq7g_-1404583680")]
    [Description(@"Relates to the issuance of a security such as an equity or a depositary receipt.")]
    Issuance,
    
    /// <summary>
    /// Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("__tcs5dojEeC60axPepSq7g_1893311263")]
    [Description(@"Relates to the decrease of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corp. event realigned).")]
    MarkDown,
    
    /// <summary>
    /// Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("__tcs5tojEeC60axPepSq7g_-449710714")]
    [Description(@"Relates to the increase of positions held by an International Central Securities Depository (ICSD) at the common depository due to custody operations (repurchase, pre-release, proceed of corporate event realigned).")]
    MarkUp,
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as &quot;NETT&quot;.
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("__tmd4NojEeC60axPepSq7g_-1624901739")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Netting,
    
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("__tmd4dojEeC60axPepSq7g_1964950942")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated,
    
    /// <summary>
    /// Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("__tmd4tojEeC60axPepSq7g_-1097905796")]
    [Description(@"Relates to an account transfer involving more than one instructing party (messages sender) and/or account servicer (messages receiver).")]
    ExternalAccountTransfer,
    
    /// <summary>
    /// Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).
    /// Encoded/decoded by serializers as &quot;OWNI&quot;.
    /// </summary>
    [EnumMember(Value = "OWNI")]
    [IsoId("__tmd49ojEeC60axPepSq7g_854039523")]
    [Description(@"Relates to an account transfer involving one instructing party (messages sender) at one account servicer (messages receiver).")]
    InternalAccountTransfer,
    
    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("__tmd5NojEeC60axPepSq7g_-321151502")]
    [Description(@"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.")]
    PairOff,
    
    /// <summary>
    /// Relates to the placement/new issue of a financial instrument.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("__tmd5dojEeC60axPepSq7g_-1026266117")]
    [Description(@"Relates to the placement/new issue of a financial instrument.")]
    Placement,
    
    /// <summary>
    /// Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.
    /// Encoded/decoded by serializers as &quot;PORT&quot;.
    /// </summary>
    [EnumMember(Value = "PORT")]
    [IsoId("__tmd5tojEeC60axPepSq7g_205844441")]
    [Description(@"Relates to a portfolio move from one investment manager to another and/or from an account servicer to another. It is generally charged differently than another account transfer, hence the need to identify this type of transfer as such.")]
    PortfolioMove,
    
    /// <summary>
    /// Relates to a realignment of positions.
    /// Encoded/decoded by serializers as &quot;REAL&quot;.
    /// </summary>
    [EnumMember(Value = "REAL")]
    [IsoId("__tvn0NojEeC60axPepSq7g_-2137177536")]
    [Description(@"Relates to a realignment of positions.")]
    Realignment,
    
    /// <summary>
    /// Relates to the withdrawal of specified amounts from specified subaccounts.
    /// Encoded/decoded by serializers as &quot;REDI&quot;.
    /// </summary>
    [EnumMember(Value = "REDI")]
    [IsoId("__tvn0dojEeC60axPepSq7g_982598735")]
    [Description(@"Relates to the withdrawal of specified amounts from specified subaccounts.")]
    Withdrawal,
    
    /// <summary>
    /// Relates to a redemption of funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("__tvn0tojEeC60axPepSq7g_277484120")]
    [Description(@"Relates to a redemption of funds (funds industry only).")]
    Redemption,
    
    /// <summary>
    /// Relates to a release (into/from local) of depository receipt operation.
    /// Encoded/decoded by serializers as &quot;RELE&quot;.
    /// </summary>
    [EnumMember(Value = "RELE")]
    [IsoId("__tvn09ojEeC60axPepSq7g_1509594678")]
    [Description(@"Relates to a release (into/from local) of depository receipt operation.")]
    DepositoryReceiptReleaseCancellation,
    
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("__tvn1NojEeC60axPepSq7g_-833427299")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo,
    
    /// <summary>
    /// Relates to the return of financial instruments resulting from a rejected delivery without matching operation.
    /// Encoded/decoded by serializers as &quot;RODE&quot;.
    /// </summary>
    [EnumMember(Value = "RODE")]
    [IsoId("__tvn1dojEeC60axPepSq7g_-2008618324")]
    [Description(@"Relates to the return of financial instruments resulting from a rejected delivery without matching operation.")]
    ReturnDeliveryWithoutMatching,
    
    /// <summary>
    /// Relates to a transaction that is for reporting purposes only.
    /// Encoded/decoded by serializers as &quot;RPTO&quot;.
    /// </summary>
    [EnumMember(Value = "RPTO")]
    [IsoId("__tvn1tojEeC60axPepSq7g_1581234357")]
    [Description(@"Relates to a transaction that is for reporting purposes only.")]
    Reporting,
    
    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("__t5Y0NojEeC60axPepSq7g_-1481622381")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// Relates to a sell buy back transaction.
    /// Encoded/decoded by serializers as &quot;SBBK&quot;.
    /// </summary>
    [EnumMember(Value = "SBBK")]
    [IsoId("__t5Y0dojEeC60axPepSq7g_470322938")]
    [Description(@"Relates to a sell buy back transaction.")]
    SellBuyBack,
    
    /// <summary>
    /// Internal reallocation of a borrowed holding from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SBRE&quot;.
    /// </summary>
    [EnumMember(Value = "SBRE")]
    [IsoId("__t5Y0tojEeC60axPepSq7g_-704868087")]
    [Description(@"Internal reallocation of a borrowed holding from one safekeeping account to another.")]
    BorrowingReallocation,
    
    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("__t5Y09ojEeC60axPepSq7g_-1409982702")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing,
    
    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("__t5Y1NojEeC60axPepSq7g_-177872144")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending,
    
    /// <summary>
    /// Internal reallocation of a holding on loan from one safekeeping account to another.
    /// Encoded/decoded by serializers as &quot;SLRE&quot;.
    /// </summary>
    [EnumMember(Value = "SLRE")]
    [IsoId("__t5Y1dojEeC60axPepSq7g_1774073175")]
    [Description(@"Internal reallocation of a holding on loan from one safekeeping account to another.")]
    LendingReallocation,
    
    /// <summary>
    /// Relates to a subscription to funds (funds industry only).
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("__t5Y1tojEeC60axPepSq7g_598882150")]
    [Description(@"Relates to a subscription to funds (funds industry only).")]
    Subscription,
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("__uDJ0NojEeC60axPepSq7g_-106232465")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters,
    
    /// <summary>
    /// Relates to a To Be Announced (TBA) closing trade.
    /// Encoded/decoded by serializers as &quot;TBAC&quot;.
    /// </summary>
    [EnumMember(Value = "TBAC")]
    [IsoId("__uDJ0dojEeC60axPepSq7g_1125878093")]
    [Description(@"Relates to a To Be Announced (TBA) closing trade.")]
    TBAClosing,
    
    /// <summary>
    /// Relates to the settlement of a trade.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("__uDJ0tojEeC60axPepSq7g_-1217143884")]
    [Description(@"Relates to the settlement of a trade.")]
    Trade,
    
    /// <summary>
    /// Relates to a triparty repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRPO&quot;.
    /// </summary>
    [EnumMember(Value = "TRPO")]
    [IsoId("__uDJ09ojEeC60axPepSq7g_1902632387")]
    [Description(@"Relates to a triparty repurchase agreement.")]
    TripartyRepo,
    
    /// <summary>
    /// Relates to a triparty reverse repurchase agreement.
    /// Encoded/decoded by serializers as &quot;TRVO&quot;.
    /// </summary>
    [EnumMember(Value = "TRVO")]
    [IsoId("__uMTwNojEeC60axPepSq7g_1197517772")]
    [Description(@"Relates to a triparty reverse repurchase agreement.")]
    TripartyReverseRepo,
    
    /// <summary>
    /// Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.
    /// Encoded/decoded by serializers as &quot;TURN&quot;.
    /// </summary>
    [EnumMember(Value = "TURN")]
    [IsoId("__uMTwdojEeC60axPepSq7g_-1865338966")]
    [Description(@"Relates to a turnaround: the same security is bought and sold to settle the same day, to or from different brokers.")]
    Turnaround,
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// Encoded/decoded by serializers as &quot;PREA&quot;.
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("__uMTwtojEeC60axPepSq7g_86606353")]
    [Description(@"Transaction is a pre-advice, that is, for matching purposes only.")]
    PreAdvice,
    
    /// <summary>
    /// Relates to an auto-collateralisation movement.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("__uMTw9ojEeC60axPepSq7g_-1088584672")]
    [Description(@"Relates to an auto-collateralisation movement.")]
    AutoCollateralisation,
    
    /// <summary>
    /// Relates to a market claim.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("__uMTxNojEeC60axPepSq7g_-2085657025")]
    [Description(@"Relates to a market claim.")]
    MarketClaim,
    
    /// <summary>
    /// Relates to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("__uMTxdojEeC60axPepSq7g_-1316746935")]
    [Description(@"Relates to a corporate action.")]
    CorporateAction,
    
    /// <summary>
    /// Transaction is a purchase of financial instrument.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__uWEwNojEeC60axPepSq7g_1407089925")]
    [Description(@"Transaction is a purchase of financial instrument.")]
    Buy,
    
    /// <summary>
    /// Transaction is a sale of financial instrument.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__uWEwdojEeC60axPepSq7g_-1655766813")]
    [Description(@"Transaction is a sale of financial instrument.")]
    Sell,
    
    /// <summary>
    /// Transaction is an Initial Public Offer (IPO) order.
    /// Encoded/decoded by serializers as &quot;IPOO&quot;.
    /// </summary>
    [EnumMember(Value = "IPOO")]
    [IsoId("__uWEwtojEeC60axPepSq7g_1993036951")]
    [Description(@"Transaction is an Initial Public Offer (IPO) order.")]
    InitialPublicOffer,
    
    /// <summary>
    /// Transaction is a reinvestment of dividends.
    /// Encoded/decoded by serializers as &quot;DIVR&quot;.
    /// </summary>
    [EnumMember(Value = "DIVR")]
    [IsoId("__uWEw9ojEeC60axPepSq7g_-1069819787")]
    [Description(@"Transaction is a reinvestment of dividends.")]
    ReinvestmentOfDividend,
    
    /// <summary>
    /// Indicates that the type of transaction is a cross from.
    /// Encoded/decoded by serializers as &quot;CROF&quot;.
    /// </summary>
    [EnumMember(Value = "CROF")]
    [IsoId("__uWExNojEeC60axPepSq7g_-714562212")]
    [Description(@"Indicates that the type of transaction is a cross from.")]
    CrossFrom,
    
    /// <summary>
    /// Indicates that the type of transaction is a cross to.
    /// Encoded/decoded by serializers as &quot;CROT&quot;.
    /// </summary>
    [EnumMember(Value = "CROT")]
    [IsoId("__uWExdojEeC60axPepSq7g_1768213943")]
    [Description(@"Indicates that the type of transaction is a cross to.")]
    CrossTo,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund.
    /// Encoded/decoded by serializers as &quot;SWIF&quot;.
    /// </summary>
    [EnumMember(Value = "SWIF")]
    [IsoId("__uWExtojEeC60axPepSq7g_-561399172")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund.")]
    SwitchFrom,
    
    /// <summary>
    /// Transaction is a change of an investment from one sub-fund to another sub-fund.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("__ufOsNojEeC60axPepSq7g_612481219")]
    [Description(@"Transaction is a change of an investment from one sub-fund to another sub-fund.")]
    SwitchTo,
    
    /// <summary>
    /// A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("__ufOsdojEeC60axPepSq7g_1147681709")]
    [Description(@"A basket trade, i.e. a unit of 15 or more financial instruments used in program trading.")]
    Basket,
    
    /// <summary>
    /// Trade which is guaranteed to be finalized.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("__ufOstojEeC60axPepSq7g_-1502018152")]
    [Description(@"Trade which is guaranteed to be finalized.")]
    GuaranteedClose,
    
    /// <summary>
    /// A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.
    /// Encoded/decoded by serializers as &quot;PROG&quot;.
    /// </summary>
    [EnumMember(Value = "PROG")]
    [IsoId("__ufOs9ojEeC60axPepSq7g_36770290")]
    [Description(@"A program trade, i.e. a computer-driven trade of buying and selling of baskets of 15 or more financial instruments by index arbitrage specialists or institutional traders.")]
    Program,
    
    /// <summary>
    /// Transaction relates to employee trade reporting.
    /// Encoded/decoded by serializers as &quot;EMTR&quot;.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("__ufOtNojEeC60axPepSq7g_-591305624")]
    [Description(@"Transaction relates to employee trade reporting.")]
    EmployeeTradeReporting,
    
    /// <summary>
    /// Trade in which an agent intermediates between a buyer and a seller.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("__ufOtdojEeC60axPepSq7g_802726540")]
    [Description(@"Trade in which an agent intermediates between a buyer and a seller.")]
    Agency,
    
    /// <summary>
    /// A trade from a broker to another broker.
    /// Encoded/decoded by serializers as &quot;BRBR&quot;.
    /// </summary>
    [EnumMember(Value = "BRBR")]
    [IsoId("__ufOttojEeC60axPepSq7g_1908446862")]
    [Description(@"A trade from a broker to another broker.")]
    BrokerToBroker,
    
    /// <summary>
    /// A pre-allocated trade.
    /// Encoded/decoded by serializers as &quot;PRAL&quot;.
    /// </summary>
    [EnumMember(Value = "PRAL")]
    [IsoId("__uo_sNojEeC60axPepSq7g_-741252999")]
    [Description(@"A pre-allocated trade.")]
    PreAllocation,
    
    /// <summary>
    /// A trade from an investment fund to another investment fund.
    /// Encoded/decoded by serializers as &quot;FDFD&quot;.
    /// </summary>
    [EnumMember(Value = "FDFD")]
    [IsoId("__uo_sdojEeC60axPepSq7g_797535443")]
    [Description(@"A trade from an investment fund to another investment fund.")]
    FundToFund,
    
    /// <summary>
    /// Transaction is an List order.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("__uo_stojEeC60axPepSq7g_169459529")]
    [Description(@"Transaction is an List order.")]
    List,
    
    /// <summary>
    /// Transaction is an Index order.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("__uo_s9ojEeC60axPepSq7g_1677330759")]
    [Description(@"Transaction is an Index order.")]
    Index,
    
    /// <summary>
    /// Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("__uo_tNojEeC60axPepSq7g_-972369102")]
    [Description(@"Trade whose price is guaranteed as the weighted average of the trade prices on a specific day.")]
    VWAPGuarantee,
    
    /// <summary>
    /// Trade involving risk.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("__uo_tdojEeC60axPepSq7g_566419340")]
    [Description(@"Trade involving risk.")]
    RiskTrade,
    
    /// <summary>
    /// Offering issue trade.
    /// Encoded/decoded by serializers as &quot;OFIT&quot;.
    /// </summary>
    [EnumMember(Value = "OFIT")]
    [IsoId("__uo_ttojEeC60axPepSq7g_1018289392")]
    [Description(@"Offering issue trade.")]
    OfferingIssuingTrade,
    
}
