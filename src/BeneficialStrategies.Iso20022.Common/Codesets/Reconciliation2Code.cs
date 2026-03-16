// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tquq4HhCEeu3kecHd7QKUQ")]
[Description(@"Specifies the process type used for the trade repository reconciliation.")]
[DerivedFrom(typeof(ReconciliationV2Code))]
public enum Reconciliation2Code
{
    /// <summary>
    /// Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.
    /// Encoded/decoded by serializers as &quot;SSNE&quot;.
    /// </summary>
    [EnumMember(Value = "SSNE")]
    [IsoId("_XplGEXhCEeu3kecHd7QKUQ")]
    [Description(
        @"Trade repository has one side of the trade and knows that the other side does not have a reporting obligation."
    )]
    SingleSidedForeign = ReconciliationV2Code.SingleSidedForeign, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.
    /// Encoded/decoded by serializers as &quot;SSUN&quot;.
    /// </summary>
    [EnumMember(Value = "SSUN")]
    [IsoId("_XxBK0XhCEeu3kecHd7QKUQ")]
    [Description(
        @"Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade."
    )]
    SingleSidedDomesticUnpaired = ReconciliationV2Code.SingleSidedDomesticUnpaired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_X4AjoXhCEeu3kecHd7QKUQ")]
    [Description(
        @"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so."
    )]
    SingleSidedDomesticPaired = ReconciliationV2Code.SingleSidedDomesticPaired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.
    /// Encoded/decoded by serializers as &quot;SSMA&quot;.
    /// </summary>
    [EnumMember(Value = "SSMA")]
    [IsoId("_X_coYXhCEeu3kecHd7QKUQ")]
    [Description(
        @"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process."
    )]
    SingleSidedDomesticMatched = ReconciliationV2Code.SingleSidedDomesticMatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade was not required to be submitted for reconciliation.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_YGJGQXhCEeu3kecHd7QKUQ")]
    [Description(@"Trade was not required to be submitted for reconciliation.")]
    NotSubmittedToReconciliation = ReconciliationV2Code.NotSubmittedToReconciliation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade repository has both sides of the trade reported but not all fields match.
    /// Encoded/decoded by serializers as &quot;DSNM&quot;.
    /// </summary>
    [EnumMember(Value = "DSNM")]
    [IsoId("_YMsaMXhCEeu3kecHd7QKUQ")]
    [Description(
        @"Trade repository has both sides of the trade reported but not all fields match."
    )]
    DualSidedNonMatched = ReconciliationV2Code.DualSidedNonMatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade repository has both sides of the trade reported and all fields match.
    /// Encoded/decoded by serializers as &quot;DSMA&quot;.
    /// </summary>
    [EnumMember(Value = "DSMA")]
    [IsoId("_YVBPwXhCEeu3kecHd7QKUQ")]
    [Description(@"Trade repository has both sides of the trade reported and all fields match.")]
    DualSidedMatched = ReconciliationV2Code.DualSidedMatched, // same ordinal as derivation source for type conversions
}
