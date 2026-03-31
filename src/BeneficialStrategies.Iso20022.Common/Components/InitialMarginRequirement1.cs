// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liability and assets that arise for a clearing member with respect to a central counterparty.
/// </summary>
[IsoId("_BTNckKpwEeamNLogr5TkIQ")]
[DisplayName("Initial Margin Requirement")]
public record InitialMarginRequirement1
{
    /// <summary>
    /// Liability a clearing member has to a central counterparty with respect to potential future exposures.
    /// </summary>
    [IsoId("_iLGYQKpzEeamNLogr5TkIQ")]
    [DisplayName("Initial Margin Exposure")]
    [IsoXmlTag("InitlMrgnXpsr")]
    public ValueList<InitialMarginExposure1> InitialMarginExposure { get; init; } = [];

    // ID for the above is _iLGYQKpzEeamNLogr5TkIQ

    /// <summary>
    /// Total value of any credits offsetable against initial margin requirements at the end of day. For example, net liquidating value of option positions, contingent variation margin, delivery credits.
    /// </summary>
    [IsoId("_rCMxQKpyEeamNLogr5TkIQ")]
    [DisplayName("Credit")]
    [IsoXmlTag("Cdt")]
    public required ActiveCurrencyAndAmount Credit { get; init; }
}
