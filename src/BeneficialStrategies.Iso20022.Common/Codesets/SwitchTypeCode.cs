// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RQTCAQ2XEeStB9HSJRk0Qw")]
[Description(@"Specifies the status of the switch either full or part for a given account.")]
[Derivations(typeof(SwitchType1Code))]
public enum SwitchTypeCode
{
    /// <summary>
    /// Indicates a partial switch for an account.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Tt_zgA2XEeStB9HSJRk0Qw")]
    [Description(@"Indicates a partial switch for an account.")]
    PartSwitch,
    
    /// <summary>
    /// Indicates a full switch for an account.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_VwU3oA2XEeStB9HSJRk0Qw")]
    [Description(@"Indicates a full switch for an account.")]
    FullSwitch,
    
}
