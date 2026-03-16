// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Dmq4uhrpEeyhRdHRjakS2w")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason65Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Dmq40hrpEeyhRdHRjakS2w")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested additional documentation is missing.
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_Dmq4zBrpEeyhRdHRjakS2w")]
    [Description(@"Requested additional documentation is missing. ")]
    AdditionalDocumentationMissing = RejectionReasonV3Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("_Dmq40BrpEeyhRdHRjakS2w")]
    [Description(@"Event has been cancelled.")]
    EventCancelled = RejectionReasonV3Code.EventCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Dmq4vBrpEeyhRdHRjakS2w")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_Dmq4vxrpEeyhRdHRjakS2w")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = RejectionReasonV3Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Dmq4vRrpEeyhRdHRjakS2w")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_Dmq4zRrpEeyhRdHRjakS2w")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_Dmq4vhrpEeyhRdHRjakS2w")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_Dmq4xhrpEeyhRdHRjakS2w")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonV3Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_Dmq4yRrpEeyhRdHRjakS2w")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = RejectionReasonV3Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_Dmq4zhrpEeyhRdHRjakS2w")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy = RejectionReasonV3Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Dmq40xrpEeyhRdHRjakS2w")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_Dmq4yhrpEeyhRdHRjakS2w")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = RejectionReasonV3Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Dmq4zxrpEeyhRdHRjakS2w")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Dmq4yxrpEeyhRdHRjakS2w")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = RejectionReasonV3Code.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_Dmq4whrpEeyhRdHRjakS2w")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = RejectionReasonV3Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_Dmq4xBrpEeyhRdHRjakS2w")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonV3Code.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as &quot;RESN&quot;.
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("_Dmq4wBrpEeyhRdHRjakS2w")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy = RejectionReasonV3Code.ResolutionNumberDiscrepancy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Dmq40RrpEeyhRdHRjakS2w")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_Dmq4wRrpEeyhRdHRjakS2w")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = RejectionReasonV3Code.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Dmq4xRrpEeyhRdHRjakS2w")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_Dmq4uxrpEeyhRdHRjakS2w")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_Dmq4wxrpEeyhRdHRjakS2w")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is invalid due to multiple resolutions instructed as vote &quot;For” and belonging to the same listing group resolution label number.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_Dmq4xxrpEeyhRdHRjakS2w")]
    [Description(
        @"Instruction is invalid due to multiple resolutions instructed as vote ""For” and belonging to the same listing group resolution label number."
    )]
    InvalidVoteInFavourInGroupListing = RejectionReasonV3Code.InvalidVoteInFavourInGroupListing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book.
    /// Encoded/decoded by serializers as &quot;NOSL&quot;.
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("_Dmq4yBrpEeyhRdHRjakS2w")]
    [Description(
        @"Invalid instruction as the shareholder or its delegate is not registered in the company stock ledger book."
    )]
    NotRegisteredInInStockLedger = RejectionReasonV3Code.NotRegisteredInInStockLedger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction rejected due to the method of participation not supported by the account servicer.
    /// Encoded/decoded by serializers as &quot;PMNS&quot;.
    /// </summary>
    [EnumMember(Value = "PMNS")]
    [IsoId("_V7QDQRrpEeyhRdHRjakS2w")]
    [Description(
        @"Instruction rejected due to the method of participation not supported by the account servicer."
    )]
    ParticipationMethodNotSupported = RejectionReasonV3Code.ParticipationMethodNotSupported, // same ordinal as derivation source for type conversions
}
