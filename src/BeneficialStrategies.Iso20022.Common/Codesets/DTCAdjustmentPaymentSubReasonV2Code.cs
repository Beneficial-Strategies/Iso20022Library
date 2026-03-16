// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xxT_AL_kEeeb2ZBoAlSG1Q")]
[Description(@"Specifies the subtype of the payment adjustment.")]
[Derivations(typeof(DTCAdjustmentPaymentSubReason2Code))]
public enum DTCAdjustmentPaymentSubReasonV2Code
{
    /// <summary>
    /// Adjustment sub-reason is for reorganisation related adjustment on user defined date.
    /// Encoded/decoded by serializers as &quot;S777&quot;.
    /// </summary>
    [EnumMember(Value = "S777")]
    [IsoId("_xx6bfr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for reorganisation related adjustment on user defined date."
    )]
    ReorganisationRelatedAdjustment,

    /// <summary>
    /// Adjustment sub-reason is that the interest due on the above CUSIP was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date.
    /// Encoded/decoded by serializers as &quot;S66P&quot;.
    /// </summary>
    [EnumMember(Value = "S66P")]
    [IsoId("_xx6btL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that the interest due on the above CUSIP was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date."
    )]
    InterestDueWasErroneouslyPaidToYouByIssuer,

    /// <summary>
    /// Adjustment sub-reason is for an allocation of baby bonds amount to be exited in USD.
    /// Encoded/decoded by serializers as &quot;SABA&quot;.
    /// </summary>
    [EnumMember(Value = "SABA")]
    [IsoId("_xx6bor_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an allocation of baby bonds amount to be exited in USD."
    )]
    AllocationOfBabyBondsAmountToBeExited,

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on conversion related adjustment.
    /// Encoded/decoded by serializers as &quot;SAC7&quot;.
    /// </summary>
    [EnumMember(Value = "SAC7")]
    [IsoId("_xx6bmb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for interest or dividend due on conversion related adjustment."
    )]
    InterestorDividendDueOnConversion,

    /// <summary>
    /// Adjustment sub-reason is for the accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SACA&quot;.
    /// </summary>
    [EnumMember(Value = "SACA")]
    [IsoId("_xx6bUr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for the accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    AccruedInterestWrongRate,

    /// <summary>
    /// Adjustment sub-reason is for Interest adjusted due to early withdrawal (certificate of deposit).
    /// Encoded/decoded by serializers as &quot;SACB&quot;.
    /// </summary>
    [EnumMember(Value = "SACB")]
    [IsoId("_xx6bjL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for Interest adjusted due to early withdrawal (certificate of deposit)."
    )]
    InterestAdjustedDueToEarlyWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is that accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_xx6bY7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest."
    )]
    AccruedInterestNotPaid,

    /// <summary>
    /// Adjustment sub-reason is that the Company in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADA&quot;.
    /// </summary>
    [EnumMember(Value = "SADA")]
    [IsoId("_xx6bar_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is that the Company in default related adjustment.")]
    CompanyInDefault,

    /// <summary>
    /// Adjustment sub-reason is for issue in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADM&quot;.
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_xxT_CL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for issue in default related adjustment.")]
    IssueInDefault,

    /// <summary>
    /// Adjustment sub-reason is for interest allocated in error first payment on &quot;date user defined&quot;.
    /// Encoded/decoded by serializers as &quot;SAEA&quot;.
    /// </summary>
    [EnumMember(Value = "SAEA")]
    [IsoId("_xx6bhb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for interest allocated in error first payment on ""date user defined""."
    )]
    InterestAllocatedInError,

    /// <summary>
    /// Adjustment sub-reason is for interest adjusted due to tender fee deduction.
    /// Encoded/decoded by serializers as &quot;SAF7&quot;.
    /// </summary>
    [EnumMember(Value = "SAF7")]
    [IsoId("_xx6bmL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for interest adjusted due to tender fee deduction.")]
    TenderFeeDeduction,

    /// <summary>
    /// Adjustment sub-reason is for supplementary interim on user defined date.
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_xx6biL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for supplementary interim on user defined date.")]
    SupplementaryInterimOn,

    /// <summary>
    /// Adjustment sub-reason is that company is taking 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_xx6bZL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is that company is taking 30 day grace period.")]
    GracePeriod,

    /// <summary>
    /// Adjustment sub-reason is that payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAHA&quot;.
    /// </summary>
    [EnumMember(Value = "SAHA")]
    [IsoId("_xx6bhr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that payment of full avoid fiscal tax refund (equal to 42.5% of the dividend)."
    )]
    PaymentOfFullAvoidFiscalTaxRefund,

    /// <summary>
    /// Adjustment sub-reason is for an adjustment to avoid fiscal payment.
    /// Encoded/decoded by serializers as &quot;SAIA&quot;.
    /// </summary>
    [EnumMember(Value = "SAIA")]
    [IsoId("_xxT_Mb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for an adjustment to avoid fiscal payment.")]
    AvoidFiscalPayment,

    /// <summary>
    /// Adjustment sub-reason is for revision of charge for withholding tax.
    /// Encoded/decoded by serializers as &quot;SAJA&quot;.
    /// </summary>
    [EnumMember(Value = "SAJA")]
    [IsoId("_xxT_G7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for revision of charge for withholding tax.")]
    RevisionOfChargeForWithholdingTax,

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on merger related adjustment.
    /// Encoded/decoded by serializers as &quot;SAM7&quot;.
    /// </summary>
    [EnumMember(Value = "SAM7")]
    [IsoId("_xx6brr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for interest or dividend due on merger related adjustment."
    )]
    InterestOrDividendDueOnMerger,

    /// <summary>
    /// Adjustment sub-reason is that interest pays at maturity. Allocated in error on user defined date.
    /// Encoded/decoded by serializers as &quot;SAMA&quot;.
    /// </summary>
    [EnumMember(Value = "SAMA")]
    [IsoId("_xx6bcb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that interest pays at maturity. Allocated in error on user defined date."
    )]
    InterestPaysAtMaturity,

    /// <summary>
    /// Adjustment sub-reason is that the company never declared dividend adjust allocation on user defined date.
    /// Encoded/decoded by serializers as &quot;SANA&quot;.
    /// </summary>
    [EnumMember(Value = "SANA")]
    [IsoId("_xx6bfL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that the company never declared dividend adjust allocation on user defined date."
    )]
    CompanyDidNotDeclareDividend,

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on repayment option.
    /// Encoded/decoded by serializers as &quot;SAP7&quot;.
    /// </summary>
    [EnumMember(Value = "SAP7")]
    [IsoId("_xx6bVr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on repayment option.")]
    InterestOrDividendDueOnRepaymentOption,

    /// <summary>
    /// Adjustment sub-reason is that payment of partial avoid fiscal tax refund (equal to 15% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAPA&quot;.
    /// </summary>
    [EnumMember(Value = "SAPA")]
    [IsoId("_xxT_Eb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that payment of partial avoid fiscal tax refund (equal to 15% of the dividend)."
    )]
    PaymentOfPartialAvoidFiscalTaxRefund,

    /// <summary>
    /// Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_xxT_M7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest."
    )]
    CalledCertificatesAccruedErroneousInterestChargeBack,

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on redemption.
    /// Encoded/decoded by serializers as &quot;SAR7&quot;.
    /// </summary>
    [EnumMember(Value = "SAR7")]
    [IsoId("_xx6blr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on redemption.")]
    InterestOrDividendDueOnRedemption,

    /// <summary>
    /// Adjustment sub-reason is for an allocation for a participant position that was assumed by your good selves paid on retired Participant number.
    /// Encoded/decoded by serializers as &quot;SARA&quot;.
    /// </summary>
    [EnumMember(Value = "SARA")]
    [IsoId("_xx6bnr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an allocation for a participant position that was assumed by your good selves paid on retired Participant number."
    )]
    AssumedByYourGoodselves,

    /// <summary>
    /// Adjustment sub-reason is for allocation of script shares amount to be exited in dollar value.
    /// Encoded/decoded by serializers as &quot;SASA&quot;.
    /// </summary>
    [EnumMember(Value = "SASA")]
    [IsoId("_xxT_Ab_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for allocation of script shares amount to be exited in dollar value."
    )]
    ScriptSharesExited,

    /// <summary>
    /// Adjustment sub-reason is for interest or dividend due on tender.
    /// Encoded/decoded by serializers as &quot;SAT7&quot;.
    /// </summary>
    [EnumMember(Value = "SAT7")]
    [IsoId("_xx6baL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for interest or dividend due on tender.")]
    InterestOrDividendDueOnTender,

    /// <summary>
    /// Adjustment sub-reason is for uninsured interest withheld as per FSLICN.
    /// Encoded/decoded by serializers as &quot;SAWA&quot;.
    /// </summary>
    [EnumMember(Value = "SAWA")]
    [IsoId("_xx6bU7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for uninsured interest withheld as per FSLICN.")]
    UninsuredInterestWithheld,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a DWAC buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SSBB&quot;.
    /// </summary>
    [EnumMember(Value = "SSBB")]
    [IsoId("_xxT_L7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a DWAC buy back withdrawal."
    )]
    DWACBuyBackWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a COD buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB1&quot;.
    /// </summary>
    [EnumMember(Value = "SBB1")]
    [IsoId("_xxT_A7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a COD buy back withdrawal."
    )]
    CODBuyBackWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a w/t buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB2&quot;.
    /// </summary>
    [EnumMember(Value = "SBB2")]
    [IsoId("_xx6bkr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a w/t buy back withdrawal."
    )]
    WithdrawalTransferBuyBackWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SBDB&quot;.
    /// </summary>
    [EnumMember(Value = "SBDB")]
    [IsoId("_xx6ber_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your good selves."
    )]
    CODWithdrawalNotDeliveredInNameOfGoodselves,

    /// <summary>
    /// Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SBEB&quot;.
    /// </summary>
    [EnumMember(Value = "SBEB")]
    [IsoId("_xx6bsb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee."
    )]
    CODWithdrawalNotDeliveredInNameOfNominee,

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a COD withdrawal related adjustment.
    /// Encoded/decoded by serializers as &quot;SBRH&quot;.
    /// </summary>
    [EnumMember(Value = "SBRH")]
    [IsoId("_xx6bpL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for a reversal of a COD withdrawal related adjustment."
    )]
    ReversalOfCODWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is for Custody payment.
    /// Encoded/decoded by serializers as &quot;SCDP&quot;.
    /// </summary>
    [EnumMember(Value = "SCDP")]
    [IsoId("_xx6bUL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for Custody payment.")]
    CustodyPayment,

    /// <summary>
    /// Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal proceeds via check, but in your customer’s name. We are forwarding the check today. This adjustment is to charge you for the funds.
    /// Encoded/decoded by serializers as &quot;SCKS&quot;.
    /// </summary>
    [EnumMember(Value = "SCKS")]
    [IsoId("_xxT_Gb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for certificates you deposited prior to publication date were subsequently called. The agent paid DTCC the principal proceeds via check, but in your customer’s name. We are forwarding the check today. This adjustment is to charge you for the funds."
    )]
    CalledCertificatesCheckInParticipantsNameChargeBack,

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Pacific depository (3097).
    /// Encoded/decoded by serializers as &quot;SCLU&quot;.
    /// </summary>
    [EnumMember(Value = "SCLU")]
    [IsoId("_xxT_F7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Pacific depository (3097)."
    )]
    PacificDepository,

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Midwest depository (6942).
    /// Encoded/decoded by serializers as &quot;SCMU&quot;.
    /// </summary>
    [EnumMember(Value = "SCMU")]
    [IsoId("_xx6bm7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Midwest depository (6942)."
    )]
    MidwestDepository,

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for the Philadelphia depository (6070).
    /// Encoded/decoded by serializers as &quot;SCNU&quot;.
    /// </summary>
    [EnumMember(Value = "SCNU")]
    [IsoId("_xx6bp7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for the Philadelphia depository (6070)."
    )]
    PhiladelphiaDepository,

    /// <summary>
    /// Adjustment sub-reason is for an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCPK&quot;.
    /// </summary>
    [EnumMember(Value = "SCPK")]
    [IsoId("_xxT_Fb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an accrual claim payment related to a stock distribution payable on user defined date."
    )]
    AccrualClaimPayment,

    /// <summary>
    /// Adjustment sub-reason is for part claim payment.
    /// Encoded/decoded by serializers as &quot;SCPP&quot;.
    /// </summary>
    [EnumMember(Value = "SCPP")]
    [IsoId("_xx6bYL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for part claim payment.")]
    PartClaimPayment,

    /// <summary>
    /// Adjustment sub-reason is for a reversal of an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCRK&quot;.
    /// </summary>
    [EnumMember(Value = "SCRK")]
    [IsoId("_xx6bl7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for a reversal of an accrual claim payment related to a stock distribution payable on user defined date."
    )]
    ReversalOfAccrualClaimPayment,

    /// <summary>
    /// Adjustment sub-reason is for part-claim reversal.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_xx6bZr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for part-claim reversal.")]
    PartClaimReversal,

    /// <summary>
    /// Adjustment sub-reason code is for the coupon collection service adjustment for coupon deposit.
    /// Encoded/decoded by serializers as &quot;SCSM&quot;.
    /// </summary>
    [EnumMember(Value = "SCSM")]
    [IsoId("_xxT_IL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason code is for the coupon collection service adjustment for coupon deposit."
    )]
    CouponCollectionService,

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a deposit adjustment.
    /// Encoded/decoded by serializers as &quot;SDRH&quot;.
    /// </summary>
    [EnumMember(Value = "SDRH")]
    [IsoId("_xx6bjb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for a reversal of a deposit adjustment.")]
    ReversalOfDeposit,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for deliver order (DO) activity.
    /// Encoded/decoded by serializers as &quot;SEEE&quot;.
    /// </summary>
    [EnumMember(Value = "SEEE")]
    [IsoId("_xx6bjr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for deliver order (DO) activity."
    )]
    DeliverOrderActivity,

    /// <summary>
    /// Adjustment sub-reason is due to shares escheated to New York state in error. This is to reverse.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_xx6bh7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is due to shares escheated to New York state in error. This is to reverse."
    )]
    ReverseOfSharesEscheatedToNYStateInError,

    /// <summary>
    /// Adjustment sub-reason is that, as per agent, this charge is for French avoid fiscal tax credit.
    /// Encoded/decoded by serializers as &quot;SFAF&quot;.
    /// </summary>
    [EnumMember(Value = "SFAF")]
    [IsoId("_xx6bXr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that, as per agent, this charge is for French avoid fiscal tax credit."
    )]
    ChargeForFrenchAvoidFiscalTaxCredit,

    /// <summary>
    /// Adjustment sub-reason is due to a reverse of escheated amount of claim.
    /// Encoded/decoded by serializers as &quot;SFAP&quot;.
    /// </summary>
    [EnumMember(Value = "SFAP")]
    [IsoId("_xx6bVL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is due to a reverse of escheated amount of claim.")]
    ReverseOfEscheatedAmountOfClaim,

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends/bond interest allocation at exempt rate.
    /// Encoded/decoded by serializers as &quot;SFE8&quot;.
    /// </summary>
    [EnumMember(Value = "SFE8")]
    [IsoId("_xxT_I7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends/bond interest allocation at exempt rate."
    )]
    ForeignCashDividendsOrBondInterestAllocationAtExemptRate,

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends/bonds interest allocation at favourable rate.
    /// Encoded/decoded by serializers as &quot;SFF8&quot;.
    /// </summary>
    [EnumMember(Value = "SFF8")]
    [IsoId("_xxT_BL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends/bonds interest allocation at favourable rate."
    )]
    ForeignCashDividendsOrBondsInterestAllocationAtFavourableRate,

    /// <summary>
    /// Adjustment sub-reason is for fifteen percent French withholding tax, based on your option election of 100% ADRs at the favourable rate.
    /// Encoded/decoded by serializers as &quot;SFG8&quot;.
    /// </summary>
    [EnumMember(Value = "SFG8")]
    [IsoId("_xx6bsr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for fifteen percent French withholding tax, based on your option election of 100% ADRs at the favourable rate."
    )]
    FrenchWithholdingTax15Percent,

    /// <summary>
    /// Adjustment sub-reason is for twenty five percent French withholding tax, based on your option election of 100% ADRs at the unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFG9&quot;.
    /// </summary>
    [EnumMember(Value = "SFG9")]
    [IsoId("_xx6bV7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for twenty five percent French withholding tax, based on your option election of 100% ADRs at the unfavourable rate."
    )]
    FrenchWithholdingTax25Percent,

    /// <summary>
    /// Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your [user defined].
    /// Encoded/decoded by serializers as &quot;SDAD&quot;.
    /// </summary>
    [EnumMember(Value = "SDAD")]
    [IsoId("_xxT_ML_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your [user defined]."
    )]
    DepositLostCertificateRegisteredInNameOfYour,

    /// <summary>
    /// Adjustment sub-reason is for that the adjustment related to the deposit of lost certificate over the record date was registered in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SDBD&quot;.
    /// </summary>
    [EnumMember(Value = "SDBD")]
    [IsoId("_xxT_Db_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for that the adjustment related to the deposit of lost certificate over the record date was registered in the name of your good selves."
    )]
    LostCertificateRegisteredInTheNameOfYourGoodselves,

    /// <summary>
    /// Adjustment sub-reason is for deposit after cut off date transferred into the name of the CEDE on record date.
    /// Encoded/decoded by serializers as &quot;SDCD&quot;.
    /// </summary>
    [EnumMember(Value = "SDCD")]
    [IsoId("_xx6bqL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for deposit after cut off date transferred into the name of the CEDE on record date."
    )]
    DepositTransferredIntoNameOfCEDEAndCo,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SDDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDDD")]
    [IsoId("_xx6bUb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for deposit activity."
    )]
    PositionAdjustedForDepositActivity,

    /// <summary>
    /// Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SDED&quot;.
    /// </summary>
    [EnumMember(Value = "SDED")]
    [IsoId("_xx6bsL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment related to the deposit of lost certificate over the record date that was registered in the name of your nominee."
    )]
    LostCertificateWasRegisteredInTheNameOfYourNominee,

    /// <summary>
    /// Adjustment sub-reason is for that you deposited securities that were previously called. The agent paid DTCC the redemption proceeds. This adjustment is to pass these proceeds on to you. Your free account security position will be adjusted (shorted) today for the called quantity.
    /// Encoded/decoded by serializers as &quot;SDEP&quot;.
    /// </summary>
    [EnumMember(Value = "SDEP")]
    [IsoId("_xxT_C7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for that you deposited securities that were previously called. The agent paid DTCC the redemption proceeds. This adjustment is to pass these proceeds on to you. Your free account security position will be adjusted (shorted) today for the called quantity."
    )]
    PreviouslyCalledCertificatesFundsDelivery,

    /// <summary>
    /// Adjustment sub-reason is for CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend.
    /// Encoded/decoded by serializers as &quot;SDMT&quot;.
    /// </summary>
    [EnumMember(Value = "SDMT")]
    [IsoId("_xxT_Kb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend."
    )]
    CTFSHeldOverRecordDate,

    /// <summary>
    /// Adjustment sub-reason is for ten percent French withholding tax, based on your revised instructions to reduce favourable tax status to unfavourable.
    /// Encoded/decoded by serializers as &quot;SFH9&quot;.
    /// </summary>
    [EnumMember(Value = "SFH9")]
    [IsoId("_xxT_Kr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for ten percent French withholding tax, based on your revised instructions to reduce favourable tax status to unfavourable."
    )]
    FrenchWithholdingTax10Percent,

    /// <summary>
    /// Adjustment sub-reason is for required lists containing discrepancies or which were not forwarded to French paying agent. This charge is at user defined withholding rate.
    /// Encoded/decoded by serializers as &quot;SFI9&quot;.
    /// </summary>
    [EnumMember(Value = "SFI9")]
    [IsoId("_xx6bgr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for required lists containing discrepancies or which were not forwarded to French paying agent. This charge is at user defined withholding rate."
    )]
    ChargeAtWithholdingRate,

    /// <summary>
    /// Adjustment sub-reason is that the 25% French withholding rate has been revised. This adjustment is based on the refunded tax rate.
    /// Encoded/decoded by serializers as &quot;SFJ9&quot;.
    /// </summary>
    [EnumMember(Value = "SFJ9")]
    [IsoId("_xxT_Hb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that the 25% French withholding rate has been revised. This adjustment is based on the refunded tax rate."
    )]
    RefundedTaxRate,

    /// <summary>
    /// Adjustment sub-reason is for rate unknown for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL0&quot;.
    /// </summary>
    [EnumMember(Value = "SFL0")]
    [IsoId("_xx6bZb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for rate unknown for fail tracking related adjustment."
    )]
    RateUnknown,

    /// <summary>
    /// Adjustment sub-reason is for delete for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL1&quot;.
    /// </summary>
    [EnumMember(Value = "SFL1")]
    [IsoId("_xxT_Hr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for delete for fail tracking related adjustment.")]
    Delete,

    /// <summary>
    /// Adjustment sub-reason is for reinstate for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL2&quot;.
    /// </summary>
    [EnumMember(Value = "SFL2")]
    [IsoId("_xx6bcr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for reinstate for fail tracking related adjustment.")]
    Reinstate,

    /// <summary>
    /// Adjustment sub-reason is for post date change for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL3&quot;.
    /// </summary>
    [EnumMember(Value = "SFL3")]
    [IsoId("_xxT_Lb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for post date change for fail tracking related adjustment."
    )]
    PostDateChangeForFailTracking,

    /// <summary>
    /// Adjustment sub-reason is for an announcement deleted for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLD&quot;.
    /// </summary>
    [EnumMember(Value = "SFLD")]
    [IsoId("_xx6bZ7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an announcement deleted for fail tracking related adjustment."
    )]
    AnnouncementDeletedOrFailTracking,

    /// <summary>
    /// Adjustment sub-reason is for due bill for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLE&quot;.
    /// </summary>
    [EnumMember(Value = "SFLE")]
    [IsoId("_xx6bq7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for due bill for fail tracking related adjustment.")]
    DueBill,

    /// <summary>
    /// Adjustment sub-reason is for fail tracking for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLL&quot;.
    /// </summary>
    [EnumMember(Value = "SFLL")]
    [IsoId("_xx6bgb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for fail tracking for fail tracking related adjustment."
    )]
    LateAnnouncement,

    /// <summary>
    /// Adjustment sub-reason is for date revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLN&quot;.
    /// </summary>
    [EnumMember(Value = "SFLN")]
    [IsoId("_xx6bc7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for date revision for fail tracking related adjustment."
    )]
    DateRevision,

    /// <summary>
    /// Adjustment sub-reason is for rate revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLR&quot;.
    /// </summary>
    [EnumMember(Value = "SFLR")]
    [IsoId("_xxT_K7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for rate revision for fail tracking related adjustment."
    )]
    RateRevision,

    /// <summary>
    /// Adjustment sub-reason is for non allocation for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLS&quot;.
    /// </summary>
    [EnumMember(Value = "SFLS")]
    [IsoId("_xx6boL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for non allocation for fail tracking related adjustment."
    )]
    NonAllocation,

    /// <summary>
    /// Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the June 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRA&quot;.
    /// </summary>
    [EnumMember(Value = "SFRA")]
    [IsoId("_xx6bd7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the June 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJune,

    /// <summary>
    /// Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the July 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRB&quot;.
    /// </summary>
    [EnumMember(Value = "SFRB")]
    [IsoId("_xxT_Br_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for refund of French tax based on acceptance of global reclamation for the July 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJuly,

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends or bond interest allocation at unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFU9&quot;.
    /// </summary>
    [EnumMember(Value = "SFU9")]
    [IsoId("_xx6br7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends or bond interest allocation at unfavourable rate."
    )]
    ForeignCashDividendsOrBondInterestAllocationAtUnfavourableRate,

    /// <summary>
    /// Adjustment sub-reason is for redemption cash settlement.
    /// Encoded/decoded by serializers as &quot;SGL7&quot;.
    /// </summary>
    [EnumMember(Value = "SGL7")]
    [IsoId("_xx6beL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for redemption cash settlement.")]
    RedemptionCash,

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment.
    /// Encoded/decoded by serializers as &quot;SGLA&quot;.
    /// </summary>
    [EnumMember(Value = "SGLA")]
    [IsoId("_xxT_Gr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for an allocation adjustment.")]
    AllocationAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment.
    /// Encoded/decoded by serializers as &quot;SGLM&quot;.
    /// </summary>
    [EnumMember(Value = "SGLM")]
    [IsoId("_xxT_Ib_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for muni bearer bond coupon adjustment.")]
    MuniBearerBond,

    /// <summary>
    /// Adjustment sub-reason is for redemption payment due to pledge release.
    /// Encoded/decoded by serializers as &quot;SGLP&quot;.
    /// </summary>
    [EnumMember(Value = "SGLP")]
    [IsoId("_xx6beb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for redemption payment due to pledge release.")]
    RedemptionPaymentDueToPledgeRelease,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim on registered holder in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SGLQ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLQ")]
    [IsoId("_xx6bYb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim on registered holder in the name of your good selves."
    )]
    DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves,

    /// <summary>
    /// Adjustment sub-reason is for in settlement of a trade - DTCC reorganisation account 428-10271-1-2-039.
    /// Encoded/decoded by serializers as &quot;SGLT&quot;.
    /// </summary>
    [EnumMember(Value = "SGLT")]
    [IsoId("_xx6bur_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for in settlement of a trade - DTCC reorganisation account 428-10271-1-2-039."
    )]
    InSettlementOfTradeDTCCReorganisationAccount,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim on registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SGLZ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLZ")]
    [IsoId("_xx6blL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim on registered holder in the name of your customer."
    )]
    DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer,

    /// <summary>
    /// Adjustment sub-reason is for that your interim position was adjusted for deliver order activity.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_xx6bab_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for that your interim position was adjusted for deliver order activity."
    )]
    InterimPositionAdjustedForDeliverOrderActivity,

    /// <summary>
    /// Adjustment sub-reason is for late announcement activity due bill activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SILL&quot;.
    /// </summary>
    [EnumMember(Value = "SILL")]
    [IsoId("_xxT_Ir_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for late announcement activity due bill activity related adjustment."
    )]
    LateAnnouncementActivityDueBillActivity,

    /// <summary>
    /// Adjustment sub-reason is for DTCC COD withdrawal adjustment.
    /// Encoded/decoded by serializers as &quot;SJCB&quot;.
    /// </summary>
    [EnumMember(Value = "SJCB")]
    [IsoId("_xx6bX7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC COD withdrawal adjustment.")]
    CODWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is for DTCC deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SJDD&quot;.
    /// </summary>
    [EnumMember(Value = "SJDD")]
    [IsoId("_xx6bfb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC deposit related adjustment.")]
    DepositAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC redemption related adjustment.
    /// Encoded/decoded by serializers as &quot;SJE7&quot;.
    /// </summary>
    [EnumMember(Value = "SJE7")]
    [IsoId("_xx6ba7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC redemption related adjustment.")]
    RedemptionAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC pledge release related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEE&quot;.
    /// </summary>
    [EnumMember(Value = "SJEE")]
    [IsoId("_xx6brL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC pledge release related adjustment.")]
    PledgeReleaseAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for write off reorganisation related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEW&quot;.
    /// </summary>
    [EnumMember(Value = "SJEW")]
    [IsoId("_xx6bVb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for write off reorganisation related adjustment.")]
    WriteOffReorganisation,

    /// <summary>
    /// Adjustment sub-reason is that DTCC investment identification related adjustment.
    /// Encoded/decoded by serializers as &quot;SJIE&quot;.
    /// </summary>
    [EnumMember(Value = "SJIE")]
    [IsoId("_xxT_J7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that DTCC investment identification related adjustment."
    )]
    InvestmentIdentificationAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC pledge related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEF&quot;.
    /// </summary>
    [EnumMember(Value = "SJEF")]
    [IsoId("_xx6bnb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC pledge related adjustment.")]
    PledgeAdjustment,

    /// <summary>
    /// Adjustment sub-reason is that DTCC deliver order related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEG&quot;.
    /// </summary>
    [EnumMember(Value = "SJEG")]
    [IsoId("_xx6bbL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is that DTCC deliver order related adjustment.")]
    DeliverOrder,

    /// <summary>
    /// Adjustment sub-reason is for DTCC reorganisation related adjustment.
    /// Encoded/decoded by serializers as &quot;SJR7&quot;.
    /// </summary>
    [EnumMember(Value = "SJR7")]
    [IsoId("_xx6bqb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC reorganisation related adjustment.|")]
    ReorganisationAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC WT related adjustment.
    /// Encoded/decoded by serializers as &quot;SJWT&quot;.
    /// </summary>
    [EnumMember(Value = "SJWT")]
    [IsoId("_xx6bo7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for DTCC WT related adjustment.")]
    WithdrawalTransferAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLCP&quot;.
    /// </summary>
    [EnumMember(Value = "SLCP")]
    [IsoId("_xx6bb7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourCustomerLateTransfer,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLGP&quot;.
    /// </summary>
    [EnumMember(Value = "SLGP")]
    [IsoId("_xx6bt7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourGoodselvesLateTransfer,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLNP&quot;.
    /// </summary>
    [EnumMember(Value = "SLNP")]
    [IsoId("_xxT_Dr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimInTheNameOfYourNominee,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon related adjustment.
    /// Encoded/decoded by serializers as &quot;SMAM&quot;.
    /// </summary>
    [EnumMember(Value = "SMAM")]
    [IsoId("_xxT_D7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for muni bearer bond coupon related adjustment.")]
    MuniBearerBondCoupon,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SMBM&quot;.
    /// </summary>
    [EnumMember(Value = "SMBM")]
    [IsoId("_xx6bub_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment."
    )]
    MuniBearerBondCouponAdjustmentCouponsMissingFromDeposit,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.
    /// Encoded/decoded by serializers as &quot;SMCM&quot;.
    /// </summary>
    [EnumMember(Value = "SMCM")]
    [IsoId("_xx6bcL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal."
    )]
    MuniBearerBondCouponAdjustmentCouponsMissingFromWithdrawal,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date.
    /// Encoded/decoded by serializers as &quot;SMDM&quot;.
    /// </summary>
    [EnumMember(Value = "SMDM")]
    [IsoId("_xx6bg7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsWithdrawn,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date.
    /// Encoded/decoded by serializers as &quot;SMEM&quot;.
    /// </summary>
    [EnumMember(Value = "SMEM")]
    [IsoId("_xx6bqr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsDeposited,

    /// <summary>
    /// Adjustment sub-reason is for muni bearer bond coupon adjustment. Your interim position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SMMM&quot;.
    /// </summary>
    [EnumMember(Value = "SMMM")]
    [IsoId("_xx6bgL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for muni bearer bond coupon adjustment. Your interim position was adjusted for deposit activity."
    )]
    MuniBearerBondCouponPositionAdjustedForDepositActivity,

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash on increased shares due to a stock distribution payable.
    /// Encoded/decoded by serializers as &quot;SNNG&quot;.
    /// </summary>
    [EnumMember(Value = "SNNG")]
    [IsoId("_xx6bmr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash on increased shares due to a stock distribution payable."
    )]
    CashOnIncreasedShares,

    /// <summary>
    /// Adjustment sub-reason is for optional dividend (ops) allocation related adjustment.
    /// Encoded/decoded by serializers as &quot;SOP2&quot;.
    /// </summary>
    [EnumMember(Value = "SOP2")]
    [IsoId("_xxT_Er_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for optional dividend (ops) allocation related adjustment."
    )]
    OptionalDividendAllocationAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SPCP&quot;.
    /// </summary>
    [EnumMember(Value = "SPCP")]
    [IsoId("_xxT_H7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your customer."
    )]
    DTCCClaimInTheNameOfYourCustomer,

    /// <summary>
    /// Adjustment sub-reason is for proceeds from sale of.
    /// Encoded/decoded by serializers as &quot;SPFS&quot;.
    /// </summary>
    [EnumMember(Value = "SPFS")]
    [IsoId("_xxT_LL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for proceeds from sale of.")]
    ProceedsFromSaleOf,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves.
    /// Encoded/decoded by serializers as &quot;SPGP&quot;.
    /// </summary>
    [EnumMember(Value = "SPGP")]
    [IsoId("_xxT_Cb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your good selves."
    )]
    DTCCClaimInTheNameOfYourGoodselves,

    /// <summary>
    /// Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SPNP&quot;.
    /// </summary>
    [EnumMember(Value = "SPNP")]
    [IsoId("_xx6bdr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for DTCC claim against registered holder in the name of your nominee."
    )]
    DTCCClaimInTheNameOfYourNomineeLateTransfer,

    /// <summary>
    /// Adjustment sub-reason is that the principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SPRA&quot;.
    /// </summary>
    [EnumMember(Value = "SPRA")]
    [IsoId("_xx6bdL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that the principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    WrongRatePrincipal,

    /// <summary>
    /// Adjustment sub-reason is in response to your written inquiry.
    /// Encoded/decoded by serializers as &quot;SRAH&quot;.
    /// </summary>
    [EnumMember(Value = "SRAH")]
    [IsoId("_xx6bir_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is in response to your written inquiry.")]
    WrittenInquiry,

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment due to a change in the record date.
    /// Encoded/decoded by serializers as &quot;SRDA&quot;.
    /// </summary>
    [EnumMember(Value = "SRDA")]
    [IsoId("_xxT_Lr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an allocation adjustment due to a change in the record date."
    )]
    ChangeInRecordDate,

    /// <summary>
    /// Adjustment sub-reason is that adjustment is in response to your inquiry. Refer to control number.
    /// Encoded/decoded by serializers as &quot;SRIH&quot;.
    /// </summary>
    [EnumMember(Value = "SRIH")]
    [IsoId("_xxT_E7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that adjustment is in response to your inquiry. Refer to control number."
    )]
    InResponseToYourInquiry,

    /// <summary>
    /// Adjustment sub-reason is for Rep payment / charge.
    /// Encoded/decoded by serializers as &quot;SRPO&quot;.
    /// </summary>
    [EnumMember(Value = "SRPO")]
    [IsoId("_xx6bj7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for Rep payment / charge.")]
    RepPaymentCharge,

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SRPP&quot;.
    /// </summary>
    [EnumMember(Value = "SRPP")]
    [IsoId("_xx6bpb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for supplemental interim activity related adjustment.")]
    SupplementalInterimActivity,

    /// <summary>
    /// Adjustment sub-reason is that this adjustment represents credits/debits to your account in lieu of reorganisation deposit activity.
    /// Encoded/decoded by serializers as &quot;SPRG&quot;.
    /// </summary>
    [EnumMember(Value = "SPRG")]
    [IsoId("_xxT_GL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that this adjustment represents credits/debits to your account in lieu of reorganisation deposit activity."
    )]
    InLieuOfReorganisationDepositActivity,

    /// <summary>
    /// Adjustment sub-reason is that this allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information.
    /// Encoded/decoded by serializers as &quot;SRTA&quot;.
    /// </summary>
    [EnumMember(Value = "SRTA")]
    [IsoId("_xxT_B7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that this allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information."
    )]
    RateChange,

    /// <summary>
    /// Adjustment sub-reason is for allocation adjustment for dividend reinvestment due to price correction by the agent.
    /// Encoded/decoded by serializers as &quot;SSA6&quot;.
    /// </summary>
    [EnumMember(Value = "SSA6")]
    [IsoId("_xxT_EL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for allocation adjustment for dividend reinvestment due to price correction by the agent."
    )]
    PriceCorrectionDividendReinvestment,

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash due on an accrued stock payment.
    /// Encoded/decoded by serializers as &quot;SSBK&quot;.
    /// </summary>
    [EnumMember(Value = "SSBK")]
    [IsoId("_xx6btb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash due on an accrued stock payment."
    )]
    CashDueOnAccruedStockPayment,

    /// <summary>
    /// Adjustment sub-reason is for dividend reinvestment allocation why not on normal event.
    /// Encoded/decoded by serializers as &quot;SSC6&quot;.
    /// </summary>
    [EnumMember(Value = "SSC6")]
    [IsoId("_xxT_Fr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for dividend reinvestment allocation why not on normal event."
    )]
    DividendReinvestmentAllocation,

    /// <summary>
    /// Adjustment sub-reason is for accrued cash due on a stock dividend adjustment made on user defined date.
    /// Encoded/decoded by serializers as &quot;SSCK&quot;.
    /// </summary>
    [EnumMember(Value = "SSCK")]
    [IsoId("_xx6btr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for accrued cash due on a stock dividend adjustment made on user defined date."
    )]
    CashDueOnStockDividend,

    /// <summary>
    /// Adjustment sub-reason is for an adjustment to your dividend reinvestment (DRP) position related adjustment.
    /// Encoded/decoded by serializers as &quot;SSD6&quot;.
    /// </summary>
    [EnumMember(Value = "SSD6")]
    [IsoId("_xxT_JL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an adjustment to your dividend reinvestment (DRP) position related adjustment."
    )]
    AdjustmentToYourDividendReinvestmentPosition,

    /// <summary>
    /// Adjustment sub-reason is for accrued cash due on DRP share allocation.
    /// Encoded/decoded by serializers as &quot;SSDK&quot;.
    /// </summary>
    [EnumMember(Value = "SSDK")]
    [IsoId("_xx6bob_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for accrued cash due on DRP share allocation.")]
    CashDueOnDRPShareAllocation,

    /// <summary>
    /// Adjustment sub-reason is for dividend reinvestment allocation of cash in lieu of fractions related adjustment.
    /// Encoded/decoded by serializers as &quot;SSE6&quot;.
    /// </summary>
    [EnumMember(Value = "SSE6")]
    [IsoId("_xx6bYr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for dividend reinvestment allocation of cash in lieu of fractions related adjustment."
    )]
    DividendReinvestmentAllocationOfCashInLieuOfFractions,

    /// <summary>
    /// Adjustment sub-reason is for an adjustment for cash-in-lieu of fractional shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSJJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSJJ")]
    [IsoId("_xx6bbr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an adjustment for cash-in-lieu of fractional shares related adjustment."
    )]
    CashInLieuOfFractionalShares,

    /// <summary>
    /// Adjustment sub-reason is for stock loan related payment or charge.
    /// Encoded/decoded by serializers as &quot;SSLA&quot;.
    /// </summary>
    [EnumMember(Value = "SSLA")]
    [IsoId("_xx6bk7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for stock loan related payment or charge.|")]
    StockLoanAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity from Midwest (6942).
    /// Encoded/decoded by serializers as &quot;SSME&quot;.
    /// </summary>
    [EnumMember(Value = "SSME")]
    [IsoId("_xxT_HL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for supplemental interim activity from Midwest (6942)."
    )]
    SupplementalInterimActivityFromMidwest,

    /// <summary>
    /// Adjustment sub-reason is for proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSP4&quot;.
    /// </summary>
    [EnumMember(Value = "SSP4")]
    [IsoId("_xx6bXb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsFromBuyTransactionInDividendTradingAccount,

    /// <summary>
    /// Adjustment sub-reason is for supplemental interim activity from Philadelphia (6070).
    /// Encoded/decoded by serializers as &quot;SSPE&quot;.
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_xxT_Mr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for supplemental interim activity from Philadelphia (6070)."
    )]
    SupplementalInterimActivityFromPhiladelphia,

    /// <summary>
    /// Adjustment sub-reason is for stock loan or repo payment order related adjustment.
    /// Encoded/decoded by serializers as &quot;SSPO&quot;.
    /// </summary>
    [EnumMember(Value = "SSPO")]
    [IsoId("_xxT_Jr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for stock loan or repo payment order related adjustment."
    )]
    StockLoanOrRepoPaymentOrder,

    /// <summary>
    /// Adjustment sub-reason is for share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR4&quot;.
    /// </summary>
    [EnumMember(Value = "SSR4")]
    [IsoId("_xx6bf7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentFromBuyTransactionInDividendTradingAccount,

    /// <summary>
    /// Adjustment sub-reason is for share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR5&quot;.
    /// </summary>
    [EnumMember(Value = "SSR5")]
    [IsoId("_xx6bs7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentFromSellTransactionInDividendTradingAccount,

    /// <summary>
    /// Adjustment sub-reason is that, as per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSR6&quot;.
    /// </summary>
    [EnumMember(Value = "SSR6")]
    [IsoId("_xxT_FL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that, as per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment."
    )]
    ChargeInLieuOfReceiptOfDividendReinvestment,

    /// <summary>
    /// Adjustment sub-reason is for an allocation adjustment due to fractions rounded up by the agent related adjustment.
    /// Encoded/decoded by serializers as &quot;SSRJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_xx6bnL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an allocation adjustment due to fractions rounded up by the agent related adjustment."
    )]
    AllocationAdjustmentDueToFractionsRoundedUpByAgent,

    /// <summary>
    /// Adjustment sub-reason is for proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSS5&quot;.
    /// </summary>
    [EnumMember(Value = "SSS5")]
    [IsoId("_xxT_NL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsFromSellTransactionInDividendTradingAccount,

    /// <summary>
    /// Adjustment sub-reason is for dividend allocation adjustment due to your sub accounting instructions to the agent.
    /// Encoded/decoded by serializers as &quot;SSS6&quot;.
    /// </summary>
    [EnumMember(Value = "SSS6")]
    [IsoId("_xx6bWL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for dividend allocation adjustment due to your sub accounting instructions to the agent."
    )]
    DividendReinvestmentAllocationAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for an allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.
    /// Encoded/decoded by serializers as &quot;SST6&quot;.
    /// </summary>
    [EnumMember(Value = "SST6")]
    [IsoId("_xx6bW7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for an allocation of dividend reinvestment shares - DRP/TEDS instruction @100%."
    )]
    AllocationOfDRPTEDSInstruction,

    /// <summary>
    /// Adjustment sub-reason is to adjust allocation at 100% on your tax exempt instructions.
    /// Encoded/decoded by serializers as &quot;STEA&quot;.
    /// </summary>
    [EnumMember(Value = "STEA")]
    [IsoId("_xx6bkb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is to adjust allocation at 100% on your tax exempt instructions."
    )]
    TaxExemptInstructions,

    /// <summary>
    /// Adjustment sub-reason is for withdrawal by transfer - lost certificate over the record date was registered in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SWG1&quot;.
    /// </summary>
    [EnumMember(Value = "SWG1")]
    [IsoId("_xxT_KL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for withdrawal by transfer - lost certificate over the record date was registered in the name of your customer."
    )]
    LostCertificateWasRegisteredInTheNameOfYourCustomer,

    /// <summary>
    /// Adjustment sub-reason is that our record date position was adjusted for a withdrawal by transfer activity.
    /// Encoded/decoded by serializers as &quot;SWHT&quot;.
    /// </summary>
    [EnumMember(Value = "SWHT")]
    [IsoId("_xx6bbb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that our record date position was adjusted for a withdrawal by transfer activity."
    )]
    RecordDatePositionAdjustedForWithdrawalByTransfer,

    /// <summary>
    /// Adjustment sub-reason is for adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date.
    /// Encoded/decoded by serializers as &quot;SWL1&quot;.
    /// </summary>
    [EnumMember(Value = "SWL1")]
    [IsoId("_xxT_DL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date."
    )]
    WithdrawalByTransferNotTransferredIntoClientsName,

    /// <summary>
    /// Adjustment sub-reason code is for adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name.
    /// Encoded/decoded by serializers as &quot;SWM1&quot;.
    /// </summary>
    [EnumMember(Value = "SWM1")]
    [IsoId("_xxT_Bb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason code is for adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name."
    )]
    WithdrawalByTransferSetUpAfterCutOffDateTransferIntoClientsName,

    /// <summary>
    /// Adjustment sub-reason is that your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s).
    /// Encoded/decoded by serializers as &quot;SWN1&quot;.
    /// </summary>
    [EnumMember(Value = "SWN1")]
    [IsoId("_xx6bhL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s)."
    )]
    PositionReinstatedCertificatesIssuedAndOutstanding,

    /// <summary>
    /// Adjustment sub-reason is for a reversal of a withdrawal by transfer adjustment.
    /// Encoded/decoded by serializers as &quot;SWRH&quot;.
    /// </summary>
    [EnumMember(Value = "SWRH")]
    [IsoId("_xxT_Jb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for a reversal of a withdrawal by transfer adjustment."
    )]
    ReversalOfWithdrawalByTransfer,

    /// <summary>
    /// Adjustment sub-reason is for adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country.
    /// Encoded/decoded by serializers as &quot;SWTA&quot;.
    /// </summary>
    [EnumMember(Value = "SWTA")]
    [IsoId("_xx6be7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country."
    )]
    WithholdingTaxAdjustmentInUserDefinedCountry,

    /// <summary>
    /// Adjustment sub-reason is that your account is being credited at the unfavourable rate (20%) as a result of the reorg merger paid on 4/2/93 (Armstrong Pharm to Medeva plc, effective 1/15/93). If entitled to favourable rate(15%), you must follow attached.
    /// Encoded/decoded by serializers as &quot;SAA7&quot;.
    /// </summary>
    [EnumMember(Value = "SAA7")]
    [IsoId("_xx6bWb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your account is being credited at the unfavourable rate (20%) as a result of the reorg merger paid on 4/2/93 (Armstrong Pharm to Medeva plc, effective 1/15/93). If entitled to favourable rate(15%), you must follow attached."
    )]
    UnfavourableRateMerger,

    /// <summary>
    /// Adjustment sub-reason is for allocation of fractional rights.
    /// Encoded/decoded by serializers as &quot;SAFR&quot;.
    /// </summary>
    [EnumMember(Value = "SAFR")]
    [IsoId("_xx6blb_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for allocation of fractional rights.")]
    FractionalRights,

    /// <summary>
    /// Adjustment sub-reason is that your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase.
    /// Encoded/decoded by serializers as &quot;SBB3&quot;.
    /// </summary>
    [EnumMember(Value = "SBB3")]
    [IsoId("_xx6buL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase."
    )]
    DWACAdjustment,

    /// <summary>
    /// Adjustment sub-reason is for foreign cash dividends allocation at unfavourable rate.
    /// Encoded/decoded by serializers as &quot;SFL9&quot;.
    /// </summary>
    [EnumMember(Value = "SFL9")]
    [IsoId("_xx6brb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for foreign cash dividends allocation at unfavourable rate."
    )]
    ForeignCashDividendUnfavourableRate,

    /// <summary>
    /// Adjustment sub-reason is as per memo requesting a frozen letter movement from part number.
    /// Encoded/decoded by serializers as &quot;SFRO&quot;.
    /// </summary>
    [EnumMember(Value = "SFRO")]
    [IsoId("_xx6bi7_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is as per memo requesting a frozen letter movement from part number."
    )]
    FrozenLetterMovement,

    /// <summary>
    /// Adjustment sub-reason is for option to receive Vodafone Group American Depository Receipt at 11.354392 for every 100 ADRS.
    /// Encoded/decoded by serializers as &quot;SRRA&quot;.
    /// </summary>
    [EnumMember(Value = "SRRA")]
    [IsoId("_xxT_Ar_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for option to receive Vodafone Group American Depository Receipt at 11.354392 for every 100 ADRS."
    )]
    VodaphoneADR,

    /// <summary>
    /// Adjustment sub-reason is for a distribution of additional rights for round up of fractions as requested for your beneficial owners.
    /// Encoded/decoded by serializers as &quot;SRTJ&quot;.
    /// </summary>
    [EnumMember(Value = "SRTJ")]
    [IsoId("_xxT_Cr_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for a distribution of additional rights for round up of fractions as requested for your beneficial owners."
    )]
    AdditionalRightsForBeneficialOwner,

    /// <summary>
    /// Adjustment sub-reason is for a bond paying in baby bonds that are issued in minimum/incremental denominations. This is to adjust for the amount of pending unissued bonds.
    /// Encoded/decoded by serializers as &quot;SSDJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSDJ")]
    [IsoId("_xx6bdb_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is for a bond paying in baby bonds that are issued in minimum/incremental denominations. This is to adjust for the amount of pending unissued bonds."
    )]
    BabyBondPayment,

    /// <summary>
    /// Adjustment sub-reason is for due bill fail tracking reversal.
    /// Encoded/decoded by serializers as &quot;SSFR&quot;.
    /// </summary>
    [EnumMember(Value = "SSFR")]
    [IsoId("_xx6bWr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for due bill fail tracking reversal.")]
    DueBillReversal,

    /// <summary>
    /// Adjustment sub-reason is for due bill fail tracking.
    /// Encoded/decoded by serializers as &quot;SSFF&quot;.
    /// </summary>
    [EnumMember(Value = "SSFF")]
    [IsoId("_xx6bpr_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for due bill fail tracking.")]
    DueBillFailTracking,

    /// <summary>
    /// Adjustment sub-reason is for an allocation of spinoff security.
    /// Encoded/decoded by serializers as &quot;SSOS&quot;.
    /// </summary>
    [EnumMember(Value = "SSOS")]
    [IsoId("_xx6bib_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for an allocation of spinoff security.")]
    SpinOffAllocation,

    /// <summary>
    /// Adjustment sub-reason is that an agent paid DTC based on combined fractions for all public service New Hampshire. New spinoffs distributed on July 25, 1991.
    /// Encoded/decoded by serializers as &quot;SSPJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSPJ")]
    [IsoId("_xx6bkL_kEeeb2ZBoAlSG1Q")]
    [Description(
        @"Adjustment sub-reason is that an agent paid DTC based on combined fractions for all public service New Hampshire. New spinoffs distributed on July 25, 1991."
    )]
    AgentPaidBasedOnCombinedFractions,

    /// <summary>
    /// Adjustment sub-reason is for an allocation of a pay in kind distribution.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_xx6bn7_kEeeb2ZBoAlSG1Q")]
    [Description(@"Adjustment sub-reason is for an allocation of a pay in kind distribution.")]
    PaynInKindDistribution,

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_xx6bXL_kEeeb2ZBoAlSG1Q")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
}
