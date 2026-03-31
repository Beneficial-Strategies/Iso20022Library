// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement instructions to be used to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_bGuAQRRfEeOKWo1NF21OVw")]
[DisplayName("Investment Fund Cash Settlement Information")]
public record InvestmentFundCashSettlementInformation7
{
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_bdx1YxRfEeOKWo1NF21OVw")]
    [DisplayName("Subscription Payment Instrument")]
    [IsoXmlTag("SbcptPmtInstrm")]
    public PaymentInstrument11? SubscriptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_bdx1ZRRfEeOKWo1NF21OVw")]
    [DisplayName("Redemption Payment Instrument")]
    [IsoXmlTag("RedPmtInstrm")]
    public PaymentInstrument12? RedemptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_bdx1ZxRfEeOKWo1NF21OVw")]
    [DisplayName("Dividend Payment Instrument")]
    [IsoXmlTag("DvddPmtInstrm")]
    public PaymentInstrument12? DividendPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_bdx1aRRfEeOKWo1NF21OVw")]
    [DisplayName("Savings Plan Payment Instrument")]
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    public PaymentInstrument11? SavingsPlanPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [IsoId("_bdx1axRfEeOKWo1NF21OVw")]
    [DisplayName("Interest Payment Instrument")]
    [IsoXmlTag("IntrstPmtInstrm")]
    public PaymentInstrument12? InterestPaymentInstrument { get; init; }
}
