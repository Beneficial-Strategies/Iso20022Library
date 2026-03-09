// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the energy delivery profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uODncBVnEeWXLoZC9OIRgg")]
[Description(@"Specifies the energy delivery profile.")]
[Derivations(typeof(EnergyLoadType1Code))]
public enum EnergyLoadTypeCode
{
    /// <summary>
    /// Off-Peak.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_0JbZsBVnEeWXLoZC9OIRgg")]
    [Description(@"Off-Peak.|")]
    Off_Peak,
    
    /// <summary>
    /// Hour and block hours.
    /// Encoded/decoded by serializers as &quot;HABH&quot;.
    /// </summary>
    [EnumMember(Value = "HABH")]
    [IsoId("_0NmIABVnEeWXLoZC9OIRgg")]
    [Description(@"Hour and block hours.")]
    HourAndBlockHours,
    
    /// <summary>
    /// Shaped.
    /// Encoded/decoded by serializers as &quot;SHPD&quot;.
    /// </summary>
    [EnumMember(Value = "SHPD")]
    [IsoId("_0Rw2UBVnEeWXLoZC9OIRgg")]
    [Description(@"Shaped.")]
    Shaped,
    
    /// <summary>
    /// Gas day.
    /// Encoded/decoded by serializers as &quot;GASD&quot;.
    /// </summary>
    [EnumMember(Value = "GASD")]
    [IsoId("_0Rw2URVnEeWXLoZC9OIRgg")]
    [Description(@"Gas day.")]
    GasDay,
    
    /// <summary>
    /// Base load.
    /// Encoded/decoded by serializers as &quot;BSLD&quot;.
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_EmqBIhVoEeWXLoZC9OIRgg")]
    [Description(@"Base load.")]
    BaseLoad,
    
    /// <summary>
    /// Peak load.
    /// Encoded/decoded by serializers as &quot;PKLD&quot;.
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_EmqBIxVoEeWXLoZC9OIRgg")]
    [Description(@"Peak load.")]
    PeakLoad,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jP73kBVoEeWXLoZC9OIRgg")]
    [Description(@"Other.")]
    Other,
    
}
