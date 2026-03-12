// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Country and residential status.
/// </summary>
[IsoId("_0D9OcSDZEeWCLu74WLgP4w")]
[DisplayName("Country And Residential Status Type")]
public partial record CountryAndResidentialStatusType2
{
    #nullable enable
    
    /// <summary>
    /// Country to which the residential status is applicable.
    /// </summary>
    [IsoId("_0gOTsSDZEeWCLu74WLgP4w")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Residential status of the organisation or individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_0gOTsyDZEeWCLu74WLgP4w")]
    [DisplayName("Residential Status")]
    [IsoXmlTag("ResdtlSts")]
    public required ResidentialStatus1Code ResidentialStatus { get; init; } 
    
    
    #nullable disable
    
}
