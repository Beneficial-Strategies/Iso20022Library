// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Reversal.
/// </summary>
[IsoId("_SY3AAQ1REeqjM-rxn3HuXQ")]
[DisplayName("Reversal Request")]
public record ReversalRequest2
{
    /// <summary>
    /// Original transaction to reverse.
    /// </summary>
    [IsoId("_SlixIQ1REeqjM-rxn3HuXQ")]
    [DisplayName("Original Payment Transaction")]
    [IsoXmlTag("OrgnlPmtTx")]
    public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; }

    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_SlixIw1REeqjM-rxn3HuXQ")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; }

    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_SlixJQ1REeqjM-rxn3HuXQ")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_SlixJw1REeqjM-rxn3HuXQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
