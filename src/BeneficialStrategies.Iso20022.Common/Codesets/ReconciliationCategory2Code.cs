// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation category.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y6kfwWP5EfCX7uJiAWHfoQ")]
[Description(@"Contains the reconciliation category.")]
[DerivedFrom(typeof(ReconciliationCategoryCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ReconciliationCategory2Code>))]
public enum ReconciliationCategory2Code
{
    /// <summary>
    /// Reconciliation category is a chargeback.
    /// Encoded/decoded by serializers as &quot;CGBK&quot;.
    /// </summary>
    [EnumMember(Value = "CGBK")]
    [IsoId("_Y9M9CWP5EfCX7uJiAWHfoQ")]
    [Description(@"Reconciliation category is a chargeback.")]
    Chargeback = ReconciliationCategoryCode.Chargeback, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reconciliation category is financial.
    /// Encoded/decoded by serializers as &quot;FNCL&quot;.
    /// </summary>
    [EnumMember(Value = "FNCL")]
    [IsoId("_Y9M9B2P5EfCX7uJiAWHfoQ")]
    [Description(@"Reconciliation category is financial.")]
    Financial = ReconciliationCategoryCode.Financial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reconciliation category is reversal.
    /// Encoded/decoded by serializers as &quot;RVSL&quot;.
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_Y9M9AWP5EfCX7uJiAWHfoQ")]
    [Description(@"Reconciliation category is reversal.")]
    Reversal = ReconciliationCategoryCode.Reversal, // same ordinal as derivation source for type conversions
}
