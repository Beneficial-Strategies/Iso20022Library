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
[IsoId("_jYNgQQ1VEeqjM-rxn3HuXQ")]
[DisplayName("Service Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ServiceRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ServiceRequest3( CardPaymentEnvironment75 reqEnvironment,CardPaymentContext28 reqContext,RetailerService2Code reqServiceContent )
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
    [IsoId("_jkawQQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment75 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment75 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment75 Environment { get; init; } 
    #else
    public CardPaymentEnvironment75 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_jkawQw1VEeqjM-rxn3HuXQ")]
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
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_jkawRQ1VEeqjM-rxn3HuXQ")]
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
    [IsoId("_jkawRw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Payment Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtReq")]
    #endif
    [IsoXmlTag("PmtReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentRequest2? PaymentRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentRequest2? PaymentRequest { get; init; } 
    #else
    public PaymentRequest2? PaymentRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_jkawSQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Reversal Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslReq")]
    #endif
    [IsoXmlTag("RvslReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalRequest2? ReversalRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalRequest2? ReversalRequest { get; init; } 
    #else
    public ReversalRequest2? ReversalRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_jkawSw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Balance Inquiry Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalNqryReq")]
    #endif
    [IsoXmlTag("BalNqryReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceInquiryRequest3? BalanceInquiryRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceInquiryRequest3? BalanceInquiryRequest { get; init; } 
    #else
    public BalanceInquiryRequest3? BalanceInquiryRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_jkawTQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Loyalty Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyReq")]
    #endif
    [IsoXmlTag("LltyReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRequest2? LoyaltyRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRequest2? LoyaltyRequest { get; init; } 
    #else
    public LoyaltyRequest2? LoyaltyRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_jkawTw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Stored Value Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValReq")]
    #endif
    [IsoXmlTag("StordValReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueRequest3? StoredValueRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueRequest3? StoredValueRequest { get; init; } 
    #else
    public StoredValueRequest3? StoredValueRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_jkawUQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Batch Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchReq")]
    #endif
    [IsoXmlTag("BtchReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BatchRequest2? BatchRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BatchRequest2? BatchRequest { get; init; } 
    #else
    public BatchRequest2? BatchRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_jkawUw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Enable Service Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NblSvcReq")]
    #endif
    [IsoXmlTag("NblSvcReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnableServiceRequest2? EnableServiceRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnableServiceRequest2? EnableServiceRequest { get; init; } 
    #else
    public EnableServiceRequest2? EnableServiceRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_jkawVQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Card Acquisition Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardAcqstnReq")]
    #endif
    [IsoXmlTag("CardAcqstnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; } 
    #else
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_jkawVw1VEeqjM-rxn3HuXQ")]
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
