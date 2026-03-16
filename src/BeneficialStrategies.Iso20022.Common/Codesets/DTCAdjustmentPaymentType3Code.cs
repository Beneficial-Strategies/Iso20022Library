// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RYe2wJ6BEeW1p8WuttdPEw")]
[Description(@"Specifies the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeV2Code))]
public enum DTCAdjustmentPaymentType3Code
{
    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_dpHh8Z6BEeW1p8WuttdPEw")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement = DTCAdjustmentPaymentTypeV2Code.FailSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_ecv-UZ6BEeW1p8WuttdPEw")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement = DTCAdjustmentPaymentTypeV2Code.MiscellaneousSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_fUYw8Z6BEeW1p8WuttdPEw")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement = DTCAdjustmentPaymentTypeV2Code.RepoSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_gEcU4Z6BEeW1p8WuttdPEw")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement = DTCAdjustmentPaymentTypeV2Code.StockLoanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD1&quot;.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_h8zksZ6BEeW1p8WuttdPEw")]
    [Description(
        @"Participant deposited a security within 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseOne = DTCAdjustmentPaymentTypeV2Code.ReorganisationDepositPhaseOne, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD2&quot;.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_iOXOwZ6BEeW1p8WuttdPEw")]
    [Description(
        @"Participant deposited a security 10 days after a corporate action event has occurred."
    )]
    ReorgDepositPhaseTwo = DTCAdjustmentPaymentTypeV2Code.ReorgDepositPhaseTwo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCD&quot;.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_lckQIZ6BEeW1p8WuttdPEw")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    CustodyReorganizationDeposit = DTCAdjustmentPaymentTypeV2Code.CustodyReorganizationDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRDR&quot;.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_mp7bIZ6BEeW1p8WuttdPEw")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange = DTCAdjustmentPaymentTypeV2Code.DynamicRateChange, // same ordinal as derivation source for type conversions
}
