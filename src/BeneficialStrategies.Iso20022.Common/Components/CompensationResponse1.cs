// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compensation Response1.
/// </summary>
[IsoId("__QtDEXZIEe2W3OiCJJKf0A")]
[DisplayName("Compensation Response1")]
public partial record CompensationResponse1
{
    #nullable enable

    /// <summary>
    /// Amount Due.
    /// </summary>
    [DisplayName("Amount Due")]
    [IsoXmlTag("AmtDue")]
    public ActiveCurrencyAndAmount? AmountDue { get; init; } 

    /// <summary>
    /// Expected Value Date.
    /// </summary>
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; } 

    /// <summary>
    /// Granted.
    /// </summary>
    [DisplayName("Granted")]
    [IsoXmlTag("Grantd")]
    public required IsoTrueFalseIndicator Granted { get; init; } 

    /// <summary>
    /// Initial Amount.
    /// </summary>
    [DisplayName("Initial Amount")]
    [IsoXmlTag("InitlAmt")]
    public ActiveCurrencyAndAmount? InitialAmount { get; init; } 

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public IsoPercentageRate? InterestRate { get; init; } 

    /// <summary>
    /// Paid Charges.
    /// </summary>
    [DisplayName("Paid Charges")]
    [IsoXmlTag("PdChrgs")]
    public ActiveCurrencyAndAmount? PaidCharges { get; init; } 

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DatePeriod2? Period { get; init; } 

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax140Text? Reason { get; init; } 

    
    #nullable disable
    
}
