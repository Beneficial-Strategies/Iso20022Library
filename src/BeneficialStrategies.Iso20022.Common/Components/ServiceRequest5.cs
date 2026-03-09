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
/// This component defines the service to be called.
/// </summary>
[IsoId("_R3lwcU31Eey_VecAUE-C9Q")]
[DisplayName("Service Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceRequest5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceRequest5( CardPaymentEnvironment78 reqEnvironment,CardPaymentContext29 reqContext,RetailerService2Code reqServiceContent )
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
    [IsoId("_R9zGIU31Eey_VecAUE-C9Q")]
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
    [IsoId("_R9zGI031Eey_VecAUE-C9Q")]
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
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_R9zGJU31Eey_VecAUE-C9Q")]
    [DisplayName("Service Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCntt")]
    #endif
    [IsoXmlTag("SvcCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService2Code ServiceContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService2Code ServiceContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService2Code ServiceContent { get; init; } 
    #else
    public RetailerService2Code ServiceContent { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_R9ztMU31Eey_VecAUE-C9Q")]
    [DisplayName("Payment Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtReq")]
    #endif
    [IsoXmlTag("PmtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentRequest4? PaymentRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentRequest4? PaymentRequest { get; init; } 
    #else
    public PaymentRequest4? PaymentRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_R9ztM031Eey_VecAUE-C9Q")]
    [DisplayName("Reversal Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslReq")]
    #endif
    [IsoXmlTag("RvslReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalRequest4? ReversalRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalRequest4? ReversalRequest { get; init; } 
    #else
    public ReversalRequest4? ReversalRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_R9ztNU31Eey_VecAUE-C9Q")]
    [DisplayName("Balance Inquiry Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalNqryReq")]
    #endif
    [IsoXmlTag("BalNqryReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceInquiryRequest5? BalanceInquiryRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceInquiryRequest5? BalanceInquiryRequest { get; init; } 
    #else
    public BalanceInquiryRequest5? BalanceInquiryRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_R9ztN031Eey_VecAUE-C9Q")]
    [DisplayName("Loyalty Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyReq")]
    #endif
    [IsoXmlTag("LltyReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRequest4? LoyaltyRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRequest4? LoyaltyRequest { get; init; } 
    #else
    public LoyaltyRequest4? LoyaltyRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_R9ztOU31Eey_VecAUE-C9Q")]
    [DisplayName("Stored Value Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValReq")]
    #endif
    [IsoXmlTag("StordValReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueRequest5? StoredValueRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueRequest5? StoredValueRequest { get; init; } 
    #else
    public StoredValueRequest5? StoredValueRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_R9ztO031Eey_VecAUE-C9Q")]
    [DisplayName("Batch Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchReq")]
    #endif
    [IsoXmlTag("BtchReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchRequest4? BatchRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchRequest4? BatchRequest { get; init; } 
    #else
    public BatchRequest4? BatchRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_R9ztPU31Eey_VecAUE-C9Q")]
    [DisplayName("Enable Service Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NblSvcReq")]
    #endif
    [IsoXmlTag("NblSvcReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnableServiceRequest4? EnableServiceRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnableServiceRequest4? EnableServiceRequest { get; init; } 
    #else
    public EnableServiceRequest4? EnableServiceRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_R9ztP031Eey_VecAUE-C9Q")]
    [DisplayName("Card Acquisition Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardAcqstnReq")]
    #endif
    [IsoXmlTag("CardAcqstnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; } 
    #else
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_R9ztQU31Eey_VecAUE-C9Q")]
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
