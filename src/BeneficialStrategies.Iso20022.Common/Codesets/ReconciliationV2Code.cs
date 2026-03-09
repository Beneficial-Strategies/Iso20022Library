// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FZQwYHhCEeu3kecHd7QKUQ")]
[Description(@"Specifies the process type used for the trade repository reconciliation.")]
[Derivations(typeof(Reconciliation2Code))]
public enum ReconciliationV2Code
{
    /// <summary>
    /// Trade was not required to be submitted for reconciliation.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_FZQwYnhCEeu3kecHd7QKUQ")]
    [Description(@"Trade was not required to be submitted for reconciliation.")]
    NotSubmittedToReconciliation,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.
    /// Encoded/decoded by serializers as &quot;SSUN&quot;.
    /// </summary>
    [EnumMember(Value = "SSUN")]
    [IsoId("_FZQwZHhCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.")]
    SingleSidedDomesticUnpaired,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_FZQwY3hCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.")]
    SingleSidedDomesticPaired,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.
    /// Encoded/decoded by serializers as &quot;SSMA&quot;.
    /// </summary>
    [EnumMember(Value = "SSMA")]
    [IsoId("_FZQwZnhCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.")]
    SingleSidedDomesticMatched,
    
    /// <summary>
    /// Trade repository has both sides of the trade reported but not all fields match.
    /// Encoded/decoded by serializers as &quot;DSNM&quot;.
    /// </summary>
    [EnumMember(Value = "DSNM")]
    [IsoId("_FZQwZ3hCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has both sides of the trade reported but not all fields match.")]
    DualSidedNonMatched,
    
    /// <summary>
    /// Trade repository has both sides of the trade reported and all fields match.
    /// Encoded/decoded by serializers as &quot;DSMA&quot;.
    /// </summary>
    [EnumMember(Value = "DSMA")]
    [IsoId("_FZQwZXhCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has both sides of the trade reported and all fields match.")]
    DualSidedMatched,
    
    /// <summary>
    /// Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.
    /// Encoded/decoded by serializers as &quot;SSNE&quot;.
    /// </summary>
    [EnumMember(Value = "SSNE")]
    [IsoId("_FZQwYXhCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.")]
    SingleSidedForeign,
    
}
