// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Action associated with a result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ActionType14Code")]
[Description(@"Action associated with a result.")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType14Code
{
    /// <summary>
    /// Activate device or service.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ActionType14Code_Activate")]
    [Description(@"Activate device or service.")]
    Activate = ActionTypeCode.Activate,

    /// <summary>
    /// Additional verification of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDV&quot;.
    /// </summary>
    [EnumMember(Value = "CHDV")]
    [IsoId("_ActionType14Code_CardholderVerification")]
    [Description(@"Additional verification of cardholder required.")]
    CardholderVerification = ActionTypeCode.CardholderVerification,

    /// <summary>
    /// Card acceptor to call acquirer’s security department.
    /// Encoded/decoded by serializers as &quot;CNAS&quot;.
    /// </summary>
    [EnumMember(Value = "CNAS")]
    [IsoId("_ActionType14Code_ContactAcquirerSecurity")]
    [Description(@"Card acceptor to call acquirer’s security department.")]
    ContactAcquirerSecurity = ActionTypeCode.ContactAcquirerSecurity,

    /// <summary>
    /// Refer to card issuer’s special conditions.
    /// Encoded/decoded by serializers as &quot;CNIS&quot;.
    /// </summary>
    [EnumMember(Value = "CNIS")]
    [IsoId("_ActionType14Code_ContactIssuerSpecialConditions")]
    [Description(@"Refer to card issuer’s special conditions.")]
    ContactIssuerSpecialConditions = ActionTypeCode.ContactIssuerSpecialConditions,

    /// <summary>
    /// Contact acquirer.
    /// Encoded/decoded by serializers as &quot;CNTA&quot;.
    /// </summary>
    [EnumMember(Value = "CNTA")]
    [IsoId("_ActionType14Code_ContactAcquirer")]
    [Description(@"Contact acquirer.")]
    ContactAcquirer = ActionTypeCode.ContactAcquirer,

    /// <summary>
    /// Contact card issuer.
    /// Encoded/decoded by serializers as &quot;CNTI&quot;.
    /// </summary>
    [EnumMember(Value = "CNTI")]
    [IsoId("_ActionType14Code_ContactIssuer")]
    [Description(@"Contact card issuer.")]
    ContactIssuer = ActionTypeCode.ContactIssuer,

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_ActionType14Code_CaptureCard")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard,

    /// <summary>
    /// Deactivate device or service.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_ActionType14Code_Deactivate")]
    [Description(@"Deactivate device or service.")]
    Deactivate = ActionTypeCode.Deactivate,

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ActionType14Code_DisplayMessage")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage,

    /// <summary>
    /// Update a data file.
    /// Encoded/decoded by serializers as &quot;FUPD&quot;.
    /// </summary>
    [EnumMember(Value = "FUPD")]
    [IsoId("_ActionType14Code_FileUpdate")]
    [Description(@"Update a data file.")]
    FileUpdate = ActionTypeCode.FileUpdate,

    /// <summary>
    /// Other action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_ActionType14Code_OtherNational")]
    [Description(@"Other action defined at national level.")]
    OtherNational = ActionTypeCode.OtherNational,

    /// <summary>
    /// Other action defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ActionType14Code_OtherPrivate")]
    [Description(@"Other action defined at private level")]
    OtherPrivate = ActionTypeCode.OtherPrivate,

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_ActionType14Code_PrintMessage")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage,

    /// <summary>
    /// Signature required.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_ActionType14Code_Signature")]
    [Description(@"Signature required.")]
    Signature = ActionTypeCode.Signature,

    /// <summary>
    /// Send a message.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_ActionType14Code_SendMessage")]
    [Description(@"Send a message.")]
    SendMessage = ActionTypeCode.SendMessage,

    /// <summary>
    /// Track provided in the response must be updated on the card.
    /// Encoded/decoded by serializers as &quot;TRCK&quot;.
    /// </summary>
    [EnumMember(Value = "TRCK")]
    [IsoId("_ActionType14Code_UpdateTrack")]
    [Description(@"Track provided in the response must be updated on the card.")]
    UpdateTrack = ActionTypeCode.UpdateTrack,

    /// <summary>
    /// Transaction to be re-entered.
    /// Encoded/decoded by serializers as &quot;TRXR&quot;.
    /// </summary>
    [EnumMember(Value = "TRXR")]
    [IsoId("_ActionType14Code_ReEnterTransaction")]
    [Description(@"Transaction to be re-entered.")]
    ReEnterTransaction = ActionTypeCode.ReEnterTransaction,

    /// <summary>
    /// Manage account as a VIP one.
    /// Encoded/decoded by serializers as &quot;VIPM&quot;.
    /// </summary>
    [EnumMember(Value = "VIPM")]
    [IsoId("_ActionType14Code_VIPAccountManagement")]
    [Description(@"Manage account as a VIP one.")]
    VIPAccountManagement = ActionTypeCode.VIPAccountManagement,

}
