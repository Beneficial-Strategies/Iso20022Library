// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel agency component provides details of travel agency, airline, or railway transactions.
/// </summary>
[IsoId("_H51h0_PdEeihCvvpsmGI2w")]
[DisplayName("Travel Agency")]
public record TravelAgency2
{
    /// <summary>
    /// Information describing the travel agency or party providing travel-related services.
    /// </summary>
    [IsoId("_H51h1PPdEeihCvvpsmGI2w")]
    [DisplayName("Company")]
    [IsoXmlTag("Cpny")]
    public PartyIdentification207? Company { get; init; }

    /// <summary>
    /// Provides detailed information about the travel package, excluding specific itinerary data.
    /// </summary>
    [IsoId("_H51h1fPdEeihCvvpsmGI2w")]
    [DisplayName("Travel Package")]
    [IsoXmlTag("TrvlPackg")]
    public ValueList<TravelAgencyPackage1> TravelPackage { get; init; } = [];

    /// <summary>
    /// Provides additional travel details.
    /// </summary>
    [IsoId("_zllTkPPeEeihCvvpsmGI2w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
