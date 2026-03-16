// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cmC3IHxsEeOCOoRiuJeDeg")]
[Description(@"Specifies the type of the payment adjustment.")]
[Derivations(typeof(DTCAdjustmentPaymentType2Code), typeof(DTCAdjustmentPaymentType3Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum DTCAdjustmentPaymentTypeV2Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRA&quot;.
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_kPhxGnxsEeOCOoRiuJeDeg")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription,

    /// <summary>
    /// American Depository R issue fee charge adjustment.
    /// Encoded/decoded by serializers as &quot;RADC&quot;.
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_kPhxG3xsEeOCOoRiuJeDeg")]
    [Description(@"American Depository R issue fee charge adjustment.")]
    ADRIssueFeeCharge,

    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as &quot;RADR&quot;.
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_kPhxHHxsEeOCOoRiuJeDeg")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal,

    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as &quot;RCIL&quot;.
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_kPhxHXxsEeOCOoRiuJeDeg")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu,

    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCL&quot;.
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_kPhxHnxsEeOCOoRiuJeDeg")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement,

    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as &quot;RCDP&quot;.
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_kPhxH3xsEeOCOoRiuJeDeg")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment,

    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCD&quot;.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_kPhxIHxsEeOCOoRiuJeDeg")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    CustodyReorganizationDeposit,

    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRDR&quot;.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_kPhxIXxsEeOCOoRiuJeDeg")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange,

    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_kPhxInxsEeOCOoRiuJeDeg")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement,

    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXF&quot;.
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_kPhxI3xsEeOCOoRiuJeDeg")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding,

    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXV&quot;.
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_kPhxJHxsEeOCOoRiuJeDeg")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding,

    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRL&quot;.
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_kPhxJXxsEeOCOoRiuJeDeg")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect,

    /// <summary>
    /// Legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRML&quot;.
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_kPhxJnxsEeOCOoRiuJeDeg")]
    [Description(@"Legal reorganization deposit related adjustment.")]
    LegalReorganizationDeposits,

    /// <summary>
    /// Mandatory legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRLR&quot;.
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_kPhxJ3xsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory legal reorganization deposit related adjustment.")]
    MandatoryLegalReorgDeposit,

    /// <summary>
    /// Mandatory over three year reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRR3&quot;.
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_kPhxKHxsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory over three year reorganization deposit related adjustment.")]
    MandatoryOverThreeYearReorganizationDeposit,

    /// <summary>
    /// Mandatory reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRMD&quot;.
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_kPhxKXxsEeOCOoRiuJeDeg")]
    [Description(@"Mandatory reorganization deposit related adjustment.")]
    MandatoryReorganizationDeposit,

    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as &quot;TJXU&quot;.
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_kPhxKnxsEeOCOoRiuJeDeg")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax,

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_kPhxK3xsEeOCOoRiuJeDeg")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement,

    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXO&quot;.
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_kPhxLHxsEeOCOoRiuJeDeg")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding,

    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXL&quot;.
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_kPhxLXxsEeOCOoRiuJeDeg")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding,

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_kPhxLnxsEeOCOoRiuJeDeg")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,

    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXT&quot;.
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_kPhxL3xsEeOCOoRiuJeDeg")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding,

    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXD&quot;.
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_kPhxMHxsEeOCOoRiuJeDeg")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding,

    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD1&quot;.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_kPhxMXxsEeOCOoRiuJeDeg")]
    [Description(
        @"Participant deposited a security within 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseOne,

    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD2&quot;.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_kPhxMnxsEeOCOoRiuJeDeg")]
    [Description(
        @"Participant deposited a security 10 days after a corporate action event has occurred."
    )]
    ReorgDepositPhaseTwo,

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_kPhxM3xsEeOCOoRiuJeDeg")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement,

    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as &quot;REVA&quot;.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_kPhxNHxsEeOCOoRiuJeDeg")]
    [Description(@"Reversal related adjustment.")]
    Reversal,

    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXR&quot;.
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_kPhxNXxsEeOCOoRiuJeDeg")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding,

    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRI&quot;.
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_kPhxNnxsEeOCOoRiuJeDeg")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect,

    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRS&quot;.
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_kPhxN3xsEeOCOoRiuJeDeg")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales,

    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRU&quot;.
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_kPhxOHxsEeOCOoRiuJeDeg")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp,

    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRE&quot;.
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_kPhxOXxsEeOCOoRiuJeDeg")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription,

    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_kPhxOnxsEeOCOoRiuJeDeg")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement,

    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXI&quot;.
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_kPhxO3xsEeOCOoRiuJeDeg")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange,

    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as &quot;RRT2&quot;.
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_kPhxPHxsEeOCOoRiuJeDeg")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction,

    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWT&quot;.
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_kPhxPXxsEeOCOoRiuJeDeg")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete,

    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWC&quot;.
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_kPhxPnxsEeOCOoRiuJeDeg")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange,
}
