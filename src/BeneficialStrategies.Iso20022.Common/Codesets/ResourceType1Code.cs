// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of resource.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8wnVAC8CEeu125Ip9zFcsQ")]
[Description(@"Type of resource.")]
[DerivedFrom(typeof(ResourceTypeCode))]
public enum ResourceType1Code
{
    /// <summary>
    /// Voice synthesis.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_-HF_wS8CEeu125Ip9zFcsQ")]
    [Description(@"Voice synthesis.")]
    TextToSpeech = ResourceTypeCode.TextToSpeech, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// String of characters that unambiguously identifies a particular resource.
    /// Encoded/decoded by serializers as &quot;URLI&quot;.
    /// </summary>
    [EnumMember(Value = "URLI")]
    [IsoId("_-K6v0S8CEeu125Ip9zFcsQ")]
    [Description(@"String of characters that unambiguously identifies a particular resource.")]
    UniformResourceIdentifier = ResourceTypeCode.UniformResourceIdentifier, // same ordinal as derivation source for type conversions
    
}
