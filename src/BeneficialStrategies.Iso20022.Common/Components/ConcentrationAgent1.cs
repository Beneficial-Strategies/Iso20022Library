// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit taking institution with which a central counterparty has accounts used to concentrate cash funds before or after investment.
/// </summary>
[IsoId("_ph5wQBXrEeejf-cbr8l5qw")]
[DisplayName("Concentration Agent")]
public record ConcentrationAgent1
{
    /// <summary>
    /// Identifies the concentration agent.
    /// </summary>
    [IsoId("_7oHHsBXrEeejf-cbr8l5qw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier Identification { get; init; }

    /// <summary>
    /// Inflows and outflows to and from the CCP’s concentration accounts aggregated across all business lines / waterfalls.
    /// </summary>
    [IsoId("_2W_MUBXrEeejf-cbr8l5qw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public ValueList<ConcentrationAccount1> Account { get; init; } = [];
    // ID for the above is _2W_MUBXrEeejf-cbr8l5qw
}
