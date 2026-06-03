// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
[IsoId("_dBQu8aovEfCG2_q2WT-90w")]
[DisplayName("Document Number22")]
public record DocumentNumber22
{
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    [IsoId("_dEWfN6ovEfCG2_q2WT-90w")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public required DocumentNumber5Choice_ Number { get; init; }

    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    [IsoId("_dEWfQ6ovEfCG2_q2WT-90w")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    [MinLength(1)]
    public ValueList<Identification32> References { get; init; } = [];
}
