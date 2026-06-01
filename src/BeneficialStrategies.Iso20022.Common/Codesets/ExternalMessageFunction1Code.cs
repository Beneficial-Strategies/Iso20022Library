// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify the type of process related to the message, as published separately in a message function external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RwXVAL8fEe6tVqdcbD5-mg")]
[Description(
    @"Code to identify the type of process related to the message, as published separately in a message function external code set. External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMessageFunctionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalMessageFunction1Code>))]
public enum ExternalMessageFunction1Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_B0R0YwySEe-uhfEdsrOCZg")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.")]
    Advice = ExternalMessageFunctionCode.Advice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification to initiate the transfer of a batch (no response expected).
    /// Encoded/decoded by serializers as &quot;BNTF&quot;.
    /// </summary>
    [EnumMember(Value = "BNTF")]
    [IsoId("__P-YsgyeEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a batch (no response expected).")]
    BatchNotification = ExternalMessageFunctionCode.BatchNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to initiate the transfer of a batch (response expected).
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_DPKLEgyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a batch (response expected).")]
    BatchRequest = ExternalMessageFunctionCode.BatchRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice about the capture of an activity already performed (response expected).
    /// Encoded/decoded by serializers as &quot;CAAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAAD")]
    [IsoId("_wy2n0QyeEe-uhfEdsrOCZg")]
    [Description(@"Advice about the capture of an activity already performed (response expected).")]
    CaptureAdvice = ExternalMessageFunctionCode.CaptureAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification about the capture of an activity already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_45O5EgyeEe-uhfEdsrOCZg")]
    [Description(@"Notification about the capture of an activity already performed (no response expected).")]
    CaptureNotification = ExternalMessageFunctionCode.CaptureNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification to initiate the transfer of a collection (no response expected).
    /// Encoded/decoded by serializers as &quot;CLNF&quot;.
    /// </summary>
    [EnumMember(Value = "CLNF")]
    [IsoId("_IJSiwgyfEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a collection (no response expected).")]
    CollectionNotification = ExternalMessageFunctionCode.CollectionNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to initiate the transfer of a collection (response expected).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_QlkykAyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a collection (response expected).")]
    CollectionRequest = ExternalMessageFunctionCode.CollectionRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification of a message containing errors.
    /// Encoded/decoded by serializers as &quot;ERNO&quot;.
    /// </summary>
    [EnumMember(Value = "ERNO")]
    [IsoId("_gS8qYQyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a message containing errors.")]
    ErrorNotification = ExternalMessageFunctionCode.ErrorNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Informs of an action to be taken.
    /// Encoded/decoded by serializers as &quot;INSN&quot;.
    /// </summary>
    [EnumMember(Value = "INSN")]
    [IsoId("_qMHu8QyfEe-uhfEdsrOCZg")]
    [Description(@"Informs of an action to be taken.")]
    Instruction = ExternalMessageFunctionCode.Instruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is notification.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_B0SbcQySEe-uhfEdsrOCZg")]
    [Description(@"Message function is notification.")]
    Notification = ExternalMessageFunctionCode.Notification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification of a rejected message.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_l0PvwgyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a rejected message.")]
    RejectNotification = ExternalMessageFunctionCode.RejectNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_B0R0YQySEe-uhfEdsrOCZg")]
    [Description(@"Message function is request.")]
    Request = ExternalMessageFunctionCode.Request, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STAD&quot;.
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_VUh1AgyfEe-uhfEdsrOCZg")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice = ExternalMessageFunctionCode.StatusAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STNO&quot;.
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_b5bscgyfEe-uhfEdsrOCZg")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification = ExternalMessageFunctionCode.StatusNotification, // same ordinal as derivation source for type conversions
}
