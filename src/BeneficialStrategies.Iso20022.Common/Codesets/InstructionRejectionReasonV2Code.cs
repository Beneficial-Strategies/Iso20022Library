// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IWWm-A-xEeuE0Pnt-OcNOA")]
[Description(
    @"Reason for rejection of a corporate action instruction or of an instruction cancellation."
)]
[Derivations(
    typeof(InstructionReason3Code),
    typeof(InstructionReason4Code),
    typeof(InstructionRejectionReason3Code)
)]
public enum InstructionRejectionReasonV2Code
{
    /// <summary>
    /// Acknowledgement must be agreed.
    /// Encoded/decoded by serializers as &quot;ACKA&quot;.
    /// </summary>
    [EnumMember(Value = "ACKA")]
    [IsoId("_IWfw3g-xEeuE0Pnt-OcNOA")]
    [Description(@"Acknowledgement must be agreed.")]
    AcknowledgementNotAgreed,

    /// <summary>
    /// Acknowledgment indicator is missing.
    /// Encoded/decoded by serializers as &quot;ACKS&quot;.
    /// </summary>
    [EnumMember(Value = "ACKS")]
    [IsoId("_IWfwtQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Acknowledgment indicator is missing.")]
    AcknowledgmentIndicatorMissing,

    /// <summary>
    /// Offer is not ATOP eligible.
    /// Encoded/decoded by serializers as &quot;ATOP&quot;.
    /// </summary>
    [EnumMember(Value = "ATOP")]
    [IsoId("_IWfweA-xEeuE0Pnt-OcNOA")]
    [Description(@"Offer is not ATOP eligible.")]
    OfferNotATOPEligible,

    /// <summary>
    /// Zeroes are required for bid price.
    /// Encoded/decoded by serializers as &quot;BID0&quot;.
    /// </summary>
    [EnumMember(Value = "BID0")]
    [IsoId("_IWfwsw-xEeuE0Pnt-OcNOA")]
    [Description(@"Zeroes are required for bid price.")]
    BidPriceZeroesRequired,

    /// <summary>
    /// Bid price exceeds maximum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_IWfwnA-xEeuE0Pnt-OcNOA")]
    [Description(@"Bid price exceeds maximum bid price allowed for the offer.")]
    BidPriceOverMaximumAllowed,

    /// <summary>
    /// Bid price cannot be greater than 9999.99999.
    /// Encoded/decoded by serializers as &quot;BIDG&quot;.
    /// </summary>
    [EnumMember(Value = "BIDG")]
    [IsoId("_IWfwjA-xEeuE0Pnt-OcNOA")]
    [Description(@"Bid price cannot be greater than 9999.99999.")]
    BidPriceOverflow,

    /// <summary>
    /// Bid price is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_IWfwdA-xEeuE0Pnt-OcNOA")]
    [Description(@"Bid price is missing or invalid.")]
    BidPriceMissingOrInvalid,

    /// <summary>
    /// Bid price is less than the minimum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDM&quot;.
    /// </summary>
    [EnumMember(Value = "BIDM")]
    [IsoId("_IWfwpw-xEeuE0Pnt-OcNOA")]
    [Description(@"Bid price is less than the minimum bid price allowed for the offer.")]
    BidPriceUnderMinimumAllowed,

    /// <summary>
    /// Bond check on master table is not available.
    /// Encoded/decoded by serializers as &quot;BNDU&quot;.
    /// </summary>
    [EnumMember(Value = "BNDU")]
    [IsoId("_IWfwlA-xEeuE0Pnt-OcNOA")]
    [Description(@"Bond check on master table is not available.")]
    BondCheckOnMasterTableNotAvailable,

    /// <summary>
    /// Corporate action event identification is invalid.
    /// Encoded/decoded by serializers as &quot;CAID&quot;.
    /// </summary>
    [EnumMember(Value = "CAID")]
    [IsoId("_IWfwew-xEeuE0Pnt-OcNOA")]
    [Description(@"Corporate action event identification is invalid.")]
    CorporateActionEventInvalid,

    /// <summary>
    /// CUSIP is depository deliver chilled.
    /// Encoded/decoded by serializers as &quot;CHIL&quot;.
    /// </summary>
    [EnumMember(Value = "CHIL")]
    [IsoId("_IWfwqA-xEeuE0Pnt-OcNOA")]
    [Description(@"CUSIP is depository deliver chilled.")]
    CUSIPDepositoryDeliverChilled,

    /// <summary>
    /// Condition 1 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN1R&quot;.
    /// </summary>
    [EnumMember(Value = "CN1R")]
    [IsoId("_IWfwog-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 1 indicator is must be present.")]
    Condition1Required,

    /// <summary>
    /// Condition 2 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN2R&quot;.
    /// </summary>
    [EnumMember(Value = "CN2R")]
    [IsoId("_IWfwow-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 2 indicator is must be present.")]
    Condition2Required,

    /// <summary>
    /// Condition 3 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN3R&quot;.
    /// </summary>
    [EnumMember(Value = "CN3R")]
    [IsoId("_IWfw3Q-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 3 indicator is must be present.")]
    Condition3Required,

    /// <summary>
    /// Condition 4 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN4R&quot;.
    /// </summary>
    [EnumMember(Value = "CN4R")]
    [IsoId("_IWfw0w-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 4 indicator is must be present.")]
    Condition4Required,

    /// <summary>
    /// Condition 5 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN5R&quot;.
    /// </summary>
    [EnumMember(Value = "CN5R")]
    [IsoId("_IWfwmQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 5 indicator is must be present.")]
    Condition5Required,

    /// <summary>
    /// Condition 6 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN6R&quot;.
    /// </summary>
    [EnumMember(Value = "CN6R")]
    [IsoId("_IWfwrA-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 6 indicator is must be present.")]
    Condition6Required,

    /// <summary>
    /// Condition 1 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN1N&quot;.
    /// </summary>
    [EnumMember(Value = "CN1N")]
    [IsoId("_IWfw0g-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 1 indicator is invalid. It must be No.")]
    Condition1InvalidMustBeNo,

    /// <summary>
    /// Condition 2 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN2N&quot;.
    /// </summary>
    [EnumMember(Value = "CN2N")]
    [IsoId("_IWfwwA-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 2 indicator is invalid. It must be No.")]
    Condition2InvalidMustBeNo,

    /// <summary>
    /// Condition 3 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN3N&quot;.
    /// </summary>
    [EnumMember(Value = "CN3N")]
    [IsoId("_IWfwYw-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 3 indicator is invalid. It must be No.")]
    Condition3InvalidMustBeNo,

    /// <summary>
    /// Condition 4 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN4N&quot;.
    /// </summary>
    [EnumMember(Value = "CN4N")]
    [IsoId("_IWfw4A-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 4 indicator is invalid. It must be No.")]
    Condition4InvalidMustBeNo,

    /// <summary>
    /// Condition 5 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN5N&quot;.
    /// </summary>
    [EnumMember(Value = "CN5N")]
    [IsoId("_IWfwvQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 5 indicator is invalid. It must be No.")]
    Condition5InvalidMustBeNo,

    /// <summary>
    /// Condition 6 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN6N&quot;.
    /// </summary>
    [EnumMember(Value = "CN6N")]
    [IsoId("_IWfwfA-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 6 indicator is invalid. It must be No.")]
    Condition6InvalidMustBeNo,

    /// <summary>
    /// Condition 1 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN1Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN1Y")]
    [IsoId("_IWfweQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 1 indicator is invalid. It must be Yes.")]
    Condition1InvalidMustBeYes,

    /// <summary>
    /// Condition 2 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN2Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN2Y")]
    [IsoId("_IWfwyA-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 2 indicator is invalid. It must be Yes.")]
    Condition2InvalidMustBeYes,

    /// <summary>
    /// Condition 3 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN3Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN3Y")]
    [IsoId("_IWfwyQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 3 indicator is invalid. It must be Yes.")]
    Condition3InvalidMustBeYes,

    /// <summary>
    /// Condition 4 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN4Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN4Y")]
    [IsoId("_IWfwhg-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 4 indicator is invalid. It must be Yes.")]
    Condition4InvalidMustBeYes,

    /// <summary>
    /// Condition 5 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN5Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN5Y")]
    [IsoId("_IWfwqQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 5 indicator is invalid. It must be Yes.")]
    Condition5InvalidMustBeYes,

    /// <summary>
    /// Condition 6 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN6Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN6Y")]
    [IsoId("_IWfw4Q-xEeuE0Pnt-OcNOA")]
    [Description(@"Condition 6 indicator is invalid. It must be Yes.")]
    Condition6InvalidMustBeYes,

    /// <summary>
    /// Contact name is missing.
    /// Encoded/decoded by serializers as &quot;CNAM&quot;.
    /// </summary>
    [EnumMember(Value = "CNAM")]
    [IsoId("_IWfwyg-xEeuE0Pnt-OcNOA")]
    [Description(@"Contact name is missing.")]
    ContactNameMissing,

    /// <summary>
    /// Contact name is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNAX&quot;.
    /// </summary>
    [EnumMember(Value = "CNAX")]
    [IsoId("_IWfwgw-xEeuE0Pnt-OcNOA")]
    [Description(@"Contact name is not used with this event.")]
    ContactNameNotUsedWithEvent,

    /// <summary>
    /// Contact phone number is missing.
    /// Encoded/decoded by serializers as &quot;CNPM&quot;.
    /// </summary>
    [EnumMember(Value = "CNPM")]
    [IsoId("_IWfwhw-xEeuE0Pnt-OcNOA")]
    [Description(@"Contact phone number is missing.")]
    ContactPhoneNumberMissing,

    /// <summary>
    /// Contact phone number is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNPX&quot;.
    /// </summary>
    [EnumMember(Value = "CNPX")]
    [IsoId("_IWfwyw-xEeuE0Pnt-OcNOA")]
    [Description(@"Contact phone number is not used with this event.")]
    ContactPhoneNumberNotUsedWithEvent,

    /// <summary>
    /// Comment area is invalid.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_IWfwzA-xEeuE0Pnt-OcNOA")]
    [Description(@"Comment area is invalid.")]
    CommentAreaInvalid,

    /// <summary>
    /// Conditional quantity zeroes are required.
    /// Encoded/decoded by serializers as &quot;COQ0&quot;.
    /// </summary>
    [EnumMember(Value = "COQ0")]
    [IsoId("_IWfwdg-xEeuE0Pnt-OcNOA")]
    [Description(@"Conditional quantity zeroes are required.")]
    ConditionalQuantityZeroesRequired,

    /// <summary>
    /// Conditional quantity exceeds the transaction quantity.
    /// Encoded/decoded by serializers as &quot;COQE&quot;.
    /// </summary>
    [EnumMember(Value = "COQE")]
    [IsoId("_IWfwxA-xEeuE0Pnt-OcNOA")]
    [Description(@"Conditional quantity exceeds the transaction quantity.")]
    ConditionalQuantityExceedsTransactionQuantity,

    /// <summary>
    /// Conditional quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;COQI&quot;.
    /// </summary>
    [EnumMember(Value = "COQI")]
    [IsoId("_IWfwsA-xEeuE0Pnt-OcNOA")]
    [Description(@"Conditional quantity is missing or invalid.")]
    ConditionalQuantityMissingOrInvalid,

    /// <summary>
    /// Conditional quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;COQX&quot;.
    /// </summary>
    [EnumMember(Value = "COQX")]
    [IsoId("_IWfwmg-xEeuE0Pnt-OcNOA")]
    [Description(@"Conditional quantity cannot be zero.")]
    ConditionalQuantityCannotBeZero,

    /// <summary>
    /// Conditional quantity does not equal the transaction quantity whilst this offer accepts only the full conditional quantity.
    /// Encoded/decoded by serializers as &quot;COTQ&quot;.
    /// </summary>
    [EnumMember(Value = "COTQ")]
    [IsoId("_IWfwwg-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Conditional quantity does not equal the transaction quantity whilst this offer accepts only the full conditional quantity."
    )]
    ConditionalQuantityDoesNotEqualTransactionQuantity,

    /// <summary>
    /// Cover quantity is greater than the remaining protect quantity.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_IWfwbw-xEeuE0Pnt-OcNOA")]
    [Description(@"Cover quantity is greater than the remaining protect quantity.")]
    CoverQuantityGreaterThanProtectQuantity,

    /// <summary>
    /// Customer quantities do not add up to total rights quantities.
    /// Encoded/decoded by serializers as &quot;CQRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CQRQ")]
    [IsoId("_IWfwZw-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer quantities do not add up to total rights quantities.")]
    CustomerQuantitiesAndTotalRightsQuantitiesMismatch,

    /// <summary>
    /// Customer sequence number is invalid or out of sequence.
    /// Encoded/decoded by serializers as &quot;CSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSEQ")]
    [IsoId("_IWfwcA-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer sequence number is invalid or out of sequence.")]
    CustomerSequenceNumberInvalid,

    /// <summary>
    /// Customer identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_IWfwzg-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer identification is missing or invalid.")]
    CustomerIdentificationMissingOrInvalid,

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;CUSD&quot;.
    /// </summary>
    [EnumMember(Value = "CUSD")]
    [IsoId("_IWfwZg-xEeuE0Pnt-OcNOA")]
    [Description(@"Target CUSIP or contra CUSIP identification is not DTC eligible.")]
    CUSIPNotDTCEligible,

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUSI&quot;.
    /// </summary>
    [EnumMember(Value = "CUSI")]
    [IsoId("_IWfwsQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Target CUSIP or contra CUSIP identification is missing or invalid.")]
    CUSIPMissingOrInvalid,

    /// <summary>
    /// Underlying security CUSIP is invalid.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_IWfwkQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Underlying security CUSIP is invalid.")]
    UnderlyingSecurityCUSIPInvalid,

    /// <summary>
    /// Underlying security CUSIP does not match the original.
    /// Encoded/decoded by serializers as &quot;CUSU&quot;.
    /// </summary>
    [EnumMember(Value = "CUSU")]
    [IsoId("_IWfwiQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Underlying security CUSIP does not match the original.")]
    UnderlyingSecurityCUSIPMismatch,

    /// <summary>
    /// Cut-off time check has failed.
    /// Encoded/decoded by serializers as &quot;CUTC&quot;.
    /// </summary>
    [EnumMember(Value = "CUTC")]
    [IsoId("_IWfwlQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Cut-off time check has failed.")]
    CutoffTimeCheckFailed,

    /// <summary>
    /// Cut-off time has passed.
    /// Encoded/decoded by serializers as &quot;CUTT&quot;.
    /// </summary>
    [EnumMember(Value = "CUTT")]
    [IsoId("_IWfwrg-xEeuE0Pnt-OcNOA")]
    [Description(@"Cut-off time has passed.")]
    CutoffTimePassed,

    /// <summary>
    /// Entry date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_IWfwzw-xEeuE0Pnt-OcNOA")]
    [Description(@"Entry date must be less than or equal to current date.")]
    EntryDatePassed,

    /// <summary>
    /// Entry date is invalid.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_IWfwmw-xEeuE0Pnt-OcNOA")]
    [Description(@"Entry date is invalid.")]
    EntryDateInvalid,

    /// <summary>
    /// Customer has fractional underlying quantity, adjust quantity.
    /// Encoded/decoded by serializers as &quot;FRAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FRAQ")]
    [IsoId("_IWfwmA-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer has fractional underlying quantity, adjust quantity.")]
    FractionalUnderlyingQuantity,

    /// <summary>
    /// Transaction type or withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_IWWm-Q-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction type or withdrawal transaction type is invalid.")]
    TransactionTypeInvalid,

    /// <summary>
    /// Function is not available at this time. Please check expiration start and end times for the event.
    /// Encoded/decoded by serializers as &quot;FUNU&quot;.
    /// </summary>
    [EnumMember(Value = "FUNU")]
    [IsoId("_IWfwig-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Function is not available at this time. Please check expiration start and end times for the event."
    )]
    FunctionNotAvailable,

    /// <summary>
    /// Offer is already on historical data base.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_IWfwag-xEeuE0Pnt-OcNOA")]
    [Description(@"Offer is already on historical data base.")]
    OfferInDatabase,

    /// <summary>
    /// Key information is missing (tenders data).
    /// Encoded/decoded by serializers as &quot;KEYM&quot;.
    /// </summary>
    [EnumMember(Value = "KEYM")]
    [IsoId("_IWfw4g-xEeuE0Pnt-OcNOA")]
    [Description(@"Key information is missing (tenders data).")]
    KeyInformationMissing,

    /// <summary>
    /// Key data (VOI transaction) cannot be found.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_IWfwrQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Key data (VOI transaction) cannot be found.")]
    KeyDataNotFound,

    /// <summary>
    /// Participant has an insufficient position.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_IWfwfg-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant has an insufficient position.")]
    InsufficientPosition,

    /// <summary>
    /// Master tables are not available.
    /// Encoded/decoded by serializers as &quot;MSTB&quot;.
    /// </summary>
    [EnumMember(Value = "MSTB")]
    [IsoId("_IWfw1Q-xEeuE0Pnt-OcNOA")]
    [Description(@"Master tables are not available.")]
    MasterTablesNotAvailable,

    /// <summary>
    /// There is no withdrawal privilege on this offer.
    /// Encoded/decoded by serializers as &quot;NWIT&quot;.
    /// </summary>
    [EnumMember(Value = "NWIT")]
    [IsoId("_IWfwqg-xEeuE0Pnt-OcNOA")]
    [Description(@"There is no withdrawal privilege on this offer.")]
    NoWithdrawalPrivilege,

    /// <summary>
    /// Odd lot indicator is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ODLI&quot;.
    /// </summary>
    [EnumMember(Value = "ODLI")]
    [IsoId("_IWfwwQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Odd lot indicator is missing or invalid.")]
    OddLotIndicatorMissingOrInvalid,

    /// <summary>
    /// Cannot submit odd lot indicator &apos;Yes&apos; for the offer.
    /// Encoded/decoded by serializers as &quot;ODLY&quot;.
    /// </summary>
    [EnumMember(Value = "ODLY")]
    [IsoId("_IWfw0Q-xEeuE0Pnt-OcNOA")]
    [Description(@"Cannot submit odd lot indicator 'Yes' for the offer.")]
    OddLotIndicatorYesInvalid,

    /// <summary>
    /// Offer is not eligible for the PUTS function.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_IWfwaw-xEeuE0Pnt-OcNOA")]
    [Description(@"Offer is not eligible for the PUTS function.")]
    OfferNotEligibleForPuts,

    /// <summary>
    /// Rejection reason is unknown.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IWfwdw-xEeuE0Pnt-OcNOA")]
    [Description(@"Rejection reason is unknown.")]
    UnknownErrorCondition,

    /// <summary>
    /// Customer oversubscription quantities do not add up to total oversubscription quantity.
    /// Encoded/decoded by serializers as &quot;OVCU&quot;.
    /// </summary>
    [EnumMember(Value = "OVCU")]
    [IsoId("_IWfw0A-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Customer oversubscription quantities do not add up to total oversubscription quantity."
    )]
    CustomerAndTotalOversubscriptionQuantitiesMismatch,

    /// <summary>
    /// Oversubscription quantity is greater than percentage of underlying shares.
    /// Encoded/decoded by serializers as &quot;OVRG&quot;.
    /// </summary>
    [EnumMember(Value = "OVRG")]
    [IsoId("_IWfwnQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Oversubscription quantity is greater than percentage of underlying shares.")]
    OversubscriptionQuantityExceeded,

    /// <summary>
    /// Oversubscription quantity is invalid.
    /// Encoded/decoded by serializers as &quot;OVRI&quot;.
    /// </summary>
    [EnumMember(Value = "OVRI")]
    [IsoId("_IWWm-g-xEeuE0Pnt-OcNOA")]
    [Description(@"Oversubscription quantity is invalid.")]
    OversubscriptionQuantityInvalid,

    /// <summary>
    /// Oversubscription is not allowed.
    /// Encoded/decoded by serializers as &quot;OVRX&quot;.
    /// </summary>
    [EnumMember(Value = "OVRX")]
    [IsoId("_IWfwgA-xEeuE0Pnt-OcNOA")]
    [Description(@"Oversubscription is not allowed.")]
    OversubscriptionNotAllowed,

    /// <summary>
    /// Oversubscription quantity not used with this transaction type.
    /// Encoded/decoded by serializers as &quot;OVTT&quot;.
    /// </summary>
    [EnumMember(Value = "OVTT")]
    [IsoId("_IWfwkg-xEeuE0Pnt-OcNOA")]
    [Description(@"Oversubscription quantity not used with this transaction type.")]
    OversubscriptionQuantityNotUsed,

    /// <summary>
    /// Participant is DO chilled.
    /// Encoded/decoded by serializers as &quot;PACH&quot;.
    /// </summary>
    [EnumMember(Value = "PACH")]
    [IsoId("_IWfwYA-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant is DO chilled.")]
    ParticipantDOChilled,

    /// <summary>
    /// Participant eligibility check on master table is not available.
    /// Encoded/decoded by serializers as &quot;PAEC&quot;.
    /// </summary>
    [EnumMember(Value = "PAEC")]
    [IsoId("_IWfwpA-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant eligibility check on master table is not available.")]
    ParticipantEligibilityCheckNotAvailable,

    /// <summary>
    /// Participant does not match the participant on protect identification.
    /// Encoded/decoded by serializers as &quot;PAPI&quot;.
    /// </summary>
    [EnumMember(Value = "PAPI")]
    [IsoId("_IWfwoA-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant does not match the participant on protect identification.")]
    ParticipantNoMatchOnProtectIdentification,

    /// <summary>
    /// Participant is globally locked.
    /// Encoded/decoded by serializers as &quot;PARL&quot;.
    /// </summary>
    [EnumMember(Value = "PARL")]
    [IsoId("_IWfwYg-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant is globally locked.")]
    ParticipantLocked,

    /// <summary>
    /// Participant number is invalid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_IWfwaA-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant number is invalid.")]
    ParticipantNumberInvalid,

    /// <summary>
    /// Participant is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;PARX&quot;.
    /// </summary>
    [EnumMember(Value = "PARX")]
    [IsoId("_IWfwuA-xEeuE0Pnt-OcNOA")]
    [Description(@"Participant is not DTC eligible.")]
    ParticipantNotEligible,

    /// <summary>
    /// Protect date on file must be zero.
    /// Encoded/decoded by serializers as &quot;PRO0&quot;.
    /// </summary>
    [EnumMember(Value = "PRO0")]
    [IsoId("_IWfwgg-xEeuE0Pnt-OcNOA")]
    [Description(@"Protect date on file must be zero.")]
    ProtectDateZero,

    /// <summary>
    /// Current date is greater than the protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROE&quot;.
    /// </summary>
    [EnumMember(Value = "PROE")]
    [IsoId("_IWfwlg-xEeuE0Pnt-OcNOA")]
    [Description(@"Current date is greater than the protect submission end date.")]
    CurrentDatePassedProtectSubmissionEndDate,

    /// <summary>
    /// Protect date invalid or missing.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_IWfw1w-xEeuE0Pnt-OcNOA")]
    [Description(@"Protect date invalid or missing.")]
    ProtectDateInvalidOrMissing,

    /// <summary>
    /// Protect date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;PROL&quot;.
    /// </summary>
    [EnumMember(Value = "PROL")]
    [IsoId("_IWfwcQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Protect date must be less than or equal to current date.")]
    ProtectDatePassed,

    /// <summary>
    /// Current date is less than the protect submission start date.
    /// Encoded/decoded by serializers as &quot;PROS&quot;.
    /// </summary>
    [EnumMember(Value = "PROS")]
    [IsoId("_IWfwZA-xEeuE0Pnt-OcNOA")]
    [Description(@"Current date is less than the protect submission start date.")]
    CurrentDatePrecedesProtectSubmissionStartDate,

    /// <summary>
    /// Protect identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_IWfwnw-xEeuE0Pnt-OcNOA")]
    [Description(@"Protect identification is missing or invalid.")]
    ProtectIdentificationMissingOrInvalid,

    /// <summary>
    /// Protect identification is not used with this event.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_IWfw2w-xEeuE0Pnt-OcNOA")]
    [Description(@"Protect identification is not used with this event.")]
    ProtectIdentificationNotUsed,

    /// <summary>
    /// Function is quiesced (not available).
    /// Encoded/decoded by serializers as &quot;QUIE&quot;.
    /// </summary>
    [EnumMember(Value = "QUIE")]
    [IsoId("_IWfw3A-xEeuE0Pnt-OcNOA")]
    [Description(@"Function is quiesced (not available).")]
    FunctionQuiesced,

    /// <summary>
    /// Record type is invalid.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_IWfwcg-xEeuE0Pnt-OcNOA")]
    [Description(@"Record type is invalid.")]
    RecordTypeInvalid,

    /// <summary>
    /// Rights CUSIP has insufficient position.
    /// Encoded/decoded by serializers as &quot;RILA&quot;.
    /// </summary>
    [EnumMember(Value = "RILA")]
    [IsoId("_IWfw3w-xEeuE0Pnt-OcNOA")]
    [Description(@"Rights CUSIP has insufficient position.")]
    RightsCUSIPInsufficientPosition,

    /// <summary>
    /// Not a good return code from rights position check.
    /// Encoded/decoded by serializers as &quot;RPCI&quot;.
    /// </summary>
    [EnumMember(Value = "RPCI")]
    [IsoId("_IWfwvg-xEeuE0Pnt-OcNOA")]
    [Description(@"Not a good return code from rights position check.")]
    RightsPositionCheckInvalid,

    /// <summary>
    /// Rights quantity for this subscription must be divisible by rights.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("_IWfw4w-xEeuE0Pnt-OcNOA")]
    [Description(@"Rights quantity for this subscription must be divisible by rights.")]
    RightsQuantityDivisibleByRights,

    /// <summary>
    /// Rights quantity is invalid.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("_IWfwhA-xEeuE0Pnt-OcNOA")]
    [Description(@"Rights quantity is invalid.")]
    RightsQuantityInvalid,

    /// <summary>
    /// Rights ratio not found on data base.
    /// Encoded/decoded by serializers as &quot;RTIO&quot;.
    /// </summary>
    [EnumMember(Value = "RTIO")]
    [IsoId("_IWfwbA-xEeuE0Pnt-OcNOA")]
    [Description(@"Rights ratio not found on data base.")]
    RightsRatioNotFound,

    /// <summary>
    /// RTS processing is in progress. Submit later.
    /// Encoded/decoded by serializers as &quot;RTSP&quot;.
    /// </summary>
    [EnumMember(Value = "RTSP")]
    [IsoId("_IWfwgQ-xEeuE0Pnt-OcNOA")]
    [Description(@"RTS processing is in progress. Submit later.")]
    RTSProcessingInProgress,

    /// <summary>
    /// Customer sequence number must be all zero.
    /// Encoded/decoded by serializers as &quot;SEQ0&quot;.
    /// </summary>
    [EnumMember(Value = "SEQ0")]
    [IsoId("_IWfwpg-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer sequence number must be all zero.")]
    CustomerSequenceNumberAllZero,

    /// <summary>
    /// Transaction sequence number is duplicated.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_IWfwhQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction sequence number is duplicated.")]
    DuplicateTransactionSequenceNumber,

    /// <summary>
    /// Sequence number is missing.
    /// Encoded/decoded by serializers as &quot;SEQM&quot;.
    /// </summary>
    [EnumMember(Value = "SEQM")]
    [IsoId("_IWfw5A-xEeuE0Pnt-OcNOA")]
    [Description(@"Sequence number is missing.")]
    SequenceNumberMissing,

    /// <summary>
    /// Sequence number is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_IWfwlw-xEeuE0Pnt-OcNOA")]
    [Description(@"Sequence number is out of sequence.")]
    SequenceNumberOutOfSync,

    /// <summary>
    /// Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.
    /// Encoded/decoded by serializers as &quot;SEQP&quot;.
    /// </summary>
    [EnumMember(Value = "SEQP")]
    [IsoId("_IWfwdQ-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912."
    )]
    SequenceNumberInvalidBounds,

    /// <summary>
    /// Underlying share quantity is invalid.
    /// Encoded/decoded by serializers as &quot;SHQI&quot;.
    /// </summary>
    [EnumMember(Value = "SHQI")]
    [IsoId("_IWfwuQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Underlying share quantity is invalid.")]
    UnderlyingShareQuantityInvalid,

    /// <summary>
    /// Underlying share quantity does not match original share quantity.
    /// Encoded/decoded by serializers as &quot;SHQO&quot;.
    /// </summary>
    [EnumMember(Value = "SHQO")]
    [IsoId("_IWfwsg-xEeuE0Pnt-OcNOA")]
    [Description(@"Underlying share quantity does not match original share quantity.")]
    UnderlyingShareQuantityMismatch,

    /// <summary>
    /// Comments are required for solicitation fee.
    /// Encoded/decoded by serializers as &quot;SOCR&quot;.
    /// </summary>
    [EnumMember(Value = "SOCR")]
    [IsoId("_IWfwaQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Comments are required for solicitation fee.")]
    SolicitationFeeCommentsRequired,

    /// <summary>
    /// Solicitation fee indicator is required.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("_IWfwiw-xEeuE0Pnt-OcNOA")]
    [Description(@"Solicitation fee indicator is required.")]
    SolicitationFeeIndicatorRequired,

    /// <summary>
    /// Solicitation fee indicator is not used with this event.
    /// Encoded/decoded by serializers as &quot;SOLX&quot;.
    /// </summary>
    [EnumMember(Value = "SOLX")]
    [IsoId("_IWfwrw-xEeuE0Pnt-OcNOA")]
    [Description(@"Solicitation fee indicator is not used with this event.")]
    SolicitationFeeIndicatorNotUsed,

    /// <summary>
    /// Submission date is not yet reached.
    /// Encoded/decoded by serializers as &quot;SUBE&quot;.
    /// </summary>
    [EnumMember(Value = "SUBE")]
    [IsoId("_IWfwpQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Submission date is not yet reached.")]
    SubmissionDateNotReached,

    /// <summary>
    /// Date of submission has passed.
    /// Encoded/decoded by serializers as &quot;SUBL&quot;.
    /// </summary>
    [EnumMember(Value = "SUBL")]
    [IsoId("_IWfweg-xEeuE0Pnt-OcNOA")]
    [Description(@"Date of submission has passed.")]
    SubmissionDatePassed,

    /// <summary>
    /// Transaction type and event are incompatible.
    /// Encoded/decoded by serializers as &quot;TNFN&quot;.
    /// </summary>
    [EnumMember(Value = "TNFN")]
    [IsoId("_IWfwxw-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction type and event are incompatible.")]
    TransactionTypeAndEventIncompatible,

    /// <summary>
    /// Transaction identification is invalid.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_IWfwzQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction identification is invalid.")]
    TransactionIdentificationInvalid,

    /// <summary>
    /// Transaction type is missing.
    /// Encoded/decoded by serializers as &quot;TRNM&quot;.
    /// </summary>
    [EnumMember(Value = "TRNM")]
    [IsoId("_IWfwxQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction type is missing.")]
    TransactionTypeMissing,

    /// <summary>
    /// Transaction sequence is invalid. Used only for rights exercise events.
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_IWfwjg-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction sequence is invalid. Used only for rights exercise events.")]
    TransactionSequenceInvalid,

    /// <summary>
    /// Transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;TRQ0&quot;.
    /// </summary>
    [EnumMember(Value = "TRQ0")]
    [IsoId("_IWfw1g-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction quantity cannot be zero.")]
    TransactionQuantityCannotBeZero,

    /// <summary>
    /// Transaction quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;TRQI&quot;.
    /// </summary>
    [EnumMember(Value = "TRQI")]
    [IsoId("_IWfwvw-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction quantity is missing or invalid.")]
    TransactionQuantityMissingOrInvalid,

    /// <summary>
    /// Transaction quantity is less than the transaction minimum.
    /// Encoded/decoded by serializers as &quot;TRQM&quot;.
    /// </summary>
    [EnumMember(Value = "TRQM")]
    [IsoId("_IWfwfQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Transaction quantity is less than the transaction minimum.")]
    TransactionQuantityLessThanTransactionMinimum,

    /// <summary>
    /// Provided by protect, enter 0 for transaction quantity.
    /// Encoded/decoded by serializers as &quot;TRQP&quot;.
    /// </summary>
    [EnumMember(Value = "TRQP")]
    [IsoId("_IWfwZQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Provided by protect, enter 0 for transaction quantity.")]
    ProvidedByProtect,

    /// <summary>
    /// Withdrawal transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;WIT0&quot;.
    /// </summary>
    [EnumMember(Value = "WIT0")]
    [IsoId("_IWfwtw-xEeuE0Pnt-OcNOA")]
    [Description(@"Withdrawal transaction quantity cannot be zero.")]
    WithdrawalTransactionQuantityCannotBeZero,

    /// <summary>
    /// Error in withdraw occurred.
    /// Encoded/decoded by serializers as &quot;WITE&quot;.
    /// </summary>
    [EnumMember(Value = "WITE")]
    [IsoId("_IWfwbQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Error in withdraw occurred.")]
    WithdrawError,

    /// <summary>
    /// Withdrawal quantity is greater than VOI/protect quantity.
    /// Encoded/decoded by serializers as &quot;WITG&quot;.
    /// </summary>
    [EnumMember(Value = "WITG")]
    [IsoId("_IWfwfw-xEeuE0Pnt-OcNOA")]
    [Description(@"Withdrawal quantity is greater than VOI/protect quantity.")]
    WithdrawalQuantityGreaterThanProtectQuantity,

    /// <summary>
    /// Withdrawal quantity exceeds the remaining quantity.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_IWfwtA-xEeuE0Pnt-OcNOA")]
    [Description(@"Withdrawal quantity exceeds the remaining quantity.")]
    WithdrawalQuantityExceedsRemainingQuantity,

    /// <summary>
    /// Beneficial owner name is missing.
    /// Encoded/decoded by serializers as &quot;BONM&quot;.
    /// </summary>
    [EnumMember(Value = "BONM")]
    [IsoId("_IWfwww-xEeuE0Pnt-OcNOA")]
    [Description(@"Beneficial owner name is missing.")]
    BeneficialOwnerNameMissing,

    /// <summary>
    /// Beneficial owner death date is missing.
    /// Encoded/decoded by serializers as &quot;BODD&quot;.
    /// </summary>
    [EnumMember(Value = "BODD")]
    [IsoId("_IWfwkw-xEeuE0Pnt-OcNOA")]
    [Description(@"Beneficial owner death date is missing.")]
    BeneficialOwnerDeathDateMissing,

    /// <summary>
    /// Death certificate details are missing.
    /// Encoded/decoded by serializers as &quot;BODC&quot;.
    /// </summary>
    [EnumMember(Value = "BODC")]
    [IsoId("_IWfw2A-xEeuE0Pnt-OcNOA")]
    [Description(@"Death certificate details are missing.")]
    DeathCertificateMissing,

    /// <summary>
    /// Issuing jurisdiction is missing.
    /// Encoded/decoded by serializers as &quot;BOIJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOIJ")]
    [IsoId("_IWfwxg-xEeuE0Pnt-OcNOA")]
    [Description(@"Issuing jurisdiction is missing.")]
    IssuingJurisdictionMissing,

    /// <summary>
    /// Certificate number is invalid.
    /// Encoded/decoded by serializers as &quot;CERN&quot;.
    /// </summary>
    [EnumMember(Value = "CERN")]
    [IsoId("_IWfwug-xEeuE0Pnt-OcNOA")]
    [Description(@"Certificate number is invalid.")]
    CertificateNumberInvalid,

    /// <summary>
    /// Certificate sequence number is invalid.
    /// Encoded/decoded by serializers as &quot;CERS&quot;.
    /// </summary>
    [EnumMember(Value = "CERS")]
    [IsoId("_IWfwiA-xEeuE0Pnt-OcNOA")]
    [Description(@"Certificate sequence number is invalid.")]
    CertificateSequenceNumberInvalid,

    /// <summary>
    /// Certificate number is missing.
    /// Encoded/decoded by serializers as &quot;CENM&quot;.
    /// </summary>
    [EnumMember(Value = "CENM")]
    [IsoId("_IWfwcw-xEeuE0Pnt-OcNOA")]
    [Description(@"Certificate number is missing.")]
    CertificateNameMissing,

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;ADIN&quot;.
    /// </summary>
    [EnumMember(Value = "ADIN")]
    [IsoId("_IWfwYQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is invalid.")]
    AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("_IWfwjw-xEeuE0Pnt-OcNOA")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is missing.")]
    AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing,

    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;LEGI&quot;.
    /// </summary>
    [EnumMember(Value = "LEGI")]
    [IsoId("_IWfw2Q-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Legal documentation thirty months retention acknowledgement indicator is invalid."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;LEGM&quot;.
    /// </summary>
    [EnumMember(Value = "LEGM")]
    [IsoId("_IWfwkA-xEeuE0Pnt-OcNOA")]
    [Description(
        @"Legal documentation thirty months retention acknowledgement indicator is missing."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing,

    /// <summary>
    /// Instruction deletion acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_IWfwvA-xEeuE0Pnt-OcNOA")]
    [Description(@"Instruction deletion acknowledgement indicator is invalid.")]
    InstructionDeletionAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Instruction deletion acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_IWfwuw-xEeuE0Pnt-OcNOA")]
    [Description(@"Instruction deletion acknowledgement indicator is missing.")]
    InstructionDeletionAcknowledgementIndicatorMissing,

    /// <summary>
    /// Potential loss acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;POLI&quot;.
    /// </summary>
    [EnumMember(Value = "POLI")]
    [IsoId("_IWfwqw-xEeuE0Pnt-OcNOA")]
    [Description(@"Potential loss acknowledgement indicator is invalid.")]
    PotentialLossAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Potential loss acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;POLM&quot;.
    /// </summary>
    [EnumMember(Value = "POLM")]
    [IsoId("_IWfw2g-xEeuE0Pnt-OcNOA")]
    [Description(@"Potential loss acknowledgement indicator is missing.")]
    PotentialLossAcknowledgementIndicatorMissing,

    /// <summary>
    /// Warrant subscription charge amount is not balancing.
    /// Encoded/decoded by serializers as &quot;WARC&quot;.
    /// </summary>
    [EnumMember(Value = "WARC")]
    [IsoId("_IWfwoQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Warrant subscription charge amount is not balancing.")]
    WarrantSubscriptionChargeAmountInvalid,

    /// <summary>
    /// There is a summary difference between the core instruction quantity and the extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUME&quot;.
    /// </summary>
    [EnumMember(Value = "SUME")]
    [IsoId("_IWfwng-xEeuE0Pnt-OcNOA")]
    [Description(
        @"There is a summary difference between the core instruction quantity and the extension transaction details."
    )]
    CoreInstructionQuantityAndExtensionTransactionDetailsDifference,

    /// <summary>
    /// There is summary difference between core oversubscription quantity and extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUMO&quot;.
    /// </summary>
    [EnumMember(Value = "SUMO")]
    [IsoId("_IWfw1A-xEeuE0Pnt-OcNOA")]
    [Description(
        @"There is summary difference between core oversubscription quantity and extension transaction details."
    )]
    CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference,

    /// <summary>
    /// Withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;WITI&quot;.
    /// </summary>
    [EnumMember(Value = "WITI")]
    [IsoId("_IWfwtg-xEeuE0Pnt-OcNOA")]
    [Description(@"Withdrawal transaction type is invalid.")]
    WithdrawalTransactionTypeInvalid,

    /// <summary>
    /// Current date has passed cover protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_IWfwbg-xEeuE0Pnt-OcNOA")]
    [Description(@"Current date has passed cover protect submission end date.")]
    PassedProtectSubmissionEndDate,

    /// <summary>
    /// Customer reference identification must be populated for each sequence.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_IWfwjQ-xEeuE0Pnt-OcNOA")]
    [Description(@"Customer reference identification must be populated for each sequence.")]
    CustomerReferenceIdentificationMissingInSequence,

    /// <summary>
    /// Corporate action event type provided is not valid.
    /// Encoded/decoded by serializers as &quot;EVNT&quot;.
    /// </summary>
    [EnumMember(Value = "EVNT")]
    [IsoId("_SMu2gBRjEeu0TObkeMykfg")]
    [Description(@"Corporate action event type provided is not valid.")]
    CorporateActionEventTypeInvalid,

    /// <summary>
    /// Instructions are not released.
    /// Encoded/decoded by serializers as &quot;RTOP&quot;.
    /// </summary>
    [EnumMember(Value = "RTOP")]
    [IsoId("_b4iOIDDvEey2N-DB7H7A5A")]
    [Description(@"Instructions are not released.")]
    InstructionsNotReleased,

    /// <summary>
    /// Is not approved by the subscription agent.
    /// Encoded/decoded by serializers as &quot;ASOP&quot;.
    /// </summary>
    [EnumMember(Value = "ASOP")]
    [IsoId("_WIeUcDyqEeymFudlWrxhpw")]
    [Description(@"Is not approved by the subscription agent.")]
    NotApprovedBySubscriptionAgent,

    /// <summary>
    /// Event type is not valid.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_3wq-oVCBEe2KGNXAcFL5RA")]
    [Description(@"Event type is not valid.")]
    InvalidEventType,

    /// <summary>
    /// Option number is not valid.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_ApLQYlCCEe2KGNXAcFL5RA")]
    [Description(@"Option number is not valid.")]
    InvalidOptionNumber,

    /// <summary>
    /// Option type is not valid.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_ApLQY1CCEe2KGNXAcFL5RA")]
    [Description(@"Option type is not valid.")]
    InvalidOptionType,

    /// <summary>
    /// Not eligible for withdrawal, not in made status
    /// Encoded/decoded by serializers as &quot;NELG&quot;.
    /// </summary>
    [EnumMember(Value = "NELG")]
    [IsoId("_OkJWcVCCEe2KGNXAcFL5RA")]
    [Description(@"Not eligible for withdrawal, not in made status")]
    NotEligibleForWithdrawal,

    /// <summary>
    /// Event already allocated.
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_jEsCUFCCEe2KGNXAcFL5RA")]
    [Description(@"Event already allocated.")]
    EventAlreadyAllocated,
}
