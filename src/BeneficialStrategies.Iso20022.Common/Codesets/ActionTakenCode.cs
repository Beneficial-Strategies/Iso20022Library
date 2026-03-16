// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action taken as a disposition of a reported card payment fraud.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zpu8sHdjEeeKH6vrEwvLHA")]
[Description(@"Type of action taken as a disposition of a reported card payment fraud.")]
[Derivations(typeof(ActionTaken1Code))]
public enum ActionTakenCode
{
    /// <summary>
    /// Reported fraud was accepted
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_8QpIIHdjEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted")]
    Accepted,

    /// <summary>
    /// Reported fraud was rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Og4TYHdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was rejected.")]
    Rejected,

    /// <summary>
    /// Reported fraud was accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_XWXGUHdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted with warnings.")]
    Warning,

    /// <summary>
    /// Reported fraud led to actions defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_eaCkcHdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at national level.")]
    OtherNational,

    /// <summary>
    /// Reported fraud led to actions defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_nOyXkHdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at private level.")]
    OtherPrivate,
}
