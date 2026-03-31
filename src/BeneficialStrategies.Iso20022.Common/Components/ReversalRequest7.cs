// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal Request7.
/// </summary>
[IsoId("_lOUwsZ9GEe-nbM0aSPcoiQ")]
[DisplayName("Reversal Request7")]
public record ReversalRequest7
{
    /// <summary>
    /// Customer Order.
    /// </summary>
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Loyalty Data.
    /// </summary>
    [DisplayName("Loyalty Data")]
    [IsoXmlTag("LltyData")]
    public ValueList<LoyaltyRequestData3> LoyaltyData { get; init; } = [];

    /// <summary>
    /// Reversal Reason.
    /// </summary>
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public required ReversalReason1Code ReversalReason { get; init; }

    /// <summary>
    /// Reversal Transaction.
    /// </summary>
    [DisplayName("Reversal Transaction")]
    [IsoXmlTag("RvslTx")]
    public PaymentTransaction165? ReversalTransaction { get; init; }

    /// <summary>
    /// Reversed Amount.
    /// </summary>
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }
}
