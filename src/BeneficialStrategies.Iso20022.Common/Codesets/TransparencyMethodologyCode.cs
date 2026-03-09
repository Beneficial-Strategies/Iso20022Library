// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the methodology used for a transparency operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j4SNANQCEeWBZtcpHyzahg")]
[Description(@"Specifies the methodology used for a transparency operation.")]
[Derivations(typeof(TransparencyMethodology2Code))]
public enum TransparencyMethodologyCode
{
    /// <summary>
    /// Estimation for New Equity Instruments.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_p58NcNQCEeWBZtcpHyzahg")]
    [Description(@"Estimation for New Equity Instruments.")]
    Estimated,
    
    /// <summary>
    /// Calculation based on first Four Weeks of Trading for Equity Instruments.
    /// Encoded/decoded by serializers as &quot;FFWK&quot;.
    /// </summary>
    [EnumMember(Value = "FFWK")]
    [IsoId("_rVzugNQCEeWBZtcpHyzahg")]
    [Description(@"Calculation based on first Four Weeks of Trading for Equity Instruments.")]
    FirstFourWeeks,
    
    /// <summary>
    /// Calculation based on yearly cycle.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_tAZoENQCEeWBZtcpHyzahg")]
    [Description(@"Calculation based on yearly cycle.")]
    Year,
    
    /// <summary>
    /// Results of calculations supporting Systematic Internaliser regime.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_UE7csHvtEeanCNPcMT7sSg")]
    [Description(@"Results of calculations supporting Systematic Internaliser regime.")]
    SystematicInternaliser,
    
}
