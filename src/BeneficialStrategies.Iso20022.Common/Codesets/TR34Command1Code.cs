// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specific TR34 command that the ATM could perform.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_M5BZgF2jEeekzJIz1JxYSQ")]
[Description(@"Specific TR34 command that the ATM could perform.")]
[DerivedFrom(typeof(TR34CommandCode))]
public enum TR34Command1Code
{
    /// <summary>
    /// TR34 bind operation.
    /// Encoded/decoded by serializers as &quot;BIND&quot;.
    /// </summary>
    [EnumMember(Value = "BIND")]
    [IsoId("_KalWQV2lEeekzJIz1JxYSQ")]
    [Description(@"TR34 bind operation.")]
    Bind = TR34CommandCode.Bind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TR34 Higher Level rebind operation.
    /// Encoded/decoded by serializers as &quot;HILR&quot;.
    /// </summary>
    [EnumMember(Value = "HILR")]
    [IsoId("_KfcoIV2lEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level rebind operation.")]
    HigherLevelRebind = TR34CommandCode.HigherLevelRebind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TR34 Higher Level unbind operation.
    /// Encoded/decoded by serializers as &quot;HILU&quot;.
    /// </summary>
    [EnumMember(Value = "HILU")]
    [IsoId("_KiyQAV2lEeekzJIz1JxYSQ")]
    [Description(@"TR34 Higher Level unbind operation.")]
    HigherLevelUnbind = TR34CommandCode.HigherLevelUnbind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TR34 rebind operation.
    /// Encoded/decoded by serializers as &quot;RBND&quot;.
    /// </summary>
    [EnumMember(Value = "RBND")]
    [IsoId("_KndUoV2lEeekzJIz1JxYSQ")]
    [Description(@"TR34 rebind operation.")]
    Rebind = TR34CommandCode.Rebind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TR34 unbind operation.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_KsIZQV2lEeekzJIz1JxYSQ")]
    [Description(@"TR34 unbind operation.")]
    Unbind = TR34CommandCode.Unbind, // same ordinal as derivation source for type conversions
}
