// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal Response8.
/// </summary>
[IsoId("_JsNwUZRJEe6mHLZGMDWxvg")]
[DisplayName("Reversal Response8")]
public partial record ReversalResponse8
{
    #nullable enable

    /// <summary>
    /// Issuer Reference Data.
    /// </summary>
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax140Text? IssuerReferenceData { get; init; } 

    /// <summary>
    /// POI Reconciliation Identification.
    /// </summary>
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 

    /// <summary>
    /// POI Transaction Identification.
    /// </summary>
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 

    /// <summary>
    /// Receipt.
    /// </summary>
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt6> Receipt { get; init; } = [];

    /// <summary>
    /// Reversal Transaction Result.
    /// </summary>
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult6 ReversalTransactionResult { get; init; } 

    /// <summary>
    /// Reversed Amount.
    /// </summary>
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 

    /// <summary>
    /// Sale Reference Identification.
    /// </summary>
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 

    
    #nullable disable
    
}
