// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component contains the response of the corresponding service request.
/// </summary>
[IsoId("_XH490YYAEemxIqbaFEE8-w")]
[DisplayName("Service Response")]
public partial record ServiceResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_XSS3AYYAEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_XSS3A4YAEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_XSS3BYYAEemxIqbaFEE8-w")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_XSS3B4YAEemxIqbaFEE8-w")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse1? PaymentResponse { get; init; } 
    
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_XSS3CYYAEemxIqbaFEE8-w")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse1? ReversalResponse { get; init; } 
    
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_XSS3C4YAEemxIqbaFEE8-w")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse1? BalanceInquiryResponse { get; init; } 
    
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_XSS3DYYAEemxIqbaFEE8-w")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse1? LoyaltyResponse { get; init; } 
    
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_XSS3D4YAEemxIqbaFEE8-w")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse2? StoredValueResponse { get; init; } 
    
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_XSS3EYYAEemxIqbaFEE8-w")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse1? BatchResponse { get; init; } 
    
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_XSS3E4YAEemxIqbaFEE8-w")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_XSS3FYYAEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_XSS3F4YAEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
