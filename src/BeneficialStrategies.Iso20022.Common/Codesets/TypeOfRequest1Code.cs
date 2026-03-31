// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EuVucNveEeqxGfKJubfhIw")]
[Description(@"Specifies a type of request.")]
[DerivedFrom(typeof(TypeOfRequestCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfRequest1Code>))]
#endif
public enum TypeOfRequest1Code
{
    /// <summary>
    /// Request for information.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_GYj0kdveEeqxGfKJubfhIw")]
    [Description(@"Request for information.")]
    Information = TypeOfRequestCode.Information, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_GhCbIdveEeqxGfKJubfhIw")]
    [Description(@"Request for status.")]
    Status = TypeOfRequestCode.Status, // same ordinal as derivation source for type conversions
}
