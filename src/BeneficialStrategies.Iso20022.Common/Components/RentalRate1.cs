// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle rental rate
/// </summary>
[IsoId("_jy_0d_S2Eeife6veM7daYw")]
[DisplayName("Rental Rate")]
public partial record RentalRate1
{
    #nullable enable
    
    /// <summary>
    /// Unit of measure used to compute the rental rate.
    /// </summary>
    [IsoId("_jy_0e_S2Eeife6veM7daYw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public PeriodUnit3Code? Period { get; init; } 
    
    /// <summary>
    /// Other unit of measure used to compute the rental rate.
    /// </summary>
    [IsoId("_jy_0fPS2Eeife6veM7daYw")]
    [DisplayName("Other Period")]
    [IsoXmlTag("OthrPrd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherPeriod { get; init; } 
    
    /// <summary>
    /// Rate applied to the vehicle rental for the specified period. 
    /// </summary>
    [IsoId("_jy_0evS2Eeife6veM7daYw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; } 
    
    /// <summary>
    /// Duration of the period for which the rental rate is calculated. 
    /// </summary>
    [IsoId("_jy_0ffS2Eeife6veM7daYw")]
    [DisplayName("Period Count")]
    [IsoXmlTag("PrdCnt")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? PeriodCount { get; init; } 
    
    
    #nullable disable
    
}
