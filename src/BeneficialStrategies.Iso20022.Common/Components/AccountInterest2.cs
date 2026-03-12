// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the interest that applies to the account at a particular moment in time.
/// </summary>
[IsoId("_SRxMVdp-Ed-ak6NoX_4Aeg_-1871894733")]
[DisplayName("Account Interest")]
public partial record AccountInterest2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_SRxMVtp-Ed-ak6NoX_4Aeg_-1871894658")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_SRxMV9p-Ed-ak6NoX_4Aeg_-1871894610")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate3? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_SRxMWNp-Ed-ak6NoX_4Aeg_-1871894548")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_SR69UNp-Ed-ak6NoX_4Aeg_-1871894724")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    
    #nullable disable
    
}
