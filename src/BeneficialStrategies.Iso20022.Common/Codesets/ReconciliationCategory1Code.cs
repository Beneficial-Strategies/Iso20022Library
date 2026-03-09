// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation category.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z1GFgC7NEemIy6A-26wnAg")]
[Description(@"Contains the reconciliation category.")]
[DerivedFrom(typeof(ReconciliationCategoryCode))]
public enum ReconciliationCategory1Code
{
    /// <summary>
    /// Reconciliation category is reversal.
    /// Encoded/decoded by serializers as &quot;RVSL&quot;.
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_cav5IS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is reversal.")]
    Reversal = ReconciliationCategoryCode.Reversal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation category is other private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cfaWsS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is other private")]
    OtherPrivate = ReconciliationCategoryCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation category is other national.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_cjOfsS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is other national.")]
    OtherNational = ReconciliationCategoryCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation category is financial.
    /// Encoded/decoded by serializers as &quot;FNCL&quot;.
    /// </summary>
    [EnumMember(Value = "FNCL")]
    [IsoId("_cquO0S7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is financial.")]
    Financial = ReconciliationCategoryCode.Financial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reconciliation category is a chargeback.
    /// Encoded/decoded by serializers as &quot;CGBK&quot;.
    /// </summary>
    [EnumMember(Value = "CGBK")]
    [IsoId("_cu_DwS7NEemIy6A-26wnAg")]
    [Description(@"Reconciliation category is a chargeback.")]
    Chargeback = ReconciliationCategoryCode.Chargeback, // same ordinal as derivation source for type conversions
    
}
