// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible rejection reasons.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpPeeNp-Ed-ak6NoX_4Aeg_597993338")]
[Description(@"Identifies the possible rejection reasons.")]
[DerivedFrom(typeof(MeetingInstructionRejectionCode))]
public enum MeetingInstructionRejection1Code
{
    /// <summary>
    /// Instruction contains an invalid meeting reference.
    /// Encoded/decoded by serializers as &quot;INMR&quot;.
    /// </summary>
    [EnumMember(Value = "INMR")]
    [IsoId("_VpPeedp-Ed-ak6NoX_4Aeg_700506198")]
    [Description(@"Instruction contains an invalid meeting reference.")]
    InvalidMeetingReference = MeetingInstructionRejectionCode.InvalidMeetingReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid account identification.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_VpYoYNp-Ed-ak6NoX_4Aeg_704197272")]
    [Description(@"Instruction contains an invalid account identification.")]
    InvalidAccount = MeetingInstructionRejectionCode.InvalidAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Position is less than required threshold to be allowed to vote.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_VpYoYdp-Ed-ak6NoX_4Aeg_1494487379")]
    [Description(@"Position is less than required threshold to be allowed to vote.")]
    InsufficientSecurityPosition = MeetingInstructionRejectionCode.InsufficientSecurityPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).
    /// Encoded/decoded by serializers as &quot;INQY&quot;.
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_VpYoYtp-Ed-ak6NoX_4Aeg_714356552")]
    [Description(@"Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).")]
    InvalidInstructedQuantity = MeetingInstructionRejectionCode.InvalidInstructedQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction received after the specified deadline.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_VpYoY9p-Ed-ak6NoX_4Aeg_717129391")]
    [Description(@"Instruction received after the specified deadline.")]
    InvalidDate = MeetingInstructionRejectionCode.InvalidDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_VpYoZNp-Ed-ak6NoX_4Aeg_1091710118")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed = MeetingInstructionRejectionCode.SplitVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VpYoZdp-Ed-ak6NoX_4Aeg_1122184465")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed = MeetingInstructionRejectionCode.PartialVoteNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_VpYoZtp-Ed-ak6NoX_4Aeg_1349369580")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = MeetingInstructionRejectionCode.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VpYoZ9p-Ed-ak6NoX_4Aeg_1367840945")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy = MeetingInstructionRejectionCode.ProxyCardDiscrepancy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_VpYoaNp-Ed-ak6NoX_4Aeg_534839775")]
    [Description(@"Issuer has rejected the instruction.")]
    RejectedByIssuer = MeetingInstructionRejectionCode.RejectedByIssuer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other errors.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VpYoadp-Ed-ak6NoX_4Aeg_1423253062")]
    [Description(@"Other errors.")]
    Other = MeetingInstructionRejectionCode.Other, // same ordinal as derivation source for type conversions
    
}
