// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8byFsFNgEeijdq8ilaxyOA")]
[Description(@"Specifies a type of beneficiary.")]
[Derivations(typeof(BeneficiaryType1Code))]
public enum BeneficiaryTypeCode
{
    /// <summary>
    /// Beneficiary is a dependent.
    /// Encoded/decoded by serializers as &quot;DEPE&quot;.
    /// </summary>
    [EnumMember(Value = "DEPE")]
    [IsoId("__reU0FNgEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a dependent.")]
    Dependent,

    /// <summary>
    /// Beneficiary is a nominee.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_GzUhQFNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a nominee.")]
    Nominee,

    /// <summary>
    /// Beneficiary is a successor.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_JziJ8FNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a successor.")]
    Successor,
}
