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
[IsoId("_RS_foYYDEemxIqbaFEE8-w")]
[DisplayName("Device Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceRequest2( CardPaymentEnvironment73 reqEnvironment,CardPaymentContext27 reqContext,RetailerService8Code reqServiceContent )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        ServiceContent = reqServiceContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_RdKvUYYDEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment73 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment73 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment73 Environment { get; init; } 
    #else
    public CardPaymentEnvironment73 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_RdKvU4YDEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext27 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext27 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext27 Context { get; init; } 
    #else
    public CardPaymentContext27 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_RdKvVYYDEemxIqbaFEE8-w")]
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
    [IsoId("_RdKvV4YDEemxIqbaFEE8-w")]
    [DisplayName("Display Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispReq")]
    #endif
    [IsoXmlTag("DispReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayRequest1? DisplayRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayRequest1? DisplayRequest { get; init; } 
    #else
    public DeviceDisplayRequest1? DisplayRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_RdKvWYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptReq")]
    #endif
    [IsoXmlTag("InptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputRequest1? InputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputRequest1? InputRequest { get; init; } 
    #else
    public DeviceInputRequest1? InputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_RdKvW4YDEemxIqbaFEE8-w")]
    [DisplayName("Print Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtReq")]
    #endif
    [IsoXmlTag("PrtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePrintRequest1? PrintRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePrintRequest1? PrintRequest { get; init; } 
    #else
    public DevicePrintRequest1? PrintRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Sound Request message.
    /// </summary>
    [IsoId("_RdKvXYYDEemxIqbaFEE8-w")]
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
    [IsoId("_RdKvX4YDEemxIqbaFEE8-w")]
    [DisplayName("Secure Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptReq")]
    #endif
    [IsoXmlTag("ScrInptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputRequest1? SecureInputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputRequest1? SecureInputRequest { get; init; } 
    #else
    public DeviceSecureInputRequest1? SecureInputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_RdKvYYYDEemxIqbaFEE8-w")]
    [DisplayName("Initialisation Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrReq")]
    #endif
    [IsoXmlTag("InitlstnCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderRequest1? InitialisationCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderRequest1? InitialisationCardReaderRequest { get; init; } 
    #else
    public DeviceInitialisationCardReaderRequest1? InitialisationCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_RdKvY4YDEemxIqbaFEE8-w")]
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
    [IsoId("_RdKvZYYDEemxIqbaFEE8-w")]
    [DisplayName("Power Off Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOffCardRdrReq")]
    #endif
    [IsoXmlTag("PwrOffCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePoweroffCardReaderRequest1? PowerOffCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePoweroffCardReaderRequest1? PowerOffCardReaderRequest { get; init; } 
    #else
    public DevicePoweroffCardReaderRequest1? PowerOffCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_RdKvZ4YDEemxIqbaFEE8-w")]
    [DisplayName("Transmission Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnReq")]
    #endif
    [IsoXmlTag("TrnsmssnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceTransmitMessageRequest1? TransmissionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceTransmitMessageRequest1? TransmissionRequest { get; init; } 
    #else
    public DeviceTransmitMessageRequest1? TransmissionRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    [IsoId("_RdKvaYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptNtfctn")]
    #endif
    [IsoXmlTag("InptNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputNotification1? InputNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputNotification1? InputNotification { get; init; } 
    #else
    public DeviceInputNotification1? InputNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_RdKva4YDEemxIqbaFEE8-w")]
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
