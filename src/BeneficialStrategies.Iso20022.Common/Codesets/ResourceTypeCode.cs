// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lu4ewC8CEeu125Ip9zFcsQ")]
[Description(@"Type of resource.")]
[Derivations(typeof(ResourceType1Code))]
public enum ResourceTypeCode
{
    /// <summary>
    /// Voice synthesis.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_togtcC8CEeu125Ip9zFcsQ")]
    [Description(@"Voice synthesis.")]
    TextToSpeech,
    
    /// <summary>
    /// String of characters that unambiguously identifies a particular resource.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_1mAIcC8CEeu125Ip9zFcsQ")]
    [Description(@"String of characters that unambiguously identifies a particular resource.")]
    UniformResourceIdentifier,
    
}
