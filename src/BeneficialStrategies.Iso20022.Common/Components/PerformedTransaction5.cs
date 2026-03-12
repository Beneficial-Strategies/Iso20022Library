// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of performed transactions.
/// </summary>
[IsoId("_SoUJAXIMEe2OqYulmHWukQ")]
[DisplayName("Performed Transaction")]
public partial record PerformedTransaction5
{
    #nullable enable
    
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    [IsoId("_SyQIIXIMEe2OqYulmHWukQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    [IsoId("_SyQvMXIMEe2OqYulmHWukQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_SyQvM3IMEe2OqYulmHWukQ")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    [IsoId("_SyQvNXIMEe2OqYulmHWukQ")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_SyQvN3IMEe2OqYulmHWukQ")]
    [DisplayName("Payment Result")]
    [IsoXmlTag("PmtRslt")]
    public RetailerPaymentResult5? PaymentResult { get; init; } 
    
    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    [IsoId("_SyQvOXIMEe2OqYulmHWukQ")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public LoyaltyResult3? LoyaltyResult { get; init; } 
    
    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    [IsoId("_SyQvO3IMEe2OqYulmHWukQ")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    
    
    #nullable disable
    
}
