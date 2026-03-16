// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet data pertaining to the payment transaction.
/// </summary>
[IsoId("_FceP0RyuEey6gI8SKlv7rg")]
[DisplayName("Fleet Data")]
public record FleetData4
{
    /// <summary>
    /// Invoice Summary information.
    /// </summary>
    [IsoId("_FiO5kRyuEey6gI8SKlv7rg")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public FleetSummary2? Summary { get; init; }

    /// <summary>
    /// Fleet Line Item component is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions.
    /// </summary>
    [IsoId("_FiO5kxyuEey6gI8SKlv7rg")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<FleetLineItem4> LineItem { get; init; } = [];
}
