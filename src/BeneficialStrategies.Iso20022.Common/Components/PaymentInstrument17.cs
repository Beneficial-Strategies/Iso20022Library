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
[IsoId("_2kS7gZTAEemqYPWMBuVawg")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument17
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_238QQZTAEemqYPWMBuVawg")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_238QQ5TAEemqYPWMBuVawg")]
    [DisplayName("Dividend Percentage")]
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public IsoPercentageBoundedRate? DividendPercentage { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_238QRZTAEemqYPWMBuVawg")]
    [DisplayName("Subscription Payment Instrument")]
    [IsoXmlTag("SbcptPmtInstrm")]
    public PaymentInstrument24Choice_? SubscriptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_238QR5TAEemqYPWMBuVawg")]
    [DisplayName("Redemption Payment Instrument")]
    [IsoXmlTag("RedPmtInstrm")]
    public PaymentInstrument19Choice_? RedemptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_238QSZTAEemqYPWMBuVawg")]
    [DisplayName("Dividend Payment Instrument")]
    [IsoXmlTag("DvddPmtInstrm")]
    public PaymentInstrument19Choice_? DividendPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_238QS5TAEemqYPWMBuVawg")]
    [DisplayName("Savings Plan Payment Instrument")]
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    public PaymentInstrument24Choice_? SavingsPlanPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [IsoId("_238QTZTAEemqYPWMBuVawg")]
    [DisplayName("Interest Payment Instrument")]
    [IsoXmlTag("IntrstPmtInstrm")]
    public PaymentInstrument19Choice_? InterestPaymentInstrument { get; init; }
}
