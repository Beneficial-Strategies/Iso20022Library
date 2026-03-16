// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zl0BuNp-Ed-ak6NoX_4Aeg_1693452570")]
[Description(@"Specifies the reason of a rejection cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason7Code
{
    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_Zl9ysNp-Ed-ak6NoX_4Aeg_476926389")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated = RejectionReasonCode.EventAlreadyDeactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zl9ysdp-Ed-ak6NoX_4Aeg_476926419")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The cancellation request is rejected as there is no pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PDEA&quot;.
    /// </summary>
    [EnumMember(Value = "PDEA")]
    [IsoId("_Zl9ystp-Ed-ak6NoX_4Aeg_476926450")]
    [Description(
        @"The cancellation request is rejected as there is no pending deactivation instruction."
    )]
    NoPendingDeactivationInstruction = RejectionReasonCode.NoPendingDeactivationInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Zl9ys9p-Ed-ak6NoX_4Aeg_476926481")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification = RejectionReasonCode.InvalidIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_Zl9ytNp-Ed-ak6NoX_4Aeg_476926728")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification = RejectionReasonCode.InvalidCAIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_Zl9ytdp-Ed-ak6NoX_4Aeg_476926759")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent = RejectionReasonCode.InvalidAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zl9yttp-Ed-ak6NoX_4Aeg_476926790")]
    [Description(@"Several message with the same identification.")]
    SameIdentification = RejectionReasonCode.SameIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected as the deactivation of the option is already completed.
    /// Encoded/decoded by serializers as &quot;DEAO&quot;.
    /// </summary>
    [EnumMember(Value = "DEAO")]
    [IsoId("_Zl9yt9p-Ed-ak6NoX_4Aeg_476926820")]
    [Description(@"Rejected as the deactivation of the option is already completed.")]
    OptionAlreadyDeactivated = RejectionReasonCode.OptionAlreadyDeactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INET&quot;.
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Zl9yuNp-Ed-ak6NoX_4Aeg_476926851")]
    [Description(@"CA Event Type does not correspond with the relating Corporate Action.")]
    InvalidEventType = RejectionReasonCode.InvalidEventType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying Security Identification does not correspond with the Corporate Action Reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Zl9yudp-Ed-ak6NoX_4Aeg_476926882")]
    [Description(
        @"Underlying Security Identification does not correspond with the Corporate Action Reference supplied."
    )]
    InvalidUnderlyingSecurity = RejectionReasonCode.InvalidUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event Processing Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_ZmG8oNp-Ed-ak6NoX_4Aeg_476927160")]
    [Description(@"Event Processing Type does not correspond with the relating Corporate Action.")]
    InvalidEventProcessingType = RejectionReasonCode.InvalidEventProcessingType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INMV&quot;.
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_ZmG8odp-Ed-ak6NoX_4Aeg_476927191")]
    [Description(
        @"Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action."
    )]
    InvalidMandatoryVoluntaryEventType = RejectionReasonCode.InvalidMandatoryVoluntaryEventType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ZmG8otp-Ed-ak6NoX_4Aeg_476927244")]
    [Description(
        @"Details specified in the Corporate Action General Information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidCorporateActionInformation = RejectionReasonCode.InvalidCorporateActionInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_ZmG8o9p-Ed-ak6NoX_4Aeg_476927275")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails = RejectionReasonCode.InvalidDetails, // same ordinal as derivation source for type conversions
}
