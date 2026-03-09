// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_YVZewS5KEeunNvJlR_vCbg")]
[DisplayName("Device Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceRequest4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceRequest4( RetailerService8Code reqServiceContent )
    {
        ServiceContent = reqServiceContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YjDgQS5KEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentEnvironment77? Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment77? Environment { get; init; } 
    #else
    public CardPaymentEnvironment77? Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_YjDgQy5KEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentContext28? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext28? Context { get; init; } 
    #else
    public CardPaymentContext28? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_YjDgRS5KEeunNvJlR_vCbg")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService8Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService8Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService8Code ServiceContent { get; init; } 
    #else
    public RetailerService8Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [IsoId("_YjDgRy5KEeunNvJlR_vCbg")]
    [DisplayName("Display Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispReq")]
    #endif
    [IsoXmlTag("DispReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayRequest3? DisplayRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayRequest3? DisplayRequest { get; init; } 
    #else
    public DeviceDisplayRequest3? DisplayRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_YjDgSS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptReq")]
    #endif
    [IsoXmlTag("InptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputRequest3? InputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputRequest3? InputRequest { get; init; } 
    #else
    public DeviceInputRequest3? InputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_YjDgSy5KEeunNvJlR_vCbg")]
    [DisplayName("Print Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtReq")]
    #endif
    [IsoXmlTag("PrtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePrintRequest3? PrintRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePrintRequest3? PrintRequest { get; init; } 
    #else
    public DevicePrintRequest3? PrintRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_YjDgTS5KEeunNvJlR_vCbg")]
    [DisplayName("Play Resource Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlayRsrcReq")]
    #endif
    [IsoXmlTag("PlayRsrcReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePlayResourceRequest1? PlayResourceRequest { get; init; } 
    #else
    public DevicePlayResourceRequest1? PlayResourceRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_YjDgTy5KEeunNvJlR_vCbg")]
    [DisplayName("Secure Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptReq")]
    #endif
    [IsoXmlTag("ScrInptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputRequest3? SecureInputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputRequest3? SecureInputRequest { get; init; } 
    #else
    public DeviceSecureInputRequest3? SecureInputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_YjDgUS5KEeunNvJlR_vCbg")]
    [DisplayName("Initialisation Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrReq")]
    #endif
    [IsoXmlTag("InitlstnCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderRequest3? InitialisationCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderRequest3? InitialisationCardReaderRequest { get; init; } 
    #else
    public DeviceInitialisationCardReaderRequest3? InitialisationCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_YjDgUy5KEeunNvJlR_vCbg")]
    [DisplayName("Card Reader APDU Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdrAPDUReq")]
    #endif
    [IsoXmlTag("CardRdrAPDUReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 
    #else
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    [IsoId("_YjDgVS5KEeunNvJlR_vCbg")]
    [DisplayName("Power Off Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOffCardRdrReq")]
    #endif
    [IsoXmlTag("PwrOffCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePoweroffCardReaderRequest3? PowerOffCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePoweroffCardReaderRequest3? PowerOffCardReaderRequest { get; init; } 
    #else
    public DevicePoweroffCardReaderRequest3? PowerOffCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_YjDgVy5KEeunNvJlR_vCbg")]
    [DisplayName("Transmission Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnReq")]
    #endif
    [IsoXmlTag("TrnsmssnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 
    #else
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_YjDgWS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptNtfctn")]
    #endif
    [IsoXmlTag("InptNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputNotification3? InputNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputNotification3? InputNotification { get; init; } 
    #else
    public DeviceInputNotification3? InputNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_YjDgWy5KEeunNvJlR_vCbg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
