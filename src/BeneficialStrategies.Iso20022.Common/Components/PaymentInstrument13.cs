// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument used to process a payment instruction.
/// </summary>
[IsoId("__Ai3oCC0EeWJd9HF2tO7BA")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument13
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_Hmk5USC1EeWJd9HF2tO7BA")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_LAh3sSC1EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Percentage")]
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public IsoPercentageBoundedRate? DividendPercentage { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_q1v80SC1EeWJd9HF2tO7BA")]
    [DisplayName("Subscription Payment Instrument")]
    [IsoXmlTag("SbcptPmtInstrm")]
    public PaymentInstrument18Choice_? SubscriptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_CUs6kSC2EeWJd9HF2tO7BA")]
    [DisplayName("Redemption Payment Instrument")]
    [IsoXmlTag("RedPmtInstrm")]
    public PaymentInstrument19Choice_? RedemptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_OMg2ESC2EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Payment Instrument")]
    [IsoXmlTag("DvddPmtInstrm")]
    public PaymentInstrument19Choice_? DividendPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_TWp_sSC2EeWJd9HF2tO7BA")]
    [DisplayName("Savings Plan Payment Instrument")]
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    public PaymentInstrument18Choice_? SavingsPlanPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [IsoId("_YE0X8SC2EeWJd9HF2tO7BA")]
    [DisplayName("Interest Payment Instrument")]
    [IsoXmlTag("IntrstPmtInstrm")]
    public PaymentInstrument19Choice_? InterestPaymentInstrument { get; init; }
}
