// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wd_KUMMJEee-Vv_OVx0uAQ")]
[Description(@"Specifies the subtype of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentSubReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCAdjustmentPaymentSubReason2Code>))]
#endif
public enum DTCAdjustmentPaymentSubReason2Code
{
    /// <summary>
    /// Adjustment sub-reason is for an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCPK&quot;.
    /// </summary>
    [EnumMember(Value = "SCPK")]
    [IsoId("_BZFXscMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an accrual claim payment related to a stock distribution payable on user defined date."
    )]
    AccrualClaimPayment = DTCAdjustmentPaymentSubReasonV2Code.AccrualClaimPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_BgOhgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest."
    )]
    AccruedInterestNotPaid = DTCAdjustmentPaymentSubReasonV2Code.AccruedInterestNotPaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for the accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SACA&quot;.
    /// </summary>
    [EnumMember(Value = "SACA")]
    [IsoId("_Bjyy4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for the accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    AccruedInterestWrongRate = DTCAdjustmentPaymentSubReasonV2Code.AccruedInterestWrongRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a distribution of additional rights for round up of fractions as requested for your beneficial owners.
    /// Encoded/decoded by serializers as &quot;SRTJ&quot;.
    /// </summary>
    [EnumMember(Value = "SRTJ")]
    [IsoId("_BrYoocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for a distribution of additional rights for round up of fractions as requested for your beneficial owners."
    )]
    AdditionalRightsForBeneficialOwner =
        DTCAdjustmentPaymentSubReasonV2Code.AdditionalRightsForBeneficialOwner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment due to fractions rounded up by the agent related adjustment.
    /// Encoded/decoded by serializers as &quot;SSRJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_B4epccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an allocation adjustment due to fractions rounded up by the agent related adjustment."
    )]
    AllocationAdjustmentDueToFractionsRoundedUpByAgent =
        DTCAdjustmentPaymentSubReasonV2Code.AllocationAdjustmentDueToFractionsRoundedUpByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.
    /// Encoded/decoded by serializers as &quot;SST6&quot;.
    /// </summary>
    [EnumMember(Value = "SST6")]
    [IsoId("_CDe_kcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an allocation of dividend reinvestment shares - DRP/TEDS instruction @100%."
    )]
    AllocationOfDRPTEDSInstruction =
        DTCAdjustmentPaymentSubReasonV2Code.AllocationOfDRPTEDSInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation for a participant position that was assumed by your good selves paid on retired Participant number.
    /// Encoded/decoded by serializers as &quot;SARA&quot;.
    /// </summary>
    [EnumMember(Value = "SARA")]
    [IsoId("_CGwWAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an allocation for a participant position that was assumed by your good selves paid on retired Participant number."
    )]
    AssumedByYourGoodselves = DTCAdjustmentPaymentSubReasonV2Code.AssumedByYourGoodselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an adjustment to avoid fiscal payment.
    /// Encoded/decoded by serializers as &quot;SAIA&quot;.
    /// </summary>
    [EnumMember(Value = "SAIA")]
    [IsoId("_CQuxYcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for an adjustment to avoid fiscal payment.")]
    AvoidFiscalPayment = DTCAdjustmentPaymentSubReasonV2Code.AvoidFiscalPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_Cai0scMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest."
    )]
    CalledCertificatesAccruedErroneousInterestChargeBack =
        DTCAdjustmentPaymentSubReasonV2Code.CalledCertificatesAccruedErroneousInterestChargeBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal proceeds via check, but in your customer’s name. We are forwarding the check today. This adjustment is to charge you for the funds.
    /// Encoded/decoded by serializers as &quot;SCKS&quot;.
    /// </summary>
    [EnumMember(Value = "SCKS")]
    [IsoId("_Cd0LIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal proceeds via check, but in your customer’s name. We are forwarding the check today. This adjustment is to charge you for the funds."
    )]
    CalledCertificatesCheckInParticipantsNameChargeBack =
        DTCAdjustmentPaymentSubReasonV2Code.CalledCertificatesCheckInParticipantsNameChargeBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for accrued cash due on DRP share allocation.
    /// Encoded/decoded by serializers as &quot;SSDK&quot;.
    /// </summary>
    [EnumMember(Value = "SSDK")]
    [IsoId("_Cno1gcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for accrued cash due on DRP share allocation.")]
    CashDueOnDRPShareAllocation = DTCAdjustmentPaymentSubReasonV2Code.CashDueOnDRPShareAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for accrued cash due on a stock dividend adjustment made on user defined date.
    /// Encoded/decoded by serializers as &quot;SSCK&quot;.
    /// </summary>
    [EnumMember(Value = "SSCK")]
    [IsoId("_Cq6L8cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for accrued cash due on a stock dividend adjustment made on user defined date."
    )]
    CashDueOnStockDividend = DTCAdjustmentPaymentSubReasonV2Code.CashDueOnStockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash-in-lieu of fractional shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSJJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSJJ")]
    [IsoId("_C0b7YcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash-in-lieu of fractional shares related adjustment."
    )]
    CashInLieuOfFractionalShares = DTCAdjustmentPaymentSubReasonV2Code.CashInLieuOfFractionalShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash on increased shares due to a stock distribution payable.
    /// Encoded/decoded by serializers as &quot;SNNG&quot;.
    /// </summary>
    [EnumMember(Value = "SNNG")]
    [IsoId("_C3tR0cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash on increased shares due to a stock distribution payable."
    )]
    CashOnIncreasedShares = DTCAdjustmentPaymentSubReasonV2Code.CashOnIncreasedShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that, as per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSR6&quot;.
    /// </summary>
    [EnumMember(Value = "SSR6")]
    [IsoId("_Dk7kMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that, as per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment."
    )]
    ChargeInLieuOfReceiptOfDividendReinvestment =
        DTCAdjustmentPaymentSubReasonV2Code.ChargeInLieuOfReceiptOfDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an announcement deleted for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLD&quot;.
    /// </summary>
    [EnumMember(Value = "SFLD")]
    [IsoId("_EHmMYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an announcement deleted for fail tracking related adjustment."
    )]
    AnnouncementDeletedOrFailTracking =
        DTCAdjustmentPaymentSubReasonV2Code.AnnouncementDeletedOrFailTracking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation of baby bonds amount to be exited in USD.
    /// Encoded/decoded by serializers as &quot;SABA&quot;.
    /// </summary>
    [EnumMember(Value = "SABA")]
    [IsoId("_EN_vUcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an allocation of baby bonds amount to be exited in USD."
    )]
    AllocationOfBabyBondsAmountToBeExited =
        DTCAdjustmentPaymentSubReasonV2Code.AllocationOfBabyBondsAmountToBeExited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment.
    /// Encoded/decoded by serializers as &quot;SGLA&quot;.
    /// </summary>
    [EnumMember(Value = "SGLA")]
    [IsoId("_EUicMcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for an allocation adjustment.")]
    AllocationAdjustment = DTCAdjustmentPaymentSubReasonV2Code.AllocationAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that an agent paid DTC based on combined fractions for all public service New Hampshire. New spinoffs distributed on July 25, 1991.
    /// Encoded/decoded by serializers as &quot;SSPJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSPJ")]
    [IsoId("_EapEMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that an agent paid DTC based on combined fractions for all public service New Hampshire. New spinoffs distributed on July 25, 1991."
    )]
    AgentPaidBasedOnCombinedFractions =
        DTCAdjustmentPaymentSubReasonV2Code.AgentPaidBasedOnCombinedFractions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an adjustment to your dividend reinvestment (DRP) position related adjustment.
    /// Encoded/decoded by serializers as &quot;SSD6&quot;.
    /// </summary>
    [EnumMember(Value = "SSD6")]
    [IsoId("_EdwpocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an adjustment to your dividend reinvestment (DRP) position related adjustment."
    )]
    AdjustmentToYourDividendReinvestmentPosition =
        DTCAdjustmentPaymentSubReasonV2Code.AdjustmentToYourDividendReinvestmentPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a bond paying in baby bonds that are issued in minimum/incremental denominations. This is to adjust for the amount of pending unissued bonds.
    /// Encoded/decoded by serializers as &quot;SSDJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSDJ")]
    [IsoId("_FKi3IcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for a bond paying in baby bonds that are issued in minimum/incremental denominations. This is to adjust for the amount of pending unissued bonds."
    )]
    BabyBondPayment = DTCAdjustmentPaymentSubReasonV2Code.BabyBondPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash due on an accrued stock payment.
    /// Encoded/decoded by serializers as &quot;SSBK&quot;.
    /// </summary>
    [EnumMember(Value = "SSBK")]
    [IsoId("_Fdb98cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash due on an accrued stock payment."
    )]
    CashDueOnAccruedStockPayment = DTCAdjustmentPaymentSubReasonV2Code.CashDueOnAccruedStockPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment due to a change in the record date.
    /// Encoded/decoded by serializers as &quot;SRDA&quot;.
    /// </summary>
    [EnumMember(Value = "SRDA")]
    [IsoId("_FnG3UcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for an allocation adjustment due to a change in the record date."
    )]
    ChangeInRecordDate = DTCAdjustmentPaymentSubReasonV2Code.ChangeInRecordDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for required lists containing discrepancies or which were not forwarded to French paying agent. This charge is at user defined withholding rate.
    /// Encoded/decoded by serializers as &quot;SFI9&quot;.
    /// </summary>
    [EnumMember(Value = "SFI9")]
    [IsoId("_FqYNwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for required lists containing discrepancies or which were not forwarded to French paying agent. This charge is at user defined withholding rate."
    )]
    ChargeAtWithholdingRate = DTCAdjustmentPaymentSubReasonV2Code.ChargeAtWithholdingRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that, as per agent, this charge is for French avoid fiscal tax credit.
    /// Encoded/decoded by serializers as &quot;SFAF&quot;.
    /// </summary>
    [EnumMember(Value = "SFAF")]
    [IsoId("_FwomwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that, as per agent, this charge is for French avoid fiscal tax credit."
    )]
    ChargeForFrenchAvoidFiscalTaxCredit =
        DTCAdjustmentPaymentSubReasonV2Code.ChargeForFrenchAvoidFiscalTaxCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a COD buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB1&quot;.
    /// </summary>
    [EnumMember(Value = "SBB1")]
    [IsoId("_F3eOkcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a COD buy back withdrawal."
    )]
    CODBuyBackWithdrawal = DTCAdjustmentPaymentSubReasonV2Code.CODBuyBackWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC COD withdrawal adjustment.
    /// Encoded/decoded by serializers as &quot;SJCB&quot;.
    /// </summary>
    [EnumMember(Value = "SJCB")]
    [IsoId("_F7DHAcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC COD withdrawal adjustment.")]
    CODWithdrawal = DTCAdjustmentPaymentSubReasonV2Code.CODWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SBDB&quot;.
    /// </summary>
    [EnumMember(Value = "SBDB")]
    [IsoId("_Htc4wcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your good selves."
    )]
    CODWithdrawalNotDeliveredInNameOfGoodselves =
        DTCAdjustmentPaymentSubReasonV2Code.CODWithdrawalNotDeliveredInNameOfGoodselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SBEB&quot;.
    /// </summary>
    [EnumMember(Value = "SBEB")]
    [IsoId("_Hw4AMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee."
    )]
    CODWithdrawalNotDeliveredInNameOfNominee =
        DTCAdjustmentPaymentSubReasonV2Code.CODWithdrawalNotDeliveredInNameOfNominee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that the company never declared dividend adjust allocation on user defined date.
    /// Encoded/decoded by serializers as &quot;SANA&quot;.
    /// </summary>
    [EnumMember(Value = "SANA")]
    [IsoId("_H3atEcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that the company never declared dividend adjust allocation on user defined date."
    )]
    CompanyDidNotDeclareDividend = DTCAdjustmentPaymentSubReasonV2Code.CompanyDidNotDeclareDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that the Company in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADA&quot;.
    /// </summary>
    [EnumMember(Value = "SADA")]
    [IsoId("_H6sDgcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is that the Company in default related adjustment.")]
    CompanyInDefault = DTCAdjustmentPaymentSubReasonV2Code.CompanyInDefault, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason code is for the coupon collection service adjustment for coupon deposit.
    /// Encoded/decoded by serializers as &quot;SCSM&quot;.
    /// </summary>
    [EnumMember(Value = "SCSM")]
    [IsoId("_H90QAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason code is for the coupon collection service adjustment for coupon deposit."
    )]
    CouponCollectionService = DTCAdjustmentPaymentSubReasonV2Code.CouponCollectionService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for Custody payment.
    /// Encoded/decoded by serializers as &quot;SCDP&quot;.
    /// </summary>
    [EnumMember(Value = "SCDP")]
    [IsoId("_IHyEUcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for Custody payment.")]
    CustodyPayment = DTCAdjustmentPaymentSubReasonV2Code.CustodyPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that DTCC deliver order related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEG&quot;.
    /// </summary>
    [EnumMember(Value = "SJEG")]
    [IsoId("_IXjlscMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is that DTCC deliver order related adjustment.")]
    DeliverOrder = DTCAdjustmentPaymentSubReasonV2Code.DeliverOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SJDD&quot;.
    /// </summary>
    [EnumMember(Value = "SJDD")]
    [IsoId("_IhEuEcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC deposit related adjustment.")]
    DepositAdjustment = DTCAdjustmentPaymentSubReasonV2Code.DepositAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for dividend reinvestment allocation why not on normal event.
    /// Encoded/decoded by serializers as &quot;SSC6&quot;.
    /// </summary>
    [EnumMember(Value = "SSC6")]
    [IsoId("_IxJKYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for dividend reinvestment allocation why not on normal event."
    )]
    DividendReinvestmentAllocation =
        DTCAdjustmentPaymentSubReasonV2Code.DividendReinvestmentAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for date revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLN&quot;.
    /// </summary>
    [EnumMember(Value = "SFLN")]
    [IsoId("_JOmiccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for date revision for fail tracking related adjustment."
    )]
    DateRevision = DTCAdjustmentPaymentSubReasonV2Code.DateRevision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for delete for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL1&quot;.
    /// </summary>
    [EnumMember(Value = "SFL1")]
    [IsoId("_JRuH4cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for delete for fail tracking related adjustment.")]
    Delete = DTCAdjustmentPaymentSubReasonV2Code.Delete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for deliver order (DO) activity.
    /// Encoded/decoded by serializers as &quot;SEEE&quot;.
    /// </summary>
    [EnumMember(Value = "SEEE")]
    [IsoId("_JYHq0cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for deliver order (DO) activity."
    )]
    DeliverOrderActivity = DTCAdjustmentPaymentSubReasonV2Code.DeliverOrderActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your [user defined].
    /// Encoded/decoded by serializers as &quot;SDAD&quot;.
    /// </summary>
    [EnumMember(Value = "SDAD")]
    [IsoId("_JbZBQcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your [user defined]."
    )]
    DepositLostCertificateRegisteredInNameOfYour =
        DTCAdjustmentPaymentSubReasonV2Code.DepositLostCertificateRegisteredInNameOfYour, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for deposit after cut off date transferred into the name of the CEDE on record date.
    /// Encoded/decoded by serializers as &quot;SDCD&quot;.
    /// </summary>
    [EnumMember(Value = "SDCD")]
    [IsoId("_JiPQIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for deposit after cut off date transferred into the name of the CEDE on record date."
    )]
    DepositTransferredIntoNameOfCEDEAndCo =
        DTCAdjustmentPaymentSubReasonV2Code.DepositTransferredIntoNameOfCEDEAndCo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for dividend allocation adjustment due to your sub accounting instructions to the agent.
    /// Encoded/decoded by serializers as &quot;SSS6&quot;.
    /// </summary>
    [EnumMember(Value = "SSS6")]
    [IsoId("_Jx3AgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for dividend allocation adjustment due to your sub accounting instructions to the agent."
    )]
    DividendReinvestmentAllocationAdjustment =
        DTCAdjustmentPaymentSubReasonV2Code.DividendReinvestmentAllocationAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for dividend reinvestment allocation of cash in lieu of fractions related adjustment.
    /// Encoded/decoded by serializers as &quot;SSE6&quot;.
    /// </summary>
    [EnumMember(Value = "SSE6")]
    [IsoId("_J4jeYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for dividend reinvestment allocation of cash in lieu of fractions related adjustment."
    )]
    DividendReinvestmentAllocationOfCashInLieuOfFractions =
        DTCAdjustmentPaymentSubReasonV2Code.DividendReinvestmentAllocationOfCashInLieuOfFractions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend.
    /// Encoded/decoded by serializers as &quot;SDMT&quot;.
    /// </summary>
    [EnumMember(Value = "SDMT")]
    [IsoId("_KLmWMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend."
    )]
    CTFSHeldOverRecordDate = DTCAdjustmentPaymentSubReasonV2Code.CTFSHeldOverRecordDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SPCP&quot;.
    /// </summary>
    [EnumMember(Value = "SPCP")]
    [IsoId("_LWuskcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer."
    )]
    DTCCClaimInTheNameOfYourCustomer =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLCP&quot;.
    /// </summary>
    [EnumMember(Value = "SLCP")]
    [IsoId("_LZ2SAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourCustomerLateTransfer =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourCustomerLateTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SPGP&quot;.
    /// </summary>
    [EnumMember(Value = "SPGP")]
    [IsoId("_Lc-egcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves."
    )]
    DTCCClaimInTheNameOfYourGoodselves =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLNP&quot;.
    /// </summary>
    [EnumMember(Value = "SLNP")]
    [IsoId("_LmpX4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourNominee =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourNominee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SPNP&quot;.
    /// </summary>
    [EnumMember(Value = "SPNP")]
    [IsoId("_Lp6uUcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee."
    )]
    DTCCClaimInTheNameOfYourNomineeLateTransfer =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourNomineeLateTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim on registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SGLZ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLZ")]
    [IsoId("_LtC60cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim on registered holder in the name of your customer."
    )]
    DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for due bill for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLE&quot;.
    /// </summary>
    [EnumMember(Value = "SFLE")]
    [IsoId("_L89mIcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for due bill for fail tracking related adjustment.")]
    DueBill = DTCAdjustmentPaymentSubReasonV2Code.DueBill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for due bill fail tracking.
    /// Encoded/decoded by serializers as &quot;SSFF&quot;.
    /// </summary>
    [EnumMember(Value = "SSFF")]
    [IsoId("_MAFyocMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for due bill fail tracking.")]
    DueBillFailTracking = DTCAdjustmentPaymentSubReasonV2Code.DueBillFailTracking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for due bill fail tracking reversal.
    /// Encoded/decoded by serializers as &quot;SSFR&quot;.
    /// </summary>
    [EnumMember(Value = "SSFR")]
    [IsoId("_MDgTAcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for due bill fail tracking reversal.")]
    DueBillReversal = DTCAdjustmentPaymentSubReasonV2Code.DueBillReversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase.
    /// Encoded/decoded by serializers as &quot;SBB3&quot;.
    /// </summary>
    [EnumMember(Value = "SBB3")]
    [IsoId("_MNLMYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase."
    )]
    DWACAdjustment = DTCAdjustmentPaymentSubReasonV2Code.DWACAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends/bonds interest allocation at favourable rate.
    /// Encoded/decoded by serializers as &quot;SFF8&quot;.
    /// </summary>
    [EnumMember(Value = "SFF8")]
    [IsoId("_MxCHYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends/bonds interest allocation at favourable rate."
    )]
    ForeignCashDividendsOrBondsInterestAllocationAtFavourableRate =
        DTCAdjustmentPaymentSubReasonV2Code.ForeignCashDividendsOrBondsInterestAllocationAtFavourableRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for ten percent French withholding tax, based on your revised instructions to reduce favourable tax status to unfavourable.
    /// Encoded/decoded by serializers as &quot;SFH9&quot;.
    /// </summary>
    [EnumMember(Value = "SFH9")]
    [IsoId("_NK6nAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for ten percent French withholding tax, based on your revised instructions to reduce favourable tax status to unfavourable."
    )]
    FrenchWithholdingTax10Percent =
        DTCAdjustmentPaymentSubReasonV2Code.FrenchWithholdingTax10Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends or bond interest allocation at unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFU9&quot;.
    /// </summary>
    [EnumMember(Value = "SFU9")]
    [IsoId("_NRLAAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends or bond interest allocation at unfavourable rate."
    )]
    ForeignCashDividendsOrBondInterestAllocationAtUnfavourableRate =
        DTCAdjustmentPaymentSubReasonV2Code.ForeignCashDividendsOrBondInterestAllocationAtUnfavourableRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends/bond interest allocation at exempt rate.
    /// Encoded/decoded by serializers as &quot;SFE8&quot;.
    /// </summary>
    [EnumMember(Value = "SFE8")]
    [IsoId("_NUSlccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends/bond interest allocation at exempt rate."
    )]
    ForeignCashDividendsOrBondInterestAllocationAtExemptRate =
        DTCAdjustmentPaymentSubReasonV2Code.ForeignCashDividendsOrBondInterestAllocationAtExemptRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a DWAC buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SSBB&quot;.
    /// </summary>
    [EnumMember(Value = "SSBB")]
    [IsoId("_NXj74cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a DWAC buy back withdrawal."
    )]
    DWACBuyBackWithdrawal = DTCAdjustmentPaymentSubReasonV2Code.DWACBuyBackWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim on registered holder in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SGLQ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLQ")]
    [IsoId("_Nq5uocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim on registered holder in the name of your good selves."
    )]
    DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLGP&quot;.
    /// </summary>
    [EnumMember(Value = "SLGP")]
    [IsoId("_NxKHocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourGoodselvesLateTransfer =
        DTCAdjustmentPaymentSubReasonV2Code.DTCCClaimInTheNameOfYourGoodselvesLateTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends allocation at unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFL9&quot;.
    /// </summary>
    [EnumMember(Value = "SFL9")]
    [IsoId("_OKTAYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends allocation at unfavourable rate."
    )]
    ForeignCashDividendUnfavourableRate =
        DTCAdjustmentPaymentSubReasonV2Code.ForeignCashDividendUnfavourableRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for allocation of fractional rights.
    /// Encoded/decoded by serializers as &quot;SAFR&quot;.
    /// </summary>
    [EnumMember(Value = "SAFR")]
    [IsoId("_OQsjUcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for allocation of fractional rights.")]
    FractionalRights = DTCAdjustmentPaymentSubReasonV2Code.FractionalRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for fifteen percent French withholding tax, based on your option election of 100% ADRs at the favourable rate.
    /// Encoded/decoded by serializers as &quot;SFG8&quot;.
    /// </summary>
    [EnumMember(Value = "SFG8")]
    [IsoId("_OdfCIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for fifteen percent French withholding tax, based on your option election of 100% ADRs at the favourable rate."
    )]
    FrenchWithholdingTax15Percent =
        DTCAdjustmentPaymentSubReasonV2Code.FrenchWithholdingTax15Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for twenty five percent French withholding tax, based on your option election of 100% ADRs at the unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFG9&quot;.
    /// </summary>
    [EnumMember(Value = "SFG9")]
    [IsoId("_OjvbIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for twenty five percent French withholding tax, based on your option election of 100% ADRs at the unfavourable rate."
    )]
    FrenchWithholdingTax25Percent =
        DTCAdjustmentPaymentSubReasonV2Code.FrenchWithholdingTax25Percent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is as per memo requesting a frozen letter movement from part number.
    /// Encoded/decoded by serializers as &quot;SFRO&quot;.
    /// </summary>
    [EnumMember(Value = "SFRO")]
    [IsoId("_PZTKIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is as per memo requesting a frozen letter movement from part number."
    )]
    FrozenLetterMovement = DTCAdjustmentPaymentSubReasonV2Code.FrozenLetterMovement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that company is taking 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_PfsGAcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is that company is taking 30 day grace period.")]
    GracePeriod = DTCAdjustmentPaymentSubReasonV2Code.GracePeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that this adjustment represents credits/debits to your account in lieu of reorganisation deposit activity.
    /// Encoded/decoded by serializers as &quot;SPRG&quot;.
    /// </summary>
    [EnumMember(Value = "SPRG")]
    [IsoId("_Pi-DgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that this adjustment represents credits/debits to your account in lieu of reorganisation deposit activity."
    )]
    InLieuOfReorganisationDepositActivity =
        DTCAdjustmentPaymentSubReasonV2Code.InLieuOfReorganisationDepositActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that adjustment is in response to your inquiry. Refer to control number.
    /// Encoded/decoded by serializers as &quot;SRIH&quot;.
    /// </summary>
    [EnumMember(Value = "SRIH")]
    [IsoId("_PpN1ccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that adjustment is in response to your inquiry. Refer to control number."
    )]
    InResponseToYourInquiry = DTCAdjustmentPaymentSubReasonV2Code.InResponseToYourInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for in settlement of a trade - DTCC reorganisation account 428-10271-1-2-039.
    /// Encoded/decoded by serializers as &quot;SGLT&quot;.
    /// </summary>
    [EnumMember(Value = "SGLT")]
    [IsoId("_PsVa4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for in settlement of a trade - DTCC reorganisation account 428-10271-1-2-039."
    )]
    InSettlementOfTradeDTCCReorganisationAccount =
        DTCAdjustmentPaymentSubReasonV2Code.InSettlementOfTradeDTCCReorganisationAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for Interest adjusted due to early withdrawal (certificate of deposit).
    /// Encoded/decoded by serializers as &quot;SACB&quot;.
    /// </summary>
    [EnumMember(Value = "SACB")]
    [IsoId("_Pylz4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for Interest adjusted due to early withdrawal (certificate of deposit)."
    )]
    InterestAdjustedDueToEarlyWithdrawal =
        DTCAdjustmentPaymentSubReasonV2Code.InterestAdjustedDueToEarlyWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest allocated in error first payment on &quot;date user defined&quot;.
    /// Encoded/decoded by serializers as &quot;SAEA&quot;.
    /// </summary>
    [EnumMember(Value = "SAEA")]
    [IsoId("_P4-vwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for interest allocated in error first payment on ""date user defined""."
    )]
    InterestAllocatedInError = DTCAdjustmentPaymentSubReasonV2Code.InterestAllocatedInError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that the interest due on the above CUSIP was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date.
    /// Encoded/decoded by serializers as &quot;S66P&quot;.
    /// </summary>
    [EnumMember(Value = "S66P")]
    [IsoId("_P_0-ocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that the interest due on the above CUSIP was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date."
    )]
    InterestDueWasErroneouslyPaidToYouByIssuer =
        DTCAdjustmentPaymentSubReasonV2Code.InterestDueWasErroneouslyPaidToYouByIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on conversion related adjustment.
    /// Encoded/decoded by serializers as &quot;SAC7&quot;.
    /// </summary>
    [EnumMember(Value = "SAC7")]
    [IsoId("_QDQGEcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for interest or dividend due on conversion related adjustment."
    )]
    InterestorDividendDueOnConversion =
        DTCAdjustmentPaymentSubReasonV2Code.InterestorDividendDueOnConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on merger related adjustment.
    /// Encoded/decoded by serializers as &quot;SAM7&quot;.
    /// </summary>
    [EnumMember(Value = "SAM7")]
    [IsoId("_QJyy8cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for interest or dividend due on merger related adjustment."
    )]
    InterestOrDividendDueOnMerger =
        DTCAdjustmentPaymentSubReasonV2Code.InterestOrDividendDueOnMerger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on redemption.
    /// Encoded/decoded by serializers as &quot;SAR7&quot;.
    /// </summary>
    [EnumMember(Value = "SAR7")]
    [IsoId("_QQMV4cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on redemption.")]
    InterestOrDividendDueOnRedemption =
        DTCAdjustmentPaymentSubReasonV2Code.InterestOrDividendDueOnRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on repayment option.
    /// Encoded/decoded by serializers as &quot;SAP7&quot;.
    /// </summary>
    [EnumMember(Value = "SAP7")]
    [IsoId("_QWvCwcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on repayment option.")]
    InterestOrDividendDueOnRepaymentOption =
        DTCAdjustmentPaymentSubReasonV2Code.InterestOrDividendDueOnRepaymentOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on tender.
    /// Encoded/decoded by serializers as &quot;SAT7&quot;.
    /// </summary>
    [EnumMember(Value = "SAT7")]
    [IsoId("_QdIlscMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on tender.")]
    InterestOrDividendDueOnTender =
        DTCAdjustmentPaymentSubReasonV2Code.InterestOrDividendDueOnTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that interest pays at maturity. Allocated in error on user defined date.
    /// Encoded/decoded by serializers as &quot;SAMA&quot;.
    /// </summary>
    [EnumMember(Value = "SAMA")]
    [IsoId("_QmqVIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that interest pays at maturity. Allocated in error on user defined date."
    )]
    InterestPaysAtMaturity = DTCAdjustmentPaymentSubReasonV2Code.InterestPaysAtMaturity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for that your interim position was adjusted for deliver order activity.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_QtDRAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for that your interim position was adjusted for deliver order activity."
    )]
    InterimPositionAdjustedForDeliverOrderActivity =
        DTCAdjustmentPaymentSubReasonV2Code.InterimPositionAdjustedForDeliverOrderActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that DTCC investment identification related adjustment.
    /// Encoded/decoded by serializers as &quot;SJIE&quot;.
    /// </summary>
    [EnumMember(Value = "SJIE")]
    [IsoId("_Qzcz8cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that DTCC investment identification related adjustment."
    )]
    InvestmentIdentificationAdjustment =
        DTCAdjustmentPaymentSubReasonV2Code.InvestmentIdentificationAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for issue in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADM&quot;.
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_Q8-jYcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for issue in default related adjustment.")]
    IssueInDefault = DTCAdjustmentPaymentSubReasonV2Code.IssueInDefault, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for fail tracking for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLL&quot;.
    /// </summary>
    [EnumMember(Value = "SFLL")]
    [IsoId("_RDhQQcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for fail tracking for fail tracking related adjustment."
    )]
    LateAnnouncement = DTCAdjustmentPaymentSubReasonV2Code.LateAnnouncement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for late announcement activity due bill activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SILL&quot;.
    /// </summary>
    [EnumMember(Value = "SILL")]
    [IsoId("_RGymscMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for late announcement activity due bill activity related adjustment."
    )]
    LateAnnouncementActivityDueBillActivity =
        DTCAdjustmentPaymentSubReasonV2Code.LateAnnouncementActivityDueBillActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for that the adjustment related to the deposit of lost certificate over the record date was registered in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SDBD&quot;.
    /// </summary>
    [EnumMember(Value = "SDBD")]
    [IsoId("_RKNuIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for that the adjustment related to the deposit of lost certificate over the record date was registered in the name of your good selves."
    )]
    LostCertificateRegisteredInTheNameOfYourGoodselves =
        DTCAdjustmentPaymentSubReasonV2Code.LostCertificateRegisteredInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for withdrawal by transfer - lost certificate over the record date was registered in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SWG1&quot;.
    /// </summary>
    [EnumMember(Value = "SWG1")]
    [IsoId("_RQdgEcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for withdrawal by transfer - lost certificate over the record date was registered in the name of your customer."
    )]
    LostCertificateWasRegisteredInTheNameOfYourCustomer =
        DTCAdjustmentPaymentSubReasonV2Code.LostCertificateWasRegisteredInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SDED&quot;.
    /// </summary>
    [EnumMember(Value = "SDED")]
    [IsoId("_SJ5CccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your nominee."
    )]
    LostCertificateWasRegisteredInTheNameOfYourNominee =
        DTCAdjustmentPaymentSubReasonV2Code.LostCertificateWasRegisteredInTheNameOfYourNominee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Midwest depository (6942).
    /// Encoded/decoded by serializers as &quot;SCMU&quot;.
    /// </summary>
    [EnumMember(Value = "SCMU")]
    [IsoId("_SNdT0cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Midwest depository (6942)."
    )]
    MidwestDepository = DTCAdjustmentPaymentSubReasonV2Code.MidwestDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment.
    /// Encoded/decoded by serializers as &quot;SGLM&quot;.
    /// </summary>
    [EnumMember(Value = "SGLM")]
    [IsoId("_STtFwcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for muni bearer bond coupon adjustment.")]
    MuniBearerBond = DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon related adjustment.
    /// Encoded/decoded by serializers as &quot;SMAM&quot;.
    /// </summary>
    [EnumMember(Value = "SMAM")]
    [IsoId("_SW1SQcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for muni bearer bond coupon related adjustment.")]
    MuniBearerBondCoupon = DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCoupon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date.
    /// Encoded/decoded by serializers as &quot;SMDM&quot;.
    /// </summary>
    [EnumMember(Value = "SMDM")]
    [IsoId("_StJggcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsWithdrawn =
        DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCouponAdjustmentExcessCouponsWithdrawn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for non allocation for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLS&quot;.
    /// </summary>
    [EnumMember(Value = "SFLS")]
    [IsoId("_S2qo4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for non allocation for fail tracking related adjustment."
    )]
    NonAllocation = DTCAdjustmentPaymentSubReasonV2Code.NonAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for optional dividend (ops) allocation related adjustment.
    /// Encoded/decoded by serializers as &quot;SOP2&quot;.
    /// </summary>
    [EnumMember(Value = "SOP2")]
    [IsoId("_S5y1YcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for optional dividend (ops) allocation related adjustment."
    )]
    OptionalDividendAllocationAdjustment =
        DTCAdjustmentPaymentSubReasonV2Code.OptionalDividendAllocationAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for part claim payment.
    /// Encoded/decoded by serializers as &quot;SCPP&quot;.
    /// </summary>
    [EnumMember(Value = "SCPP")]
    [IsoId("_TNIoIcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for part claim payment.")]
    PartClaimPayment = DTCAdjustmentPaymentSubReasonV2Code.PartClaimPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC pledge release related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEE&quot;.
    /// </summary>
    [EnumMember(Value = "SJEE")]
    [IsoId("_UE7LwcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC pledge release related adjustment.")]
    PledgeReleaseAdjustment = DTCAdjustmentPaymentSubReasonV2Code.PledgeReleaseAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SDDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDDD")]
    [IsoId("_UIWTMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for deposit activity."
    )]
    PositionAdjustedForDepositActivity =
        DTCAdjustmentPaymentSubReasonV2Code.PositionAdjustedForDepositActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s).
    /// Encoded/decoded by serializers as &quot;SWN1&quot;.
    /// </summary>
    [EnumMember(Value = "SWN1")]
    [IsoId("_ULxaocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s)."
    )]
    PositionReinstatedCertificatesIssuedAndOutstanding =
        DTCAdjustmentPaymentSubReasonV2Code.PositionReinstatedCertificatesIssuedAndOutstanding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_UVSjAcMKEee-Vv_OVx0uAQ")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCAdjustmentPaymentSubReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Pacific depository (3097).
    /// Encoded/decoded by serializers as &quot;SCLU&quot;.
    /// </summary>
    [EnumMember(Value = "SCLU")]
    [IsoId("_UYj5ccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Pacific depository (3097)."
    )]
    PacificDepository = DTCAdjustmentPaymentSubReasonV2Code.PacificDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAHA&quot;.
    /// </summary>
    [EnumMember(Value = "SAHA")]
    [IsoId("_UooVwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that payment of full avoid fiscal tax refund (equal to 42.5% of the dividend)."
    )]
    PaymentOfFullAvoidFiscalTaxRefund =
        DTCAdjustmentPaymentSubReasonV2Code.PaymentOfFullAvoidFiscalTaxRefund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that payment of partial avoid fiscal tax refund (equal to 15% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAPA&quot;.
    /// </summary>
    [EnumMember(Value = "SAPA")]
    [IsoId("_UvB4scMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that payment of partial avoid fiscal tax refund (equal to 15% of the dividend)."
    )]
    PaymentOfPartialAvoidFiscalTaxRefund =
        DTCAdjustmentPaymentSubReasonV2Code.PaymentOfPartialAvoidFiscalTaxRefund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Philadelphia depository (6070).
    /// Encoded/decoded by serializers as &quot;SCNU&quot;.
    /// </summary>
    [EnumMember(Value = "SCNU")]
    [IsoId("_U7rNkcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Philadelphia depository (6070)."
    )]
    PhiladelphiaDepository = DTCAdjustmentPaymentSubReasonV2Code.PhiladelphiaDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC pledge related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEF&quot;.
    /// </summary>
    [EnumMember(Value = "SJEF")]
    [IsoId("_VCEwgcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC pledge related adjustment.")]
    PledgeAdjustment = DTCAdjustmentPaymentSubReasonV2Code.PledgeAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for post date change for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL3&quot;.
    /// </summary>
    [EnumMember(Value = "SFL3")]
    [IsoId("_VLl44cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for post date change for fail tracking related adjustment."
    )]
    PostDateChangeForFailTracking =
        DTCAdjustmentPaymentSubReasonV2Code.PostDateChangeForFailTracking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for part-claim reversal.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_VbgkMcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for part-claim reversal.")]
    PartClaimReversal = DTCAdjustmentPaymentSubReasonV2Code.PartClaimReversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment. Your interim position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SMMM&quot;.
    /// </summary>
    [EnumMember(Value = "SMMM")]
    [IsoId("_Vk4iocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment. Your interim position was adjusted for deposit activity."
    )]
    MuniBearerBondCouponPositionAdjustedForDepositActivity =
        DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCouponPositionAdjustedForDepositActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date.
    /// Encoded/decoded by serializers as &quot;SMEM&quot;.
    /// </summary>
    [EnumMember(Value = "SMEM")]
    [IsoId("_VrbPgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsDeposited =
        DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCouponAdjustmentExcessCouponsDeposited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.
    /// Encoded/decoded by serializers as &quot;SMCM&quot;.
    /// </summary>
    [EnumMember(Value = "SMCM")]
    [IsoId("_VujcAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal."
    )]
    MuniBearerBondCouponAdjustmentCouponsMissingFromWithdrawal =
        DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCouponAdjustmentCouponsMissingFromWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SMBM&quot;.
    /// </summary>
    [EnumMember(Value = "SMBM")]
    [IsoId("_V08-8cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment."
    )]
    MuniBearerBondCouponAdjustmentCouponsMissingFromDeposit =
        DTCAdjustmentPaymentSubReasonV2Code.MuniBearerBondCouponAdjustmentCouponsMissingFromDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation of a pay in kind distribution.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_WUfaocMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for an allocation of a pay in kind distribution.")]
    PaynInKindDistribution = DTCAdjustmentPaymentSubReasonV2Code.PaynInKindDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for that you deposited securities that were previously called. The agent paid DTCC the redemption proceeds. This adjustment is to pass these proceeds on to you. Your free account security position will be adjusted (shorted) today for the called quantity.
    /// Encoded/decoded by serializers as &quot;SDEP&quot;.
    /// </summary>
    [EnumMember(Value = "SDEP")]
    [IsoId("_XDzXscMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for that you deposited securities that were previously called. The agent paid DTCC the redemption proceeds. This adjustment is to pass these proceeds on to you. Your free account security position will be adjusted (shorted) today for the called quantity."
    )]
    PreviouslyCalledCertificatesFundsDelivery =
        DTCAdjustmentPaymentSubReasonV2Code.PreviouslyCalledCertificatesFundsDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for allocation adjustment for dividend reinvestment due to price correction by the agent.
    /// Encoded/decoded by serializers as &quot;SSA6&quot;.
    /// </summary>
    [EnumMember(Value = "SSA6")]
    [IsoId("_XKo_gcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for allocation adjustment for dividend reinvestment due to price correction by the agent."
    )]
    PriceCorrectionDividendReinvestment =
        DTCAdjustmentPaymentSubReasonV2Code.PriceCorrectionDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for proceeds from sale of.
    /// Encoded/decoded by serializers as &quot;SPFS&quot;.
    /// </summary>
    [EnumMember(Value = "SPFS")]
    [IsoId("_Xg0D0cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for proceeds from sale of.")]
    ProceedsFromSaleOf = DTCAdjustmentPaymentSubReasonV2Code.ProceedsFromSaleOf, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSP4&quot;.
    /// </summary>
    [EnumMember(Value = "SSP4")]
    [IsoId("_XqVMMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsFromBuyTransactionInDividendTradingAccount =
        DTCAdjustmentPaymentSubReasonV2Code.ProceedsFromBuyTransactionInDividendTradingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSS5&quot;.
    /// </summary>
    [EnumMember(Value = "SSS5")]
    [IsoId("_X3RcAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsFromSellTransactionInDividendTradingAccount =
        DTCAdjustmentPaymentSubReasonV2Code.ProceedsFromSellTransactionInDividendTradingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that this allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information.
    /// Encoded/decoded by serializers as &quot;SRTA&quot;.
    /// </summary>
    [EnumMember(Value = "SRTA")]
    [IsoId("_X6jZgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that this allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information."
    )]
    RateChange = DTCAdjustmentPaymentSubReasonV2Code.RateChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for rate revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLR&quot;.
    /// </summary>
    [EnumMember(Value = "SFLR")]
    [IsoId("_YAzLccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for rate revision for fail tracking related adjustment."
    )]
    RateRevision = DTCAdjustmentPaymentSubReasonV2Code.RateRevision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for rate unknown for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL0&quot;.
    /// </summary>
    [EnumMember(Value = "SFL0")]
    [IsoId("_YEEh4cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for rate unknown for fail tracking related adjustment."
    )]
    RateUnknown = DTCAdjustmentPaymentSubReasonV2Code.RateUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that our record date position was adjusted for a withdrawal by transfer activity.
    /// Encoded/decoded by serializers as &quot;SWHT&quot;.
    /// </summary>
    [EnumMember(Value = "SWHT")]
    [IsoId("_YKeE0cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that our record date position was adjusted for a withdrawal by transfer activity."
    )]
    RecordDatePositionAdjustedForWithdrawalByTransfer =
        DTCAdjustmentPaymentSubReasonV2Code.RecordDatePositionAdjustedForWithdrawalByTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC redemption related adjustment.
    /// Encoded/decoded by serializers as &quot;SJE7&quot;.
    /// </summary>
    [EnumMember(Value = "SJE7")]
    [IsoId("_YNlqQcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC redemption related adjustment.")]
    RedemptionAdjustment = DTCAdjustmentPaymentSubReasonV2Code.RedemptionAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for redemption payment due to pledge release.
    /// Encoded/decoded by serializers as &quot;SGLP&quot;.
    /// </summary>
    [EnumMember(Value = "SGLP")]
    [IsoId("_YdXLocMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for redemption payment due to pledge release.")]
    RedemptionPaymentDueToPledgeRelease =
        DTCAdjustmentPaymentSubReasonV2Code.RedemptionPaymentDueToPledgeRelease, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that the 25% French withholding rate has been revised. This adjustment is based on the refunded tax rate.
    /// Encoded/decoded by serializers as &quot;SFJ9&quot;.
    /// </summary>
    [EnumMember(Value = "SFJ9")]
    [IsoId("_YgoiEcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that the 25% French withholding rate has been revised. This adjustment is based on the refunded tax rate."
    )]
    RefundedTaxRate = DTCAdjustmentPaymentSubReasonV2Code.RefundedTaxRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the July 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRB&quot;.
    /// </summary>
    [EnumMember(Value = "SFRB")]
    [IsoId("_YnCFAcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the July 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJuly = DTCAdjustmentPaymentSubReasonV2Code.RefundOfFrenchTaxJuly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the June 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRA&quot;.
    /// </summary>
    [EnumMember(Value = "SFRA")]
    [IsoId("_YqKRgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the June 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJune = DTCAdjustmentPaymentSubReasonV2Code.RefundOfFrenchTaxJune, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for reinstate for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL2&quot;.
    /// </summary>
    [EnumMember(Value = "SFL2")]
    [IsoId("_YwjNYcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for reinstate for fail tracking related adjustment.")]
    Reinstate = DTCAdjustmentPaymentSubReasonV2Code.Reinstate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC reorganisation related adjustment.
    /// Encoded/decoded by serializers as &quot;SJR7&quot;.
    /// </summary>
    [EnumMember(Value = "SJR7")]
    [IsoId("_Y28wUcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC reorganisation related adjustment.|")]
    ReorganisationAdjustment = DTCAdjustmentPaymentSubReasonV2Code.ReorganisationAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for reorganisation related adjustment on user defined date.
    /// Encoded/decoded by serializers as &quot;S777&quot;.
    /// </summary>
    [EnumMember(Value = "S777")]
    [IsoId("_ZHK9ocMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for reorganisation related adjustment on user defined date."
    )]
    ReorganisationRelatedAdjustment =
        DTCAdjustmentPaymentSubReasonV2Code.ReorganisationRelatedAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for Rep payment / charge.
    /// Encoded/decoded by serializers as &quot;SRPO&quot;.
    /// </summary>
    [EnumMember(Value = "SRPO")]
    [IsoId("_ZKSjEcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for Rep payment / charge.")]
    RepPaymentCharge = DTCAdjustmentPaymentSubReasonV2Code.RepPaymentCharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for redemption cash settlement.
    /// Encoded/decoded by serializers as &quot;SGL7&quot;.
    /// </summary>
    [EnumMember(Value = "SGL7")]
    [IsoId("_ZfuAgcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for redemption cash settlement.")]
    RedemptionCash = DTCAdjustmentPaymentSubReasonV2Code.RedemptionCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a reversal of an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCRK&quot;.
    /// </summary>
    [EnumMember(Value = "SCRK")]
    [IsoId("_aHcH0cMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for a reversal of an accrual claim payment related to a stock distribution payable on user defined date."
    )]
    ReversalOfAccrualClaimPayment =
        DTCAdjustmentPaymentSubReasonV2Code.ReversalOfAccrualClaimPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a COD withdrawal related adjustment.
    /// Encoded/decoded by serializers as &quot;SBRH&quot;.
    /// </summary>
    [EnumMember(Value = "SBRH")]
    [IsoId("_aLAZMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for a reversal of a COD withdrawal related adjustment."
    )]
    ReversalOfCODWithdrawal = DTCAdjustmentPaymentSubReasonV2Code.ReversalOfCODWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a deposit adjustment.
    /// Encoded/decoded by serializers as &quot;SDRH&quot;.
    /// </summary>
    [EnumMember(Value = "SDRH")]
    [IsoId("_aR_yAcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for a reversal of a deposit adjustment.")]
    ReversalOfDeposit = DTCAdjustmentPaymentSubReasonV2Code.ReversalOfDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for allocation of script shares amount to be exited in dollar value.
    /// Encoded/decoded by serializers as &quot;SASA&quot;.
    /// </summary>
    [EnumMember(Value = "SASA")]
    [IsoId("_alfVwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for allocation of script shares amount to be exited in dollar value."
    )]
    ScriptSharesExited = DTCAdjustmentPaymentSubReasonV2Code.ScriptSharesExited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR4&quot;.
    /// </summary>
    [EnumMember(Value = "SSR4")]
    [IsoId("_aoniQcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentFromBuyTransactionInDividendTradingAccount =
        DTCAdjustmentPaymentSubReasonV2Code.ShareAdjustmentFromBuyTransactionInDividendTradingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR5&quot;.
    /// </summary>
    [EnumMember(Value = "SSR5")]
    [IsoId("_arvHscMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentFromSellTransactionInDividendTradingAccount =
        DTCAdjustmentPaymentSubReasonV2Code.ShareAdjustmentFromSellTransactionInDividendTradingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for an allocation of spinoff security.
    /// Encoded/decoded by serializers as &quot;SSOS&quot;.
    /// </summary>
    [EnumMember(Value = "SSOS")]
    [IsoId("_au3UMcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for an allocation of spinoff security.")]
    SpinOffAllocation = DTCAdjustmentPaymentSubReasonV2Code.SpinOffAllocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for stock loan related payment or charge.
    /// Encoded/decoded by serializers as &quot;SSLA&quot;.
    /// </summary>
    [EnumMember(Value = "SSLA")]
    [IsoId("_ax-5ocMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for stock loan related payment or charge.|")]
    StockLoanAdjustment = DTCAdjustmentPaymentSubReasonV2Code.StockLoanAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for stock loan or repo payment order related adjustment.
    /// Encoded/decoded by serializers as &quot;SSPO&quot;.
    /// </summary>
    [EnumMember(Value = "SSPO")]
    [IsoId("_a1HGIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for stock loan or repo payment order related adjustment."
    )]
    StockLoanOrRepoPaymentOrder = DTCAdjustmentPaymentSubReasonV2Code.StockLoanOrRepoPaymentOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity from Midwest (6942).
    /// Encoded/decoded by serializers as &quot;SSME&quot;.
    /// </summary>
    [EnumMember(Value = "SSME")]
    [IsoId("_a_OrccMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for supplemental interim activity from Midwest (6942)."
    )]
    SupplementalInterimActivityFromMidwest =
        DTCAdjustmentPaymentSubReasonV2Code.SupplementalInterimActivityFromMidwest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for supplementary interim on user defined date.
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_bI5k0cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for supplementary interim on user defined date.")]
    SupplementaryInterimOn = DTCAdjustmentPaymentSubReasonV2Code.SupplementaryInterimOn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity from Philadelphia (6070).
    /// Encoded/decoded by serializers as &quot;SSPE&quot;.
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_bPcRscMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for supplemental interim activity from Philadelphia (6070)."
    )]
    SupplementalInterimActivityFromPhiladelphia =
        DTCAdjustmentPaymentSubReasonV2Code.SupplementalInterimActivityFromPhiladelphia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SRPP&quot;.
    /// </summary>
    [EnumMember(Value = "SRPP")]
    [IsoId("_bcPXkcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for supplemental interim activity related adjustment.")]
    SupplementalInterimActivity = DTCAdjustmentPaymentSubReasonV2Code.SupplementalInterimActivity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for revision of charge for withholding tax.
    /// Encoded/decoded by serializers as &quot;SAJA&quot;.
    /// </summary>
    [EnumMember(Value = "SAJA")]
    [IsoId("_bsv4wcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for revision of charge for withholding tax.")]
    RevisionOfChargeForWithholdingTax =
        DTCAdjustmentPaymentSubReasonV2Code.RevisionOfChargeForWithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is due to shares escheated to New York state in error. This is to reverse.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_bwxdIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is due to shares escheated to New York state in error. This is to reverse."
    )]
    ReverseOfSharesEscheatedToNYStateInError =
        DTCAdjustmentPaymentSubReasonV2Code.ReverseOfSharesEscheatedToNYStateInError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is due to a reverse of escheated amount of claim.
    /// Encoded/decoded by serializers as &quot;SFAP&quot;.
    /// </summary>
    [EnumMember(Value = "SFAP")]
    [IsoId("_b0yaccMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is due to a reverse of escheated amount of claim.")]
    ReverseOfEscheatedAmountOfClaim =
        DTCAdjustmentPaymentSubReasonV2Code.ReverseOfEscheatedAmountOfClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a withdrawal by transfer adjustment.
    /// Encoded/decoded by serializers as &quot;SWRH&quot;.
    /// </summary>
    [EnumMember(Value = "SWRH")]
    [IsoId("_b4pmwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for a reversal of a withdrawal by transfer adjustment."
    )]
    ReversalOfWithdrawalByTransfer =
        DTCAdjustmentPaymentSubReasonV2Code.ReversalOfWithdrawalByTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is to adjust allocation at 100% on your tax exempt instructions.
    /// Encoded/decoded by serializers as &quot;STEA&quot;.
    /// </summary>
    [EnumMember(Value = "STEA")]
    [IsoId("_cwvsYcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is to adjust allocation at 100% on your tax exempt instructions."
    )]
    TaxExemptInstructions = DTCAdjustmentPaymentSubReasonV2Code.TaxExemptInstructions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for interest adjusted due to tender fee deduction.
    /// Encoded/decoded by serializers as &quot;SAF7&quot;.
    /// </summary>
    [EnumMember(Value = "SAF7")]
    [IsoId("_c3lUMcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for interest adjusted due to tender fee deduction.")]
    TenderFeeDeduction = DTCAdjustmentPaymentSubReasonV2Code.TenderFeeDeduction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your account is being credited at the unfavourable rate (20%) as a result of the reorg merger paid on 4/2/93 (Armstrong Pharm to Medeva plc, effective 1/15/93). If entitled to favourable rate(15%), you must follow attached.
    /// Encoded/decoded by serializers as &quot;SAA7&quot;.
    /// </summary>
    [EnumMember(Value = "SAA7")]
    [IsoId("_c75zgcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your account is being credited at the unfavourable rate (20%) as a result of the reorg merger paid on 4/2/93 (Armstrong Pharm to Medeva plc, effective 1/15/93). If entitled to favourable rate(15%), you must follow attached."
    )]
    UnfavourableRateMerger = DTCAdjustmentPaymentSubReasonV2Code.UnfavourableRateMerger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for uninsured interest withheld as per FSLICN.
    /// Encoded/decoded by serializers as &quot;SAWA&quot;.
    /// </summary>
    [EnumMember(Value = "SAWA")]
    [IsoId("_c_LJ8cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for uninsured interest withheld as per FSLICN.")]
    UninsuredInterestWithheld = DTCAdjustmentPaymentSubReasonV2Code.UninsuredInterestWithheld, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for option to receive Vodafone Group American Depository Receipt at 11.354392 for every 100 ADRS.
    /// Encoded/decoded by serializers as &quot;SRRA&quot;.
    /// </summary>
    [EnumMember(Value = "SRRA")]
    [IsoId("_dGKiwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for option to receive Vodafone Group American Depository Receipt at 11.354392 for every 100 ADRS."
    )]
    VodaphoneADR = DTCAdjustmentPaymentSubReasonV2Code.VodaphoneADR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date.
    /// Encoded/decoded by serializers as &quot;SWL1&quot;.
    /// </summary>
    [EnumMember(Value = "SWL1")]
    [IsoId("_dJSvQcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date."
    )]
    WithdrawalByTransferNotTransferredIntoClientsName =
        DTCAdjustmentPaymentSubReasonV2Code.WithdrawalByTransferNotTransferredIntoClientsName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason code is for adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name.
    /// Encoded/decoded by serializers as &quot;SWM1&quot;.
    /// </summary>
    [EnumMember(Value = "SWM1")]
    [IsoId("_dP_NIcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason code is for adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name."
    )]
    WithdrawalByTransferSetUpAfterCutOffDateTransferIntoClientsName =
        DTCAdjustmentPaymentSubReasonV2Code.WithdrawalByTransferSetUpAfterCutOffDateTransferIntoClientsName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for DTCC WT related adjustment.
    /// Encoded/decoded by serializers as &quot;SJWT&quot;.
    /// </summary>
    [EnumMember(Value = "SJWT")]
    [IsoId("_ddEm4cMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for DTCC WT related adjustment.")]
    WithdrawalTransferAdjustment = DTCAdjustmentPaymentSubReasonV2Code.WithdrawalTransferAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a w/t buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB2&quot;.
    /// </summary>
    [EnumMember(Value = "SBB2")]
    [IsoId("_djxEwcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a w/t buy back withdrawal."
    )]
    WithdrawalTransferBuyBackWithdrawal =
        DTCAdjustmentPaymentSubReasonV2Code.WithdrawalTransferBuyBackWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country.
    /// Encoded/decoded by serializers as &quot;SWTA&quot;.
    /// </summary>
    [EnumMember(Value = "SWTA")]
    [IsoId("_dnMMMcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is for adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country."
    )]
    WithholdingTaxAdjustmentInUserDefinedCountry =
        DTCAdjustmentPaymentSubReasonV2Code.WithholdingTaxAdjustmentInUserDefinedCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is in response to your written inquiry.
    /// Encoded/decoded by serializers as &quot;SRAH&quot;.
    /// </summary>
    [EnumMember(Value = "SRAH")]
    [IsoId("_dxdigcMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is in response to your written inquiry.")]
    WrittenInquiry = DTCAdjustmentPaymentSubReasonV2Code.WrittenInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is for write off reorganisation related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEW&quot;.
    /// </summary>
    [EnumMember(Value = "SJEW")]
    [IsoId("_d8UHocMKEee-Vv_OVx0uAQ")]
    [Description(@"Adjustment sub-reason is for write off reorganisation related adjustment.")]
    WriteOffReorganisation = DTCAdjustmentPaymentSubReasonV2Code.WriteOffReorganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment sub-reason is that the principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SPRA&quot;.
    /// </summary>
    [EnumMember(Value = "SPRA")]
    [IsoId("_eD59YcMKEee-Vv_OVx0uAQ")]
    [Description(
        @"Adjustment sub-reason is that the principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    WrongRatePrincipal = DTCAdjustmentPaymentSubReasonV2Code.WrongRatePrincipal, // same ordinal as derivation source for type conversions
}
