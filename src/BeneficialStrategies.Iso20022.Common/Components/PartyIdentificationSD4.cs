// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact person at the party organising the meeting, at the issuer or at an intermediary.
/// </summary>
[IsoId("_1VTtwjL3EeKU9IrkkToqcw_-1706678617")]
[DisplayName("Party Identification SD")]
public record PartyIdentificationSD4
{
    /// <summary>
    /// Identifies a contact person by a name, a given name and an address.
    /// </summary>
    [IsoId("_1VTtwzL3EeKU9IrkkToqcw_-1820517683")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification1? ContactPerson { get; init; }

    /// <summary>
    /// Identifies the organisation which is represented by a person or for which a person works.
    /// </summary>
    [IsoId("_1VTtxDL3EeKU9IrkkToqcw_1477377260")]
    [DisplayName("Employing Party")]
    [IsoXmlTag("EmplngPty")]
    public PartyIdentificationSD3? EmployingParty { get; init; }
}
