// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the non-equity financial instruments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YAQMcPPREeS_qLctCs2aRQ")]
[Description(@"Specifies the non-equity financial instruments.")]
[DerivedFrom(typeof(FinancialInstrumentReportingClassificationCode))]
public enum NonEquityInstrumentReportingClassification1Code
{
    /// <summary>
    /// Contract is of type structured finance products (SFPs).
    /// Encoded/decoded by serializers as &quot;SFPS&quot;.
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_eT4oMfVGEeSKpdoott6G4g")]
    [Description(@"Contract is of type structured finance products (SFPs).")]
    StructuredFinanceProduct = FinancialInstrumentReportingClassificationCode.StructuredFinanceProduct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type securitised derivatives.
    /// Encoded/decoded by serializers as &quot;SDRV&quot;.
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_eZruMfVGEeSKpdoott6G4g")]
    [Description(@"Contract is of type securitised derivatives.")]
    SecuritisedDerivative = FinancialInstrumentReportingClassificationCode.SecuritisedDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type derivative.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_egh9EfVGEeSKpdoott6G4g")]
    [Description(@"Contract is of type derivative.|")]
    Derivative = FinancialInstrumentReportingClassificationCode.Derivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type emission allowances.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_enhV4fVGEeSKpdoott6G4g")]
    [Description(@"Contract is of type emission allowances.")]
    EmissionAllowance = FinancialInstrumentReportingClassificationCode.EmissionAllowance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_e0KqwfVGEeSKpdoott6G4g")]
    [Description(@"Contract is of type bonds.|")]
    Bond = FinancialInstrumentReportingClassificationCode.Bond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type exchange traded commodities.
    /// Encoded/decoded by serializers as &quot;ETCS&quot;.
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_KNPywQnOEeW1sbwBDSZgiA")]
    [Description(@"Contract is of type exchange traded commodities.")]
    ExchangeTradedCommodities = FinancialInstrumentReportingClassificationCode.ExchangeTradedCommodities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract is of type exchange traded note.
    /// Encoded/decoded by serializers as &quot;ETNS&quot;.
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_v3ZaIX1tEeW6DpJJTspC5Q")]
    [Description(@"Contract is of type exchange traded note.")]
    ExchangeTradedNote = FinancialInstrumentReportingClassificationCode.ExchangeTradedNote, // same ordinal as derivation source for type conversions
    
}
