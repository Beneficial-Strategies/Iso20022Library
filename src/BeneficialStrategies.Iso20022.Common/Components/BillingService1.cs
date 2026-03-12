// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the values used for every line item service in the statement.
/// </summary>
[IsoId("_6PDr1ZqlEeGSON8vddiWzQ_-1150406183")]
[DisplayName("Billing Service")]
public partial record BillingService1
{
    #nullable enable
    
    /// <summary>
    /// Specifies further detailed values for this service.
    /// </summary>
    [IsoId("_6PDr1pqlEeGSON8vddiWzQ_-1969359864")]
    [DisplayName("Service Detail")]
    [IsoXmlTag("SvcDtl")]
    public required BillingServiceParameters1 ServiceDetail { get; init; } 
    
    /// <summary>
    /// Price applied to the service, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr15qlEeGSON8vddiWzQ_972952151")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public BillingPrice1? Price { get; init; } 
    
    /// <summary>
    /// Code identifying the disposition of the calculated charge.
    /// </summary>
    [IsoId("_6PDr2JqlEeGSON8vddiWzQ_-322179582")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required ServicePaymentMethod1Code PaymentMethod { get; init; } 
    
    /// <summary>
    /// Amount of the calculated charge, expressed in the pricing currency. This value does not include any tax on the service.
    /// </summary>
    [IsoId("_6PNc0JqlEeGSON8vddiWzQ_-525586085")]
    [DisplayName("Original Charge Price")]
    [IsoXmlTag("OrgnlChrgPric")]
    public required AmountAndDirection34 OriginalChargePrice { get; init; } 
    
    /// <summary>
    /// Amount of the calculated charge, expressed in the settlement currency.
    /// </summary>
    [IsoId("_6PNc0ZqlEeGSON8vddiWzQ_1343532522")]
    [DisplayName("Original Charge Settlement Amount")]
    [IsoXmlTag("OrgnlChrgSttlmAmt")]
    public AmountAndDirection34? OriginalChargeSettlementAmount { get; init; } 
    
    /// <summary>
    /// Average daily collected balance required to offset a balance compensable service charge, exclusive of taxes, expressed in the account currency.
    /// </summary>
    [IsoId("_6PNc0pqlEeGSON8vddiWzQ_-551745174")]
    [DisplayName("Balance Required Account Amount")]
    [IsoXmlTag("BalReqrdAcctAmt")]
    public AmountAndDirection34? BalanceRequiredAccountAmount { get; init; } 
    
    /// <summary>
    /// Provides the details of the taxable status of a service.
    /// </summary>
    [IsoId("_6PNc05qlEeGSON8vddiWzQ_-1099969523")]
    [DisplayName("Tax Designation")]
    [IsoXmlTag("TaxDsgnt")]
    public required ServiceTaxDesignation1 TaxDesignation { get; init; } 
    
    /// <summary>
    /// Provides tax related values for tax calculation methods A, B or D.
    /// </summary>
    [IsoId("_6PNc1JqlEeGSON8vddiWzQ_-972287511")]
    [DisplayName("Tax Calculation")]
    [IsoXmlTag("TaxClctn")]
    public BillingMethod1Choice_? TaxCalculation { get; init; } 
    
    
    #nullable disable
    
}
