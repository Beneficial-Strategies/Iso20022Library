// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Type And Additional Parameters21.
/// </summary>
[IsoId("_AD08MYVsEe-Pv9KR9bv9IA")]
[DisplayName("Transaction Type And Additional Parameters21")]
public partial record TransactionTypeAndAdditionalParameters21
{
    #nullable enable

    /// <summary>
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; } 

    /// <summary>
    /// Nonce Identification.
    /// </summary>
    [DisplayName("Nonce Identification")]
    [IsoXmlTag("NonceId")]
    public IsoMax35Text? NonceIdentification { get; init; } 

    /// <summary>
    /// Payment.
    /// </summary>
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; } 

    /// <summary>
    /// Reconciliation Indicator.
    /// </summary>
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; } 

    /// <summary>
    /// Securities Financing Transaction Type.
    /// </summary>
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; } 

    
    #nullable disable
    
}
