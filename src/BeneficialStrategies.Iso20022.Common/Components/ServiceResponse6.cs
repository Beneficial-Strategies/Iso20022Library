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
/// This component contains the response of the corresponding service request.
/// </summary>
[IsoId("_BynvsU0_Eeybj420QgWBkA")]
[DisplayName("Service Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceResponse6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceResponse6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceResponse6( CardPaymentEnvironment78 reqEnvironment,CardPaymentContext29 reqContext,RetailerService3Code reqServiceContent,ResponseType11 reqResponse )
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
    [IsoId("_B5udQU0_Eeybj420QgWBkA")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment78 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment78 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment78 Environment { get; init; } 
    #else
    public CardPaymentEnvironment78 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_B5udQ00_Eeybj420QgWBkA")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext29 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext29 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext29 Context { get; init; } 
    #else
    public CardPaymentContext29 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_B5udRU0_Eeybj420QgWBkA")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService3Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService3Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService3Code ServiceContent { get; init; } 
    #else
    public RetailerService3Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_B5udR00_Eeybj420QgWBkA")]
    [DisplayName("Payment Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRspn")]
    #endif
    [IsoXmlTag("PmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse4? PaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse4? PaymentResponse { get; init; } 
    #else
    public PaymentResponse4? PaymentResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_B5udSU0_Eeybj420QgWBkA")]
    [DisplayName("Reversal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRspn")]
    #endif
    [IsoXmlTag("RvslRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalResponse6? ReversalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalResponse6? ReversalResponse { get; init; } 
    #else
    public ReversalResponse6? ReversalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_B5udS00_Eeybj420QgWBkA")]
    [DisplayName("Balance Inquiry Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalNqryRspn")]
    #endif
    [IsoXmlTag("BalNqryRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceInquiryResponse4? BalanceInquiryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceInquiryResponse4? BalanceInquiryResponse { get; init; } 
    #else
    public BalanceInquiryResponse4? BalanceInquiryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_B5udTU0_Eeybj420QgWBkA")]
    [DisplayName("Loyalty Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyRspn")]
    #endif
    [IsoXmlTag("LltyRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResponse3? LoyaltyResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResponse3? LoyaltyResponse { get; init; } 
    #else
    public LoyaltyResponse3? LoyaltyResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_B5udT00_Eeybj420QgWBkA")]
    [DisplayName("Stored Value Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValRspn")]
    #endif
    [IsoXmlTag("StordValRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueResponse5? StoredValueResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueResponse5? StoredValueResponse { get; init; } 
    #else
    public StoredValueResponse5? StoredValueResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_B5udUU0_Eeybj420QgWBkA")]
    [DisplayName("Batch Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchRspn")]
    #endif
    [IsoXmlTag("BtchRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchResponse4? BatchResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchResponse4? BatchResponse { get; init; } 
    #else
    public BatchResponse4? BatchResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_B5udU00_Eeybj420QgWBkA")]
    [DisplayName("Card Acquisition Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardAcqstnRspn")]
    #endif
    [IsoXmlTag("CardAcqstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; } 
    #else
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_B5udVU0_Eeybj420QgWBkA")]
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
    [IsoId("_B5udV00_Eeybj420QgWBkA")]
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
