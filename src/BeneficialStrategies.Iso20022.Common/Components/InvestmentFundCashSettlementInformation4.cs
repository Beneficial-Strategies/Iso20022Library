// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement instructions to be used to transfer cash from the Debtor to the Creditor.
/// </summary>
[IsoId("_RRjFddp-Ed-ak6NoX_4Aeg_355595672")]
[DisplayName("Investment Fund Cash Settlement Information")]
public record InvestmentFundCashSettlementInformation4
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRjFdtp-Ed-ak6NoX_4Aeg_355595690")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification2Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_RRjFd9p-Ed-ak6NoX_4Aeg_355596578")]
    [DisplayName("Subscription Payment Instrument")]
    [IsoXmlTag("SbcptPmtInstrm")]
    public PaymentInstrument8? SubscriptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_RRjFeNp-Ed-ak6NoX_4Aeg_355596114")]
    [DisplayName("Redemption Payment Instrument")]
    [IsoXmlTag("RedPmtInstrm")]
    public PaymentInstrument9? RedemptionPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_RRsPYNp-Ed-ak6NoX_4Aeg_355596002")]
    [DisplayName("Dividend Payment Instrument")]
    [IsoXmlTag("DvddPmtInstrm")]
    public PaymentInstrument9? DividendPaymentInstrument { get; init; }

    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_RRsPYdp-Ed-ak6NoX_4Aeg_355596482")]
    [DisplayName("Savings Plan Payment Instrument")]
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    public PaymentInstrument8? SavingsPlanPaymentInstrument { get; init; }
}
