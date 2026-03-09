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
[IsoId("_gvdHYQ0rEeqUVL7sB4m7NA")]
[DisplayName("Device Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceRequest3( RetailerService8Code reqServiceContent )
    {
        ServiceContent = reqServiceContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_g6-a4Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentEnvironment75? Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment75? Environment { get; init; } 
    #else
    public CardPaymentEnvironment75? Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_g6-a4w0rEeqUVL7sB4m7NA")]
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
    [IsoId("_g6-a5Q0rEeqUVL7sB4m7NA")]
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
    [IsoId("_g6-a5w0rEeqUVL7sB4m7NA")]
    [DisplayName("Display Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispReq")]
    #endif
    [IsoXmlTag("DispReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayRequest2? DisplayRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayRequest2? DisplayRequest { get; init; } 
    #else
    public DeviceDisplayRequest2? DisplayRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_g6-a6Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptReq")]
    #endif
    [IsoXmlTag("InptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputRequest2? InputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputRequest2? InputRequest { get; init; } 
    #else
    public DeviceInputRequest2? InputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_g6-a6w0rEeqUVL7sB4m7NA")]
    [DisplayName("Print Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtReq")]
    #endif
    [IsoXmlTag("PrtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePrintRequest2? PrintRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePrintRequest2? PrintRequest { get; init; } 
    #else
    public DevicePrintRequest2? PrintRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Sound Request message.
    /// </summary>
    [IsoId("_g6-a7Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Play Sound Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlaySoundReq")]
    #endif
    [IsoXmlTag("PlaySoundReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePlaySoundRequest1? PlaySoundRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePlaySoundRequest1? PlaySoundRequest { get; init; } 
    #else
    public DevicePlaySoundRequest1? PlaySoundRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    [IsoId("_g6-a7w0rEeqUVL7sB4m7NA")]
    [DisplayName("Secure Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptReq")]
    #endif
    [IsoXmlTag("ScrInptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputRequest2? SecureInputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputRequest2? SecureInputRequest { get; init; } 
    #else
    public DeviceSecureInputRequest2? SecureInputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_g6-a8Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Initialisation Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrReq")]
    #endif
    [IsoXmlTag("InitlstnCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderRequest2? InitialisationCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderRequest2? InitialisationCardReaderRequest { get; init; } 
    #else
    public DeviceInitialisationCardReaderRequest2? InitialisationCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_g6-a8w0rEeqUVL7sB4m7NA")]
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
    [IsoId("_g6-a9Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Power Off Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOffCardRdrReq")]
    #endif
    [IsoXmlTag("PwrOffCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePoweroffCardReaderRequest2? PowerOffCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePoweroffCardReaderRequest2? PowerOffCardReaderRequest { get; init; } 
    #else
    public DevicePoweroffCardReaderRequest2? PowerOffCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_g6-a9w0rEeqUVL7sB4m7NA")]
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
    [IsoId("_g6-a-Q0rEeqUVL7sB4m7NA")]
    [DisplayName("Input Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptNtfctn")]
    #endif
    [IsoXmlTag("InptNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputNotification2? InputNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputNotification2? InputNotification { get; init; } 
    #else
    public DeviceInputNotification2? InputNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_g6-a-w0rEeqUVL7sB4m7NA")]
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
