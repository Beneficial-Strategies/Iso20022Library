// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement instructions to be used to transfer cash from the Debtor to the Creditor.
/// </summary>
[IsoId("_RRsPYtp-Ed-ak6NoX_4Aeg_-1105806618")]
[DisplayName("Investment Fund Cash Settlement Information")]
public partial record InvestmentFundCashSettlementInformation3
{
    #nullable enable
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_RRsPY9p-Ed-ak6NoX_4Aeg_-1105806185")]
    [DisplayName("Subscription Payment Instrument")]
    [IsoXmlTag("SbcptPmtInstrm")]
    public PaymentInstrument8? SubscriptionPaymentInstrument { get; init; } 
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_RRsPZNp-Ed-ak6NoX_4Aeg_-1105806557")]
    [DisplayName("Redemption Payment Instrument")]
    [IsoXmlTag("RedPmtInstrm")]
    public PaymentInstrument9? RedemptionPaymentInstrument { get; init; } 
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_RRsPZdp-Ed-ak6NoX_4Aeg_-1105806246")]
    [DisplayName("Dividend Payment Instrument")]
    [IsoXmlTag("DvddPmtInstrm")]
    public PaymentInstrument9? DividendPaymentInstrument { get; init; } 
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_RRsPZtp-Ed-ak6NoX_4Aeg_-1105806109")]
    [DisplayName("Savings Plan Payment Instrument")]
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    public PaymentInstrument8? SavingsPlanPaymentInstrument { get; init; } 
    
    
    #nullable disable
    
}
