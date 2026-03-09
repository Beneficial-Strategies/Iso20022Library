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
[IsoId("_l07w0VS8EeuUvsVXOV79DQ")]
[DisplayName("Service Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceResponse5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceResponse5( CardPaymentEnvironment77 reqEnvironment,CardPaymentContext28 reqContext,RetailerService3Code reqServiceContent,ResponseType11 reqResponse )
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
    [IsoId("_l7BKsVS8EeuUvsVXOV79DQ")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment77 Environment { get; init; } 
    #else
    public CardPaymentEnvironment77 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_l7BKs1S8EeuUvsVXOV79DQ")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext28 Context { get; init; } 
    #else
    public CardPaymentContext28 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_l7BKtVS8EeuUvsVXOV79DQ")]
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
    [IsoId("_l7BKt1S8EeuUvsVXOV79DQ")]
    [DisplayName("Payment Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRspn")]
    #endif
    [IsoXmlTag("PmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse3? PaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse3? PaymentResponse { get; init; } 
    #else
    public PaymentResponse3? PaymentResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_l7BKuVS8EeuUvsVXOV79DQ")]
    [DisplayName("Reversal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRspn")]
    #endif
    [IsoXmlTag("RvslRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalResponse5? ReversalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalResponse5? ReversalResponse { get; init; } 
    #else
    public ReversalResponse5? ReversalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_l7BKu1S8EeuUvsVXOV79DQ")]
    [DisplayName("Balance Inquiry Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalNqryRspn")]
    #endif
    [IsoXmlTag("BalNqryRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceInquiryResponse3? BalanceInquiryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceInquiryResponse3? BalanceInquiryResponse { get; init; } 
    #else
    public BalanceInquiryResponse3? BalanceInquiryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_l7BKvVS8EeuUvsVXOV79DQ")]
    [DisplayName("Loyalty Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyRspn")]
    #endif
    [IsoXmlTag("LltyRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResponse2? LoyaltyResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResponse2? LoyaltyResponse { get; init; } 
    #else
    public LoyaltyResponse2? LoyaltyResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_l7BKv1S8EeuUvsVXOV79DQ")]
    [DisplayName("Stored Value Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValRspn")]
    #endif
    [IsoXmlTag("StordValRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueResponse4? StoredValueResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueResponse4? StoredValueResponse { get; init; } 
    #else
    public StoredValueResponse4? StoredValueResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_l7BKwVS8EeuUvsVXOV79DQ")]
    [DisplayName("Batch Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchRspn")]
    #endif
    [IsoXmlTag("BtchRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchResponse3? BatchResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchResponse3? BatchResponse { get; init; } 
    #else
    public BatchResponse3? BatchResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_l7BKw1S8EeuUvsVXOV79DQ")]
    [DisplayName("Card Acquisition Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardAcqstnRspn")]
    #endif
    [IsoXmlTag("CardAcqstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; } 
    #else
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_l7BKxVS8EeuUvsVXOV79DQ")]
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
    [IsoId("_l7BKx1S8EeuUvsVXOV79DQ")]
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
