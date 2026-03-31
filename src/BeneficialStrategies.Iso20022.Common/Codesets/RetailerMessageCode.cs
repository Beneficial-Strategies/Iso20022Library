// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dtx60Nj4EeiojJsa6FYyew")]
[Description(@"Identifies the type of process related to the message.")]
[Derivations(typeof(RetailerMessage1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RetailerMessageCode>))]
#endif
public enum RetailerMessageCode
{
    /// <summary>
    /// Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc.
    /// Encoded/decoded by serializers as &quot;SFSQ&quot;.
    /// </summary>
    [EnumMember(Value = "SFSQ")]
    [IsoId("_luQYYNj4EeiojJsa6FYyew")]
    [Description(
        @"Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc."
    )]
    SaleFinancialServiceRequest,

    /// <summary>
    /// Response to a financial service request.
    /// Encoded/decoded by serializers as &quot;SFSP&quot;.
    /// </summary>
    [EnumMember(Value = "SFSP")]
    [IsoId("_pY2a0Nj4EeiojJsa6FYyew")]
    [Description(@"Response to a financial service request.")]
    SaleFinancialServiceResponse,

    /// <summary>
    /// Request a reconciliation (different types) between Sale System and POI System.
    /// Encoded/decoded by serializers as &quot;SFRQ&quot;.
    /// </summary>
    [EnumMember(Value = "SFRQ")]
    [IsoId("_ssIJcNj4EeiojJsa6FYyew")]
    [Description(@"Request a reconciliation (different types) between Sale System and POI System.")]
    SaleFinancialReconciliationRequest,

    /// <summary>
    /// Response to a Reconciliation Request.
    /// Encoded/decoded by serializers as &quot;SFRP&quot;.
    /// </summary>
    [EnumMember(Value = "SFRP")]
    [IsoId("_vKg3cNj4EeiojJsa6FYyew")]
    [Description(@"Response to a Reconciliation Request.")]
    SaleFinancialReconciliationResponse,

    /// <summary>
    /// Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system.
    /// Encoded/decoded by serializers as &quot;SASQ&quot;.
    /// </summary>
    [EnumMember(Value = "SASQ")]
    [IsoId("_yZLL0Nj4EeiojJsa6FYyew")]
    [Description(
        @"Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system."
    )]
    SessionManagementRequest,

    /// <summary>
    /// Response to a session management request to initiate/terminate a session.
    /// Encoded/decoded by serializers as &quot;SASP&quot;.
    /// </summary>
    [EnumMember(Value = "SASP")]
    [IsoId("_1kvI4Nj4EeiojJsa6FYyew")]
    [Description(@"Response to a session management request to initiate/terminate a session.")]
    SessionManagementResponse,

    /// <summary>
    /// To select and start customised administrative services provided by the POI, using a &quot;menu&quot; for an interactive or software interface, initiated by the Sale system.
    /// Encoded/decoded by serializers as &quot;SAAQ&quot;.
    /// </summary>
    [EnumMember(Value = "SAAQ")]
    [IsoId("_6Ere8Nj4EeiojJsa6FYyew")]
    [Description(
        @"To select and start customised administrative services provided by the POI, using a ""menu"" for an interactive or software interface, initiated by the Sale system."
    )]
    AdminRequest,

    /// <summary>
    /// Response to the Admin request.
    /// Encoded/decoded by serializers as &quot;SAAP&quot;.
    /// </summary>
    [EnumMember(Value = "SAAP")]
    [IsoId("__kmrUNj4EeiojJsa6FYyew")]
    [Description(@"Response to the Admin request.")]
    AdminResponse,

    /// <summary>
    /// To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction.
    /// Encoded/decoded by serializers as &quot;SARQ&quot;.
    /// </summary>
    [EnumMember(Value = "SARQ")]
    [IsoId("_CsCWUNj5EeiojJsa6FYyew")]
    [Description(
        @"To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction."
    )]
    ReportRequest,

    /// <summary>
    /// Response to a Report request.
    /// Encoded/decoded by serializers as &quot;SARP&quot;.
    /// </summary>
    [EnumMember(Value = "SARP")]
    [IsoId("_FwMq4Nj5EeiojJsa6FYyew")]
    [Description(@"Response to a Report request.")]
    ReportResponse,

    /// <summary>
    /// Abort the current process or the last request.
    /// Encoded/decoded by serializers as &quot;SSAB&quot;.
    /// </summary>
    [EnumMember(Value = "SSAB")]
    [IsoId("_JLdQ0Nj5EeiojJsa6FYyew")]
    [Description(@"Abort the current process or the last request.")]
    Abort,

    /// <summary>
    /// Notify the other party of an event that occurs on its side.
    /// Encoded/decoded by serializers as &quot;SSEN&quot;.
    /// </summary>
    [EnumMember(Value = "SSEN")]
    [IsoId("_MJgWUNj5EeiojJsa6FYyew")]
    [Description(@"Notify the other party of an event that occurs on its side.")]
    EventNotification,

    /// <summary>
    /// Reject a previous received message, for technical or functional reasons.
    /// Encoded/decoded by serializers as &quot;SSRJ&quot;.
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_Qd6x0Nj5EeiojJsa6FYyew")]
    [Description(@"Reject a previous received message, for technical or functional reasons.")]
    Rejection,

    /// <summary>
    /// Request the status of a previous message for which the Sale system has no response.
    /// Encoded/decoded by serializers as &quot;SSMQ&quot;.
    /// </summary>
    [EnumMember(Value = "SSMQ")]
    [IsoId("_TBfh0Nj5EeiojJsa6FYyew")]
    [Description(
        @"Request the status of a previous message for which the Sale system has no response."
    )]
    MessageStatusRequest,

    /// <summary>
    /// Response to a Message Status request.
    /// Encoded/decoded by serializers as &quot;SSMR&quot;.
    /// </summary>
    [EnumMember(Value = "SSMR")]
    [IsoId("_W2xxUNj5EeiojJsa6FYyew")]
    [Description(@"Response to a Message Status request.")]
    MessageStatusResponse,

    /// <summary>
    /// Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message.
    /// Encoded/decoded by serializers as &quot;SDDR&quot;.
    /// </summary>
    [EnumMember(Value = "SDDR")]
    [IsoId("_baS_0Nj5EeiojJsa6FYyew")]
    [Description(
        @"Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message."
    )]
    DeviceRequest,

    /// <summary>
    /// Response to a Device request.
    /// Encoded/decoded by serializers as &quot;SDDP&quot;.
    /// </summary>
    [EnumMember(Value = "SDDP")]
    [IsoId("_hOsAUNj5EeiojJsa6FYyew")]
    [Description(@"Response to a Device request.")]
    DeviceResponse,
}
