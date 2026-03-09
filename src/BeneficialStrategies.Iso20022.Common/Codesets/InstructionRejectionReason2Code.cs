// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_53kiUACpEeqouY-yI_q3qQ")]
[Description(@"Reason for rejection of a corporate action instruction or of an instruction cancellation.")]
[DerivedFrom(typeof(InstructionRejectionReasonCode))]
public enum InstructionRejectionReason2Code
{
    /// <summary>
    /// Acknowledgement must be agreed.
    /// Encoded/decoded by serializers as &quot;ACKA&quot;.
    /// </summary>
    [EnumMember(Value = "ACKA")]
    [IsoId("_8BRZwQCpEeqouY-yI_q3qQ")]
    [Description(@"Acknowledgement must be agreed.")]
    AcknowledgementNotAgreed = InstructionRejectionReasonCode.AcknowledgementNotAgreed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgment indicator is missing.
    /// Encoded/decoded by serializers as &quot;ACKS&quot;.
    /// </summary>
    [EnumMember(Value = "ACKS")]
    [IsoId("_8FFiwQCpEeqouY-yI_q3qQ")]
    [Description(@"Acknowledgment indicator is missing.")]
    AcknowledgmentIndicatorMissing = InstructionRejectionReasonCode.AcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;ADIN&quot;.
    /// </summary>
    [EnumMember(Value = "ADIN")]
    [IsoId("_8I_yYQCpEeqouY-yI_q3qQ")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is invalid.")]
    AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid = InstructionRejectionReasonCode.AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficial owner death date is missing.
    /// Encoded/decoded by serializers as &quot;BODD&quot;.
    /// </summary>
    [EnumMember(Value = "BODD")]
    [IsoId("_8P0zIQCpEeqouY-yI_q3qQ")]
    [Description(@"Beneficial owner death date is missing.")]
    BeneficialOwnerDeathDateMissing = InstructionRejectionReasonCode.BeneficialOwnerDeathDateMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("_8fME0QCpEeqouY-yI_q3qQ")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is missing.")]
    AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing = InstructionRejectionReasonCode.AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficial owner name is missing.
    /// Encoded/decoded by serializers as &quot;BONM&quot;.
    /// </summary>
    [EnumMember(Value = "BONM")]
    [IsoId("_8nly4QCpEeqouY-yI_q3qQ")]
    [Description(@"Beneficial owner name is missing.")]
    BeneficialOwnerNameMissing = InstructionRejectionReasonCode.BeneficialOwnerNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid price is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_8rZ74QCpEeqouY-yI_q3qQ")]
    [Description(@"Bid price is missing or invalid.")]
    BidPriceMissingOrInvalid = InstructionRejectionReasonCode.BidPriceMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid Price cannot be greater than 9999.99999.
    /// Encoded/decoded by serializers as &quot;BIDG&quot;.
    /// </summary>
    [EnumMember(Value = "BIDG")]
    [IsoId("_8u7J8QCpEeqouY-yI_q3qQ")]
    [Description(@"Bid Price cannot be greater than 9999.99999.")]
    BidPriceOverflow = InstructionRejectionReasonCode.BidPriceOverflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid Price is less than the minimum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDM&quot;.
    /// </summary>
    [EnumMember(Value = "BIDM")]
    [IsoId("_8ydmIQCpEeqouY-yI_q3qQ")]
    [Description(@"Bid Price is less than the minimum bid price allowed for the offer.")]
    BidPriceUnderMinimumAllowed = InstructionRejectionReasonCode.BidPriceUnderMinimumAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bid Price exceeds maximum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_856R8QCpEeqouY-yI_q3qQ")]
    [Description(@"Bid Price exceeds maximum bid price allowed for the offer.")]
    BidPriceOverMaximumAllowed = InstructionRejectionReasonCode.BidPriceOverMaximumAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Zeroes are required for bid price.
    /// Encoded/decoded by serializers as &quot;BID0&quot;.
    /// </summary>
    [EnumMember(Value = "BID0")]
    [IsoId("_9BoDgQCpEeqouY-yI_q3qQ")]
    [Description(@"Zeroes are required for bid price.")]
    BidPriceZeroesRequired = InstructionRejectionReasonCode.BidPriceZeroesRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bond check on master table is not available.
    /// Encoded/decoded by serializers as &quot;BNDU&quot;.
    /// </summary>
    [EnumMember(Value = "BNDU")]
    [IsoId("_9F1OEQCpEeqouY-yI_q3qQ")]
    [Description(@"Bond check on master table is not available.")]
    BondCheckOnMasterTableNotAvailable = InstructionRejectionReasonCode.BondCheckOnMasterTableNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number is missing.
    /// Encoded/decoded by serializers as &quot;CENM&quot;.
    /// </summary>
    [EnumMember(Value = "CENM")]
    [IsoId("_9JyhAQCpEeqouY-yI_q3qQ")]
    [Description(@"Certificate number is missing.")]
    CertificateNameMissing = InstructionRejectionReasonCode.CertificateNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number is invalid.
    /// Encoded/decoded by serializers as &quot;CERN&quot;.
    /// </summary>
    [EnumMember(Value = "CERN")]
    [IsoId("_9NKlIQCpEeqouY-yI_q3qQ")]
    [Description(@"Certificate number is invalid.")]
    CertificateNumberInvalid = InstructionRejectionReasonCode.CertificateNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate sequence number is invalid.
    /// Encoded/decoded by serializers as &quot;CERS&quot;.
    /// </summary>
    [EnumMember(Value = "CERS")]
    [IsoId("_9Rg5oQCpEeqouY-yI_q3qQ")]
    [Description(@"Certificate sequence number is invalid.")]
    CertificateSequenceNumberInvalid = InstructionRejectionReasonCode.CertificateSequenceNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Comment area is invalid.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_9VVCoQCpEeqouY-yI_q3qQ")]
    [Description(@"Comment area is invalid.")]
    CommentAreaInvalid = InstructionRejectionReasonCode.CommentAreaInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN1N&quot;.
    /// </summary>
    [EnumMember(Value = "CN1N")]
    [IsoId("_9ZPSQQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 1 indicator is invalid. It must be No.")]
    Condition1InvalidMustBeNo = InstructionRejectionReasonCode.Condition1InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN1Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN1Y")]
    [IsoId("_9dJh4QCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 1 indicator is invalid. It must be Yes.")]
    Condition1InvalidMustBeYes = InstructionRejectionReasonCode.Condition1InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 1 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN1R&quot;.
    /// </summary>
    [EnumMember(Value = "CN1R")]
    [IsoId("_9gvBYQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 1 indicator is must be present.")]
    Condition1Required = InstructionRejectionReasonCode.Condition1Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN2N&quot;.
    /// </summary>
    [EnumMember(Value = "CN2N")]
    [IsoId("_9ks7YQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 2 indicator is invalid. It must be No.")]
    Condition2InvalidMustBeNo = InstructionRejectionReasonCode.Condition2InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN2Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN2Y")]
    [IsoId("_9u2V4QCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 2 indicator is invalid. It must be Yes.")]
    Condition2InvalidMustBeYes = InstructionRejectionReasonCode.Condition2InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 2 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN2R&quot;.
    /// </summary>
    [EnumMember(Value = "CN2R")]
    [IsoId("_9yKvoQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 2 indicator is must be present.")]
    Condition2Required = InstructionRejectionReasonCode.Condition2Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN3N&quot;.
    /// </summary>
    [EnumMember(Value = "CN3N")]
    [IsoId("_92LF4QCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 3 indicator is invalid. It must be No.")]
    Condition3InvalidMustBeNo = InstructionRejectionReasonCode.Condition3InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN3Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN3Y")]
    [IsoId("_95YK4QCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 3 indicator is invalid. It must be Yes.")]
    Condition3InvalidMustBeYes = InstructionRejectionReasonCode.Condition3InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 3 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN3R&quot;.
    /// </summary>
    [EnumMember(Value = "CN3R")]
    [IsoId("_-SqNkQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 3 indicator is must be present.")]
    Condition3Required = InstructionRejectionReasonCode.Condition3Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN4N&quot;.
    /// </summary>
    [EnumMember(Value = "CN4N")]
    [IsoId("_-WDf0QCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 4 indicator is invalid. It must be No.")]
    Condition4InvalidMustBeNo = InstructionRejectionReasonCode.Condition4InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN4Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN4Y")]
    [IsoId("_-ZhDgQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 4 indicator is invalid. It must be Yes.")]
    Condition4InvalidMustBeYes = InstructionRejectionReasonCode.Condition4InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 4 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN4R&quot;.
    /// </summary>
    [EnumMember(Value = "CN4R")]
    [IsoId("_-ciiUQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 4 indicator is must be present.")]
    Condition4Required = InstructionRejectionReasonCode.Condition4Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN5N&quot;.
    /// </summary>
    [EnumMember(Value = "CN5N")]
    [IsoId("_-fCcsQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 5 indicator is invalid. It must be No.")]
    Condition5InvalidMustBeNo = InstructionRejectionReasonCode.Condition5InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN5Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN5Y")]
    [IsoId("_-h48YQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 5 indicator is invalid. It must be Yes.")]
    Condition5InvalidMustBeYes = InstructionRejectionReasonCode.Condition5InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 5 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN5R&quot;.
    /// </summary>
    [EnumMember(Value = "CN5R")]
    [IsoId("_-kLbYQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 5 indicator is must be present.")]
    Condition5Required = InstructionRejectionReasonCode.Condition5Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN6N&quot;.
    /// </summary>
    [EnumMember(Value = "CN6N")]
    [IsoId("_-m9poQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 6 indicator is invalid. It must be No.")]
    Condition6InvalidMustBeNo = InstructionRejectionReasonCode.Condition6InvalidMustBeNo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN6Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN6Y")]
    [IsoId("_-pZSkQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 6 indicator is invalid. It must be Yes.")]
    Condition6InvalidMustBeYes = InstructionRejectionReasonCode.Condition6InvalidMustBeYes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;COQX&quot;.
    /// </summary>
    [EnumMember(Value = "COQX")]
    [IsoId("_-60ZwQCpEeqouY-yI_q3qQ")]
    [Description(@"Conditional quantity cannot be zero.")]
    ConditionalQuantityCannotBeZero = InstructionRejectionReasonCode.ConditionalQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Condition 6 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN6R&quot;.
    /// </summary>
    [EnumMember(Value = "CN6R")]
    [IsoId("_--EiEQCpEeqouY-yI_q3qQ")]
    [Description(@"Condition 6 indicator is must be present.")]
    Condition6Required = InstructionRejectionReasonCode.Condition6Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity.
    /// Encoded/decoded by serializers as &quot;COTQ&quot;.
    /// </summary>
    [EnumMember(Value = "COTQ")]
    [IsoId("__EZMgQCpEeqouY-yI_q3qQ")]
    [Description(@"Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity.")]
    ConditionalQuantityDoesNotEqualTransactionQuantity = InstructionRejectionReasonCode.ConditionalQuantityDoesNotEqualTransactionQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity exceeds the transaction quantity.
    /// Encoded/decoded by serializers as &quot;COQE&quot;.
    /// </summary>
    [EnumMember(Value = "COQE")]
    [IsoId("__HVLwQCpEeqouY-yI_q3qQ")]
    [Description(@"Conditional quantity exceeds the transaction quantity.")]
    ConditionalQuantityExceedsTransactionQuantity = InstructionRejectionReasonCode.ConditionalQuantityExceedsTransactionQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity zeroes are required.
    /// Encoded/decoded by serializers as &quot;COQ0&quot;.
    /// </summary>
    [EnumMember(Value = "COQ0")]
    [IsoId("__PqBUQCpEeqouY-yI_q3qQ")]
    [Description(@"Conditional quantity zeroes are required.")]
    ConditionalQuantityZeroesRequired = InstructionRejectionReasonCode.ConditionalQuantityZeroesRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact name is missing.
    /// Encoded/decoded by serializers as &quot;CNAM&quot;.
    /// </summary>
    [EnumMember(Value = "CNAM")]
    [IsoId("__SghAQCpEeqouY-yI_q3qQ")]
    [Description(@"Contact name is missing.")]
    ContactNameMissing = InstructionRejectionReasonCode.ContactNameMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact name is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNAX&quot;.
    /// </summary>
    [EnumMember(Value = "CNAX")]
    [IsoId("__VKzcQCpEeqouY-yI_q3qQ")]
    [Description(@"Contact name is not used with this event.")]
    ContactNameNotUsedWithEvent = InstructionRejectionReasonCode.ContactNameNotUsedWithEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact phone number is missing.
    /// Encoded/decoded by serializers as &quot;CNPM&quot;.
    /// </summary>
    [EnumMember(Value = "CNPM")]
    [IsoId("__YP8oQCpEeqouY-yI_q3qQ")]
    [Description(@"Contact phone number is missing.")]
    ContactPhoneNumberMissing = InstructionRejectionReasonCode.ContactPhoneNumberMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact phone number is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNPX&quot;.
    /// </summary>
    [EnumMember(Value = "CNPX")]
    [IsoId("__bCK4QCpEeqouY-yI_q3qQ")]
    [Description(@"Contact phone number is not used with this event.")]
    ContactPhoneNumberNotUsedWithEvent = InstructionRejectionReasonCode.ContactPhoneNumberNotUsedWithEvent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is summary difference between core oversubscription quantity and extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUMO&quot;.
    /// </summary>
    [EnumMember(Value = "SUMO")]
    [IsoId("__d2OUQCpEeqouY-yI_q3qQ")]
    [Description(@"There is summary difference between core oversubscription quantity and extension transaction details.")]
    CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference = InstructionRejectionReasonCode.CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is a summary difference between the core instruction quantity and the extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUME&quot;.
    /// </summary>
    [EnumMember(Value = "SUME")]
    [IsoId("__gn1gQCpEeqouY-yI_q3qQ")]
    [Description(@"There is a summary difference between the core instruction quantity and the extension transaction details.")]
    CoreInstructionQuantityAndExtensionTransactionDetailsDifference = InstructionRejectionReasonCode.CoreInstructionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate action event identification is invalid.
    /// Encoded/decoded by serializers as &quot;CAID&quot;.
    /// </summary>
    [EnumMember(Value = "CAID")]
    [IsoId("__jMoYQCpEeqouY-yI_q3qQ")]
    [Description(@"Corporate action event identification is invalid.")]
    CorporateActionEventInvalid = InstructionRejectionReasonCode.CorporateActionEventInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cover quantity is greater than the remaining protect quantity.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("__nn1YQCpEeqouY-yI_q3qQ")]
    [Description(@"Cover quantity is greater than the remaining protect quantity.")]
    CoverQuantityGreaterThanProtectQuantity = InstructionRejectionReasonCode.CoverQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conditional quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;COQI&quot;.
    /// </summary>
    [EnumMember(Value = "COQI")]
    [IsoId("__v6OsQCpEeqouY-yI_q3qQ")]
    [Description(@"Conditional quantity is missing or invalid.")]
    ConditionalQuantityMissingOrInvalid = InstructionRejectionReasonCode.ConditionalQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current date is greater than protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROE&quot;.
    /// </summary>
    [EnumMember(Value = "PROE")]
    [IsoId("_ASMcYQCqEeqouY-yI_q3qQ")]
    [Description(@"Current date is greater than protect submission end date.")]
    CurrentDatePassedProtectSubmissionEndDate = InstructionRejectionReasonCode.CurrentDatePassedProtectSubmissionEndDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current date is less than protect submission start date.
    /// Encoded/decoded by serializers as &quot;PROS&quot;.
    /// </summary>
    [EnumMember(Value = "PROS")]
    [IsoId("_AVb9oQCqEeqouY-yI_q3qQ")]
    [Description(@"Current date is less than protect submission start date.")]
    CurrentDatePrecedesProtectSubmissionStartDate = InstructionRejectionReasonCode.CurrentDatePrecedesProtectSubmissionStartDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CUSIP is depository deliver chilled.
    /// Encoded/decoded by serializers as &quot;CHIL&quot;.
    /// </summary>
    [EnumMember(Value = "CHIL")]
    [IsoId("_AYc1YQCqEeqouY-yI_q3qQ")]
    [Description(@"CUSIP is depository deliver chilled.")]
    CUSIPDepositoryDeliverChilled = InstructionRejectionReasonCode.CUSIPDepositoryDeliverChilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Target CUSIP or contra CUSIP identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUSI&quot;.
    /// </summary>
    [EnumMember(Value = "CUSI")]
    [IsoId("_AbneIQCqEeqouY-yI_q3qQ")]
    [Description(@"Target CUSIP or contra CUSIP identification is missing or invalid.")]
    CUSIPMissingOrInvalid = InstructionRejectionReasonCode.CUSIPMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Target CUSIP or contra CUSIP identification is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;CUSD&quot;.
    /// </summary>
    [EnumMember(Value = "CUSD")]
    [IsoId("_AeZsYQCqEeqouY-yI_q3qQ")]
    [Description(@"Target CUSIP or contra CUSIP identification is not DTC eligible.")]
    CUSIPNotDTCEligible = InstructionRejectionReasonCode.CUSIPNotDTCEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer oversubscription quantities do not add up to total oversubscription quantity.
    /// Encoded/decoded by serializers as &quot;OVCU&quot;.
    /// </summary>
    [EnumMember(Value = "OVCU")]
    [IsoId("_Ag5mwQCqEeqouY-yI_q3qQ")]
    [Description(@"Customer oversubscription quantities do not add up to total oversubscription quantity.")]
    CustomerAndTotalOversubscriptionQuantitiesMismatch = InstructionRejectionReasonCode.CustomerAndTotalOversubscriptionQuantitiesMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_AjZhIQCqEeqouY-yI_q3qQ")]
    [Description(@"Customer identification is missing or invalid.")]
    CustomerIdentificationMissingOrInvalid = InstructionRejectionReasonCode.CustomerIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer quantities do not add up to total rights quantities.
    /// Encoded/decoded by serializers as &quot;CQRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CQRQ")]
    [IsoId("_AmDMgQCqEeqouY-yI_q3qQ")]
    [Description(@"Customer quantities do not add up to total rights quantities.")]
    CustomerQuantitiesAndTotalRightsQuantitiesMismatch = InstructionRejectionReasonCode.CustomerQuantitiesAndTotalRightsQuantitiesMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer Reference Identification must be populated for each sequence.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_AoZV4QCqEeqouY-yI_q3qQ")]
    [Description(@"Customer Reference Identification must be populated for each sequence.")]
    CustomerReferenceIdentificationMissingInSequence = InstructionRejectionReasonCode.CustomerReferenceIdentificationMissingInSequence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer Sequence number must be all zero.
    /// Encoded/decoded by serializers as &quot;SEQ0&quot;.
    /// </summary>
    [EnumMember(Value = "SEQ0")]
    [IsoId("_AqYS4QCqEeqouY-yI_q3qQ")]
    [Description(@"Customer Sequence number must be all zero.")]
    CustomerSequenceNumberAllZero = InstructionRejectionReasonCode.CustomerSequenceNumberAllZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer Sequence number is invalid or out of sequence.
    /// Encoded/decoded by serializers as &quot;CSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSEQ")]
    [IsoId("_Auf94QCqEeqouY-yI_q3qQ")]
    [Description(@"Customer Sequence number is invalid or out of sequence.")]
    CustomerSequenceNumberInvalid = InstructionRejectionReasonCode.CustomerSequenceNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off time check has failed.
    /// Encoded/decoded by serializers as &quot;CUTC&quot;.
    /// </summary>
    [EnumMember(Value = "CUTC")]
    [IsoId("_A1WMwQCqEeqouY-yI_q3qQ")]
    [Description(@"Cut-off time check has failed.")]
    CutoffTimeCheckFailed = InstructionRejectionReasonCode.CutoffTimeCheckFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Death certificate details are missing.
    /// Encoded/decoded by serializers as &quot;BODC&quot;.
    /// </summary>
    [EnumMember(Value = "BODC")]
    [IsoId("_A31gEQCqEeqouY-yI_q3qQ")]
    [Description(@"Death certificate details are missing.")]
    DeathCertificateMissing = InstructionRejectionReasonCode.DeathCertificateMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry Date is invalid.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_A__9kQCqEeqouY-yI_q3qQ")]
    [Description(@"Entry Date is invalid.")]
    EntryDateInvalid = InstructionRejectionReasonCode.EntryDateInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer has fractional underlying quantity, adjust quantity.
    /// Encoded/decoded by serializers as &quot;FRAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FRAQ")]
    [IsoId("_BH8YoQCqEeqouY-yI_q3qQ")]
    [Description(@"Customer has fractional underlying quantity, adjust quantity.")]
    FractionalUnderlyingQuantity = InstructionRejectionReasonCode.FractionalUnderlyingQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Function is not available at this time. Please check expiration start and end times for the event.
    /// Encoded/decoded by serializers as &quot;FUNU&quot;.
    /// </summary>
    [EnumMember(Value = "FUNU")]
    [IsoId("_BKFGoQCqEeqouY-yI_q3qQ")]
    [Description(@"Function is not available at this time. Please check expiration start and end times for the event.")]
    FunctionNotAvailable = InstructionRejectionReasonCode.FunctionNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Function is quiesced (not available).
    /// Encoded/decoded by serializers as &quot;QUIE&quot;.
    /// </summary>
    [EnumMember(Value = "QUIE")]
    [IsoId("_BNBF4QCqEeqouY-yI_q3qQ")]
    [Description(@"Function is quiesced (not available).")]
    FunctionQuiesced = InstructionRejectionReasonCode.FunctionQuiesced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction deletion acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_BQGPEQCqEeqouY-yI_q3qQ")]
    [Description(@"Instruction deletion acknowledgement indicator is invalid.")]
    InstructionDeletionAcknowledgementIndicatorInvalid = InstructionRejectionReasonCode.InstructionDeletionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant has insufficient position.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_BaQ3sQCqEeqouY-yI_q3qQ")]
    [Description(@"Participant has insufficient position.")]
    InsufficientPosition = InstructionRejectionReasonCode.InsufficientPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction deletion acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_Bei6wQCqEeqouY-yI_q3qQ")]
    [Description(@"Instruction deletion acknowledgement indicator is missing.")]
    InstructionDeletionAcknowledgementIndicatorMissing = InstructionRejectionReasonCode.InstructionDeletionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_Bn7gQQCqEeqouY-yI_q3qQ")]
    [Description(@"Entry date must be less than or equal to current date.")]
    EntryDatePassed = InstructionRejectionReasonCode.EntryDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction sequence number is duplicated.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_Bst5oQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction sequence number is duplicated.")]
    DuplicateTransactionSequenceNumber = InstructionRejectionReasonCode.DuplicateTransactionSequenceNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off time has passed.
    /// Encoded/decoded by serializers as &quot;CUTT&quot;.
    /// </summary>
    [EnumMember(Value = "CUTT")]
    [IsoId("_BxRpgQCqEeqouY-yI_q3qQ")]
    [Description(@"Cut-off time has passed.")]
    CutoffTimePassed = InstructionRejectionReasonCode.CutoffTimePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuing jurisdiction is missing.
    /// Encoded/decoded by serializers as &quot;BOIJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOIJ")]
    [IsoId("_CdfPQQCqEeqouY-yI_q3qQ")]
    [Description(@"Issuing jurisdiction is missing.")]
    IssuingJurisdictionMissing = InstructionRejectionReasonCode.IssuingJurisdictionMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key data (VOI transaction) cannot be found.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_CgbOgQCqEeqouY-yI_q3qQ")]
    [Description(@"Key data (VOI transaction) cannot be found.")]
    KayDataNotFound = InstructionRejectionReasonCode.KayDataNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;LEGI&quot;.
    /// </summary>
    [EnumMember(Value = "LEGI")]
    [IsoId("_CjSVQQCqEeqouY-yI_q3qQ")]
    [Description(@"Legal documentation thirty months retention acknowledgement indicator is invalid.")]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid = InstructionRejectionReasonCode.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Master tables are not available.
    /// Encoded/decoded by serializers as &quot;MSTB&quot;.
    /// </summary>
    [EnumMember(Value = "MSTB")]
    [IsoId("_CmBgMQCqEeqouY-yI_q3qQ")]
    [Description(@"Master tables are not available.")]
    MasterTablesNotAvailable = InstructionRejectionReasonCode.MasterTablesNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is no withdrawal privilege on this offer.
    /// Encoded/decoded by serializers as &quot;NWIT&quot;.
    /// </summary>
    [EnumMember(Value = "NWIT")]
    [IsoId("_CoygUQCqEeqouY-yI_q3qQ")]
    [Description(@"There is no withdrawal privilege on this offer.")]
    NoWithdrawalPrivilege = InstructionRejectionReasonCode.NoWithdrawalPrivilege, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Odd lot indicator is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ODLI&quot;.
    /// </summary>
    [EnumMember(Value = "ODLI")]
    [IsoId("_CrmjwQCqEeqouY-yI_q3qQ")]
    [Description(@"Odd lot indicator is missing or invalid.")]
    OddLotIndicatorMissingOrInvalid = InstructionRejectionReasonCode.OddLotIndicatorMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cannot submit odd lot indicator &apos;Yes&apos; for the offer.
    /// Encoded/decoded by serializers as &quot;ODLY&quot;.
    /// </summary>
    [EnumMember(Value = "ODLY")]
    [IsoId("_CudqgQCqEeqouY-yI_q3qQ")]
    [Description(@"Cannot submit odd lot indicator 'Yes' for the offer.")]
    OddLotIndicatorYesInvalid = InstructionRejectionReasonCode.OddLotIndicatorYesInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is not ATOP eligible.
    /// Encoded/decoded by serializers as &quot;ATOP&quot;.
    /// </summary>
    [EnumMember(Value = "ATOP")]
    [IsoId("_CxMOYQCqEeqouY-yI_q3qQ")]
    [Description(@"Offer is not ATOP eligible.")]
    OfferNotATOPEligible = InstructionRejectionReasonCode.OfferNotATOPEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is not eligible for the PUTS function.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_C0EjQQCqEeqouY-yI_q3qQ")]
    [Description(@"Offer is not eligible for the PUTS function.")]
    OfferNotEligibleForPuts = InstructionRejectionReasonCode.OfferNotEligibleForPuts, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity is greater than percentage of underlying shares.
    /// Encoded/decoded by serializers as &quot;OVRG&quot;.
    /// </summary>
    [EnumMember(Value = "OVRG")]
    [IsoId("_C4izkQCqEeqouY-yI_q3qQ")]
    [Description(@"Oversubscription quantity is greater than percentage of underlying shares.")]
    OversubscriptionQuantityExceeded = InstructionRejectionReasonCode.OversubscriptionQuantityExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity is invalid.
    /// Encoded/decoded by serializers as &quot;OVRI&quot;.
    /// </summary>
    [EnumMember(Value = "OVRI")]
    [IsoId("_DCZ6MQCqEeqouY-yI_q3qQ")]
    [Description(@"Oversubscription quantity is invalid.")]
    OversubscriptionQuantityInvalid = InstructionRejectionReasonCode.OversubscriptionQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant eligibility check on master table is not available.
    /// Encoded/decoded by serializers as &quot;PAEC&quot;.
    /// </summary>
    [EnumMember(Value = "PAEC")]
    [IsoId("_DHZH4QCqEeqouY-yI_q3qQ")]
    [Description(@"Participant eligibility check on master table is not available.")]
    ParticipantEligibilityCheckNotAvailable = InstructionRejectionReasonCode.ParticipantEligibilityCheckNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is globally locked.
    /// Encoded/decoded by serializers as &quot;PARL&quot;.
    /// </summary>
    [EnumMember(Value = "PARL")]
    [IsoId("_DJYE4QCqEeqouY-yI_q3qQ")]
    [Description(@"Participant is globally locked.")]
    ParticipantLocked = InstructionRejectionReasonCode.ParticipantLocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant does not match participant on Protect ID.
    /// Encoded/decoded by serializers as &quot;PAPI&quot;.
    /// </summary>
    [EnumMember(Value = "PAPI")]
    [IsoId("_DMHP0ACqEeqouY-yI_q3qQ")]
    [Description(@"Participant does not match participant on Protect ID.")]
    ParticipantNoMatchOnProtectIdentification = InstructionRejectionReasonCode.ParticipantNoMatchOnProtectIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;PARX&quot;.
    /// </summary>
    [EnumMember(Value = "PARX")]
    [IsoId("_DOnKMQCqEeqouY-yI_q3qQ")]
    [Description(@"Participant is not DTC eligible.")]
    ParticipantNotEligible = InstructionRejectionReasonCode.ParticipantNotEligible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant number is invalid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_DQ0JoQCqEeqouY-yI_q3qQ")]
    [Description(@"Participant number is invalid.")]
    ParticipantNumberInvalid = InstructionRejectionReasonCode.ParticipantNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Current date has passed cover protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_DTwv8QCqEeqouY-yI_q3qQ")]
    [Description(@"Current date has passed cover protect submission end date.")]
    PassedProtectSubmissionEndDate = InstructionRejectionReasonCode.PassedProtectSubmissionEndDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription quantity not used with this transaction type.
    /// Encoded/decoded by serializers as &quot;OVTT&quot;.
    /// </summary>
    [EnumMember(Value = "OVTT")]
    [IsoId("_DiiLwQCqEeqouY-yI_q3qQ")]
    [Description(@"Oversubscription quantity not used with this transaction type.")]
    OversubscriptionQuantityNotUsed = InstructionRejectionReasonCode.OversubscriptionQuantityNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant is DO chilled.
    /// Encoded/decoded by serializers as &quot;PACH&quot;.
    /// </summary>
    [EnumMember(Value = "PACH")]
    [IsoId("_DninkQCqEeqouY-yI_q3qQ")]
    [Description(@"Participant is DO chilled.")]
    ParticipantDOChilled = InstructionRejectionReasonCode.ParticipantDOChilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Oversubscription is not allowed.
    /// Encoded/decoded by serializers as &quot;OVRX&quot;.
    /// </summary>
    [EnumMember(Value = "OVRX")]
    [IsoId("_Dw9pUQCqEeqouY-yI_q3qQ")]
    [Description(@"Oversubscription is not allowed.")]
    OversubscriptionNotAllowed = InstructionRejectionReasonCode.OversubscriptionNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is already on historical data base.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_D3RFoQCqEeqouY-yI_q3qQ")]
    [Description(@"Offer is already on historical data base.")]
    OfferInDatabase = InstructionRejectionReasonCode.OfferInDatabase, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal documentation thirty Months retention acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;LEGM&quot;.
    /// </summary>
    [EnumMember(Value = "LEGM")]
    [IsoId("_EBNEwQCqEeqouY-yI_q3qQ")]
    [Description(@"Legal documentation thirty Months retention acknowledgement indicator is missing.")]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing = InstructionRejectionReasonCode.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key Information is missing (tenders data).
    /// Encoded/decoded by serializers as &quot;KEYM&quot;.
    /// </summary>
    [EnumMember(Value = "KEYM")]
    [IsoId("_EJ9YIQCqEeqouY-yI_q3qQ")]
    [Description(@"Key Information is missing (tenders data).")]
    KeyInformationMissing = InstructionRejectionReasonCode.KeyInformationMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Potential loss acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;POLI&quot;.
    /// </summary>
    [EnumMember(Value = "POLI")]
    [IsoId("_EsvVEQCqEeqouY-yI_q3qQ")]
    [Description(@"Potential loss acknowledgement indicator is invalid.")]
    PotentiaLossAcknowledgementIndicatorInvalid = InstructionRejectionReasonCode.PotentiaLossAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Potential loss acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;POLM&quot;.
    /// </summary>
    [EnumMember(Value = "POLM")]
    [IsoId("_EvtJgQCqEeqouY-yI_q3qQ")]
    [Description(@"Potential loss acknowledgement indicator is missing.")]
    PotentiaLossAcknowledgementIndicatorMissing = InstructionRejectionReasonCode.PotentiaLossAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect Date invalid or missing.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_EyeJoQCqEeqouY-yI_q3qQ")]
    [Description(@"Protect Date invalid or missing.")]
    ProtectDateInvalidOrMissing = InstructionRejectionReasonCode.ProtectDateInvalidOrMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_E781wQCqEeqouY-yI_q3qQ")]
    [Description(@"Protect identification is missing or invalid.")]
    ProtectIdentificationMissingOrInvalid = InstructionRejectionReasonCode.ProtectIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect identification is not used with this event.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_E-hooQCqEeqouY-yI_q3qQ")]
    [Description(@"Protect identification is not used with this event.")]
    ProtectIdentificationNotUsed = InstructionRejectionReasonCode.ProtectIdentificationNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provided by protect, enter 0 for transaction quantity.
    /// Encoded/decoded by serializers as &quot;TRQP&quot;.
    /// </summary>
    [EnumMember(Value = "TRQP")]
    [IsoId("_FA8qgQCqEeqouY-yI_q3qQ")]
    [Description(@"Provided by protect, enter 0 for transaction quantity.")]
    ProvidedByProtect = InstructionRejectionReasonCode.ProvidedByProtect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Record type is invalid.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_FDmV4QCqEeqouY-yI_q3qQ")]
    [Description(@"Record type is invalid.")]
    RecordTypeInvalid = InstructionRejectionReasonCode.RecordTypeInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights CUSIP has insufficient position.
    /// Encoded/decoded by serializers as &quot;RILA&quot;.
    /// </summary>
    [EnumMember(Value = "RILA")]
    [IsoId("_FGVg0QCqEeqouY-yI_q3qQ")]
    [Description(@"Rights CUSIP has insufficient position.")]
    RightsCUSIPInsufficientPosition = InstructionRejectionReasonCode.RightsCUSIPInsufficientPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not a good return code from rights position check.
    /// Encoded/decoded by serializers as &quot;RPCI&quot;.
    /// </summary>
    [EnumMember(Value = "RPCI")]
    [IsoId("_FJRgEQCqEeqouY-yI_q3qQ")]
    [Description(@"Not a good return code from rights position check.")]
    RightsPositionCheckInvalid = InstructionRejectionReasonCode.RightsPositionCheckInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights quantity for this subscription must be divisible by rights.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("_FL2S8QCqEeqouY-yI_q3qQ")]
    [Description(@"Rights quantity for this subscription must be divisible by rights.")]
    RightsQuantityDivisibleByRights = InstructionRejectionReasonCode.RightsQuantityDivisibleByRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights quantity is invalid.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("_FOuAwQCqEeqouY-yI_q3qQ")]
    [Description(@"Rights quantity is invalid.")]
    RightsQuantityInvalid = InstructionRejectionReasonCode.RightsQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rights ratio not found on data base.
    /// Encoded/decoded by serializers as &quot;RTIO&quot;.
    /// </summary>
    [EnumMember(Value = "RTIO")]
    [IsoId("_FV6N4QCqEeqouY-yI_q3qQ")]
    [Description(@"Rights ratio not found on data base.")]
    RightsRatioNotFound = InstructionRejectionReasonCode.RightsRatioNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RTS processing is in progress. Submit later.
    /// Encoded/decoded by serializers as &quot;RTSP&quot;.
    /// </summary>
    [EnumMember(Value = "RTSP")]
    [IsoId("_FY3bQQCqEeqouY-yI_q3qQ")]
    [Description(@"RTS processing is in progress. Submit later.")]
    RTSProcessingInProgress = InstructionRejectionReasonCode.RTSProcessingInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.
    /// Encoded/decoded by serializers as &quot;SEQP&quot;.
    /// </summary>
    [EnumMember(Value = "SEQP")]
    [IsoId("_Fb8kcQCqEeqouY-yI_q3qQ")]
    [Description(@"Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.")]
    SequenceNumberInvalidBounds = InstructionRejectionReasonCode.SequenceNumberInvalidBounds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sequence number is missing.
    /// Encoded/decoded by serializers as &quot;SEQM&quot;.
    /// </summary>
    [EnumMember(Value = "SEQM")]
    [IsoId("_FfC7wQCqEeqouY-yI_q3qQ")]
    [Description(@"Sequence number is missing.")]
    SequenceNumberMissing = InstructionRejectionReasonCode.SequenceNumberMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sequence number is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_FiDzgQCqEeqouY-yI_q3qQ")]
    [Description(@"Sequence number is out of sequence.")]
    SequenceNumberOutOfSync = InstructionRejectionReasonCode.SequenceNumberOutOfSync, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Comments are required for solicitation fee.
    /// Encoded/decoded by serializers as &quot;SOCR&quot;.
    /// </summary>
    [EnumMember(Value = "SOCR")]
    [IsoId("_Fk2BwQCqEeqouY-yI_q3qQ")]
    [Description(@"Comments are required for solicitation fee.")]
    SolicitationFeeCommentsRequired = InstructionRejectionReasonCode.SolicitationFeeCommentsRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Solicitation fee indicator is not used with this event.
    /// Encoded/decoded by serializers as &quot;SOLX&quot;.
    /// </summary>
    [EnumMember(Value = "SOLX")]
    [IsoId("_FnpeIQCqEeqouY-yI_q3qQ")]
    [Description(@"Solicitation fee indicator is not used with this event.")]
    SolicitationFeeIndicatorNotUsed = InstructionRejectionReasonCode.SolicitationFeeIndicatorNotUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Submission date is not yet reached.
    /// Encoded/decoded by serializers as &quot;SUBE&quot;.
    /// </summary>
    [EnumMember(Value = "SUBE")]
    [IsoId("_FwQnkQCqEeqouY-yI_q3qQ")]
    [Description(@"Submission date is not yet reached.")]
    SubmissionDateNotReached = InstructionRejectionReasonCode.SubmissionDateNotReached, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Solicitation fee indicator is required.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("_F8vkYQCqEeqouY-yI_q3qQ")]
    [Description(@"Solicitation fee indicator is required.")]
    SolicitationFeeIndicatorRequired = InstructionRejectionReasonCode.SolicitationFeeIndicatorRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date of submission has passed.
    /// Encoded/decoded by serializers as &quot;SUBL&quot;.
    /// </summary>
    [EnumMember(Value = "SUBL")]
    [IsoId("_GDAkcQCqEeqouY-yI_q3qQ")]
    [Description(@"Date of submission has passed.")]
    SubmissionDatePassed = InstructionRejectionReasonCode.SubmissionDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date on file must be zero.
    /// Encoded/decoded by serializers as &quot;PRO0&quot;.
    /// </summary>
    [EnumMember(Value = "PRO0")]
    [IsoId("_GNEfYQCqEeqouY-yI_q3qQ")]
    [Description(@"Protect date on file must be zero.")]
    ProtectDateZero = InstructionRejectionReasonCode.ProtectDateZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;PROL&quot;.
    /// </summary>
    [EnumMember(Value = "PROL")]
    [IsoId("_GSEUIQCqEeqouY-yI_q3qQ")]
    [Description(@"Protect date must be less than or equal to current date.")]
    ProtectDatePassed = InstructionRejectionReasonCode.ProtectDatePassed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction Identification is invalid.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_G-II4QCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction Identification is invalid.")]
    TransactionIdentificationInvalid = InstructionRejectionReasonCode.TransactionIdentificationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction Quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;TRQ0&quot;.
    /// </summary>
    [EnumMember(Value = "TRQ0")]
    [IsoId("_HBu2gQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction Quantity cannot be zero.")]
    TransactionQuantityCannotBeZero = InstructionRejectionReasonCode.TransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction quantity is less than the transaction minimum.
    /// Encoded/decoded by serializers as &quot;TRQM&quot;.
    /// </summary>
    [EnumMember(Value = "TRQM")]
    [IsoId("_HFCCIQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction quantity is less than the transaction minimum.")]
    TransactionQuantityLessThanTransactionMinimum = InstructionRejectionReasonCode.TransactionQuantityLessThanTransactionMinimum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction Quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;TRQI&quot;.
    /// </summary>
    [EnumMember(Value = "TRQI")]
    [IsoId("_HH5I4QCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction Quantity is missing or invalid.")]
    TransactionQuantityMissingOrInvalid = InstructionRejectionReasonCode.TransactionQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction sequence number is invalid, not numeric.
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_HKxdwQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction sequence number is invalid, not numeric.")]
    TransactionSequenceNumberInvalid = InstructionRejectionReasonCode.TransactionSequenceNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type and event are incompatible.
    /// Encoded/decoded by serializers as &quot;TNFN&quot;.
    /// </summary>
    [EnumMember(Value = "TNFN")]
    [IsoId("_HNWQoQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction type and event are incompatible.")]
    TransactionTypeAndEventIncompatible = InstructionRejectionReasonCode.TransactionTypeAndEventIncompatible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type is missing.
    /// Encoded/decoded by serializers as &quot;TRNM&quot;.
    /// </summary>
    [EnumMember(Value = "TRNM")]
    [IsoId("_HVccsQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction type is missing.")]
    TransactionTypeMissing = InstructionRejectionReasonCode.TransactionTypeMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying security CUSIP does not match the original.
    /// Encoded/decoded by serializers as &quot;CUSU&quot;.
    /// </summary>
    [EnumMember(Value = "CUSU")]
    [IsoId("_HZyxMQCqEeqouY-yI_q3qQ")]
    [Description(@"Underlying security CUSIP does not match the original.")]
    UnderlyingSecurityCUSIPMismatch = InstructionRejectionReasonCode.UnderlyingSecurityCUSIPMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying share quantity is invalid.
    /// Encoded/decoded by serializers as &quot;SHQI&quot;.
    /// </summary>
    [EnumMember(Value = "SHQI")]
    [IsoId("_Hgxi8QCqEeqouY-yI_q3qQ")]
    [Description(@"Underlying share quantity is invalid.")]
    UnderlyingShareQuantityInvalid = InstructionRejectionReasonCode.UnderlyingShareQuantityInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying share quantity does not match original share quantity.
    /// Encoded/decoded by serializers as &quot;SHQO&quot;.
    /// </summary>
    [EnumMember(Value = "SHQO")]
    [IsoId("_HjNy8QCqEeqouY-yI_q3qQ")]
    [Description(@"Underlying share quantity does not match original share quantity.")]
    UnderlyingShareQuantityMismatch = InstructionRejectionReasonCode.UnderlyingShareQuantityMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The rejection reason is unknown.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_HlayYQCqEeqouY-yI_q3qQ")]
    [Description(@"The rejection reason is unknown.")]
    UnknownErrorCondition = InstructionRejectionReasonCode.UnknownErrorCondition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Warrant subscription charge amount is not balancing.
    /// Encoded/decoded by serializers as &quot;WARC&quot;.
    /// </summary>
    [EnumMember(Value = "WARC")]
    [IsoId("_HnnKwQCqEeqouY-yI_q3qQ")]
    [Description(@"Warrant subscription charge amount is not balancing.")]
    WarrantSubscriptionChargeAmountInvalid = InstructionRejectionReasonCode.WarrantSubscriptionChargeAmountInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal quantity exceeds the remaining quantity.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_Hpdk4QCqEeqouY-yI_q3qQ")]
    [Description(@"Withdrawal quantity exceeds the remaining quantity.")]
    WithdrawalQuantityExceedsRemainingQuantity = InstructionRejectionReasonCode.WithdrawalQuantityExceedsRemainingQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;WIT0&quot;.
    /// </summary>
    [EnumMember(Value = "WIT0")]
    [IsoId("_Hvn3QQCqEeqouY-yI_q3qQ")]
    [Description(@"Withdrawal transaction quantity cannot be zero.")]
    WithdrawalTransactionQuantityCannotBeZero = InstructionRejectionReasonCode.WithdrawalTransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error in withdraw occurred.
    /// Encoded/decoded by serializers as &quot;WITE&quot;.
    /// </summary>
    [EnumMember(Value = "WITE")]
    [IsoId("_H4lmAQCqEeqouY-yI_q3qQ")]
    [Description(@"Error in withdraw occurred.")]
    WithdrawError = InstructionRejectionReasonCode.WithdrawError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal Transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;WITI&quot;.
    /// </summary>
    [EnumMember(Value = "WITI")]
    [IsoId("_H83CAQCqEeqouY-yI_q3qQ")]
    [Description(@"Withdrawal Transaction type is invalid.")]
    WithdrawalTransactionTypeInvalid = InstructionRejectionReasonCode.WithdrawalTransactionTypeInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal quantity is greater than VOI / protect quantity.
    /// Encoded/decoded by serializers as &quot;WITG&quot;.
    /// </summary>
    [EnumMember(Value = "WITG")]
    [IsoId("_IAchgQCqEeqouY-yI_q3qQ")]
    [Description(@"Withdrawal quantity is greater than VOI / protect quantity.")]
    WithdrawalQuantityGreaterThanProtectQuantity = InstructionRejectionReasonCode.WithdrawalQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying security CUSIP is invalid.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_IMARQQCqEeqouY-yI_q3qQ")]
    [Description(@"Underlying security CUSIP is invalid.")]
    UnderlyingSecurityCUSIPInvalid = InstructionRejectionReasonCode.UnderlyingSecurityCUSIPInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type or withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_IS6xkQCqEeqouY-yI_q3qQ")]
    [Description(@"Transaction type or withdrawal transaction type is invalid.")]
    TransactionTypeInvalid = InstructionRejectionReasonCode.TransactionTypeInvalid, // same ordinal as derivation source for type conversions
    
}
