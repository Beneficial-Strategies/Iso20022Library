// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of Retailer for this message.
/// </summary>
[IsoId("_EGn-QYX-EemxIqbaFEE8-w")]
[DisplayName("Retailer Sale Environment")]
public record RetailerSaleEnvironment2
{
    /// <summary>
    /// Capabilities of the Sale system.
    /// </summary>
    [IsoId("_ES4RkYX-EemxIqbaFEE8-w")]
    [DisplayName("Sale Capabilities")]
    [IsoXmlTag("SaleCpblties")]
    public SaleCapabilities1Code? SaleCapabilities { get; init; }

    /// <summary>
    /// Default currency associated with the sale system.
    /// </summary>
    [IsoId("_KXvXAIX-EemxIqbaFEE8-w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Minimum amount the Sale System is allowed to deliver for this payment.
    /// </summary>
    [IsoId("_ES4Rk4X-EemxIqbaFEE8-w")]
    [DisplayName("Minimum Amount To Deliver")]
    [IsoXmlTag("MinAmtToDlvr")]
    public ImpliedCurrencyAndAmount? MinimumAmountToDeliver { get; init; }

    /// <summary>
    /// Maximum amount which could be requested for cash-back.
    /// </summary>
    [IsoId("_ES4RlYX-EemxIqbaFEE8-w")]
    [DisplayName("Maximum Cash Back Amount")]
    [IsoXmlTag("MaxCshBckAmt")]
    public ImpliedCurrencyAndAmount? MaximumCashBackAmount { get; init; }

    /// <summary>
    /// Minimum amount to split a sale transaction.
    /// </summary>
    [IsoId("_ES4Rl4X-EemxIqbaFEE8-w")]
    [DisplayName("Minimum Split Amount")]
    [IsoXmlTag("MinSpltAmt")]
    public ImpliedCurrencyAndAmount? MinimumSplitAmount { get; init; }

    /// <summary>
    /// Flag if preferred type of payment is a debit transaction.
    /// </summary>
    [IsoId("_ES4RmYX-EemxIqbaFEE8-w")]
    [DisplayName("Debit Preferred Flag")]
    [IsoXmlTag("DbtPrefrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DebitPreferredFlag { get; init; }

    /// <summary>
    /// Way of Loyalty handling.
    /// </summary>
    [IsoId("_ES4Rm4X-EemxIqbaFEE8-w")]
    [DisplayName("Loyalty Handling")]
    [IsoXmlTag("LltyHdlg")]
    public LoyaltyHandling1Code? LoyaltyHandling { get; init; }
}
