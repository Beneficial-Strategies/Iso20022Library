// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel agency component provides details of travel agency, airline, or railway transactions. 
/// </summary>
[IsoId("_q3BbUcWyEeuhguwJmlgagQ")]
[DisplayName("Travel Agency")]
public partial record TravelAgency3
{
    #nullable enable
    
    /// <summary>
    /// Information describing the travel agency or party providing travel-related services. 
    /// </summary>
    [IsoId("_q7ZlAcWyEeuhguwJmlgagQ")]
    [DisplayName("Company")]
    [IsoXmlTag("Cpny")]
    public PartyIdentification261? Company { get; init; } 
    
    /// <summary>
    /// Provides detailed information about the travel package, excluding specific itinerary data. 
    /// </summary>
    [IsoId("_q7ZlA8WyEeuhguwJmlgagQ")]
    [DisplayName("Travel Package")]
    [IsoXmlTag("TrvlPackg")]
    public TravelAgencyPackage1? TravelPackage { get; init; } 
    
    /// <summary>
    /// Provides additional travel details.
    /// </summary>
    [IsoId("_q7ZlBcWyEeuhguwJmlgagQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
