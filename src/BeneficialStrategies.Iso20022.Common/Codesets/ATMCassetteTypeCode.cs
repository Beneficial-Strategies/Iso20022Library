// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W-ddQIqfEeS4a4abTJTSSw")]
[Description(@"Type of cassette.")]
[Derivations(typeof(ATMCassetteType1Code))]
public enum ATMCassetteTypeCode
{
    /// <summary>
    /// Cassette for deposits.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_ZQDFYIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for deposits.")]
    In,
    
    /// <summary>
    /// Cassette for dispense.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_cvkgQIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for dispense.")]
    Out,
    
    /// <summary>
    /// Cassette for recycling.
    /// Encoded/decoded by serializers as &quot;RCYC&quot;.
    /// </summary>
    [EnumMember(Value = "RCYC")]
    [IsoId("_fI5vIIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for recycling.")]
    Recycling,
    
    /// <summary>
    /// Cassette for replenishment.
    /// Encoded/decoded by serializers as &quot;RPLT&quot;.
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_hhCrMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for replenishment.")]
    Replenishment,
    
    /// <summary>
    /// Cassette for reject.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_kgFPMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for reject.")]
    Reject,
    
    /// <summary>
    /// Cassette for retract.
    /// Encoded/decoded by serializers as &quot;RTRC&quot;.
    /// </summary>
    [EnumMember(Value = "RTRC")]
    [IsoId("_nSTfMIqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for retract.")]
    Retract,
    
}
