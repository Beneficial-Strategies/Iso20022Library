// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the interest rate
/// </summary>
[IsoId("_mtqjoZJJEeuuktRxxQZoNQ")]
[DisplayName("Interest Rate Details")]
public partial record InterestRateDetails2
{
    #nullable enable
    
    /// <summary>
    /// Interest rate applicable to the instalment.
    /// </summary>
    [IsoId("_mzzn4ZJJEeuuktRxxQZoNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestRate1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of interest applied to the instalment, when Type is OtherNational or OtherPrivate.
    /// </summary>
    [IsoId("_mzzn45JJEeuuktRxxQZoNQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Contains instalment period
    /// </summary>
    [IsoId("_mzzn5ZJJEeuuktRxxQZoNQ")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public InstalmentPeriod1Code? Period { get; init; } 
    
    /// <summary>
    /// Rate expressed as a decimal, example, 0.7 is 7/10 and 70%.
    /// </summary>
    [IsoId("_mzzn55JJEeuuktRxxQZoNQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate Rate { get; init; } 
    
    
    #nullable disable
    
}
