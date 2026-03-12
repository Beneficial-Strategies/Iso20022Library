// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and place of birth of a person.
/// </summary>
[IsoId("_QBE8Gdp-Ed-ak6NoX_4Aeg_1131681932")]
[DisplayName("Date And Place Of Birth")]
public partial record DateAndPlaceOfBirth
{
    #nullable enable
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QBE8Gtp-Ed-ak6NoX_4Aeg_-1166836636")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; } 
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_QBOtENp-Ed-ak6NoX_4Aeg_-5969904")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_QBOtEdp-Ed-ak6NoX_4Aeg_-893474033")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CityOfBirth { get; init; } 
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_QBOtEtp-Ed-ak6NoX_4Aeg_8803974")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public required CountryCode CountryOfBirth { get; init; } 
    
    
    #nullable disable
    
}
