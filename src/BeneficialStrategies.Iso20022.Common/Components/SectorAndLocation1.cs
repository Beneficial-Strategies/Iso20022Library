// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the reported party through the sector and the location.
/// </summary>
[IsoId("_RsV18JfdEeSfnc-VXAEapg")]
[DisplayName("Sector And Location")]
public partial record SectorAndLocation1
{
    #nullable enable
    
    /// <summary>
    /// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
    /// </summary>
    [IsoId("_oLh_0JfdEeSfnc-VXAEapg")]
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
    public required IsoSNA2008SectorIdentifier Sector { get; init; } 
    
    /// <summary>
    /// Location of the country in which the counterparty is incorporated.
    /// </summary>
    [IsoId("_97X68JfeEeSfnc-VXAEapg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public required CountryCode Location { get; init; } 
    
    
    #nullable disable
    
}
