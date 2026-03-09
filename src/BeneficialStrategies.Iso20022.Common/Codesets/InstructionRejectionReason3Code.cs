// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BNsdQFCDEe2KGNXAcFL5RA")]
[Description(@"Reason for rejection of a corporate action instruction or of an instruction cancellation.")]
[DerivedFrom(typeof(InstructionRejectionReasonV2Code))]
public enum InstructionRejectionReason3Code
{
    /// <summary>
    /// Acknowledgement must be agreed.
    /// Encoded/decoded by serializers as &quot;ACKA&quot;.
    /// </summary>
    [EnumMember(Value = "ACKA")]
    [IsoId("_gbIwsVCDEe2KGNXAcFL5RA")]
    [Description(@"Acknowledgement must be agreed.")]
    AcknowledgementNotAgreed = InstructionRejectionReasonV2Code.AcknowledgementNotAgreed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgment indicator is missing.
    /// Encoded/decoded by serializers as &quot;ACKS&quot;.
    /// </summary>
    [EnumMember(Value = "ACKS")]
    [IsoId("_gv0nQVCDEe2KGNXAcFL5RA")]
    [Description(@"Acknowledgment indicator is missing.")]
    AcknowledgmentIndicatorMissing = InstructionRejectionReasonV2Code.AcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;ADIN&quot;.
    /// </summary>
    [EnumMember(Value = "ADIN")]
    [IsoId("_hBjQcVCDEe2KGNXAcFL5RA")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is invalid.")]
    AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid = InstructionRejectionReasonV2Code.AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("_hQgScVCDEe2KGNXAcFL5RA")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is missing.")]
    AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing = InstructionRejectionReasonV2Code.AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficial owner death date is missing.
    /// Encoded/decoded by serializers as &quot;BODD&quot;.
    /// </summary>
    [EnumMember(Value = "BODD")]
    [IsoId("_hc0QIVCDEe2KGNXAcFL5RA")]
    [Description(@"Beneficial owner death date is missing.")]
    BeneficialOwnerDeathDateMissing = InstructionRejectionReasonV2Code.BeneficialOwnerDeathDateMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficial owner name is missing.
    /// Encoded/decoded by serializers as &quot;BONM&quot;.
    /// </summary>
    [EnumMember(Value = "BONM")]
    [IsoId("_hqh8AVCDEe2KGNXAcFL5RA")]
    [Description(@"Beneficial owner name is missing.")]
    BeneficialOwnerNameMissing = InstructionRejectionReasonV2Code.BeneficialOwnerNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_h6oNgVCDEe2KGNXAcFL5RA")]
    [Description(@"Bid price is missing or invalid.")]
    BidPriceMissingOrInvalid = InstructionRejectionReasonV2Code.BidPriceMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price cannot be greater than 9999.99999.
    /// Encoded/decoded by serializers as &quot;BIDG&quot;.
    /// </summary>
    [EnumMember(Value = "BIDG")]
    [IsoId("_iGhUcVCDEe2KGNXAcFL5RA")]
    [Description(@"Bid price cannot be greater than 9999.99999.")]
    BidPriceOverflow = InstructionRejectionReasonV2Code.BidPriceOverflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price exceeds maximum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_iXPRAVCDEe2KGNXAcFL5RA")]
    [Description(@"Bid price exceeds maximum bid price allowed for the offer.")]
    BidPriceOverMaximumAllowed = InstructionRejectionReasonV2Code.BidPriceOverMaximumAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price is less than the minimum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDM&quot;.
    /// </summary>
    [EnumMember(Value = "BIDM")]
    [IsoId("_iuLxYVCDEe2KGNXAcFL5RA")]
    [Description(@"Bid price is less than the minimum bid price allowed for the offer.")]
    BidPriceUnderMinimumAllowed = InstructionRejectionReasonV2Code.BidPriceUnderMinimumAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Zeroes are required for bid price.
    /// Encoded/decoded by serializers as &quot;BID0&quot;.
    /// </summary>
    [EnumMember(Value = "BID0")]
    [IsoId("_i588gVCDEe2KGNXAcFL5RA")]
    [Description(@"Zeroes are required for bid price.")]
    BidPriceZeroesRequired = InstructionRejectionReasonV2Code.BidPriceZeroesRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bond check on master table is not available.
    /// Encoded/decoded by serializers as &quot;BNDU&quot;.
    /// </summary>
    [EnumMember(Value = "BNDU")]
    [IsoId("_jIaPQVCDEe2KGNXAcFL5RA")]
    [Description(@"Bond check on master table is not available.")]
    BondCheckOnMasterTableNotAvailable = InstructionRejectionReasonV2Code.BondCheckOnMasterTableNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number is missing.
    /// Encoded/decoded by serializers as &quot;CENM&quot;.
    /// </summary>
    [EnumMember(Value = "CENM")]
    [IsoId("_jfRQEVCDEe2KGNXAcFL5RA")]
    [Description(@"Certificate number is missing.")]
    CertificateNameMissing = InstructionRejectionReasonV2Code.CertificateNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number is invalid.
    /// Encoded/decoded by serializers as &quot;CERN&quot;.
    /// </summary>
    [EnumMember(Value = "CERN")]
    [IsoId("_jxwHMVCDEe2KGNXAcFL5RA")]
    [Description(@"Certificate number is invalid.")]
    CertificateNumberInvalid = InstructionRejectionReasonV2Code.CertificateNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate sequence number is invalid.
    /// Encoded/decoded by serializers as &quot;CERS&quot;.
    /// </summary>
    [EnumMember(Value = "CERS")]
    [IsoId("_l9BE4VCDEe2KGNXAcFL5RA")]
    [Description(@"Certificate sequence number is invalid.")]
    CertificateSequenceNumberInvalid = InstructionRejectionReasonV2Code.CertificateSequenceNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Comment area is invalid.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_mJid8VCDEe2KGNXAcFL5RA")]
    [Description(@"Comment area is invalid.")]
    CommentAreaInvalid = InstructionRejectionReasonV2Code.CommentAreaInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN1N&quot;.
    /// </summary>
    [EnumMember(Value = "CN1N")]
    [IsoId("_mWNA8VCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 1 indicator is invalid. It must be No.")]
    Condition1InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition1InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN1Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN1Y")]
    [IsoId("_mj7T4VCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 1 indicator is invalid. It must be Yes.")]
    Condition1InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition1InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN1R&quot;.
    /// </summary>
    [EnumMember(Value = "CN1R")]
    [IsoId("_m1C5EVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 1 indicator is must be present.")]
    Condition1Required = InstructionRejectionReasonV2Code.Condition1Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN2N&quot;.
    /// </summary>
    [EnumMember(Value = "CN2N")]
    [IsoId("_oJrwwVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 2 indicator is invalid. It must be No.")]
    Condition2InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition2InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN2Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN2Y")]
    [IsoId("_oQ_SoVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 2 indicator is invalid. It must be Yes.")]
    Condition2InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition2InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN2R&quot;.
    /// </summary>
    [EnumMember(Value = "CN2R")]
    [IsoId("_obRQAVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 2 indicator is must be present.")]
    Condition2Required = InstructionRejectionReasonV2Code.Condition2Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN3N&quot;.
    /// </summary>
    [EnumMember(Value = "CN3N")]
    [IsoId("_olQScVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 3 indicator is invalid. It must be No.")]
    Condition3InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition3InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN3Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN3Y")]
    [IsoId("_ouV9AVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 3 indicator is invalid. It must be Yes.")]
    Condition3InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition3InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN3R&quot;.
    /// </summary>
    [EnumMember(Value = "CN3R")]
    [IsoId("_o7AgAVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 3 indicator is must be present.")]
    Condition3Required = InstructionRejectionReasonV2Code.Condition3Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN4N&quot;.
    /// </summary>
    [EnumMember(Value = "CN4N")]
    [IsoId("_pNVmIVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 4 indicator is invalid. It must be No.")]
    Condition4InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition4InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN4Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN4Y")]
    [IsoId("_pvw9wVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 4 indicator is invalid. It must be Yes.")]
    Condition4InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition4InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN4R&quot;.
    /// </summary>
    [EnumMember(Value = "CN4R")]
    [IsoId("_qJMxcVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 4 indicator is must be present.")]
    Condition4Required = InstructionRejectionReasonV2Code.Condition4Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN5N&quot;.
    /// </summary>
    [EnumMember(Value = "CN5N")]
    [IsoId("_qXjWgVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 5 indicator is invalid. It must be No.")]
    Condition5InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition5InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN5Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN5Y")]
    [IsoId("_qejWYVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 5 indicator is invalid. It must be Yes.")]
    Condition5InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition5InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN5R&quot;.
    /// </summary>
    [EnumMember(Value = "CN5R")]
    [IsoId("_qk9gYVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 5 indicator is must be present.")]
    Condition5Required = InstructionRejectionReasonV2Code.Condition5Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN6N&quot;.
    /// </summary>
    [EnumMember(Value = "CN6N")]
    [IsoId("_q2c5AVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 6 indicator is invalid. It must be No.")]
    Condition6InvalidMustBeNo = InstructionRejectionReasonV2Code.Condition6InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN6Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN6Y")]
    [IsoId("_q9QEkVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 6 indicator is invalid. It must be Yes.")]
    Condition6InvalidMustBeYes = InstructionRejectionReasonV2Code.Condition6InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN6R&quot;.
    /// </summary>
    [EnumMember(Value = "CN6R")]
    [IsoId("_rE_rUVCDEe2KGNXAcFL5RA")]
    [Description(@"Condition 6 indicator is must be present.")]
    Condition6Required = InstructionRejectionReasonV2Code.Condition6Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;COQX&quot;.
    /// </summary>
    [EnumMember(Value = "COQX")]
    [IsoId("_reoTUVCDEe2KGNXAcFL5RA")]
    [Description(@"Conditional quantity cannot be zero.")]
    ConditionalQuantityCannotBeZero = InstructionRejectionReasonV2Code.ConditionalQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity does not equal the transaction quantity whilst this offer accepts only the full conditional quantity.
    /// Encoded/decoded by serializers as &quot;COTQ&quot;.
    /// </summary>
    [EnumMember(Value = "COTQ")]
    [IsoId("_tOixwVCDEe2KGNXAcFL5RA")]
    [Description(@"Conditional quantity does not equal the transaction quantity whilst this offer accepts only the full conditional quantity.")]
    ConditionalQuantityDoesNotEqualTransactionQuantity = InstructionRejectionReasonV2Code.ConditionalQuantityDoesNotEqualTransactionQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity exceeds the transaction quantity.
    /// Encoded/decoded by serializers as &quot;COQE&quot;.
    /// </summary>
    [EnumMember(Value = "COQE")]
    [IsoId("_tcixgVCDEe2KGNXAcFL5RA")]
    [Description(@"Conditional quantity exceeds the transaction quantity.")]
    ConditionalQuantityExceedsTransactionQuantity = InstructionRejectionReasonV2Code.ConditionalQuantityExceedsTransactionQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;COQI&quot;.
    /// </summary>
    [EnumMember(Value = "COQI")]
    [IsoId("_twbW0VCDEe2KGNXAcFL5RA")]
    [Description(@"Conditional quantity is missing or invalid.")]
    ConditionalQuantityMissingOrInvalid = InstructionRejectionReasonV2Code.ConditionalQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity zeroes are required.
    /// Encoded/decoded by serializers as &quot;COQ0&quot;.
    /// </summary>
    [EnumMember(Value = "COQ0")]
    [IsoId("_uFBt0VCDEe2KGNXAcFL5RA")]
    [Description(@"Conditional quantity zeroes are required.")]
    ConditionalQuantityZeroesRequired = InstructionRejectionReasonV2Code.ConditionalQuantityZeroesRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact name is missing.
    /// Encoded/decoded by serializers as &quot;CNAM&quot;.
    /// </summary>
    [EnumMember(Value = "CNAM")]
    [IsoId("_uT0-0VCDEe2KGNXAcFL5RA")]
    [Description(@"Contact name is missing.")]
    ContactNameMissing = InstructionRejectionReasonV2Code.ContactNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact name is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNAX&quot;.
    /// </summary>
    [EnumMember(Value = "CNAX")]
    [IsoId("_uhoKQVCDEe2KGNXAcFL5RA")]
    [Description(@"Contact name is not used with this event.")]
    ContactNameNotUsedWithEvent = InstructionRejectionReasonV2Code.ContactNameNotUsedWithEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact phone number is missing.
    /// Encoded/decoded by serializers as &quot;CNPM&quot;.
    /// </summary>
    [EnumMember(Value = "CNPM")]
    [IsoId("_wn-ywVCDEe2KGNXAcFL5RA")]
    [Description(@"Contact phone number is missing.")]
    ContactPhoneNumberMissing = InstructionRejectionReasonV2Code.ContactPhoneNumberMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact phone number is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNPX&quot;.
    /// </summary>
    [EnumMember(Value = "CNPX")]
    [IsoId("_w2SUgVCDEe2KGNXAcFL5RA")]
    [Description(@"Contact phone number is not used with this event.")]
    ContactPhoneNumberNotUsedWithEvent = InstructionRejectionReasonV2Code.ContactPhoneNumberNotUsedWithEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is summary difference between core oversubscription quantity and extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUMO&quot;.
    /// </summary>
    [EnumMember(Value = "SUMO")]
    [IsoId("_xHsNkVCDEe2KGNXAcFL5RA")]
    [Description(@"There is summary difference between core oversubscription quantity and extension transaction details.")]
    CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference = InstructionRejectionReasonV2Code.CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is a summary difference between the core instruction quantity and the extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUME&quot;.
    /// </summary>
    [EnumMember(Value = "SUME")]
    [IsoId("_xRYVEVCDEe2KGNXAcFL5RA")]
    [Description(@"There is a summary difference between the core instruction quantity and the extension transaction details.")]
    CoreInstructionQuantityAndExtensionTransactionDetailsDifference = InstructionRejectionReasonV2Code.CoreInstructionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action event identification is invalid.
    /// Encoded/decoded by serializers as &quot;CAID&quot;.
    /// </summary>
    [EnumMember(Value = "CAID")]
    [IsoId("_xlx3wVCDEe2KGNXAcFL5RA")]
    [Description(@"Corporate action event identification is invalid.")]
    CorporateActionEventInvalid = InstructionRejectionReasonV2Code.CorporateActionEventInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cover quantity is greater than the remaining protect quantity.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_8NAVIVCDEe2KGNXAcFL5RA")]
    [Description(@"Cover quantity is greater than the remaining protect quantity.")]
    CoverQuantityGreaterThanProtectQuantity = InstructionRejectionReasonV2Code.CoverQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current date is greater than the protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROE&quot;.
    /// </summary>
    [EnumMember(Value = "PROE")]
    [IsoId("_8t-7QVCDEe2KGNXAcFL5RA")]
    [Description(@"Current date is greater than the protect submission end date.")]
    CurrentDatePassedProtectSubmissionEndDate = InstructionRejectionReasonV2Code.CurrentDatePassedProtectSubmissionEndDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current date is less than the protect submission start date.
    /// Encoded/decoded by serializers as &quot;PROS&quot;.
    /// </summary>
    [EnumMember(Value = "PROS")]
    [IsoId("_86MyUVCDEe2KGNXAcFL5RA")]
    [Description(@"Current date is less than the protect submission start date.")]
    CurrentDatePrecedesProtectSubmissionStartDate = InstructionRejectionReasonV2Code.CurrentDatePrecedesProtectSubmissionStartDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CUSIP is depository deliver chilled.
    /// Encoded/decoded by serializers as &quot;CHIL&quot;.
    /// </summary>
    [EnumMember(Value = "CHIL")]
    [IsoId("_9EcTcVCDEe2KGNXAcFL5RA")]
    [Description(@"CUSIP is depository deliver chilled.")]
    CUSIPDepositoryDeliverChilled = InstructionRejectionReasonV2Code.CUSIPDepositoryDeliverChilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Target CUSIP or contra CUSIP identification is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;CUSD&quot;.
    /// </summary>
    [EnumMember(Value = "CUSD")]
    [IsoId("_9YtTQVCDEe2KGNXAcFL5RA")]
    [Description(@"Target CUSIP or contra CUSIP identification is not DTC eligible.")]
    CUSIPNotDTCEligible = InstructionRejectionReasonV2Code.CUSIPNotDTCEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Target CUSIP or contra CUSIP identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUSI&quot;.
    /// </summary>
    [EnumMember(Value = "CUSI")]
    [IsoId("_9sE7MVCDEe2KGNXAcFL5RA")]
    [Description(@"Target CUSIP or contra CUSIP identification is missing or invalid.")]
    CUSIPMissingOrInvalid = InstructionRejectionReasonV2Code.CUSIPMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer oversubscription quantities do not add up to total oversubscription quantity.
    /// Encoded/decoded by serializers as &quot;OVCU&quot;.
    /// </summary>
    [EnumMember(Value = "OVCU")]
    [IsoId("_-qPzoVCDEe2KGNXAcFL5RA")]
    [Description(@"Customer oversubscription quantities do not add up to total oversubscription quantity.")]
    CustomerAndTotalOversubscriptionQuantitiesMismatch = InstructionRejectionReasonV2Code.CustomerAndTotalOversubscriptionQuantitiesMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_-yaRIVCDEe2KGNXAcFL5RA")]
    [Description(@"Customer identification is missing or invalid.")]
    CustomerIdentificationMissingOrInvalid = InstructionRejectionReasonV2Code.CustomerIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer quantities do not add up to total rights quantities.
    /// Encoded/decoded by serializers as &quot;CQRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CQRQ")]
    [IsoId("__Rs1MVCDEe2KGNXAcFL5RA")]
    [Description(@"Customer quantities do not add up to total rights quantities.")]
    CustomerQuantitiesAndTotalRightsQuantitiesMismatch = InstructionRejectionReasonV2Code.CustomerQuantitiesAndTotalRightsQuantitiesMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer sequence number must be all zero.
    /// Encoded/decoded by serializers as &quot;SEQ0&quot;.
    /// </summary>
    [EnumMember(Value = "SEQ0")]
    [IsoId("_DZKZ0VCEEe2KGNXAcFL5RA")]
    [Description(@"Customer sequence number must be all zero.")]
    CustomerSequenceNumberAllZero = InstructionRejectionReasonV2Code.CustomerSequenceNumberAllZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer sequence number is invalid or out of sequence.
    /// Encoded/decoded by serializers as &quot;CSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSEQ")]
    [IsoId("_D1ESsVCEEe2KGNXAcFL5RA")]
    [Description(@"Customer sequence number is invalid or out of sequence.")]
    CustomerSequenceNumberInvalid = InstructionRejectionReasonV2Code.CustomerSequenceNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off time check has failed.
    /// Encoded/decoded by serializers as &quot;CUTC&quot;.
    /// </summary>
    [EnumMember(Value = "CUTC")]
    [IsoId("_EmgWsVCEEe2KGNXAcFL5RA")]
    [Description(@"Cut-off time check has failed.")]
    CutoffTimeCheckFailed = InstructionRejectionReasonV2Code.CutoffTimeCheckFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off time has passed.
    /// Encoded/decoded by serializers as &quot;CUTT&quot;.
    /// </summary>
    [EnumMember(Value = "CUTT")]
    [IsoId("_E2JVMVCEEe2KGNXAcFL5RA")]
    [Description(@"Cut-off time has passed.")]
    CutoffTimePassed = InstructionRejectionReasonV2Code.CutoffTimePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Death certificate details are missing.
    /// Encoded/decoded by serializers as &quot;BODC&quot;.
    /// </summary>
    [EnumMember(Value = "BODC")]
    [IsoId("_E_Pm0VCEEe2KGNXAcFL5RA")]
    [Description(@"Death certificate details are missing.")]
    DeathCertificateMissing = InstructionRejectionReasonV2Code.DeathCertificateMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction sequence number is duplicated.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_FhD6cVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction sequence number is duplicated.")]
    DuplicateTransactionSequenceNumber = InstructionRejectionReasonV2Code.DuplicateTransactionSequenceNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry date is invalid.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_F14T4VCEEe2KGNXAcFL5RA")]
    [Description(@"Entry date is invalid.")]
    EntryDateInvalid = InstructionRejectionReasonV2Code.EntryDateInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_GENDwVCEEe2KGNXAcFL5RA")]
    [Description(@"Entry date must be less than or equal to current date.")]
    EntryDatePassed = InstructionRejectionReasonV2Code.EntryDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event already allocated.
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_Gt9LYVCEEe2KGNXAcFL5RA")]
    [Description(@"Event already allocated.")]
    EventAlreadyAllocated = InstructionRejectionReasonV2Code.EventAlreadyAllocated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer has fractional underlying quantity, adjust quantity.
    /// Encoded/decoded by serializers as &quot;FRAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FRAQ")]
    [IsoId("_HOnocVCEEe2KGNXAcFL5RA")]
    [Description(@"Customer has fractional underlying quantity, adjust quantity.")]
    FractionalUnderlyingQuantity = InstructionRejectionReasonV2Code.FractionalUnderlyingQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Function is not available at this time. Please check expiration start and end times for the event.
    /// Encoded/decoded by serializers as &quot;FUNU&quot;.
    /// </summary>
    [EnumMember(Value = "FUNU")]
    [IsoId("_Hk9r4VCEEe2KGNXAcFL5RA")]
    [Description(@"Function is not available at this time. Please check expiration start and end times for the event.")]
    FunctionNotAvailable = InstructionRejectionReasonV2Code.FunctionNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Function is quiesced (not available).
    /// Encoded/decoded by serializers as &quot;QUIE&quot;.
    /// </summary>
    [EnumMember(Value = "QUIE")]
    [IsoId("_Hq570VCEEe2KGNXAcFL5RA")]
    [Description(@"Function is quiesced (not available).")]
    FunctionQuiesced = InstructionRejectionReasonV2Code.FunctionQuiesced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction deletion acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_IIxjkVCEEe2KGNXAcFL5RA")]
    [Description(@"Instruction deletion acknowledgement indicator is invalid.")]
    InstructionDeletionAcknowledgementIndicatorInvalid = InstructionRejectionReasonV2Code.InstructionDeletionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction deletion acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_IXKk4VCEEe2KGNXAcFL5RA")]
    [Description(@"Instruction deletion acknowledgement indicator is missing.")]
    InstructionDeletionAcknowledgementIndicatorMissing = InstructionRejectionReasonV2Code.InstructionDeletionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant has an insufficient position.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_JdxAkVCEEe2KGNXAcFL5RA")]
    [Description(@"Participant has an insufficient position.")]
    InsufficientPosition = InstructionRejectionReasonV2Code.InsufficientPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event type is not valid.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_JxLEwVCEEe2KGNXAcFL5RA")]
    [Description(@"Event type is not valid.")]
    InvalidEventType = InstructionRejectionReasonV2Code.InvalidEventType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option number is not valid.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_KPRWAVCEEe2KGNXAcFL5RA")]
    [Description(@"Option number is not valid.")]
    InvalidOptionNumber = InstructionRejectionReasonV2Code.InvalidOptionNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option type is not valid.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_KXwjoVCEEe2KGNXAcFL5RA")]
    [Description(@"Option type is not valid.")]
    InvalidOptionType = InstructionRejectionReasonV2Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuing jurisdiction is missing.
    /// Encoded/decoded by serializers as &quot;BOIJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOIJ")]
    [IsoId("_L21JsVCEEe2KGNXAcFL5RA")]
    [Description(@"Issuing jurisdiction is missing.")]
    IssuingJurisdictionMissing = InstructionRejectionReasonV2Code.IssuingJurisdictionMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key data (VOI transaction) cannot be found.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_PNQS8VCEEe2KGNXAcFL5RA")]
    [Description(@"Key data (VOI transaction) cannot be found.")]
    KeyDataNotFound = InstructionRejectionReasonV2Code.KeyDataNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key information is missing (tenders data).
    /// Encoded/decoded by serializers as &quot;KEYM&quot;.
    /// </summary>
    [EnumMember(Value = "KEYM")]
    [IsoId("_PwuzcVCEEe2KGNXAcFL5RA")]
    [Description(@"Key information is missing (tenders data).")]
    KeyInformationMissing = InstructionRejectionReasonV2Code.KeyInformationMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;LEGI&quot;.
    /// </summary>
    [EnumMember(Value = "LEGI")]
    [IsoId("_P9QMgVCEEe2KGNXAcFL5RA")]
    [Description(@"Legal documentation thirty months retention acknowledgement indicator is invalid.")]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid = InstructionRejectionReasonV2Code.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;LEGM&quot;.
    /// </summary>
    [EnumMember(Value = "LEGM")]
    [IsoId("_QIucsVCEEe2KGNXAcFL5RA")]
    [Description(@"Legal documentation thirty months retention acknowledgement indicator is missing.")]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing = InstructionRejectionReasonV2Code.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Master tables are not available.
    /// Encoded/decoded by serializers as &quot;MSTB&quot;.
    /// </summary>
    [EnumMember(Value = "MSTB")]
    [IsoId("_QZjuAVCEEe2KGNXAcFL5RA")]
    [Description(@"Master tables are not available.")]
    MasterTablesNotAvailable = InstructionRejectionReasonV2Code.MasterTablesNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not eligible for withdrawal, not in made status
    /// Encoded/decoded by serializers as &quot;NELG&quot;.
    /// </summary>
    [EnumMember(Value = "NELG")]
    [IsoId("_S0gGcVCEEe2KGNXAcFL5RA")]
    [Description(@"Not eligible for withdrawal, not in made status")]
    NotEligibleForWithdrawal = InstructionRejectionReasonV2Code.NotEligibleForWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is no withdrawal privilege on this offer.
    /// Encoded/decoded by serializers as &quot;NWIT&quot;.
    /// </summary>
    [EnumMember(Value = "NWIT")]
    [IsoId("_TGt30VCEEe2KGNXAcFL5RA")]
    [Description(@"There is no withdrawal privilege on this offer.")]
    NoWithdrawalPrivilege = InstructionRejectionReasonV2Code.NoWithdrawalPrivilege, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Odd lot indicator is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ODLI&quot;.
    /// </summary>
    [EnumMember(Value = "ODLI")]
    [IsoId("_UjG9UVCEEe2KGNXAcFL5RA")]
    [Description(@"Odd lot indicator is missing or invalid.")]
    OddLotIndicatorMissingOrInvalid = InstructionRejectionReasonV2Code.OddLotIndicatorMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cannot submit odd lot indicator &apos;Yes&apos; for the offer.
    /// Encoded/decoded by serializers as &quot;ODLY&quot;.
    /// </summary>
    [EnumMember(Value = "ODLY")]
    [IsoId("_U9CgQVCEEe2KGNXAcFL5RA")]
    [Description(@"Cannot submit odd lot indicator 'Yes' for the offer.")]
    OddLotIndicatorYesInvalid = InstructionRejectionReasonV2Code.OddLotIndicatorYesInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is already on historical data base.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_VIjzwVCEEe2KGNXAcFL5RA")]
    [Description(@"Offer is already on historical data base.")]
    OfferInDatabase = InstructionRejectionReasonV2Code.OfferInDatabase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is not ATOP eligible.
    /// Encoded/decoded by serializers as &quot;ATOP&quot;.
    /// </summary>
    [EnumMember(Value = "ATOP")]
    [IsoId("_VV66UVCEEe2KGNXAcFL5RA")]
    [Description(@"Offer is not ATOP eligible.")]
    OfferNotATOPEligible = InstructionRejectionReasonV2Code.OfferNotATOPEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is not eligible for the PUTS function.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_Vg8ekVCEEe2KGNXAcFL5RA")]
    [Description(@"Offer is not eligible for the PUTS function.")]
    OfferNotEligibleForPuts = InstructionRejectionReasonV2Code.OfferNotEligibleForPuts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription is not allowed.
    /// Encoded/decoded by serializers as &quot;OVRX&quot;.
    /// </summary>
    [EnumMember(Value = "OVRX")]
    [IsoId("_WPb8QVCEEe2KGNXAcFL5RA")]
    [Description(@"Oversubscription is not allowed.")]
    OversubscriptionNotAllowed = InstructionRejectionReasonV2Code.OversubscriptionNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity is greater than percentage of underlying shares.
    /// Encoded/decoded by serializers as &quot;OVRG&quot;.
    /// </summary>
    [EnumMember(Value = "OVRG")]
    [IsoId("_WmFhsVCEEe2KGNXAcFL5RA")]
    [Description(@"Oversubscription quantity is greater than percentage of underlying shares.")]
    OversubscriptionQuantityExceeded = InstructionRejectionReasonV2Code.OversubscriptionQuantityExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity is invalid.
    /// Encoded/decoded by serializers as &quot;OVRI&quot;.
    /// </summary>
    [EnumMember(Value = "OVRI")]
    [IsoId("_WvLzUVCEEe2KGNXAcFL5RA")]
    [Description(@"Oversubscription quantity is invalid.")]
    OversubscriptionQuantityInvalid = InstructionRejectionReasonV2Code.OversubscriptionQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity not used with this transaction type.
    /// Encoded/decoded by serializers as &quot;OVTT&quot;.
    /// </summary>
    [EnumMember(Value = "OVTT")]
    [IsoId("_XCtMQVCEEe2KGNXAcFL5RA")]
    [Description(@"Oversubscription quantity not used with this transaction type.")]
    OversubscriptionQuantityNotUsed = InstructionRejectionReasonV2Code.OversubscriptionQuantityNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is DO chilled.
    /// Encoded/decoded by serializers as &quot;PACH&quot;.
    /// </summary>
    [EnumMember(Value = "PACH")]
    [IsoId("_XY2bYVCEEe2KGNXAcFL5RA")]
    [Description(@"Participant is DO chilled.")]
    ParticipantDOChilled = InstructionRejectionReasonV2Code.ParticipantDOChilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant eligibility check on master table is not available.
    /// Encoded/decoded by serializers as &quot;PAEC&quot;.
    /// </summary>
    [EnumMember(Value = "PAEC")]
    [IsoId("_XluZwVCEEe2KGNXAcFL5RA")]
    [Description(@"Participant eligibility check on master table is not available.")]
    ParticipantEligibilityCheckNotAvailable = InstructionRejectionReasonV2Code.ParticipantEligibilityCheckNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is globally locked.
    /// Encoded/decoded by serializers as &quot;PARL&quot;.
    /// </summary>
    [EnumMember(Value = "PARL")]
    [IsoId("_YBlPUVCEEe2KGNXAcFL5RA")]
    [Description(@"Participant is globally locked.")]
    ParticipantLocked = InstructionRejectionReasonV2Code.ParticipantLocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant does not match the participant on protect identification.
    /// Encoded/decoded by serializers as &quot;PAPI&quot;.
    /// </summary>
    [EnumMember(Value = "PAPI")]
    [IsoId("_YoLVQVCEEe2KGNXAcFL5RA")]
    [Description(@"Participant does not match the participant on protect identification.")]
    ParticipantNoMatchOnProtectIdentification = InstructionRejectionReasonV2Code.ParticipantNoMatchOnProtectIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;PARX&quot;.
    /// </summary>
    [EnumMember(Value = "PARX")]
    [IsoId("_a5OK0VCEEe2KGNXAcFL5RA")]
    [Description(@"Participant is not DTC eligible.")]
    ParticipantNotEligible = InstructionRejectionReasonV2Code.ParticipantNotEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant number is invalid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_bD5w0VCEEe2KGNXAcFL5RA")]
    [Description(@"Participant number is invalid.")]
    ParticipantNumberInvalid = InstructionRejectionReasonV2Code.ParticipantNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Potential loss acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;POLI&quot;.
    /// </summary>
    [EnumMember(Value = "POLI")]
    [IsoId("_ddYwsVCEEe2KGNXAcFL5RA")]
    [Description(@"Potential loss acknowledgement indicator is invalid.")]
    PotentialLossAcknowledgementIndicatorInvalid = InstructionRejectionReasonV2Code.PotentialLossAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Potential loss acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;POLM&quot;.
    /// </summary>
    [EnumMember(Value = "POLM")]
    [IsoId("_dmBvUVCEEe2KGNXAcFL5RA")]
    [Description(@"Potential loss acknowledgement indicator is missing.")]
    PotentialLossAcknowledgementIndicatorMissing = InstructionRejectionReasonV2Code.PotentialLossAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date invalid or missing.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_d_D6YVCEEe2KGNXAcFL5RA")]
    [Description(@"Protect date invalid or missing.")]
    ProtectDateInvalidOrMissing = InstructionRejectionReasonV2Code.ProtectDateInvalidOrMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;PROL&quot;.
    /// </summary>
    [EnumMember(Value = "PROL")]
    [IsoId("_eOju8VCEEe2KGNXAcFL5RA")]
    [Description(@"Protect date must be less than or equal to current date.")]
    ProtectDatePassed = InstructionRejectionReasonV2Code.ProtectDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date on file must be zero.
    /// Encoded/decoded by serializers as &quot;PRO0&quot;.
    /// </summary>
    [EnumMember(Value = "PRO0")]
    [IsoId("_efGsYVCEEe2KGNXAcFL5RA")]
    [Description(@"Protect date on file must be zero.")]
    ProtectDateZero = InstructionRejectionReasonV2Code.ProtectDateZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_euTmAVCEEe2KGNXAcFL5RA")]
    [Description(@"Protect identification is missing or invalid.")]
    ProtectIdentificationMissingOrInvalid = InstructionRejectionReasonV2Code.ProtectIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is not used with this event.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_e3sLgVCEEe2KGNXAcFL5RA")]
    [Description(@"Protect identification is not used with this event.")]
    ProtectIdentificationNotUsed = InstructionRejectionReasonV2Code.ProtectIdentificationNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provided by protect, enter 0 for transaction quantity.
    /// Encoded/decoded by serializers as &quot;TRQP&quot;.
    /// </summary>
    [EnumMember(Value = "TRQP")]
    [IsoId("_fRUzgVCEEe2KGNXAcFL5RA")]
    [Description(@"Provided by protect, enter 0 for transaction quantity.")]
    ProvidedByProtect = InstructionRejectionReasonV2Code.ProvidedByProtect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Record type is invalid.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_fbKE8VCEEe2KGNXAcFL5RA")]
    [Description(@"Record type is invalid.")]
    RecordTypeInvalid = InstructionRejectionReasonV2Code.RecordTypeInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights CUSIP has insufficient position.
    /// Encoded/decoded by serializers as &quot;RILA&quot;.
    /// </summary>
    [EnumMember(Value = "RILA")]
    [IsoId("_gMxvIVCEEe2KGNXAcFL5RA")]
    [Description(@"Rights CUSIP has insufficient position.")]
    RightsCUSIPInsufficientPosition = InstructionRejectionReasonV2Code.RightsCUSIPInsufficientPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not a good return code from rights position check.
    /// Encoded/decoded by serializers as &quot;RPCI&quot;.
    /// </summary>
    [EnumMember(Value = "RPCI")]
    [IsoId("_gbrGwVCEEe2KGNXAcFL5RA")]
    [Description(@"Not a good return code from rights position check.")]
    RightsPositionCheckInvalid = InstructionRejectionReasonV2Code.RightsPositionCheckInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights quantity for this subscription must be divisible by rights.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("_gnmC4VCEEe2KGNXAcFL5RA")]
    [Description(@"Rights quantity for this subscription must be divisible by rights.")]
    RightsQuantityDivisibleByRights = InstructionRejectionReasonV2Code.RightsQuantityDivisibleByRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights quantity is invalid.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("_hAVTAVCEEe2KGNXAcFL5RA")]
    [Description(@"Rights quantity is invalid.")]
    RightsQuantityInvalid = InstructionRejectionReasonV2Code.RightsQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights ratio not found on data base.
    /// Encoded/decoded by serializers as &quot;RTIO&quot;.
    /// </summary>
    [EnumMember(Value = "RTIO")]
    [IsoId("_iCsu8VCEEe2KGNXAcFL5RA")]
    [Description(@"Rights ratio not found on data base.")]
    RightsRatioNotFound = InstructionRejectionReasonV2Code.RightsRatioNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RTS processing is in progress. Submit later.
    /// Encoded/decoded by serializers as &quot;RTSP&quot;.
    /// </summary>
    [EnumMember(Value = "RTSP")]
    [IsoId("_iPOIAVCEEe2KGNXAcFL5RA")]
    [Description(@"RTS processing is in progress. Submit later.")]
    RTSProcessingInProgress = InstructionRejectionReasonV2Code.RTSProcessingInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.
    /// Encoded/decoded by serializers as &quot;SEQP&quot;.
    /// </summary>
    [EnumMember(Value = "SEQP")]
    [IsoId("_ijRscVCEEe2KGNXAcFL5RA")]
    [Description(@"Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.")]
    SequenceNumberInvalidBounds = InstructionRejectionReasonV2Code.SequenceNumberInvalidBounds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sequence number is missing.
    /// Encoded/decoded by serializers as &quot;SEQM&quot;.
    /// </summary>
    [EnumMember(Value = "SEQM")]
    [IsoId("_jB-aoVCEEe2KGNXAcFL5RA")]
    [Description(@"Sequence number is missing.")]
    SequenceNumberMissing = InstructionRejectionReasonV2Code.SequenceNumberMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sequence number is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_jj0jcVCEEe2KGNXAcFL5RA")]
    [Description(@"Sequence number is out of sequence.")]
    SequenceNumberOutOfSync = InstructionRejectionReasonV2Code.SequenceNumberOutOfSync, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Comments are required for solicitation fee.
    /// Encoded/decoded by serializers as &quot;SOCR&quot;.
    /// </summary>
    [EnumMember(Value = "SOCR")]
    [IsoId("_j9luUVCEEe2KGNXAcFL5RA")]
    [Description(@"Comments are required for solicitation fee.")]
    SolicitationFeeCommentsRequired = InstructionRejectionReasonV2Code.SolicitationFeeCommentsRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Solicitation fee indicator is not used with this event.
    /// Encoded/decoded by serializers as &quot;SOLX&quot;.
    /// </summary>
    [EnumMember(Value = "SOLX")]
    [IsoId("_kESzQVCEEe2KGNXAcFL5RA")]
    [Description(@"Solicitation fee indicator is not used with this event.")]
    SolicitationFeeIndicatorNotUsed = InstructionRejectionReasonV2Code.SolicitationFeeIndicatorNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Solicitation fee indicator is required.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("_kMo28VCEEe2KGNXAcFL5RA")]
    [Description(@"Solicitation fee indicator is required.")]
    SolicitationFeeIndicatorRequired = InstructionRejectionReasonV2Code.SolicitationFeeIndicatorRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Submission date is not yet reached.
    /// Encoded/decoded by serializers as &quot;SUBE&quot;.
    /// </summary>
    [EnumMember(Value = "SUBE")]
    [IsoId("_kXNvQVCEEe2KGNXAcFL5RA")]
    [Description(@"Submission date is not yet reached.")]
    SubmissionDateNotReached = InstructionRejectionReasonV2Code.SubmissionDateNotReached, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date of submission has passed.
    /// Encoded/decoded by serializers as &quot;SUBL&quot;.
    /// </summary>
    [EnumMember(Value = "SUBL")]
    [IsoId("_kpqKIVCEEe2KGNXAcFL5RA")]
    [Description(@"Date of submission has passed.")]
    SubmissionDatePassed = InstructionRejectionReasonV2Code.SubmissionDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction identification is invalid.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_kyyQ8VCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction identification is invalid.")]
    TransactionIdentificationInvalid = InstructionRejectionReasonV2Code.TransactionIdentificationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;TRQ0&quot;.
    /// </summary>
    [EnumMember(Value = "TRQ0")]
    [IsoId("_lB-jgVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction quantity cannot be zero.")]
    TransactionQuantityCannotBeZero = InstructionRejectionReasonV2Code.TransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction quantity is less than the transaction minimum.
    /// Encoded/decoded by serializers as &quot;TRQM&quot;.
    /// </summary>
    [EnumMember(Value = "TRQM")]
    [IsoId("_lbnLgVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction quantity is less than the transaction minimum.")]
    TransactionQuantityLessThanTransactionMinimum = InstructionRejectionReasonV2Code.TransactionQuantityLessThanTransactionMinimum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;TRQI&quot;.
    /// </summary>
    [EnumMember(Value = "TRQI")]
    [IsoId("_llJiAVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction quantity is missing or invalid.")]
    TransactionQuantityMissingOrInvalid = InstructionRejectionReasonV2Code.TransactionQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction sequence is invalid. Used only for rights exercise events.
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_l0DgsVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction sequence is invalid. Used only for rights exercise events.")]
    TransactionSequenceInvalid = InstructionRejectionReasonV2Code.TransactionSequenceInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type and event are incompatible.
    /// Encoded/decoded by serializers as &quot;TNFN&quot;.
    /// </summary>
    [EnumMember(Value = "TNFN")]
    [IsoId("_mM43cVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction type and event are incompatible.")]
    TransactionTypeAndEventIncompatible = InstructionRejectionReasonV2Code.TransactionTypeAndEventIncompatible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type or withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_mVINcVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction type or withdrawal transaction type is invalid.")]
    TransactionTypeInvalid = InstructionRejectionReasonV2Code.TransactionTypeInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type is missing.
    /// Encoded/decoded by serializers as &quot;TRNM&quot;.
    /// </summary>
    [EnumMember(Value = "TRNM")]
    [IsoId("_mkoCAVCEEe2KGNXAcFL5RA")]
    [Description(@"Transaction type is missing.")]
    TransactionTypeMissing = InstructionRejectionReasonV2Code.TransactionTypeMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying security CUSIP is invalid.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_pGdsoVCEEe2KGNXAcFL5RA")]
    [Description(@"Underlying security CUSIP is invalid.")]
    UnderlyingSecurityCUSIPInvalid = InstructionRejectionReasonV2Code.UnderlyingSecurityCUSIPInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying security CUSIP does not match the original.
    /// Encoded/decoded by serializers as &quot;CUSU&quot;.
    /// </summary>
    [EnumMember(Value = "CUSU")]
    [IsoId("_pU1f0VCEEe2KGNXAcFL5RA")]
    [Description(@"Underlying security CUSIP does not match the original.")]
    UnderlyingSecurityCUSIPMismatch = InstructionRejectionReasonV2Code.UnderlyingSecurityCUSIPMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying share quantity is invalid.
    /// Encoded/decoded by serializers as &quot;SHQI&quot;.
    /// </summary>
    [EnumMember(Value = "SHQI")]
    [IsoId("_pfWGsVCEEe2KGNXAcFL5RA")]
    [Description(@"Underlying share quantity is invalid.")]
    UnderlyingShareQuantityInvalid = InstructionRejectionReasonV2Code.UnderlyingShareQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying share quantity does not match original share quantity.
    /// Encoded/decoded by serializers as &quot;SHQO&quot;.
    /// </summary>
    [EnumMember(Value = "SHQO")]
    [IsoId("_puOQMVCEEe2KGNXAcFL5RA")]
    [Description(@"Underlying share quantity does not match original share quantity.")]
    UnderlyingShareQuantityMismatch = InstructionRejectionReasonV2Code.UnderlyingShareQuantityMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejection reason is unknown.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_p8_sAVCEEe2KGNXAcFL5RA")]
    [Description(@"Rejection reason is unknown.")]
    UnknownErrorCondition = InstructionRejectionReasonV2Code.UnknownErrorCondition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warrant subscription charge amount is not balancing.
    /// Encoded/decoded by serializers as &quot;WARC&quot;.
    /// </summary>
    [EnumMember(Value = "WARC")]
    [IsoId("_qb2LMVCEEe2KGNXAcFL5RA")]
    [Description(@"Warrant subscription charge amount is not balancing.")]
    WarrantSubscriptionChargeAmountInvalid = InstructionRejectionReasonV2Code.WarrantSubscriptionChargeAmountInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal quantity exceeds the remaining quantity.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_qpQVEVCEEe2KGNXAcFL5RA")]
    [Description(@"Withdrawal quantity exceeds the remaining quantity.")]
    WithdrawalQuantityExceedsRemainingQuantity = InstructionRejectionReasonV2Code.WithdrawalQuantityExceedsRemainingQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal quantity is greater than VOI/protect quantity.
    /// Encoded/decoded by serializers as &quot;WITG&quot;.
    /// </summary>
    [EnumMember(Value = "WITG")]
    [IsoId("_qzGNkVCEEe2KGNXAcFL5RA")]
    [Description(@"Withdrawal quantity is greater than VOI/protect quantity.")]
    WithdrawalQuantityGreaterThanProtectQuantity = InstructionRejectionReasonV2Code.WithdrawalQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;WIT0&quot;.
    /// </summary>
    [EnumMember(Value = "WIT0")]
    [IsoId("_rBZIQVCEEe2KGNXAcFL5RA")]
    [Description(@"Withdrawal transaction quantity cannot be zero.")]
    WithdrawalTransactionQuantityCannotBeZero = InstructionRejectionReasonV2Code.WithdrawalTransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;WITI&quot;.
    /// </summary>
    [EnumMember(Value = "WITI")]
    [IsoId("_rkJ3EVCEEe2KGNXAcFL5RA")]
    [Description(@"Withdrawal transaction type is invalid.")]
    WithdrawalTransactionTypeInvalid = InstructionRejectionReasonV2Code.WithdrawalTransactionTypeInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error in withdraw occurred.
    /// Encoded/decoded by serializers as &quot;WITE&quot;.
    /// </summary>
    [EnumMember(Value = "WITE")]
    [IsoId("_rznPYVCEEe2KGNXAcFL5RA")]
    [Description(@"Error in withdraw occurred.")]
    WithdrawError = InstructionRejectionReasonV2Code.WithdrawError, // same ordinal as derivation source for type conversions
    
}
