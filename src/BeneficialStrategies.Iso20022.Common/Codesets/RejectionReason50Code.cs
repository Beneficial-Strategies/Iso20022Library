// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a reason why the instruction has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_frUwsLKxEemDyeh7tbvg1w")]
[Description(@"Specifies a reason why the instruction has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason50Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_jnMwYLKxEemDyeh7tbvg1w")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested additional documentation is missing. 
    /// Encoded/decoded by serializers as &quot;ADDM&quot;.
    /// </summary>
    [EnumMember(Value = "ADDM")]
    [IsoId("_kLM1UbKxEemDyeh7tbvg1w")]
    [Description(@"Requested additional documentation is missing. ")]
    AdditionalDocumentationMissing = RejectionReasonV3Code.AdditionalDocumentationMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event has been cancelled.
    /// Encoded/decoded by serializers as &quot;MCAN&quot;.
    /// </summary>
    [EnumMember(Value = "MCAN")]
    [IsoId("__7IgEbKxEemDyeh7tbvg1w")]
    [Description(@"Event has been cancelled.")]
    EventCancelled = RejectionReasonV3Code.EventCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_CnQvIbKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deadline to register is missed.
    /// Encoded/decoded by serializers as &quot;DREM&quot;.
    /// </summary>
    [EnumMember(Value = "DREM")]
    [IsoId("_TNN0wbKyEemDyeh7tbvg1w")]
    [Description(@"Deadline to register is missed.")]
    DeadlineToRegisterMissed = RejectionReasonV3Code.DeadlineToRegisterMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_XMg74bKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_Yhd8obKyEemDyeh7tbvg1w")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_ay-FMbKyEemDyeh7tbvg1w")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV3Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_jm1HgbKyEemDyeh7tbvg1w")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonV3Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position is less than required threshold.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_nC3JgbKyEemDyeh7tbvg1w")]
    [Description(@"Position is less than required threshold.")]
    InsufficientThresholdPosition = RejectionReasonV3Code.InsufficientThresholdPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_o-Wl0bKyEemDyeh7tbvg1w")]
    [Description(@"Invalid registration information.")]
    RegistrationDiscrepancy = RejectionReasonV3Code.RegistrationDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_sPhbobKyEemDyeh7tbvg1w")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or no registered position.
    /// Encoded/decoded by serializers as &quot;NPOS&quot;.
    /// </summary>
    [EnumMember(Value = "NPOS")]
    [IsoId("_Fooo4bLHEemDyeh7tbvg1w")]
    [Description(@"Insufficient or no registered position.")]
    NoRegisteredPosition = RejectionReasonV3Code.NoRegisteredPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Im6X4bLHEemDyeh7tbvg1w")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_LNib4bLHEemDyeh7tbvg1w")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = RejectionReasonV3Code.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_OtAMYbLHEemDyeh7tbvg1w")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = RejectionReasonV3Code.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer or registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_QftgIbLHEemDyeh7tbvg1w")]
    [Description(@"Issuer or registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonV3Code.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Resolution number provided discrepancy.
    /// Encoded/decoded by serializers as &quot;RESN&quot;.
    /// </summary>
    [EnumMember(Value = "RESN")]
    [IsoId("_gxbbIbLHEemDyeh7tbvg1w")]
    [Description(@"Resolution number provided discrepancy.")]
    ResolutionNumberDiscrepancy = RejectionReasonV3Code.ResolutionNumberDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_if-AkbLHEemDyeh7tbvg1w")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_kJAa8bLHEemDyeh7tbvg1w")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = RejectionReasonV3Code.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_mM92wbLHEemDyeh7tbvg1w")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_uAQz8bLHEemDyeh7tbvg1w")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed position exceeds the eligible balance.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_KZ1cIcjCEem7mOT-LZ2mYQ")]
    [Description(@"Instructed position exceeds the eligible balance.")]
    LackofSecurities = RejectionReasonV3Code.LackofSecurities, // same ordinal as derivation source for type conversions
    
}
