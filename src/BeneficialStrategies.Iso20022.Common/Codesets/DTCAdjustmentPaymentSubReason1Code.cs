// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the subtype of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j-SZYGjLEeOdXoiw6mfXMw")]
[Description(@"Specifies the subtype of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentSubReasonCode))]
public enum DTCAdjustmentPaymentSubReason1Code
{
    /// <summary>
    /// Reorganization related adjustment on user defined date.
    /// Encoded/decoded by serializers as &quot;S777&quot;.
    /// </summary>
    [EnumMember(Value = "S777")]
    [IsoId("_pnv8QWjLEeOdXoiw6mfXMw")]
    [Description(@"Reorganization related adjustment on user defined date.")]
    ReorganizationRelatedAdjustment = DTCAdjustmentPaymentSubReasonCode.ReorganizationRelatedAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rep payment/charge.
    /// Encoded/decoded by serializers as &quot;SRPO&quot;.
    /// </summary>
    [EnumMember(Value = "SRPO")]
    [IsoId("_puL7cWjLEeOdXoiw6mfXMw")]
    [Description(@"Rep payment/charge.")]
    RepPaymentCharge = DTCAdjustmentPaymentSubReasonCode.RepPaymentCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of a COD withdrawal related adjustment.
    /// Encoded/decoded by serializers as &quot;SBRH&quot;.
    /// </summary>
    [EnumMember(Value = "SBRH")]
    [IsoId("_p0pIwWjLEeOdXoiw6mfXMw")]
    [Description(@"Reversal of a COD withdrawal related adjustment.")]
    ReversalOfACODWithdrawal = DTCAdjustmentPaymentSubReasonCode.ReversalOfACODWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of a deposit adjustment.
    /// Encoded/decoded by serializers as &quot;SDRH&quot;.
    /// </summary>
    [EnumMember(Value = "SDRH")]
    [IsoId("_p7Eg4WjLEeOdXoiw6mfXMw")]
    [Description(@"Reversal of a deposit adjustment.")]
    ReversalOfADeposit = DTCAdjustmentPaymentSubReasonCode.ReversalOfADeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of an accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCRK&quot;.
    /// </summary>
    [EnumMember(Value = "SCRK")]
    [IsoId("_qBi8UWjLEeOdXoiw6mfXMw")]
    [Description(@"Reversal of an accrual claim payment related to a stock distribution payable on user defined date.")]
    ReversalOfAnAccrualClaimPayment = DTCAdjustmentPaymentSubReasonCode.ReversalOfAnAccrualClaimPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of a withdrawal by transfer adjustment.
    /// Encoded/decoded by serializers as &quot;SWRH&quot;.
    /// </summary>
    [EnumMember(Value = "SWRH")]
    [IsoId("_qDn_8WjLEeOdXoiw6mfXMw")]
    [Description(@"Reversal of a withdrawal by transfer adjustment.")]
    ReversalOfaWithdrawalByTransfer = DTCAdjustmentPaymentSubReasonCode.ReversalOfaWithdrawalByTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds previously escheated to ny state, affidavit to follow this is to reverse escheated amount of claim paid on user defined date.
    /// Encoded/decoded by serializers as &quot;SFAP&quot;.
    /// </summary>
    [EnumMember(Value = "SFAP")]
    [IsoId("_qJ_GoWjLEeOdXoiw6mfXMw")]
    [Description(@"Funds previously escheated to ny state, affidavit to follow this is to reverse escheated amount of claim paid on user defined date.")]
    ReverseOfEscheatedAmountOfClaim = DTCAdjustmentPaymentSubReasonCode.ReverseOfEscheatedAmountOfClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shares escheated to New York state in error; affidavit to follow. This is to reverse.
    /// Encoded/decoded by serializers as &quot;SETO&quot;.
    /// </summary>
    [EnumMember(Value = "SETO")]
    [IsoId("_qMF_cWjLEeOdXoiw6mfXMw")]
    [Description(@"Shares escheated to New York state in error; affidavit to follow. This is to reverse.")]
    ReverseOfTheSharesEscheatedToNYStateInError = DTCAdjustmentPaymentSubReasonCode.ReverseOfTheSharesEscheatedToNYStateInError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Revision of charge for withholding tax.
    /// Encoded/decoded by serializers as &quot;SAJA&quot;.
    /// </summary>
    [EnumMember(Value = "SAJA")]
    [IsoId("_qau4YWjLEeOdXoiw6mfXMw")]
    [Description(@"Revision of charge for withholding tax.")]
    RevisionOfChargeForWithholdingTax = DTCAdjustmentPaymentSubReasonCode.RevisionOfChargeForWithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of script shares amount to be exited in dollar value.
    /// Encoded/decoded by serializers as &quot;SASA&quot;.
    /// </summary>
    [EnumMember(Value = "SASA")]
    [IsoId("_qhNT0WjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation of script shares amount to be exited in dollar value.")]
    ScriptSharesExited = DTCAdjustmentPaymentSubReasonCode.ScriptSharesExited, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR4&quot;.
    /// </summary>
    [EnumMember(Value = "SSR4")]
    [IsoId("_qjWB0WjLEeOdXoiw6mfXMw")]
    [Description(@"Share adjustment resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).")]
    ShareAdjustmentFromABuyTransactionInOurDTCCDividendTradingAccount = DTCAdjustmentPaymentSubReasonCode.ShareAdjustmentFromABuyTransactionInOurDTCCDividendTradingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSR5&quot;.
    /// </summary>
    [EnumMember(Value = "SSR5")]
    [IsoId("_qp5VwWjLEeOdXoiw6mfXMw")]
    [Description(@"Share adjustment resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).")]
    ShareAdjustmentResultingFromASellTransactionAffectedInOurDTCCDividendTradingAccount = DTCAdjustmentPaymentSubReasonCode.ShareAdjustmentResultingFromASellTransactionAffectedInOurDTCCDividendTradingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of spinoff security.
    /// Encoded/decoded by serializers as &quot;SSOS&quot;.
    /// </summary>
    [EnumMember(Value = "SSOS")]
    [IsoId("_qwKV0WjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation of spinoff security.")]
    SpinOffAllocation = DTCAdjustmentPaymentSubReasonCode.SpinOffAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stock loan related payment or charge.
    /// Encoded/decoded by serializers as &quot;SSLA&quot;.
    /// </summary>
    [EnumMember(Value = "SSLA")]
    [IsoId("_q2lG4WjLEeOdXoiw6mfXMw")]
    [Description(@"Stock loan related payment or charge.|")]
    StockLoanAdjustment = DTCAdjustmentPaymentSubReasonCode.StockLoanAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stock loan or repo payment order related adjustment.
    /// Encoded/decoded by serializers as &quot;SSPO&quot;.
    /// </summary>
    [EnumMember(Value = "SSPO")]
    [IsoId("_q4rYoWjLEeOdXoiw6mfXMw")]
    [Description(@"Stock loan or repo payment order related adjustment.")]
    StockLoanOrRepoPaymentOrder = DTCAdjustmentPaymentSubReasonCode.StockLoanOrRepoPaymentOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplemental interim activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SRPP&quot;.
    /// </summary>
    [EnumMember(Value = "SRPP")]
    [IsoId("_q-4uUWjLEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity related adjustment.")]
    SupplementalInterimActivity = DTCAdjustmentPaymentSubReasonCode.SupplementalInterimActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplemental interim activity from midwest (6942).
    /// Encoded/decoded by serializers as &quot;SSME&quot;.
    /// </summary>
    [EnumMember(Value = "SSME")]
    [IsoId("_rBEfoWjLEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity from midwest (6942).")]
    SupplementalInterimActivityFromMidwest = DTCAdjustmentPaymentSubReasonCode.SupplementalInterimActivityFromMidwest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplemental interim activity from Philadelphia (6070).
    /// Encoded/decoded by serializers as &quot;SSPE&quot;.
    /// </summary>
    [EnumMember(Value = "SSPE")]
    [IsoId("_rHhs8WjLEeOdXoiw6mfXMw")]
    [Description(@"Supplemental interim activity from Philadelphia (6070).")]
    SupplementalInterimActivityFromPhiladelphia = DTCAdjustmentPaymentSubReasonCode.SupplementalInterimActivityFromPhiladelphia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Supplementary interim on user defined date.
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_rJn-sWjLEeOdXoiw6mfXMw")]
    [Description(@"Supplementary interim on user defined date.")]
    SupplementaryInterimOn = DTCAdjustmentPaymentSubReasonCode.SupplementaryInterimOn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accrual claim payment related to a stock distribution payable on user defined date.
    /// Encoded/decoded by serializers as &quot;SCPK&quot;.
    /// </summary>
    [EnumMember(Value = "SCPK")]
    [IsoId("_r2azQWjLEeOdXoiw6mfXMw")]
    [Description(@"Accrual claim payment related to a stock distribution payable on user defined date.")]
    AccrualClaimPayment = DTCAdjustmentPaymentSubReasonCode.AccrualClaimPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest.
    /// Encoded/decoded by serializers as &quot;SACP&quot;.
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_r87q8WjLEeOdXoiw6mfXMw")]
    [Description(@"Accrued interest was not previously paid to you for the redemption in this issue. This adjustment is to pay you for this accrued interest.")]
    AccruedInterestNotPaid = DTCAdjustmentPaymentSubReasonCode.AccruedInterestNotPaid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SACA&quot;.
    /// </summary>
    [EnumMember(Value = "SACA")]
    [IsoId("_sDSxoWjLEeOdXoiw6mfXMw")]
    [Description(@"The accrued interest previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.")]
    AccruedInterestWrongRate = DTCAdjustmentPaymentSubReasonCode.AccruedInterestWrongRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of additional rights for round up of fractions as requested for your beneficial owners.
    /// Encoded/decoded by serializers as &quot;SRTJ&quot;.
    /// </summary>
    [EnumMember(Value = "SRTJ")]
    [IsoId("_sJuw0WjLEeOdXoiw6mfXMw")]
    [Description(@"Distribution of additional rights for round up of fractions as requested for your beneficial owners.")]
    AdditionalRightsForBeneficialOwner = DTCAdjustmentPaymentSubReasonCode.AdditionalRightsForBeneficialOwner, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date.
    /// Encoded/decoded by serializers as &quot;SWL1&quot;.
    /// </summary>
    [EnumMember(Value = "SWL1")]
    [IsoId("_sL1CkWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment made for a withdrawal by transfer that was not transferred into your clients name by the record date.")]
    AdjustmentForAWithdrawalByTransferNotTransferredIntoYourClientsName = DTCAdjustmentPaymentSubReasonCode.AdjustmentForAWithdrawalByTransferNotTransferredIntoYourClientsName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment for cash-in-lieu of fractional shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSJJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSJJ")]
    [IsoId("_sSPMkWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash-in-lieu of fractional shares related adjustment.")]
    AdjustmentForCashInLieuOfFractionalShares = DTCAdjustmentPaymentSubReasonCode.AdjustmentForCashInLieuOfFractionalShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment for cash on increased shares due to a stock distribution payable.
    /// Encoded/decoded by serializers as &quot;SNNG&quot;.
    /// </summary>
    [EnumMember(Value = "SNNG")]
    [IsoId("_sUU3QWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash on increased shares due to a stock distribution payable.")]
    AdjustmentForCashOnIncreasedShares = DTCAdjustmentPaymentSubReasonCode.AdjustmentForCashOnIncreasedShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This adjustment is in responve to your written inquiry.
    /// Encoded/decoded by serializers as &quot;SRAH&quot;.
    /// </summary>
    [EnumMember(Value = "SRAH")]
    [IsoId("_z_dW8WjLEeOdXoiw6mfXMw")]
    [Description(@"This adjustment is in responve to your written inquiry.")]
    AdjustmentForWrittenInquiry = DTCAdjustmentPaymentSubReasonCode.AdjustmentForWrittenInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This adjustment is in response to your inquiry. refer to control number:
    /// Encoded/decoded by serializers as &quot;SRIH&quot;.
    /// </summary>
    [EnumMember(Value = "SRIH")]
    [IsoId("_0EHNcWjLEeOdXoiw6mfXMw")]
    [Description(@"This adjustment is in response to your inquiry. refer to control number:")]
    AdjustmentIsInResponseToYourInquiry = DTCAdjustmentPaymentSubReasonCode.AdjustmentIsInResponseToYourInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name.
    /// Encoded/decoded by serializers as &quot;SWM1&quot;.
    /// </summary>
    [EnumMember(Value = "SWM1")]
    [IsoId("_0IWNMWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment made for a withdrawal by transfer set up after the cut off date made transfer into your clients name.")]
    AdjustmentMadeForAWithdrawalByTransferSetUpAfterTheCutOffDateMadeTransferIntoYourClientsName = DTCAdjustmentPaymentSubReasonCode.AdjustmentMadeForAWithdrawalByTransferSetUpAfterTheCutOffDateMadeTransferIntoYourClientsName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment to avoid fiscal payment.
    /// Encoded/decoded by serializers as &quot;SAIA&quot;.
    /// </summary>
    [EnumMember(Value = "SAIA")]
    [IsoId("_0MiJoWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment to avoid fiscal payment.")]
    AdjustmentToAvoidFiscalPayment = DTCAdjustmentPaymentSubReasonCode.AdjustmentToAvoidFiscalPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment to your dividend reinvestment (DRP) position related adjustment.
    /// Encoded/decoded by serializers as &quot;SSD6&quot;.
    /// </summary>
    [EnumMember(Value = "SSD6")]
    [IsoId("_0Qs38WjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment to your dividend reinvestment (DRP) position related adjustment.")]
    AdjustmentToYourDividendReinvestmentPosition = DTCAdjustmentPaymentSubReasonCode.AdjustmentToYourDividendReinvestmentPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent paid DTC based on combined fractions for all public service–new hamp.(new) spinoffs distributed on july 25, 1991.
    /// Encoded/decoded by serializers as &quot;SSPJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSPJ")]
    [IsoId("_0U3mQWjLEeOdXoiw6mfXMw")]
    [Description(@"Agent paid DTC based on combined fractions for all public service–new hamp.(new) spinoffs distributed on july 25, 1991.")]
    AgentPaidBasedOnCombinedFractions = DTCAdjustmentPaymentSubReasonCode.AgentPaidBasedOnCombinedFractions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation adjustment.
    /// Encoded/decoded by serializers as &quot;SGLA&quot;.
    /// </summary>
    [EnumMember(Value = "SGLA")]
    [IsoId("_0aQckWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation adjustment.")]
    AllocationAdjustment = DTCAdjustmentPaymentSubReasonCode.AllocationAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation adjustment due to fractions rounded up by the agent related adjustment.
    /// Encoded/decoded by serializers as &quot;SSRJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_0ioVcWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation adjustment due to fractions rounded up by the agent related adjustment.")]
    AllocationAdjustmentDueToFractionsRoundedUpByTheAgent = DTCAdjustmentPaymentSubReasonCode.AllocationAdjustmentDueToFractionsRoundedUpByTheAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of baby bonds amount to be exited in USD.
    /// Encoded/decoded by serializers as &quot;SABA&quot;.
    /// </summary>
    [EnumMember(Value = "SABA")]
    [IsoId("_0m0R4WjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation of baby bonds amount to be exited in USD.")]
    AllocationOfBabyBondsAmountToBeExited = DTCAdjustmentPaymentSubReasonCode.AllocationOfBabyBondsAmountToBeExited, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.
    /// Encoded/decoded by serializers as &quot;SST6&quot;.
    /// </summary>
    [EnumMember(Value = "SST6")]
    [IsoId("_0q-ZIWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation of dividend reinvestment shares - DRP/TEDS instruction @100%.")]
    AllocationOfDRPTEDSInstruction = DTCAdjustmentPaymentSubReasonCode.AllocationOfDRPTEDSInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Announcement deleted for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLD&quot;.
    /// </summary>
    [EnumMember(Value = "SFLD")]
    [IsoId("_0vIgYWjLEeOdXoiw6mfXMw")]
    [Description(@"Announcement deleted for fail tracking related adjustment.")]
    AnnouncementDeletedOrFailTracking = DTCAdjustmentPaymentSubReasonCode.AnnouncementDeletedOrFailTracking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation for a Participant position that was assumed by your goodselves paid on - retired Participant number.
    /// Encoded/decoded by serializers as &quot;SARA&quot;.
    /// </summary>
    [EnumMember(Value = "SARA")]
    [IsoId("_0zusgWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation for a Participant position that was assumed by your goodselves paid on - retired Participant number.")]
    AssumedByYourGoodselves = DTCAdjustmentPaymentSubReasonCode.AssumedByYourGoodselves, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bond pays in baby bonds that are issued in minimum/incre-mental denominations; this is to adjust for the amount of pending unissued bonds.
    /// Encoded/decoded by serializers as &quot;SSDJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSDJ")]
    [IsoId("_1WkT0WjLEeOdXoiw6mfXMw")]
    [Description(@"Bond pays in baby bonds that are issued in minimum/incre-mental denominations; this is to adjust for the amount of pending unissued bonds.")]
    BabyBondPayment = DTCAdjustmentPaymentSubReasonCode.BabyBondPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest.
    /// Encoded/decoded by serializers as &quot;SAPP&quot;.
    /// </summary>
    [EnumMember(Value = "SAPP")]
    [IsoId("_1asl4WjLEeOdXoiw6mfXMw")]
    [Description(@"Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal redemption proceeds but erroneously paid you the accrued interest.")]
    CalledCertificatesAccruedErroneousInterestChargeBack = DTCAdjustmentPaymentSubReasonCode.CalledCertificatesAccruedErroneousInterestChargeBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal proceeds via check, but in your customer’s name. we are forwarding the check today. this adjustment is to charge you for the funds.
    /// Encoded/decoded by serializers as &quot;SCKS&quot;.
    /// </summary>
    [EnumMember(Value = "SCKS")]
    [IsoId("_1e1fAWjLEeOdXoiw6mfXMw")]
    [Description(@"Certificates you deposited prior to publication date were subsequently called. the agent paid DTCC the principal proceeds via check, but in your customer’s name. we are forwarding the check today. this adjustment is to charge you for the funds.")]
    CalledCertificatesCheckInParticipantsNameChargeBack = DTCAdjustmentPaymentSubReasonCode.CalledCertificatesCheckInParticipantsNameChargeBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment for cash due on an accrued stock payment.
    /// Encoded/decoded by serializers as &quot;SSBK&quot;.
    /// </summary>
    [EnumMember(Value = "SSBK")]
    [IsoId("_1jJ-UWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment for cash due on an accrued stock payment.")]
    CashDueOnAnAccruedStockPayment = DTCAdjustmentPaymentSubReasonCode.CashDueOnAnAccruedStockPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As per agent, this charge is for french avoid fiscal tax credit.
    /// Encoded/decoded by serializers as &quot;SFAF&quot;.
    /// </summary>
    [EnumMember(Value = "SFAF")]
    [IsoId("_2JAdYWjLEeOdXoiw6mfXMw")]
    [Description(@"As per agent, this charge is for french avoid fiscal tax credit.")]
    ChargeForFrenchAvoidFiscalTaxCredit = DTCAdjustmentPaymentSubReasonCode.ChargeForFrenchAvoidFiscalTaxCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment.
    /// Encoded/decoded by serializers as &quot;SSR6&quot;.
    /// </summary>
    [EnumMember(Value = "SSR6")]
    [IsoId("_2VdlAWjLEeOdXoiw6mfXMw")]
    [Description(@"As per your authorization, we are charging your account in lieu of receipt of dividend reinvestment related shares related adjustment.")]
    ChargeInLieuOfReceiptOfDividendReinvestment = DTCAdjustmentPaymentSubReasonCode.ChargeInLieuOfReceiptOfDividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC COD withdrawal adjustment.
    /// Encoded/decoded by serializers as &quot;SJCB&quot;.
    /// </summary>
    [EnumMember(Value = "SJCB")]
    [IsoId("_2h9I4WjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC COD withdrawal adjustment.")]
    CODWithdrawal = DTCAdjustmentPaymentSubReasonCode.CODWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADA&quot;.
    /// </summary>
    [EnumMember(Value = "SADA")]
    [IsoId("_26_T8WjLEeOdXoiw6mfXMw")]
    [Description(@"Company in default related adjustment.")]
    CompanyInDefault = DTCAdjustmentPaymentSubReasonCode.CompanyInDefault, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company never declared dividend adjust allocation on user defined date.
    /// Encoded/decoded by serializers as &quot;SANA&quot;.
    /// </summary>
    [EnumMember(Value = "SANA")]
    [IsoId("_2_R-EWjLEeOdXoiw6mfXMw")]
    [Description(@"Company never declared dividend adjust allocation on user defined date.")]
    CompanyDidNotDeclareDividend = DTCAdjustmentPaymentSubReasonCode.CompanyDidNotDeclareDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SBEB&quot;.
    /// </summary>
    [EnumMember(Value = "SBEB")]
    [IsoId("_3Dhk4WjLEeOdXoiw6mfXMw")]
    [Description(@"Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your nominee.")]
    CODWithdrawalNotDeliveredAndCertificatesIssuedInTheNameOfYourNominee = DTCAdjustmentPaymentSubReasonCode.CODWithdrawalNotDeliveredAndCertificatesIssuedInTheNameOfYourNominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for a COD buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB1&quot;.
    /// </summary>
    [EnumMember(Value = "SBB1")]
    [IsoId("_3LzXIWjLEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for a COD buy back withdrawal.")]
    CODBuyBackWithdrawal = DTCAdjustmentPaymentSubReasonCode.CODBuyBackWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Required lists contained discrepancies or were not forwarded to french paying agent. This charge is at user defined withholding rate.
    /// Encoded/decoded by serializers as &quot;SFI9&quot;.
    /// </summary>
    [EnumMember(Value = "SFI9")]
    [IsoId("_3QBIwWjLEeOdXoiw6mfXMw")]
    [Description(@"Required lists contained discrepancies or were not forwarded to french paying agent. This charge is at user defined withholding rate.")]
    ChargeAtWithholdingRate = DTCAdjustmentPaymentSubReasonCode.ChargeAtWithholdingRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accrued cash due on DRP share allocation.
    /// Encoded/decoded by serializers as &quot;SSDK&quot;.
    /// </summary>
    [EnumMember(Value = "SSDK")]
    [IsoId("_3lCWgWjLEeOdXoiw6mfXMw")]
    [Description(@"Accrued cash due on DRP share allocation.")]
    CashDueOnDRPShareAllocation = DTCAdjustmentPaymentSubReasonCode.CashDueOnDRPShareAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accrued cash due on a stock dividend adjustment made on user defined date.
    /// Encoded/decoded by serializers as &quot;SSCK&quot;.
    /// </summary>
    [EnumMember(Value = "SSCK")]
    [IsoId("_3tS6oWjLEeOdXoiw6mfXMw")]
    [Description(@"Accrued cash due on a stock dividend adjustment made on user defined date.")]
    CashDueOnStockDividend = DTCAdjustmentPaymentSubReasonCode.CashDueOnStockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation adjustment due to a change in the record date.
    /// Encoded/decoded by serializers as &quot;SRDA&quot;.
    /// </summary>
    [EnumMember(Value = "SRDA")]
    [IsoId("_396wkWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation adjustment due to a change in the record date.")]
    ChangeInTheRecordDate = DTCAdjustmentPaymentSubReasonCode.ChangeInTheRecordDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SBDB&quot;.
    /// </summary>
    [EnumMember(Value = "SBDB")]
    [IsoId("_4YPVEWjLEeOdXoiw6mfXMw")]
    [Description(@"Your COD withdrawal was not delivered, however the certificate(s) were issued and outstanding over the record date in the name of your goodselves.")]
    CODWithdrawalNotDeliveredAndCertificatesInTheNameOfYourGoodselves = DTCAdjustmentPaymentSubReasonCode.CODWithdrawalNotDeliveredAndCertificatesInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Coupon collection service adjustment for coupon deposit.
    /// Encoded/decoded by serializers as &quot;SCSM&quot;.
    /// </summary>
    [EnumMember(Value = "SCSM")]
    [IsoId("_4gqRQWjLEeOdXoiw6mfXMw")]
    [Description(@"Coupon collection service adjustment for coupon deposit.")]
    CouponCollectionService = DTCAdjustmentPaymentSubReasonCode.CouponCollectionService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend.
    /// Encoded/decoded by serializers as &quot;SDMT&quot;.
    /// </summary>
    [EnumMember(Value = "SDMT")]
    [IsoId("_4pfdIWjLEeOdXoiw6mfXMw")]
    [Description(@"CTF(s) held over record date on which we guarantee to hold you free and harmless of any further claim on this dividend.")]
    CTFSHeldOverRecordDateOnWhichWeGuaranteeToHoldYouFreeAndHarmless = DTCAdjustmentPaymentSubReasonCode.CTFSHeldOverRecordDateOnWhichWeGuaranteeToHoldYouFreeAndHarmless, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custody payment.
    /// Encoded/decoded by serializers as &quot;SCDP&quot;.
    /// </summary>
    [EnumMember(Value = "SCDP")]
    [IsoId("_5K_AoWjLEeOdXoiw6mfXMw")]
    [Description(@"Custody payment.")]
    CustodyPayment = DTCAdjustmentPaymentSubReasonCode.CustodyPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date revision for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLN&quot;.
    /// </summary>
    [EnumMember(Value = "SFLN")]
    [IsoId("_5TT2MWjLEeOdXoiw6mfXMw")]
    [Description(@"Date revision for fail tracking related adjustment.")]
    DateRevision = DTCAdjustmentPaymentSubReasonCode.DateRevision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deletefor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL1&quot;.
    /// </summary>
    [EnumMember(Value = "SFL1")]
    [IsoId("_5XhAwWjLEeOdXoiw6mfXMw")]
    [Description(@"Deletefor fail tracking related adjustment.")]
    Delete = DTCAdjustmentPaymentSubReasonCode.Delete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC deliver order related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEG&quot;.
    /// </summary>
    [EnumMember(Value = "SJEG")]
    [IsoId("_5bsWIWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC deliver order related adjustment.")]
    DeliverOrder = DTCAdjustmentPaymentSubReasonCode.DeliverOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for deliver order (DO) activity.
    /// Encoded/decoded by serializers as &quot;SEEE&quot;.
    /// </summary>
    [EnumMember(Value = "SEEE")]
    [IsoId("_5f3rgWjLEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for deliver order (DO) activity.")]
    DeliverOrderActivity = DTCAdjustmentPaymentSubReasonCode.DeliverOrderActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SJDD&quot;.
    /// </summary>
    [EnumMember(Value = "SJDD")]
    [IsoId("_5kCZ0WjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC deposit related adjustment.")]
    DepositAdjustment = DTCAdjustmentPaymentSubReasonCode.DepositAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your [user defined].
    /// Encoded/decoded by serializers as &quot;SDAD&quot;.
    /// </summary>
    [EnumMember(Value = "SDAD")]
    [IsoId("_5woEUWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your [user defined].")]
    DepositLostCertificateOverTheRecordDateWasRegisteredInTheNameOfYour = DTCAdjustmentPaymentSubReasonCode.DepositLostCertificateOverTheRecordDateWasRegisteredInTheNameOfYour, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit after cut off date transferred into the name of the CEDE on record date.
    /// Encoded/decoded by serializers as &quot;SDCD&quot;.
    /// </summary>
    [EnumMember(Value = "SDCD")]
    [IsoId("_50w9cWjLEeOdXoiw6mfXMw")]
    [Description(@"Deposit after cut off date transferred into the name of the CEDE on record date.")]
    DepositTransferredIntoTheNameOfTheCEDEAndCo = DTCAdjustmentPaymentSubReasonCode.DepositTransferredIntoTheNameOfTheCEDEAndCo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend reinvestment allocation why not on normal event.
    /// Encoded/decoded by serializers as &quot;SSC6&quot;.
    /// </summary>
    [EnumMember(Value = "SSC6")]
    [IsoId("_59I2UWjLEeOdXoiw6mfXMw")]
    [Description(@"Dividend reinvestment allocation why not on normal event.")]
    DividendReinvestmentAllocation = DTCAdjustmentPaymentSubReasonCode.DividendReinvestmentAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DRP allocation adjustment due to your sub accounting instructions to the agent.
    /// Encoded/decoded by serializers as &quot;SSS6&quot;.
    /// </summary>
    [EnumMember(Value = "SSS6")]
    [IsoId("_6BTkoWjLEeOdXoiw6mfXMw")]
    [Description(@"DRP allocation adjustment due to your sub accounting instructions to the agent.")]
    DividendReinvestmentAllocationAdjustmentDueToYourSubAccountingInstructionsToTheAgent = DTCAdjustmentPaymentSubReasonCode.DividendReinvestmentAllocationAdjustmentDueToYourSubAccountingInstructionsToTheAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend reinvestment (DRP) allocation of cash in lieu of fractions related adjustment.
    /// Encoded/decoded by serializers as &quot;SSE6&quot;.
    /// </summary>
    [EnumMember(Value = "SSE6")]
    [IsoId("_6Fh9UWjLEeOdXoiw6mfXMw")]
    [Description(@"Dividend reinvestment (DRP) allocation of cash in lieu of fractions related adjustment.")]
    DividendReinvestmentAllocationOfCashInLieuOfFractions = DTCAdjustmentPaymentSubReasonCode.DividendReinvestmentAllocationOfCashInLieuOfFractions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SPCP&quot;.
    /// </summary>
    [EnumMember(Value = "SPCP")]
    [IsoId("_6JpoUWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your customer.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomer = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLCP&quot;.
    /// </summary>
    [EnumMember(Value = "SLCP")]
    [IsoId("_6N52MWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your customer. Late identification of missed transfer by Transfer Agent.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomerLateTransfer = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourCustomerLateTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SPGP&quot;.
    /// </summary>
    [EnumMember(Value = "SPGP")]
    [IsoId("_6SDWYWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your goodselves.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselves = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your goodselves. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLGP&quot;.
    /// </summary>
    [EnumMember(Value = "SLGP")]
    [IsoId("_6aW90WjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your goodselves. Late identification of missed transfer by Transfer Agent.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselvesLateTransfer = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourGoodselvesLateTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent.
    /// Encoded/decoded by serializers as &quot;SLNP&quot;.
    /// </summary>
    [EnumMember(Value = "SLNP")]
    [IsoId("_6iuPoWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your nominee. Late identification of missed transfer by Transfer Agent.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourNominee = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourNominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim against registered holder in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SPNP&quot;.
    /// </summary>
    [EnumMember(Value = "SPNP")]
    [IsoId("_6m4W4WjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim against registered holder in the name of your nominee.")]
    DTCCClaimAgainstRegisteredHolderInTheNameOfYourNomineeLateTransfer = DTCAdjustmentPaymentSubReasonCode.DTCCClaimAgainstRegisteredHolderInTheNameOfYourNomineeLateTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim on registered holder in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SGLZ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLZ")]
    [IsoId("_6vMlYWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim on registered holder in the name of your customer.")]
    DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer = DTCAdjustmentPaymentSubReasonCode.DTCCClaimOnRegisteredHolderInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC claim on registered holder in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SGLQ&quot;.
    /// </summary>
    [EnumMember(Value = "SGLQ")]
    [IsoId("_7Yxt4WjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC claim on registered holder in the name of your goodselves.")]
    DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves = DTCAdjustmentPaymentSubReasonCode.DTCCClaimOnRegisteredHolderInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due bill for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLE&quot;.
    /// </summary>
    [EnumMember(Value = "SFLE")]
    [IsoId("_7dBUsWjLEeOdXoiw6mfXMw")]
    [Description(@"Due bill for fail tracking related adjustment.")]
    DueBill = DTCAdjustmentPaymentSubReasonCode.DueBill, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due bill fail tracking.
    /// Encoded/decoded by serializers as &quot;SSFF&quot;.
    /// </summary>
    [EnumMember(Value = "SSFF")]
    [IsoId("_7hLb8WjLEeOdXoiw6mfXMw")]
    [Description(@"Due bill fail tracking.")]
    DueBillFailTracking = DTCAdjustmentPaymentSubReasonCode.DueBillFailTracking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due bill fail tracking reversal.
    /// Encoded/decoded by serializers as &quot;SSFR&quot;.
    /// </summary>
    [EnumMember(Value = "SSFR")]
    [IsoId("_7pki8WjLEeOdXoiw6mfXMw")]
    [Description(@"Due bill fail tracking reversal.")]
    DueBillReversal = DTCAdjustmentPaymentSubReasonCode.DueBillReversal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase.
    /// Encoded/decoded by serializers as &quot;SBB3&quot;.
    /// </summary>
    [EnumMember(Value = "SBB3")]
    [IsoId("_7txtgWjLEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for a DWAC withdrawal to effect a buy back/treasury purchase.")]
    DWACAdjustment = DTCAdjustmentPaymentSubReasonCode.DWACAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for a DWAC buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SSBB&quot;.
    /// </summary>
    [EnumMember(Value = "SSBB")]
    [IsoId("_72C4sWjLEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for a DWAC buy back withdrawal.")]
    DWACBuyBackWithdrawal = DTCAdjustmentPaymentSubReasonCode.DWACBuyBackWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign cash dividends/bond interest allocation at exempt rate.
    /// Encoded/decoded by serializers as &quot;SFE8&quot;.
    /// </summary>
    [EnumMember(Value = "SFE8")]
    [IsoId("_76U7wWjLEeOdXoiw6mfXMw")]
    [Description(@"Foreign cash dividends/bond interest allocation at exempt rate.")]
    ForeignCashDividendsOrBondInterestAllocationAtExemptRate = DTCAdjustmentPaymentSubReasonCode.ForeignCashDividendsOrBondInterestAllocationAtExemptRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign cash dividends or bond interest allocation at unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFU9&quot;.
    /// </summary>
    [EnumMember(Value = "SFU9")]
    [IsoId("_7-d04WjLEeOdXoiw6mfXMw")]
    [Description(@"Foreign cash dividends or bond interest allocation at unfavorable rate.")]
    ForeignCashDividendsOrBondInterestAllocationAtUnfavorableRate = DTCAdjustmentPaymentSubReasonCode.ForeignCashDividendsOrBondInterestAllocationAtUnfavorableRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign cash dividends/bonds interest allocation at favorable rate.
    /// Encoded/decoded by serializers as &quot;SFF8&quot;.
    /// </summary>
    [EnumMember(Value = "SFF8")]
    [IsoId("_8CqYYWjLEeOdXoiw6mfXMw")]
    [Description(@"Foreign cash dividends/bonds interest allocation at favorable rate.")]
    ForeignCashDividendsOrBondsInterestAllocationAtFavorableRate = DTCAdjustmentPaymentSubReasonCode.ForeignCashDividendsOrBondsInterestAllocationAtFavorableRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign cash dividends allocation at unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFL9&quot;.
    /// </summary>
    [EnumMember(Value = "SFL9")]
    [IsoId("_8G4KAWjLEeOdXoiw6mfXMw")]
    [Description(@"Foreign cash dividends allocation at unfavorable rate.")]
    ForeignCashDividendUnfavorableRate = DTCAdjustmentPaymentSubReasonCode.ForeignCashDividendUnfavorableRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of fractional rights.
    /// Encoded/decoded by serializers as &quot;SAFR&quot;.
    /// </summary>
    [EnumMember(Value = "SAFR")]
    [IsoId("_8LGisWjLEeOdXoiw6mfXMw")]
    [Description(@"Allocation of fractional rights.")]
    FractionalRights = DTCAdjustmentPaymentSubReasonCode.FractionalRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ten percent french withholding tax, based on your revised instructions to reduce favorable tax status to unfavorable.
    /// Encoded/decoded by serializers as &quot;SFH9&quot;.
    /// </summary>
    [EnumMember(Value = "SFH9")]
    [IsoId("_8PZM0WjLEeOdXoiw6mfXMw")]
    [Description(@"Ten percent french withholding tax, based on your revised instructions to reduce favorable tax status to unfavorable.")]
    FrenchWithholdingTax10Percent = DTCAdjustmentPaymentSubReasonCode.FrenchWithholdingTax10Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fifteen percent french withholding tax, based on your option election of 100% ADRs at the favorable rate.
    /// Encoded/decoded by serializers as &quot;SFG8&quot;.
    /// </summary>
    [EnumMember(Value = "SFG8")]
    [IsoId("_8X0JAWjLEeOdXoiw6mfXMw")]
    [Description(@"Fifteen percent french withholding tax, based on your option election of 100% ADRs at the favorable rate.")]
    FrenchWithholdingTax15Percent = DTCAdjustmentPaymentSubReasonCode.FrenchWithholdingTax15Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Twenty five percent french withholding tax, based on your option election of 100% ADRs at the unfavorable rate.
    /// Encoded/decoded by serializers as &quot;SFG9&quot;.
    /// </summary>
    [EnumMember(Value = "SFG9")]
    [IsoId("_8caVIWjLEeOdXoiw6mfXMw")]
    [Description(@"Twenty five percent french withholding tax, based on your option election of 100% ADRs at the unfavorable rate.")]
    FrenchWithholdingTax25Percent = DTCAdjustmentPaymentSubReasonCode.FrenchWithholdingTax25Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// As per memo requesting a frozen letter movement from part number.
    /// Encoded/decoded by serializers as &quot;SFRO&quot;.
    /// </summary>
    [EnumMember(Value = "SFRO")]
    [IsoId("_8ksHYGjLEeOdXoiw6mfXMw")]
    [Description(@"As per memo requesting a frozen letter movement from part number.")]
    FrozenLetterMovement = DTCAdjustmentPaymentSubReasonCode.FrozenLetterMovement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Company is taking 30 day grace period.
    /// Encoded/decoded by serializers as &quot;SAGA&quot;.
    /// </summary>
    [EnumMember(Value = "SAGA")]
    [IsoId("_8xPVoWjLEeOdXoiw6mfXMw")]
    [Description(@"Company is taking 30 day grace period.")]
    GracePeriod = DTCAdjustmentPaymentSubReasonCode.GracePeriod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This adjustment represents credits/debits to your account in lieu of reorg deposit activity.
    /// Encoded/decoded by serializers as &quot;SPRG&quot;.
    /// </summary>
    [EnumMember(Value = "SPRG")]
    [IsoId("_85jkIWjLEeOdXoiw6mfXMw")]
    [Description(@"This adjustment represents credits/debits to your account in lieu of reorg deposit activity.")]
    InLieuOfReorgDepositActivity = DTCAdjustmentPaymentSubReasonCode.InLieuOfReorgDepositActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In settlement of a trade - DTCC reorg account 428-10271-1-2-039.
    /// Encoded/decoded by serializers as &quot;SGLT&quot;.
    /// </summary>
    [EnumMember(Value = "SGLT")]
    [IsoId("_89wHoWjLEeOdXoiw6mfXMw")]
    [Description(@"In settlement of a trade - DTCC reorg account 428-10271-1-2-039.")]
    InSettlementOfATradeDTCCReorgAccount = DTCAdjustmentPaymentSubReasonCode.InSettlementOfATradeDTCCReorgAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest adjusted due to early withdrawal (certificate of deposit).
    /// Encoded/decoded by serializers as &quot;SACB&quot;.
    /// </summary>
    [EnumMember(Value = "SACB")]
    [IsoId("_9gj5wWjLEeOdXoiw6mfXMw")]
    [Description(@"Interest adjusted due to early withdrawal (certificate of deposit).")]
    InterestAdjustedDueToEarlyWithdrawal = DTCAdjustmentPaymentSubReasonCode.InterestAdjustedDueToEarlyWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest allocated in error first payment on &quot;date user defined&quot;.
    /// Encoded/decoded by serializers as &quot;SAEA&quot;.
    /// </summary>
    [EnumMember(Value = "SAEA")]
    [IsoId("_9kxEUWjLEeOdXoiw6mfXMw")]
    [Description(@"Interest allocated in error first payment on ""date user defined"".")]
    InterestAllocatedInError = DTCAdjustmentPaymentSubReasonCode.InterestAllocatedInError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The interest due on the above cusip was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date.
    /// Encoded/decoded by serializers as &quot;S66P&quot;.
    /// </summary>
    [EnumMember(Value = "S66P")]
    [IsoId("_9tKLUWjLEeOdXoiw6mfXMw")]
    [Description(@"The interest due on the above cusip was erroneously paid to you by the issuer although the certificate of deposit was transferred to CEDE (DTCC) prior to the interest payment date.")]
    InterestDueWasErroneouslyPaidToYouByTheIssuer = DTCAdjustmentPaymentSubReasonCode.InterestDueWasErroneouslyPaidToYouByTheIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest or dividend due on conversion related adjustment.
    /// Encoded/decoded by serializers as &quot;SAC7&quot;.
    /// </summary>
    [EnumMember(Value = "SAC7")]
    [IsoId("_9xppwWjLEeOdXoiw6mfXMw")]
    [Description(@"Interest or dividend due on conversion related adjustment.")]
    InterestorDividendDueOnConversion = DTCAdjustmentPaymentSubReasonCode.InterestorDividendDueOnConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest or dividend due on merger related adjustment.
    /// Encoded/decoded by serializers as &quot;SAM7&quot;.
    /// </summary>
    [EnumMember(Value = "SAM7")]
    [IsoId("_92Qc8WjLEeOdXoiw6mfXMw")]
    [Description(@"Interest or dividend due on merger related adjustment.")]
    InterestOrDividendDueOnMerger = DTCAdjustmentPaymentSubReasonCode.InterestOrDividendDueOnMerger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest or dividend due on redemption.
    /// Encoded/decoded by serializers as &quot;SAR7&quot;.
    /// </summary>
    [EnumMember(Value = "SAR7")]
    [IsoId("_96e1oWjLEeOdXoiw6mfXMw")]
    [Description(@"Interest or dividend due on redemption.")]
    InterestOrDividendDueOnRedemption = DTCAdjustmentPaymentSubReasonCode.InterestOrDividendDueOnRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest or dividend due on repayment option.
    /// Encoded/decoded by serializers as &quot;SAP7&quot;.
    /// </summary>
    [EnumMember(Value = "SAP7")]
    [IsoId("_-CwA0WjLEeOdXoiw6mfXMw")]
    [Description(@"Interest or dividend due on repayment option.")]
    InterestOrDividendDueOnRepaymentOption = DTCAdjustmentPaymentSubReasonCode.InterestOrDividendDueOnRepaymentOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interestor dividend due on tender.
    /// Encoded/decoded by serializers as &quot;SAT7&quot;.
    /// </summary>
    [EnumMember(Value = "SAT7")]
    [IsoId("_-PZ8wWjLEeOdXoiw6mfXMw")]
    [Description(@"Interestor dividend due on tender.")]
    InterestOrDividendDueOnTender = DTCAdjustmentPaymentSubReasonCode.InterestOrDividendDueOnTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest pays at maturity. Allocated in error onn user defined date.
    /// Encoded/decoded by serializers as &quot;SAMA&quot;.
    /// </summary>
    [EnumMember(Value = "SAMA")]
    [IsoId("_-Tjc8WjLEeOdXoiw6mfXMw")]
    [Description(@"Interest pays at maturity. Allocated in error onn user defined date.")]
    InterestPaysAtMaturity = DTCAdjustmentPaymentSubReasonCode.InterestPaysAtMaturity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your interim position was adjusted for deliver orderactivity.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_-b0oIWjLEeOdXoiw6mfXMw")]
    [Description(@"Your interim position was adjusted for deliver orderactivity.")]
    InterimPositionAdjustedForDeliverOrderActivity = DTCAdjustmentPaymentSubReasonCode.InterimPositionAdjustedForDeliverOrderActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC investment id related adjustment.
    /// Encoded/decoded by serializers as &quot;SJIE&quot;.
    /// </summary>
    [EnumMember(Value = "SJIE")]
    [IsoId("_-kSnoWjLEeOdXoiw6mfXMw")]
    [Description(@"DTCC investment id related adjustment.")]
    InvestmentIdAdjustment = DTCAdjustmentPaymentSubReasonCode.InvestmentIdAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issue in default related adjustment.
    /// Encoded/decoded by serializers as &quot;SADM&quot;.
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_-szDYWjLEeOdXoiw6mfXMw")]
    [Description(@"Issue in default related adjustment.")]
    IssueInDefault = DTCAdjustmentPaymentSubReasonCode.IssueInDefault, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fail tracking for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLL&quot;.
    /// </summary>
    [EnumMember(Value = "SFLL")]
    [IsoId("_-w-_0WjLEeOdXoiw6mfXMw")]
    [Description(@"Fail tracking for fail tracking related adjustment.")]
    LateAnnouncement = DTCAdjustmentPaymentSubReasonCode.LateAnnouncement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Late announcement activity due bill activity related adjustment.
    /// Encoded/decoded by serializers as &quot;SILL&quot;.
    /// </summary>
    [EnumMember(Value = "SILL")]
    [IsoId("_-1MxcWjLEeOdXoiw6mfXMw")]
    [Description(@"Late announcement activity due bill activity related adjustment.")]
    LateAnnouncementActivityDueBillActivity = DTCAdjustmentPaymentSubReasonCode.LateAnnouncementActivityDueBillActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your goodselves.
    /// Encoded/decoded by serializers as &quot;SDBD&quot;.
    /// </summary>
    [EnumMember(Value = "SDBD")]
    [IsoId("_-5W4sWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your goodselves.")]
    LostCertificateRegisteredInTheNameOfYourGoodselves = DTCAdjustmentPaymentSubReasonCode.LostCertificateRegisteredInTheNameOfYourGoodselves, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal by transfer - lost certificate over the record date was registered in the name of your customer.
    /// Encoded/decoded by serializers as &quot;SWG1&quot;.
    /// </summary>
    [EnumMember(Value = "SWG1")]
    [IsoId("_-9kDQWjLEeOdXoiw6mfXMw")]
    [Description(@"Withdrawal by transfer - lost certificate over the record date was registered in the name of your customer.")]
    LostCertificateWasRegisteredInTheNameOfYourCustomer = DTCAdjustmentPaymentSubReasonCode.LostCertificateWasRegisteredInTheNameOfYourCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment related to the deposit of lost certificate over the record date was registered in the name of your nominee.
    /// Encoded/decoded by serializers as &quot;SDED&quot;.
    /// </summary>
    [EnumMember(Value = "SDED")]
    [IsoId("__F-_cWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment related to the deposit of lost certificate over the record date was registered in the name of your nominee.")]
    LostCertificateWasRegisteredInTheNameOfYourNominee = DTCAdjustmentPaymentSubReasonCode.LostCertificateWasRegisteredInTheNameOfYourNominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment made for the Midwest depository (6942).
    /// Encoded/decoded by serializers as &quot;SCMU&quot;.
    /// </summary>
    [EnumMember(Value = "SCMU")]
    [IsoId("__KMxEWjLEeOdXoiw6mfXMw")]
    [Description(@"Adjustment made for the Midwest depository (6942).")]
    MidwestDepository = DTCAdjustmentPaymentSubReasonCode.MidwestDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment (same as line 118).
    /// Encoded/decoded by serializers as &quot;SGLM&quot;.
    /// </summary>
    [EnumMember(Value = "SGLM")]
    [IsoId("__0XIYWjLEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment (same as line 118).")]
    MuniBearerBond = DTCAdjustmentPaymentSubReasonCode.MuniBearerBond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon related adjustment.
    /// Encoded/decoded by serializers as &quot;SMAM&quot;.
    /// </summary>
    [EnumMember(Value = "SMAM")]
    [IsoId("__4okYWjLEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon related adjustment.")]
    MuniBearerBondCoupon = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCoupon, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date.
    /// Encoded/decoded by serializers as &quot;SMEM&quot;.
    /// </summary>
    [EnumMember(Value = "SMEM")]
    [IsoId("__8zSsWjLEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment excess coupon(s) deposited on user defined date.")]
    MuniBearerBondCouponAdjustmentExcessCouponsDepositedOn = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCouponAdjustmentExcessCouponsDepositedOn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date.
    /// Encoded/decoded by serializers as &quot;SMDM&quot;.
    /// </summary>
    [EnumMember(Value = "SMDM")]
    [IsoId("_ABBrYWjMEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment excess coupon(s) withdrawn on user defined date.")]
    MuniBearerBondCouponAdjustmentExcessCouponsWithdrawnOn = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCouponAdjustmentExcessCouponsWithdrawnOn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment.
    /// Encoded/decoded by serializers as &quot;SMBM&quot;.
    /// </summary>
    [EnumMember(Value = "SMBM")]
    [IsoId("_AFTucWjMEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment for coupon(s) missing from a deposit related adjustment.")]
    MuniBearerBondCouponAdjustmentForCouponsMissingFromaDeposit = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCouponAdjustmentForCouponsMissingFromaDeposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.
    /// Encoded/decoded by serializers as &quot;SMCM&quot;.
    /// </summary>
    [EnumMember(Value = "SMCM")]
    [IsoId("_AJmYkWjMEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment for coupon(s) missing from a withdrawal.")]
    MuniBearerBondCouponAdjustmentForCouponsMissingFromaWithdrawal = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCouponAdjustmentForCouponsMissingFromaWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Muni bearer bond coupon adjustment your interim position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SMMM&quot;.
    /// </summary>
    [EnumMember(Value = "SMMM")]
    [IsoId("_ANxG4WjMEeOdXoiw6mfXMw")]
    [Description(@"Muni bearer bond coupon adjustment your interim position was adjusted for deposit activity.")]
    MuniBearerBondCouponPositionAdjustedForDepositActivity = DTCAdjustmentPaymentSubReasonCode.MuniBearerBondCouponPositionAdjustedForDepositActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non allocation for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLS&quot;.
    /// </summary>
    [EnumMember(Value = "SFLS")]
    [IsoId("_AWQUgWjMEeOdXoiw6mfXMw")]
    [Description(@"Non allocation for fail tracking related adjustment.")]
    NonAllocation = DTCAdjustmentPaymentSubReasonCode.NonAllocation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Optional dividend (ops) allocation related adjustment.
    /// Encoded/decoded by serializers as &quot;SOP2&quot;.
    /// </summary>
    [EnumMember(Value = "SOP2")]
    [IsoId("_AaZ0sWjMEeOdXoiw6mfXMw")]
    [Description(@"Optional dividend (ops) allocation related adjustment.")]
    OptionalDividendAllocationAdjustment = DTCAdjustmentPaymentSubReasonCode.OptionalDividendAllocationAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved for new user defined reason codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Am1uMWjMEeOdXoiw6mfXMw")]
    [Description(@"Reserved for new user defined reason codes.")]
    Other = DTCAdjustmentPaymentSubReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment made for the Pacific depository (3097).
    /// Encoded/decoded by serializers as &quot;SCLU&quot;.
    /// </summary>
    [EnumMember(Value = "SCLU")]
    [IsoId("_ArBDkWjMEeOdXoiw6mfXMw")]
    [Description(@"Adjustment made for the Pacific depository (3097).")]
    PacificDepository = DTCAdjustmentPaymentSubReasonCode.PacificDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part claim payment.
    /// Encoded/decoded by serializers as &quot;SCPP&quot;.
    /// </summary>
    [EnumMember(Value = "SCPP")]
    [IsoId("_AvTGoWjMEeOdXoiw6mfXMw")]
    [Description(@"Part claim payment.")]
    PartClaimPayment = DTCAdjustmentPaymentSubReasonCode.PartClaimPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part-claim reversal.
    /// Encoded/decoded by serializers as &quot;SCRP&quot;.
    /// </summary>
    [EnumMember(Value = "SCRP")]
    [IsoId("_AzecAWjMEeOdXoiw6mfXMw")]
    [Description(@"Part-claim reversal.")]
    PartClaimReversal = DTCAdjustmentPaymentSubReasonCode.PartClaimReversal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAHA&quot;.
    /// </summary>
    [EnumMember(Value = "SAHA")]
    [IsoId("_A3ojQWjMEeOdXoiw6mfXMw")]
    [Description(@"Payment of full avoid fiscal tax refund (equal to 42.5% of the dividend).")]
    PaymentOfFullAvoidFiscalTaxRefund = DTCAdjustmentPaymentSubReasonCode.PaymentOfFullAvoidFiscalTaxRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment of partial avoid fiscal tax refund (equal to 15% of the dividend).
    /// Encoded/decoded by serializers as &quot;SAPA&quot;.
    /// </summary>
    [EnumMember(Value = "SAPA")]
    [IsoId("_A7z4oWjMEeOdXoiw6mfXMw")]
    [Description(@"Payment of partial avoid fiscal tax refund (equal to 15% of the dividend).")]
    PaymentOfPartialAvoidFiscalTaxRefund = DTCAdjustmentPaymentSubReasonCode.PaymentOfPartialAvoidFiscalTaxRefund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation of a Pay in Kind distribution.
    /// Encoded/decoded by serializers as &quot;SSPA&quot;.
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_BACRUWjMEeOdXoiw6mfXMw")]
    [Description(@"Allocation of a Pay in Kind distribution.")]
    PaynInKindDistribution = DTCAdjustmentPaymentSubReasonCode.PaynInKindDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment made for the Philadelphia depository (6070).
    /// Encoded/decoded by serializers as &quot;SCNU&quot;.
    /// </summary>
    [EnumMember(Value = "SCNU")]
    [IsoId("_BEMYkWjMEeOdXoiw6mfXMw")]
    [Description(@"Adjustment made for the Philadelphia depository (6070).")]
    PhiladelphiaDepository = DTCAdjustmentPaymentSubReasonCode.PhiladelphiaDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC pledge related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEF&quot;.
    /// </summary>
    [EnumMember(Value = "SJEF")]
    [IsoId("_BIYVAWjMEeOdXoiw6mfXMw")]
    [Description(@"DTCC pledge related adjustment.")]
    PledgeAdjustment = DTCAdjustmentPaymentSubReasonCode.PledgeAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC pledge release related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEE&quot;.
    /// </summary>
    [EnumMember(Value = "SJEE")]
    [IsoId("_BqEs0WjMEeOdXoiw6mfXMw")]
    [Description(@"DTCC pledge release related adjustment.")]
    PledgeReleaseAdjustment = DTCAdjustmentPaymentSubReasonCode.PledgeReleaseAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for deposit activity.
    /// Encoded/decoded by serializers as &quot;SDDD&quot;.
    /// </summary>
    [EnumMember(Value = "SDDD")]
    [IsoId("_BuONAWjMEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for deposit activity.")]
    PositionAdjustedForDepositActivity = DTCAdjustmentPaymentSubReasonCode.PositionAdjustedForDepositActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s).
    /// Encoded/decoded by serializers as &quot;SWN1&quot;.
    /// </summary>
    [EnumMember(Value = "SWN1")]
    [IsoId("_B2k3wWjMEeOdXoiw6mfXMw")]
    [Description(@"Your position was reinstated for a withdrawal by transfer. However the certificates(s) were issued and outstanding over the record date in the name of your customer(s).")]
    PositionReinstatedCertificatesIssuedAndOutstandingInTheNameOfYourCustomers = DTCAdjustmentPaymentSubReasonCode.PositionReinstatedCertificatesIssuedAndOutstandingInTheNameOfYourCustomers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Post date changefor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL3&quot;.
    /// </summary>
    [EnumMember(Value = "SFL3")]
    [IsoId("_B6zQcWjMEeOdXoiw6mfXMw")]
    [Description(@"Post date changefor fail tracking related adjustment.")]
    PostDateChangeForFailTracking = DTCAdjustmentPaymentSubReasonCode.PostDateChangeForFailTracking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// You deposited securities that were previously called. the agent paid DTCC the redemption proceeds. this adjustment is to pass these proceeds on to you. your free account security position will be adjusted (shorted) today for the called quantity.
    /// Encoded/decoded by serializers as &quot;SDEP&quot;.
    /// </summary>
    [EnumMember(Value = "SDEP")]
    [IsoId("_B--l0WjMEeOdXoiw6mfXMw")]
    [Description(@"You deposited securities that were previously called. the agent paid DTCC the redemption proceeds. this adjustment is to pass these proceeds on to you. your free account security position will be adjusted (shorted) today for the called quantity.")]
    PreviouslyCalledCertificatesFundsDelivery = DTCAdjustmentPaymentSubReasonCode.PreviouslyCalledCertificatesFundsDelivery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allocation adjustment for dividend reinvestment due to price correction by the agent.
    /// Encoded/decoded by serializers as &quot;SSA6&quot;.
    /// </summary>
    [EnumMember(Value = "SSA6")]
    [IsoId("_CDHe8WjMEeOdXoiw6mfXMw")]
    [Description(@"Allocation adjustment for dividend reinvestment due to price correction by the agent.")]
    PriceCorrectionDividendReinvestment = DTCAdjustmentPaymentSubReasonCode.PriceCorrectionDividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSP4&quot;.
    /// </summary>
    [EnumMember(Value = "SSP4")]
    [IsoId("_CHUpgWjMEeOdXoiw6mfXMw")]
    [Description(@"Proceeds resulting from a (buy) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).")]
    ProceedsFromBuyTransactionInOurDTCCDividendTradingAccount = DTCAdjustmentPaymentSubReasonCode.ProceedsFromBuyTransactionInOurDTCCDividendTradingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proceeds from sale of.
    /// Encoded/decoded by serializers as &quot;SPFS&quot;.
    /// </summary>
    [EnumMember(Value = "SPFS")]
    [IsoId("_CLgl8WjMEeOdXoiw6mfXMw")]
    [Description(@"Proceeds from sale of.")]
    ProceedsFromSaleOf = DTCAdjustmentPaymentSubReasonCode.ProceedsFromSaleOf, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).
    /// Encoded/decoded by serializers as &quot;SSS5&quot;.
    /// </summary>
    [EnumMember(Value = "SSS5")]
    [IsoId("_CPwMwWjMEeOdXoiw6mfXMw")]
    [Description(@"Proceeds resulting from a (sell) transaction affected in our DTCC/dividend trading account (#428‑10288‑1‑3‑039).")]
    ProceedsResultingFromaASellTransactionAffectedInOurDTCCDividendTradingAccount = DTCAdjustmentPaymentSubReasonCode.ProceedsResultingFromaASellTransactionAffectedInOurDTCCDividendTradingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information.
    /// Encoded/decoded by serializers as &quot;SRTA&quot;.
    /// </summary>
    [EnumMember(Value = "SRTA")]
    [IsoId("_CT6UAWjMEeOdXoiw6mfXMw")]
    [Description(@"This allocation was adjusted for a rate change. Please refer to DIVA comment field for additional information.")]
    RateChange = DTCAdjustmentPaymentSubReasonCode.RateChange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate revisionfor fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFLR&quot;.
    /// </summary>
    [EnumMember(Value = "SFLR")]
    [IsoId("_CYD0MWjMEeOdXoiw6mfXMw")]
    [Description(@"Rate revisionfor fail tracking related adjustment.")]
    RateRevision = DTCAdjustmentPaymentSubReasonCode.RateRevision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate unknown for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL0&quot;.
    /// </summary>
    [EnumMember(Value = "SFL0")]
    [IsoId("_CcNUYWjMEeOdXoiw6mfXMw")]
    [Description(@"Rate unknown for fail tracking related adjustment.")]
    RateUnknown = DTCAdjustmentPaymentSubReasonCode.RateUnknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Our record date position was adjusted for a withdrawal by transfer activity.
    /// Encoded/decoded by serializers as &quot;SWHT&quot;.
    /// </summary>
    [EnumMember(Value = "SWHT")]
    [IsoId("_Cko3oWjMEeOdXoiw6mfXMw")]
    [Description(@"Our record date position was adjusted for a withdrawal by transfer activity.")]
    RecordDatePositionAdjustedForaWithdrawalByTransfer = DTCAdjustmentPaymentSubReasonCode.RecordDatePositionAdjustedForaWithdrawalByTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC redemption related adjustment.
    /// Encoded/decoded by serializers as &quot;SJE7&quot;.
    /// </summary>
    [EnumMember(Value = "SJE7")]
    [IsoId("_Co5FgWjMEeOdXoiw6mfXMw")]
    [Description(@"DTCC redemption related adjustment.")]
    RedemptionAdjustment = DTCAdjustmentPaymentSubReasonCode.RedemptionAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption cash settlement.
    /// Encoded/decoded by serializers as &quot;SGL7&quot;.
    /// </summary>
    [EnumMember(Value = "SGL7")]
    [IsoId("_CtLIkWjMEeOdXoiw6mfXMw")]
    [Description(@"Redemption cash settlement.")]
    RedemptionCash = DTCAdjustmentPaymentSubReasonCode.RedemptionCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption payment due to pledge release.
    /// Encoded/decoded by serializers as &quot;SGLP&quot;.
    /// </summary>
    [EnumMember(Value = "SGLP")]
    [IsoId("_CxV24WjMEeOdXoiw6mfXMw")]
    [Description(@"Redemption payment due to pledge release.")]
    RedemptionPaymentDueToPledgeRelease = DTCAdjustmentPaymentSubReasonCode.RedemptionPaymentDueToPledgeRelease, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The 25% french withholding rate has been revised. This adjustment is based on the refunded tax rate.
    /// Encoded/decoded by serializers as &quot;SFJ9&quot;.
    /// </summary>
    [EnumMember(Value = "SFJ9")]
    [IsoId("_C1iaYWjMEeOdXoiw6mfXMw")]
    [Description(@"The 25% french withholding rate has been revised. This adjustment is based on the refunded tax rate.")]
    RefundedTaxRate = DTCAdjustmentPaymentSubReasonCode.RefundedTaxRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of french tax based on acceptance of global reclamation for the july 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRB&quot;.
    /// </summary>
    [EnumMember(Value = "SFRB")]
    [IsoId("_C5shoWjMEeOdXoiw6mfXMw")]
    [Description(@"Refund of french tax based on acceptance of global reclamation for the july 1992 distribution refer to important notice b # 1352‑93.")]
    RefundOfFrenchTaxJuly = DTCAdjustmentPaymentSubReasonCode.RefundOfFrenchTaxJuly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refund of french tax based on acceptance of global reclamation for the june 1992 distribution refer to important notice b # 1352‑93.
    /// Encoded/decoded by serializers as &quot;SFRA&quot;.
    /// </summary>
    [EnumMember(Value = "SFRA")]
    [IsoId("_DgpM4WjMEeOdXoiw6mfXMw")]
    [Description(@"Refund of french tax based on acceptance of global reclamation for the june 1992 distribution refer to important notice b # 1352‑93.")]
    RefundOfFrenchTaxJune = DTCAdjustmentPaymentSubReasonCode.RefundOfFrenchTaxJune, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reinstate for fail tracking related adjustment.
    /// Encoded/decoded by serializers as &quot;SFL2&quot;.
    /// </summary>
    [EnumMember(Value = "SFL2")]
    [IsoId("_DkzUIWjMEeOdXoiw6mfXMw")]
    [Description(@"Reinstate for fail tracking related adjustment.")]
    Reinstate = DTCAdjustmentPaymentSubReasonCode.Reinstate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC reorganization related adjustment.
    /// Encoded/decoded by serializers as &quot;SJR7&quot;.
    /// </summary>
    [EnumMember(Value = "SJR7")]
    [IsoId("_DtL0EWjMEeOdXoiw6mfXMw")]
    [Description(@"DTCC reorganization related adjustment.|")]
    ReorganizationAdjustment = DTCAdjustmentPaymentSubReasonCode.ReorganizationAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To adjust allocation at 100% on your tax exempt instructions.
    /// Encoded/decoded by serializers as &quot;STEA&quot;.
    /// </summary>
    [EnumMember(Value = "STEA")]
    [IsoId("_EbENwWjMEeOdXoiw6mfXMw")]
    [Description(@"To adjust allocation at 100% on your tax exempt instructions.")]
    TaxExemptInstructions = DTCAdjustmentPaymentSubReasonCode.TaxExemptInstructions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest adjusted due to tender fee deduction.
    /// Encoded/decoded by serializers as &quot;SAF7&quot;.
    /// </summary>
    [EnumMember(Value = "SAF7")]
    [IsoId("_EfOVAWjMEeOdXoiw6mfXMw")]
    [Description(@"Interest adjusted due to tender fee deduction.")]
    TenderFeeDeduction = DTCAdjustmentPaymentSubReasonCode.TenderFeeDeduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your account is being credited at the unfav rate (20%) as a result of the reorg merger pd on 4/2/93 (Armstrong Pharm to Medeva plc, eff 1/15/93; if entitled to fav rate(15%), you must follow attached.
    /// Encoded/decoded by serializers as &quot;SAA7&quot;.
    /// </summary>
    [EnumMember(Value = "SAA7")]
    [IsoId("_EjXOIWjMEeOdXoiw6mfXMw")]
    [Description(@"Your account is being credited at the unfav rate (20%) as a result of the reorg merger pd on 4/2/93 (Armstrong Pharm to Medeva plc, eff 1/15/93; if entitled to fav rate(15%), you must follow attached.")]
    UnfavorableRateMerger = DTCAdjustmentPaymentSubReasonCode.UnfavorableRateMerger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Uninsured interest withheld as per FSLICN.
    /// Encoded/decoded by serializers as &quot;SAWA&quot;.
    /// </summary>
    [EnumMember(Value = "SAWA")]
    [IsoId("_EnfgMWjMEeOdXoiw6mfXMw")]
    [Description(@"Uninsured interest withheld as per FSLICN.")]
    UninsuredInterestWithheld = DTCAdjustmentPaymentSubReasonCode.UninsuredInterestWithheld, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to receive Vodafone Group adrs at 11.354392 for every 100 adrs.
    /// Encoded/decoded by serializers as &quot;SRRA&quot;.
    /// </summary>
    [EnumMember(Value = "SRRA")]
    [IsoId("_Ert44WjMEeOdXoiw6mfXMw")]
    [Description(@"Option to receive Vodafone Group adrs at 11.354392 for every 100 adrs.")]
    VodaphoneADR = DTCAdjustmentPaymentSubReasonCode.VodaphoneADR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DTCC WT related adjustment.
    /// Encoded/decoded by serializers as &quot;SJWT&quot;.
    /// </summary>
    [EnumMember(Value = "SJWT")]
    [IsoId("_Ev51UWjMEeOdXoiw6mfXMw")]
    [Description(@"DTCC WT related adjustment.")]
    WithdrawalTransferAdjustment = DTCAdjustmentPaymentSubReasonCode.WithdrawalTransferAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Your record date position was adjusted for a w/t buy back withdrawal.
    /// Encoded/decoded by serializers as &quot;SBB2&quot;.
    /// </summary>
    [EnumMember(Value = "SBB2")]
    [IsoId("_E0FxwWjMEeOdXoiw6mfXMw")]
    [Description(@"Your record date position was adjusted for a w/t buy back withdrawal.")]
    WithdrawalTransferBuyBackWithdrawal = DTCAdjustmentPaymentSubReasonCode.WithdrawalTransferBuyBackWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country.
    /// Encoded/decoded by serializers as &quot;SWTA&quot;.
    /// </summary>
    [EnumMember(Value = "SWTA")]
    [IsoId("_E4QgEWjMEeOdXoiw6mfXMw")]
    [Description(@"Adjustment to allocation to charge (user defined percentage) withholding tax in (user defined) country.")]
    WithholdingTaxAdjustmentInUserDefinedCountry = DTCAdjustmentPaymentSubReasonCode.WithholdingTaxAdjustmentInUserDefinedCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Write off reorganization related adjustment.
    /// Encoded/decoded by serializers as &quot;SJEW&quot;.
    /// </summary>
    [EnumMember(Value = "SJEW")]
    [IsoId("_E8bOYWjMEeOdXoiw6mfXMw")]
    [Description(@"Write off reorganization related adjustment.")]
    WriteOffReorganization = DTCAdjustmentPaymentSubReasonCode.WriteOffReorganization, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.
    /// Encoded/decoded by serializers as &quot;SPRA&quot;.
    /// </summary>
    [EnumMember(Value = "SPRA")]
    [IsoId("_FEtnsWjMEeOdXoiw6mfXMw")]
    [Description(@"The principal previously paid to you was at the wrong rate. This adjustment is to correct that erroneous payment.")]
    WrongRatePrincipal = DTCAdjustmentPaymentSubReasonCode.WrongRatePrincipal, // same ordinal as derivation source for type conversions
    
}
