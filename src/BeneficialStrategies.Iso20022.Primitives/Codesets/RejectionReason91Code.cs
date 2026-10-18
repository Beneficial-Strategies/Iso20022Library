// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cN7z4KjXEfCzuLlmLrhIvA")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RejectionReason91Code>))]
public enum RejectionReason91Code
{
    /// <summary>
    /// Requested additional documentation is missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("24b9cf54-3e20-4ddf-845e-e232f80576ac")]
    [Description(@"Requested additional documentation is missing.")]
    AdditionalDocumentationMissing = RejectionReasonV3Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("e3d6cac1-c096-437c-b98b-9dc2da3f513f")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// (I)CSD failed to receive (from underlying) or provide (to the issuer agent) the disclosure information required.
    /// Encoded/decoded by serializers as &quot;ADIM&quot;.
    /// </summary>
    [EnumMember(Value = "ADIM")]
    [IsoId("686b47e9-57d2-4096-be3c-0655b0c686d0")]
    [Description(@"(I)CSD failed to receive (from underlying) or provide (to the issuer agent) the disclosure information required.")]
    AdditionalDisclosureInformationMissing = RejectionReasonV3Code.AdditionalDisclosureInformationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("101bdbf9-e278-418a-a38f-704e11c9114e")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("6d2f953d-cf72-429a-b549-797acf1c3a6e")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = RejectionReasonV3Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_ikTZsbAiEfCVt6rBUi-YSg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("fb8fb7d7-ee9b-445b-95d8-e410e8047847")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entitlement fixing date is missing or incorrect.
    /// Encoded/decoded by serializers as &quot;EFDM&quot;.
    /// </summary>
    [EnumMember(Value = "EFDM")]
    [IsoId("370b4c04-8986-4c61-95ec-7500b7888ba2")]
    [Description(@"Entitlement fixing date is missing or incorrect.")]
    MissingOrIncorrectEntitlementFixingDate = RejectionReasonV3Code.MissingOrIncorrectEntitlementFixingDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("9bca3d66-a6c9-41be-a905-1423951c7e6d")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("45b9bc71-3575-4d7b-8218-595bc46503ad")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received prior to entitlement date.
    /// Encoded/decoded by serializers as &quot;IPED&quot;.
    /// </summary>
    [EnumMember(Value = "IPED")]
    [IsoId("e6602a5a-e9f3-46ff-b9eb-1924b8215666")]
    [Description(@"Instruction was received prior to entitlement date.")]
    InstructionPriorToEntitlementDate = RejectionReasonV3Code.InstructionPriorToEntitlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("3b7c75a7-223d-4d60-a900-1a0e9d726881")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonV3Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("68ee81e0-4ed1-4857-9c39-1fb3f86357a7")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = RejectionReasonV3Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("495cbaca-3001-4515-a5e0-f3386cd82a25")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy = RejectionReasonV3Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("97e50f1e-72bb-4cbd-8791-75a315fdb2ad")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("9c490f46-9a63-4f51-8d2b-7a9fe2dcaf3b")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is invalid due to multiple resolutions instructed as vote &quot;For&quot; and belonging to the same listing group resolution label number.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("d3dc6f9c-6924-42f8-841d-4f02aae81378")]
    [Description(@"Instruction is invalid due to multiple resolutions instructed as vote ""For"" and belonging to the same listing group resolution label number.")]
    InvalidVoteInFavourInGroupListing = RejectionReasonV3Code.InvalidVoteInFavourInGroupListing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("581f1137-893a-45e3-9f7a-361d8267fa7a")]
    [Description(@"Event has been cancelled.")]
    EventCancelled = RejectionReasonV3Code.EventCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Classification submitted in the instruction does not match the investor classification in the notification.
    /// Encoded/decoded by serializers as &quot;MINC&quot;.
    /// </summary>
    [EnumMember(Value = "MINC")]
    [IsoId("555a483c-cdfe-4585-bb7b-81d224b55590")]
    [Description(@"Classification submitted in the instruction does not match the investor classification in the notification.")]
    MissingInvestorClassificationDetails = RejectionReasonV3Code.MissingInvestorClassificationDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction to virtually attend meeting is rejected due to missing attendee email address.
    /// Encoded/decoded by serializers as &quot;NACD&quot;.
    /// </summary>
    [EnumMember(Value = "NACD")]
    [IsoId("ee067b9a-a4c6-475f-9155-84fc3afcfcfe")]
    [Description(@"Instruction to virtually attend meeting is rejected due to missing attendee email address.")]
    NotAcceptedEmailAddressMissing = RejectionReasonV3Code.NotAcceptedEmailAddressMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.
    /// Encoded/decoded by serializers as &quot;NOSL&quot;.
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("39dcf212-88f7-4aa7-80d2-44e8706f0d21")]
    [Description(@"Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.")]
    NotRegisteredInInStockLedger = RejectionReasonV3Code.NotRegisteredInInStockLedger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("e6e1ee0f-1011-481e-b46e-02cbb59f352c")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = RejectionReasonV3Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("e45c1fb6-89e3-4183-9bec-02ab9dadcf89")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("2b22b97e-718f-4c17-84ce-8a3480887640")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("7eed3634-abba-4ef0-869a-8acafe3dd944")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = RejectionReasonV3Code.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction rejected due to the method of participation not supported by the account servicer.
    /// Encoded/decoded by serializers as &quot;PMNS&quot;.
    /// </summary>
    [EnumMember(Value = "PMNS")]
    [IsoId("7bb8bcdb-76be-4afb-9943-08fcb9793423")]
    [Description(@"Instruction rejected due to the method of participation not supported by the account servicer.")]
    ParticipationMethodNotSupported = RejectionReasonV3Code.ParticipationMethodNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("7f6375ed-c779-4476-bcb8-15db04a8d30f")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = RejectionReasonV3Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("5d025a97-1bc7-4b34-bbe3-9f1aa44b80c5")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonV3Code.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as &quot;RESN&quot;.
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("d5a21018-bff5-4d84-943d-6b3650c41d21")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy = RejectionReasonV3Code.ResolutionNumberDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("e0780978-4e7e-43d9-8064-744fd14c5539")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("a3f3dab0-4a81-4666-a289-06e9c4752ac0")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = RejectionReasonV3Code.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("2cd47858-30fb-4d40-8d53-7b2d2e9b1a44")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
}
