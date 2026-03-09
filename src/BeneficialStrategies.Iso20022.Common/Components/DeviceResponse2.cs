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
/// This component define the type of Device service to be used with this message.
/// </summary>
[IsoId("_by2wwYYDEemxIqbaFEE8-w")]
[DisplayName("Device Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceResponse2( CardPaymentEnvironment73 reqEnvironment,CardPaymentContext27 reqContext,RetailerService9Code reqServiceContent,ResponseType9 reqResponse )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        ServiceContent = reqServiceContent;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_b9IuIYYDEemxIqbaFEE8-w")]
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
    [IsoId("_b9IuI4YDEemxIqbaFEE8-w")]
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
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_b9IuJYYDEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService9Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService9Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService9Code ServiceContent { get; init; } 
    #else
    public RetailerService9Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [IsoId("_b9IuJ4YDEemxIqbaFEE8-w")]
    [DisplayName("Display Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispRspn")]
    #endif
    [IsoXmlTag("DispRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayResponse1? DisplayResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayResponse1? DisplayResponse { get; init; } 
    #else
    public DeviceDisplayResponse1? DisplayResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_b9IuKYYDEemxIqbaFEE8-w")]
    [DisplayName("Input Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptRspn")]
    #endif
    [IsoXmlTag("InptRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputResponse1? InputResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputResponse1? InputResponse { get; init; } 
    #else
    public DeviceInputResponse1? InputResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_b9IuK4YDEemxIqbaFEE8-w")]
    [DisplayName("Print Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtRspn")]
    #endif
    [IsoXmlTag("PrtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DevicePrintResponse1? PrintResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DevicePrintResponse1? PrintResponse { get; init; } 
    #else
    public DevicePrintResponse1? PrintResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response to a secure input request.
    /// </summary>
    [IsoId("_b9IuLYYDEemxIqbaFEE8-w")]
    [DisplayName("Secure Input Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptRspn")]
    #endif
    [IsoXmlTag("ScrInptRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputResponse1? SecureInputResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputResponse1? SecureInputResponse { get; init; } 
    #else
    public DeviceSecureInputResponse1? SecureInputResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_b9IuL4YDEemxIqbaFEE8-w")]
    [DisplayName("Initialisation Card Reader Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrRspn")]
    #endif
    [IsoXmlTag("InitlstnCardRdrRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderResponse1? InitialisationCardReaderResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderResponse1? InitialisationCardReaderResponse { get; init; } 
    #else
    public DeviceInitialisationCardReaderResponse1? InitialisationCardReaderResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_b9IuMYYDEemxIqbaFEE8-w")]
    [DisplayName("Card Reader Application Protocol Data Unit Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdrApplPrtcolDataUnitRspn")]
    #endif
    [IsoXmlTag("CardRdrApplPrtcolDataUnitRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; init; } 
    #else
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? CardReaderApplicationProtocolDataUnitResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Transmit Response message.
    /// </summary>
    [IsoId("_b9IuM4YDEemxIqbaFEE8-w")]
    [DisplayName("Transmission Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnRspn")]
    #endif
    [IsoXmlTag("TrnsmssnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; init; } 
    #else
    public DeviceTransmitMessageResponse1? TransmissionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_b9IuNYYDEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType9 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType9 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType9 Response { get; init; } 
    #else
    public ResponseType9 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_b9IuN4YDEemxIqbaFEE8-w")]
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
