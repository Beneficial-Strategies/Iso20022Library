// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cash settlement date is not recognised or is invalid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("f3ab3670-8ade-470b-8e4a-e1be73853fd1")]
[Description(@"Cash settlement date is not recognised or is invalid.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RejectedStatusReason14Code>))]
public enum RejectedStatusReason14Code
{
    /// <summary>
    /// Instruction was received after the Receiver's deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("0cc71e53-c391-423c-982d-72c827473ab4")]
    [Description(@"Instruction was received after the Receiver's deadline.")]
    AfterDeadline = RejectedStatusReasonCode.AfterDeadline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received after the cut-off time.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("594b0d79-107a-455e-8dd8-6db424c23de1")]
    [Description(@"Instruction has been received after the cut-off time.")]
    CutOffTime = RejectedStatusReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("3631f14b-9eea-41ef-8f76-bf35b04005d9")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to request a cancellation.
    /// Encoded/decoded by serializers as &quot;NALC&quot;.
    /// </summary>
    [EnumMember(Value = "NALC")]
    [IsoId("feb0b132-68c6-475a-85fd-7dc677b5d898")]
    [Description(@"Instructing party is not allowed to request a cancellation.")]
    NotAllowedToCancel = RejectedStatusReasonCode.NotAllowedToCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("4cfe8f6c-60e5-4e76-8d88-c441c453652f")]
    [Description(
        @"The cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoCancellationMatch = RejectedStatusReasonCode.NoCancellationMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("e200ba6d-f619-4ed1-85da-d18a0db96274")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is not known.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("15c29865-c505-458d-95b2-1dd4b0c9e8c0")]
    [Description(@"Linked reference is not known.")]
    UnknownLinkagesReference = RejectedStatusReasonCode.UnknownLinkagesReference, // same ordinal as derivation source for type conversions
}
