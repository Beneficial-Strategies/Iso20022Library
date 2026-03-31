// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reconciliation credit or debit indicator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-kRtwC7OEemIy6A-26wnAg")]
[Description(@"Reconciliation credit or debit indicator.")]
[DerivedFrom(typeof(ReconciliationImpactCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReconciliationImpact1Code>))]
#endif
public enum ReconciliationImpact1Code
{
    /// <summary>
    /// Debit category
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("__1Z-cS7OEemIy6A-26wnAg")]
    [Description(@"Debit category")]
    Debit = ReconciliationImpactCode.Debit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit category
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("__5E9gS7OEemIy6A-26wnAg")]
    [Description(@"Credit category")]
    Credit = ReconciliationImpactCode.Credit, // same ordinal as derivation source for type conversions
}
