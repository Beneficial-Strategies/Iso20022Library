// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Response to a request of service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_40Uz0GqHEeS8RZDTbvnB_A")]
[Description(@"Response to a request of service.")]
[DerivedFrom(typeof(ResponseCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Response2Code>))]
#endif
public enum Response2Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_-2kqIWqHEeS8RZDTbvnB_A")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("__G0Fk2qHEeS8RZDTbvnB_A")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions
}
