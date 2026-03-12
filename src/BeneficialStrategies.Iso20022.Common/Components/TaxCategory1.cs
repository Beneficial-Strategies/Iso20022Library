// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the identification of the tax category.
/// </summary>
[IsoId("_3WHcEOaPEei5aPS232E3Mw")]
[DisplayName("Tax Category")]
public partial record TaxCategory1
{
    #nullable enable
    
    /// <summary>
    /// Tax category identification.
    /// </summary>
    [IsoId("_OKB4wOaQEei5aPS232E3Mw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Identification { get; init; } 
    
    /// <summary>
    /// Description of the tax category.
    /// </summary>
    [IsoId("_cqX8wOaQEei5aPS232E3Mw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; } 
    
    /// <summary>
    /// Identification of the country in which the tax is withheld.
    /// </summary>
    [IsoId("_6rctIOgkEei5aPS232E3Mw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
