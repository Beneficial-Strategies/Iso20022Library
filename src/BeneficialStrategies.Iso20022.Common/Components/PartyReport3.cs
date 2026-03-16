// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report information about party reference data.
/// </summary>
[IsoId("_7fpehVhLEeih3fUfzR38Ig")]
[DisplayName("Party Report")]
public record PartyReport3
{
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_7qW5sVhLEeih3fUfzR38Ig")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification8 PartyIdentification { get; init; }

    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    [IsoId("_7qW5s1hLEeih3fUfzR38Ig")]
    [DisplayName("Party Or Error")]
    [IsoXmlTag("PtyOrErr")]
    public required PartyOrBusinessError3Choice_ PartyOrError { get; init; }
}
