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
[IsoId("_jYNgQQ1VEeqjM-rxn3HuXQ")]
[DisplayName("Service Request")]
public partial record ServiceRequest3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_jkawQQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_jkawQw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    [IsoId("_jkawRQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService2Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Content of the payment request.
    /// </summary>
    [IsoId("_jkawRw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Payment Request")]
    [IsoXmlTag("PmtReq")]
    public PaymentRequest2? PaymentRequest { get; init; } 
    
    /// <summary>
    /// Content of the reversal request.
    /// </summary>
    [IsoId("_jkawSQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Reversal Request")]
    [IsoXmlTag("RvslReq")]
    public ReversalRequest2? ReversalRequest { get; init; } 
    
    /// <summary>
    /// Content of a Balance Inquiry Request.
    /// </summary>
    [IsoId("_jkawSw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Balance Inquiry Request")]
    [IsoXmlTag("BalNqryReq")]
    public BalanceInquiryRequest3? BalanceInquiryRequest { get; init; } 
    
    /// <summary>
    /// Content of the Loyalty Request.
    /// </summary>
    [IsoId("_jkawTQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public LoyaltyRequest2? LoyaltyRequest { get; init; } 
    
    /// <summary>
    /// Content of a Stored Value Request.
    /// </summary>
    [IsoId("_jkawTw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Stored Value Request")]
    [IsoXmlTag("StordValReq")]
    public StoredValueRequest3? StoredValueRequest { get; init; } 
    
    /// <summary>
    /// Content of the Batch Request.
    /// </summary>
    [IsoId("_jkawUQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Batch Request")]
    [IsoXmlTag("BtchReq")]
    public BatchRequest2? BatchRequest { get; init; } 
    
    /// <summary>
    /// Content of the Enable Service Request.
    /// </summary>
    [IsoId("_jkawUw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Enable Service Request")]
    [IsoXmlTag("NblSvcReq")]
    public EnableServiceRequest2? EnableServiceRequest { get; init; } 
    
    /// <summary>
    /// Content of the Card Acquisition Request.
    /// </summary>
    [IsoId("_jkawVQ1VEeqjM-rxn3HuXQ")]
    [DisplayName("Card Acquisition Request")]
    [IsoXmlTag("CardAcqstnReq")]
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_jkawVw1VEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
