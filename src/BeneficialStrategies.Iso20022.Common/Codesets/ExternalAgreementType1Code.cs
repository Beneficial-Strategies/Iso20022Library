// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Jjlw8MkeEeeiAIB1i4AlQw")]
[Description(
    @"Name of the identification scheme, in a coded form as published in an external list."
)]
[DerivedFrom(typeof(ExternalAgreementTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAgreementType1Code>))]
#endif
public enum ExternalAgreementType1Code
{
    /// <summary>
    /// Australian Masters Securities Lending Agreement (AMSLA).
    /// Encoded/decoded by serializers as &quot;AUSL&quot;.
    /// </summary>
    [EnumMember(Value = "AUSL")]
    [IsoId("_usWLovRYEeuLhpyIdtJzwg")]
    [Description(@"Australian Masters Securities Lending Agreement (AMSLA).")]
    AustralianMastersSecuritiesLendingAgreementAMSLA =
        ExternalAgreementTypeCode.AustralianMastersSecuritiesLendingAgreementAMSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bilateral agreement.
    /// Encoded/decoded by serializers as &quot;BIAG&quot;.
    /// </summary>
    [EnumMember(Value = "BIAG")]
    [IsoId("_usWLpfRYEeuLhpyIdtJzwg")]
    [Description(@"Bilateral agreement.")]
    BilateralAgreement = ExternalAgreementTypeCode.BilateralAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment Industry Regulatory Organization of Canada (IIROC) Repurchase/Reverse Repurchase Transaction Agreement.
    /// Encoded/decoded by serializers as &quot;CARA&quot;.
    /// </summary>
    [EnumMember(Value = "CARA")]
    [IsoId("_usfVkvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Investment Industry Regulatory Organization of Canada (IIROC) Repurchase/Reverse Repurchase Transaction Agreement."
    )]
    InvestmentIndustryRegulatoryOrganizationofCanadaIIROCRepurchaseReverseRepurchaseTransactionAgreement =
        ExternalAgreementTypeCode.InvestmentIndustryRegulatoryOrganizationofCanadaIIROCRepurchaseReverseRepurchaseTransactionAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FIA-ISDA Cleared Derivatives Execution Agreement.
    /// Encoded/decoded by serializers as &quot;CDEA&quot;.
    /// </summary>
    [EnumMember(Value = "CDEA")]
    [IsoId("_usfVlfRYEeuLhpyIdtJzwg")]
    [Description(@"FIA-ISDA Cleared Derivatives Execution Agreement.")]
    FIAISDAClearedDerivativesExecutionAgreement =
        ExternalAgreementTypeCode.FIAISDAClearedDerivativesExecutionAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swiss Master Agreement.
    /// Encoded/decoded by serializers as &quot;CHMA&quot;.
    /// </summary>
    [EnumMember(Value = "CHMA")]
    [IsoId("_usfVmPRYEeuLhpyIdtJzwg")]
    [Description(@"Swiss Master Agreement.")]
    SwissMasterAgreement = ExternalAgreementTypeCode.SwissMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Swiss Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;CHRA&quot;.
    /// </summary>
    [EnumMember(Value = "CHRA")]
    [IsoId("_uspGkvRYEeuLhpyIdtJzwg")]
    [Description(@"Swiss Master Repurchase Agreement.")]
    SwissMasterRepurchaseAgreement = ExternalAgreementTypeCode.SwissMasterRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contrato Marco de Operaciones Financieras.
    /// Encoded/decoded by serializers as &quot;CMOP&quot;.
    /// </summary>
    [EnumMember(Value = "CMOP")]
    [IsoId("_uspGlfRYEeuLhpyIdtJzwg")]
    [Description(@"Contrato Marco de Operaciones Financieras.")]
    ContratoMarcoDeOperacionesFinancieras =
        ExternalAgreementTypeCode.ContratoMarcoDeOperacionesFinancieras, // same ordinal as derivation source for type conversions

    /// <summary>
    /// China Bond Repurchase Master Agreement.
    /// Encoded/decoded by serializers as &quot;CNBR&quot;.
    /// </summary>
    [EnumMember(Value = "CNBR")]
    [IsoId("_uspGmPRYEeuLhpyIdtJzwg")]
    [Description(@"China Bond Repurchase Master Agreement.")]
    ChinaBondRepurchaseMasterAgreement =
        ExternalAgreementTypeCode.ChinaBondRepurchaseMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CSD bilateral agreement.
    /// Encoded/decoded by serializers as &quot;CSDA&quot;.
    /// </summary>
    [EnumMember(Value = "CSDA")]
    [IsoId("_usy3kvRYEeuLhpyIdtJzwg")]
    [Description(@"CSD bilateral agreement.")]
    CSDBilateralAgreement = ExternalAgreementTypeCode.CSDBilateralAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// German Master Agreement.
    /// Encoded/decoded by serializers as &quot;DEMA&quot;.
    /// </summary>
    [EnumMember(Value = "DEMA")]
    [IsoId("_usy3lfRYEeuLhpyIdtJzwg")]
    [Description(@"German Master Agreement.")]
    GermanMasterAgreement = ExternalAgreementTypeCode.GermanMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deutscher Rahmenvertrag für Wertpapierdarlehen.
    /// Encoded/decoded by serializers as &quot;DERD&quot;.
    /// </summary>
    [EnumMember(Value = "DERD")]
    [IsoId("_usy3mPRYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Wertpapierdarlehen.")]
    DeutscherRahmenvertragfurWertpapierdarlehen =
        ExternalAgreementTypeCode.DeutscherRahmenvertragfurWertpapierdarlehen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deutscher Rahmenvertrag für Wertpapierpensionsgeschäfte .
    /// Encoded/decoded by serializers as &quot;DERP&quot;.
    /// </summary>
    [EnumMember(Value = "DERP")]
    [IsoId("_usy3m_RYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Wertpapierpensionsgeschäfte .")]
    DeutscherRahmenvertragfurWertpapierpensionsgeschafte =
        ExternalAgreementTypeCode.DeutscherRahmenvertragfurWertpapierpensionsgeschafte, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deutscher Rahmenvertrag für Finanztermingeschäfte (DRV).
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_us8BgvRYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Finanztermingeschäfte (DRV).")]
    DeutscherRahmenvertragfurFinanztermingeschafteDRV =
        ExternalAgreementTypeCode.DeutscherRahmenvertragfurFinanztermingeschafteDRV, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EFET Master Agreement.
    /// Encoded/decoded by serializers as &quot;EFMA&quot;.
    /// </summary>
    [EnumMember(Value = "EFMA")]
    [IsoId("_us8BhfRYEeuLhpyIdtJzwg")]
    [Description(@"EFET Master Agreement.")]
    EFETMasterAgreement = ExternalAgreementTypeCode.EFETMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contrato Marco de compraventa y Reporto de valores.
    /// Encoded/decoded by serializers as &quot;ESRA&quot;.
    /// </summary>
    [EnumMember(Value = "ESRA")]
    [IsoId("_us8BiPRYEeuLhpyIdtJzwg")]
    [Description(@"Contrato Marco de compraventa y Reporto de valores.")]
    ContratoMarcoDeCompraventaYReportoDeValores =
        ExternalAgreementTypeCode.ContratoMarcoDeCompraventaYReportoDeValores, // same ordinal as derivation source for type conversions

    /// <summary>
    /// European Master Agreement.
    /// Encoded/decoded by serializers as &quot;EUMA&quot;.
    /// </summary>
    [EnumMember(Value = "EUMA")]
    [IsoId("_us8Bi_RYEeuLhpyIdtJzwg")]
    [Description(@"European Master Agreement.")]
    EuropeanMasterAgreement = ExternalAgreementTypeCode.EuropeanMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FBF Master Agreement related to transactions on forward financial instruments.
    /// Encoded/decoded by serializers as &quot;FMAT&quot;.
    /// </summary>
    [EnumMember(Value = "FMAT")]
    [IsoId("_utFygvRYEeuLhpyIdtJzwg")]
    [Description(@"FBF Master Agreement related to transactions on forward financial instruments.")]
    FBFMasterAgreementRelatedToTransactionsOnForwardFinancialInstruments =
        ExternalAgreementTypeCode.FBFMasterAgreementRelatedToTransactionsOnForwardFinancialInstruments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FOA Professional Client Agreement.
    /// Encoded/decoded by serializers as &quot;FPCA&quot;.
    /// </summary>
    [EnumMember(Value = "FPCA")]
    [IsoId("_utFyhfRYEeuLhpyIdtJzwg")]
    [Description(@"FOA Professional Client Agreement.")]
    FOAProfessionalClientAgreement = ExternalAgreementTypeCode.FOAProfessionalClientAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convention-Cadre Relative aux Operations de Pensions Livrees.
    /// Encoded/decoded by serializers as &quot;FRFB&quot;.
    /// </summary>
    [EnumMember(Value = "FRFB")]
    [IsoId("_utFyiPRYEeuLhpyIdtJzwg")]
    [Description(@"Convention-Cadre Relative aux Operations de Pensions Livrees.")]
    ConventionCadreRelativeauxOperationsdePensionsLivrees =
        ExternalAgreementTypeCode.ConventionCadreRelativeauxOperationsdePensionsLivrees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gilt Edged Stock Lending Agreement (GESLA).
    /// Encoded/decoded by serializers as &quot;GESL&quot;.
    /// </summary>
    [EnumMember(Value = "GESL")]
    [IsoId("_utFyi_RYEeuLhpyIdtJzwg")]
    [Description(@"Gilt Edged Stock Lending Agreement (GESLA).")]
    GiltEdgedStockLendingAgreementGESLA =
        ExternalAgreementTypeCode.GiltEdgedStockLendingAgreementGESLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;GMRA&quot;.
    /// </summary>
    [EnumMember(Value = "GMRA")]
    [IsoId("_utFyjvRYEeuLhpyIdtJzwg")]
    [Description(@"Global Master Repurchase Agreement.")]
    GlobalMasterRepurchaseAgreement = ExternalAgreementTypeCode.GlobalMasterRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global Master Securities Lending Agreement.
    /// Encoded/decoded by serializers as &quot;GMSL&quot;.
    /// </summary>
    [EnumMember(Value = "GMSL")]
    [IsoId("_utO8cvRYEeuLhpyIdtJzwg")]
    [Description(@"Global Master Securities Lending Agreement.")]
    GlobalMasterSecuritiesLendingAgreement =
        ExternalAgreementTypeCode.GlobalMasterSecuritiesLendingAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Islamic Derivative Master Agreement.
    /// Encoded/decoded by serializers as &quot;IDMA&quot;.
    /// </summary>
    [EnumMember(Value = "IDMA")]
    [IsoId("_utO8dfRYEeuLhpyIdtJzwg")]
    [Description(@"Islamic Derivative Master Agreement.")]
    IslamicDerivativeMasterAgreement = ExternalAgreementTypeCode.IslamicDerivativeMasterAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International Swaps and Derivatives Association Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_utYtcvRYEeuLhpyIdtJzwg")]
    [Description(@"International Swaps and Derivatives Association Agreement.")]
    InternationalSwapsAndDerivativesAssociationAgreement =
        ExternalAgreementTypeCode.InternationalSwapsAndDerivativesAssociationAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Japanese Master Agreement on Lending Transaction of Bonds.
    /// Encoded/decoded by serializers as &quot;JPBL&quot;.
    /// </summary>
    [EnumMember(Value = "JPBL")]
    [IsoId("_utYtdfRYEeuLhpyIdtJzwg")]
    [Description(@"Japanese Master Agreement on Lending Transaction of Bonds.")]
    JapaneseMasterAgreementonLendingTransactionOfBonds =
        ExternalAgreementTypeCode.JapaneseMasterAgreementonLendingTransactionOfBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Japanese Master Agreement on the Transaction with Repurchase Agreement of the Bonds.
    /// Encoded/decoded by serializers as &quot;JPBR&quot;.
    /// </summary>
    [EnumMember(Value = "JPBR")]
    [IsoId("_utYtePRYEeuLhpyIdtJzwg")]
    [Description(
        @"Japanese Master Agreement on the Transaction with Repurchase Agreement of the Bonds."
    )]
    JapaneseMasterAgreementontheTransactionwithRepurchaseAgreementOfTheBonds =
        ExternalAgreementTypeCode.JapaneseMasterAgreementontheTransactionwithRepurchaseAgreementOfTheBonds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Japanese Master Agreement on the Borrowing and Lending Transactions of Share Certificates.
    /// Encoded/decoded by serializers as &quot;JPSL&quot;.
    /// </summary>
    [EnumMember(Value = "JPSL")]
    [IsoId("_utYte_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Japanese Master Agreement on the Borrowing and Lending Transactions of Share Certificates."
    )]
    JapaneseMasterAgreementOnTheBorrowingAndLendingTransactionsofShareCertificates =
        ExternalAgreementTypeCode.JapaneseMasterAgreementOnTheBorrowingAndLendingTransactionsofShareCertificates, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Korea Financial Investment Association (KOFIA) Standard Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;KRRA&quot;.
    /// </summary>
    [EnumMember(Value = "KRRA")]
    [IsoId("_utYtfvRYEeuLhpyIdtJzwg")]
    [Description(@"Korea Financial Investment Association (KOFIA) Standard Repurchase Agreement.")]
    KoreaFinancialInvestmentAssociationKOFIAStandardRepurchaseAgreement =
        ExternalAgreementTypeCode.KoreaFinancialInvestmentAssociationKOFIAStandardRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Korean Securities Lending Agreement (KOSLA).
    /// Encoded/decoded by serializers as &quot;KRSL&quot;.
    /// </summary>
    [EnumMember(Value = "KRSL")]
    [IsoId("_utiecvRYEeuLhpyIdtJzwg")]
    [Description(@"Korean Securities Lending Agreement (KOSLA).")]
    KoreanSecuritiesLendingAgreementKOSLA =
        ExternalAgreementTypeCode.KoreanSecuritiesLendingAgreementKOSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Master Equity and Fixed Interest Stock Lending Agreement (MEFISLA).
    /// Encoded/decoded by serializers as &quot;MEFI&quot;.
    /// </summary>
    [EnumMember(Value = "MEFI")]
    [IsoId("_utiedfRYEeuLhpyIdtJzwg")]
    [Description(@"Master Equity and Fixed Interest Stock Lending Agreement (MEFISLA).")]
    MasterEquityandFixedInterestStockLendingAgreementMEFISLA =
        ExternalAgreementTypeCode.MasterEquityandFixedInterestStockLendingAgreementMEFISLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;MRAA&quot;.
    /// </summary>
    [EnumMember(Value = "MRAA")]
    [IsoId("_utroYvRYEeuLhpyIdtJzwg")]
    [Description(@"Master Repurchase Agreement.")]
    MasterRepurchaseAgreement = ExternalAgreementTypeCode.MasterRepurchaseAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Master Securities Loan Agreement.
    /// Encoded/decoded by serializers as &quot;MSLA&quot;.
    /// </summary>
    [EnumMember(Value = "MSLA")]
    [IsoId("_utroZfRYEeuLhpyIdtJzwg")]
    [Description(@"Master Securities Loan Agreement.")]
    MasterSecuritiesLoanAgreement = ExternalAgreementTypeCode.MasterSecuritiesLoanAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overseas Securities Lending Agreement.
    /// Encoded/decoded by serializers as &quot;OSLA&quot;.
    /// </summary>
    [EnumMember(Value = "OSLA")]
    [IsoId("_utroaPRYEeuLhpyIdtJzwg")]
    [Description(@"Overseas Securities Lending Agreement.")]
    OverseasSecuritiesLendingAgreement =
        ExternalAgreementTypeCode.OverseasSecuritiesLendingAgreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of master agreement.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_utroa_RYEeuLhpyIdtJzwg")]
    [Description(@"Other type of master agreement.")]
    OtherTypeOfMasterAgreement = ExternalAgreementTypeCode.OtherTypeOfMasterAgreement, // same ordinal as derivation source for type conversions
}
