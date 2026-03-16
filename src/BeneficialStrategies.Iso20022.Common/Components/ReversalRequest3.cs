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
[IsoId("_aWvZcS8QEeu125Ip9zFcsQ")]
[DisplayName("Reversal Request")]
public record ReversalRequest3
{
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    [IsoId("_ah5gkS8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversal Transaction")]
    [IsoXmlTag("RvslTx")]
    public CardPaymentTransaction110? ReversalTransaction { get; init; }

    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_IS6LIS8REeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData2> LoyaltyData { get; init; } = [];

    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_ah5gky8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; }

    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_ah5glS8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_ah5gly8QEeu125Ip9zFcsQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
