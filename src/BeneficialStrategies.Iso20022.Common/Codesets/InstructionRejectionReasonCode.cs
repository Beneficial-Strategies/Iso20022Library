// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for rejection of a corporate action instruction or of an instruction cancellation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vvgkkMYMEeexPc-mfUU5zQ")]
[Description(
    @"Reason for rejection of a corporate action instruction or of an instruction cancellation."
)]
[Derivations(typeof(InstructionRejectionReason1Code), typeof(InstructionRejectionReason2Code))]
public enum InstructionRejectionReasonCode
{
    /// <summary>
    /// Acknowledgement must be agreed.
    /// Encoded/decoded by serializers as &quot;ACKA&quot;.
    /// </summary>
    [EnumMember(Value = "ACKA")]
    [IsoId("_FXGYEMYNEeexPc-mfUU5zQ")]
    [Description(@"Acknowledgement must be agreed.")]
    AcknowledgementNotAgreed,

    /// <summary>
    /// Acknowledgment indicator is missing.
    /// Encoded/decoded by serializers as &quot;ACKS&quot;.
    /// </summary>
    [EnumMember(Value = "ACKS")]
    [IsoId("_0LkJ4MhhEee7W-rN1yqPMg")]
    [Description(@"Acknowledgment indicator is missing.")]
    AcknowledgmentIndicatorMissing,

    /// <summary>
    /// Offer is not ATOP eligible.
    /// Encoded/decoded by serializers as &quot;ATOP&quot;.
    /// </summary>
    [EnumMember(Value = "ATOP")]
    [IsoId("_2sGM8MhhEee7W-rN1yqPMg")]
    [Description(@"Offer is not ATOP eligible.")]
    OfferNotATOPEligible,

    /// <summary>
    /// Zeroes are required for bid price.
    /// Encoded/decoded by serializers as &quot;BID0&quot;.
    /// </summary>
    [EnumMember(Value = "BID0")]
    [IsoId("_2vqeUMhhEee7W-rN1yqPMg")]
    [Description(@"Zeroes are required for bid price.")]
    BidPriceZeroesRequired,

    /// <summary>
    /// Bid Price exceeds maximum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDE&quot;.
    /// </summary>
    [EnumMember(Value = "BIDE")]
    [IsoId("_2yfI0MhhEee7W-rN1yqPMg")]
    [Description(@"Bid Price exceeds maximum bid price allowed for the offer.")]
    BidPriceOverMaximumAllowed,

    /// <summary>
    /// Bid Price cannot be greater than 9999.99999.
    /// Encoded/decoded by serializers as &quot;BIDG&quot;.
    /// </summary>
    [EnumMember(Value = "BIDG")]
    [IsoId("_20t9cMhhEee7W-rN1yqPMg")]
    [Description(@"Bid Price cannot be greater than 9999.99999.")]
    BidPriceOverflow,

    /// <summary>
    /// Bid price is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_23sY8MhhEee7W-rN1yqPMg")]
    [Description(@"Bid price is missing or invalid.")]
    BidPriceMissingOrInvalid,

    /// <summary>
    /// Bid Price is less than the minimum bid price allowed for the offer.
    /// Encoded/decoded by serializers as &quot;BIDM&quot;.
    /// </summary>
    [EnumMember(Value = "BIDM")]
    [IsoId("_257NkMhhEee7W-rN1yqPMg")]
    [Description(@"Bid Price is less than the minimum bid price allowed for the offer.")]
    BidPriceUnderMinimumAllowed,

    /// <summary>
    /// Bond check on master table is not available.
    /// Encoded/decoded by serializers as &quot;BNDU&quot;.
    /// </summary>
    [EnumMember(Value = "BNDU")]
    [IsoId("_28A4QMhhEee7W-rN1yqPMg")]
    [Description(@"Bond check on master table is not available.")]
    BondCheckOnMasterTableNotAvailable,

    /// <summary>
    /// Corporate action event identification is invalid.
    /// Encoded/decoded by serializers as &quot;CAID&quot;.
    /// </summary>
    [EnumMember(Value = "CAID")]
    [IsoId("_2-Ps4MhhEee7W-rN1yqPMg")]
    [Description(@"Corporate action event identification is invalid.")]
    CorporateActionEventInvalid,

    /// <summary>
    /// CUSIP is depository deliver chilled.
    /// Encoded/decoded by serializers as &quot;CHIL&quot;.
    /// </summary>
    [EnumMember(Value = "CHIL")]
    [IsoId("_3AehgMhhEee7W-rN1yqPMg")]
    [Description(@"CUSIP is depository deliver chilled.")]
    CUSIPDepositoryDeliverChilled,

    /// <summary>
    /// Condition 1 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN1R&quot;.
    /// </summary>
    [EnumMember(Value = "CN1R")]
    [IsoId("_76E8oMiAEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is must be present.")]
    Condition1Required,

    /// <summary>
    /// Condition 2 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN2R&quot;.
    /// </summary>
    [EnumMember(Value = "CN2R")]
    [IsoId("_Vdr5wMiBEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is must be present.")]
    Condition2Required,

    /// <summary>
    /// Condition 3 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN3R&quot;.
    /// </summary>
    [EnumMember(Value = "CN3R")]
    [IsoId("_ViAZEMiBEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is must be present.")]
    Condition3Required,

    /// <summary>
    /// Condition 4 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN4R&quot;.
    /// </summary>
    [EnumMember(Value = "CN4R")]
    [IsoId("_VmBWYMiBEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is must be present.")]
    Condition4Required,

    /// <summary>
    /// Condition 5 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN5R&quot;.
    /// </summary>
    [EnumMember(Value = "CN5R")]
    [IsoId("_VqMEsMiBEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is must be present.")]
    Condition5Required,

    /// <summary>
    /// Condition 6 indicator is must be present.
    /// Encoded/decoded by serializers as &quot;CN6R&quot;.
    /// </summary>
    [EnumMember(Value = "CN6R")]
    [IsoId("_Vuy34MiBEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is must be present.")]
    Condition6Required,

    /// <summary>
    /// Condition 1 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN1N&quot;.
    /// </summary>
    [EnumMember(Value = "CN1N")]
    [IsoId("_z_hrcMiBEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is invalid. It must be No.")]
    Condition1InvalidMustBeNo,

    /// <summary>
    /// Condition 2 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN2N&quot;.
    /// </summary>
    [EnumMember(Value = "CN2N")]
    [IsoId("_E8-rEMiCEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is invalid. It must be No.")]
    Condition2InvalidMustBeNo,

    /// <summary>
    /// Condition 3 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN3N&quot;.
    /// </summary>
    [EnumMember(Value = "CN3N")]
    [IsoId("_FBleQMiCEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is invalid. It must be No.")]
    Condition3InvalidMustBeNo,

    /// <summary>
    /// Condition 4 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN4N&quot;.
    /// </summary>
    [EnumMember(Value = "CN4N")]
    [IsoId("_FFwMkMiCEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is invalid. It must be No.")]
    Condition4InvalidMustBeNo,

    /// <summary>
    /// Condition 5 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN5N&quot;.
    /// </summary>
    [EnumMember(Value = "CN5N")]
    [IsoId("_FJxJ4MiCEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is invalid. It must be No.")]
    Condition5InvalidMustBeNo,

    /// <summary>
    /// Condition 6 indicator is invalid. It must be No.
    /// Encoded/decoded by serializers as &quot;CN6N&quot;.
    /// </summary>
    [EnumMember(Value = "CN6N")]
    [IsoId("_FNo9QMiCEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is invalid. It must be No.")]
    Condition6InvalidMustBeNo,

    /// <summary>
    /// Condition 1 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN1Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN1Y")]
    [IsoId("_TPyCUMiCEee7W-rN1yqPMg")]
    [Description(@"Condition 1 indicator is invalid. It must be Yes.")]
    Condition1InvalidMustBeYes,

    /// <summary>
    /// Condition 2 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN2Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN2Y")]
    [IsoId("_B6ZmsMiJEee7W-rN1yqPMg")]
    [Description(@"Condition 2 indicator is invalid. It must be Yes.")]
    Condition2InvalidMustBeYes,

    /// <summary>
    /// Condition 3 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN3Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN3Y")]
    [IsoId("_B-3P8MiJEee7W-rN1yqPMg")]
    [Description(@"Condition 3 indicator is invalid. It must be Yes.")]
    Condition3InvalidMustBeYes,

    /// <summary>
    /// Condition 4 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN4Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN4Y")]
    [IsoId("_CC4NQMiJEee7W-rN1yqPMg")]
    [Description(@"Condition 4 indicator is invalid. It must be Yes.")]
    Condition4InvalidMustBeYes,

    /// <summary>
    /// Condition 5 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN5Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN5Y")]
    [IsoId("_CHC7kMiJEee7W-rN1yqPMg")]
    [Description(@"Condition 5 indicator is invalid. It must be Yes.")]
    Condition5InvalidMustBeYes,

    /// <summary>
    /// Condition 6 indicator is invalid. It must be Yes.
    /// Encoded/decoded by serializers as &quot;CN6Y&quot;.
    /// </summary>
    [EnumMember(Value = "CN6Y")]
    [IsoId("_CdgTwMiJEee7W-rN1yqPMg")]
    [Description(@"Condition 6 indicator is invalid. It must be Yes.")]
    Condition6InvalidMustBeYes,

    /// <summary>
    /// Contact name is missing.
    /// Encoded/decoded by serializers as &quot;CNAM&quot;.
    /// </summary>
    [EnumMember(Value = "CNAM")]
    [IsoId("_tW-JcMiJEee7W-rN1yqPMg")]
    [Description(@"Contact name is missing.")]
    ContactNameMissing,

    /// <summary>
    /// Contact name is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNAX&quot;.
    /// </summary>
    [EnumMember(Value = "CNAX")]
    [IsoId("_TY5ocMiKEee7W-rN1yqPMg")]
    [Description(@"Contact name is not used with this event.")]
    ContactNameNotUsedWithEvent,

    /// <summary>
    /// Contact phone number is missing.
    /// Encoded/decoded by serializers as &quot;CNPM&quot;.
    /// </summary>
    [EnumMember(Value = "CNPM")]
    [IsoId("_UbP2QMiKEee7W-rN1yqPMg")]
    [Description(@"Contact phone number is missing.")]
    ContactPhoneNumberMissing,

    /// <summary>
    /// Contact phone number is not used with this event.
    /// Encoded/decoded by serializers as &quot;CNPX&quot;.
    /// </summary>
    [EnumMember(Value = "CNPX")]
    [IsoId("_UftfgMiKEee7W-rN1yqPMg")]
    [Description(@"Contact phone number is not used with this event.")]
    ContactPhoneNumberNotUsedWithEvent,

    /// <summary>
    /// Comment area is invalid.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_Uj4N0MiKEee7W-rN1yqPMg")]
    [Description(@"Comment area is invalid.")]
    CommentAreaInvalid,

    /// <summary>
    /// Conditional quantity zeroes are required.
    /// Encoded/decoded by serializers as &quot;COQ0&quot;.
    /// </summary>
    [EnumMember(Value = "COQ0")]
    [IsoId("_UnwBMMiKEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity zeroes are required.")]
    ConditionalQuantityZeroesRequired,

    /// <summary>
    /// Conditional quantity exceeds the transaction quantity.
    /// Encoded/decoded by serializers as &quot;COQE&quot;.
    /// </summary>
    [EnumMember(Value = "COQE")]
    [IsoId("_UsD5cMiKEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity exceeds the transaction quantity.")]
    ConditionalQuantityExceedsTransactionQuantity,

    /// <summary>
    /// Conditional quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;COQI&quot;.
    /// </summary>
    [EnumMember(Value = "COQI")]
    [IsoId("_UsD5cciKEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity is missing or invalid.")]
    ConditionalQuantityMissingOrInvalid,

    /// <summary>
    /// Conditional quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;COQX&quot;.
    /// </summary>
    [EnumMember(Value = "COQX")]
    [IsoId("_Uv7s0MiKEee7W-rN1yqPMg")]
    [Description(@"Conditional quantity cannot be zero.")]
    ConditionalQuantityCannotBeZero,

    /// <summary>
    /// Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity.
    /// Encoded/decoded by serializers as &quot;COTQ&quot;.
    /// </summary>
    [EnumMember(Value = "COTQ")]
    [IsoId("_Uzf-MMiKEee7W-rN1yqPMg")]
    [Description(
        @"Conditional quantity does not equal the transaction quantity whilst this offer accepts only full conditional quantity."
    )]
    ConditionalQuantityDoesNotEqualTransactionQuantity,

    /// <summary>
    /// Cover quantity is greater than the remaining protect quantity.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_U68C8MiKEee7W-rN1yqPMg")]
    [Description(@"Cover quantity is greater than the remaining protect quantity.")]
    CoverQuantityGreaterThanProtectQuantity,

    /// <summary>
    /// Customer quantities do not add up to total rights quantities.
    /// Encoded/decoded by serializers as &quot;CQRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CQRQ")]
    [IsoId("_U-z2UMiKEee7W-rN1yqPMg")]
    [Description(@"Customer quantities do not add up to total rights quantities.")]
    CustomerQuantitiesAndTotalRightsQuantitiesMismatch,

    /// <summary>
    /// Customer Sequence number is invalid or out of sequence.
    /// Encoded/decoded by serializers as &quot;CSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CSEQ")]
    [IsoId("_VD3VcMiKEee7W-rN1yqPMg")]
    [Description(@"Customer Sequence number is invalid or out of sequence.")]
    CustomerSequenceNumberInvalid,

    /// <summary>
    /// Customer identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_VIevsMiKEee7W-rN1yqPMg")]
    [Description(@"Customer identification is missing or invalid.")]
    CustomerIdentificationMissingOrInvalid,

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;CUSD&quot;.
    /// </summary>
    [EnumMember(Value = "CUSD")]
    [IsoId("_VNiO0MiKEee7W-rN1yqPMg")]
    [Description(@"Target CUSIP or contra CUSIP identification is not DTC eligible.")]
    CUSIPNotDTCEligible,

    /// <summary>
    /// Target CUSIP or contra CUSIP identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;CUSI&quot;.
    /// </summary>
    [EnumMember(Value = "CUSI")]
    [IsoId("_1vqBgMkfEee7W-rN1yqPMg")]
    [Description(@"Target CUSIP or contra CUSIP identification is missing or invalid.")]
    CUSIPMissingOrInvalid,

    /// <summary>
    /// Underlying security CUSIP is invalid.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("_1z0v0MkfEee7W-rN1yqPMg")]
    [Description(@"Underlying security CUSIP is invalid.")]
    UnderlyingSecurityCUSIPInvalid,

    /// <summary>
    /// Underlying security CUSIP does not match the original.
    /// Encoded/decoded by serializers as &quot;CUSU&quot;.
    /// </summary>
    [EnumMember(Value = "CUSU")]
    [IsoId("_144O8MkfEee7W-rN1yqPMg")]
    [Description(@"Underlying security CUSIP does not match the original.")]
    UnderlyingSecurityCUSIPMismatch,

    /// <summary>
    /// Cut-off time check has failed.
    /// Encoded/decoded by serializers as &quot;CUTC&quot;.
    /// </summary>
    [EnumMember(Value = "CUTC")]
    [IsoId("_185MQMkfEee7W-rN1yqPMg")]
    [Description(@"Cut-off time check has failed.")]
    CutoffTimeCheckFailed,

    /// <summary>
    /// Cut-off time has passed.
    /// Encoded/decoded by serializers as &quot;CUTT&quot;.
    /// </summary>
    [EnumMember(Value = "CUTT")]
    [IsoId("_2A6woMkfEee7W-rN1yqPMg")]
    [Description(@"Cut-off time has passed.")]
    CutoffTimePassed,

    /// <summary>
    /// Entry date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_2E7t8MkfEee7W-rN1yqPMg")]
    [Description(@"Entry date must be less than or equal to current date.")]
    EntryDatePassed,

    /// <summary>
    /// Entry Date is invalid.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_2JZXMMkfEee7W-rN1yqPMg")]
    [Description(@"Entry Date is invalid.")]
    EntryDateInvalid,

    /// <summary>
    /// Customer has fractional underlying quantity, adjust quantity.
    /// Encoded/decoded by serializers as &quot;FRAQ&quot;.
    /// </summary>
    [EnumMember(Value = "FRAQ")]
    [IsoId("_2NtPcMkfEee7W-rN1yqPMg")]
    [Description(@"Customer has fractional underlying quantity, adjust quantity.")]
    FractionalUnderlyingQuantity,

    /// <summary>
    /// Transaction type or withdrawal transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_2SnkoMkfEee7W-rN1yqPMg")]
    [Description(@"Transaction type or withdrawal transaction type is invalid.")]
    TransactionTypeInvalid,

    /// <summary>
    /// Function is not available at this time. Please check expiration start and end times for the event.
    /// Encoded/decoded by serializers as &quot;FUNU&quot;.
    /// </summary>
    [EnumMember(Value = "FUNU")]
    [IsoId("_2XO-4MkfEee7W-rN1yqPMg")]
    [Description(
        @"Function is not available at this time. Please check expiration start and end times for the event."
    )]
    FunctionNotAvailable,

    /// <summary>
    /// Offer is already on historical data base.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_KBml0MkiEee7W-rN1yqPMg")]
    [Description(@"Offer is already on historical data base.")]
    OfferInDatabase,

    /// <summary>
    /// Key Information is missing (tenders data).
    /// Encoded/decoded by serializers as &quot;KEYM&quot;.
    /// </summary>
    [EnumMember(Value = "KEYM")]
    [IsoId("_KKFMYMkiEee7W-rN1yqPMg")]
    [Description(@"Key Information is missing (tenders data).")]
    KeyInformationMissing,

    /// <summary>
    /// Key data (VOI transaction) cannot be found.
    /// Encoded/decoded by serializers as &quot;KEYV&quot;.
    /// </summary>
    [EnumMember(Value = "KEYV")]
    [IsoId("_KTKP4MkiEee7W-rN1yqPMg")]
    [Description(@"Key data (VOI transaction) cannot be found.")]
    KayDataNotFound,

    /// <summary>
    /// Participant has insufficient position.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_KTwFwMkiEee7W-rN1yqPMg")]
    [Description(@"Participant has insufficient position.")]
    InsufficientPosition,

    /// <summary>
    /// Master tables are not available.
    /// Encoded/decoded by serializers as &quot;MSTB&quot;.
    /// </summary>
    [EnumMember(Value = "MSTB")]
    [IsoId("_K3dPwMkiEee7W-rN1yqPMg")]
    [Description(@"Master tables are not available.")]
    MasterTablesNotAvailable,

    /// <summary>
    /// There is no withdrawal privilege on this offer.
    /// Encoded/decoded by serializers as &quot;NWIT&quot;.
    /// </summary>
    [EnumMember(Value = "NWIT")]
    [IsoId("_LXvSUMkiEee7W-rN1yqPMg")]
    [Description(@"There is no withdrawal privilege on this offer.")]
    NoWithdrawalPrivilege,

    /// <summary>
    /// Odd lot indicator is missing or invalid.
    /// Encoded/decoded by serializers as &quot;ODLI&quot;.
    /// </summary>
    [EnumMember(Value = "ODLI")]
    [IsoId("_Lgqk0MkiEee7W-rN1yqPMg")]
    [Description(@"Odd lot indicator is missing or invalid.")]
    OddLotIndicatorMissingOrInvalid,

    /// <summary>
    /// Cannot submit odd lot indicator &apos;Yes&apos; for the offer.
    /// Encoded/decoded by serializers as &quot;ODLY&quot;.
    /// </summary>
    [EnumMember(Value = "ODLY")]
    [IsoId("_LyOO4MkiEee7W-rN1yqPMg")]
    [Description(@"Cannot submit odd lot indicator 'Yes' for the offer.")]
    OddLotIndicatorYesInvalid,

    /// <summary>
    /// Offer is not eligible for the PUTS function.
    /// Encoded/decoded by serializers as &quot;OFFP&quot;.
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_L6s1cMkiEee7W-rN1yqPMg")]
    [Description(@"Offer is not eligible for the PUTS function.")]
    OfferNotEligibleForPuts,

    /// <summary>
    /// The rejection reason is unknown.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_TPGL8MkpEee7W-rN1yqPMg")]
    [Description(@"The rejection reason is unknown.")]
    UnknownErrorCondition,

    /// <summary>
    /// Customer oversubscription quantities do not add up to total oversubscription quantity.
    /// Encoded/decoded by serializers as &quot;OVCU&quot;.
    /// </summary>
    [EnumMember(Value = "OVCU")]
    [IsoId("_TebBYMkpEee7W-rN1yqPMg")]
    [Description(
        @"Customer oversubscription quantities do not add up to total oversubscription quantity."
    )]
    CustomerAndTotalOversubscriptionQuantitiesMismatch,

    /// <summary>
    /// Oversubscription quantity is greater than percentage of underlying shares.
    /// Encoded/decoded by serializers as &quot;OVRG&quot;.
    /// </summary>
    [EnumMember(Value = "OVRG")]
    [IsoId("_TlRQQMkpEee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity is greater than percentage of underlying shares.")]
    OversubscriptionQuantityExceeded,

    /// <summary>
    /// Oversubscription quantity is invalid.
    /// Encoded/decoded by serializers as &quot;OVRI&quot;.
    /// </summary>
    [EnumMember(Value = "OVRI")]
    [IsoId("_b_OIUMkqEee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity is invalid.")]
    OversubscriptionQuantityInvalid,

    /// <summary>
    /// Oversubscription is not allowed.
    /// Encoded/decoded by serializers as &quot;OVRX&quot;.
    /// </summary>
    [EnumMember(Value = "OVRX")]
    [IsoId("_kyU8sMkqEee7W-rN1yqPMg")]
    [Description(@"Oversubscription is not allowed.")]
    OversubscriptionNotAllowed,

    /// <summary>
    /// Oversubscription quantity not used with this transaction type.
    /// Encoded/decoded by serializers as &quot;OVTT&quot;.
    /// </summary>
    [EnumMember(Value = "OVTT")]
    [IsoId("_rvGWAMk0Eee7W-rN1yqPMg")]
    [Description(@"Oversubscription quantity not used with this transaction type.")]
    OversubscriptionQuantityNotUsed,

    /// <summary>
    /// Participant is DO chilled.
    /// Encoded/decoded by serializers as &quot;PACH&quot;.
    /// </summary>
    [EnumMember(Value = "PACH")]
    [IsoId("_r5zxMMk0Eee7W-rN1yqPMg")]
    [Description(@"Participant is DO chilled.")]
    ParticipantDOChilled,

    /// <summary>
    /// Participant eligibility check on master table is not available.
    /// Encoded/decoded by serializers as &quot;PAEC&quot;.
    /// </summary>
    [EnumMember(Value = "PAEC")]
    [IsoId("_r7J1AMk0Eee7W-rN1yqPMg")]
    [Description(@"Participant eligibility check on master table is not available.")]
    ParticipantEligibilityCheckNotAvailable,

    /// <summary>
    /// Participant does not match participant on Protect ID.
    /// Encoded/decoded by serializers as &quot;PAPI&quot;.
    /// </summary>
    [EnumMember(Value = "PAPI")]
    [IsoId("_sDClsMk0Eee7W-rN1yqPMg")]
    [Description(@"Participant does not match participant on Protect ID.")]
    ParticipantNoMatchOnProtectIdentification,

    /// <summary>
    /// Participant is globally locked.
    /// Encoded/decoded by serializers as &quot;PARL&quot;.
    /// </summary>
    [EnumMember(Value = "PARL")]
    [IsoId("_sLORUMk0Eee7W-rN1yqPMg")]
    [Description(@"Participant is globally locked.")]
    ParticipantLocked,

    /// <summary>
    /// Participant number is invalid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_sT2B0Mk0Eee7W-rN1yqPMg")]
    [Description(@"Participant number is invalid.")]
    ParticipantNumberInvalid,

    /// <summary>
    /// Participant is not DTC eligible.
    /// Encoded/decoded by serializers as &quot;PARX&quot;.
    /// </summary>
    [EnumMember(Value = "PARX")]
    [IsoId("_sT2B0ck0Eee7W-rN1yqPMg")]
    [Description(@"Participant is not DTC eligible.")]
    ParticipantNotEligible,

    /// <summary>
    /// Protect date on file must be zero.
    /// Encoded/decoded by serializers as &quot;PRO0&quot;.
    /// </summary>
    [EnumMember(Value = "PRO0")]
    [IsoId("_seHYIMk0Eee7W-rN1yqPMg")]
    [Description(@"Protect date on file must be zero.")]
    ProtectDateZero,

    /// <summary>
    /// Current date is greater than protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROE&quot;.
    /// </summary>
    [EnumMember(Value = "PROE")]
    [IsoId("_sl2X0Mk0Eee7W-rN1yqPMg")]
    [Description(@"Current date is greater than protect submission end date.")]
    CurrentDatePassedProtectSubmissionEndDate,

    /// <summary>
    /// Protect Date invalid or missing.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_stcNkMk0Eee7W-rN1yqPMg")]
    [Description(@"Protect Date invalid or missing.")]
    ProtectDateInvalidOrMissing,

    /// <summary>
    /// Protect date must be less than or equal to current date.
    /// Encoded/decoded by serializers as &quot;PROL&quot;.
    /// </summary>
    [EnumMember(Value = "PROL")]
    [IsoId("_pGGBgMk2Eee7W-rN1yqPMg")]
    [Description(@"Protect date must be less than or equal to current date.")]
    ProtectDatePassed,

    /// <summary>
    /// Current date is less than protect submission start date.
    /// Encoded/decoded by serializers as &quot;PROS&quot;.
    /// </summary>
    [EnumMember(Value = "PROS")]
    [IsoId("_zPMYcMk2Eee7W-rN1yqPMg")]
    [Description(@"Current date is less than protect submission start date.")]
    CurrentDatePrecedesProtectSubmissionStartDate,

    /// <summary>
    /// Protect identification is missing or invalid.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_zX958Mk2Eee7W-rN1yqPMg")]
    [Description(@"Protect identification is missing or invalid.")]
    ProtectIdentificationMissingOrInvalid,

    /// <summary>
    /// Protect identification is not used with this event.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_zg5McMk2Eee7W-rN1yqPMg")]
    [Description(@"Protect identification is not used with this event.")]
    ProtectIdentificationNotUsed,

    /// <summary>
    /// Function is quiesced (not available).
    /// Encoded/decoded by serializers as &quot;QUIE&quot;.
    /// </summary>
    [EnumMember(Value = "QUIE")]
    [IsoId("_zqIA8Mk2Eee7W-rN1yqPMg")]
    [Description(@"Function is quiesced (not available).")]
    FunctionQuiesced,

    /// <summary>
    /// Record type is invalid.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_z0O_MMk2Eee7W-rN1yqPMg")]
    [Description(@"Record type is invalid.")]
    RecordTypeInvalid,

    /// <summary>
    /// Rights CUSIP has insufficient position.
    /// Encoded/decoded by serializers as &quot;RILA&quot;.
    /// </summary>
    [EnumMember(Value = "RILA")]
    [IsoId("_AiCqYMk-Eee7W-rN1yqPMg")]
    [Description(@"Rights CUSIP has insufficient position.")]
    RightsCUSIPInsufficientPosition,

    /// <summary>
    /// Not a good return code from rights position check.
    /// Encoded/decoded by serializers as &quot;RPCI&quot;.
    /// </summary>
    [EnumMember(Value = "RPCI")]
    [IsoId("_Ar3UwMk-Eee7W-rN1yqPMg")]
    [Description(@"Not a good return code from rights position check.")]
    RightsPositionCheckInvalid,

    /// <summary>
    /// Rights quantity for this subscription must be divisible by rights.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("_A11JEMk-Eee7W-rN1yqPMg")]
    [Description(@"Rights quantity for this subscription must be divisible by rights.")]
    RightsQuantityDivisibleByRights,

    /// <summary>
    /// Rights quantity is invalid.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("_BAZaUMk-Eee7W-rN1yqPMg")]
    [Description(@"Rights quantity is invalid.")]
    RightsQuantityInvalid,

    /// <summary>
    /// Rights ratio not found on data base.
    /// Encoded/decoded by serializers as &quot;RTIO&quot;.
    /// </summary>
    [EnumMember(Value = "RTIO")]
    [IsoId("_BCoO8Mk-Eee7W-rN1yqPMg")]
    [Description(@"Rights ratio not found on data base.")]
    RightsRatioNotFound,

    /// <summary>
    /// RTS processing is in progress. Submit later.
    /// Encoded/decoded by serializers as &quot;RTSP&quot;.
    /// </summary>
    [EnumMember(Value = "RTSP")]
    [IsoId("_BLjhcMk-Eee7W-rN1yqPMg")]
    [Description(@"RTS processing is in progress. Submit later.")]
    RTSProcessingInProgress,

    /// <summary>
    /// Customer Sequence number must be all zero.
    /// Encoded/decoded by serializers as &quot;SEQ0&quot;.
    /// </summary>
    [EnumMember(Value = "SEQ0")]
    [IsoId("_BT4XAMk-Eee7W-rN1yqPMg")]
    [Description(@"Customer Sequence number must be all zero.")]
    CustomerSequenceNumberAllZero,

    /// <summary>
    /// Transaction sequence number is duplicated.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_BbUbwMk-Eee7W-rN1yqPMg")]
    [Description(@"Transaction sequence number is duplicated.")]
    DuplicateTransactionSequenceNumber,

    /// <summary>
    /// Sequence number is missing.
    /// Encoded/decoded by serializers as &quot;SEQM&quot;.
    /// </summary>
    [EnumMember(Value = "SEQM")]
    [IsoId("_BlcBEMk-Eee7W-rN1yqPMg")]
    [Description(@"Sequence number is missing.")]
    SequenceNumberMissing,

    /// <summary>
    /// Sequence number is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_Btd7sMk-Eee7W-rN1yqPMg")]
    [Description(@"Sequence number is out of sequence.")]
    SequenceNumberOutOfSync,

    /// <summary>
    /// Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912.
    /// Encoded/decoded by serializers as &quot;SEQP&quot;.
    /// </summary>
    [EnumMember(Value = "SEQP")]
    [IsoId("_-ikBwMlEEee7W-rN1yqPMg")]
    [Description(
        @"Customer sequence number must be between 1 and 1 or for PUTS between 9999901 and 9999912."
    )]
    SequenceNumberInvalidBounds,

    /// <summary>
    /// Underlying share quantity is invalid.
    /// Encoded/decoded by serializers as &quot;SHQI&quot;.
    /// </summary>
    [EnumMember(Value = "SHQI")]
    [IsoId("_-srnEMlEEee7W-rN1yqPMg")]
    [Description(@"Underlying share quantity is invalid.")]
    UnderlyingShareQuantityInvalid,

    /// <summary>
    /// Underlying share quantity does not match original share quantity.
    /// Encoded/decoded by serializers as &quot;SHQO&quot;.
    /// </summary>
    [EnumMember(Value = "SHQO")]
    [IsoId("_-1m5kMlEEee7W-rN1yqPMg")]
    [Description(@"Underlying share quantity does not match original share quantity.")]
    UnderlyingShareQuantityMismatch,

    /// <summary>
    /// Comments are required for solicitation fee.
    /// Encoded/decoded by serializers as &quot;SOCR&quot;.
    /// </summary>
    [EnumMember(Value = "SOCR")]
    [IsoId("_-1m5kclEEee7W-rN1yqPMg")]
    [Description(@"Comments are required for solicitation fee.")]
    SolicitationFeeCommentsRequired,

    /// <summary>
    /// Solicitation fee indicator is required.
    /// Encoded/decoded by serializers as &quot;SOLI&quot;.
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("_---Q8MlEEee7W-rN1yqPMg")]
    [Description(@"Solicitation fee indicator is required.")]
    SolicitationFeeIndicatorRequired,

    /// <summary>
    /// Solicitation fee indicator is not used with this event.
    /// Encoded/decoded by serializers as &quot;SOLX&quot;.
    /// </summary>
    [EnumMember(Value = "SOLX")]
    [IsoId("_qnK_cMlGEee7W-rN1yqPMg")]
    [Description(@"Solicitation fee indicator is not used with this event.")]
    SolicitationFeeIndicatorNotUsed,

    /// <summary>
    /// Submission date is not yet reached.
    /// Encoded/decoded by serializers as &quot;SUBE&quot;.
    /// </summary>
    [EnumMember(Value = "SUBE")]
    [IsoId("_qyL8oMlGEee7W-rN1yqPMg")]
    [Description(@"Submission date is not yet reached.")]
    SubmissionDateNotReached,

    /// <summary>
    /// Date of submission has passed.
    /// Encoded/decoded by serializers as &quot;SUBL&quot;.
    /// </summary>
    [EnumMember(Value = "SUBL")]
    [IsoId("_q7aKEMlGEee7W-rN1yqPMg")]
    [Description(@"Date of submission has passed.")]
    SubmissionDatePassed,

    /// <summary>
    /// Transaction type and event are incompatible.
    /// Encoded/decoded by serializers as &quot;TNFN&quot;.
    /// </summary>
    [EnumMember(Value = "TNFN")]
    [IsoId("_RJiSAMlHEee7W-rN1yqPMg")]
    [Description(@"Transaction type and event are incompatible.")]
    TransactionTypeAndEventIncompatible,

    /// <summary>
    /// Transaction Identification is invalid.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_RSnVgMlHEee7W-rN1yqPMg")]
    [Description(@"Transaction Identification is invalid.")]
    TransactionIdentificationInvalid,

    /// <summary>
    /// Transaction type is missing.
    /// Encoded/decoded by serializers as &quot;TRNM&quot;.
    /// </summary>
    [EnumMember(Value = "TRNM")]
    [IsoId("_RbF8EMlHEee7W-rN1yqPMg")]
    [Description(@"Transaction type is missing.")]
    TransactionTypeMissing,

    /// <summary>
    /// Transaction sequence number is invalid, not numeric.
    /// Encoded/decoded by serializers as &quot;TRNS&quot;.
    /// </summary>
    [EnumMember(Value = "TRNS")]
    [IsoId("_RbF8EclHEee7W-rN1yqPMg")]
    [Description(@"Transaction sequence number is invalid, not numeric.")]
    TransactionSequenceNumberInvalid,

    /// <summary>
    /// Transaction Quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;TRQ0&quot;.
    /// </summary>
    [EnumMember(Value = "TRQ0")]
    [IsoId("_RknEcMlHEee7W-rN1yqPMg")]
    [Description(@"Transaction Quantity cannot be zero.")]
    TransactionQuantityCannotBeZero,

    /// <summary>
    /// Transaction Quantity is missing or invalid.
    /// Encoded/decoded by serializers as &quot;TRQI&quot;.
    /// </summary>
    [EnumMember(Value = "TRQI")]
    [IsoId("_RrTiUMlHEee7W-rN1yqPMg")]
    [Description(@"Transaction Quantity is missing or invalid.")]
    TransactionQuantityMissingOrInvalid,

    /// <summary>
    /// Transaction quantity is less than the transaction minimum.
    /// Encoded/decoded by serializers as &quot;TRQM&quot;.
    /// </summary>
    [EnumMember(Value = "TRQM")]
    [IsoId("_RtsH8MlHEee7W-rN1yqPMg")]
    [Description(@"Transaction quantity is less than the transaction minimum.")]
    TransactionQuantityLessThanTransactionMinimum,

    /// <summary>
    /// Provided by protect, enter 0 for transaction quantity.
    /// Encoded/decoded by serializers as &quot;TRQP&quot;.
    /// </summary>
    [EnumMember(Value = "TRQP")]
    [IsoId("_R83MYMlHEee7W-rN1yqPMg")]
    [Description(@"Provided by protect, enter 0 for transaction quantity.")]
    ProvidedByProtect,

    /// <summary>
    /// Withdrawal transaction quantity cannot be zero.
    /// Encoded/decoded by serializers as &quot;WIT0&quot;.
    /// </summary>
    [EnumMember(Value = "WIT0")]
    [IsoId("_R_GBAMlHEee7W-rN1yqPMg")]
    [Description(@"Withdrawal transaction quantity cannot be zero.")]
    WithdrawalTransactionQuantityCannotBeZero,

    /// <summary>
    /// Error in withdraw occurred.
    /// Encoded/decoded by serializers as &quot;WITE&quot;.
    /// </summary>
    [EnumMember(Value = "WITE")]
    [IsoId("_ewDgIMlJEee7W-rN1yqPMg")]
    [Description(@"Error in withdraw occurred.")]
    WithdrawError,

    /// <summary>
    /// Withdrawal quantity is greater than VOI / protect quantity.
    /// Encoded/decoded by serializers as &quot;WITG&quot;.
    /// </summary>
    [EnumMember(Value = "WITG")]
    [IsoId("_e7NnQMlJEee7W-rN1yqPMg")]
    [Description(@"Withdrawal quantity is greater than VOI / protect quantity.")]
    WithdrawalQuantityGreaterThanProtectQuantity,

    /// <summary>
    /// Withdrawal quantity exceeds the remaining quantity.
    /// Encoded/decoded by serializers as &quot;WITQ&quot;.
    /// </summary>
    [EnumMember(Value = "WITQ")]
    [IsoId("_fE4goMlJEee7W-rN1yqPMg")]
    [Description(@"Withdrawal quantity exceeds the remaining quantity.")]
    WithdrawalQuantityExceedsRemainingQuantity,

    /// <summary>
    /// Beneficial owner name is missing.
    /// Encoded/decoded by serializers as &quot;BONM&quot;.
    /// </summary>
    [EnumMember(Value = "BONM")]
    [IsoId("_fHRGQMlJEee7W-rN1yqPMg")]
    [Description(@"Beneficial owner name is missing.")]
    BeneficialOwnerNameMissing,

    /// <summary>
    /// Beneficial owner death date is missing.
    /// Encoded/decoded by serializers as &quot;BODD&quot;.
    /// </summary>
    [EnumMember(Value = "BODD")]
    [IsoId("_fPAF8MlJEee7W-rN1yqPMg")]
    [Description(@"Beneficial owner death date is missing.")]
    BeneficialOwnerDeathDateMissing,

    /// <summary>
    /// Death certificate details are missing.
    /// Encoded/decoded by serializers as &quot;BODC&quot;.
    /// </summary>
    [EnumMember(Value = "BODC")]
    [IsoId("_fYFJcMlJEee7W-rN1yqPMg")]
    [Description(@"Death certificate details are missing.")]
    DeathCertificateMissing,

    /// <summary>
    /// Issuing jurisdiction is missing.
    /// Encoded/decoded by serializers as &quot;BOIJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOIJ")]
    [IsoId("_fgZ_AMlJEee7W-rN1yqPMg")]
    [Description(@"Issuing jurisdiction is missing.")]
    IssuingJurisdictionMissing,

    /// <summary>
    /// Certificate number is invalid.
    /// Encoded/decoded by serializers as &quot;CERN&quot;.
    /// </summary>
    [EnumMember(Value = "CERN")]
    [IsoId("_fhJl4MlJEee7W-rN1yqPMg")]
    [Description(@"Certificate number is invalid.")]
    CertificateNumberInvalid,

    /// <summary>
    /// Certificate sequence number is invalid.
    /// Encoded/decoded by serializers as &quot;CERS&quot;.
    /// </summary>
    [EnumMember(Value = "CERS")]
    [IsoId("_fq-QQMlJEee7W-rN1yqPMg")]
    [Description(@"Certificate sequence number is invalid.")]
    CertificateSequenceNumberInvalid,

    /// <summary>
    /// Certificate number is missing.
    /// Encoded/decoded by serializers as &quot;CENM&quot;.
    /// </summary>
    [EnumMember(Value = "CENM")]
    [IsoId("_fxz4EMlJEee7W-rN1yqPMg")]
    [Description(@"Certificate number is missing.")]
    CertificateNameMissing,

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;ADIN&quot;.
    /// </summary>
    [EnumMember(Value = "ADIN")]
    [IsoId("_LSIc8MlLEee7W-rN1yqPMg")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is invalid.")]
    AdjudicationOfIncompetencyAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Adjudication of incompetency acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("_LdSkEMlLEee7W-rN1yqPMg")]
    [Description(@"Adjudication of incompetency acknowledgement indicator is missing.")]
    AdjudicationOfIncompetencyAcknowledgmentIndicatorMissing,

    /// <summary>
    /// Legal documentation thirty months retention acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;LEGI&quot;.
    /// </summary>
    [EnumMember(Value = "LEGI")]
    [IsoId("_Lmp7cMlLEee7W-rN1yqPMg")]
    [Description(
        @"Legal documentation thirty months retention acknowledgement indicator is invalid."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Legal documentation thirty Months retention acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;LEGM&quot;.
    /// </summary>
    [EnumMember(Value = "LEGM")]
    [IsoId("_Lmp7cclLEee7W-rN1yqPMg")]
    [Description(
        @"Legal documentation thirty Months retention acknowledgement indicator is missing."
    )]
    LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicatorMissing,

    /// <summary>
    /// Instruction deletion acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_Lvu-8MlLEee7W-rN1yqPMg")]
    [Description(@"Instruction deletion acknowledgement indicator is invalid.")]
    InstructionDeletionAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Instruction deletion acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_L3U0sMlLEee7W-rN1yqPMg")]
    [Description(@"Instruction deletion acknowledgement indicator is missing.")]
    InstructionDeletionAcknowledgementIndicatorMissing,

    /// <summary>
    /// Potential loss acknowledgement indicator is invalid.
    /// Encoded/decoded by serializers as &quot;POLI&quot;.
    /// </summary>
    [EnumMember(Value = "POLI")]
    [IsoId("_L4EbkMlLEee7W-rN1yqPMg")]
    [Description(@"Potential loss acknowledgement indicator is invalid.")]
    PotentiaLossAcknowledgementIndicatorInvalid,

    /// <summary>
    /// Potential loss acknowledgement indicator is missing.
    /// Encoded/decoded by serializers as &quot;POLM&quot;.
    /// </summary>
    [EnumMember(Value = "POLM")]
    [IsoId("_MBlj8MlLEee7W-rN1yqPMg")]
    [Description(@"Potential loss acknowledgement indicator is missing.")]
    PotentiaLossAcknowledgementIndicatorMissing,

    /// <summary>
    /// Warrant subscription charge amount is not balancing.
    /// Encoded/decoded by serializers as &quot;WARC&quot;.
    /// </summary>
    [EnumMember(Value = "WARC")]
    [IsoId("_MJeUoMlLEee7W-rN1yqPMg")]
    [Description(@"Warrant subscription charge amount is not balancing.")]
    WarrantSubscriptionChargeAmountInvalid,

    /// <summary>
    /// There is a summary difference between the core instruction quantity and the extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUME&quot;.
    /// </summary>
    [EnumMember(Value = "SUME")]
    [IsoId("_MJnekMlLEee7W-rN1yqPMg")]
    [Description(
        @"There is a summary difference between the core instruction quantity and the extension transaction details."
    )]
    CoreInstructionQuantityAndExtensionTransactionDetailsDifference,

    /// <summary>
    /// There is summary difference between core oversubscription quantity and extension transaction details.
    /// Encoded/decoded by serializers as &quot;SUMO&quot;.
    /// </summary>
    [EnumMember(Value = "SUMO")]
    [IsoId("_0z2xsMlNEee7W-rN1yqPMg")]
    [Description(
        @"There is summary difference between core oversubscription quantity and extension transaction details."
    )]
    CoreInstructionOversubscriptionQuantityAndExtensionTransactionDetailsDifference,

    /// <summary>
    /// Withdrawal Transaction type is invalid.
    /// Encoded/decoded by serializers as &quot;WITI&quot;.
    /// </summary>
    [EnumMember(Value = "WITI")]
    [IsoId("_SLeIgMnpEee6kIhZjMqQ2Q")]
    [Description(@"Withdrawal Transaction type is invalid.")]
    WithdrawalTransactionTypeInvalid,

    /// <summary>
    /// Current date has passed cover protect submission end date.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_9oGDEACoEeqouY-yI_q3qQ")]
    [Description(@"Current date has passed cover protect submission end date.")]
    PassedProtectSubmissionEndDate,

    /// <summary>
    /// Customer Reference Identification must be populated for each sequence.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_kKw3oACpEeqouY-yI_q3qQ")]
    [Description(@"Customer Reference Identification must be populated for each sequence.")]
    CustomerReferenceIdentificationMissingInSequence,
}
