// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Request8.
/// </summary>
[IsoId("_22FhwaEsEe-MRKYsaX6JDg")]
[DisplayName("Device Request8")]
public partial record DeviceRequest8
{
    #nullable enable

    /// <summary>
    /// Card Reader APDU Request.
    /// </summary>
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 

    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public PaymentContext30? Context { get; init; } 

    /// <summary>
    /// Display Request.
    /// </summary>
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest6? DisplayRequest { get; init; } 

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment81? Environment { get; init; } 

    /// <summary>
    /// Initialisation Card Reader Request.
    /// </summary>
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest6? InitialisationCardReaderRequest { get; init; } 

    /// <summary>
    /// Input Notification.
    /// </summary>
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification6? InputNotification { get; init; } 

    /// <summary>
    /// Input Request.
    /// </summary>
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest6? InputRequest { get; init; } 

    /// <summary>
    /// Play Resource Request.
    /// </summary>
    [DisplayName("Play Resource Request")]
    [IsoXmlTag("PlayRsrcReq")]
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; } 

    /// <summary>
    /// Power Off Card Reader Request.
    /// </summary>
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest6? PowerOffCardReaderRequest { get; init; } 

    /// <summary>
    /// Print Request.
    /// </summary>
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest6? PrintRequest { get; init; } 

    /// <summary>
    /// Secure Input Request.
    /// </summary>
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest6? SecureInputRequest { get; init; } 

    /// <summary>
    /// Service Content.
    /// </summary>
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transmission Request.
    /// </summary>
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 

    
    #nullable disable
    
}
