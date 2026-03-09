// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the reconciliation category
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tJKXo8yrEeiqqJhU2tqK8A")]
[Description(@"Contains the reconciliation category")]
[Derivations(typeof(ReconciliationCategory1Code))]
public enum ReconciliationCategoryCode
{
    /// <summary>
    /// Reconciliation category is financial.
    /// Encoded/decoded by serializers as &quot;FNCL&quot;.
    /// </summary>
    [EnumMember(Value = "FNCL")]
    [IsoId("_tJKXpcyrEeiqqJhU2tqK8A")]
    [Description(@"Reconciliation category is financial.")]
    Financial,
    
    /// <summary>
    /// Reconciliation category is reversal.
    /// Encoded/decoded by serializers as &quot;RVSL&quot;.
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_tJKXpMyrEeiqqJhU2tqK8A")]
    [Description(@"Reconciliation category is reversal.")]
    Reversal,
    
    /// <summary>
    /// Reconciliation category is a chargeback.
    /// Encoded/decoded by serializers as &quot;CGBK&quot;.
    /// </summary>
    [EnumMember(Value = "CGBK")]
    [IsoId("_RAve8MysEeiqqJhU2tqK8A")]
    [Description(@"Reconciliation category is a chargeback.")]
    Chargeback,
    
    /// <summary>
    /// Reconciliation category is other national.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Zq06MMysEeiqqJhU2tqK8A")]
    [Description(@"Reconciliation category is other national.")]
    OtherNational,
    
    /// <summary>
    /// Reconciliation category is other private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cd3CgMysEeiqqJhU2tqK8A")]
    [Description(@"Reconciliation category is other private")]
    OtherPrivate,
    
}
