// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the methodology used for a transparency operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EjDNwHvuEeanCNPcMT7sSg")]
[Description(@"Specifies the methodology used for a transparency operation.")]
[DerivedFrom(typeof(TransparencyMethodologyCode))]
public enum TransparencyMethodology2Code
{
    /// <summary>
    /// Calculation based on yearly cycle.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_IUk-oXvuEeanCNPcMT7sSg")]
    [Description(@"Calculation based on yearly cycle.")]
    Year = TransparencyMethodologyCode.Year, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Results of calculations supporting Systematic Internaliser regime.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_IYpmUXvuEeanCNPcMT7sSg")]
    [Description(@"Results of calculations supporting Systematic Internaliser regime.")]
    SystematicInternaliser = TransparencyMethodologyCode.SystematicInternaliser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Calculation based on first Four Weeks of Trading for Equity Instruments.
    /// Encoded/decoded by serializers as &quot;FFWK&quot;.
    /// </summary>
    [EnumMember(Value = "FFWK")]
    [IsoId("_IcsY0XvuEeanCNPcMT7sSg")]
    [Description(@"Calculation based on first Four Weeks of Trading for Equity Instruments.")]
    FirstFourWeeks = TransparencyMethodologyCode.FirstFourWeeks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Estimation for New Equity Instruments.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_IgesoXvuEeanCNPcMT7sSg")]
    [Description(@"Estimation for New Equity Instruments.")]
    Estimated = TransparencyMethodologyCode.Estimated, // same ordinal as derivation source for type conversions
    
}
