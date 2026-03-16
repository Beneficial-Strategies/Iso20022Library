// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount related to the original transaction.
/// </summary>
[IsoId("_wYTrgEULEeea-M6VZkEPUw")]
[DisplayName("Original Transaction Amount")]
public record OriginalTransactionAmount1
{
    /// <summary>
    /// Qualifies the amount of the transaction.
    /// </summary>
    [IsoId("_DMuMwEUMEeea-M6VZkEPUw")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount11Code? AmountQualifier { get; init; }

    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    [IsoId("_6jgewEUMEeea-M6VZkEPUw")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public required TransactionAmount1 TransactionAmount { get; init; }

    /// <summary>
    /// Amount to be billed to cardholder.
    /// </summary>
    [IsoId("_FHgzkEUOEeea-M6VZkEPUw")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount4? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Amount used for reconciliation.
    /// </summary>
    [IsoId("_NEdcAEUOEeea-M6VZkEPUw")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount4? ReconciliationAmount { get; init; }
}
