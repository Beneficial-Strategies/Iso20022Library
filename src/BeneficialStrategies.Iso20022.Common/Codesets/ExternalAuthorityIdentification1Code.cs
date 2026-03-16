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
[IsoId("_90vq8DbzEeeYhaZ6bvG1Xg")]
[Description(
    @"Specifies the external authority identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAuthorityIdentificationCode))]
public enum ExternalAuthorityIdentification1Code
{
    /// <summary>
    /// Australian Securities and Investments Commission (ASIC)
    /// Encoded/decoded by serializers as &quot;AUAS&quot;.
    /// </summary>
    [EnumMember(Value = "AUAS")]
    [IsoId("_um-jdfRYEeuLhpyIdtJzwg")]
    [Description(@"Australian Securities and Investments Commission (ASIC)")]
    AustralianSecuritiesAndInvestmentsCommissionASIC =
        ExternalAuthorityIdentificationCode.AustralianSecuritiesAndInvestmentsCommissionASIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Austrian Financial Market Authority (FMA)
    /// Encoded/decoded by serializers as &quot;ATFM&quot;.
    /// </summary>
    [EnumMember(Value = "ATFM")]
    [IsoId("_unIUcvRYEeuLhpyIdtJzwg")]
    [Description(@"Austrian Financial Market Authority (FMA)")]
    AustrianFinancialMarketAuthorityFMA =
        ExternalAuthorityIdentificationCode.AustrianFinancialMarketAuthorityFMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Services and Markets Authority (FSMA)
    /// Encoded/decoded by serializers as &quot;BEFS&quot;.
    /// </summary>
    [EnumMember(Value = "BEFS")]
    [IsoId("_unIUdfRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Services and Markets Authority (FSMA)")]
    FinancialServicesAndMarketsAuthorityFSMA =
        ExternalAuthorityIdentificationCode.FinancialServicesAndMarketsAuthorityFSMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National Bank of Belgium
    /// Encoded/decoded by serializers as &quot;BENB&quot;.
    /// </summary>
    [EnumMember(Value = "BENB")]
    [IsoId("_unIUePRYEeuLhpyIdtJzwg")]
    [Description(@"National Bank of Belgium")]
    NationalBankOfBelgium = ExternalAuthorityIdentificationCode.NationalBankOfBelgium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Supervision Commission (FSC)
    /// Encoded/decoded by serializers as &quot;BGFS&quot;.
    /// </summary>
    [EnumMember(Value = "BGFS")]
    [IsoId("_unReYvRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Supervision Commission (FSC)")]
    FinancialSupervisionCommissionFSC =
        ExternalAuthorityIdentificationCode.FinancialSupervisionCommissionFSC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Securities Transition Office (CSTO)
    /// Encoded/decoded by serializers as &quot;CACS&quot;.
    /// </summary>
    [EnumMember(Value = "CACS")]
    [IsoId("_unReZfRYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Securities Transition Office (CSTO)")]
    CanadianSecuritiesTransitionOfficeCSTO =
        ExternalAuthorityIdentificationCode.CanadianSecuritiesTransitionOfficeCSTO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authority for the Supervision and Development of Cooperative Societies
    /// Encoded/decoded by serializers as &quot;CYAS&quot;.
    /// </summary>
    [EnumMember(Value = "CYAS")]
    [IsoId("_unbPYvRYEeuLhpyIdtJzwg")]
    [Description(@"Authority for the Supervision and Development of Cooperative Societies")]
    AuthorityForTheSupervisionAndDevelopmentOfCooperativeSocieties =
        ExternalAuthorityIdentificationCode.AuthorityForTheSupervisionAndDevelopmentOfCooperativeSocieties, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Bank of Cyprus (CBC)
    /// Encoded/decoded by serializers as &quot;CYCB&quot;.
    /// </summary>
    [EnumMember(Value = "CYCB")]
    [IsoId("_unbPZfRYEeuLhpyIdtJzwg")]
    [Description(@"Central Bank of Cyprus (CBC)")]
    CentralBankOfCyprusCBC = ExternalAuthorityIdentificationCode.CentralBankOfCyprusCBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cyprus Securities and Exchange Commission (CySEC)
    /// Encoded/decoded by serializers as &quot;CYCY&quot;.
    /// </summary>
    [EnumMember(Value = "CYCY")]
    [IsoId("_unbPaPRYEeuLhpyIdtJzwg")]
    [Description(@"Cyprus Securities and Exchange Commission (CySEC)")]
    CyprusSecuritiesAndExchangeCommissionCySEC =
        ExternalAuthorityIdentificationCode.CyprusSecuritiesAndExchangeCommissionCySEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Czech National Bank (CNB)
    /// Encoded/decoded by serializers as &quot;CZCN&quot;.
    /// </summary>
    [EnumMember(Value = "CZCN")]
    [IsoId("_unlAYvRYEeuLhpyIdtJzwg")]
    [Description(@"Czech National Bank (CNB)")]
    CzechNationalBankCNB = ExternalAuthorityIdentificationCode.CzechNationalBankCNB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Federal Financial Supervisory Authority (BaFin)
    /// Encoded/decoded by serializers as &quot;DEBA&quot;.
    /// </summary>
    [EnumMember(Value = "DEBA")]
    [IsoId("_unlAZfRYEeuLhpyIdtJzwg")]
    [Description(@"Federal Financial Supervisory Authority (BaFin)")]
    FederalFinancialSupervisoryAuthorityBaFin =
        ExternalAuthorityIdentificationCode.FederalFinancialSupervisoryAuthorityBaFin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Finanstilsynet
    /// Encoded/decoded by serializers as &quot;DKFI&quot;.
    /// </summary>
    [EnumMember(Value = "DKFI")]
    [IsoId("_unlAaPRYEeuLhpyIdtJzwg")]
    [Description(@"Finanstilsynet ")]
    Finanstilsynet = ExternalAuthorityIdentificationCode.Finanstilsynet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Estonian Financial Supervision Authority (EFSA)
    /// Encoded/decoded by serializers as &quot;EEEF&quot;.
    /// </summary>
    [EnumMember(Value = "EEEF")]
    [IsoId("_unlAa_RYEeuLhpyIdtJzwg")]
    [Description(@"Estonian Financial Supervision Authority (EFSA)")]
    EstonianFinancialSupervisionAuthorityEFSA =
        ExternalAuthorityIdentificationCode.EstonianFinancialSupervisionAuthorityEFSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// European Securities and Markets Authority (ESMA)
    /// Encoded/decoded by serializers as &quot;EUES&quot;.
    /// </summary>
    [EnumMember(Value = "EUES")]
    [IsoId("_unuKUvRYEeuLhpyIdtJzwg")]
    [Description(@"European Securities and Markets Authority (ESMA)")]
    EuropeanSecuritiesAndMarketsAuthorityESMA =
        ExternalAuthorityIdentificationCode.EuropeanSecuritiesAndMarketsAuthorityESMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank of Spain (BDE)
    /// Encoded/decoded by serializers as &quot;ESBD&quot;.
    /// </summary>
    [EnumMember(Value = "ESBD")]
    [IsoId("_unuKVfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Spain (BDE)")]
    BankOfSpainBDE = ExternalAuthorityIdentificationCode.BankOfSpainBDE, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Comisión Nacional del Mercado de Valores (CNMV)
    /// Encoded/decoded by serializers as &quot;ESCN&quot;.
    /// </summary>
    [EnumMember(Value = "ESCN")]
    [IsoId("_unuKWPRYEeuLhpyIdtJzwg")]
    [Description(@"Comisión Nacional del Mercado de Valores (CNMV)")]
    ComisiónNacionalDelMercadoDeValoresCNMV =
        ExternalAuthorityIdentificationCode.ComisiónNacionalDelMercadoDeValoresCNMV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Finanssivalvonta (FSA)
    /// Encoded/decoded by serializers as &quot;FIFS&quot;.
    /// </summary>
    [EnumMember(Value = "FIFS")]
    [IsoId("_un37UvRYEeuLhpyIdtJzwg")]
    [Description(@"Finanssivalvonta (FSA)")]
    FinanssivalvontaFSA = ExternalAuthorityIdentificationCode.FinanssivalvontaFSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Autorité de Contrôle Prudentiel et de Résolution (ACPR)
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_un37VfRYEeuLhpyIdtJzwg")]
    [Description(@"Autorité de Contrôle Prudentiel et de Résolution (ACPR)")]
    AutoritéDeContrôlePrudentielEtDeRésolutionACPR =
        ExternalAuthorityIdentificationCode.AutoritéDeContrôlePrudentielEtDeRésolutionACPR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Autorité des Marchés Financiers (AMF)
    /// Encoded/decoded by serializers as &quot;FRAM&quot;.
    /// </summary>
    [EnumMember(Value = "FRAM")]
    [IsoId("_un37WPRYEeuLhpyIdtJzwg")]
    [Description(@"Autorité des Marchés Financiers (AMF)")]
    AutoritéDesMarchésFinanciersAMF =
        ExternalAuthorityIdentificationCode.AutoritéDesMarchésFinanciersAMF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Services Authority (FSA)
    /// Encoded/decoded by serializers as &quot;GBFS&quot;.
    /// </summary>
    [EnumMember(Value = "GBFS")]
    [IsoId("_uoBsUvRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Services Authority (FSA)")]
    FinancialServicesAuthorityFSA =
        ExternalAuthorityIdentificationCode.FinancialServicesAuthorityFSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Conduct Authority (FCA)
    /// Encoded/decoded by serializers as &quot;GBFC&quot;.
    /// </summary>
    [EnumMember(Value = "GBFC")]
    [IsoId("_uoBsVfRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Conduct Authority (FCA)")]
    FinancialConductAuthorityFCA = ExternalAuthorityIdentificationCode.FinancialConductAuthorityFCA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Prudential Regulation Authority (PRA)
    /// Encoded/decoded by serializers as &quot;GBPR&quot;.
    /// </summary>
    [EnumMember(Value = "GBPR")]
    [IsoId("_uoBsWPRYEeuLhpyIdtJzwg")]
    [Description(@"Prudential Regulation Authority (PRA)")]
    PrudentialRegulationAuthorityPRA =
        ExternalAuthorityIdentificationCode.PrudentialRegulationAuthorityPRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gibraltar FSC (FSC)
    /// Encoded/decoded by serializers as &quot;GIFS&quot;.
    /// </summary>
    [EnumMember(Value = "GIFS")]
    [IsoId("_uoK2QvRYEeuLhpyIdtJzwg")]
    [Description(@"Gibraltar FSC (FSC)")]
    GibraltarFSC = ExternalAuthorityIdentificationCode.GibraltarFSC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US Commodity Futures Trading Commission (CFTC)
    /// Encoded/decoded by serializers as &quot;USCF&quot;.
    /// </summary>
    [EnumMember(Value = "USCF")]
    [IsoId("_uoK2RfRYEeuLhpyIdtJzwg")]
    [Description(@"US Commodity Futures Trading Commission (CFTC)")]
    USCommodityFuturesTradingCommissionCFTC =
        ExternalAuthorityIdentificationCode.USCommodityFuturesTradingCommissionCFTC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank of Greece (BOG)
    /// Encoded/decoded by serializers as &quot;GRBO&quot;.
    /// </summary>
    [EnumMember(Value = "GRBO")]
    [IsoId("_uoUnQvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Greece (BOG)")]
    BankOfGreeceBOG = ExternalAuthorityIdentificationCode.BankOfGreeceBOG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hellenic Capital Market Commission (HCMC)
    /// Encoded/decoded by serializers as &quot;GRHC&quot;.
    /// </summary>
    [EnumMember(Value = "GRHC")]
    [IsoId("_uoUnRfRYEeuLhpyIdtJzwg")]
    [Description(@"Hellenic Capital Market Commission (HCMC)")]
    HellenicCapitalMarketCommissionHCMC =
        ExternalAuthorityIdentificationCode.HellenicCapitalMarketCommissionHCMC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Croatian Financial Services Supervisory Agency (HANFA)
    /// Encoded/decoded by serializers as &quot;HRHA&quot;.
    /// </summary>
    [EnumMember(Value = "HRHA")]
    [IsoId("_uoUnSPRYEeuLhpyIdtJzwg")]
    [Description(@"Croatian Financial Services Supervisory Agency (HANFA)")]
    CroatianFinancialServicesSupervisoryAgencyHANFA =
        ExternalAuthorityIdentificationCode.CroatianFinancialServicesSupervisoryAgencyHANFA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hungarian Financial Supervisory Authority (PSZAF)
    /// Encoded/decoded by serializers as &quot;HUPS&quot;.
    /// </summary>
    [EnumMember(Value = "HUPS")]
    [IsoId("_uoUnS_RYEeuLhpyIdtJzwg")]
    [Description(@"Hungarian Financial Supervisory Authority (PSZAF)")]
    HungarianFinancialSupervisoryAuthorityPSZAF =
        ExternalAuthorityIdentificationCode.HungarianFinancialSupervisoryAuthorityPSZAF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Bank of Ireland (CBI)
    /// Encoded/decoded by serializers as &quot;IECB&quot;.
    /// </summary>
    [EnumMember(Value = "IECB")]
    [IsoId("_uodxMvRYEeuLhpyIdtJzwg")]
    [Description(@"Central Bank of Ireland (CBI)")]
    CentralBankOfIrelandCBI = ExternalAuthorityIdentificationCode.CentralBankOfIrelandCBI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Iceland Financial Supervisory Authority (FME)
    /// Encoded/decoded by serializers as &quot;ISFM&quot;.
    /// </summary>
    [EnumMember(Value = "ISFM")]
    [IsoId("_uodxNfRYEeuLhpyIdtJzwg")]
    [Description(@"Iceland Financial Supervisory Authority (FME)")]
    IcelandFinancialSupervisoryAuthorityFME =
        ExternalAuthorityIdentificationCode.IcelandFinancialSupervisoryAuthorityFME, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BANCA D&apos;ITALIA (BDI)
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_uodxOPRYEeuLhpyIdtJzwg")]
    [Description(@"BANCA D'ITALIA (BDI)")]
    BANCAAndDITALIA = ExternalAuthorityIdentificationCode.BANCAAndDITALIA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commissione Nazionale per le Societa e la Borsa (CONSOB)
    /// Encoded/decoded by serializers as &quot;ITCO&quot;.
    /// </summary>
    [EnumMember(Value = "ITCO")]
    [IsoId("_uodxO_RYEeuLhpyIdtJzwg")]
    [Description(@"Commissione Nazionale per le Societa e la Borsa (CONSOB)")]
    CommissioneNazionalePerLeSocietaELaBorsaCONSOB =
        ExternalAuthorityIdentificationCode.CommissioneNazionalePerLeSocietaELaBorsaCONSOB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Market Authority (FMA)
    /// Encoded/decoded by serializers as &quot;LIFM&quot;.
    /// </summary>
    [EnumMember(Value = "LIFM")]
    [IsoId("_uoniMvRYEeuLhpyIdtJzwg")]
    [Description(@"Financial Market Authority (FMA)")]
    FinancialMarketAuthorityFMA = ExternalAuthorityIdentificationCode.FinancialMarketAuthorityFMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank of Lithuania (LSC)
    /// Encoded/decoded by serializers as &quot;LTLS&quot;.
    /// </summary>
    [EnumMember(Value = "LTLS")]
    [IsoId("_uoniNfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank of Lithuania (LSC)")]
    BankOfLithuaniaLSC = ExternalAuthorityIdentificationCode.BankOfLithuaniaLSC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission de Surveillance du Secteur Financier (CSSF)
    /// Encoded/decoded by serializers as &quot;LUCS&quot;.
    /// </summary>
    [EnumMember(Value = "LUCS")]
    [IsoId("_uoniOPRYEeuLhpyIdtJzwg")]
    [Description(@"Commission de Surveillance du Secteur Financier (CSSF)")]
    CommissionDeSurveillanceDuSecteurFinancierCSSF =
        ExternalAuthorityIdentificationCode.CommissionDeSurveillanceDuSecteurFinancierCSSF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial &amp; Capital Market Commission (FKTK)
    /// Encoded/decoded by serializers as &quot;LVFK&quot;.
    /// </summary>
    [EnumMember(Value = "LVFK")]
    [IsoId("_uoniO_RYEeuLhpyIdtJzwg")]
    [Description(@"Financial & Capital Market Commission (FKTK)")]
    FinancialAndCapitalMarketCommissionFKTK =
        ExternalAuthorityIdentificationCode.FinancialAndCapitalMarketCommissionFKTK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Malta Financial Services Authority (MFSA)
    /// Encoded/decoded by serializers as &quot;MTMF&quot;.
    /// </summary>
    [EnumMember(Value = "MTMF")]
    [IsoId("_uoniPvRYEeuLhpyIdtJzwg")]
    [Description(@"Malta Financial Services Authority (MFSA)")]
    MaltaFinancialServicesAuthorityMFSA =
        ExternalAuthorityIdentificationCode.MaltaFinancialServicesAuthorityMFSA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Netherlands Authority for the Financial Markets (AFM)
    /// Encoded/decoded by serializers as &quot;NLAF&quot;.
    /// </summary>
    [EnumMember(Value = "NLAF")]
    [IsoId("_uoxTMvRYEeuLhpyIdtJzwg")]
    [Description(@"Netherlands Authority for the Financial Markets (AFM)")]
    NetherlandsAuthorityForTheFinancialMarketsAFM =
        ExternalAuthorityIdentificationCode.NetherlandsAuthorityForTheFinancialMarketsAFM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Nederlandse Bank (DNB)
    /// Encoded/decoded by serializers as &quot;NLDN&quot;.
    /// </summary>
    [EnumMember(Value = "NLDN")]
    [IsoId("_uoxTNfRYEeuLhpyIdtJzwg")]
    [Description(@"Nederlandse Bank (DNB)")]
    NederlandseBankDNB = ExternalAuthorityIdentificationCode.NederlandseBankDNB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Norwegian Financial Supervisory Authority (Finanstilsynet)
    /// Encoded/decoded by serializers as &quot;NOFI&quot;.
    /// </summary>
    [EnumMember(Value = "NOFI")]
    [IsoId("_uo6dIvRYEeuLhpyIdtJzwg")]
    [Description(@"Norwegian Financial Supervisory Authority (Finanstilsynet)")]
    NorwegianFinancialSupervisoryAuthorityFinanstilsynet =
        ExternalAuthorityIdentificationCode.NorwegianFinancialSupervisoryAuthorityFinanstilsynet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Polish Financial Supervisory Commission (KNF)
    /// Encoded/decoded by serializers as &quot;PLKN&quot;.
    /// </summary>
    [EnumMember(Value = "PLKN")]
    [IsoId("_uo6dJfRYEeuLhpyIdtJzwg")]
    [Description(@"Polish Financial Supervisory Commission (KNF)")]
    PolishFinancialSupervisoryCommissionKNF =
        ExternalAuthorityIdentificationCode.PolishFinancialSupervisoryCommissionKNF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Banco de Portugal (BP)
    /// Encoded/decoded by serializers as &quot;PTBP&quot;.
    /// </summary>
    [EnumMember(Value = "PTBP")]
    [IsoId("_uo6dKPRYEeuLhpyIdtJzwg")]
    [Description(@"Banco de Portugal (BP)")]
    BancoDePortugalBP = ExternalAuthorityIdentificationCode.BancoDePortugalBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Comissão do Mercado de Valores Mobiliários (CMVM)
    /// Encoded/decoded by serializers as &quot;PTCM&quot;.
    /// </summary>
    [EnumMember(Value = "PTCM")]
    [IsoId("_uo6dK_RYEeuLhpyIdtJzwg")]
    [Description(@"Comissão do Mercado de Valores Mobiliários (CMVM)")]
    ComissãoDoMercadoDeValoresMobiliáriosCMVM =
        ExternalAuthorityIdentificationCode.ComissãoDoMercadoDeValoresMobiliáriosCMVM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Romanian Financial Supervisory Authority (ASF)
    /// Encoded/decoded by serializers as &quot;ROAS&quot;.
    /// </summary>
    [EnumMember(Value = "ROAS")]
    [IsoId("_upEOIvRYEeuLhpyIdtJzwg")]
    [Description(@"Romanian Financial Supervisory Authority (ASF)")]
    RomanianFinancialSupervisoryAuthorityASF =
        ExternalAuthorityIdentificationCode.RomanianFinancialSupervisoryAuthorityASF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Finansinspektionen (FI)
    /// Encoded/decoded by serializers as &quot;SEFI&quot;.
    /// </summary>
    [EnumMember(Value = "SEFI")]
    [IsoId("_upEOJfRYEeuLhpyIdtJzwg")]
    [Description(@"Finansinspektionen (FI)")]
    FinansinspektionenFI = ExternalAuthorityIdentificationCode.FinansinspektionenFI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities Market Agency (ATVP)
    /// Encoded/decoded by serializers as &quot;SIAT&quot;.
    /// </summary>
    [EnumMember(Value = "SIAT")]
    [IsoId("_upNYEvRYEeuLhpyIdtJzwg")]
    [Description(@"Securities Market Agency (ATVP)")]
    SecuritiesMarketAgencyATVP = ExternalAuthorityIdentificationCode.SecuritiesMarketAgencyATVP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National Bank of Slovakia (NBS)
    /// Encoded/decoded by serializers as &quot;SKNB&quot;.
    /// </summary>
    [EnumMember(Value = "SKNB")]
    [IsoId("_upNYFfRYEeuLhpyIdtJzwg")]
    [Description(@"National Bank of Slovakia (NBS)")]
    NationalBankOfSlovakiaNBS = ExternalAuthorityIdentificationCode.NationalBankOfSlovakiaNBS, // same ordinal as derivation source for type conversions
}
