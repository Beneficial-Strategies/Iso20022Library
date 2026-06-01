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
[IsoId("_o6qLAJgHEe6OBt2eQPMPsQ")]
[Description(
    @"Code to identify the type of process related to the message, as published separately in a message function external code set. External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalMessageFunction1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalMessageFunctionCode>))]
public enum ExternalMessageFunctionCode
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_LtvcgL8lEe6tVqdcbD5-mg")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.")]
    Advice,

    /// <summary>
    /// Notification to initiate the transfer of a batch (no response expected).
    /// Encoded/decoded by serializers as &quot;BNTF&quot;.
    /// </summary>
    [EnumMember(Value = "BNTF")]
    [IsoId("__P-YsAyeEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a batch (no response expected).")]
    BatchNotification,

    /// <summary>
    /// Request to initiate the transfer of a batch (response expected).
    /// Encoded/decoded by serializers as &quot;BTRQ&quot;.
    /// </summary>
    [EnumMember(Value = "BTRQ")]
    [IsoId("_DPKLEAyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a batch (response expected).")]
    BatchRequest,

    /// <summary>
    /// Advice about the capture of an activity already performed (response expected).
    /// Encoded/decoded by serializers as &quot;CAAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAAD")]
    [IsoId("_wy0yoAyeEe-uhfEdsrOCZg")]
    [Description(@"Advice about the capture of an activity already performed (response expected).")]
    CaptureAdvice,

    /// <summary>
    /// Notification about the capture of an activity already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_45O5EAyeEe-uhfEdsrOCZg")]
    [Description(@"Notification about the capture of an activity already performed (no response expected).")]
    CaptureNotification,

    /// <summary>
    /// Notification to initiate the transfer of a collection (no response expected).
    /// Encoded/decoded by serializers as &quot;CLNF&quot;.
    /// </summary>
    [EnumMember(Value = "CLNF")]
    [IsoId("_IJSiwAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification to initiate the transfer of a collection (no response expected).")]
    CollectionNotification,

    /// <summary>
    /// Request to initiate the transfer of a collection (response expected).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_QlkLgAyfEe-uhfEdsrOCZg")]
    [Description(@"Request to initiate the transfer of a collection (response expected).")]
    CollectionRequest,

    /// <summary>
    /// Notification of a message containing errors.
    /// Encoded/decoded by serializers as &quot;ERNO&quot;.
    /// </summary>
    [EnumMember(Value = "ERNO")]
    [IsoId("_gS8DUAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a message containing errors.")]
    ErrorNotification,

    /// <summary>
    /// Informs of an action to be taken.
    /// Encoded/decoded by serializers as &quot;INSN&quot;.
    /// </summary>
    [EnumMember(Value = "INSN")]
    [IsoId("_qMHH4AyfEe-uhfEdsrOCZg")]
    [Description(@"Informs of an action to be taken.")]
    Instruction,

    /// <summary>
    /// Message function is notification.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_M_GWsL8lEe6tVqdcbD5-mg")]
    [Description(@"Message function is notification.")]
    Notification,

    /// <summary>
    /// Notification of a rejected message.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("_l0PvwAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification of a rejected message.")]
    RejectNotification,

    /// <summary>
    /// Message function is request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_IAyCkL8lEe6tVqdcbD5-mg")]
    [Description(@"Message function is request.")]
    Request,

    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STAD&quot;.
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_VUh1AAyfEe-uhfEdsrOCZg")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice,

    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STNO&quot;.
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_b5bscAyfEe-uhfEdsrOCZg")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification,
}
