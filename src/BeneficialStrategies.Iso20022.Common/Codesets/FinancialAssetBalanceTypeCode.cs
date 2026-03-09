// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies balances of assets and other balances.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m34UtfNBEeCuA5Tr22BnwA_1170507866")]
[Description(@"Specifies balances of assets and other balances.")]
[Derivations(typeof(FinancialAssetBalanceType1Code))]
public enum FinancialAssetBalanceTypeCode
{
    /// <summary>
    /// Balance attributed to other financial instruments.
    /// Encoded/decoded by serializers as &quot;OINT&quot;.
    /// </summary>
    [EnumMember(Value = "OINT")]
    [IsoId("_m4CFsPNBEeCuA5Tr22BnwA_1499281326")]
    [Description(@"Balance attributed to other financial instruments.")]
    OtherFinancialInstruments,
    
    /// <summary>
    /// Balance attributed to settled cash.
    /// Encoded/decoded by serializers as &quot;SCAS&quot;.
    /// </summary>
    [EnumMember(Value = "SCAS")]
    [IsoId("_m4CFsfNBEeCuA5Tr22BnwA_1531605963")]
    [Description(@"Balance attributed to settled cash.")]
    SettledCash,
    
    /// <summary>
    /// Balance attributed to accrued income.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_m4CFsvNBEeCuA5Tr22BnwA_1553768540")]
    [Description(@"Balance attributed to accrued income.")]
    AccruedIncome,
    
    /// <summary>
    /// Balance attributed to foreign exchange profit or loss.
    /// Encoded/decoded by serializers as &quot;FXTR&quot;.
    /// </summary>
    [EnumMember(Value = "FXTR")]
    [IsoId("_m4CFs_NBEeCuA5Tr22BnwA_-650529017")]
    [Description(@"Balance attributed to foreign exchange profit or loss.")]
    FXTransaction,
    
    /// <summary>
    /// Balance attributed to cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_m4CFtPNBEeCuA5Tr22BnwA_66457166")]
    [Description(@"Balance attributed to cash.")]
    Cash,
    
    /// <summary>
    /// Balance attributed to treasury inflated protected securities.
    /// Encoded/decoded by serializers as &quot;TIPS&quot;.
    /// </summary>
    [EnumMember(Value = "TIPS")]
    [IsoId("_m4CFtfNBEeCuA5Tr22BnwA_-916710363")]
    [Description(@"Balance attributed to treasury inflated protected securities.")]
    TreasuryInflatedProtectedSecurity,
    
    /// <summary>
    /// Balance attributed to equities.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_m4LPoPNBEeCuA5Tr22BnwA_324189526")]
    [Description(@"Balance attributed to equities.")]
    Equity,
    
    /// <summary>
    /// Balance attributed to common stock.
    /// Encoded/decoded by serializers as &quot;CSTK&quot;.
    /// </summary>
    [EnumMember(Value = "CSTK")]
    [IsoId("_m4LPofNBEeCuA5Tr22BnwA_577846223")]
    [Description(@"Balance attributed to common stock.")]
    CommonStock,
    
    /// <summary>
    /// Balance attributed to preferred stock.
    /// Encoded/decoded by serializers as &quot;PREF&quot;.
    /// </summary>
    [EnumMember(Value = "PREF")]
    [IsoId("_m4LPovNBEeCuA5Tr22BnwA_52283690")]
    [Description(@"Balance attributed to preferred stock.")]
    PreferredStock,
    
    /// <summary>
    /// Balance attributed to mutual funds.
    /// Encoded/decoded by serializers as &quot;MFUN&quot;.
    /// </summary>
    [EnumMember(Value = "MFUN")]
    [IsoId("_m4LPo_NBEeCuA5Tr22BnwA_-983188090")]
    [Description(@"Balance attributed to mutual funds.")]
    MutualFund,
    
    /// <summary>
    /// Balance attributed to exchange traded funds.
    /// Encoded/decoded by serializers as &quot;XFUN&quot;.
    /// </summary>
    [EnumMember(Value = "XFUN")]
    [IsoId("_m4LPpPNBEeCuA5Tr22BnwA_-2109056942")]
    [Description(@"Balance attributed to exchange traded funds.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Balance attributed to rights.
    /// Encoded/decoded by serializers as &quot;RGHT&quot;.
    /// </summary>
    [EnumMember(Value = "RGHT")]
    [IsoId("_m4LPpfNBEeCuA5Tr22BnwA_1999294159")]
    [Description(@"Balance attributed to rights.")]
    Rights,
    
    /// <summary>
    /// Balance attributed to warrants.
    /// Encoded/decoded by serializers as &quot;WARR&quot;.
    /// </summary>
    [EnumMember(Value = "WARR")]
    [IsoId("_m4LPpvNBEeCuA5Tr22BnwA_80361990")]
    [Description(@"Balance attributed to warrants.")]
    Warrant,
    
    /// <summary>
    /// Balance attributed to bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_m4VAoPNBEeCuA5Tr22BnwA_1711724601")]
    [Description(@"Balance attributed to bonds.")]
    Bond,
    
    /// <summary>
    /// Balance attributed to convertible bonds.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_m4VAofNBEeCuA5Tr22BnwA_1321261879")]
    [Description(@"Balance attributed to convertible bonds.")]
    ConvertibleBond,
    
    /// <summary>
    /// Balance attributed to corporate bonds.
    /// Encoded/decoded by serializers as &quot;CBND&quot;.
    /// </summary>
    [EnumMember(Value = "CBND")]
    [IsoId("_m4VAovNBEeCuA5Tr22BnwA_1499380551")]
    [Description(@"Balance attributed to corporate bonds.")]
    CorporateBond,
    
    /// <summary>
    /// Balance attributed to government bonds.
    /// Encoded/decoded by serializers as &quot;GBND&quot;.
    /// </summary>
    [EnumMember(Value = "GBND")]
    [IsoId("_m4VAo_NBEeCuA5Tr22BnwA_-1393276496")]
    [Description(@"Balance attributed to government bonds.")]
    GovernmentBond,
    
    /// <summary>
    /// Balance attributed to futures.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_m4VApPNBEeCuA5Tr22BnwA_-1480854084")]
    [Description(@"Balance attributed to futures.")]
    Future,
    
    /// <summary>
    /// Balance attributed to options.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_m4VApfNBEeCuA5Tr22BnwA_315327278")]
    [Description(@"Balance attributed to options.")]
    Option,
    
    /// <summary>
    /// Balance attributed to swaps.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_m4VApvNBEeCuA5Tr22BnwA_258480662")]
    [Description(@"Balance attributed to swaps.")]
    Swap,
    
    /// <summary>
    /// Balance attributed to currency exchange contracts.
    /// Encoded/decoded by serializers as &quot;CUEX&quot;.
    /// </summary>
    [EnumMember(Value = "CUEX")]
    [IsoId("_m4exoPNBEeCuA5Tr22BnwA_-1328437982")]
    [Description(@"Balance attributed to currency exchange contracts.")]
    CurrencyExchange,
    
    /// <summary>
    /// Balance attributed to foreign investments.
    /// Encoded/decoded by serializers as &quot;FOIV&quot;.
    /// </summary>
    [EnumMember(Value = "FOIV")]
    [IsoId("_m4exofNBEeCuA5Tr22BnwA_-1302735412")]
    [Description(@"Balance attributed to foreign investments.")]
    ForeignInvestment,
    
    /// <summary>
    /// Balance attributed to gold.
    /// Encoded/decoded by serializers as &quot;GOLD&quot;.
    /// </summary>
    [EnumMember(Value = "GOLD")]
    [IsoId("_m4exovNBEeCuA5Tr22BnwA_-1819631751")]
    [Description(@"Balance attributed to gold.")]
    Gold,
    
    /// <summary>
    /// Balance attributed to property.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_m4exo_NBEeCuA5Tr22BnwA_650726384")]
    [Description(@"Balance attributed to property.")]
    Property,
    
    /// <summary>
    /// Balance attributed to bankers acceptances.
    /// Encoded/decoded by serializers as &quot;BAAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAAP")]
    [IsoId("_m4expPNBEeCuA5Tr22BnwA_-441513399")]
    [Description(@"Balance attributed to bankers acceptances.")]
    BankersAcceptance,
    
    /// <summary>
    /// Balance attributed to syndicated bank loans.
    /// Encoded/decoded by serializers as &quot;SYBL&quot;.
    /// </summary>
    [EnumMember(Value = "SYBL")]
    [IsoId("_m4n7kPNBEeCuA5Tr22BnwA_1429247769")]
    [Description(@"Balance attributed to syndicated bank loans.")]
    SyndicatedBankLoan,
    
    /// <summary>
    /// Balance attributed to collateralised bond obligations.
    /// Encoded/decoded by serializers as &quot;CBOO&quot;.
    /// </summary>
    [EnumMember(Value = "CBOO")]
    [IsoId("_m4n7kfNBEeCuA5Tr22BnwA_-1387724878")]
    [Description(@"Balance attributed to collateralised bond obligations.")]
    CollateralisedBondObligation,
    
    /// <summary>
    /// Balance attributed to certificates of deposits.
    /// Encoded/decoded by serializers as &quot;CEOD&quot;.
    /// </summary>
    [EnumMember(Value = "CEOD")]
    [IsoId("_m4n7kvNBEeCuA5Tr22BnwA_588812844")]
    [Description(@"Balance attributed to certificates of deposits.")]
    CertificateOfDeposit,
    
    /// <summary>
    /// Balance attributed to collateralised debt obligations.
    /// Encoded/decoded by serializers as &quot;CDEO&quot;.
    /// </summary>
    [EnumMember(Value = "CDEO")]
    [IsoId("_m4n7k_NBEeCuA5Tr22BnwA_-1128898245")]
    [Description(@"Balance attributed to collateralised debt obligations.")]
    CollateralisedDebtObligation,
    
    /// <summary>
    /// Balance attributed to collateralised loan obligations.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_m4n7lPNBEeCuA5Tr22BnwA_696281544")]
    [Description(@"Balance attributed to collateralised loan obligations.")]
    CollateralisedLoanObligation,
    
    /// <summary>
    /// Balance attributed to collateralised mortgage obligations.
    /// Encoded/decoded by serializers as &quot;CMOO&quot;.
    /// </summary>
    [EnumMember(Value = "CMOO")]
    [IsoId("_m4n7lfNBEeCuA5Tr22BnwA_936367265")]
    [Description(@"Balance attributed to collateralised mortgage obligations.")]
    CollateralisedMortgageObligation,
    
    /// <summary>
    /// Balance attributed to commercial paper.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_m4xskPNBEeCuA5Tr22BnwA_22441313")]
    [Description(@"Balance attributed to commercial paper.")]
    CommericalPaper,
    
    /// <summary>
    /// Balance attributed to corporate private placements.
    /// Encoded/decoded by serializers as &quot;CPPE&quot;.
    /// </summary>
    [EnumMember(Value = "CPPE")]
    [IsoId("_m4xskfNBEeCuA5Tr22BnwA_315448309")]
    [Description(@"Balance attributed to corporate private placements.")]
    CorporatePrivatePlacement,
    
    /// <summary>
    /// Balance attributed to discount notes.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_m4xskvNBEeCuA5Tr22BnwA_-687489337")]
    [Description(@"Balance attributed to discount notes.")]
    DiscountNote,
    
    /// <summary>
    /// Balance attributed to federal agency discount notes.
    /// Encoded/decoded by serializers as &quot;FEAD&quot;.
    /// </summary>
    [EnumMember(Value = "FEAD")]
    [IsoId("_m4xsk_NBEeCuA5Tr22BnwA_1199877358")]
    [Description(@"Balance attributed to federal agency discount notes.")]
    FederalAgencyDiscountNote,
    
    /// <summary>
    /// Balance attributed to federal housing authorities.
    /// Encoded/decoded by serializers as &quot;FEHA&quot;.
    /// </summary>
    [EnumMember(Value = "FEHA")]
    [IsoId("_m4xslPNBEeCuA5Tr22BnwA_545398206")]
    [Description(@"Balance attributed to federal housing authorities.")]
    FederalHousingAuthority,
    
    /// <summary>
    /// Balance attributed to federal home loans.
    /// Encoded/decoded by serializers as &quot;FEHL&quot;.
    /// </summary>
    [EnumMember(Value = "FEHL")]
    [IsoId("_m4xslfNBEeCuA5Tr22BnwA_-1310041479")]
    [Description(@"Balance attributed to federal home loans.")]
    FederalHomeLoan,
    
    /// <summary>
    /// Balance attributed to federal national mortgage associations.
    /// Encoded/decoded by serializers as &quot;FNMA&quot;.
    /// </summary>
    [EnumMember(Value = "FNMA")]
    [IsoId("_m462gPNBEeCuA5Tr22BnwA_-586583737")]
    [Description(@"Balance attributed to federal national mortgage associations.")]
    FederalNationalMortgageAssociation,
    
    /// <summary>
    /// Balance attributed to floating rate notes.
    /// Encoded/decoded by serializers as &quot;FLNO&quot;.
    /// </summary>
    [EnumMember(Value = "FLNO")]
    [IsoId("_m462gfNBEeCuA5Tr22BnwA_-2013220186")]
    [Description(@"Balance attributed to floating rate notes.")]
    FloatingRateNote,
    
    /// <summary>
    /// Balance attributed to the government national mortgage association.
    /// Encoded/decoded by serializers as &quot;GNMA&quot;.
    /// </summary>
    [EnumMember(Value = "GNMA")]
    [IsoId("_m462gvNBEeCuA5Tr22BnwA_-87458484")]
    [Description(@"Balance attributed to the government national mortgage association.")]
    GovernmentNationalMortgageAssociation,
    
    /// <summary>
    /// Balance attributed to treasuries and agencies debentures.
    /// Encoded/decoded by serializers as &quot;TAAB&quot;.
    /// </summary>
    [EnumMember(Value = "TAAB")]
    [IsoId("_m462g_NBEeCuA5Tr22BnwA_1693882052")]
    [Description(@"Balance attributed to treasuries and agencies debentures.")]
    TreasuriesAndAgenciesDebentures,
    
    /// <summary>
    /// Balance attributed to IOETTE mortgages.
    /// Encoded/decoded by serializers as &quot;IETM&quot;.
    /// </summary>
    [EnumMember(Value = "IETM")]
    [IsoId("_m462hPNBEeCuA5Tr22BnwA_-1110416674")]
    [Description(@"Balance attributed to IOETTE mortgages.")]
    IOETTEMortgage,
    
    /// <summary>
    /// Balance attributed to mortgage private placements.
    /// Encoded/decoded by serializers as &quot;MPRP&quot;.
    /// </summary>
    [EnumMember(Value = "MPRP")]
    [IsoId("_m462hfNBEeCuA5Tr22BnwA_-320360860")]
    [Description(@"Balance attributed to mortgage private placements.")]
    MortgagePrivatePlacement,
    
    /// <summary>
    /// Balance attributed to municipal bonds.
    /// Encoded/decoded by serializers as &quot;MBON&quot;.
    /// </summary>
    [EnumMember(Value = "MBON")]
    [IsoId("_m462hvNBEeCuA5Tr22BnwA_723289388")]
    [Description(@"Balance attributed to municipal bonds.")]
    MunicipalBond,
    
    /// <summary>
    /// Balance attributed to student loan marketing associations.
    /// Encoded/decoded by serializers as &quot;SLMA&quot;.
    /// </summary>
    [EnumMember(Value = "SLMA")]
    [IsoId("_m5EngPNBEeCuA5Tr22BnwA_1401877872")]
    [Description(@"Balance attributed to student loan marketing associations.")]
    StudentLoanMarketingAssociation,
    
    /// <summary>
    /// Balance attributed to short term investment funds.
    /// Encoded/decoded by serializers as &quot;STIF&quot;.
    /// </summary>
    [EnumMember(Value = "STIF")]
    [IsoId("_m5EngfNBEeCuA5Tr22BnwA_340780055")]
    [Description(@"Balance attributed to short term investment funds.")]
    ShortTermInvestmentFund,
    
    /// <summary>
    /// Balance attributed to treasury strips.
    /// Encoded/decoded by serializers as &quot;TSTP&quot;.
    /// </summary>
    [EnumMember(Value = "TSTP")]
    [IsoId("_m5EngvNBEeCuA5Tr22BnwA_1310821862")]
    [Description(@"Balance attributed to treasury strips.")]
    TreasuryStrips,
    
    /// <summary>
    /// Balance attributed to time deposits.
    /// Encoded/decoded by serializers as &quot;TIDE&quot;.
    /// </summary>
    [EnumMember(Value = "TIDE")]
    [IsoId("_m5Eng_NBEeCuA5Tr22BnwA_2117762639")]
    [Description(@"Balance attributed to time deposits.")]
    TimeDeposit,
    
    /// <summary>
    /// Balance attributed to unitized bonds and warrants.
    /// Encoded/decoded by serializers as &quot;UNBW&quot;.
    /// </summary>
    [EnumMember(Value = "UNBW")]
    [IsoId("_m5EnhPNBEeCuA5Tr22BnwA_-1458320575")]
    [Description(@"Balance attributed to unitized bonds and warrants.")]
    UnitizedBondsAndWarrants,
    
    /// <summary>
    /// Balance attributed to unitized bonds.
    /// Encoded/decoded by serializers as &quot;UNBO&quot;.
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_m5EnhfNBEeCuA5Tr22BnwA_-799980806")]
    [Description(@"Balance attributed to unitized bonds.")]
    UnitizedBonds,
    
    /// <summary>
    /// Balance attributed to variable rate discount notes.
    /// Encoded/decoded by serializers as &quot;VRDN&quot;.
    /// </summary>
    [EnumMember(Value = "VRDN")]
    [IsoId("_m5OYgPNBEeCuA5Tr22BnwA_1279144469")]
    [Description(@"Balance attributed to variable rate discount notes.")]
    VariableRateDiscountNote,
    
    /// <summary>
    /// Balance attributed to cats, lions and tigers.
    /// Encoded/decoded by serializers as &quot;ZOOO&quot;.
    /// </summary>
    [EnumMember(Value = "ZOOO")]
    [IsoId("_m5OYgfNBEeCuA5Tr22BnwA_-1796097192")]
    [Description(@"Balance attributed to cats, lions and tigers.")]
    CatsTigersLions,
    
    /// <summary>
    /// Balance attributed to forwards - bonds.
    /// Encoded/decoded by serializers as &quot;FWBO&quot;.
    /// </summary>
    [EnumMember(Value = "FWBO")]
    [IsoId("_m5OYgvNBEeCuA5Tr22BnwA_-2043451381")]
    [Description(@"Balance attributed to forwards - bonds.")]
    ForwardBonds,
    
    /// <summary>
    /// Balance attributed to forward rate agreements.
    /// Encoded/decoded by serializers as &quot;FRAG&quot;.
    /// </summary>
    [EnumMember(Value = "FRAG")]
    [IsoId("_m5OYg_NBEeCuA5Tr22BnwA_152977320")]
    [Description(@"Balance attributed to forward rate agreements.")]
    ForwardRateAgreement,
    
    /// <summary>
    /// Balance attributed to repurchase agreements.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_m5OYhPNBEeCuA5Tr22BnwA_496215225")]
    [Description(@"Balance attributed to repurchase agreements.")]
    RepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to reverse repurchase agreements.
    /// Encoded/decoded by serializers as &quot;XREP&quot;.
    /// </summary>
    [EnumMember(Value = "XREP")]
    [IsoId("_m5OYhfNBEeCuA5Tr22BnwA_139874332")]
    [Description(@"Balance attributed to reverse repurchase agreements.")]
    ReverseRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to triparty repurchase agreements.
    /// Encoded/decoded by serializers as &quot;TREP&quot;.
    /// </summary>
    [EnumMember(Value = "TREP")]
    [IsoId("_m5OYhvNBEeCuA5Tr22BnwA_-1835908884")]
    [Description(@"Balance attributed to triparty repurchase agreements.")]
    TripartyRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to triparty reverse repurchase agreements.
    /// Encoded/decoded by serializers as &quot;RXRP&quot;.
    /// </summary>
    [EnumMember(Value = "RXRP")]
    [IsoId("_m5XicPNBEeCuA5Tr22BnwA_1121258651")]
    [Description(@"Balance attributed to triparty reverse repurchase agreements.")]
    TripartyReverseRepurchaseAgreement,
    
    /// <summary>
    /// Balance attributed to foreign exchange forwards.
    /// Encoded/decoded by serializers as &quot;FXFD&quot;.
    /// </summary>
    [EnumMember(Value = "FXFD")]
    [IsoId("_m5XicfNBEeCuA5Tr22BnwA_472812638")]
    [Description(@"Balance attributed to foreign exchange forwards.")]
    FXForward,
    
    /// <summary>
    /// Balance attributed to foreign exchange spots.
    /// Encoded/decoded by serializers as &quot;FXSP&quot;.
    /// </summary>
    [EnumMember(Value = "FXSP")]
    [IsoId("_m5XicvNBEeCuA5Tr22BnwA_845627309")]
    [Description(@"Balance attributed to foreign exchange spots.")]
    FXSpot,
    
    /// <summary>
    /// Balance attributed to foreign exchange profit.
    /// Encoded/decoded by serializers as &quot;FXPR&quot;.
    /// </summary>
    [EnumMember(Value = "FXPR")]
    [IsoId("_m5Xic_NBEeCuA5Tr22BnwA_1929755497")]
    [Description(@"Balance attributed to foreign exchange profit.")]
    FXProfit,
    
    /// <summary>
    /// Balance attributed to foreign exchange loss.
    /// Encoded/decoded by serializers as &quot;FXLO&quot;.
    /// </summary>
    [EnumMember(Value = "FXLO")]
    [IsoId("_m5XidPNBEeCuA5Tr22BnwA_140854004")]
    [Description(@"Balance attributed to foreign exchange loss.")]
    FXLoss,
    
}
