// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action taken as a disposition of a reported card payment fraud. P000-P999 reserved for private use, Z000-Z999 reserved for national use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpPT4RNSEfC1ZfCQz0xB3g")]
[Description(@"Type of action taken as a disposition of a reported card payment fraud. P000-P999 reserved for private use, Z000-Z999 reserved for national use.")]
[DerivedFrom(typeof(ActionTakenCode))]
public enum ActionTaken2Code
{
    /// <summary>
    /// Reported fraud was accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_VwiOsRNSEfC1ZfCQz0xB3g")]
    [Description(@"Reported fraud was accepted.")]
    Accepted = ActionTakenCode.Accepted,

    /// <summary>
    /// Reported fraud was rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_VwiOtxNSEfC1ZfCQz0xB3g")]
    [Description(@"Reported fraud was rejected.")]
    Rejected = ActionTakenCode.Rejected,

    /// <summary>
    /// Reported fraud was accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_VwiOuRNSEfC1ZfCQz0xB3g")]
    [Description(@"Reported fraud was accepted with warnings.")]
    Warning = ActionTakenCode.Warning,
}
