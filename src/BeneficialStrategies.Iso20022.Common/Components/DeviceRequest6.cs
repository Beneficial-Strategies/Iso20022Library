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
[IsoId("_t_XcUXGhEe2TbaNWBpRZpQ")]
[DisplayName("Device Request")]
public record DeviceRequest6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_uF0CkXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment79? Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_uF0Ck3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext30? Context { get; init; }

    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_uF0ClXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_uF0Cl3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest5? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_uF0CmXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest5? InputRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_uF0Cm3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest5? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_uF0CnXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Play Resource Request")]
    [IsoXmlTag("PlayRsrcReq")]
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; }

    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_uF0Cn3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest5? SecureInputRequest { get; init; }

    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_uF0CoXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest5? InitialisationCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_uF0Co3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; }

    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_uF1QsXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest5? PowerOffCardReaderRequest { get; init; }

    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_uF1Qs3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; }

    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_uF1QtXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification5? InputNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_uF1Qt3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
