// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a deactivation instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZgmKgdp-Ed-ak6NoX_4Aeg_1795040901")]
[Description(@"Specifies the reason of a rejection of a deactivation instruction.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason12Code
{
    /// <summary>
    /// Rejected as the deactivation of the event is already completed.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_ZgmKgtp-Ed-ak6NoX_4Aeg_-843380834")]
    [Description(@"Rejected as the deactivation of the event is already completed.")]
    EventAlreadyDeactivated = RejectionReasonCode.EventAlreadyDeactivated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZgmKg9p-Ed-ak6NoX_4Aeg_-843380804")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An Agent Corporate Action Deactivation Instruction with the same identification already exists.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_ZgmKhNp-Ed-ak6NoX_4Aeg_-843380803")]
    [Description(
        @"An Agent Corporate Action Deactivation Instruction with the same identification already exists."
    )]
    SameCAIdentification = RejectionReasonCode.SameCAIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_ZgmKhdp-Ed-ak6NoX_4Aeg_-843380773")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification = RejectionReasonCode.InvalidCAIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_ZgmKhtp-Ed-ak6NoX_4Aeg_-843380742")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent = RejectionReasonCode.InvalidAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent Identification specified does not correspond to the main Agent of the relating event.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_ZgmKh9p-Ed-ak6NoX_4Aeg_-843380712")]
    [Description(
        @"Agent Identification specified does not correspond to the main Agent of the relating event."
    )]
    NotMainAgent = RejectionReasonCode.NotMainAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid combination of CA option code and CA option number.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_ZgmKiNp-Ed-ak6NoX_4Aeg_-843380681")]
    [Description(@"Invalid combination of CA option code and CA option number.")]
    InvalidOption = RejectionReasonCode.InvalidOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The specified Corporate Action option already has a pending deactivation instruction.
    /// Encoded/decoded by serializers as &quot;PEDA&quot;.
    /// </summary>
    [EnumMember(Value = "PEDA")]
    [IsoId("_Zgv7gNp-Ed-ak6NoX_4Aeg_-843380651")]
    [Description(
        @"The specified Corporate Action option already has a pending deactivation instruction."
    )]
    PendingDeactivation = RejectionReasonCode.PendingDeactivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified Corporate Action has no remaining options to disable.
    /// Encoded/decoded by serializers as &quot;NORO&quot;.
    /// </summary>
    [EnumMember(Value = "NORO")]
    [IsoId("_Zgv7gdp-Ed-ak6NoX_4Aeg_-843380620")]
    [Description(@"Specified Corporate Action has no remaining options to disable.")]
    NoRemainingOption = RejectionReasonCode.NoRemainingOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INET&quot;.
    /// </summary>
    [EnumMember(Value = "INET")]
    [IsoId("_Zgv7gtp-Ed-ak6NoX_4Aeg_-843380372")]
    [Description(@"CA Event Type does not correspond with the relating Corporate Action.")]
    InvalidEventType = RejectionReasonCode.InvalidEventType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying Security Identification does not correspond with the Corporate Action Reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_Zgv7g9p-Ed-ak6NoX_4Aeg_-843380342")]
    [Description(
        @"Underlying Security Identification does not correspond with the Corporate Action Reference supplied."
    )]
    InvalidUnderlyingSecurity = RejectionReasonCode.InvalidUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event Processing Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_Zgv7hNp-Ed-ak6NoX_4Aeg_-843380311")]
    [Description(@"Event Processing Type does not correspond with the relating Corporate Action.")]
    InvalidEventProcessingType = RejectionReasonCode.InvalidEventProcessingType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action.
    /// Encoded/decoded by serializers as &quot;INMV&quot;.
    /// </summary>
    [EnumMember(Value = "INMV")]
    [IsoId("_Zgv7hdp-Ed-ak6NoX_4Aeg_-843379917")]
    [Description(
        @"Mandatory/Voluntary Event Type does not correspond with the relating Corporate Action."
    )]
    InvalidMandatoryVoluntaryEventType = RejectionReasonCode.InvalidMandatoryVoluntaryEventType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zgv7htp-Ed-ak6NoX_4Aeg_-843379886")]
    [Description(@"Several message with the same identification.")]
    SameIdentification = RejectionReasonCode.SameIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer CA Identification does not correspond with the Corporate Action Identification supplied.
    /// Encoded/decoded by serializers as &quot;MICA&quot;.
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("_Zgv7h9p-Ed-ak6NoX_4Aeg_-843379825")]
    [Description(
        @"Issuer CA Identification does not correspond with the Corporate Action Identification supplied."
    )]
    MismatchedCAIdentification = RejectionReasonCode.MismatchedCAIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_Zgv7iNp-Ed-ak6NoX_4Aeg_-843379764")]
    [Description(@"This instruction type is not applicable for mandatory events.")]
    NotApplicable = RejectionReasonCode.NotApplicable, // same ordinal as derivation source for type conversions
}
