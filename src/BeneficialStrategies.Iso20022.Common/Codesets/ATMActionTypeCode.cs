// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action that could be run on a configuration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMActionTypeCode")]
[Description(@"Type of action that could be run on a configuration.")]
public enum ATMActionTypeCode
{
    /// <summary>
    /// The received configuration must be applied.
    /// Encoded/decoded by serializers as &quot;APLY&quot;.
    /// </summary>
    [EnumMember(Value = "APLY")]
    [IsoId("_ATMActionTypeCode_Apply")]
    [Description(@"The received configuration must be applied.")]
    Apply,

    /// <summary>
    /// There is no specific action required with the received configuration.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ATMActionTypeCode_None")]
    [Description(@"There is no specific action required with the received configuration.")]
    None,
}
