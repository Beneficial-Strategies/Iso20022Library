// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Stored Value Data7.
/// </summary>
[IsoId("_zpgJYZLPEe6-zvj9Dw-ctg")]
[DisplayName("Stored Value Data7")]
public record StoredValueData7
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public StoredValueAccount2? AccountIdentification { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// EANUPC.
    /// </summary>
    [DisplayName("EANUPC")]
    [IsoXmlTag("EANUPC")]
    public IsoMax35NumericText? EANUPC { get; init; }

    /// <summary>
    /// Host Transaction Identification.
    /// </summary>
    [DisplayName("Host Transaction Identification")]
    [IsoXmlTag("HstTxId")]
    public TransactionIdentifier1? HostTransactionIdentification { get; init; }

    /// <summary>
    /// Item Amount.
    /// </summary>
    [DisplayName("Item Amount")]
    [IsoXmlTag("ItmAmt")]
    public ImpliedCurrencyAndAmount? ItemAmount { get; init; }

    /// <summary>
    /// Original POI Transaction.
    /// </summary>
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction136? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Product Code.
    /// </summary>
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax35Text? ProductCode { get; init; }

    /// <summary>
    /// Provider.
    /// </summary>
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Transaction Type.
    /// </summary>
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required StoredValueTransactionType3Code TransactionType { get; init; }
}
