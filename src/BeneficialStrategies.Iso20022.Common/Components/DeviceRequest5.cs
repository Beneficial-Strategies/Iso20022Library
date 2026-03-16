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
[IsoId("_2QiaAU6mEeyGi9JAv6wq7Q")]
[DisplayName("Device Request")]
public record DeviceRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_2XXawU6mEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment78? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_2XYB0U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext29? Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_2XYB006mEeyGi9JAv6wq7Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_2XYB1U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest4? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_2XYB106mEeyGi9JAv6wq7Q")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest4? InputRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_2XYB2U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest4? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_2XYB206mEeyGi9JAv6wq7Q")]
    [DisplayName("Play Resource Request")]
    [IsoXmlTag("PlayRsrcReq")]
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; }

    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_2XYB3U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest4? SecureInputRequest { get; init; }

    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_2XYB306mEeyGi9JAv6wq7Q")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest4? InitialisationCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_2XYB4U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; }

    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_2XYB406mEeyGi9JAv6wq7Q")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest4? PowerOffCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_2XYB5U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; }

    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_2XYB506mEeyGi9JAv6wq7Q")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification4? InputNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_2XYB6U6mEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
