// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the response of the corresponding service request.
/// </summary>
[IsoId("_TTosAXIOEe2OqYulmHWukQ")]
[DisplayName("Service Response")]
public partial record ServiceResponse7
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_TaJjsXIOEe2OqYulmHWukQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_TaKx0XIOEe2OqYulmHWukQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext30 Context { get; init; } 
    
    /// <summary>
    /// Define the type of service response.
    /// </summary>
    [IsoId("_TaKx03IOEe2OqYulmHWukQ")]
    [DisplayName("Service Content")]
    [IsoXmlTag("SvcCntt")]
    public required RetailerService3Code ServiceContent { get; init; } 
    
    /// <summary>
    /// Data to respond to a Payment request.
    /// </summary>
    [IsoId("_TaKx1XIOEe2OqYulmHWukQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse5? PaymentResponse { get; init; } 
    
    /// <summary>
    /// Response Data to a Reversal request.
    /// </summary>
    [IsoId("_TaKx13IOEe2OqYulmHWukQ")]
    [DisplayName("Reversal Response")]
    [IsoXmlTag("RvslRspn")]
    public ReversalResponse7? ReversalResponse { get; init; } 
    
    /// <summary>
    /// Response data to a balance inquiry service request.
    /// </summary>
    [IsoId("_TaKx2XIOEe2OqYulmHWukQ")]
    [DisplayName("Balance Inquiry Response")]
    [IsoXmlTag("BalNqryRspn")]
    public BalanceInquiryResponse5? BalanceInquiryResponse { get; init; } 
    
    /// <summary>
    /// Response data to a loyalty service request.
    /// </summary>
    [IsoId("_TaKx23IOEe2OqYulmHWukQ")]
    [DisplayName("Loyalty Response")]
    [IsoXmlTag("LltyRspn")]
    public LoyaltyResponse3? LoyaltyResponse { get; init; } 
    
    /// <summary>
    /// Response data to a Stored Value request.
    /// </summary>
    [IsoId("_TaKx3XIOEe2OqYulmHWukQ")]
    [DisplayName("Stored Value Response")]
    [IsoXmlTag("StordValRspn")]
    public StoredValueResponse6? StoredValueResponse { get; init; } 
    
    /// <summary>
    /// Content of the Batch Response message.
    /// </summary>
    [IsoId("_TaL_8XIOEe2OqYulmHWukQ")]
    [DisplayName("Batch Response")]
    [IsoXmlTag("BtchRspn")]
    public BatchResponse5? BatchResponse { get; init; } 
    
    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [IsoId("_TaL_83IOEe2OqYulmHWukQ")]
    [DisplayName("Card Acquisition Response")]
    [IsoXmlTag("CardAcqstnRspn")]
    public CardAcquisitionResponse3? CardAcquisitionResponse { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_TaL_9XIOEe2OqYulmHWukQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_TaL_93IOEe2OqYulmHWukQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
