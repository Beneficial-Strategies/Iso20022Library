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
[IsoId("_HScVsU4AEey_VecAUE-C9Q")]
[DisplayName("Stored Value Data")]
public partial record StoredValueData5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// </summary>
    [IsoId("_HZbugU4AEey_VecAUE-C9Q")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; } 
    
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HZbug04AEey_VecAUE-C9Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required StoredValueTransactionType2Code TransactionType { get; init; } 
    
    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// </summary>
    [IsoId("_HZbuhU4AEey_VecAUE-C9Q")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public StoredValueAccount2? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [IsoId("_HZbuh04AEey_VecAUE-C9Q")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction120? OriginalPOITransaction { get; init; } 
    
    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HZbuiU4AEey_VecAUE-C9Q")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductCode { get; init; } 
    
    /// <summary>
    /// Standard European Article Number Universal Product Code of item purchased with the transaction.
    /// </summary>
    [IsoId("_HZbui04AEey_VecAUE-C9Q")]
    [DisplayName("EANUPC")]
    [IsoXmlTag("EANUPC")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? EANUPC { get; init; } 
    
    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [IsoId("_HZbujU4AEey_VecAUE-C9Q")]
    [DisplayName("Item Amount")]
    [IsoXmlTag("ItmAmt")]
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; } 
    
    /// <summary>
    /// Currency of the monetary amount.
    /// </summary>
    [IsoId("_HZbuj04AEey_VecAUE-C9Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// </summary>
    [IsoId("_HZbukU4AEey_VecAUE-C9Q")]
    [DisplayName("Host Transaction Identification")]
    [IsoXmlTag("HstTxId")]
    public TransactionIdentifier1? HostTransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}
