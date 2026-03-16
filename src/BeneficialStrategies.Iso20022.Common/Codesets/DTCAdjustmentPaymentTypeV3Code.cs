// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vYTypsMMEee-Vv_OVx0uAQ")]
[Description(@"Specifies the type of the payment adjustment.")]
[Derivations(typeof(DTCAdjustmentPaymentType5Code), typeof(DTCAdjustmentPaymentType4Code))]
public enum DTCAdjustmentPaymentTypeV3Code
{
    /// <summary>
    /// Adjusted for rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRA&quot;.
    /// </summary>
    [EnumMember(Value = "RRRA")]
    [IsoId("_vYdjjsMMEee-Vv_OVx0uAQ")]
    [Description(@"Adjusted for rights subscription related adjustment.")]
    AdjustedForRightsSubscription,

    /// <summary>
    /// American Depository Receipt issue fee charge adjustment.
    /// Encoded/decoded by serializers as &quot;RADC&quot;.
    /// </summary>
    [EnumMember(Value = "RADC")]
    [IsoId("_vYdjjMMMEee-Vv_OVx0uAQ")]
    [Description(@"American Depository Receipt issue fee charge adjustment.")]
    ADRIssueFeeCharge,

    /// <summary>
    /// ADR issue fee reversal adjustment.
    /// Encoded/decoded by serializers as &quot;RADR&quot;.
    /// </summary>
    [EnumMember(Value = "RADR")]
    [IsoId("_vYTyuMMMEee-Vv_OVx0uAQ")]
    [Description(@"ADR issue fee reversal adjustment.")]
    ADRIssueFeeReversal,

    /// <summary>
    /// Cash in lieu related adjustment.
    /// Encoded/decoded by serializers as &quot;RCIL&quot;.
    /// </summary>
    [EnumMember(Value = "RCIL")]
    [IsoId("_vYdjicMMEee-Vv_OVx0uAQ")]
    [Description(@"Cash in lieu related adjustment.")]
    CashInLieu,

    /// <summary>
    /// Claim settlement related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCL&quot;.
    /// </summary>
    [EnumMember(Value = "RRCL")]
    [IsoId("_vYdjgcMMEee-Vv_OVx0uAQ")]
    [Description(@"Claim settlement related adjustment.")]
    ClaimSettlement,

    /// <summary>
    /// Dividend payment on a DTC custody held security related adjustment.
    /// Encoded/decoded by serializers as &quot;RCDP&quot;.
    /// </summary>
    [EnumMember(Value = "RCDP")]
    [IsoId("_vYTyucMMEee-Vv_OVx0uAQ")]
    [Description(@"Dividend payment on a DTC custody held security related adjustment.")]
    CustodyDividendPayment,

    /// <summary>
    /// Custody reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRCD&quot;.
    /// </summary>
    [EnumMember(Value = "RRCD")]
    [IsoId("_vYdjisMMEee-Vv_OVx0uAQ")]
    [Description(@"Custody reorganisation deposit related adjustment.")]
    CustodyReorganisationDeposit,

    /// <summary>
    /// Dynamic rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRDR&quot;.
    /// </summary>
    [EnumMember(Value = "RRDR")]
    [IsoId("_vYTys8MMEee-Vv_OVx0uAQ")]
    [Description(@"Dynamic rate change related adjustment.")]
    DynamicRateChange,

    /// <summary>
    /// FAIL (undelivered securities) transaction.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_vYdjgsMMEee-Vv_OVx0uAQ")]
    [Description(@"FAIL (undelivered securities) transaction.")]
    FailSettlement,

    /// <summary>
    /// Fail tracking tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXF&quot;.
    /// </summary>
    [EnumMember(Value = "TJXF")]
    [IsoId("_vYTyrsMMEee-Vv_OVx0uAQ")]
    [Description(@"Fail tracking tax withholding related adjustment.")]
    FailTrackingTaxWithholding,

    /// <summary>
    /// Intra-day reversal of original tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXV&quot;.
    /// </summary>
    [EnumMember(Value = "TJXV")]
    [IsoId("_vYTytsMMEee-Vv_OVx0uAQ")]
    [Description(@"Intra-day reversal of original tax withholding related adjustment.")]
    IntraDayReversalOfOriginalTaxWithholding,

    /// <summary>
    /// Last day protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRL&quot;.
    /// </summary>
    [EnumMember(Value = "RRRL")]
    [IsoId("_vYTyqMMMEee-Vv_OVx0uAQ")]
    [Description(@"Last day protect related adjustment.")]
    LastDayProtect,

    /// <summary>
    /// Legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRML&quot;.
    /// </summary>
    [EnumMember(Value = "RRML")]
    [IsoId("_vYdjj8MMEee-Vv_OVx0uAQ")]
    [Description(@"Legal reorganisation deposit related adjustment.")]
    LegalReorganisationDeposits,

    /// <summary>
    /// Mandatory legal reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRLR&quot;.
    /// </summary>
    [EnumMember(Value = "RRLR")]
    [IsoId("_vYTyrcMMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory legal reorganisation deposit related adjustment.")]
    MandatoryLegalReorganisationDeposit,

    /// <summary>
    /// Mandatory over three year reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRR3&quot;.
    /// </summary>
    [EnumMember(Value = "RRR3")]
    [IsoId("_vYdji8MMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory over three year reorganisation deposit related adjustment.")]
    MandatoryOverThreeYearReorganisationDeposit,

    /// <summary>
    /// Mandatory reorganisation deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;RRMD&quot;.
    /// </summary>
    [EnumMember(Value = "RRMD")]
    [IsoId("_vYTyr8MMEee-Vv_OVx0uAQ")]
    [Description(@"Mandatory reorganisation deposit related adjustment.")]
    MandatoryReorganisationDeposit,

    /// <summary>
    /// Manual user tax adjustment.
    /// Encoded/decoded by serializers as &quot;TJXU&quot;.
    /// </summary>
    [EnumMember(Value = "TJXU")]
    [IsoId("_vYTytMMMEee-Vv_OVx0uAQ")]
    [Description(@"Manual user tax adjustment.")]
    ManualUserTax,

    /// <summary>
    /// Miscellaneous (adjustment) transaction.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_vYdjjcMMEee-Vv_OVx0uAQ")]
    [Description(@"Miscellaneous (adjustment) transaction.")]
    MiscellaneousSettlement,

    /// <summary>
    /// Original (initial) tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXO&quot;.
    /// </summary>
    [EnumMember(Value = "TJXO")]
    [IsoId("_vYdjhMMMEee-Vv_OVx0uAQ")]
    [Description(@"Original (initial) tax withholding related adjustment.")]
    OriginalInitialTaxWithholding,

    /// <summary>
    /// Original late tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXL&quot;.
    /// </summary>
    [EnumMember(Value = "TJXL")]
    [IsoId("_vYTysMMMEee-Vv_OVx0uAQ")]
    [Description(@"Original late tax withholding related adjustment.")]
    OriginalLateTaxWithholding,

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_vYdjg8MMEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,

    /// <summary>
    /// Rate change tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXT&quot;.
    /// </summary>
    [EnumMember(Value = "TJXT")]
    [IsoId("_vYTyqcMMEee-Vv_OVx0uAQ")]
    [Description(@"Rate change tax withholding related adjustment.")]
    RateChangeTaxWithholding,

    /// <summary>
    /// Reclassification tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXD&quot;.
    /// </summary>
    [EnumMember(Value = "TJXD")]
    [IsoId("_vYTyt8MMEee-Vv_OVx0uAQ")]
    [Description(@"Reclassification tax withholding related adjustment.")]
    ReclassificationTaxWithholding,

    /// <summary>
    /// Participant deposited a security within 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD1&quot;.
    /// </summary>
    [EnumMember(Value = "RRD1")]
    [IsoId("_vYTyq8MMEee-Vv_OVx0uAQ")]
    [Description(
        @"Participant deposited a security within 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseOne,

    /// <summary>
    /// Participant deposited a security 10 days after a corporate action event has occurred.
    /// Encoded/decoded by serializers as &quot;RRD2&quot;.
    /// </summary>
    [EnumMember(Value = "RRD2")]
    [IsoId("_vYTyqsMMEee-Vv_OVx0uAQ")]
    [Description(
        @"Participant deposited a security 10 days after a corporate action event has occurred."
    )]
    ReorganisationDepositPhaseTwo,

    /// <summary>
    /// REPO (repurchase agreement) transaction.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("_vYdjgMMMEee-Vv_OVx0uAQ")]
    [Description(@"REPO (repurchase agreement) transaction.")]
    RepoSettlement,

    /// <summary>
    /// Reversal related adjustment.
    /// Encoded/decoded by serializers as &quot;REVA&quot;.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("_vYTyscMMEee-Vv_OVx0uAQ")]
    [Description(@"Reversal related adjustment.")]
    Reversal,

    /// <summary>
    /// Reversal of tax withholding related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXR&quot;.
    /// </summary>
    [EnumMember(Value = "TJXR")]
    [IsoId("_vYdjiMMMEee-Vv_OVx0uAQ")]
    [Description(@"Reversal of tax withholding related adjustment.")]
    ReversalOfTaxWithholding,

    /// <summary>
    /// Rights protect related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRI&quot;.
    /// </summary>
    [EnumMember(Value = "RRRI")]
    [IsoId("_vYTyssMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights protect related adjustment.")]
    RightsProtect,

    /// <summary>
    /// Rights sales related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRS&quot;.
    /// </summary>
    [EnumMember(Value = "RRRS")]
    [IsoId("_vYTyusMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights sales related adjustment.")]
    RightsSales,

    /// <summary>
    /// Rights step up related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRU&quot;.
    /// </summary>
    [EnumMember(Value = "RRRU")]
    [IsoId("_vYdjhsMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights step up related adjustment.")]
    RightsStepUp,

    /// <summary>
    /// Rights subscription related adjustment.
    /// Encoded/decoded by serializers as &quot;RRRE&quot;.
    /// </summary>
    [EnumMember(Value = "RRRE")]
    [IsoId("_vYdjhcMMEee-Vv_OVx0uAQ")]
    [Description(@"Rights subscription related adjustment.")]
    RightsSubscription,

    /// <summary>
    /// Stock loan transaction.
    /// Encoded/decoded by serializers as &quot;STOK&quot;.
    /// </summary>
    [EnumMember(Value = "STOK")]
    [IsoId("_vYdjh8MMEee-Vv_OVx0uAQ")]
    [Description(@"Stock loan transaction.")]
    StockLoanSettlement,

    /// <summary>
    /// Tax instruction change related adjustment.
    /// Encoded/decoded by serializers as &quot;TJXI&quot;.
    /// </summary>
    [EnumMember(Value = "TJXI")]
    [IsoId("_vYTyrMMMEee-Vv_OVx0uAQ")]
    [Description(@"Tax instruction change related adjustment.")]
    TaxInstructionChange,

    /// <summary>
    /// Tender offer fraction related adjustment.
    /// Encoded/decoded by serializers as &quot;RRT2&quot;.
    /// </summary>
    [EnumMember(Value = "RRT2")]
    [IsoId("_vYTytcMMEee-Vv_OVx0uAQ")]
    [Description(@"Tender offer fraction related adjustment.")]
    TenderOfferFraction,

    /// <summary>
    /// Warrant Participant delete related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWT&quot;.
    /// </summary>
    [EnumMember(Value = "RRWT")]
    [IsoId("_vYdjkMMMEee-Vv_OVx0uAQ")]
    [Description(@"Warrant Participant delete related adjustment.")]
    WarrantParticipantDelete,

    /// <summary>
    /// Warrant rate change related adjustment.
    /// Encoded/decoded by serializers as &quot;RRWC&quot;.
    /// </summary>
    [EnumMember(Value = "RRWC")]
    [IsoId("_vYTyp8MMEee-Vv_OVx0uAQ")]
    [Description(@"Warrant rate change related adjustment.")]
    WarrantRateChange,
}
