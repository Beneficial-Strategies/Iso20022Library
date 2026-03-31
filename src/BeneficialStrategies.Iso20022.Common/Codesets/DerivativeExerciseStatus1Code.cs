// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the exercise status of the derivative products.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QJkDQIAxEeSUJZYcWGKkkw")]
[Description(@"Specifies the exercise status of the derivative products.")]
[DerivedFrom(typeof(DerivativeExerciseStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DerivativeExerciseStatus1Code>))]
#endif
public enum DerivativeExerciseStatus1Code
{
    /// <summary>
    /// Derivative is exercised.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_ULyikYAxEeSUJZYcWGKkkw")]
    [Description(@"Derivative is exercised.")]
    Exercised = DerivativeExerciseStatusCode.Exercised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Derivative is expired and will not be exercised.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_UQXgkYAxEeSUJZYcWGKkkw")]
    [Description(@"Derivative is expired and will not be exercised.")]
    Expired = DerivativeExerciseStatusCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Derivative is not exercised.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_UU6CUYAxEeSUJZYcWGKkkw")]
    [Description(@"Derivative is not exercised.")]
    Valid = DerivativeExerciseStatusCode.Valid, // same ordinal as derivation source for type conversions
}
