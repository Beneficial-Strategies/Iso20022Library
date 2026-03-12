// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the stored value card.
/// </summary>
[IsoId("_fPjngYYLEemxIqbaFEE8-w")]
[DisplayName("Stored Value Data")]
public partial record StoredValueData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// </summary>
    [IsoId("_faco4YYLEemxIqbaFEE8-w")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; } 
    
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// </summary>
    [IsoId("_faco44YLEemxIqbaFEE8-w")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required StoredValueTransactionType2Code TransactionType { get; init; } 
    
    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// </summary>
    [IsoId("_faco5YYLEemxIqbaFEE8-w")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public StoredValueAccount1? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [IsoId("_faco54YLEemxIqbaFEE8-w")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction91? OriginalPOITransaction { get; init; } 
    
    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [IsoId("_faco6YYLEemxIqbaFEE8-w")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductCode { get; init; } 
    
    /// <summary>
    /// Standard European Article Number Universal Product Code of item purchased with the transaction.
    /// </summary>
    [IsoId("_faco64YLEemxIqbaFEE8-w")]
    [DisplayName("EANUPC")]
    [IsoXmlTag("EANUPC")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? EANUPC { get; init; } 
    
    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [IsoId("_faco7YYLEemxIqbaFEE8-w")]
    [DisplayName("Item Amount")]
    [IsoXmlTag("ItmAmt")]
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; } 
    
    /// <summary>
    /// Currency of the monetary amount.
    /// </summary>
    [IsoId("_faco74YLEemxIqbaFEE8-w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// </summary>
    [IsoId("_faco8YYLEemxIqbaFEE8-w")]
    [DisplayName("Host Transaction Identification")]
    [IsoXmlTag("HstTxId")]
    public TransactionIdentifier1? HostTransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}
