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
[IsoId("_gvdHYQ0rEeqUVL7sB4m7NA")]
[DisplayName("Device Request")]
public record DeviceRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_g6-a4Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment75? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_g6-a4w0rEeqUVL7sB4m7NA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_g6-a5Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_g6-a5w0rEeqUVL7sB4m7NA")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest2? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_g6-a6Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest2? InputRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_g6-a6w0rEeqUVL7sB4m7NA")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest2? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Sound Request message.
    /// </summary>
    [IsoId("_g6-a7Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Play Sound Request")]
    [IsoXmlTag("PlaySoundReq")]
    public DevicePlaySoundRequest1? PlaySoundRequest { get; init; }

    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_g6-a7w0rEeqUVL7sB4m7NA")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest2? SecureInputRequest { get; init; }

    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_g6-a8Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest2? InitialisationCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_g6-a8w0rEeqUVL7sB4m7NA")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; }

    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_g6-a9Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest2? PowerOffCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_g6-a9w0rEeqUVL7sB4m7NA")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; }

    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_g6-a-Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification2? InputNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_g6-a-w0rEeqUVL7sB4m7NA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
