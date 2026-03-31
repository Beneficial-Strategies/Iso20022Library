// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the novation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_joS1IMETEea7jLfvGi1PDw")]
[Description(@"Specifies the status of the novation.")]
[DerivedFrom(typeof(NovationStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NovationStatus1Code>))]
#endif
public enum NovationStatus1Code
{
    /// <summary>
    /// Transaction is not a novation.
    /// Encoded/decoded by serializers as &quot;NONO&quot;.
    /// </summary>
    [EnumMember(Value = "NONO")]
    [IsoId("_k6HCUcETEea7jLfvGi1PDw")]
    [Description(@"Transaction is not a novation.")]
    NoNovation = NovationStatusCode.NoNovation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a novation.
    /// Encoded/decoded by serializers as &quot;NOVA&quot;.
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_lA8qIcETEea7jLfvGi1PDw")]
    [Description(@"Transaction is a novation.")]
    Novation = NovationStatusCode.Novation, // same ordinal as derivation source for type conversions
}
