// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Llp6Iz2yEeGXQ7zxoAIFpQ")]
[Description(@"Specifies the status of the response.")]
[Derivations(typeof(StatusResponse1Code))]
public enum StatusResponseCode
{
    /// <summary>
    /// Response not provided yet.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_Oh2ljT2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response not provided yet.")]
    NoResponseYet,
    
    /// <summary>
    /// Response is partially provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_b9g5bT2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is partially provided.")]
    PartialResponse,
    
    /// <summary>
    /// Response is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ilBY7T2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is complete.")]
    CompleteResponse,
    
}
