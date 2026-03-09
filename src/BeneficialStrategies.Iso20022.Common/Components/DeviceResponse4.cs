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
[IsoId("_hevo4S5KEeunNvJlR_vCbg")]
[DisplayName("Device Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceResponse4( RetailerService9Code reqServiceContent,ResponseType11 reqResponse )
    {
        ServiceContent = reqServiceContent;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_hvVpoS5KEeunNvJlR_vCbg")]
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
    [IsoId("_hvVpoy5KEeunNvJlR_vCbg")]
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
    /// Define the type of service answered.
    /// </summary>
    [IsoId("_hvVppS5KEeunNvJlR_vCbg")]
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
    [IsoId("_hvVppy5KEeunNvJlR_vCbg")]
    [DisplayName("Display Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispRspn")]
    #endif
    [IsoXmlTag("DispRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceDisplayResponse2? DisplayResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceDisplayResponse2? DisplayResponse { get; init; } 
    #else
    public DeviceDisplayResponse2? DisplayResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [IsoId("_hvVpqS5KEeunNvJlR_vCbg")]
    [DisplayName("Input Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptRspn")]
    #endif
    [IsoXmlTag("InptRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInputResponse3? InputResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInputResponse3? InputResponse { get; init; } 
    #else
    public DeviceInputResponse3? InputResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [IsoId("_hvVpqy5KEeunNvJlR_vCbg")]
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
    [IsoId("_hvVprS5KEeunNvJlR_vCbg")]
    [DisplayName("Secure Input Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScrInptRspn")]
    #endif
    [IsoXmlTag("ScrInptRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSecureInputResponse3? SecureInputResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSecureInputResponse3? SecureInputResponse { get; init; } 
    #else
    public DeviceSecureInputResponse3? SecureInputResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content received after a card initialisation.
    /// </summary>
    [IsoId("_hvVpry5KEeunNvJlR_vCbg")]
    [DisplayName("Initialisation Card Reader Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnCardRdrRspn")]
    #endif
    [IsoXmlTag("InitlstnCardRdrRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; init; } 
    #else
    public DeviceInitialisationCardReaderResponse2? InitialisationCardReaderResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Reader APDU (Application Protocol Data Unit) response message.
    /// </summary>
    [IsoId("_hvVpsS5KEeunNvJlR_vCbg")]
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
    [IsoId("_hvVpsy5KEeunNvJlR_vCbg")]
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
    [IsoId("_hvVptS5KEeunNvJlR_vCbg")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType11 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType11 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType11 Response { get; init; } 
    #else
    public ResponseType11 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_hvVpty5KEeunNvJlR_vCbg")]
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
