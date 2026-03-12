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
[IsoId("_OEm_MVthEeSwKe7KuKvXhg")]
[DisplayName("Meeting Contact Person")]
public partial record MeetingContactPerson2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the contact person by its name, given name and address.
    /// </summary>
    [IsoId("_OiEXQ1thEeSwKe7KuKvXhg")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification1? ContactPerson { get; init; } 
    
    /// <summary>
    /// Identifies the organisation which is represented by the person or for which the person works.
    /// </summary>
    [IsoId("_OiEXRVthEeSwKe7KuKvXhg")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification40Choice_? EmployingParty { get; init; } 
    
    /// <summary>
    /// Identification of the financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
    /// </summary>
    [IsoId("_OiEXR1thEeSwKe7KuKvXhg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlaceOfListing { get; init; } 
    
    
    #nullable disable
    
}
