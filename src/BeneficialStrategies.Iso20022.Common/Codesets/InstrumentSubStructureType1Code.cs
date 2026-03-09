// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of deal for structured finance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hbSPoGliEeGaMcKyqKNRfQ_2045189258")]
[Description(@"Indicates the type of deal for structured finance.")]
[DerivedFrom(typeof(InstrumentSubStructureTypeCode))]
public enum InstrumentSubStructureType1Code
{
    /// <summary>
    /// Sub structured type of the financial instrument is an asset backed security.
    /// Encoded/decoded by serializers as &quot;ABSE&quot;.
    /// </summary>
    [EnumMember(Value = "ABSE")]
    [IsoId("_hbSPoWliEeGaMcKyqKNRfQ_-1602851951")]
    [Description(@"Sub structured type of the financial instrument is an asset backed security.")]
    AssetBackedSecurity = InstrumentSubStructureTypeCode.AssetBackedSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is an airline trust.
    /// Encoded/decoded by serializers as &quot;AIRT&quot;.
    /// </summary>
    [EnumMember(Value = "AIRT")]
    [IsoId("_hbSPomliEeGaMcKyqKNRfQ_-1552631371")]
    [Description(@"Sub structured type of the financial instrument is an airline trust.")]
    AirlineTrust = InstrumentSubStructureTypeCode.AirlineTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is an auto trust.
    /// Encoded/decoded by serializers as &quot;AUTT&quot;.
    /// </summary>
    [EnumMember(Value = "AUTT")]
    [IsoId("_hbSPo2liEeGaMcKyqKNRfQ_-791866218")]
    [Description(@"Sub structured type of the financial instrument is an auto trust.")]
    AutoTrust = InstrumentSubStructureTypeCode.AutoTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a collateral bond obligation.
    /// Encoded/decoded by serializers as &quot;CBOB&quot;.
    /// </summary>
    [EnumMember(Value = "CBOB")]
    [IsoId("_hbSPpGliEeGaMcKyqKNRfQ_675282545")]
    [Description(@"Sub structured type of the financial instrument is a collateral bond obligation.")]
    CollateralBondObligation = InstrumentSubStructureTypeCode.CollateralBondObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a collateral debt obligation.
    /// Encoded/decoded by serializers as &quot;CDOB&quot;.
    /// </summary>
    [EnumMember(Value = "CDOB")]
    [IsoId("_hbSPpWliEeGaMcKyqKNRfQ_-1109642879")]
    [Description(@"Sub structured type of the financial instrument is a collateral debt obligation.")]
    CollateralDebtObligation = InstrumentSubStructureTypeCode.CollateralDebtObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub-structured type of the financial instrument is a credit linked note.
    /// Encoded/decoded by serializers as &quot;CLNO&quot;.
    /// </summary>
    [EnumMember(Value = "CLNO")]
    [IsoId("_hbSPpmliEeGaMcKyqKNRfQ_357505884")]
    [Description(@"Sub-structured type of the financial instrument is a credit linked note.")]
    CreditLinkedNotes = InstrumentSubStructureTypeCode.CreditLinkedNotes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a collateral loan obligation.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_hbSPp2liEeGaMcKyqKNRfQ_248168077")]
    [Description(@"Sub structured type of the financial instrument is a collateral loan obligation.")]
    CollateralLoanObligation = InstrumentSubStructureTypeCode.CollateralLoanObligation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a commercial mortgage.
    /// Encoded/decoded by serializers as &quot;CMBS&quot;.
    /// </summary>
    [EnumMember(Value = "CMBS")]
    [IsoId("_hbSPqGliEeGaMcKyqKNRfQ_1715316840")]
    [Description(@"Sub structured type of the financial instrument is a commercial mortgage.")]
    CommercialMortgage = InstrumentSubStructureTypeCode.CommercialMortgage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a consumer.
    /// Encoded/decoded by serializers as &quot;CSMR&quot;.
    /// </summary>
    [EnumMember(Value = "CSMR")]
    [IsoId("_hbSPqWliEeGaMcKyqKNRfQ_1128715103")]
    [Description(@"Sub structured type of the financial instrument is a consumer.")]
    Consumer = InstrumentSubStructureTypeCode.Consumer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a credit card trust.
    /// Encoded/decoded by serializers as &quot;CRCT&quot;.
    /// </summary>
    [EnumMember(Value = "CRCT")]
    [IsoId("_hbSPqmliEeGaMcKyqKNRfQ_-1141613643")]
    [Description(@"Sub structured type of the financial instrument is a credit card trust.")]
    CreditCardTrust = InstrumentSubStructureTypeCode.CreditCardTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a home equity loan.
    /// Encoded/decoded by serializers as &quot;HELO&quot;.
    /// </summary>
    [EnumMember(Value = "HELO")]
    [IsoId("_hbSPq2liEeGaMcKyqKNRfQ_325535120")]
    [Description(@"Sub structured type of the financial instrument is a home equity loan.")]
    HomeEquityLoans = InstrumentSubStructureTypeCode.HomeEquityLoans, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a loan participation notes.
    /// Encoded/decoded by serializers as &quot;LPNO&quot;.
    /// </summary>
    [EnumMember(Value = "LPNO")]
    [IsoId("_hbSPrGliEeGaMcKyqKNRfQ_-816496136")]
    [Description(@"Sub structured type of the financial instrument is a loan participation notes.")]
    LoanParticipationNote = InstrumentSubStructureTypeCode.LoanParticipationNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a covered bond.
    /// Encoded/decoded by serializers as &quot;PFAB&quot;.
    /// </summary>
    [EnumMember(Value = "PFAB")]
    [IsoId("_hbSPrWliEeGaMcKyqKNRfQ_650652627")]
    [Description(@"Sub structured type of the financial instrument is a covered bond.")]
    CoveredBond = InstrumentSubStructureTypeCode.CoveredBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a payment right.
    /// Encoded/decoded by serializers as &quot;PYRT&quot;.
    /// </summary>
    [EnumMember(Value = "PYRT")]
    [IsoId("_hbSPrmliEeGaMcKyqKNRfQ_2103546148")]
    [Description(@"Sub structured type of the financial instrument is a payment right.")]
    PaymentRight = InstrumentSubStructureTypeCode.PaymentRight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a repackaging.
    /// Encoded/decoded by serializers as &quot;REPK&quot;.
    /// </summary>
    [EnumMember(Value = "REPK")]
    [IsoId("_hbSPr2liEeGaMcKyqKNRfQ_1468514302")]
    [Description(@"Sub structured type of the financial instrument is a repackaging.")]
    Repackagings = InstrumentSubStructureTypeCode.Repackagings, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a residential mortgage.
    /// Encoded/decoded by serializers as &quot;RMBS&quot;.
    /// </summary>
    [EnumMember(Value = "RMBS")]
    [IsoId("_hbSPsGliEeGaMcKyqKNRfQ_-1359304231")]
    [Description(@"Sub structured type of the financial instrument is a residential mortgage.")]
    ResidentialMortgage = InstrumentSubStructureTypeCode.ResidentialMortgage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a structured covered bond.
    /// Encoded/decoded by serializers as &quot;SCBO&quot;.
    /// </summary>
    [EnumMember(Value = "SCBO")]
    [IsoId("_hbSPsWliEeGaMcKyqKNRfQ_-1748432656")]
    [Description(@"Sub structured type of the financial instrument is a structured covered bond.")]
    StructuredCoveredBond = InstrumentSubStructureTypeCode.StructuredCoveredBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a straight bond.
    /// Encoded/decoded by serializers as &quot;STRB&quot;.
    /// </summary>
    [EnumMember(Value = "STRB")]
    [IsoId("_hbSPsmliEeGaMcKyqKNRfQ_-281283893")]
    [Description(@"Sub structured type of the financial instrument is a straight bond.")]
    StraightBond = InstrumentSubStructureTypeCode.StraightBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a student loan trust.
    /// Encoded/decoded by serializers as &quot;STUT&quot;.
    /// </summary>
    [EnumMember(Value = "STUT")]
    [IsoId("_hbSPs2liEeGaMcKyqKNRfQ_-697299584")]
    [Description(@"Sub structured type of the financial instrument is a student loan trust.")]
    StudentLoanTrust = InstrumentSubStructureTypeCode.StudentLoanTrust, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub structured type of the financial instrument is a whole business security.
    /// Encoded/decoded by serializers as &quot;WBSE&quot;.
    /// </summary>
    [EnumMember(Value = "WBSE")]
    [IsoId("_hbSPtGliEeGaMcKyqKNRfQ_769849179")]
    [Description(@"Sub structured type of the financial instrument is a whole business security.")]
    WholeBusinessSecurity = InstrumentSubStructureTypeCode.WholeBusinessSecurity, // same ordinal as derivation source for type conversions
    
}
