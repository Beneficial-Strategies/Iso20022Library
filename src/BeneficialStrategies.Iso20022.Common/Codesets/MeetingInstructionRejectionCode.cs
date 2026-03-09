// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the possible rejection reasons.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpFtddp-Ed-ak6NoX_4Aeg_-315431614")]
[Description(@"Identifies the possible rejection reasons.")]
[Derivations(typeof(MeetingInstructionRejection1Code))]
public enum MeetingInstructionRejectionCode
{
    /// <summary>
    /// Instruction contains an invalid meeting reference.
    /// Encoded/decoded by serializers as &quot;INMR&quot;.
    /// </summary>
    [EnumMember(Value = "INMR")]
    [IsoId("_VpFtdtp-Ed-ak6NoX_4Aeg_-1691416163")]
    [Description(@"Instruction contains an invalid meeting reference.")]
    InvalidMeetingReference,
    
    /// <summary>
    /// Instruction contains an invalid account identification.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_VpFtd9p-Ed-ak6NoX_4Aeg_-1204717743")]
    [Description(@"Instruction contains an invalid account identification.")]
    InvalidAccount,
    
    /// <summary>
    /// Position is less than required threshold to be allowed to vote.
    /// Encoded/decoded by serializers as &quot;IPOS&quot;.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_VpFteNp-Ed-ak6NoX_4Aeg_787992222")]
    [Description(@"Position is less than required threshold to be allowed to vote.")]
    InsufficientSecurityPosition,
    
    /// <summary>
    /// Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).
    /// Encoded/decoded by serializers as &quot;INQY&quot;.
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_VpFtedp-Ed-ak6NoX_4Aeg_-1119755804")]
    [Description(@"Instruction contains an invalid instructed quantity (eg the instructed quantity is greater than the entitlement).")]
    InvalidInstructedQuantity,
    
    /// <summary>
    /// Instruction received after the specified deadline.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_VpPecNp-Ed-ak6NoX_4Aeg_-573954333")]
    [Description(@"Instruction received after the specified deadline.")]
    InvalidDate,
    
    /// <summary>
    /// Split voting is not allowed.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_VpPecdp-Ed-ak6NoX_4Aeg_913141247")]
    [Description(@"Split voting is not allowed.")]
    SplitVoteNotAllowed,
    
    /// <summary>
    /// Partial voting is not allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VpPectp-Ed-ak6NoX_4Aeg_1239143520")]
    [Description(@"Partial voting is not allowed.")]
    PartialVoteNotAllowed,
    
    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_VpPec9p-Ed-ak6NoX_4Aeg_-1808147630")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA,
    
    /// <summary>
    /// Invalid proxy information.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VpPedNp-Ed-ak6NoX_4Aeg_1784019512")]
    [Description(@"Invalid proxy information.")]
    ProxyCardDiscrepancy,
    
    /// <summary>
    /// Invalid re-registration information.
    /// Encoded/decoded by serializers as &quot;IREG&quot;.
    /// </summary>
    [EnumMember(Value = "IREG")]
    [IsoId("_VpPeddp-Ed-ak6NoX_4Aeg_-1666850052")]
    [Description(@"Invalid re-registration information.")]
    ReRegistrationDiscrepancy,
    
    /// <summary>
    /// Issuer has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_VpPedtp-Ed-ak6NoX_4Aeg_394462746")]
    [Description(@"Issuer has rejected the instruction.")]
    RejectedByIssuer,
    
    /// <summary>
    /// Other errors.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VpPed9p-Ed-ak6NoX_4Aeg_-2127686918")]
    [Description(@"Other errors.")]
    Other,
    
}
