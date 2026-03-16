// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the calculation method to be used to caculate on which dates the shares have been acquired.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oGUJ5lSUEempisJfoIfvvQ")]
[Description(
    @"Indicates the calculation method to be used to caculate on which dates the shares have been acquired."
)]
[Derivations(typeof(DateCalculationMethod1Code))]
public enum DateCalculationMethodCode
{
    /// <summary>
    /// First in, first out.
    /// Encoded/decoded by serializers as &quot;FIFO&quot;.
    /// </summary>
    [EnumMember(Value = "FIFO")]
    [IsoId("_oGUJ51SUEempisJfoIfvvQ")]
    [Description(@"First in, first out. ")]
    Fifo,

    /// <summary>
    /// Last in, first out.
    /// Encoded/decoded by serializers as &quot;LIFO&quot;.
    /// </summary>
    [EnumMember(Value = "LIFO")]
    [IsoId("_oGUJ6FSUEempisJfoIfvvQ")]
    [Description(@"Last in, first out. ")]
    Lifo,
}
