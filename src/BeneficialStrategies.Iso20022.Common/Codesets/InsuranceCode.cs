// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of insurance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gQ8SUxQaEeKebsB9eKJSkA")]
[Description(@"Specifies the type of insurance.")]
[Derivations(typeof(Insurance1Code))]
public enum InsuranceCode
{
    /// <summary>
    /// Life insurance.
    /// Encoded/decoded by serializers as &quot;LIFE&quot;.
    /// </summary>
    [EnumMember(Value = "LIFE")]
    [IsoId("_qztGcBQaEeKebsB9eKJSkA")]
    [Description(@"Life insurance.")]
    LifeInsurance,

    /// <summary>
    /// Permanent disability insurance.
    /// Encoded/decoded by serializers as &quot;PDIS&quot;.
    /// </summary>
    [EnumMember(Value = "PDIS")]
    [IsoId("_q9Fr8BQaEeKebsB9eKJSkA")]
    [Description(@"Permanent disability insurance.")]
    PermanentDisabilityInsurance,
}
