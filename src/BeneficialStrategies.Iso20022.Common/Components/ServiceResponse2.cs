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
[IsoId("_XH490YYAEemxIqbaFEE8-w")]
[DisplayName("Service Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceResponse2( CardPaymentEnvironment73 reqEnvironment,CardPaymentContext27 reqContext,RetailerService3Code reqServiceContent,ResponseType9 reqResponse )
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
    [IsoId("_XSS3AYYAEemxIqbaFEE8-w")]
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
    [IsoId("_XSS3A4YAEemxIqbaFEE8-w")]
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
    /// Define the type of service response.
    /// </summary>
    [IsoId("_XSS3BYYAEemxIqbaFEE8-w")]
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
    [IsoId("_XSS3B4YAEemxIqbaFEE8-w")]
    [DisplayName("Payment Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRspn")]
    #endif
    [IsoXmlTag("PmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse1? PaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse1? PaymentResponse { get; init; } 
    #else
    public PaymentResponse1? PaymentResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_XSS3CYYAEemxIqbaFEE8-w")]
    [DisplayName("Reversal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRspn")]
    #endif
    [IsoXmlTag("RvslRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalResponse1? ReversalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalResponse1? ReversalResponse { get; init; } 
    #else
    public ReversalResponse1? ReversalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_XSS3C4YAEemxIqbaFEE8-w")]
    [DisplayName("Balance Inquiry Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalNqryRspn")]
    #endif
    [IsoXmlTag("BalNqryRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceInquiryResponse1? BalanceInquiryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceInquiryResponse1? BalanceInquiryResponse { get; init; } 
    #else
    public BalanceInquiryResponse1? BalanceInquiryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_XSS3DYYAEemxIqbaFEE8-w")]
    [DisplayName("Loyalty Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyRspn")]
    #endif
    [IsoXmlTag("LltyRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResponse1? LoyaltyResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResponse1? LoyaltyResponse { get; init; } 
    #else
    public LoyaltyResponse1? LoyaltyResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_XSS3D4YAEemxIqbaFEE8-w")]
    [DisplayName("Stored Value Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValRspn")]
    #endif
    [IsoXmlTag("StordValRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueResponse2? StoredValueResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueResponse2? StoredValueResponse { get; init; } 
    #else
    public StoredValueResponse2? StoredValueResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_XSS3EYYAEemxIqbaFEE8-w")]
    [DisplayName("Batch Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchRspn")]
    #endif
    [IsoXmlTag("BtchRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchResponse1? BatchResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchResponse1? BatchResponse { get; init; } 
    #else
    public BatchResponse1? BatchResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_XSS3E4YAEemxIqbaFEE8-w")]
    [DisplayName("Card Acquisition Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardAcqstnRspn")]
    #endif
    [IsoXmlTag("CardAcqstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; init; } 
    #else
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_XSS3FYYAEemxIqbaFEE8-w")]
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
    [IsoId("_XSS3F4YAEemxIqbaFEE8-w")]
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
