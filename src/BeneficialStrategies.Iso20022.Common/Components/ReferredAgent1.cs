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
[IsoId("_RQy3hdp-Ed-ak6NoX_4Aeg_-1121982136")]
[DisplayName("Referred Agent")]
public record ReferredAgent1
{
    /// <summary>
    /// Indicates if the investor was referred by a placement agent.
    /// </summary>
    [IsoId("_RQy3htp-Ed-ak6NoX_4Aeg_-671238457")]
    [DisplayName("Referred")]
    [IsoXmlTag("Rfrd")]
    public required Referred1Code Referred { get; init; }

    /// <summary>
    /// Placement agent that referred the investor.
    /// </summary>
    [IsoId("_RQy3h9p-Ed-ak6NoX_4Aeg_1052048535")]
    [DisplayName("Referred Placement Agent")]
    [IsoXmlTag("RfrdPlcmntAgt")]
    public PartyIdentification2Choice_? ReferredPlacementAgent { get; init; }
}
