// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_5Pm5wRreEeOVR9VN6fAMUg")]
[DisplayName("Tax")]
public partial record Tax23
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_qZsY8BrfEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Specifies the tax as an amount or percentage.
    /// </summary>
    [IsoId("_DQNcABrfEeOVR9VN6fAMUg")]
    [DisplayName("Amount Or Percentage")]
    [IsoXmlTag("AmtOrPctg")]
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
    
    #nullable disable
    
}
