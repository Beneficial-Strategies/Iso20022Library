// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_RS_foYYDEemxIqbaFEE8-w")]
[DisplayName("Device Request")]
public record DeviceRequest2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_RdKvUYYDEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_RdKvU4YDEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_RdKvVYYDEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_RdKvV4YDEemxIqbaFEE8-w")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest1? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_RdKvWYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest1? InputRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_RdKvW4YDEemxIqbaFEE8-w")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest1? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Sound Request message.
    /// </summary>
    [IsoId("_RdKvXYYDEemxIqbaFEE8-w")]
    [DisplayName("Play Sound Request")]
    [IsoXmlTag("PlaySoundReq")]
    public DevicePlaySoundRequest1? PlaySoundRequest { get; init; }

    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_RdKvX4YDEemxIqbaFEE8-w")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest1? SecureInputRequest { get; init; }

    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_RdKvYYYDEemxIqbaFEE8-w")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest1? InitialisationCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_RdKvY4YDEemxIqbaFEE8-w")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; }

    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_RdKvZYYDEemxIqbaFEE8-w")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest1? PowerOffCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_RdKvZ4YDEemxIqbaFEE8-w")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest1? TransmissionRequest { get; init; }

    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_RdKvaYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification1? InputNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_RdKva4YDEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
