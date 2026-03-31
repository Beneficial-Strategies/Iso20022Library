// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W_GJgMYNEeexPc-mfUU5zQ")]
[Description(
    @"Reason for rejection of a corporate action instruction or of an instruction cancellation."
)]
[DerivedFrom(typeof(InstructionRejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InstructionRejectionReason1Code>))]
#endif
public enum InstructionRejectionReason1Code
{
    /// <summary>
    /// Acknowledgement must be agreed.
    /// Encoded/decoded by serializers as &quot;ACKA&quot;.
    /// </summary>
    [EnumMember(Value = "ACKA")]
    [IsoId("_YjX_scYNEeexPc-mfUU5zQ")]
    [Description(@"Acknowledgement must be agreed.")]
    AcknowledgementNotAgreed = InstructionRejectionReasonCode.AcknowledgementNotAgreed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgment indicator is missing.
    /// Encoded/decoded by serializers as &quot;ACKS&quot;.
    /// </summary>
    [EnumMember(Value = "ACKS")]
    [IsoId("_3hp38ciNEee7W-rN1yqPMg")]
    [Description(@"Acknowledgment indicator is missing.")]
    AcknowledgmentIndicatorMissing = InstructionRejectionReasonCode.AcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid price is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_3nT0AciNEee7W-rN1yqPMg")]
    [Description(@"Bid price is missing or invalid.")]
    BidPriceMissingOrInvalid = InstructionRejectionReasonCode.BidPriceMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid Price cannot be greater than 9999.99999.
    /// Encoded/decoded by serializers as &quot;BIDG&quot;.
    /// </summary>
    [EnumMember(Value = "BIDG")]
    [IsoId("_3pioociNEee7W-rN1yqPMg")]
    [Description(@"Bid Price cannot be greater than 9999.99999.")]
    BidPriceOverflow = InstructionRejectionReasonCode.BidPriceOverflow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid Price is less than the minimum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDM&quot;.
    /// </summary>
    [EnumMember(Value = "BIDM")]
    [IsoId("_32xzYciNEee7W-rN1yqPMg")]
    [Description(@"Bid Price is less than the minimum bid price allowed for the offer.")]
    BidPriceUnderMinimumAllowed = InstructionRejectionReasonCode.BidPriceUnderMinimumAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bond check on master table is not available.
    /// Encoded/decoded by serializers as &quot;BNDU&quot;.
    /// </summary>
    [EnumMember(Value = "BNDU")]
    [IsoId("_4AvnsciNEee7W-rN1yqPMg")]
    [Description(@"Bond check on master table is not available.")]
    BondCheckOnMasterTableNotAvailable =
        InstructionRejectionReasonCode.BondCheckOnMasterTableNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 1 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN1N&quot;.
    /// </summary>
    [EnumMember(Value = "CN1N")]
    [IsoId("_4Cq6UciNEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is invalid. It must be No.")]
    Condition1InvalidMustBeNo = InstructionRejectionReasonCode.Condition1InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 2 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN2N&quot;.
    /// </summary>
    [EnumMember(Value = "CN2N")]
    [IsoId("_4TMCkciNEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is invalid. It must be No.")]
    Condition2InvalidMustBeNo = InstructionRejectionReasonCode.Condition2InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 1 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN1R&quot;.
    /// </summary>
    [EnumMember(Value = "CN1R")]
    [IsoId("_4q-3gciNEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is must be present.")]
    Condition1Required = InstructionRejectionReasonCode.Condition1Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 1 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN1Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN1Y")]
    [IsoId("_4wfCkciNEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is invalid. It must be Yes.")]
    Condition1InvalidMustBeYes = InstructionRejectionReasonCode.Condition1InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Zeroes are required for bid price.
    /// Encoded/decoded by serializers as &quot;BID0&quot;.
    /// </summary>
    [EnumMember(Value = "BID0")]
    [IsoId("_45tQAciNEee7W-rN1yqPMg")]
    [Description(@"Zeroes are required for bid price.")]
    BidPriceZeroesRequired = InstructionRejectionReasonCode.BidPriceZeroesRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid Price exceeds maximum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_4_NbEciNEee7W-rN1yqPMg")]
    [Description(@"Bid Price exceeds maximum bid price allowed for the offer.")]
    BidPriceOverMaximumAllowed = InstructionRejectionReasonCode.BidPriceOverMaximumAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 2 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN2Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN2Y")]
    [IsoId("_5PboYciNEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is invalid. It must be Yes.")]
    Condition2InvalidMustBeYes = InstructionRejectionReasonCode.Condition2InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 2 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN2R&quot;.
    /// </summary>
    [EnumMember(Value = "CN2R")]
    [IsoId("_5RW7AciNEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is must be present.")]
    Condition2Required = InstructionRejectionReasonCode.Condition2Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 3 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN3N&quot;.
    /// </summary>
    [EnumMember(Value = "CN3N")]
    [IsoId("_5XA3EciNEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is invalid. It must be No.")]
    Condition3InvalidMustBeNo = InstructionRejectionReasonCode.Condition3InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 3 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN3Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN3Y")]
    [IsoId("_5chCIciNEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is invalid. It must be Yes.")]
    Condition3InvalidMustBeYes = InstructionRejectionReasonCode.Condition3InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 3 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN3R&quot;.
    /// </summary>
    [EnumMember(Value = "CN3R")]
    [IsoId("_5h4DQciNEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is must be present.")]
    Condition3Required = InstructionRejectionReasonCode.Condition3Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 4 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN4N&quot;.
    /// </summary>
    [EnumMember(Value = "CN4N")]
    [IsoId("_5nFTYciNEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is invalid. It must be No.")]
    Condition4InvalidMustBeNo = InstructionRejectionReasonCode.Condition4InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 4 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN4Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN4Y")]
    [IsoId("_5o3cEciNEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is invalid. It must be Yes.")]
    Condition4InvalidMustBeYes = InstructionRejectionReasonCode.Condition4InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 4 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN4R&quot;.
    /// </summary>
    [EnumMember(Value = "CN4R")]
    [IsoId("_5ugxEciNEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is must be present.")]
    Condition4Required = InstructionRejectionReasonCode.Condition4Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 5 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN5Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN5Y")]
    [IsoId("_53u-gciNEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is invalid. It must be Yes.")]
    Condition5InvalidMustBeYes = InstructionRejectionReasonCode.Condition5InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 5 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN5N&quot;.
    /// </summary>
    [EnumMember(Value = "CN5N")]
    [IsoId("_6H8kwciNEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is invalid. It must be No.")]
    Condition5InvalidMustBeNo = InstructionRejectionReasonCode.Condition5InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 5 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN5R&quot;.
    /// </summary>
    [EnumMember(Value = "CN5R")]
    [IsoId("_6uLeUciNEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is must be present.")]
    Condition5Required = InstructionRejectionReasonCode.Condition5Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 6 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN6N&quot;.
    /// </summary>
    [EnumMember(Value = "CN6N")]
    [IsoId("_6v9nAciNEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is invalid. It must be No.")]
    Condition6InvalidMustBeNo = InstructionRejectionReasonCode.Condition6InvalidMustBeNo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 6 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN6Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN6Y")]
    [IsoId("_616eAciNEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is invalid. It must be Yes.")]
    Condition6InvalidMustBeYes = InstructionRejectionReasonCode.Condition6InvalidMustBeYes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Condition 6 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN6R&quot;.
    /// </summary>
    [EnumMember(Value = "CN6R")]
    [IsoId("_67Q4EciNEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is must be present.")]
    Condition6Required = InstructionRejectionReasonCode.Condition6Required, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;COQX&quot;.
    /// </summary>
    [EnumMember(Value = "COQX")]
    [IsoId("_7AeIMciNEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity cannot be zero.")]
    ConditionalQuantityCannotBeZero =
        InstructionRejectionReasonCode.ConditionalQuantityCannotBeZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity.
    /// Encoded/decoded by serializers as &quot;COTQ&quot;.
    /// </summary>
    [EnumMember(Value = "COTQ")]
    [IsoId("_7F-TQciNEee7W-rN1yqPMg")]
    [Description(
        @"Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity."
    )]
    ConditionalQuantityDoesNotEqualTransactionQuantity =
        InstructionRejectionReasonCode.ConditionalQuantityDoesNotEqualTransactionQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional quantity exceeds the transaction quantity.
    /// Encoded/decoded by serializers as &quot;COQE&quot;.
    /// </summary>
    [EnumMember(Value = "COQE")]
    [IsoId("_7WVqgciNEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity exceeds the transaction quantity.")]
    ConditionalQuantityExceedsTransactionQuantity =
        InstructionRejectionReasonCode.ConditionalQuantityExceedsTransactionQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;COQI&quot;.
    /// </summary>
    [EnumMember(Value = "COQI")]
    [IsoId("_7YHzMciNEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity is missing or invalid.")]
    ConditionalQuantityMissingOrInvalid =
        InstructionRejectionReasonCode.ConditionalQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional quantity zeroes are required.
    /// Encoded/decoded by serializers as &quot;COQ0&quot;.
    /// </summary>
    [EnumMember(Value = "COQ0")]
    [IsoId("_7dn-QciNEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity zeroes are required.")]
    ConditionalQuantityZeroesRequired =
        InstructionRejectionReasonCode.ConditionalQuantityZeroesRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact name is missing.
    /// Encoded/decoded by serializers as &quot;CNAM&quot;.
    /// </summary>
    [EnumMember(Value = "CNAM")]
    [IsoId("_7jR6UciNEee7W-rN1yqPMg")]
    [Description(@"Contact name is missing.")]
    ContactNameMissing = InstructionRejectionReasonCode.ContactNameMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact name is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNAX&quot;.
    /// </summary>
    [EnumMember(Value = "CNAX")]
    [IsoId("_7lN0AciNEee7W-rN1yqPMg")]
    [Description(@"Contact name is not used with this event.")]
    ContactNameNotUsedWithEvent = InstructionRejectionReasonCode.ContactNameNotUsedWithEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact phone number is missing.
    /// Encoded/decoded by serializers as &quot;CNPM&quot;.
    /// </summary>
    [EnumMember(Value = "CNPM")]
    [IsoId("_7qt_EciNEee7W-rN1yqPMg")]
    [Description(@"Contact phone number is missing.")]
    ContactPhoneNumberMissing = InstructionRejectionReasonCode.ContactPhoneNumberMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact phone number is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNPX&quot;.
    /// </summary>
    [EnumMember(Value = "CNPX")]
    [IsoId("_7wEZIciNEee7W-rN1yqPMg")]
    [Description(@"Contact phone number is not used with this event.")]
    ContactPhoneNumberNotUsedWithEvent =
        InstructionRejectionReasonCode.ContactPhoneNumberNotUsedWithEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cover quantity is greater than the remaining protect quantity.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_7yAS0ciNEee7W-rN1yqPMg")]
    [Description(@"Cover quantity is greater than the remaining protect quantity.")]
    CoverQuantityGreaterThanProtectQuantity =
        InstructionRejectionReasonCode.CoverQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CUSIP is depository deliver chilled.
    /// Encoded/decoded by serializers as &quot;CHIL&quot;.
    /// </summary>
    [EnumMember(Value = "CHIL")]
    [IsoId("_73zY0ciNEee7W-rN1yqPMg")]
    [Description(@"CUSIP is depository deliver chilled.")]
    CUSIPDepositoryDeliverChilled = InstructionRejectionReasonCode.CUSIPDepositoryDeliverChilled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;CUSD&quot;.
    /// </summary>
    [EnumMember(Value = "CUSD")]
    [IsoId("_79KZ8ciNEee7W-rN1yqPMg")]
    [Description(@"Target CUSIP or contra CUSIP identification is not DTC eligible.")]
    CUSIPNotDTCEligible = InstructionRejectionReasonCode.CUSIPNotDTCEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_8CqlAciNEee7W-rN1yqPMg")]
    [Description(@"Customer identification is missing or invalid.")]
    CustomerIdentificationMissingOrInvalid =
        InstructionRejectionReasonCode.CustomerIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer quantities do not add up to total rights quantities.
    /// Encoded/decoded by serializers as &quot;CQRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CQRQ")]
    [IsoId("_8a6F4ciNEee7W-rN1yqPMg")]
    [Description(@"Customer quantities do not add up to total rights quantities.")]
    CustomerQuantitiesAndTotalRightsQuantitiesMismatch =
        InstructionRejectionReasonCode.CustomerQuantitiesAndTotalRightsQuantitiesMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Comment area is invalid.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_8g284ciNEee7W-rN1yqPMg")]
    [Description(@"Comment area is invalid.")]
    CommentAreaInvalid = InstructionRejectionReasonCode.CommentAreaInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action event identification is invalid.
    /// Encoded/decoded by serializers as &quot;CAID&quot;.
    /// </summary>
    [EnumMember(Value = "CAID")]
    [IsoId("_8mXH8ciNEee7W-rN1yqPMg")]
    [Description(@"Corporate action event identification is invalid.")]
    CorporateActionEventInvalid = InstructionRejectionReasonCode.CorporateActionEventInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Sequence number is invalid or out of sequence.
    /// Encoded/decoded by serializers as &quot;CSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSEQ")]
    [IsoId("_8tDl0ciNEee7W-rN1yqPMg")]
    [Description(@"Customer Sequence number is invalid or out of sequence.")]
    CustomerSequenceNumberInvalid = InstructionRejectionReasonCode.CustomerSequenceNumberInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer is not ATOP eligible.
    /// Encoded/decoded by serializers as &quot;ATOP&quot;.
    /// </summary>
    [EnumMember(Value = "ATOP")]
    [IsoId("_8y3S4ciNEee7W-rN1yqPMg")]
    [Description(@"Offer is not ATOP eligible.")]
    OfferNotATOPEligible = InstructionRejectionReasonCode.OfferNotATOPEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;ADIN&quot;.
    /// </summary>
    [EnumMember(Value = "ADIN")]
    [IsoId("_WoXOAclOEee7W-rN1yqPMg")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is invalid.")]
    AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid =
        InstructionRejectionReasonCode.AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("_WsOaUclOEee7W-rN1yqPMg")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is missing.")]
    AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing =
        InstructionRejectionReasonCode.AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficial owner death date is missing.
    /// Encoded/decoded by serializers as &quot;BODD&quot;.
    /// </summary>
    [EnumMember(Value = "BODD")]
    [IsoId("_WwGNsclOEee7W-rN1yqPMg")]
    [Description(@"Beneficial owner death date is missing.")]
    BeneficialOwnerDeathDateMissing =
        InstructionRejectionReasonCode.BeneficialOwnerDeathDateMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficial owner name is missing.
    /// Encoded/decoded by serializers as &quot;BONM&quot;.
    /// </summary>
    [EnumMember(Value = "BONM")]
    [IsoId("_W0HLAclOEee7W-rN1yqPMg")]
    [Description(@"Beneficial owner name is missing.")]
    BeneficialOwnerNameMissing = InstructionRejectionReasonCode.BeneficialOwnerNameMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number is missing.
    /// Encoded/decoded by serializers as &quot;CENM&quot;.
    /// </summary>
    [EnumMember(Value = "CENM")]
    [IsoId("_W-rcQclOEee7W-rN1yqPMg")]
    [Description(@"Certificate number is missing.")]
    CertificateNameMissing = InstructionRejectionReasonCode.CertificateNameMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number is invalid.
    /// Encoded/decoded by serializers as &quot;CERN&quot;.
    /// </summary>
    [EnumMember(Value = "CERN")]
    [IsoId("_XCsZkclOEee7W-rN1yqPMg")]
    [Description(@"Certificate number is invalid.")]
    CertificateNumberInvalid = InstructionRejectionReasonCode.CertificateNumberInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate sequence number is invalid.
    /// Encoded/decoded by serializers as &quot;CERS&quot;.
    /// </summary>
    [EnumMember(Value = "CERS")]
    [IsoId("_XHKC0clOEee7W-rN1yqPMg")]
    [Description(@"Certificate sequence number is invalid.")]
    CertificateSequenceNumberInvalid =
        InstructionRejectionReasonCode.CertificateSequenceNumberInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is summary difference between core oversubscription quantity and extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUMO&quot;.
    /// </summary>
    [EnumMember(Value = "SUMO")]
    [IsoId("_YC0Z0clOEee7W-rN1yqPMg")]
    [Description(
        @"There is summary difference between core oversubscription quantity and extension transaction details."
    )]
    CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference =
        InstructionRejectionReasonCode.CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is a summary difference between the core instruction quantity and the extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUME&quot;.
    /// </summary>
    [EnumMember(Value = "SUME")]
    [IsoId("_YG-hEclOEee7W-rN1yqPMg")]
    [Description(
        @"There is a summary difference between the core instruction quantity and the extension transaction details."
    )]
    CoreInstructionQuantityAndExtensionTransactionDetailsDifference =
        InstructionRejectionReasonCode.CoreInstructionQuantityAndExtensionTransactionDetailsDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current date is greater than protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROE&quot;.
    /// </summary>
    [EnumMember(Value = "PROE")]
    [IsoId("_YQpacclOEee7W-rN1yqPMg")]
    [Description(@"Current date is greater than protect submission end date.")]
    CurrentDatePassedProtectSubmissionEndDate =
        InstructionRejectionReasonCode.CurrentDatePassedProtectSubmissionEndDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current date is less than protect submission start date.
    /// Encoded/decoded by serializers as &quot;PROS&quot;.
    /// </summary>
    [EnumMember(Value = "PROS")]
    [IsoId("_YU95wclOEee7W-rN1yqPMg")]
    [Description(@"Current date is less than protect submission start date.")]
    CurrentDatePrecedesProtectSubmissionStartDate =
        InstructionRejectionReasonCode.CurrentDatePrecedesProtectSubmissionStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUSI&quot;.
    /// </summary>
    [EnumMember(Value = "CUSI")]
    [IsoId("_YZIoEclOEee7W-rN1yqPMg")]
    [Description(@"Target CUSIP or contra CUSIP identification is missing or invalid.")]
    CUSIPMissingOrInvalid = InstructionRejectionReasonCode.CUSIPMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer oversubscription quantities do not add up to total oversubscription quantity.
    /// Encoded/decoded by serializers as &quot;OVCU&quot;.
    /// </summary>
    [EnumMember(Value = "OVCU")]
    [IsoId("_YdSvUclOEee7W-rN1yqPMg")]
    [Description(
        @"Customer oversubscription quantities do not add up to total oversubscription quantity."
    )]
    CustomerAndTotalOversubscriptionQuantitiesMismatch =
        InstructionRejectionReasonCode.CustomerAndTotalOversubscriptionQuantitiesMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Sequence number must be all zero.
    /// Encoded/decoded by serializers as &quot;SEQ0&quot;.
    /// </summary>
    [EnumMember(Value = "SEQ0")]
    [IsoId("_YsBu4clOEee7W-rN1yqPMg")]
    [Description(@"Customer Sequence number must be all zero.")]
    CustomerSequenceNumberAllZero = InstructionRejectionReasonCode.CustomerSequenceNumberAllZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cut-off time check has failed.
    /// Encoded/decoded by serializers as &quot;CUTC&quot;.
    /// </summary>
    [EnumMember(Value = "CUTC")]
    [IsoId("_YwVnIclOEee7W-rN1yqPMg")]
    [Description(@"Cut-off time check has failed.")]
    CutoffTimeCheckFailed = InstructionRejectionReasonCode.CutoffTimeCheckFailed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cut-off time has passed.
    /// Encoded/decoded by serializers as &quot;CUTT&quot;.
    /// </summary>
    [EnumMember(Value = "CUTT")]
    [IsoId("_Yz6fkclOEee7W-rN1yqPMg")]
    [Description(@"Cut-off time has passed.")]
    CutoffTimePassed = InstructionRejectionReasonCode.CutoffTimePassed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Death certificate details are missing.
    /// Encoded/decoded by serializers as &quot;BODC&quot;.
    /// </summary>
    [EnumMember(Value = "BODC")]
    [IsoId("_Y4hSwclOEee7W-rN1yqPMg")]
    [Description(@"Death certificate details are missing.")]
    DeathCertificateMissing = InstructionRejectionReasonCode.DeathCertificateMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction sequence number is duplicated.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_Y8sBEclOEee7W-rN1yqPMg")]
    [Description(@"Transaction sequence number is duplicated.")]
    DuplicateTransactionSequenceNumber =
        InstructionRejectionReasonCode.DuplicateTransactionSequenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entry Date is invalid.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_ZAHIgclOEee7W-rN1yqPMg")]
    [Description(@"Entry Date is invalid.")]
    EntryDateInvalid = InstructionRejectionReasonCode.EntryDateInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entry date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_ZEIF0clOEee7W-rN1yqPMg")]
    [Description(@"Entry date must be less than or equal to current date.")]
    EntryDatePassed = InstructionRejectionReasonCode.EntryDatePassed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer has fractional underlying quantity, adjust quantity.
    /// Encoded/decoded by serializers as &quot;FRAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FRAQ")]
    [IsoId("_ZHsXMclOEee7W-rN1yqPMg")]
    [Description(@"Customer has fractional underlying quantity, adjust quantity.")]
    FractionalUnderlyingQuantity = InstructionRejectionReasonCode.FractionalUnderlyingQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Function is not available at this time. Please check expiration start and end times for the event.
    /// Encoded/decoded by serializers as &quot;FUNU&quot;.
    /// </summary>
    [EnumMember(Value = "FUNU")]
    [IsoId("_ZTAPUclOEee7W-rN1yqPMg")]
    [Description(
        @"Function is not available at this time. Please check expiration start and end times for the event."
    )]
    FunctionNotAvailable = InstructionRejectionReasonCode.FunctionNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Function is quiesced (not available).
    /// Encoded/decoded by serializers as &quot;QUIE&quot;.
    /// </summary>
    [EnumMember(Value = "QUIE")]
    [IsoId("_ZWbWwclOEee7W-rN1yqPMg")]
    [Description(@"Function is quiesced (not available).")]
    FunctionQuiesced = InstructionRejectionReasonCode.FunctionQuiesced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction deletion acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_ZacUEclOEee7W-rN1yqPMg")]
    [Description(@"Instruction deletion acknowledgement indicator is invalid.")]
    InstructionDeletionAcknowledgementIndicatorInvalid =
        InstructionRejectionReasonCode.InstructionDeletionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction deletion acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_ZedRYclOEee7W-rN1yqPMg")]
    [Description(@"Instruction deletion acknowledgement indicator is missing.")]
    InstructionDeletionAcknowledgementIndicatorMissing =
        InstructionRejectionReasonCode.InstructionDeletionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant has insufficient position.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_ZieOsclOEee7W-rN1yqPMg")]
    [Description(@"Participant has insufficient position.")]
    InsufficientPosition = InstructionRejectionReasonCode.InsufficientPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record type is invalid.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_bRdgEclOEee7W-rN1yqPMg")]
    [Description(@"Record type is invalid.")]
    RecordTypeInvalid = InstructionRejectionReasonCode.RecordTypeInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights quantity is invalid.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("_bVBxcclOEee7W-rN1yqPMg")]
    [Description(@"Rights quantity is invalid.")]
    RightsQuantityInvalid = InstructionRejectionReasonCode.RightsQuantityInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type or withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_bf49oclOEee7W-rN1yqPMg")]
    [Description(@"Transaction type or withdrawal transaction type is invalid.")]
    TransactionTypeInvalid = InstructionRejectionReasonCode.TransactionTypeInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuing jurisdiction is missing.
    /// Encoded/decoded by serializers as &quot;BOIJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOIJ")]
    [IsoId("_bjwxAclOEee7W-rN1yqPMg")]
    [Description(@"Issuing jurisdiction is missing.")]
    IssuingJurisdictionMissing = InstructionRejectionReasonCode.IssuingJurisdictionMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key data (VOI transaction) cannot be found.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_bnezYclOEee7W-rN1yqPMg")]
    [Description(@"Key data (VOI transaction) cannot be found.")]
    KayDataNotFound = InstructionRejectionReasonCode.KayDataNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key Information is missing (tenders data).
    /// Encoded/decoded by serializers as &quot;KEYM&quot;.
    /// </summary>
    [EnumMember(Value = "KEYM")]
    [IsoId("_bqdO4clOEee7W-rN1yqPMg")]
    [Description(@"Key Information is missing (tenders data).")]
    KeyInformationMissing = InstructionRejectionReasonCode.KeyInformationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;LEGI&quot;.
    /// </summary>
    [EnumMember(Value = "LEGI")]
    [IsoId("_buLRQclOEee7W-rN1yqPMg")]
    [Description(
        @"Legal documentation thirty months retention acknowledgement indicator is invalid."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid =
        InstructionRejectionReasonCode.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal documentation thirty Months retention acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;LEGM&quot;.
    /// </summary>
    [EnumMember(Value = "LEGM")]
    [IsoId("_byo6gclOEee7W-rN1yqPMg")]
    [Description(
        @"Legal documentation thirty Months retention acknowledgement indicator is missing."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing =
        InstructionRejectionReasonCode.LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Master tables are not available.
    /// Encoded/decoded by serializers as &quot;MSTB&quot;.
    /// </summary>
    [EnumMember(Value = "MSTB")]
    [IsoId("_b16Q8clOEee7W-rN1yqPMg")]
    [Description(@"Master tables are not available.")]
    MasterTablesNotAvailable = InstructionRejectionReasonCode.MasterTablesNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is no withdrawal privilege on this offer.
    /// Encoded/decoded by serializers as &quot;NWIT&quot;.
    /// </summary>
    [EnumMember(Value = "NWIT")]
    [IsoId("_b5yEUclOEee7W-rN1yqPMg")]
    [Description(@"There is no withdrawal privilege on this offer.")]
    NoWithdrawalPrivilege = InstructionRejectionReasonCode.NoWithdrawalPrivilege, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Odd lot indicator is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ODLI&quot;.
    /// </summary>
    [EnumMember(Value = "ODLI")]
    [IsoId("_b85pwclOEee7W-rN1yqPMg")]
    [Description(@"Odd lot indicator is missing or invalid.")]
    OddLotIndicatorMissingOrInvalid =
        InstructionRejectionReasonCode.OddLotIndicatorMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer is already on historical data base.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_cQZNgclOEee7W-rN1yqPMg")]
    [Description(@"Offer is already on historical data base.")]
    OfferInDatabase = InstructionRejectionReasonCode.OfferInDatabase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offer is not eligible for the PUTS function.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_chDfsclOEee7W-rN1yqPMg")]
    [Description(@"Offer is not eligible for the PUTS function.")]
    OfferNotEligibleForPuts = InstructionRejectionReasonCode.OfferNotEligibleForPuts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription is not allowed.
    /// Encoded/decoded by serializers as &quot;OVRX&quot;.
    /// </summary>
    [EnumMember(Value = "OVRX")]
    [IsoId("_ck7TEclOEee7W-rN1yqPMg")]
    [Description(@"Oversubscription is not allowed.")]
    OversubscriptionNotAllowed = InstructionRejectionReasonCode.OversubscriptionNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription quantity is greater than percentage of underlying shares.
    /// Encoded/decoded by serializers as &quot;OVRG&quot;.
    /// </summary>
    [EnumMember(Value = "OVRG")]
    [IsoId("_cpPLUclOEee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity is greater than percentage of underlying shares.")]
    OversubscriptionQuantityExceeded =
        InstructionRejectionReasonCode.OversubscriptionQuantityExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription quantity is invalid.
    /// Encoded/decoded by serializers as &quot;OVRI&quot;.
    /// </summary>
    [EnumMember(Value = "OVRI")]
    [IsoId("_ctG-sclOEee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity is invalid.")]
    OversubscriptionQuantityInvalid =
        InstructionRejectionReasonCode.OversubscriptionQuantityInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription quantity not used with this transaction type.
    /// Encoded/decoded by serializers as &quot;OVTT&quot;.
    /// </summary>
    [EnumMember(Value = "OVTT")]
    [IsoId("_cxH8AclOEee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity not used with this transaction type.")]
    OversubscriptionQuantityNotUsed =
        InstructionRejectionReasonCode.OversubscriptionQuantityNotUsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant is DO chilled.
    /// Encoded/decoded by serializers as &quot;PACH&quot;.
    /// </summary>
    [EnumMember(Value = "PACH")]
    [IsoId("_c7icQclOEee7W-rN1yqPMg")]
    [Description(@"Participant is DO chilled.")]
    ParticipantDOChilled = InstructionRejectionReasonCode.ParticipantDOChilled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cannot submit odd lot indicator &apos;Yes&apos; for the offer.
    /// Encoded/decoded by serializers as &quot;ODLY&quot;.
    /// </summary>
    [EnumMember(Value = "ODLY")]
    [IsoId("_dGsjYclOEee7W-rN1yqPMg")]
    [Description(@"Cannot submit odd lot indicator 'Yes' for the offer.")]
    OddLotIndicatorYesInvalid = InstructionRejectionReasonCode.OddLotIndicatorYesInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error in withdraw occurred.
    /// Encoded/decoded by serializers as &quot;WITE&quot;.
    /// </summary>
    [EnumMember(Value = "WITE")]
    [IsoId("_d-fHAclOEee7W-rN1yqPMg")]
    [Description(@"Error in withdraw occurred.")]
    WithdrawError = InstructionRejectionReasonCode.WithdrawError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;WIT0&quot;.
    /// </summary>
    [EnumMember(Value = "WIT0")]
    [IsoId("_eIc7UclOEee7W-rN1yqPMg")]
    [Description(@"Withdrawal transaction quantity cannot be zero.")]
    WithdrawalTransactionQuantityCannotBeZero =
        InstructionRejectionReasonCode.WithdrawalTransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal quantity is greater than VOI / protect quantity.
    /// Encoded/decoded by serializers as &quot;WITG&quot;.
    /// </summary>
    [EnumMember(Value = "WITG")]
    [IsoId("_eLbW0clOEee7W-rN1yqPMg")]
    [Description(@"Withdrawal quantity is greater than VOI / protect quantity.")]
    WithdrawalQuantityGreaterThanProtectQuantity =
        InstructionRejectionReasonCode.WithdrawalQuantityGreaterThanProtectQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal quantity exceeds the remaining quantity.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_eOG3YclOEee7W-rN1yqPMg")]
    [Description(@"Withdrawal quantity exceeds the remaining quantity.")]
    WithdrawalQuantityExceedsRemainingQuantity =
        InstructionRejectionReasonCode.WithdrawalQuantityExceedsRemainingQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Warrant subscription charge amount is not balancing.
    /// Encoded/decoded by serializers as &quot;WARC&quot;.
    /// </summary>
    [EnumMember(Value = "WARC")]
    [IsoId("_eXn_wclOEee7W-rN1yqPMg")]
    [Description(@"Warrant subscription charge amount is not balancing.")]
    WarrantSubscriptionChargeAmountInvalid =
        InstructionRejectionReasonCode.WarrantSubscriptionChargeAmountInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The rejection reason is unknown.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ea5WMclOEee7W-rN1yqPMg")]
    [Description(@"The rejection reason is unknown.")]
    UnknownErrorCondition = InstructionRejectionReasonCode.UnknownErrorCondition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying share quantity does not match original share quantity.
    /// Encoded/decoded by serializers as &quot;SHQO&quot;.
    /// </summary>
    [EnumMember(Value = "SHQO")]
    [IsoId("_elnYcclOEee7W-rN1yqPMg")]
    [Description(@"Underlying share quantity does not match original share quantity.")]
    UnderlyingShareQuantityMismatch =
        InstructionRejectionReasonCode.UnderlyingShareQuantityMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying share quantity is invalid.
    /// Encoded/decoded by serializers as &quot;SHQI&quot;.
    /// </summary>
    [EnumMember(Value = "SHQI")]
    [IsoId("_epekwclOEee7W-rN1yqPMg")]
    [Description(@"Underlying share quantity is invalid.")]
    UnderlyingShareQuantityInvalid = InstructionRejectionReasonCode.UnderlyingShareQuantityInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying security CUSIP does not match the original.
    /// Encoded/decoded by serializers as &quot;CUSU&quot;.
    /// </summary>
    [EnumMember(Value = "CUSU")]
    [IsoId("_etDdMclOEee7W-rN1yqPMg")]
    [Description(@"Underlying security CUSIP does not match the original.")]
    UnderlyingSecurityCUSIPMismatch =
        InstructionRejectionReasonCode.UnderlyingSecurityCUSIPMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying security CUSIP is invalid.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_e5jBEclOEee7W-rN1yqPMg")]
    [Description(@"Underlying security CUSIP is invalid.")]
    UnderlyingSecurityCUSIPInvalid = InstructionRejectionReasonCode.UnderlyingSecurityCUSIPInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type is missing.
    /// Encoded/decoded by serializers as &quot;TRNM&quot;.
    /// </summary>
    [EnumMember(Value = "TRNM")]
    [IsoId("_e9tvYclOEee7W-rN1yqPMg")]
    [Description(@"Transaction type is missing.")]
    TransactionTypeMissing = InstructionRejectionReasonCode.TransactionTypeMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type and event are incompatible.
    /// Encoded/decoded by serializers as &quot;TNFN&quot;.
    /// </summary>
    [EnumMember(Value = "TNFN")]
    [IsoId("_fBI20clOEee7W-rN1yqPMg")]
    [Description(@"Transaction type and event are incompatible.")]
    TransactionTypeAndEventIncompatible =
        InstructionRejectionReasonCode.TransactionTypeAndEventIncompatible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction sequence number is invalid, not numeric.
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_fEtIMclOEee7W-rN1yqPMg")]
    [Description(@"Transaction sequence number is invalid, not numeric.")]
    TransactionSequenceNumberInvalid =
        InstructionRejectionReasonCode.TransactionSequenceNumberInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction quantity is less than the transaction minimum.
    /// Encoded/decoded by serializers as &quot;TRQM&quot;.
    /// </summary>
    [EnumMember(Value = "TRQM")]
    [IsoId("_fPHocclOEee7W-rN1yqPMg")]
    [Description(@"Transaction quantity is less than the transaction minimum.")]
    TransactionQuantityLessThanTransactionMinimum =
        InstructionRejectionReasonCode.TransactionQuantityLessThanTransactionMinimum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date of submission has passed.
    /// Encoded/decoded by serializers as &quot;SUBL&quot;.
    /// </summary>
    [EnumMember(Value = "SUBL")]
    [IsoId("_faRvkclOEee7W-rN1yqPMg")]
    [Description(@"Date of submission has passed.")]
    SubmissionDatePassed = InstructionRejectionReasonCode.SubmissionDatePassed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Comments are required for solicitation fee.
    /// Encoded/decoded by serializers as &quot;SOCR&quot;.
    /// </summary>
    [EnumMember(Value = "SOCR")]
    [IsoId("_fsuKcclOEee7W-rN1yqPMg")]
    [Description(@"Comments are required for solicitation fee.")]
    SolicitationFeeCommentsRequired =
        InstructionRejectionReasonCode.SolicitationFeeCommentsRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sequence number is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_fxLzsclOEee7W-rN1yqPMg")]
    [Description(@"Sequence number is out of sequence.")]
    SequenceNumberOutOfSync = InstructionRejectionReasonCode.SequenceNumberOutOfSync, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sequence number is missing.
    /// Encoded/decoded by serializers as &quot;SEQM&quot;.
    /// </summary>
    [EnumMember(Value = "SEQM")]
    [IsoId("_f0KPMclOEee7W-rN1yqPMg")]
    [Description(@"Sequence number is missing.")]
    SequenceNumberMissing = InstructionRejectionReasonCode.SequenceNumberMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.
    /// Encoded/decoded by serializers as &quot;SEQP&quot;.
    /// </summary>
    [EnumMember(Value = "SEQP")]
    [IsoId("_f4CCkclOEee7W-rN1yqPMg")]
    [Description(
        @"Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912."
    )]
    SequenceNumberInvalidBounds = InstructionRejectionReasonCode.SequenceNumberInvalidBounds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RTS processing is in progress. Submit later.
    /// Encoded/decoded by serializers as &quot;RTSP&quot;.
    /// </summary>
    [EnumMember(Value = "RTSP")]
    [IsoId("_f6tjIclOEee7W-rN1yqPMg")]
    [Description(@"RTS processing is in progress. Submit later.")]
    RTSProcessingInProgress = InstructionRejectionReasonCode.RTSProcessingInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights ratio not found on data base.
    /// Encoded/decoded by serializers as &quot;RTIO&quot;.
    /// </summary>
    [EnumMember(Value = "RTIO")]
    [IsoId("_f9PSsclOEee7W-rN1yqPMg")]
    [Description(@"Rights ratio not found on data base.")]
    RightsRatioNotFound = InstructionRejectionReasonCode.RightsRatioNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights quantity for this subscription must be divisible by rights.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("_gIjK0clOEee7W-rN1yqPMg")]
    [Description(@"Rights quantity for this subscription must be divisible by rights.")]
    RightsQuantityDivisibleByRights =
        InstructionRejectionReasonCode.RightsQuantityDivisibleByRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights CUSIP has insufficient position.
    /// Encoded/decoded by serializers as &quot;RILA&quot;.
    /// </summary>
    [EnumMember(Value = "RILA")]
    [IsoId("_gMkIIclOEee7W-rN1yqPMg")]
    [Description(@"Rights CUSIP has insufficient position.")]
    RightsCUSIPInsufficientPosition =
        InstructionRejectionReasonCode.RightsCUSIPInsufficientPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;TRQI&quot;.
    /// </summary>
    [EnumMember(Value = "TRQI")]
    [IsoId("_gT2b4clOEee7W-rN1yqPMg")]
    [Description(@"Transaction Quantity is missing or invalid.")]
    TransactionQuantityMissingOrInvalid =
        InstructionRejectionReasonCode.TransactionQuantityMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;TRQ0&quot;.
    /// </summary>
    [EnumMember(Value = "TRQ0")]
    [IsoId("_gYK7MclOEee7W-rN1yqPMg")]
    [Description(@"Transaction Quantity cannot be zero.")]
    TransactionQuantityCannotBeZero =
        InstructionRejectionReasonCode.TransactionQuantityCannotBeZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction Identification is invalid.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_gcCHgclOEee7W-rN1yqPMg")]
    [Description(@"Transaction Identification is invalid.")]
    TransactionIdentificationInvalid =
        InstructionRejectionReasonCode.TransactionIdentificationInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Submission date is not yet reached.
    /// Encoded/decoded by serializers as &quot;SUBE&quot;.
    /// </summary>
    [EnumMember(Value = "SUBE")]
    [IsoId("_gm5TsclOEee7W-rN1yqPMg")]
    [Description(@"Submission date is not yet reached.")]
    SubmissionDateNotReached = InstructionRejectionReasonCode.SubmissionDateNotReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicitation fee indicator is not used with this event.
    /// Encoded/decoded by serializers as &quot;SOLX&quot;.
    /// </summary>
    [EnumMember(Value = "SOLX")]
    [IsoId("_gpR5UclOEee7W-rN1yqPMg")]
    [Description(@"Solicitation fee indicator is not used with this event.")]
    SolicitationFeeIndicatorNotUsed =
        InstructionRejectionReasonCode.SolicitationFeeIndicatorNotUsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicitation fee indicator is required.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("_gsZewclOEee7W-rN1yqPMg")]
    [Description(@"Solicitation fee indicator is required.")]
    SolicitationFeeIndicatorRequired =
        InstructionRejectionReasonCode.SolicitationFeeIndicatorRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not a good return code from rights position check.
    /// Encoded/decoded by serializers as &quot;RPCI&quot;.
    /// </summary>
    [EnumMember(Value = "RPCI")]
    [IsoId("_g-2gsclOEee7W-rN1yqPMg")]
    [Description(@"Not a good return code from rights position check.")]
    RightsPositionCheckInvalid = InstructionRejectionReasonCode.RightsPositionCheckInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provided by protect, enter 0 for transaction quantity.
    /// Encoded/decoded by serializers as &quot;TRQP&quot;.
    /// </summary>
    [EnumMember(Value = "TRQP")]
    [IsoId("_htHU4clOEee7W-rN1yqPMg")]
    [Description(@"Provided by protect, enter 0 for transaction quantity.")]
    ProvidedByProtect = InstructionRejectionReasonCode.ProvidedByProtect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect identification is not used with this event.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_hxSDMclOEee7W-rN1yqPMg")]
    [Description(@"Protect identification is not used with this event.")]
    ProtectIdentificationNotUsed = InstructionRejectionReasonCode.ProtectIdentificationNotUsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_h2pEUclOEee7W-rN1yqPMg")]
    [Description(@"Protect identification is missing or invalid.")]
    ProtectIdentificationMissingOrInvalid =
        InstructionRejectionReasonCode.ProtectIdentificationMissingOrInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect date on file must be zero.
    /// Encoded/decoded by serializers as &quot;PRO0&quot;.
    /// </summary>
    [EnumMember(Value = "PRO0")]
    [IsoId("_h6NVsclOEee7W-rN1yqPMg")]
    [Description(@"Protect date on file must be zero.")]
    ProtectDateZero = InstructionRejectionReasonCode.ProtectDateZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;PROL&quot;.
    /// </summary>
    [EnumMember(Value = "PROL")]
    [IsoId("_h97YEclOEee7W-rN1yqPMg")]
    [Description(@"Protect date must be less than or equal to current date.")]
    ProtectDatePassed = InstructionRejectionReasonCode.ProtectDatePassed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect Date invalid or missing.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_iB8VYclOEee7W-rN1yqPMg")]
    [Description(@"Protect Date invalid or missing.")]
    ProtectDateInvalidOrMissing = InstructionRejectionReasonCode.ProtectDateInvalidOrMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Potential loss acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;POLM&quot;.
    /// </summary>
    [EnumMember(Value = "POLM")]
    [IsoId("_iF0IwclOEee7W-rN1yqPMg")]
    [Description(@"Potential loss acknowledgement indicator is missing.")]
    PotentiaLossAcknowledgementIndicatorMissing =
        InstructionRejectionReasonCode.PotentiaLossAcknowledgementIndicatorMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Potential loss acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;POLI&quot;.
    /// </summary>
    [EnumMember(Value = "POLI")]
    [IsoId("_iJYaIclOEee7W-rN1yqPMg")]
    [Description(@"Potential loss acknowledgement indicator is invalid.")]
    PotentiaLossAcknowledgementIndicatorInvalid =
        InstructionRejectionReasonCode.PotentiaLossAcknowledgementIndicatorInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant number is invalid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_iNZXcclOEee7W-rN1yqPMg")]
    [Description(@"Participant number is invalid.")]
    ParticipantNumberInvalid = InstructionRejectionReasonCode.ParticipantNumberInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant does not match participant on Protect ID.
    /// Encoded/decoded by serializers as &quot;PAPI&quot;.
    /// </summary>
    [EnumMember(Value = "PAPI")]
    [IsoId("_iRa70clOEee7W-rN1yqPMg")]
    [Description(@"Participant does not match participant on Protect ID.")]
    ParticipantNoMatchOnProtectIdentification =
        InstructionRejectionReasonCode.ParticipantNoMatchOnProtectIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant is globally locked.
    /// Encoded/decoded by serializers as &quot;PARL&quot;.
    /// </summary>
    [EnumMember(Value = "PARL")]
    [IsoId("_iU1cMclOEee7W-rN1yqPMg")]
    [Description(@"Participant is globally locked.")]
    ParticipantLocked = InstructionRejectionReasonCode.ParticipantLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;PARX&quot;.
    /// </summary>
    [EnumMember(Value = "PARX")]
    [IsoId("_if2ZYclOEee7W-rN1yqPMg")]
    [Description(@"Participant is not DTC eligible.")]
    ParticipantNotEligible = InstructionRejectionReasonCode.ParticipantNotEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant eligibility check on master table is not available.
    /// Encoded/decoded by serializers as &quot;PAEC&quot;.
    /// </summary>
    [EnumMember(Value = "PAEC")]
    [IsoId("_ipqcsclOEee7W-rN1yqPMg")]
    [Description(@"Participant eligibility check on master table is not available.")]
    ParticipantEligibilityCheckNotAvailable =
        InstructionRejectionReasonCode.ParticipantEligibilityCheckNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal Transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;WITI&quot;.
    /// </summary>
    [EnumMember(Value = "WITI")]
    [IsoId("_uefSMcnpEee6kIhZjMqQ2Q")]
    [Description(@"Withdrawal Transaction type is invalid.")]
    WithdrawalTransactionTypeInvalid =
        InstructionRejectionReasonCode.WithdrawalTransactionTypeInvalid, // same ordinal as derivation source for type conversions
}
