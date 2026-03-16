// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LqTzEMMOEee-Vv_OVx0uAQ")]
[Description(@"Specifies the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeV3Code))]
public enum DTCAdjustmentPaymentType5Code
{
    /// <summary>
    /// Custody reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCD&quot;.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_TORTwcMOEee-Vv_OVx0uAQ")]
    [Description(@"Custody reorganisation deposit related adjustment.")]
    CustodyReorganisationDeposit = DTCAdjustmentPaymentTypeV3Code.CustodyReorganisationDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRDR&quot;.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_TToU4cMOEee-Vv_OVx0uAQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange = DTCAdjustmentPaymentTypeV3Code.DynamicRateChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_TZRp4cMOEee-Vv_OVx0uAQ")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement = DTCAdjustmentPaymentTypeV3Code.FailSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_UoufkcMOEee-Vv_OVx0uAQ")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement = DTCAdjustmentPaymentTypeV3Code.MiscellaneousSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD1&quot;.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_VArFgcMOEee-Vv_OVx0uAQ")]
    [Description(
        @"Participant deposited a security within 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseOne = DTCAdjustmentPaymentTypeV3Code.ReorganisationDepositPhaseOne, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD2&quot;.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_W_lCMcMOEee-Vv_OVx0uAQ")]
    [Description(
        @"Participant deposited a security 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseTwo = DTCAdjustmentPaymentTypeV3Code.ReorganisationDepositPhaseTwo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_XGIWIcMOEee-Vv_OVx0uAQ")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement = DTCAdjustmentPaymentTypeV3Code.RepoSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_ckyXMcMOEee-Vv_OVx0uAQ")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement = DTCAdjustmentPaymentTypeV3Code.StockLoanSettlement, // same ordinal as derivation source for type conversions
}
