// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Details related to the master agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_B-g18MkeEeeiAIB1i4AlQw")]
[Description(@"Details related to the master agreement.")]
[Derivations(typeof(ExternalAgreementType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAgreementTypeCode>))]
#endif
public enum ExternalAgreementTypeCode
{
    /// <summary>
    /// Australian Masters Securities Lending Agreement (AMSLA).
    /// Encoded/decoded by serializers as &quot;AUSL&quot;.
    /// </summary>
    [EnumMember(Value = "AUSL")]
    [IsoId("_usWLoPRYEeuLhpyIdtJzwg")]
    [Description(@"Australian Masters Securities Lending Agreement (AMSLA).")]
    AustralianMastersSecuritiesLendingAgreementAMSLA,

    /// <summary>
    /// Bilateral agreement.
    /// Encoded/decoded by serializers as &quot;BIAG&quot;.
    /// </summary>
    [EnumMember(Value = "BIAG")]
    [IsoId("_usWLo_RYEeuLhpyIdtJzwg")]
    [Description(@"Bilateral agreement.")]
    BilateralAgreement,

    /// <summary>
    /// Investment Industry Regulatory Organization of Canada (IIROC) Repurchase/Reverse Repurchase Transaction Agreement.
    /// Encoded/decoded by serializers as &quot;CARA&quot;.
    /// </summary>
    [EnumMember(Value = "CARA")]
    [IsoId("_usfVkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Investment Industry Regulatory Organization of Canada (IIROC) Repurchase/Reverse Repurchase Transaction Agreement."
    )]
    InvestmentIndustryRegulatoryOrganizationofCanadaIIROCRepurchaseReverseRepurchaseTransactionAgreement,

    /// <summary>
    /// FIA-ISDA Cleared Derivatives Execution Agreement.
    /// Encoded/decoded by serializers as &quot;CDEA&quot;.
    /// </summary>
    [EnumMember(Value = "CDEA")]
    [IsoId("_usfVk_RYEeuLhpyIdtJzwg")]
    [Description(@"FIA-ISDA Cleared Derivatives Execution Agreement.")]
    FIAISDAClearedDerivativesExecutionAgreement,

    /// <summary>
    /// Swiss Master Agreement.
    /// Encoded/decoded by serializers as &quot;CHMA&quot;.
    /// </summary>
    [EnumMember(Value = "CHMA")]
    [IsoId("_usfVlvRYEeuLhpyIdtJzwg")]
    [Description(@"Swiss Master Agreement.")]
    SwissMasterAgreement,

    /// <summary>
    /// Swiss Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;CHRA&quot;.
    /// </summary>
    [EnumMember(Value = "CHRA")]
    [IsoId("_uspGkPRYEeuLhpyIdtJzwg")]
    [Description(@"Swiss Master Repurchase Agreement.")]
    SwissMasterRepurchaseAgreement,

    /// <summary>
    /// Contrato Marco de Operaciones Financieras.
    /// Encoded/decoded by serializers as &quot;CMOP&quot;.
    /// </summary>
    [EnumMember(Value = "CMOP")]
    [IsoId("_uspGk_RYEeuLhpyIdtJzwg")]
    [Description(@"Contrato Marco de Operaciones Financieras.")]
    ContratoMarcoDeOperacionesFinancieras,

    /// <summary>
    /// China Bond Repurchase Master Agreement.
    /// Encoded/decoded by serializers as &quot;CNBR&quot;.
    /// </summary>
    [EnumMember(Value = "CNBR")]
    [IsoId("_uspGlvRYEeuLhpyIdtJzwg")]
    [Description(@"China Bond Repurchase Master Agreement.")]
    ChinaBondRepurchaseMasterAgreement,

    /// <summary>
    /// CSD bilateral agreement.
    /// Encoded/decoded by serializers as &quot;CSDA&quot;.
    /// </summary>
    [EnumMember(Value = "CSDA")]
    [IsoId("_usy3kPRYEeuLhpyIdtJzwg")]
    [Description(@"CSD bilateral agreement.")]
    CSDBilateralAgreement,

    /// <summary>
    /// German Master Agreement.
    /// Encoded/decoded by serializers as &quot;DEMA&quot;.
    /// </summary>
    [EnumMember(Value = "DEMA")]
    [IsoId("_usy3k_RYEeuLhpyIdtJzwg")]
    [Description(@"German Master Agreement.")]
    GermanMasterAgreement,

    /// <summary>
    /// Deutscher Rahmenvertrag für Wertpapierdarlehen.
    /// Encoded/decoded by serializers as &quot;DERD&quot;.
    /// </summary>
    [EnumMember(Value = "DERD")]
    [IsoId("_usy3lvRYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Wertpapierdarlehen.")]
    DeutscherRahmenvertragfurWertpapierdarlehen,

    /// <summary>
    /// Deutscher Rahmenvertrag für Wertpapierpensionsgeschäfte .
    /// Encoded/decoded by serializers as &quot;DERP&quot;.
    /// </summary>
    [EnumMember(Value = "DERP")]
    [IsoId("_usy3mfRYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Wertpapierpensionsgeschäfte .")]
    DeutscherRahmenvertragfurWertpapierpensionsgeschafte,

    /// <summary>
    /// Deutscher Rahmenvertrag für Finanztermingeschäfte (DRV).
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_us8BgPRYEeuLhpyIdtJzwg")]
    [Description(@"Deutscher Rahmenvertrag für Finanztermingeschäfte (DRV).")]
    DeutscherRahmenvertragfurFinanztermingeschafteDRV,

    /// <summary>
    /// EFET Master Agreement.
    /// Encoded/decoded by serializers as &quot;EFMA&quot;.
    /// </summary>
    [EnumMember(Value = "EFMA")]
    [IsoId("_us8Bg_RYEeuLhpyIdtJzwg")]
    [Description(@"EFET Master Agreement.")]
    EFETMasterAgreement,

    /// <summary>
    /// Contrato Marco de compraventa y Reporto de valores.
    /// Encoded/decoded by serializers as &quot;ESRA&quot;.
    /// </summary>
    [EnumMember(Value = "ESRA")]
    [IsoId("_us8BhvRYEeuLhpyIdtJzwg")]
    [Description(@"Contrato Marco de compraventa y Reporto de valores.")]
    ContratoMarcoDeCompraventaYReportoDeValores,

    /// <summary>
    /// European Master Agreement.
    /// Encoded/decoded by serializers as &quot;EUMA&quot;.
    /// </summary>
    [EnumMember(Value = "EUMA")]
    [IsoId("_us8BifRYEeuLhpyIdtJzwg")]
    [Description(@"European Master Agreement.")]
    EuropeanMasterAgreement,

    /// <summary>
    /// FBF Master Agreement related to transactions on forward financial instruments.
    /// Encoded/decoded by serializers as &quot;FMAT&quot;.
    /// </summary>
    [EnumMember(Value = "FMAT")]
    [IsoId("_utFygPRYEeuLhpyIdtJzwg")]
    [Description(@"FBF Master Agreement related to transactions on forward financial instruments.")]
    FBFMasterAgreementRelatedToTransactionsOnForwardFinancialInstruments,

    /// <summary>
    /// FOA Professional Client Agreement.
    /// Encoded/decoded by serializers as &quot;FPCA&quot;.
    /// </summary>
    [EnumMember(Value = "FPCA")]
    [IsoId("_utFyg_RYEeuLhpyIdtJzwg")]
    [Description(@"FOA Professional Client Agreement.")]
    FOAProfessionalClientAgreement,

    /// <summary>
    /// Convention-Cadre Relative aux Operations de Pensions Livrees.
    /// Encoded/decoded by serializers as &quot;FRFB&quot;.
    /// </summary>
    [EnumMember(Value = "FRFB")]
    [IsoId("_utFyhvRYEeuLhpyIdtJzwg")]
    [Description(@"Convention-Cadre Relative aux Operations de Pensions Livrees.")]
    ConventionCadreRelativeauxOperationsdePensionsLivrees,

    /// <summary>
    /// Gilt Edged Stock Lending Agreement (GESLA).
    /// Encoded/decoded by serializers as &quot;GESL&quot;.
    /// </summary>
    [EnumMember(Value = "GESL")]
    [IsoId("_utFyifRYEeuLhpyIdtJzwg")]
    [Description(@"Gilt Edged Stock Lending Agreement (GESLA).")]
    GiltEdgedStockLendingAgreementGESLA,

    /// <summary>
    /// Global Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;GMRA&quot;.
    /// </summary>
    [EnumMember(Value = "GMRA")]
    [IsoId("_utFyjPRYEeuLhpyIdtJzwg")]
    [Description(@"Global Master Repurchase Agreement.")]
    GlobalMasterRepurchaseAgreement,

    /// <summary>
    /// Global Master Securities Lending Agreement.
    /// Encoded/decoded by serializers as &quot;GMSL&quot;.
    /// </summary>
    [EnumMember(Value = "GMSL")]
    [IsoId("_utO8cPRYEeuLhpyIdtJzwg")]
    [Description(@"Global Master Securities Lending Agreement.")]
    GlobalMasterSecuritiesLendingAgreement,

    /// <summary>
    /// Islamic Derivative Master Agreement.
    /// Encoded/decoded by serializers as &quot;IDMA&quot;.
    /// </summary>
    [EnumMember(Value = "IDMA")]
    [IsoId("_utO8c_RYEeuLhpyIdtJzwg")]
    [Description(@"Islamic Derivative Master Agreement.")]
    IslamicDerivativeMasterAgreement,

    /// <summary>
    /// International Swaps and Derivatives Association Agreement.
    /// Encoded/decoded by serializers as &quot;ISDA&quot;.
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_utYtcPRYEeuLhpyIdtJzwg")]
    [Description(@"International Swaps and Derivatives Association Agreement.")]
    InternationalSwapsAndDerivativesAssociationAgreement,

    /// <summary>
    /// Japanese Master Agreement on Lending Transaction of Bonds.
    /// Encoded/decoded by serializers as &quot;JPBL&quot;.
    /// </summary>
    [EnumMember(Value = "JPBL")]
    [IsoId("_utYtc_RYEeuLhpyIdtJzwg")]
    [Description(@"Japanese Master Agreement on Lending Transaction of Bonds.")]
    JapaneseMasterAgreementonLendingTransactionOfBonds,

    /// <summary>
    /// Japanese Master Agreement on the Transaction with Repurchase Agreement of the Bonds.
    /// Encoded/decoded by serializers as &quot;JPBR&quot;.
    /// </summary>
    [EnumMember(Value = "JPBR")]
    [IsoId("_utYtdvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Japanese Master Agreement on the Transaction with Repurchase Agreement of the Bonds."
    )]
    JapaneseMasterAgreementontheTransactionwithRepurchaseAgreementOfTheBonds,

    /// <summary>
    /// Japanese Master Agreement on the Borrowing and Lending Transactions of Share Certificates.
    /// Encoded/decoded by serializers as &quot;JPSL&quot;.
    /// </summary>
    [EnumMember(Value = "JPSL")]
    [IsoId("_utYtefRYEeuLhpyIdtJzwg")]
    [Description(
        @"Japanese Master Agreement on the Borrowing and Lending Transactions of Share Certificates."
    )]
    JapaneseMasterAgreementOnTheBorrowingAndLendingTransactionsofShareCertificates,

    /// <summary>
    /// Korea Financial Investment Association (KOFIA) Standard Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;KRRA&quot;.
    /// </summary>
    [EnumMember(Value = "KRRA")]
    [IsoId("_utYtfPRYEeuLhpyIdtJzwg")]
    [Description(@"Korea Financial Investment Association (KOFIA) Standard Repurchase Agreement.")]
    KoreaFinancialInvestmentAssociationKOFIAStandardRepurchaseAgreement,

    /// <summary>
    /// Korean Securities Lending Agreement (KOSLA).
    /// Encoded/decoded by serializers as &quot;KRSL&quot;.
    /// </summary>
    [EnumMember(Value = "KRSL")]
    [IsoId("_utiecPRYEeuLhpyIdtJzwg")]
    [Description(@"Korean Securities Lending Agreement (KOSLA).")]
    KoreanSecuritiesLendingAgreementKOSLA,

    /// <summary>
    /// Master Equity and Fixed Interest Stock Lending Agreement (MEFISLA).
    /// Encoded/decoded by serializers as &quot;MEFI&quot;.
    /// </summary>
    [EnumMember(Value = "MEFI")]
    [IsoId("_utiec_RYEeuLhpyIdtJzwg")]
    [Description(@"Master Equity and Fixed Interest Stock Lending Agreement (MEFISLA).")]
    MasterEquityandFixedInterestStockLendingAgreementMEFISLA,

    /// <summary>
    /// Master Repurchase Agreement.
    /// Encoded/decoded by serializers as &quot;MRAA&quot;.
    /// </summary>
    [EnumMember(Value = "MRAA")]
    [IsoId("_utroYPRYEeuLhpyIdtJzwg")]
    [Description(@"Master Repurchase Agreement.")]
    MasterRepurchaseAgreement,

    /// <summary>
    /// Master Securities Loan Agreement.
    /// Encoded/decoded by serializers as &quot;MSLA&quot;.
    /// </summary>
    [EnumMember(Value = "MSLA")]
    [IsoId("_utroY_RYEeuLhpyIdtJzwg")]
    [Description(@"Master Securities Loan Agreement.")]
    MasterSecuritiesLoanAgreement,

    /// <summary>
    /// Overseas Securities Lending Agreement.
    /// Encoded/decoded by serializers as &quot;OSLA&quot;.
    /// </summary>
    [EnumMember(Value = "OSLA")]
    [IsoId("_utroZvRYEeuLhpyIdtJzwg")]
    [Description(@"Overseas Securities Lending Agreement.")]
    OverseasSecuritiesLendingAgreement,

    /// <summary>
    /// Other type of master agreement.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_utroafRYEeuLhpyIdtJzwg")]
    [Description(@"Other type of master agreement.")]
    OtherTypeOfMasterAgreement,
}
