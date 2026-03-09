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
/// Specifies the environment, the context and the services to be used with a device request message.
/// </summary>
[IsoId("_t_XcUXGhEe2TbaNWBpRZpQ")]
[DisplayName("Device Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceRequest6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceRequest6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceRequest6( RetailerService8Code reqServiceContent )
    {
        ServiceContent = reqServiceContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_uF0CkXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentEnvironment79? Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment79? Environment { get; init; } 
    #else
    public CardPaymentEnvironment79? Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_uF0Ck3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentContext30? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext30? Context { get; init; } 
    #else
    public CardPaymentContext30? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_uF0ClXGhEe2TbaNWBpRZpQ")]
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
    [IsoId("_uF0Cl3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Display Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispReq")]
    #endif
    [IsoXmlTag("DispReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayRequest5? DisplayRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayRequest5? DisplayRequest { get; init; } 
    #else
    public DeviceDisplayRequest5? DisplayRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [IsoId("_uF0CmXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptReq")]
    #endif
    [IsoXmlTag("InptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputRequest5? InputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputRequest5? InputRequest { get; init; } 
    #else
    public DeviceInputRequest5? InputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [IsoId("_uF0Cm3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Print Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtReq")]
    #endif
    [IsoXmlTag("PrtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePrintRequest5? PrintRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePrintRequest5? PrintRequest { get; init; } 
    #else
    public DevicePrintRequest5? PrintRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Resource Request message.
    /// </summary>
    [IsoId("_uF0CnXGhEe2TbaNWBpRZpQ")]
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
    [IsoId("_uF0Cn3GhEe2TbaNWBpRZpQ")]
    [DisplayName("Secure Input Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptReq")]
    #endif
    [IsoXmlTag("ScrInptReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputRequest5? SecureInputRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputRequest5? SecureInputRequest { get; init; } 
    #else
    public DeviceSecureInputRequest5? SecureInputRequest { get; set; } 
    #endif
    
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    [IsoId("_uF0CoXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Initialisation Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrReq")]
    #endif
    [IsoXmlTag("InitlstnCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderRequest5? InitialisationCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderRequest5? InitialisationCardReaderRequest { get; init; } 
    #else
    public DeviceInitialisationCardReaderRequest5? InitialisationCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    [IsoId("_uF0Co3GhEe2TbaNWBpRZpQ")]
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
    [IsoId("_uF1QsXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Power Off Card Reader Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOffCardRdrReq")]
    #endif
    [IsoXmlTag("PwrOffCardRdrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePoweroffCardReaderRequest5? PowerOffCardReaderRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePoweroffCardReaderRequest5? PowerOffCardReaderRequest { get; init; } 
    #else
    public DevicePoweroffCardReaderRequest5? PowerOffCardReaderRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    [IsoId("_uF1Qs3GhEe2TbaNWBpRZpQ")]
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
    [IsoId("_uF1QtXGhEe2TbaNWBpRZpQ")]
    [DisplayName("Input Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptNtfctn")]
    #endif
    [IsoXmlTag("InptNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputNotification5? InputNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputNotification5? InputNotification { get; init; } 
    #else
    public DeviceInputNotification5? InputNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_uF1Qt3GhEe2TbaNWBpRZpQ")]
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
