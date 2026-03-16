// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action taken as a disposition of a reported card payment fraud.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ui-W4HdmEeeKH6vrEwvLHA")]
[Description(@"Type of action taken as a disposition of a reported card payment fraud.")]
[DerivedFrom(typeof(ActionTakenCode))]
public enum ActionTaken1Code
{
    /// <summary>
    /// Reported fraud was accepted
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_ykWhoXdmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted")]
    Accepted = ActionTakenCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported fraud led to actions defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_yzE6IndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at national level.")]
    OtherNational = ActionTakenCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported fraud led to actions defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_y8mpkndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud led to actions defined at private level.")]
    OtherPrivate = ActionTakenCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported fraud was rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_zNj2sndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was rejected.")]
    Rejected = ActionTakenCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported fraud was accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_zZUawndmEeeKH6vrEwvLHA")]
    [Description(@"Reported fraud was accepted with warnings.")]
    Warning = ActionTakenCode.Warning, // same ordinal as derivation source for type conversions
}
