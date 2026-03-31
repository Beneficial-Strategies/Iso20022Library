// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_saUqED2yEeGXQ7zxoAIFpQ")]
[Description(@"Specifies the status of the response.")]
[DerivedFrom(typeof(StatusResponseCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StatusResponse1Code>))]
#endif
public enum StatusResponse1Code
{
    /// <summary>
    /// Response not provided yet.
    /// Encoded/decoded by serializers as &quot;NRES&quot;.
    /// </summary>
    [EnumMember(Value = "NRES")]
    [IsoId("_tNlTBj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response not provided yet.")]
    NoResponseYet = StatusResponseCode.NoResponseYet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response is partially provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_tTP2Jj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is partially provided.")]
    PartialResponse = StatusResponseCode.PartialResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_tZXFNj2yEeGXQ7zxoAIFpQ")]
    [Description(@"Response is complete.")]
    CompleteResponse = StatusResponseCode.CompleteResponse, // same ordinal as derivation source for type conversions
}
