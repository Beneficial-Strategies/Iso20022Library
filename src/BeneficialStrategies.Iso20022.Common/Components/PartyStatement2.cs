// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_7qW5tVhLEeih3fUfzR38Ig")]
[DisplayName("Party Statement")]
public record PartyStatement2
{
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_70efAVhLEeih3fUfzR38Ig")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; }

    /// <summary>
    /// Provides information on the actual change occurred to a party.
    /// </summary>
    [IsoId("_70efA1hLEeih3fUfzR38Ig")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public PartyReferenceDataChange2? Change { get; init; }
}
