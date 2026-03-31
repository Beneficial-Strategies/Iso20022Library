// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the placement agent identification for a hedge fund if the investor was referred by one.
/// </summary>
[IsoId("_jiooYSFhEeW9XJWqfgXIIA")]
[DisplayName("Referred Agent")]
public record ReferredAgent2
{
    /// <summary>
    /// Indicates if the investor was referred by a placement agent.
    /// </summary>
    [IsoId("_j-L78yFhEeW9XJWqfgXIIA")]
    [DisplayName("Referred")]
    [IsoXmlTag("Rfrd")]
    public required Referred1Code Referred { get; init; }

    /// <summary>
    /// Placement agent that referred the investor.
    /// </summary>
    [IsoId("_j-L79SFhEeW9XJWqfgXIIA")]
    [DisplayName("Referred Placement Agent")]
    [IsoXmlTag("RfrdPlcmntAgt")]
    public PartyIdentification70Choice_? ReferredPlacementAgent { get; init; }
}
