// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a reversal.
/// </summary>
[IsoId("_s6yC0bZYEfCUZfsQO4rYeA")]
[DisplayName("Reversal Request8")]
public record ReversalRequest8
{
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    [IsoId("_s7yIZbZYEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Transaction")]
    [IsoXmlTag("RvslTx")]
    public PaymentTransaction183? ReversalTransaction { get; init; }

    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_s7yIa7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];

    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_s7yIcbZYEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; }

    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_s7yId7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_s7yIfbZYEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
