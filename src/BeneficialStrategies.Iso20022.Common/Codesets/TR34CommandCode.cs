// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specific TR34 command that the ATM could perform.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hWYrAF2iEeekzJIz1JxYSQ")]
[Description(@"Specific TR34 command that the ATM could perform.")]
[Derivations(typeof(TR34Command1Code))]
public enum TR34CommandCode
{
    /// <summary>
    /// TR34 bind operation.
    /// Encoded/decoded by serializers as &quot;BIND&quot;.
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_0VRW4F2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 bind operation.")]
    Bind,
    
    /// <summary>
    /// TR34 unbind operation.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_3d7J4F2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 unbind operation.")]
    Unbind,
    
    /// <summary>
    /// TR34 rebind operation.
    /// Encoded/decoded by serializers as &quot;RBND&quot;.
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_6ZOdYF2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 rebind operation.")]
    Rebind,
    
    /// <summary>
    /// TR34 Higher Level unbind operation.
    /// Encoded/decoded by serializers as &quot;HILU&quot;.
    /// </summary>
    [EnumMember(Value = "HILU")]
    [IsoId("_9VGYoF2iEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level unbind operation.")]
    HigherLevelUnbind,
    
    /// <summary>
    /// TR34 Higher Level rebind operation.
    /// Encoded/decoded by serializers as &quot;HILR&quot;.
    /// </summary>
    [EnumMember(Value = "HILR")]
    [IsoId("_B_ymIF2jEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level rebind operation.")]
    HigherLevelRebind,
    
}
