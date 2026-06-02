// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the environment, the context and the services to be used with a device request message.
/// </summary>
[IsoId("_iM-c8bYDEfCUZfsQO4rYeA")]
[DisplayName("Device Request9")]
public record DeviceRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_iN4b5bYDEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment82? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_iN4b67YDEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public PaymentContext30? Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_iN4b8bYDEfCUZfsQO4rYeA")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_iN4b97YDEfCUZfsQO4rYeA")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest7? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_iN4b_bYDEfCUZfsQO4rYeA")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest7? InputRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_iN4cA7YDEfCUZfsQO4rYeA")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest7? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_iN4cCbYDEfCUZfsQO4rYeA")]
    [DisplayName("Play Resource Request")]
    [IsoXmlTag("PlayRsrcReq")]
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; }

    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_iN4cD7YDEfCUZfsQO4rYeA")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest6? SecureInputRequest { get; init; }

    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_iN4cFbYDEfCUZfsQO4rYeA")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest7? InitialisationCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_iN4cG7YDEfCUZfsQO4rYeA")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; }

    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_iN4cIbYDEfCUZfsQO4rYeA")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest7? PowerOffCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_iN4cJ7YDEfCUZfsQO4rYeA")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; }

    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_iN4cLbYDEfCUZfsQO4rYeA")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification7? InputNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_iN4cM7YDEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
