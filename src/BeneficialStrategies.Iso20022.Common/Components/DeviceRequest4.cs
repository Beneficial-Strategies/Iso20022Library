// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_YVZewS5KEeunNvJlR_vCbg")]
[DisplayName("Device Request")]
public partial record DeviceRequest4
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YjDgQS5KEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment77? Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_YjDgQy5KEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_YjDgRS5KEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService8Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_YjDgRy5KEeunNvJlR_vCbg")]
    [DisplayName("Display Request")]
    [IsoXmlTag("DispReq")]
    public DeviceDisplayRequest3? DisplayRequest { get; init; } 
    
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_YjDgSS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Request")]
    [IsoXmlTag("InptReq")]
    public DeviceInputRequest3? InputRequest { get; init; } 
    
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_YjDgSy5KEeunNvJlR_vCbg")]
    [DisplayName("Print Request")]
    [IsoXmlTag("PrtReq")]
    public DevicePrintRequest3? PrintRequest { get; init; } 
    
    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_YjDgTS5KEeunNvJlR_vCbg")]
    [DisplayName("Play Resource Request")]
    [IsoXmlTag("PlayRsrcReq")]
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; } 
    
    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_YjDgTy5KEeunNvJlR_vCbg")]
    [DisplayName("Secure Input Request")]
    [IsoXmlTag("ScrInptReq")]
    public DeviceSecureInputRequest3? SecureInputRequest { get; init; } 
    
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_YjDgUS5KEeunNvJlR_vCbg")]
    [DisplayName("Initialisation Card Reader Request")]
    [IsoXmlTag("InitlstnCardRdrReq")]
    public DeviceInitialisationCardReaderRequest3? InitialisationCardReaderRequest { get; init; } 
    
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_YjDgUy5KEeunNvJlR_vCbg")]
    [DisplayName("Card Reader APDU Request")]
    [IsoXmlTag("CardRdrAPDUReq")]
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 
    
    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_YjDgVS5KEeunNvJlR_vCbg")]
    [DisplayName("Power Off Card Reader Request")]
    [IsoXmlTag("PwrOffCardRdrReq")]
    public DevicePoweroffCardReaderRequest3? PowerOffCardReaderRequest { get; init; } 
    
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_YjDgVy5KEeunNvJlR_vCbg")]
    [DisplayName("Transmission Request")]
    [IsoXmlTag("TrnsmssnReq")]
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 
    
    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_YjDgWS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Notification")]
    [IsoXmlTag("InptNtfctn")]
    public DeviceInputNotification3? InputNotification { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_YjDgWy5KEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
