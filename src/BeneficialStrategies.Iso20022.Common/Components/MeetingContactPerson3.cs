// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a contact person.
/// </summary>
[IsoId("_qdH44bINEemux5trsZcCpw")]
[DisplayName("Meeting Contact Person")]
public record MeetingContactPerson3
{
    /// <summary>
    /// Identification of the contact person by its name, given name and address.
    /// </summary>
    [IsoId("_q0B9A7INEemux5trsZcCpw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification1? ContactPerson { get; init; }

    /// <summary>
    /// Identification of the organisation which is represented by the person or for which the person works.
    /// </summary>
    [IsoId("_q0B9BbINEemux5trsZcCpw")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentification129Choice_? EmployingParty { get; init; }

    /// <summary>
    /// Identification of the financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
    /// </summary>
    [IsoId("_q0B9B7INEemux5trsZcCpw")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlaceOfListing { get; init; }
}
