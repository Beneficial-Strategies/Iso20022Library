// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component defines the service to be called.
/// </summary>
[IsoId("_R3lwcU31Eey_VecAUE-C9Q")]
[DisplayName("Service Request")]
public partial record ServiceRequest5
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_R9zGIU31Eey_VecAUE-C9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_R9zGI031Eey_VecAUE-C9Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_R9zGJU31Eey_VecAUE-C9Q")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_R9ztMU31Eey_VecAUE-C9Q")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest4? PaymentRequest { get; init; } 
    
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_R9ztM031Eey_VecAUE-C9Q")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest4? ReversalRequest { get; init; } 
    
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_R9ztNU31Eey_VecAUE-C9Q")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest5? BalanceInquiryRequest { get; init; } 
    
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_R9ztN031Eey_VecAUE-C9Q")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest4? LoyaltyRequest { get; init; } 
    
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_R9ztOU31Eey_VecAUE-C9Q")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest5? StoredValueRequest { get; init; } 
    
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_R9ztO031Eey_VecAUE-C9Q")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest4? BatchRequest { get; init; } 
    
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_R9ztPU31Eey_VecAUE-C9Q")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest4? EnableServiceRequest { get; init; } 
    
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_R9ztP031Eey_VecAUE-C9Q")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_R9ztQU31Eey_VecAUE-C9Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
