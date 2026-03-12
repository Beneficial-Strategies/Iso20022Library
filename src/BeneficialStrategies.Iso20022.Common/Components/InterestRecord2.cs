// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_uDYn166QEeexrtTFgmVD3Q")]
[DisplayName("Interest Record")]
public partial record InterestRecord2
{
    #nullable enable
    
    /// <summary>
    /// Amount of interest included in the entry amount.
    /// </summary>
    [IsoId("_uMKJU66QEeexrtTFgmVD3Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest amount included in the entry is credit or debit amount.
    /// Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_uMKJVa6QEeexrtTFgmVD3Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_uMKJV66QEeexrtTFgmVD3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_uMKJWa6QEeexrtTFgmVD3Q")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate4? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_uMKJW66QEeexrtTFgmVD3Q")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriod1? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_uMKJXa6QEeexrtTFgmVD3Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_uMKJX66QEeexrtTFgmVD3Q")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; } 
    
    
    #nullable disable
    
}
