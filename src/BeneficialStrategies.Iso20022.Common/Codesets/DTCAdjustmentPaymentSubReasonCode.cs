// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9k5cgGfhEeOB5r-GpjGdRQ")]
[Description(@"Specifies the subtype of the payment adjustment.")]
[Derivations(typeof(DTCAdjustmentPaymentSubReason1Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum DTCAdjustmentPaymentSubReasonCode
{
    /// <summary>
    /// Reorganization related adjustment on user defined date.
    /// Encoded/decoded by serializers as &quot;S777&quot;.
    /// </summary>
    [EnumMember(Value = "S777")]
    [IsoId("_a7mbUGfjEeOB5r-GpjGdRQ")]
    [Description(@"Reorganization related adjustment on user defined date.")]
    ReorganizationRelatedAdjustment,

    /// <summary>
    /// The interest due on the above cusip was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date.
    /// Encoded/decoded by serializers as &quot;S66P&quot;.
    /// </summary>
    [EnumMember(Value = "S66P")]
    [IsoId("_ot1cIGfjEeOB5r-GpjGdRQ")]
    [Description(
        @"The interest due on the above cusip was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date."
    )]
    InterestDueWasErroneouslyPaidToYouByTheIssuer,

    /// <summary>
    /// Allocation of baby bonds amount to be exited in USD.
    /// Encoded/decoded by serializers as &quot;SABA&quot;.
    /// </summary>
    [EnumMember(Value = "SABA")]
    [IsoId("_-NajIGfjEeOB5r-GpjGdRQ")]
    [Description(@"Allocation of baby bonds amount to be exited in USD.")]
    AllocationOfBabyBondsAmountToBeExited,

    /// <summary>
    /// Interest or dividend due on conversion related adjustment.
    /// Encoded/decoded by serializers as &quot;SAC7&quot;.
    /// </summary>
    [EnumMember(Value = "SAC7")]
    [IsoId("_-mr-wGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest or dividend due on conversion related adjustment.")]
    InterestorDividendDueOnConversion,

    /// <summary>
    /// The accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SACA&quot;.
    /// </summary>
    [EnumMember(Value = "SACA")]
    [IsoId("_-tOroGfjEeOB5r-GpjGdRQ")]
    [Description(
        @"The accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    AccruedInterestWrongRate,

    /// <summary>
    /// Interest adjusted due to early withdrawal (certificate of deposit).
    /// Encoded/decoded by serializers as &quot;SACB&quot;.
    /// </summary>
    [EnumMember(Value = "SACB")]
    [IsoId("_-yzIIGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest adjusted due to early withdrawal (certificate of deposit).")]
    InterestAdjustedDueToEarlyWithdrawal,

    /// <summary>
    /// Accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_-4F30GfjEeOB5r-GpjGdRQ")]
    [Description(
        @"Accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest."
    )]
    AccruedInterestNotPaid,

    /// <summary>
    /// Company in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADA&quot;.
    /// </summary>
    [EnumMember(Value = "SADA")]
    [IsoId("_-9bDwGfjEeOB5r-GpjGdRQ")]
    [Description(@"Company in default related adjustment.")]
    CompanyInDefault,

    /// <summary>
    /// Issue in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADM&quot;.
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("__CuagGfjEeOB5r-GpjGdRQ")]
    [Description(@"Issue in default related adjustment.")]
    IssueInDefault,

    /// <summary>
    /// Interest allocated in error first payment on &quot;date user defined&quot;.
    /// Encoded/decoded by serializers as &quot;SAEA&quot;.
    /// </summary>
    [EnumMember(Value = "SAEA")]
    [IsoId("__IHQ0GfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest allocated in error first payment on ""date user defined"".")]
    InterestAllocatedInError,

    /// <summary>
    /// Interest adjusted due to tender fee deduction.
    /// Encoded/decoded by serializers as &quot;SAF7&quot;.
    /// </summary>
    [EnumMember(Value = "SAF7")]
    [IsoId("__NaAgGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest adjusted due to tender fee deduction.")]
    TenderFeeDeduction,

    /// <summary>
    /// Supplementary interim on user defined date.
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("__SswMGfjEeOB5r-GpjGdRQ")]
    [Description(@"Supplementary interim on user defined date.")]
    SupplementaryInterimOn,

    /// <summary>
    /// Company is taking 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("__YAG8GfjEeOB5r-GpjGdRQ")]
    [Description(@"Company is taking 30 day grace period.")]
    GracePeriod,

    /// <summary>
    /// Payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAHA&quot;.
    /// </summary>
    [EnumMember(Value = "SAHA")]
    [IsoId("__ddOsGfjEeOB5r-GpjGdRQ")]
    [Description(@"Payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).")]
    PaymentOfFullAvoidFiscalTaxRefund,

    /// <summary>
    /// Adjustment to avoid fiscal payment.
    /// Encoded/decoded by serializers as &quot;SAIA&quot;.
    /// </summary>
    [EnumMember(Value = "SAIA")]
    [IsoId("__iwlcGfjEeOB5r-GpjGdRQ")]
    [Description(@"Adjustment to avoid fiscal payment.")]
    AdjustmentToAvoidFiscalPayment,

    /// <summary>
    /// Revision of charge for withholding tax.
    /// Encoded/decoded by serializers as &quot;SAJA&quot;.
    /// </summary>
    [EnumMember(Value = "SAJA")]
    [IsoId("__oINoGfjEeOB5r-GpjGdRQ")]
    [Description(@"Revision of charge for withholding tax.")]
    RevisionOfChargeForWithholdingTax,

    /// <summary>
    /// Interest or dividend due on merger related adjustment.
    /// Encoded/decoded by serializers as &quot;SAM7&quot;.
    /// </summary>
    [EnumMember(Value = "SAM7")]
    [IsoId("__tcLcGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest or dividend due on merger related adjustment.")]
    InterestOrDividendDueOnMerger,

    /// <summary>
    /// Interest pays at maturity. Allocated in error onn user defined date.
    /// Encoded/decoded by serializers as &quot;SAMA&quot;.
    /// </summary>
    [EnumMember(Value = "SAMA")]
    [IsoId("__yu7IGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest pays at maturity. Allocated in error onn user defined date.")]
    InterestPaysAtMaturity,

    /// <summary>
    /// Company never declared dividend adjust allocation on user defined date.
    /// Encoded/decoded by serializers as &quot;SANA&quot;.
    /// </summary>
    [EnumMember(Value = "SANA")]
    [IsoId("__4EuIGfjEeOB5r-GpjGdRQ")]
    [Description(@"Company never declared dividend adjust allocation on user defined date.")]
    CompanyDidNotDeclareDividend,

    /// <summary>
    /// Interest or dividend due on repayment option.
    /// Encoded/decoded by serializers as &quot;SAP7&quot;.
    /// </summary>
    [EnumMember(Value = "SAP7")]
    [IsoId("__9fZoGfjEeOB5r-GpjGdRQ")]
    [Description(@"Interest or dividend due on repayment option.")]
    InterestOrDividendDueOnRepaymentOption,

    /// <summary>
    /// Payment of partial avoid fiscal tax refund (equal to 15% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAPA&quot;.
    /// </summary>
    [EnumMember(Value = "SAPA")]
    [IsoId("_AC9IcGfkEeOB5r-GpjGdRQ")]
    [Description(@"Payment of partial avoid fiscal tax refund (equal to 15% of the dividend).")]
    PaymentOfPartialAvoidFiscalTaxRefund,

    /// <summary>
    /// Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_AIXM4GfkEeOB5r-GpjGdRQ")]
    [Description(
        @"Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest."
    )]
    CalledCertificatesAccruedErroneousInterestChargeBack,

    /// <summary>
    /// Interest or dividend due on redemption.
    /// Encoded/decoded by serializers as &quot;SAR7&quot;.
    /// </summary>
    [EnumMember(Value = "SAR7")]
    [IsoId("_ANxRUGfkEeOB5r-GpjGdRQ")]
    [Description(@"Interest or dividend due on redemption.")]
    InterestOrDividendDueOnRedemption,

    /// <summary>
    /// Allocation for a Participant position that was assumed by your goodselves paid on - retired Participant number.
    /// Encoded/decoded by serializers as &quot;SARA&quot;.
    /// </summary>
    [EnumMember(Value = "SARA")]
    [IsoId("_ATHEUGfkEeOB5r-GpjGdRQ")]
    [Description(
        @"Allocation for a Participant position that was assumed by your goodselves paid on - retired Participant number."
    )]
    AssumedByYourGoodselves,

    /// <summary>
    /// Allocation of script shares amount to be exited in dollar value.
    /// Encoded/decoded by serializers as &quot;SASA&quot;.
    /// </summary>
    [EnumMember(Value = "SASA")]
    [IsoId("_AYeFcGfkEeOB5r-GpjGdRQ")]
    [Description(@"Allocation of script shares amount to be exited in dollar value.")]
    ScriptSharesExited,

    /// <summary>
    /// Interestor dividend due on tender.
    /// Encoded/decoded by serializers as &quot;SAT7&quot;.
    /// </summary>
    [EnumMember(Value = "SAT7")]
    [IsoId("_Ad1GkGfkEeOB5r-GpjGdRQ")]
    [Description(@"Interestor dividend due on tender.")]
    InterestOrDividendDueOnTender,

    /// <summary>
    /// Uninsured interest withheld as per FSLICN.
    /// Encoded/decoded by serializers as &quot;SAWA&quot;.
    /// </summary>
    [EnumMember(Value = "SAWA")]
    [IsoId("_AjN84GfkEeOB5r-GpjGdRQ")]
    [Description(@"Uninsured interest withheld as per FSLICN.")]
    UninsuredInterestWithheld,

    /// <summary>
    /// Your record date position was adjusted for a DWAC buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SSBB&quot;.
    /// </summary>
    [EnumMember(Value = "SSBB")]
    [IsoId("_AqmXQGfkEeOB5r-GpjGdRQ")]
    [Description(@"Your record date position was adjusted for a DWAC buy back withdrawal.")]
    DWACBuyBackWithdrawal,

    /// <summary>
    /// Your record date position was adjusted for a COD buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB1&quot;.
    /// </summary>
    [EnumMember(Value = "SBB1")]
    [IsoId("_A63A0GfkEeOB5r-GpjGdRQ")]
    [Description(@"Your record date position was adjusted for a COD buy back withdrawal.")]
    CODBuyBackWithdrawal,

    /// <summary>
    /// Your record date position was adjusted for a w/t buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB2&quot;.
    /// </summary>
    [EnumMember(Value = "SBB2")]
    [IsoId("_W7S1UGfoEeOB5r-GpjGdRQ")]
    [Description(@"Your record date position was adjusted for a w/t buy back withdrawal.")]
    WithdrawalTransferBuyBackWithdrawal,

    /// <summary>
    /// Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SBDB&quot;.
    /// </summary>
    [EnumMember(Value = "SBDB")]
    [IsoId("_XcoAwGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your goodselves."
    )]
    CODWithdrawalNotDeliveredAndCertificatesInTheNameOfYourGoodselves,

    /// <summary>
    /// Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SBEB&quot;.
    /// </summary>
    [EnumMember(Value = "SBEB")]
    [IsoId("_XiIL0GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee."
    )]
    CODWithdrawalNotDeliveredAndCertificatesIssuedInTheNameOfYourNominee,

    /// <summary>
    /// Reversal of a COD withdrawal related adjustment.
    /// Encoded/decoded by serializers as &quot;SBRH&quot;.
    /// </summary>
    [EnumMember(Value = "SBRH")]
    [IsoId("_XnyH4GfoEeOB5r-GpjGdRQ")]
    [Description(@"Reversal of a COD withdrawal related adjustment.")]
    ReversalOfACODWithdrawal,

    /// <summary>
    /// Custody payment.
    /// Encoded/decoded by serializers as &quot;SCDP&quot;.
    /// </summary>
    [EnumMember(Value = "SCDP")]
    [IsoId("_Xtu-4GfoEeOB5r-GpjGdRQ")]
    [Description(@"Custody payment.")]
    CustodyPayment,

    /// <summary>
    /// Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal proceeds via check, but in your customer’s name. we are forwarding the check today. this adjustment is to charge you for the funds.
    /// Encoded/decoded by serializers as &quot;SCKS&quot;.
    /// </summary>
    [EnumMember(Value = "SCKS")]
    [IsoId("_XzPJ8GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal proceeds via check, but in your customer’s name. we are forwarding the check today. this adjustment is to charge you for the funds."
    )]
    CalledCertificatesCheckInParticipantsNameChargeBack,

    /// <summary>
    /// Adjustment made for the Pacific depository (3097).
    /// Encoded/decoded by serializers as &quot;SCLU&quot;.
    /// </summary>
    [EnumMember(Value = "SCLU")]
    [IsoId("_X4lkAGfoEeOB5r-GpjGdRQ")]
    [Description(@"Adjustment made for the Pacific depository (3097).")]
    PacificDepository,

    /// <summary>
    /// Adjustment made for the Midwest depository (6942).
    /// Encoded/decoded by serializers as &quot;SCMU&quot;.
    /// </summary>
    [EnumMember(Value = "SCMU")]
    [IsoId("_X98lIGfoEeOB5r-GpjGdRQ")]
    [Description(@"Adjustment made for the Midwest depository (6942).")]
    MidwestDepository,

    /// <summary>
    /// Adjustment made for the Philadelphia depository (6070).
    /// Encoded/decoded by serializers as &quot;SCNU&quot;.
    /// </summary>
    [EnumMember(Value = "SCNU")]
    [IsoId("_YDTmQGfoEeOB5r-GpjGdRQ")]
    [Description(@"Adjustment made for the Philadelphia depository (6070).")]
    PhiladelphiaDepository,

    /// <summary>
    /// Accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCPK&quot;.
    /// </summary>
    [EnumMember(Value = "SCPK")]
    [IsoId("_YIg2YGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Accrual claim payment related to a stock distribution payable on user defined date."
    )]
    AccrualClaimPayment,

    /// <summary>
    /// Part claim payment.
    /// Encoded/decoded by serializers as &quot;SCPP&quot;.
    /// </summary>
    [EnumMember(Value = "SCPP")]
    [IsoId("_YN3QcGfoEeOB5r-GpjGdRQ")]
    [Description(@"Part claim payment.")]
    PartClaimPayment,

    /// <summary>
    /// Reversal of an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCRK&quot;.
    /// </summary>
    [EnumMember(Value = "SCRK")]
    [IsoId("_YTORkGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Reversal of an accrual claim payment related to a stock distribution payable on user defined date."
    )]
    ReversalOfAnAccrualClaimPayment,

    /// <summary>
    /// Part-claim reversal.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_YYbhsGfoEeOB5r-GpjGdRQ")]
    [Description(@"Part-claim reversal.")]
    PartClaimReversal,

    /// <summary>
    /// Coupon collection service adjustment for coupon deposit.
    /// Encoded/decoded by serializers as &quot;SCSM&quot;.
    /// </summary>
    [EnumMember(Value = "SCSM")]
    [IsoId("_Ydox0GfoEeOB5r-GpjGdRQ")]
    [Description(@"Coupon collection service adjustment for coupon deposit.")]
    CouponCollectionService,

    /// <summary>
    /// Reversal of a deposit adjustment.
    /// Encoded/decoded by serializers as &quot;SDRH&quot;.
    /// </summary>
    [EnumMember(Value = "SDRH")]
    [IsoId("_YjI84GfoEeOB5r-GpjGdRQ")]
    [Description(@"Reversal of a deposit adjustment.")]
    ReversalOfADeposit,

    /// <summary>
    /// Your record date position was adjusted for deliver order (DO) activity.
    /// Encoded/decoded by serializers as &quot;SEEE&quot;.
    /// </summary>
    [EnumMember(Value = "SEEE")]
    [IsoId("_Yof-AGfoEeOB5r-GpjGdRQ")]
    [Description(@"Your record date position was adjusted for deliver order (DO) activity.")]
    DeliverOrderActivity,

    /// <summary>
    /// Shares escheated to New York state in error; affidavit to follow. This is to reverse.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_YttOIGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Shares escheated to New York state in error; affidavit to follow. This is to reverse."
    )]
    ReverseOfTheSharesEscheatedToNYStateInError,

    /// <summary>
    /// As per agent, this charge is for french avoid fiscal tax credit.
    /// Encoded/decoded by serializers as &quot;SFAF&quot;.
    /// </summary>
    [EnumMember(Value = "SFAF")]
    [IsoId("_YzDoMGfoEeOB5r-GpjGdRQ")]
    [Description(@"As per agent, this charge is for french avoid fiscal tax credit.")]
    ChargeForFrenchAvoidFiscalTaxCredit,

    /// <summary>
    /// Funds previously escheated to ny state, affidavit to follow this is to reverse escheated amount of claim paid on user defined date.
    /// Encoded/decoded by serializers as &quot;SFAP&quot;.
    /// </summary>
    [EnumMember(Value = "SFAP")]
    [IsoId("_Y4apUGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Funds previously escheated to ny state, affidavit to follow this is to reverse escheated amount of claim paid on user defined date."
    )]
    ReverseOfEscheatedAmountOfClaim,

    /// <summary>
    /// Foreign cash dividends/bond interest allocation at exempt rate.
    /// Encoded/decoded by serializers as &quot;SFE8&quot;.
    /// </summary>
    [EnumMember(Value = "SFE8")]
    [IsoId("_Y9xqcGfoEeOB5r-GpjGdRQ")]
    [Description(@"Foreign cash dividends/bond interest allocation at exempt rate.")]
    ForeignCashDividendsOrBondInterestAllocationAtExemptRate,

    /// <summary>
    /// Foreign cash dividends/bonds interest allocation at favorable rate.
    /// Encoded/decoded by serializers as &quot;SFF8&quot;.
    /// </summary>
    [EnumMember(Value = "SFF8")]
    [IsoId("_ZC-6kGfoEeOB5r-GpjGdRQ")]
    [Description(@"Foreign cash dividends/bonds interest allocation at favorable rate.")]
    ForeignCashDividendsOrBondsInterestAllocationAtFavorableRate,

    /// <summary>
    /// Fifteen percent french withholding tax, based on your option election of 100% ADRs at the favorable rate.
    /// Encoded/decoded by serializers as &quot;SFG8&quot;.
    /// </summary>
    [EnumMember(Value = "SFG8")]
    [IsoId("_ZIVUoGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Fifteen percent french withholding tax, based on your option election of 100% ADRs at the favorable rate."
    )]
    FrenchWithholdingTax15Percent,

    /// <summary>
    /// Twenty five percent french withholding tax, based on your option election of 100% ADRs at the unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFG9&quot;.
    /// </summary>
    [EnumMember(Value = "SFG9")]
    [IsoId("_ZTMg0GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Twenty five percent french withholding tax, based on your option election of 100% ADRs at the unfavorable rate."
    )]
    FrenchWithholdingTax25Percent,

    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your [user defined].
    /// Encoded/decoded by serializers as &quot;SDAD&quot;.
    /// </summary>
    [EnumMember(Value = "SDAD")]
    [IsoId("_Zb-CUGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your [user defined]."
    )]
    DepositLostCertificateOverTheRecordDateWasRegisteredInTheNameOfYour,

    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SDBD&quot;.
    /// </summary>
    [EnumMember(Value = "SDBD")]
    [IsoId("_ZjQ9IGfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your goodselves."
    )]
    LostCertificateRegisteredInTheNameOfYourGoodselves,

    /// <summary>
    /// Deposit after cut off date transferred into the name of the CEDE on record date.
    /// Encoded/decoded by serializers as &quot;SDCD&quot;.
    /// </summary>
    [EnumMember(Value = "SDCD")]
    [IsoId("_arty8GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Deposit after cut off date transferred into the name of the CEDE on record date."
    )]
    DepositTransferredIntoTheNameOfTheCEDEAndCo,

    /// <summary>
    /// Your record date position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SDDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDDD")]
    [IsoId("_ax9k4GfoEeOB5r-GpjGdRQ")]
    [Description(@"Your record date position was adjusted for deposit activity.")]
    PositionAdjustedForDepositActivity,

    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SDED&quot;.
    /// </summary>
    [EnumMember(Value = "SDED")]
    [IsoId("_a3xR8GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your nominee."
    )]
    LostCertificateWasRegisteredInTheNameOfYourNominee,

    /// <summary>
    /// You deposited securities that were previously called. the agent paid DTCC the redemption proceeds. this adjustment is to pass these proceeds on to you. your free account security position will be adjusted (shorted) today for the called quantity.
    /// Encoded/decoded by serializers as &quot;SDEP&quot;.
    /// </summary>
    [EnumMember(Value = "SDEP")]
    [IsoId("_a9uI8GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"You deposited securities that were previously called. the agent paid DTCC the redemption proceeds. this adjustment is to pass these proceeds on to you. your free account security position will be adjusted (shorted) today for the called quantity."
    )]
    PreviouslyCalledCertificatesFundsDelivery,

    /// <summary>
    /// CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend.
    /// Encoded/decoded by serializers as &quot;SDMT&quot;.
    /// </summary>
    [EnumMember(Value = "SDMT")]
    [IsoId("_bD0J4GfoEeOB5r-GpjGdRQ")]
    [Description(
        @"CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend."
    )]
    CTFSHeldOverRecordDateOnWhichWeGuaranteeToHoldYouFreeAndHarmless,

    /// <summary>
    /// Ten percent french withholding tax, based on your revised instructions to reduce favorable tax status to unfavorable.
    /// Encoded/decoded by serializers as &quot;SFH9&quot;.
    /// </summary>
    [EnumMember(Value = "SFH9")]
    [IsoId("_TDr-sGf1EeOB5r-GpjGdRQ")]
    [Description(
        @"Ten percent french withholding tax, based on your revised instructions to reduce favorable tax status to unfavorable."
    )]
    FrenchWithholdingTax10Percent,

    /// <summary>
    /// Required lists contained discrepancies or were not forwarded to french paying agent. This charge is at user defined withholding rate.
    /// Encoded/decoded by serializers as &quot;SFI9&quot;.
    /// </summary>
    [EnumMember(Value = "SFI9")]
    [IsoId("_TRX1YGf1EeOB5r-GpjGdRQ")]
    [Description(
        @"Required lists contained discrepancies or were not forwarded to french paying agent. This charge is at user defined withholding rate."
    )]
    ChargeAtWithholdingRate,

    /// <summary>
    /// The 25% french withholding rate has been revised. This adjustment is based on the refunded tax rate.
    /// Encoded/decoded by serializers as &quot;SFJ9&quot;.
    /// </summary>
    [EnumMember(Value = "SFJ9")]
    [IsoId("_TXBxcGf1EeOB5r-GpjGdRQ")]
    [Description(
        @"The 25% french withholding rate has been revised. This adjustment is based on the refunded tax rate."
    )]
    RefundedTaxRate,

    /// <summary>
    /// Rate unknown for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL0&quot;.
    /// </summary>
    [EnumMember(Value = "SFL0")]
    [IsoId("_TcrtgGf1EeOB5r-GpjGdRQ")]
    [Description(@"Rate unknown for fail tracking related adjustment.")]
    RateUnknown,

    /// <summary>
    /// Deletefor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL1&quot;.
    /// </summary>
    [EnumMember(Value = "SFL1")]
    [IsoId("_TiL4kGf1EeOB5r-GpjGdRQ")]
    [Description(@"Deletefor fail tracking related adjustment.")]
    Delete,

    /// <summary>
    /// Reinstate for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL2&quot;.
    /// </summary>
    [EnumMember(Value = "SFL2")]
    [IsoId("_Tn10oGf1EeOB5r-GpjGdRQ")]
    [Description(@"Reinstate for fail tracking related adjustment.")]
    Reinstate,

    /// <summary>
    /// Post date changefor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL3&quot;.
    /// </summary>
    [EnumMember(Value = "SFL3")]
    [IsoId("_To4WcGf1EeOB5r-GpjGdRQ")]
    [Description(@"Post date changefor fail tracking related adjustment.")]
    PostDateChangeForFailTracking,

    /// <summary>
    /// Announcement deleted for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLD&quot;.
    /// </summary>
    [EnumMember(Value = "SFLD")]
    [IsoId("_TtfwsGf1EeOB5r-GpjGdRQ")]
    [Description(@"Announcement deleted for fail tracking related adjustment.")]
    AnnouncementDeletedOrFailTracking,

    /// <summary>
    /// Due bill for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLE&quot;.
    /// </summary>
    [EnumMember(Value = "SFLE")]
    [IsoId("_TuYhgGf1EeOB5r-GpjGdRQ")]
    [Description(@"Due bill for fail tracking related adjustment.")]
    DueBill,

    /// <summary>
    /// Fail tracking for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLL&quot;.
    /// </summary>
    [EnumMember(Value = "SFLL")]
    [IsoId("_TzcnsGf1EeOB5r-GpjGdRQ")]
    [Description(@"Fail tracking for fail tracking related adjustment.")]
    LateAnnouncement,

    /// <summary>
    /// Date revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLN&quot;.
    /// </summary>
    [EnumMember(Value = "SFLN")]
    [IsoId("_T4Da4Gf1EeOB5r-GpjGdRQ")]
    [Description(@"Date revision for fail tracking related adjustment.")]
    DateRevision,

    /// <summary>
    /// Rate revisionfor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLR&quot;.
    /// </summary>
    [EnumMember(Value = "SFLR")]
    [IsoId("_T4NL4Gf1EeOB5r-GpjGdRQ")]
    [Description(@"Rate revisionfor fail tracking related adjustment.")]
    RateRevision,

    /// <summary>
    /// Non allocation for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLS&quot;.
    /// </summary>
    [EnumMember(Value = "SFLS")]
    [IsoId("_T93H8Gf1EeOB5r-GpjGdRQ")]
    [Description(@"Non allocation for fail tracking related adjustment.")]
    NonAllocation,

    /// <summary>
    /// Refund of french tax based on acceptance of global reclamation for the june 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRA&quot;.
    /// </summary>
    [EnumMember(Value = "SFRA")]
    [IsoId("_UCeiMGf1EeOB5r-GpjGdRQ")]
    [Description(
        @"Refund of french tax based on acceptance of global reclamation for the june 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJune,

    /// <summary>
    /// Refund of french tax based on acceptance of global reclamation for the july 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRB&quot;.
    /// </summary>
    [EnumMember(Value = "SFRB")]
    [IsoId("_UCeiMWf1EeOB5r-GpjGdRQ")]
    [Description(
        @"Refund of french tax based on acceptance of global reclamation for the july 1992 distribution refer to important notice b # 1352‑93."
    )]
    RefundOfFrenchTaxJuly,

    /// <summary>
    /// Foreign cash dividends or bond interest allocation at unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFU9&quot;.
    /// </summary>
    [EnumMember(Value = "SFU9")]
    [IsoId("_UHPGYGf1EeOB5r-GpjGdRQ")]
    [Description(@"Foreign cash dividends or bond interest allocation at unfavorable rate.")]
    ForeignCashDividendsOrBondInterestAllocationAtUnfavorableRate,

    /// <summary>
    /// Redemption cash settlement.
    /// Encoded/decoded by serializers as &quot;SGL7&quot;.
    /// </summary>
    [EnumMember(Value = "SGL7")]
    [IsoId("_UL15kGf1EeOB5r-GpjGdRQ")]
    [Description(@"Redemption cash settlement.")]
    RedemptionCash,

    /// <summary>
    /// Allocation adjustment.
    /// Encoded/decoded by serializers as &quot;SGLA&quot;.
    /// </summary>
    [EnumMember(Value = "SGLA")]
    [IsoId("_UL15kWf1EeOB5r-GpjGdRQ")]
    [Description(@"Allocation adjustment.")]
    AllocationAdjustment,

    /// <summary>
    /// Muni bearer bond coupon adjustment (same as line 118).
    /// Encoded/decoded by serializers as &quot;SGLM&quot;.
    /// </summary>
    [EnumMember(Value = "SGLM")]
    [IsoId("_UR8hkGf1EeOB5r-GpjGdRQ")]
    [Description(@"Muni bearer bond coupon adjustment (same as line 118).")]
    MuniBearerBond,

    /// <summary>
    /// Redemption payment due to pledge release.
    /// Encoded/decoded by serializers as &quot;SGLP&quot;.
    /// </summary>
    [EnumMember(Value = "SGLP")]
    [IsoId("_UR8hkWf1EeOB5r-GpjGdRQ")]
    [Description(@"Redemption payment due to pledge release.")]
    RedemptionPaymentDueToPledgeRelease,

    /// <summary>
    /// DTCC claim on registered holder in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SGLQ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLQ")]
    [IsoId("_0cPUAGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim on registered holder in the name of your goodselves.")]
    DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves,

    /// <summary>
    /// In settlement of a trade - DTCC reorg account 428-10271-1-2-039.
    /// Encoded/decoded by serializers as &quot;SGLT&quot;.
    /// </summary>
    [EnumMember(Value = "SGLT")]
    [IsoId("_1dsxAGiTEeOdXoiw6mfXMw")]
    [Description(@"In settlement of a trade - DTCC reorg account 428-10271-1-2-039.")]
    InSettlementOfATradeDTCCReorgAccount,

    /// <summary>
    /// DTCC claim on registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SGLZ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLZ")]
    [IsoId("_1lvSsGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim on registered holder in the name of your customer.")]
    DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer,

    /// <summary>
    /// Your interim position was adjusted for deliver orderactivity.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_1teSYGiTEeOdXoiw6mfXMw")]
    [Description(@"Your interim position was adjusted for deliver orderactivity.")]
    InterimPositionAdjustedForDeliverOrderActivity,

    /// <summary>
    /// Late announcement activity due bill activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SILL&quot;.
    /// </summary>
    [EnumMember(Value = "SILL")]
    [IsoId("_106XIGiTEeOdXoiw6mfXMw")]
    [Description(@"Late announcement activity due bill activity related adjustment.")]
    LateAnnouncementActivityDueBillActivity,

    /// <summary>
    /// DTCC COD withdrawal adjustment.
    /// Encoded/decoded by serializers as &quot;SJCB&quot;.
    /// </summary>
    [EnumMember(Value = "SJCB")]
    [IsoId("_18Wb4GiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC COD withdrawal adjustment.")]
    CODWithdrawal,

    /// <summary>
    /// DTCC deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SJDD&quot;.
    /// </summary>
    [EnumMember(Value = "SJDD")]
    [IsoId("_2D7qkGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC deposit related adjustment.")]
    DepositAdjustment,

    /// <summary>
    /// DTCC redemption related adjustment.
    /// Encoded/decoded by serializers as &quot;SJE7&quot;.
    /// </summary>
    [EnumMember(Value = "SJE7")]
    [IsoId("_2LOlYGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC redemption related adjustment.")]
    RedemptionAdjustment,

    /// <summary>
    /// DTCC pledge release related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEE&quot;.
    /// </summary>
    [EnumMember(Value = "SJEE")]
    [IsoId("_2SqqIGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC pledge release related adjustment.")]
    PledgeReleaseAdjustment,

    /// <summary>
    /// Write off reorganization related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEW&quot;.
    /// </summary>
    [EnumMember(Value = "SJEW")]
    [IsoId("_2VWKsGiTEeOdXoiw6mfXMw")]
    [Description(@"Write off reorganization related adjustment.")]
    WriteOffReorganization,

    /// <summary>
    /// DTCC investment id related adjustment.
    /// Encoded/decoded by serializers as &quot;SJIE&quot;.
    /// </summary>
    [EnumMember(Value = "SJIE")]
    [IsoId("_2coecGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC investment id related adjustment.")]
    InvestmentIdAdjustment,

    /// <summary>
    /// DTCC pledge related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEF&quot;.
    /// </summary>
    [EnumMember(Value = "SJEF")]
    [IsoId("_2j6yMGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC pledge related adjustment.")]
    PledgeAdjustment,

    /// <summary>
    /// DTCC deliver order related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEG&quot;.
    /// </summary>
    [EnumMember(Value = "SJEG")]
    [IsoId("_2rNtAGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC deliver order related adjustment.")]
    DeliverOrder,

    /// <summary>
    /// DTCC reorganization related adjustment.
    /// Encoded/decoded by serializers as &quot;SJR7&quot;.
    /// </summary>
    [EnumMember(Value = "SJR7")]
    [IsoId("_2ypxwGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC reorganization related adjustment.|")]
    ReorganizationAdjustment,

    /// <summary>
    /// DTCC WT related adjustment.
    /// Encoded/decoded by serializers as &quot;SJWT&quot;.
    /// </summary>
    [EnumMember(Value = "SJWT")]
    [IsoId("_26F2gGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC WT related adjustment.")]
    WithdrawalTransferAdjustment,

    /// <summary>
    /// DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLCP&quot;.
    /// </summary>
    [EnumMember(Value = "SLCP")]
    [IsoId("_3BYKQGiTEeOdXoiw6mfXMw")]
    [Description(
        @"DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomerLateTransfer,

    /// <summary>
    /// DTCC claim against registered holder in the name of your goodselves. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLGP&quot;.
    /// </summary>
    [EnumMember(Value = "SLGP")]
    [IsoId("_3GlaYGiTEeOdXoiw6mfXMw")]
    [Description(
        @"DTCC claim against registered holder in the name of your goodselves. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselvesLateTransfer,

    /// <summary>
    /// DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLNP&quot;.
    /// </summary>
    [EnumMember(Value = "SLNP")]
    [IsoId("_3NlaQGiTEeOdXoiw6mfXMw")]
    [Description(
        @"DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent."
    )]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourNominee,

    /// <summary>
    /// Muni bearer bond coupon related adjustment.
    /// Encoded/decoded by serializers as &quot;SMAM&quot;.
    /// </summary>
    [EnumMember(Value = "SMAM")]
    [IsoId("_3U3uAGiTEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon related adjustment.")]
    MuniBearerBondCoupon,

    /// <summary>
    /// Muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SMBM&quot;.
    /// </summary>
    [EnumMember(Value = "SMBM")]
    [IsoId("_3hEW8GiTEeOdXoiw6mfXMw")]
    [Description(
        @"Muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment."
    )]
    MuniBearerBondCouponAdjustmentForCouponsMissingFromaDeposit,

    /// <summary>
    /// Muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.
    /// Encoded/decoded by serializers as &quot;SMCM&quot;.
    /// </summary>
    [EnumMember(Value = "SMCM")]
    [IsoId("_31crgGiTEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.")]
    MuniBearerBondCouponAdjustmentForCouponsMissingFromaWithdrawal,

    /// <summary>
    /// Muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date.
    /// Encoded/decoded by serializers as &quot;SMDM&quot;.
    /// </summary>
    [EnumMember(Value = "SMDM")]
    [IsoId("_39ChQGiTEeOdXoiw6mfXMw")]
    [Description(
        @"Muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsWithdrawnOn,

    /// <summary>
    /// Muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date.
    /// Encoded/decoded by serializers as &quot;SMEM&quot;.
    /// </summary>
    [EnumMember(Value = "SMEM")]
    [IsoId("_4EU1AGiTEeOdXoiw6mfXMw")]
    [Description(
        @"Muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date."
    )]
    MuniBearerBondCouponAdjustmentExcessCouponsDepositedOn,

    /// <summary>
    /// Muni bearer bond coupon adjustment your interim position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SMMM&quot;.
    /// </summary>
    [EnumMember(Value = "SMMM")]
    [IsoId("_4OTQYGiTEeOdXoiw6mfXMw")]
    [Description(
        @"Muni bearer bond coupon adjustment your interim position was adjusted for deposit activity."
    )]
    MuniBearerBondCouponPositionAdjustedForDepositActivity,

    /// <summary>
    /// Adjustment for cash on increased shares due to a stock distribution payable.
    /// Encoded/decoded by serializers as &quot;SNNG&quot;.
    /// </summary>
    [EnumMember(Value = "SNNG")]
    [IsoId("_4VlkIGiTEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash on increased shares due to a stock distribution payable.")]
    AdjustmentForCashOnIncreasedShares,

    /// <summary>
    /// Optional dividend (ops) allocation related adjustment.
    /// Encoded/decoded by serializers as &quot;SOP2&quot;.
    /// </summary>
    [EnumMember(Value = "SOP2")]
    [IsoId("_4irk8GiTEeOdXoiw6mfXMw")]
    [Description(@"Optional dividend (ops) allocation related adjustment.")]
    OptionalDividendAllocationAdjustment,

    /// <summary>
    /// DTCC claim against registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SPCP&quot;.
    /// </summary>
    [EnumMember(Value = "SPCP")]
    [IsoId("_4rdGcGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your customer.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomer,

    /// <summary>
    /// Proceeds from sale of.
    /// Encoded/decoded by serializers as &quot;SPFS&quot;.
    /// </summary>
    [EnumMember(Value = "SPFS")]
    [IsoId("_4zoyEGiTEeOdXoiw6mfXMw")]
    [Description(@"Proceeds from sale of.")]
    ProceedsFromSaleOf,

    /// <summary>
    /// DTCC claim against registered holder in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SPGP&quot;.
    /// </summary>
    [EnumMember(Value = "SPGP")]
    [IsoId("_470dsGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your goodselves.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselves,

    /// <summary>
    /// DTCC claim against registered holder in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SPNP&quot;.
    /// </summary>
    [EnumMember(Value = "SPNP")]
    [IsoId("_5Jg7cGiTEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your nominee.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourNomineeLateTransfer,

    /// <summary>
    /// The principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SPRA&quot;.
    /// </summary>
    [EnumMember(Value = "SPRA")]
    [IsoId("_DQFacGiiEeOdXoiw6mfXMw")]
    [Description(
        @"The principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment."
    )]
    WrongRatePrincipal,

    /// <summary>
    /// This adjustment is in responve to your written inquiry.
    /// Encoded/decoded by serializers as &quot;SRAH&quot;.
    /// </summary>
    [EnumMember(Value = "SRAH")]
    [IsoId("_D5vbcGiiEeOdXoiw6mfXMw")]
    [Description(@"This adjustment is in responve to your written inquiry.")]
    AdjustmentForWrittenInquiry,

    /// <summary>
    /// Allocation adjustment due to a change in the record date.
    /// Encoded/decoded by serializers as &quot;SRDA&quot;.
    /// </summary>
    [EnumMember(Value = "SRDA")]
    [IsoId("_EAvbUGiiEeOdXoiw6mfXMw")]
    [Description(@"Allocation adjustment due to a change in the record date.")]
    ChangeInTheRecordDate,

    /// <summary>
    /// This adjustment is in response to your inquiry. refer to control number:
    /// Encoded/decoded by serializers as &quot;SRIH&quot;.
    /// </summary>
    [EnumMember(Value = "SRIH")]
    [IsoId("_EHu0IGiiEeOdXoiw6mfXMw")]
    [Description(@"This adjustment is in response to your inquiry. refer to control number:")]
    AdjustmentIsInResponseToYourInquiry,

    /// <summary>
    /// Rep payment/charge.
    /// Encoded/decoded by serializers as &quot;SRPO&quot;.
    /// </summary>
    [EnumMember(Value = "SRPO")]
    [IsoId("_EO398GiiEeOdXoiw6mfXMw")]
    [Description(@"Rep payment/charge.")]
    RepPaymentCharge,

    /// <summary>
    /// Supplemental interim activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SRPP&quot;.
    /// </summary>
    [EnumMember(Value = "SRPP")]
    [IsoId("_EVtlwGiiEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity related adjustment.")]
    SupplementalInterimActivity,

    /// <summary>
    /// This adjustment represents credits/debits to your account in lieu of reorg deposit activity.
    /// Encoded/decoded by serializers as &quot;SPRG&quot;.
    /// </summary>
    [EnumMember(Value = "SPRG")]
    [IsoId("_FUpTMGiiEeOdXoiw6mfXMw")]
    [Description(
        @"This adjustment represents credits/debits to your account in lieu of reorg deposit activity."
    )]
    InLieuOfReorgDepositActivity,

    /// <summary>
    /// This allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information.
    /// Encoded/decoded by serializers as &quot;SRTA&quot;.
    /// </summary>
    [EnumMember(Value = "SRTA")]
    [IsoId("_FbosAGiiEeOdXoiw6mfXMw")]
    [Description(
        @"This allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information."
    )]
    RateChange,

    /// <summary>
    /// Allocation adjustment for dividend reinvestment due to price correction by the agent.
    /// Encoded/decoded by serializers as &quot;SSA6&quot;.
    /// </summary>
    [EnumMember(Value = "SSA6")]
    [IsoId("_FiVJ4GiiEeOdXoiw6mfXMw")]
    [Description(
        @"Allocation adjustment for dividend reinvestment due to price correction by the agent."
    )]
    PriceCorrectionDividendReinvestment,

    /// <summary>
    /// Adjustment for cash due on an accrued stock payment.
    /// Encoded/decoded by serializers as &quot;SSBK&quot;.
    /// </summary>
    [EnumMember(Value = "SSBK")]
    [IsoId("_FpLYwGiiEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash due on an accrued stock payment.")]
    CashDueOnAnAccruedStockPayment,

    /// <summary>
    /// Dividend reinvestment allocation why not on normal event.
    /// Encoded/decoded by serializers as &quot;SSC6&quot;.
    /// </summary>
    [EnumMember(Value = "SSC6")]
    [IsoId("_FwKxkGiiEeOdXoiw6mfXMw")]
    [Description(@"Dividend reinvestment allocation why not on normal event.")]
    DividendReinvestmentAllocation,

    /// <summary>
    /// Accrued cash due on a stock dividend adjustment made on user defined date.
    /// Encoded/decoded by serializers as &quot;SSCK&quot;.
    /// </summary>
    [EnumMember(Value = "SSCK")]
    [IsoId("_F23PcGiiEeOdXoiw6mfXMw")]
    [Description(@"Accrued cash due on a stock dividend adjustment made on user defined date.")]
    CashDueOnStockDividend,

    /// <summary>
    /// Adjustment to your dividend reinvestment (DRP) position related adjustment.
    /// Encoded/decoded by serializers as &quot;SSD6&quot;.
    /// </summary>
    [EnumMember(Value = "SSD6")]
    [IsoId("_F9jtUGiiEeOdXoiw6mfXMw")]
    [Description(@"Adjustment to your dividend reinvestment (DRP) position related adjustment.")]
    AdjustmentToYourDividendReinvestmentPosition,

    /// <summary>
    /// Accrued cash due on DRP share allocation.
    /// Encoded/decoded by serializers as &quot;SSDK&quot;.
    /// </summary>
    [EnumMember(Value = "SSDK")]
    [IsoId("_GLZVAGiiEeOdXoiw6mfXMw")]
    [Description(@"Accrued cash due on DRP share allocation.")]
    CashDueOnDRPShareAllocation,

    /// <summary>
    /// Dividend reinvestment (DRP) allocation of cash in lieu of fractions related adjustment.
    /// Encoded/decoded by serializers as &quot;SSE6&quot;.
    /// </summary>
    [EnumMember(Value = "SSE6")]
    [IsoId("_GSFy4GiiEeOdXoiw6mfXMw")]
    [Description(
        @"Dividend reinvestment (DRP) allocation of cash in lieu of fractions related adjustment."
    )]
    DividendReinvestmentAllocationOfCashInLieuOfFractions,

    /// <summary>
    /// Adjustment for cash-in-lieu of fractional shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSJJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSJJ")]
    [IsoId("_GZO8sGiiEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash-in-lieu of fractional shares related adjustment.")]
    AdjustmentForCashInLieuOfFractionalShares,

    /// <summary>
    /// Stock loan related payment or charge.
    /// Encoded/decoded by serializers as &quot;SSLA&quot;.
    /// </summary>
    [EnumMember(Value = "SSLA")]
    [IsoId("_GgFLkGiiEeOdXoiw6mfXMw")]
    [Description(@"Stock loan related payment or charge.|")]
    StockLoanAdjustment,

    /// <summary>
    /// Supplemental interim activity from midwest (6942).
    /// Encoded/decoded by serializers as &quot;SSME&quot;.
    /// </summary>
    [EnumMember(Value = "SSME")]
    [IsoId("_GmxpcGiiEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity from midwest (6942).")]
    SupplementalInterimActivityFromMidwest,

    /// <summary>
    /// Proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSP4&quot;.
    /// </summary>
    [EnumMember(Value = "SSP4")]
    [IsoId("_UNzkMGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsFromBuyTransactionInOurDTCCDividendTradingAccount,

    /// <summary>
    /// Supplemental interim activity from Philadelphia (6070).
    /// Encoded/decoded by serializers as &quot;SSPE&quot;.
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_U8EYYGjAEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity from Philadelphia (6070).")]
    SupplementalInterimActivityFromPhiladelphia,

    /// <summary>
    /// Stock loan or repo payment order related adjustment.
    /// Encoded/decoded by serializers as &quot;SSPO&quot;.
    /// </summary>
    [EnumMember(Value = "SSPO")]
    [IsoId("_VDNiMGjAEeOdXoiw6mfXMw")]
    [Description(@"Stock loan or repo payment order related adjustment.")]
    StockLoanOrRepoPaymentOrder,

    /// <summary>
    /// Share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR4&quot;.
    /// </summary>
    [EnumMember(Value = "SSR4")]
    [IsoId("_VKM7AGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentFromABuyTransactionInOurDTCCDividendTradingAccount,

    /// <summary>
    /// Share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR5&quot;.
    /// </summary>
    [EnumMember(Value = "SSR5")]
    [IsoId("_VRMT0GjAEeOdXoiw6mfXMw")]
    [Description(
        @"Share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ShareAdjustmentResultingFromASellTransactionAffectedInOurDTCCDividendTradingAccount,

    /// <summary>
    /// As per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSR6&quot;.
    /// </summary>
    [EnumMember(Value = "SSR6")]
    [IsoId("_VUBlYGjAEeOdXoiw6mfXMw")]
    [Description(
        @"As per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment."
    )]
    ChargeInLieuOfReceiptOfDividendReinvestment,

    /// <summary>
    /// Allocation adjustment due to fractions rounded up by the agent related adjustment.
    /// Encoded/decoded by serializers as &quot;SSRJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_VfLsgGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Allocation adjustment due to fractions rounded up by the agent related adjustment."
    )]
    AllocationAdjustmentDueToFractionsRoundedUpByTheAgent,

    /// <summary>
    /// Proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSS5&quot;.
    /// </summary>
    [EnumMember(Value = "SSS5")]
    [IsoId("_VmLFUGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039)."
    )]
    ProceedsResultingFromaASellTransactionAffectedInOurDTCCDividendTradingAccount,

    /// <summary>
    /// DRP allocation adjustment due to your sub accounting instructions to the agent.
    /// Encoded/decoded by serializers as &quot;SSS6&quot;.
    /// </summary>
    [EnumMember(Value = "SSS6")]
    [IsoId("_VteAIGjAEeOdXoiw6mfXMw")]
    [Description(
        @"DRP allocation adjustment due to your sub accounting instructions to the agent."
    )]
    DividendReinvestmentAllocationAdjustmentDueToYourSubAccountingInstructionsToTheAgent,

    /// <summary>
    /// Allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.
    /// Encoded/decoded by serializers as &quot;SST6&quot;.
    /// </summary>
    [EnumMember(Value = "SST6")]
    [IsoId("_V0Tn8GjAEeOdXoiw6mfXMw")]
    [Description(@"Allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.")]
    AllocationOfDRPTEDSInstruction,

    /// <summary>
    /// To adjust allocation at 100% on your tax exempt instructions.
    /// Encoded/decoded by serializers as &quot;STEA&quot;.
    /// </summary>
    [EnumMember(Value = "STEA")]
    [IsoId("_V7J20GjAEeOdXoiw6mfXMw")]
    [Description(@"To adjust allocation at 100% on your tax exempt instructions.")]
    TaxExemptInstructions,

    /// <summary>
    /// Withdrawal by transfer - lost certificate over the record date was registered in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SWG1&quot;.
    /// </summary>
    [EnumMember(Value = "SWG1")]
    [IsoId("_WCJPoGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Withdrawal by transfer - lost certificate over the record date was registered in the name of your customer."
    )]
    LostCertificateWasRegisteredInTheNameOfYourCustomer,

    /// <summary>
    /// Our record date position was adjusted for a withdrawal by transfer activity.
    /// Encoded/decoded by serializers as &quot;SWHT&quot;.
    /// </summary>
    [EnumMember(Value = "SWHT")]
    [IsoId("_WI_egGjAEeOdXoiw6mfXMw")]
    [Description(@"Our record date position was adjusted for a withdrawal by transfer activity.")]
    RecordDatePositionAdjustedForaWithdrawalByTransfer,

    /// <summary>
    /// Adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date.
    /// Encoded/decoded by serializers as &quot;SWL1&quot;.
    /// </summary>
    [EnumMember(Value = "SWL1")]
    [IsoId("_WP1GUGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date."
    )]
    AdjustmentForAWithdrawalByTransferNotTransferredIntoYourClientsName,

    /// <summary>
    /// Adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name.
    /// Encoded/decoded by serializers as &quot;SWM1&quot;.
    /// </summary>
    [EnumMember(Value = "SWM1")]
    [IsoId("_WW0fIGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name."
    )]
    AdjustmentMadeForAWithdrawalByTransferSetUpAfterTheCutOffDateMadeTransferIntoYourClientsName,

    /// <summary>
    /// Your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s).
    /// Encoded/decoded by serializers as &quot;SWN1&quot;.
    /// </summary>
    [EnumMember(Value = "SWN1")]
    [IsoId("_Wd9o8GjAEeOdXoiw6mfXMw")]
    [Description(
        @"Your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s)."
    )]
    PositionReinstatedCertificatesIssuedAndOutstandingInTheNameOfYourCustomers,

    /// <summary>
    /// Reversal of a withdrawal by transfer adjustment.
    /// Encoded/decoded by serializers as &quot;SWRH&quot;.
    /// </summary>
    [EnumMember(Value = "SWRH")]
    [IsoId("_Wk9BwGjAEeOdXoiw6mfXMw")]
    [Description(@"Reversal of a withdrawal by transfer adjustment.")]
    ReversalOfaWithdrawalByTransfer,

    /// <summary>
    /// Adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country.
    /// Encoded/decoded by serializers as &quot;SWTA&quot;.
    /// </summary>
    [EnumMember(Value = "SWTA")]
    [IsoId("_Wr9BoGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country."
    )]
    WithholdingTaxAdjustmentInUserDefinedCountry,

    /// <summary>
    /// Your account is being credited at the unfav rate (20%) as a result of the reorg merger pd on 4/2/93 (Armstrong Pharm to Medeva plc, eff 1/15/93; if entitled to fav rate(15%), you must follow attached.
    /// Encoded/decoded by serializers as &quot;SAA7&quot;.
    /// </summary>
    [EnumMember(Value = "SAA7")]
    [IsoId("_WyypcGjAEeOdXoiw6mfXMw")]
    [Description(
        @"Your account is being credited at the unfav rate (20%) as a result of the reorg merger pd on 4/2/93 (Armstrong Pharm to Medeva plc, eff 1/15/93; if entitled to fav rate(15%), you must follow attached."
    )]
    UnfavorableRateMerger,

    /// <summary>
    /// Allocation of fractional rights.
    /// Encoded/decoded by serializers as &quot;SAFR&quot;.
    /// </summary>
    [EnumMember(Value = "SAFR")]
    [IsoId("_W5o4UGjAEeOdXoiw6mfXMw")]
    [Description(@"Allocation of fractional rights.")]
    FractionalRights,

    /// <summary>
    /// Your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase.
    /// Encoded/decoded by serializers as &quot;SBB3&quot;.
    /// </summary>
    [EnumMember(Value = "SBB3")]
    [IsoId("_8xQS0GjCEeOdXoiw6mfXMw")]
    [Description(
        @"Your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase."
    )]
    DWACAdjustment,

    /// <summary>
    /// Foreign cash dividends allocation at unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFL9&quot;.
    /// </summary>
    [EnumMember(Value = "SFL9")]
    [IsoId("_9DG30GjCEeOdXoiw6mfXMw")]
    [Description(@"Foreign cash dividends allocation at unfavorable rate.")]
    ForeignCashDividendUnfavorableRate,

    /// <summary>
    /// As per memo requesting a frozen letter movement from part number.
    /// Encoded/decoded by serializers as &quot;SFRO&quot;.
    /// </summary>
    [EnumMember(Value = "SFRO")]
    [IsoId("_9tqQsGjCEeOdXoiw6mfXMw")]
    [Description(@"As per memo requesting a frozen letter movement from part number.")]
    FrozenLetterMovement,

    /// <summary>
    /// Option to receive Vodafone Group adrs at 11.354392 for every 100 adrs.
    /// Encoded/decoded by serializers as &quot;SRRA&quot;.
    /// </summary>
    [EnumMember(Value = "SRRA")]
    [IsoId("_91GVcGjCEeOdXoiw6mfXMw")]
    [Description(@"Option to receive Vodafone Group adrs at 11.354392 for every 100 adrs.")]
    VodaphoneADR,

    /// <summary>
    /// Distribution of additional rights for round up of fractions as requested for your beneficial owners.
    /// Encoded/decoded by serializers as &quot;SRTJ&quot;.
    /// </summary>
    [EnumMember(Value = "SRTJ")]
    [IsoId("_98FuQGjCEeOdXoiw6mfXMw")]
    [Description(
        @"Distribution of additional rights for round up of fractions as requested for your beneficial owners."
    )]
    AdditionalRightsForBeneficialOwner,

    /// <summary>
    /// Bond pays in baby bonds that are issued in minimum/incre-mental denominations; this is to adjust for the amount of pending unissued bonds.
    /// Encoded/decoded by serializers as &quot;SSDJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSDJ")]
    [IsoId("_-DFHEGjCEeOdXoiw6mfXMw")]
    [Description(
        @"Bond pays in baby bonds that are issued in minimum/incre-mental denominations; this is to adjust for the amount of pending unissued bonds."
    )]
    BabyBondPayment,

    /// <summary>
    /// Due bill fail tracking reversal.
    /// Encoded/decoded by serializers as &quot;SSFR&quot;.
    /// </summary>
    [EnumMember(Value = "SSFR")]
    [IsoId("_-KOQ4GjCEeOdXoiw6mfXMw")]
    [Description(@"Due bill fail tracking reversal.")]
    DueBillReversal,

    /// <summary>
    /// Due bill fail tracking.
    /// Encoded/decoded by serializers as &quot;SSFF&quot;.
    /// </summary>
    [EnumMember(Value = "SSFF")]
    [IsoId("_-RNpsGjCEeOdXoiw6mfXMw")]
    [Description(@"Due bill fail tracking.")]
    DueBillFailTracking,

    /// <summary>
    /// Allocation of spinoff security.
    /// Encoded/decoded by serializers as &quot;SSOS&quot;.
    /// </summary>
    [EnumMember(Value = "SSOS")]
    [IsoId("_-YWzgGjCEeOdXoiw6mfXMw")]
    [Description(@"Allocation of spinoff security.")]
    SpinOffAllocation,

    /// <summary>
    /// Agent paid DTC based on combined fractions for all public service–new hamp.(new) spinoffs distributed on july 25, 1991.
    /// Encoded/decoded by serializers as &quot;SSPJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSPJ")]
    [IsoId("_-fWMUGjCEeOdXoiw6mfXMw")]
    [Description(
        @"Agent paid DTC based on combined fractions for all public service–new hamp.(new) spinoffs distributed on july 25, 1991."
    )]
    AgentPaidBasedOnCombinedFractions,

    /// <summary>
    /// Allocation of a Pay in Kind distribution.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_-mMbMGjCEeOdXoiw6mfXMw")]
    [Description(@"Allocation of a Pay in Kind distribution.")]
    PaynInKindDistribution,

    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-teu8GjCEeOdXoiw6mfXMw")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other,
}
