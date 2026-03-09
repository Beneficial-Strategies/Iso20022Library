// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw8U8FBUEe2v8Nk6ybN7jA")]
[Description(@"Specifies the process type used for the trade repository reconciliation.")]
[DerivedFrom(typeof(ReconciliationCode))]
public enum Reconciliation3Code
{
    /// <summary>
    /// Trade repository has both sides of the trade reported but fields are not valuation reconciled.
    /// Encoded/decoded by serializers as &quot;DPRW&quot;.
    /// </summary>
    [EnumMember(Value = "DPRW")]
    [IsoId("_chTjwVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has both sides of the trade reported but fields are not valuation reconciled.")]
    DualSidedEEAPartiallyReconciledNoValuationReconciliation = ReconciliationCode.DualSidedEEAPartiallyReconciledNoValuationReconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has both sides of the trade reported but fields are valuation reconciled only.
    /// Encoded/decoded by serializers as &quot;DPRV&quot;.
    /// </summary>
    [EnumMember(Value = "DPRV")]
    [IsoId("_ckmvYVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has both sides of the trade reported but fields are valuation reconciled only.")]
    DualSidedEEAPartiallyReconciledValuationReconciliationOnly = ReconciliationCode.DualSidedEEAPartiallyReconciledValuationReconciliationOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has both sides of the trade reported and all fields match.
    /// Encoded/decoded by serializers as &quot;DSMA&quot;.
    /// </summary>
    [EnumMember(Value = "DSMA")]
    [IsoId("_cn8XQVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has both sides of the trade reported and all fields match.")]
    DualSidedMatched = ReconciliationCode.DualSidedMatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has both sides of the trade reported but not all fields match.
    /// Encoded/decoded by serializers as &quot;DSNM&quot;.
    /// </summary>
    [EnumMember(Value = "DSNM")]
    [IsoId("_crFx4VBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has both sides of the trade reported but not all fields match.")]
    DualSidedNonMatched = ReconciliationCode.DualSidedNonMatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade was not required to be submitted for reconciliation.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_cuiugVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade was not required to be submitted for reconciliation.")]
    NotSubmittedToReconciliation = ReconciliationCode.NotSubmittedToReconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.
    /// Encoded/decoded by serializers as &quot;SSMA&quot;.
    /// </summary>
    [EnumMember(Value = "SSMA")]
    [IsoId("_cz8L4VBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.")]
    SingleSidedEEAMatched = ReconciliationCode.SingleSidedEEAMatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_c2xdcVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.")]
    SingleSidedEEAPaired = ReconciliationCode.SingleSidedEEAPaired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, but fields are not valuation reconciled.
    /// Encoded/decoded by serializers as &quot;SPRW&quot;.
    /// </summary>
    [EnumMember(Value = "SPRW")]
    [IsoId("_c_KkcVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, but fields are not valuation reconciled.")]
    SingleSidedEEAPartiallyReconciledNoValuationReconciliation = ReconciliationCode.SingleSidedEEAPartiallyReconciledNoValuationReconciliation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, but fields are valuation reconciled only.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_dCPtoVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, but fields are valuation reconciled only.")]
    SingleSidedEEAPartiallyReconciledValuationReconciliationOnly = ReconciliationCode.SingleSidedEEAPartiallyReconciledValuationReconciliationOnly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.
    /// Encoded/decoded by serializers as &quot;SSUN&quot;.
    /// </summary>
    [EnumMember(Value = "SSUN")]
    [IsoId("_dFnxwVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.")]
    SingleSidedEEAUnpaired = ReconciliationCode.SingleSidedEEAUnpaired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.
    /// Encoded/decoded by serializers as &quot;SSNE&quot;.
    /// </summary>
    [EnumMember(Value = "SSNE")]
    [IsoId("_dI-nwVBUEe2v8Nk6ybN7jA")]
    [Description(@"Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.")]
    SingleSidedNonEEA = ReconciliationCode.SingleSidedNonEEA, // same ordinal as derivation source for type conversions
    
}
