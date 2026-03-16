// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external authority identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a82cgH9tEeijdNUhA5U4XA")]
[Description(
    @"Specifies the external authority identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalAuthorityIdentification1Code))]
public enum ExternalAuthorityIdentificationCode
{
    /// <summary>
    /// Australian Securities and Investments Commission (ASIC)
    /// Encoded/decoded by serializers as &quot;AUAS&quot;.
    /// </summary>
    [EnumMember(Value = "AUAS")]
    [IsoId("_um-jc_RYEeuLhpyIdtJzwg")]
    [Description(@"Australian Securities and Investments Commission (ASIC)")]
    AustralianSecuritiesAndInvestmentsCommissionASIC,

    /// <summary>
    /// Austrian Financial Market Authority (FMA)
    /// Encoded/decoded by serializers as &quot;ATFM&quot;.
    /// </summary>
    [EnumMember(Value = "ATFM")]
    [IsoId("_unIUcPRYEeuLhpyIdtJzwg")]
    [Description(@"Austrian Financial Market Authority (FMA)")]
    AustrianFinancialMarketAuthorityFMA,

    /// <summary>
    /// Financial Services and Markets Authority (FSMA)
    /// Encoded/decoded by serializers as &quot;BEFS&quot;.
    /// </summary>
    [EnumMember(Value = "BEFS")]
    [IsoId("_unIUc_RYEeuLhpyIdtJzwg")]
    [Description(@"Financial Services and Markets Authority (FSMA)")]
    FinancialServicesAndMarketsAuthorityFSMA,

    /// <summary>
    /// National Bank of Belgium
    /// Encoded/decoded by serializers as &quot;BENB&quot;.
    /// </summary>
    [EnumMember(Value = "BENB")]
    [IsoId("_unIUdvRYEeuLhpyIdtJzwg")]
    [Description(@"National Bank of Belgium")]
    NationalBankOfBelgium,

    /// <summary>
    /// Financial Supervision Commission (FSC)
    /// Encoded/decoded by serializers as &quot;BGFS&quot;.
    /// </summary>
    [EnumMember(Value = "BGFS")]
    [IsoId("_unReYPRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Supervision Commission (FSC)")]
    FinancialSupervisionCommissionFSC,

    /// <summary>
    /// Canadian Securities Transition Office (CSTO)
    /// Encoded/decoded by serializers as &quot;CACS&quot;.
    /// </summary>
    [EnumMember(Value = "CACS")]
    [IsoId("_unReY_RYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Securities Transition Office (CSTO)")]
    CanadianSecuritiesTransitionOfficeCSTO,

    /// <summary>
    /// Authority for the Supervision and Development of Cooperative Societies
    /// Encoded/decoded by serializers as &quot;CYAS&quot;.
    /// </summary>
    [EnumMember(Value = "CYAS")]
    [IsoId("_unbPYPRYEeuLhpyIdtJzwg")]
    [Description(@"Authority for the Supervision and Development of Cooperative Societies")]
    AuthorityForTheSupervisionAndDevelopmentOfCooperativeSocieties,

    /// <summary>
    /// Central Bank of Cyprus (CBC)
    /// Encoded/decoded by serializers as &quot;CYCB&quot;.
    /// </summary>
    [EnumMember(Value = "CYCB")]
    [IsoId("_unbPY_RYEeuLhpyIdtJzwg")]
    [Description(@"Central Bank of Cyprus (CBC)")]
    CentralBankOfCyprusCBC,

    /// <summary>
    /// Cyprus Securities and Exchange Commission (CySEC)
    /// Encoded/decoded by serializers as &quot;CYCY&quot;.
    /// </summary>
    [EnumMember(Value = "CYCY")]
    [IsoId("_unbPZvRYEeuLhpyIdtJzwg")]
    [Description(@"Cyprus Securities and Exchange Commission (CySEC)")]
    CyprusSecuritiesAndExchangeCommissionCySEC,

    /// <summary>
    /// Czech National Bank (CNB)
    /// Encoded/decoded by serializers as &quot;CZCN&quot;.
    /// </summary>
    [EnumMember(Value = "CZCN")]
    [IsoId("_unlAYPRYEeuLhpyIdtJzwg")]
    [Description(@"Czech National Bank (CNB)")]
    CzechNationalBankCNB,

    /// <summary>
    /// Federal Financial Supervisory Authority (BaFin)
    /// Encoded/decoded by serializers as &quot;DEBA&quot;.
    /// </summary>
    [EnumMember(Value = "DEBA")]
    [IsoId("_unlAY_RYEeuLhpyIdtJzwg")]
    [Description(@"Federal Financial Supervisory Authority (BaFin)")]
    FederalFinancialSupervisoryAuthorityBaFin,

    /// <summary>
    /// Finanstilsynet
    /// Encoded/decoded by serializers as &quot;DKFI&quot;.
    /// </summary>
    [EnumMember(Value = "DKFI")]
    [IsoId("_unlAZvRYEeuLhpyIdtJzwg")]
    [Description(@"Finanstilsynet ")]
    Finanstilsynet,

    /// <summary>
    /// Estonian Financial Supervision Authority (EFSA)
    /// Encoded/decoded by serializers as &quot;EEEF&quot;.
    /// </summary>
    [EnumMember(Value = "EEEF")]
    [IsoId("_unlAafRYEeuLhpyIdtJzwg")]
    [Description(@"Estonian Financial Supervision Authority (EFSA)")]
    EstonianFinancialSupervisionAuthorityEFSA,

    /// <summary>
    /// European Securities and Markets Authority (ESMA)
    /// Encoded/decoded by serializers as &quot;EUES&quot;.
    /// </summary>
    [EnumMember(Value = "EUES")]
    [IsoId("_unuKUPRYEeuLhpyIdtJzwg")]
    [Description(@"European Securities and Markets Authority (ESMA)")]
    EuropeanSecuritiesAndMarketsAuthorityESMA,

    /// <summary>
    /// Bank of Spain (BDE)
    /// Encoded/decoded by serializers as &quot;ESBD&quot;.
    /// </summary>
    [EnumMember(Value = "ESBD")]
    [IsoId("_unuKU_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Spain (BDE)")]
    BankOfSpainBDE,

    /// <summary>
    /// Comisión Nacional del Mercado de Valores (CNMV)
    /// Encoded/decoded by serializers as &quot;ESCN&quot;.
    /// </summary>
    [EnumMember(Value = "ESCN")]
    [IsoId("_unuKVvRYEeuLhpyIdtJzwg")]
    [Description(@"Comisión Nacional del Mercado de Valores (CNMV)")]
    ComisiónNacionalDelMercadoDeValoresCNMV,

    /// <summary>
    /// Finanssivalvonta (FSA)
    /// Encoded/decoded by serializers as &quot;FIFS&quot;.
    /// </summary>
    [EnumMember(Value = "FIFS")]
    [IsoId("_un37UPRYEeuLhpyIdtJzwg")]
    [Description(@"Finanssivalvonta (FSA)")]
    FinanssivalvontaFSA,

    /// <summary>
    /// Autorité de Contrôle Prudentiel et de Résolution (ACPR)
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_un37U_RYEeuLhpyIdtJzwg")]
    [Description(@"Autorité de Contrôle Prudentiel et de Résolution (ACPR)")]
    AutoritéDeContrôlePrudentielEtDeRésolutionACPR,

    /// <summary>
    /// Autorité des Marchés Financiers (AMF)
    /// Encoded/decoded by serializers as &quot;FRAM&quot;.
    /// </summary>
    [EnumMember(Value = "FRAM")]
    [IsoId("_un37VvRYEeuLhpyIdtJzwg")]
    [Description(@"Autorité des Marchés Financiers (AMF)")]
    AutoritéDesMarchésFinanciersAMF,

    /// <summary>
    /// Financial Services Authority (FSA)
    /// Encoded/decoded by serializers as &quot;GBFS&quot;.
    /// </summary>
    [EnumMember(Value = "GBFS")]
    [IsoId("_uoBsUPRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Services Authority (FSA)")]
    FinancialServicesAuthorityFSA,

    /// <summary>
    /// Financial Conduct Authority (FCA)
    /// Encoded/decoded by serializers as &quot;GBFC&quot;.
    /// </summary>
    [EnumMember(Value = "GBFC")]
    [IsoId("_uoBsU_RYEeuLhpyIdtJzwg")]
    [Description(@"Financial Conduct Authority (FCA)")]
    FinancialConductAuthorityFCA,

    /// <summary>
    /// Prudential Regulation Authority (PRA)
    /// Encoded/decoded by serializers as &quot;GBPR&quot;.
    /// </summary>
    [EnumMember(Value = "GBPR")]
    [IsoId("_uoBsVvRYEeuLhpyIdtJzwg")]
    [Description(@"Prudential Regulation Authority (PRA)")]
    PrudentialRegulationAuthorityPRA,

    /// <summary>
    /// Gibraltar FSC (FSC)
    /// Encoded/decoded by serializers as &quot;GIFS&quot;.
    /// </summary>
    [EnumMember(Value = "GIFS")]
    [IsoId("_uoK2QPRYEeuLhpyIdtJzwg")]
    [Description(@"Gibraltar FSC (FSC)")]
    GibraltarFSC,

    /// <summary>
    /// US Commodity Futures Trading Commission (CFTC)
    /// Encoded/decoded by serializers as &quot;USCF&quot;.
    /// </summary>
    [EnumMember(Value = "USCF")]
    [IsoId("_uoK2Q_RYEeuLhpyIdtJzwg")]
    [Description(@"US Commodity Futures Trading Commission (CFTC)")]
    USCommodityFuturesTradingCommissionCFTC,

    /// <summary>
    /// Bank of Greece (BOG)
    /// Encoded/decoded by serializers as &quot;GRBO&quot;.
    /// </summary>
    [EnumMember(Value = "GRBO")]
    [IsoId("_uoUnQPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Greece (BOG)")]
    BankOfGreeceBOG,

    /// <summary>
    /// Hellenic Capital Market Commission (HCMC)
    /// Encoded/decoded by serializers as &quot;GRHC&quot;.
    /// </summary>
    [EnumMember(Value = "GRHC")]
    [IsoId("_uoUnQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Hellenic Capital Market Commission (HCMC)")]
    HellenicCapitalMarketCommissionHCMC,

    /// <summary>
    /// Croatian Financial Services Supervisory Agency (HANFA)
    /// Encoded/decoded by serializers as &quot;HRHA&quot;.
    /// </summary>
    [EnumMember(Value = "HRHA")]
    [IsoId("_uoUnRvRYEeuLhpyIdtJzwg")]
    [Description(@"Croatian Financial Services Supervisory Agency (HANFA)")]
    CroatianFinancialServicesSupervisoryAgencyHANFA,

    /// <summary>
    /// Hungarian Financial Supervisory Authority (PSZAF)
    /// Encoded/decoded by serializers as &quot;HUPS&quot;.
    /// </summary>
    [EnumMember(Value = "HUPS")]
    [IsoId("_uoUnSfRYEeuLhpyIdtJzwg")]
    [Description(@"Hungarian Financial Supervisory Authority (PSZAF)")]
    HungarianFinancialSupervisoryAuthorityPSZAF,

    /// <summary>
    /// Central Bank of Ireland (CBI)
    /// Encoded/decoded by serializers as &quot;IECB&quot;.
    /// </summary>
    [EnumMember(Value = "IECB")]
    [IsoId("_uodxMPRYEeuLhpyIdtJzwg")]
    [Description(@"Central Bank of Ireland (CBI)")]
    CentralBankOfIrelandCBI,

    /// <summary>
    /// Iceland Financial Supervisory Authority (FME)
    /// Encoded/decoded by serializers as &quot;ISFM&quot;.
    /// </summary>
    [EnumMember(Value = "ISFM")]
    [IsoId("_uodxM_RYEeuLhpyIdtJzwg")]
    [Description(@"Iceland Financial Supervisory Authority (FME)")]
    IcelandFinancialSupervisoryAuthorityFME,

    /// <summary>
    /// BANCA D&apos;ITALIA (BDI)
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_uodxNvRYEeuLhpyIdtJzwg")]
    [Description(@"BANCA D'ITALIA (BDI)")]
    BANCAAndDITALIA,

    /// <summary>
    /// Commissione Nazionale per le Societa e la Borsa (CONSOB)
    /// Encoded/decoded by serializers as &quot;ITCO&quot;.
    /// </summary>
    [EnumMember(Value = "ITCO")]
    [IsoId("_uodxOfRYEeuLhpyIdtJzwg")]
    [Description(@"Commissione Nazionale per le Societa e la Borsa (CONSOB)")]
    CommissioneNazionalePerLeSocietaELaBorsaCONSOB,

    /// <summary>
    /// Financial Market Authority (FMA)
    /// Encoded/decoded by serializers as &quot;LIFM&quot;.
    /// </summary>
    [EnumMember(Value = "LIFM")]
    [IsoId("_uoniMPRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Market Authority (FMA)")]
    FinancialMarketAuthorityFMA,

    /// <summary>
    /// Bank of Lithuania (LSC)
    /// Encoded/decoded by serializers as &quot;LTLS&quot;.
    /// </summary>
    [EnumMember(Value = "LTLS")]
    [IsoId("_uoniM_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Lithuania (LSC)")]
    BankOfLithuaniaLSC,

    /// <summary>
    /// Commission de Surveillance du Secteur Financier (CSSF)
    /// Encoded/decoded by serializers as &quot;LUCS&quot;.
    /// </summary>
    [EnumMember(Value = "LUCS")]
    [IsoId("_uoniNvRYEeuLhpyIdtJzwg")]
    [Description(@"Commission de Surveillance du Secteur Financier (CSSF)")]
    CommissionDeSurveillanceDuSecteurFinancierCSSF,

    /// <summary>
    /// Financial &amp; Capital Market Commission (FKTK)
    /// Encoded/decoded by serializers as &quot;LVFK&quot;.
    /// </summary>
    [EnumMember(Value = "LVFK")]
    [IsoId("_uoniOfRYEeuLhpyIdtJzwg")]
    [Description(@"Financial & Capital Market Commission (FKTK)")]
    FinancialAndCapitalMarketCommissionFKTK,

    /// <summary>
    /// Malta Financial Services Authority (MFSA)
    /// Encoded/decoded by serializers as &quot;MTMF&quot;.
    /// </summary>
    [EnumMember(Value = "MTMF")]
    [IsoId("_uoniPPRYEeuLhpyIdtJzwg")]
    [Description(@"Malta Financial Services Authority (MFSA)")]
    MaltaFinancialServicesAuthorityMFSA,

    /// <summary>
    /// Netherlands Authority for the Financial Markets (AFM)
    /// Encoded/decoded by serializers as &quot;NLAF&quot;.
    /// </summary>
    [EnumMember(Value = "NLAF")]
    [IsoId("_uoxTMPRYEeuLhpyIdtJzwg")]
    [Description(@"Netherlands Authority for the Financial Markets (AFM)")]
    NetherlandsAuthorityForTheFinancialMarketsAFM,

    /// <summary>
    /// Nederlandse Bank (DNB)
    /// Encoded/decoded by serializers as &quot;NLDN&quot;.
    /// </summary>
    [EnumMember(Value = "NLDN")]
    [IsoId("_uoxTM_RYEeuLhpyIdtJzwg")]
    [Description(@"Nederlandse Bank (DNB)")]
    NederlandseBankDNB,

    /// <summary>
    /// Norwegian Financial Supervisory Authority (Finanstilsynet)
    /// Encoded/decoded by serializers as &quot;NOFI&quot;.
    /// </summary>
    [EnumMember(Value = "NOFI")]
    [IsoId("_uo6dIPRYEeuLhpyIdtJzwg")]
    [Description(@"Norwegian Financial Supervisory Authority (Finanstilsynet)")]
    NorwegianFinancialSupervisoryAuthorityFinanstilsynet,

    /// <summary>
    /// Polish Financial Supervisory Commission (KNF)
    /// Encoded/decoded by serializers as &quot;PLKN&quot;.
    /// </summary>
    [EnumMember(Value = "PLKN")]
    [IsoId("_uo6dI_RYEeuLhpyIdtJzwg")]
    [Description(@"Polish Financial Supervisory Commission (KNF)")]
    PolishFinancialSupervisoryCommissionKNF,

    /// <summary>
    /// Banco de Portugal (BP)
    /// Encoded/decoded by serializers as &quot;PTBP&quot;.
    /// </summary>
    [EnumMember(Value = "PTBP")]
    [IsoId("_uo6dJvRYEeuLhpyIdtJzwg")]
    [Description(@"Banco de Portugal (BP)")]
    BancoDePortugalBP,

    /// <summary>
    /// Comissão do Mercado de Valores Mobiliários (CMVM)
    /// Encoded/decoded by serializers as &quot;PTCM&quot;.
    /// </summary>
    [EnumMember(Value = "PTCM")]
    [IsoId("_uo6dKfRYEeuLhpyIdtJzwg")]
    [Description(@"Comissão do Mercado de Valores Mobiliários (CMVM)")]
    ComissãoDoMercadoDeValoresMobiliáriosCMVM,

    /// <summary>
    /// Romanian Financial Supervisory Authority (ASF)
    /// Encoded/decoded by serializers as &quot;ROAS&quot;.
    /// </summary>
    [EnumMember(Value = "ROAS")]
    [IsoId("_upEOIPRYEeuLhpyIdtJzwg")]
    [Description(@"Romanian Financial Supervisory Authority (ASF)")]
    RomanianFinancialSupervisoryAuthorityASF,

    /// <summary>
    /// Finansinspektionen (FI)
    /// Encoded/decoded by serializers as &quot;SEFI&quot;.
    /// </summary>
    [EnumMember(Value = "SEFI")]
    [IsoId("_upEOI_RYEeuLhpyIdtJzwg")]
    [Description(@"Finansinspektionen (FI)")]
    FinansinspektionenFI,

    /// <summary>
    /// Securities Market Agency (ATVP)
    /// Encoded/decoded by serializers as &quot;SIAT&quot;.
    /// </summary>
    [EnumMember(Value = "SIAT")]
    [IsoId("_upNYEPRYEeuLhpyIdtJzwg")]
    [Description(@"Securities Market Agency (ATVP)")]
    SecuritiesMarketAgencyATVP,

    /// <summary>
    /// National Bank of Slovakia (NBS)
    /// Encoded/decoded by serializers as &quot;SKNB&quot;.
    /// </summary>
    [EnumMember(Value = "SKNB")]
    [IsoId("_upNYE_RYEeuLhpyIdtJzwg")]
    [Description(@"National Bank of Slovakia (NBS)")]
    NationalBankOfSlovakiaNBS,
}
