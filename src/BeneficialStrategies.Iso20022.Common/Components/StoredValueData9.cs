// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the stored value card.
/// </summary>
[IsoId("_5WJ-YbZYEfCUZfsQO4rYeA")]
[DisplayName("Stored Value Data9")]
public record StoredValueData9
{
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// </summary>
    [IsoId("_5XNuVbZYEfCUZfsQO4rYeA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// </summary>
    [IsoId("_5XNuW7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required StoredValueTransactionType3Code TransactionType { get; init; }

    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// </summary>
    [IsoId("_5XNuYbZYEfCUZfsQO4rYeA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public StoredValueAccount2? AccountIdentification { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// </summary>
    [IsoId("_5XNuZ7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public PaymentTransaction183? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [IsoId("_5XNubbZYEfCUZfsQO4rYeA")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax35Text? ProductCode { get; init; }

    /// <summary>
    /// Standard European Article Number Universal Product Code of item purchased with the transaction.
    /// </summary>
    [IsoId("_5XNuc7ZYEfCUZfsQO4rYeA")]
    [DisplayName("EANUPC")]
    [IsoXmlTag("EANUPC")]
    public IsoMax35NumericText? EANUPC { get; init; }

    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [IsoId("_5XNuebZYEfCUZfsQO4rYeA")]
    [DisplayName("Item Amount")]
    [IsoXmlTag("ItmAmt")]
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; }

    /// <summary>
    /// Currency of the monetary amount.
    /// </summary>
    [IsoId("_5XNuf7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// </summary>
    [IsoId("_5XNuhbZYEfCUZfsQO4rYeA")]
    [DisplayName("Host Transaction Identification")]
    [IsoXmlTag("HstTxId")]
    public TransactionIdentifier1? HostTransactionIdentification { get; init; }
}
