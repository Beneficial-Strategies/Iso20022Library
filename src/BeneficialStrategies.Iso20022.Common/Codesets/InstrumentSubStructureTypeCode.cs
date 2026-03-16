// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of deal for structured finance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbIeoGliEeGaMcKyqKNRfQ_1900611305")]
[Description(@"Indicates the type of deal for structured finance.")]
[Derivations(typeof(InstrumentSubStructureType1Code))]
public enum InstrumentSubStructureTypeCode
{
    /// <summary>
    /// Sub structured type of the financial instrument is an asset backed security.
    /// Encoded/decoded by serializers as &quot;ABSE&quot;.
    /// </summary>
    [EnumMember(Value = "ABSE")]
    [IsoId("_hbIeoWliEeGaMcKyqKNRfQ_1630077322")]
    [Description(@"Sub structured type of the financial instrument is an asset backed security.")]
    AssetBackedSecurity,

    /// <summary>
    /// Sub structured type of the financial instrument is an airline trust.
    /// Encoded/decoded by serializers as &quot;AIRT&quot;.
    /// </summary>
    [EnumMember(Value = "AIRT")]
    [IsoId("_hbIeomliEeGaMcKyqKNRfQ_634250172")]
    [Description(@"Sub structured type of the financial instrument is an airline trust.")]
    AirlineTrust,

    /// <summary>
    /// Sub structured type of the financial instrument is an auto trust.
    /// Encoded/decoded by serializers as &quot;AUTT&quot;.
    /// </summary>
    [EnumMember(Value = "AUTT")]
    [IsoId("_hbIeo2liEeGaMcKyqKNRfQ_1590253611")]
    [Description(@"Sub structured type of the financial instrument is an auto trust.")]
    AutoTrust,

    /// <summary>
    /// Sub structured type of the financial instrument is a collateral bond obligation.
    /// Encoded/decoded by serializers as &quot;CBOB&quot;.
    /// </summary>
    [EnumMember(Value = "CBOB")]
    [IsoId("_hbIepGliEeGaMcKyqKNRfQ_1415699349")]
    [Description(
        @"Sub structured type of the financial instrument is a collateral bond obligation."
    )]
    CollateralBondObligation,

    /// <summary>
    /// Sub structured type of the financial instrument is a collateral debt obligation.
    /// Encoded/decoded by serializers as &quot;CDOB&quot;.
    /// </summary>
    [EnumMember(Value = "CDOB")]
    [IsoId("_hbIepWliEeGaMcKyqKNRfQ_-2011637191")]
    [Description(
        @"Sub structured type of the financial instrument is a collateral debt obligation."
    )]
    CollateralDebtObligation,

    /// <summary>
    /// Sub-structured type of the financial instrument is a credit linked note.
    /// Encoded/decoded by serializers as &quot;CLNO&quot;.
    /// </summary>
    [EnumMember(Value = "CLNO")]
    [IsoId("_hbIepmliEeGaMcKyqKNRfQ_-81406778")]
    [Description(@"Sub-structured type of the financial instrument is a credit linked note.")]
    CreditLinkedNotes,

    /// <summary>
    /// Sub structured type of the financial instrument is a collateral loan obligation.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_hbIep2liEeGaMcKyqKNRfQ_1149112246")]
    [Description(
        @"Sub structured type of the financial instrument is a collateral loan obligation."
    )]
    CollateralLoanObligation,

    /// <summary>
    /// Sub structured type of the financial instrument is a commercial mortgage.
    /// Encoded/decoded by serializers as &quot;CMBS&quot;.
    /// </summary>
    [EnumMember(Value = "CMBS")]
    [IsoId("_hbIeqGliEeGaMcKyqKNRfQ_-1153397549")]
    [Description(@"Sub structured type of the financial instrument is a commercial mortgage.")]
    CommercialMortgage,

    /// <summary>
    /// Sub structured type of the financial instrument is a consumer.
    /// Encoded/decoded by serializers as &quot;CSMR&quot;.
    /// </summary>
    [EnumMember(Value = "CSMR")]
    [IsoId("_hbIeqWliEeGaMcKyqKNRfQ_1058192372")]
    [Description(@"Sub structured type of the financial instrument is a consumer.")]
    Consumer,

    /// <summary>
    /// Sub structured type of the financial instrument is a credit card trust.
    /// Encoded/decoded by serializers as &quot;CRCT&quot;.
    /// </summary>
    [EnumMember(Value = "CRCT")]
    [IsoId("_hbIeqmliEeGaMcKyqKNRfQ_-141407325")]
    [Description(@"Sub structured type of the financial instrument is a credit card trust.")]
    CreditCardTrust,

    /// <summary>
    /// Sub structured type of the financial instrument is a home equity loan.
    /// Encoded/decoded by serializers as &quot;HELO&quot;.
    /// </summary>
    [EnumMember(Value = "HELO")]
    [IsoId("_hbIeq2liEeGaMcKyqKNRfQ_-1539653207")]
    [Description(@"Sub structured type of the financial instrument is a home equity loan.")]
    HomeEquityLoans,

    /// <summary>
    /// Sub structured type of the financial instrument is a loan participation notes.
    /// Encoded/decoded by serializers as &quot;LPNO&quot;.
    /// </summary>
    [EnumMember(Value = "LPNO")]
    [IsoId("_hbIerGliEeGaMcKyqKNRfQ_1333153531")]
    [Description(@"Sub structured type of the financial instrument is a loan participation notes.")]
    LoanParticipationNote,

    /// <summary>
    /// Sub structured type of the financial instrument is a covered bond.
    /// Encoded/decoded by serializers as &quot;PFAB&quot;.
    /// </summary>
    [EnumMember(Value = "PFAB")]
    [IsoId("_hbIerWliEeGaMcKyqKNRfQ_1527551116")]
    [Description(@"Sub structured type of the financial instrument is a covered bond.")]
    CoveredBond,

    /// <summary>
    /// Sub structured type of the financial instrument is a payment right.
    /// Encoded/decoded by serializers as &quot;PYRT&quot;.
    /// </summary>
    [EnumMember(Value = "PYRT")]
    [IsoId("_hbIermliEeGaMcKyqKNRfQ_-2121779798")]
    [Description(@"Sub structured type of the financial instrument is a payment right.")]
    PaymentRight,

    /// <summary>
    /// Sub structured type of the financial instrument is a repackaging.
    /// Encoded/decoded by serializers as &quot;REPK&quot;.
    /// </summary>
    [EnumMember(Value = "REPK")]
    [IsoId("_hbIer2liEeGaMcKyqKNRfQ_-1016603867")]
    [Description(@"Sub structured type of the financial instrument is a repackaging.")]
    Repackagings,

    /// <summary>
    /// Sub structured type of the financial instrument is a residential mortgage.
    /// Encoded/decoded by serializers as &quot;RMBS&quot;.
    /// </summary>
    [EnumMember(Value = "RMBS")]
    [IsoId("_hbIesGliEeGaMcKyqKNRfQ_115286996")]
    [Description(@"Sub structured type of the financial instrument is a residential mortgage.")]
    ResidentialMortgage,

    /// <summary>
    /// Sub structured type of the financial instrument is a structured covered bond.
    /// Encoded/decoded by serializers as &quot;SCBO&quot;.
    /// </summary>
    [EnumMember(Value = "SCBO")]
    [IsoId("_hbIesWliEeGaMcKyqKNRfQ_-1056026648")]
    [Description(@"Sub structured type of the financial instrument is a structured covered bond.")]
    StructuredCoveredBond,

    /// <summary>
    /// Sub structured type of the financial instrument is a straight bond.
    /// Encoded/decoded by serializers as &quot;STRB&quot;.
    /// </summary>
    [EnumMember(Value = "STRB")]
    [IsoId("_hbIesmliEeGaMcKyqKNRfQ_-1821240421")]
    [Description(@"Sub structured type of the financial instrument is a straight bond.")]
    StraightBond,

    /// <summary>
    /// Sub structured type of the financial instrument is a student loan trust.
    /// Encoded/decoded by serializers as &quot;STUT&quot;.
    /// </summary>
    [EnumMember(Value = "STUT")]
    [IsoId("_hbIes2liEeGaMcKyqKNRfQ_729495071")]
    [Description(@"Sub structured type of the financial instrument is a student loan trust.")]
    StudentLoanTrust,

    /// <summary>
    /// Sub structured type of the financial instrument is a whole business security.
    /// Encoded/decoded by serializers as &quot;WBSE&quot;.
    /// </summary>
    [EnumMember(Value = "WBSE")]
    [IsoId("_hbIetGliEeGaMcKyqKNRfQ_-198092394")]
    [Description(@"Sub structured type of the financial instrument is a whole business security.")]
    WholeBusinessSecurity,
}
