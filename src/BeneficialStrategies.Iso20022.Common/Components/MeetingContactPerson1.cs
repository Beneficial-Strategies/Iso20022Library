// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact person at the party organising the meeting, at the issuer or at an intermediary.
/// </summary>
[IsoId("_QDKmxtp-Ed-ak6NoX_4Aeg_-854378880")]
[DisplayName("Meeting Contact Person")]
public partial record MeetingContactPerson1
{
    #nullable enable
    
    /// <summary>
    /// Identifies a contact person by a name, a given name and an address.
    /// </summary>
    [IsoId("_QDKmx9p-Ed-ak6NoX_4Aeg_-854378472")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification1? ContactPerson { get; init; } 
    
    /// <summary>
    /// Identifies the organisation which is represented by a person or for which a person works.
    /// </summary>
    [IsoId("_QDKmyNp-Ed-ak6NoX_4Aeg_-854378550")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification9Choice_? EmployingParty { get; init; } 
    
    /// <summary>
    /// The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
    /// </summary>
    [IsoId("_QDTwsNp-Ed-ak6NoX_4Aeg_-854378862")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlaceOfListing { get; init; } 
    
    
    #nullable disable
    
}
