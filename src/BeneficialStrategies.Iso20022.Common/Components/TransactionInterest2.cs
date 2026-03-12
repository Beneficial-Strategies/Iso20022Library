// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide transaction specific interest information that applies to the underlying transaction.
/// </summary>
[IsoId("_SSzuINp-Ed-ak6NoX_4Aeg_-309357356")]
[DisplayName("Transaction Interest")]
public partial record TransactionInterest2
{
    #nullable enable
    
    /// <summary>
    /// Amount of interest included in the entry amount.
    /// </summary>
    [IsoId("_SSzuIdp-Ed-ak6NoX_4Aeg_-309357016")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest amount included in the entry is credit or debit amount.
    /// </summary>
    [IsoId("_SSzuItp-Ed-ak6NoX_4Aeg_-309356954")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_SSzuI9p-Ed-ak6NoX_4Aeg_-309356461")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_SS9fINp-Ed-ak6NoX_4Aeg_-309356831")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate3? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_SS9fIdp-Ed-ak6NoX_4Aeg_-309356770")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_SS9fItp-Ed-ak6NoX_4Aeg_-309357317")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
