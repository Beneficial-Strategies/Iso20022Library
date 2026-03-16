// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the exercise status of the derivative products.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l2kogCKKEeSbDuI5b0sFEQ")]
[Description(@"Specifies the exercise status of the derivative products.")]
[Derivations(typeof(DerivativeExerciseStatus1Code))]
public enum DerivativeExerciseStatusCode
{
    /// <summary>
    /// Derivative is exercised.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_yRPZcCKKEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is exercised.")]
    Exercised,

    /// <summary>
    /// Derivative is expired and will not be exercised.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_6c1h4CKKEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is expired and will not be exercised.")]
    Expired,

    /// <summary>
    /// Derivative is not exercised.
    /// Encoded/decoded by serializers as &quot;VALI&quot;.
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_W9KHwCKLEeSbDuI5b0sFEQ")]
    [Description(@"Derivative is not exercised.")]
    Valid,
}
