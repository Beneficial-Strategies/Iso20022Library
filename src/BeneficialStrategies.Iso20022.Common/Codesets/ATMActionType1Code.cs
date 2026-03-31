// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action that could be run on a configuration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMActionType1Code")]
[Description(@"Type of action that could be run on a configuration.")]
[DerivedFrom(typeof(ATMActionTypeCode))]
public enum ATMActionType1Code
{
    /// <summary>
    /// The received configuration must be applied.
    /// Encoded/decoded by serializers as &quot;APLY&quot;.
    /// </summary>
    [EnumMember(Value = "APLY")]
    [IsoId("_ATMActionType1Code_Apply")]
    [Description(@"The received configuration must be applied.")]
    Apply = ATMActionTypeCode.Apply,

    /// <summary>
    /// There is no specific action required with the received configuration.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ATMActionType1Code_None")]
    [Description(@"There is no specific action required with the received configuration.")]
    None = ATMActionTypeCode.None,
}
