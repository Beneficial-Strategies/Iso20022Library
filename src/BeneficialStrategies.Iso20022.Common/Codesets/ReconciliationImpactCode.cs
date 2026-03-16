// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reconciliation credit or debit indicator
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fGUkscyqEeiqqJhU2tqK8A")]
[Description(@"Reconciliation credit or debit indicator")]
[Derivations(typeof(ReconciliationImpact1Code))]
public enum ReconciliationImpactCode
{
    /// <summary>
    /// Credit category
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_fGhYzsyqEeiqqJhU2tqK8A")]
    [Description(@"Credit category")]
    Credit,

    /// <summary>
    /// Debit category
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_fGVyk8yqEeiqqJhU2tqK8A")]
    [Description(@"Debit category")]
    Debit,
}
