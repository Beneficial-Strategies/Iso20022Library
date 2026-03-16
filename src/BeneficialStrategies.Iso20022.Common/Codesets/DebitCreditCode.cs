// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is an increase or a decrease.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ieq6AFlcEeGqx4xQw6z6Ug_-1712839316")]
[Description(@"Specifies if an operation is an increase or a decrease.")]
public enum DebitCreditCode
{
    /// <summary>
    /// Operation is an increase.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_Ieq6AVlcEeGqx4xQw6z6Ug_-1358749425")]
    [Description(@"Operation is an increase.")]
    Credit,

    /// <summary>
    /// Operation is a decrease.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_Ieq6AllcEeGqx4xQw6z6Ug_-1371089833")]
    [Description(@"Operation is a decrease.")]
    Debit,
}
