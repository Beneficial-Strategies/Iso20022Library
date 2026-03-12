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
[IsoId("_He7-QXGzEe2TbaNWBpRZpQ")]
[DisplayName("Stored Value Data")]
public partial record StoredValueData6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// </summary>
    [IsoId("_HlJT8XGzEe2TbaNWBpRZpQ")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; } 
    
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HlJT83GzEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required StoredValueTransactionType2Code TransactionType { get; init; } 
    
    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HlJT9XGzEe2TbaNWBpRZpQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public StoredValueAccount2? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [IsoId("_HlJT93GzEe2TbaNWBpRZpQ")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction127? OriginalPOITransaction { get; init; } 
    
    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HlJT-XGzEe2TbaNWBpRZpQ")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductCode { get; init; } 
    
    /// <summary>
    /// Standard European Article Number Universal Product Code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HlJT-3GzEe2TbaNWBpRZpQ")]
    [DisplayName("EANUPC")]
    [IsoXmlTag("EANUPC")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? EANUPC { get; init; } 
    
    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [IsoId("_HlJT_XGzEe2TbaNWBpRZpQ")]
    [DisplayName("Item Amount")]
    [IsoXmlTag("ItmAmt")]
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; } 
    
    /// <summary>
    /// Currency of the monetary amount.
    /// </summary>
    [IsoId("_HlJT_3GzEe2TbaNWBpRZpQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// </summary>
    [IsoId("_HlJUAXGzEe2TbaNWBpRZpQ")]
    [DisplayName("Host Transaction Identification")]
    [IsoXmlTag("HstTxId")]
    public TransactionIdentifier1? HostTransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}
