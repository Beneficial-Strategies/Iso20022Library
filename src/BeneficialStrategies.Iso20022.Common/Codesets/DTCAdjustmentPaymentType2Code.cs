// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pPQk8HxtEeOCOoRiuJeDeg")]
[Description(@"Specifies the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCAdjustmentPaymentType2Code>))]
#endif
public enum DTCAdjustmentPaymentType2Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRA&quot;.
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_ux8KYXxtEeOCOoRiuJeDeg")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription = DTCAdjustmentPaymentTypeV2Code.AdjustedForRightsSubscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// American Depository R issue fee charge adjustment.
    /// Encoded/decoded by serializers as &quot;RADC&quot;.
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_u63c4XxtEeOCOoRiuJeDeg")]
    [Description(@"American Depository R issue fee charge adjustment.")]
    ADRIssueFeeCharge = DTCAdjustmentPaymentTypeV2Code.ADRIssueFeeCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as &quot;RADR&quot;.
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_u9sucXxtEeOCOoRiuJeDeg")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal = DTCAdjustmentPaymentTypeV2Code.ADRIssueFeeReversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as &quot;RCIL&quot;.
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_vIHOs3xtEeOCOoRiuJeDeg")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu = DTCAdjustmentPaymentTypeV2Code.CashInLieu, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCL&quot;.
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_vKyvQXxtEeOCOoRiuJeDeg")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement = DTCAdjustmentPaymentTypeV2Code.ClaimSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as &quot;RCDP&quot;.
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_vNdowXxtEeOCOoRiuJeDeg")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment = DTCAdjustmentPaymentTypeV2Code.CustodyDividendPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custody reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCD&quot;.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_vmdXkXxtEeOCOoRiuJeDeg")]
    [Description(@"Custody reorganization deposit related adjustment.")]
    CustodyReorganizationDeposit = DTCAdjustmentPaymentTypeV2Code.CustodyReorganizationDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRDR&quot;.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_vpI4IXxtEeOCOoRiuJeDeg")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange = DTCAdjustmentPaymentTypeV2Code.DynamicRateChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_vr0YsXxtEeOCOoRiuJeDeg")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement = DTCAdjustmentPaymentTypeV2Code.FailSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXF&quot;.
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_v0JOQXxtEeOCOoRiuJeDeg")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding = DTCAdjustmentPaymentTypeV2Code.FailTrackingTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXV&quot;.
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_v20u0XxtEeOCOoRiuJeDeg")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding =
        DTCAdjustmentPaymentTypeV2Code.IntraDayReversalOfOriginalTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRL&quot;.
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_v5gPYXxtEeOCOoRiuJeDeg")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect = DTCAdjustmentPaymentTypeV2Code.LastDayProtect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRML&quot;.
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_v8U54XxtEeOCOoRiuJeDeg")]
    [Description(@"Legal reorganization deposit related adjustment.")]
    LegalReorganizationDeposits = DTCAdjustmentPaymentTypeV2Code.LegalReorganizationDeposits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandatory legal reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRLR&quot;.
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_wGcfM3xtEeOCOoRiuJeDeg")]
    [Description(@"Mandatory legal reorganization deposit related adjustment.")]
    MandatoryLegalReorgDeposit = DTCAdjustmentPaymentTypeV2Code.MandatoryLegalReorgDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandatory reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRMD&quot;.
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_wOoK0XxtEeOCOoRiuJeDeg")]
    [Description(@"Mandatory reorganization deposit related adjustment.")]
    MandatoryReorganizationDeposit = DTCAdjustmentPaymentTypeV2Code.MandatoryReorganizationDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as &quot;TJXU&quot;.
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_wW9ncXxtEeOCOoRiuJeDeg")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax = DTCAdjustmentPaymentTypeV2Code.ManualUserTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_wZpIAXxtEeOCOoRiuJeDeg")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement = DTCAdjustmentPaymentTypeV2Code.MiscellaneousSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXO&quot;.
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_wcUokXxtEeOCOoRiuJeDeg")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding = DTCAdjustmentPaymentTypeV2Code.OriginalInitialTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandatory over three year reorganization deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRR3&quot;.
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_wqAfQXxtEeOCOoRiuJeDeg")]
    [Description(@"Mandatory over three year reorganization deposit related adjustment.")]
    MandatoryOverThreeYearReorganizationDeposit =
        DTCAdjustmentPaymentTypeV2Code.MandatoryOverThreeYearReorganizationDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXL&quot;.
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_xOnBI3xtEeOCOoRiuJeDeg")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding = DTCAdjustmentPaymentTypeV2Code.OriginalLateTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_xRbroXxtEeOCOoRiuJeDeg")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCAdjustmentPaymentTypeV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXT&quot;.
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_xUHMMXxtEeOCOoRiuJeDeg")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding = DTCAdjustmentPaymentTypeV2Code.RateChangeTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXD&quot;.
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_xW72sXxtEeOCOoRiuJeDeg")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding = DTCAdjustmentPaymentTypeV2Code.ReclassificationTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD1&quot;.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_xe-YYXxtEeOCOoRiuJeDeg")]
    [Description(
        @"Participant deposited a security within 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseOne = DTCAdjustmentPaymentTypeV2Code.ReorganisationDepositPhaseOne, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD2&quot;.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_xhzC4XxtEeOCOoRiuJeDeg")]
    [Description(
        @"Participant deposited a security 10 days after a corporate action event has occurred."
    )]
    ReorgDepositPhaseTwo = DTCAdjustmentPaymentTypeV2Code.ReorgDepositPhaseTwo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_xkejcXxtEeOCOoRiuJeDeg")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement = DTCAdjustmentPaymentTypeV2Code.RepoSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as &quot;REVA&quot;.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_xyApIXxtEeOCOoRiuJeDeg")]
    [Description(@"Reversal related adjustment.")]
    Reversal = DTCAdjustmentPaymentTypeV2Code.Reversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXR&quot;.
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_x0sJsXxtEeOCOoRiuJeDeg")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding = DTCAdjustmentPaymentTypeV2Code.ReversalOfTaxWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRI&quot;.
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_x3XqQXxtEeOCOoRiuJeDeg")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect = DTCAdjustmentPaymentTypeV2Code.RightsProtect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRS&quot;.
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_x_jV4XxtEeOCOoRiuJeDeg")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales = DTCAdjustmentPaymentTypeV2Code.RightsSales, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRU&quot;.
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_yCO2cXxtEeOCOoRiuJeDeg")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp = DTCAdjustmentPaymentTypeV2Code.RightsStepUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRE&quot;.
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_zBKj4XxtEeOCOoRiuJeDeg")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription = DTCAdjustmentPaymentTypeV2Code.RightsSubscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_zD2EcXxtEeOCOoRiuJeDeg")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement = DTCAdjustmentPaymentTypeV2Code.StockLoanSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXI&quot;.
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_zMBwEXxtEeOCOoRiuJeDeg")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange = DTCAdjustmentPaymentTypeV2Code.TaxInstructionChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as &quot;RRT2&quot;.
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_zOtQoXxtEeOCOoRiuJeDeg")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction = DTCAdjustmentPaymentTypeV2Code.TenderOfferFraction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWT&quot;.
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_zRYKIXxtEeOCOoRiuJeDeg")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete = DTCAdjustmentPaymentTypeV2Code.WarrantParticipantDelete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWC&quot;.
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_zZar0XxtEeOCOoRiuJeDeg")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange = DTCAdjustmentPaymentTypeV2Code.WarrantRateChange, // same ordinal as derivation source for type conversions
}
