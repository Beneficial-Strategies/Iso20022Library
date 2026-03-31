// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the system restriction.
/// </summary>
[IsoId("_kpU3oO5NEeCisYr99QEiWA_1758511651")]
[DisplayName("System Restriction")]
public record SystemRestriction1
{
    /// <summary>
    /// Specifies the date from which the restriction is valid.
    /// </summary>
    [IsoId("_kpU3oe5NEeCisYr99QEiWA_534617393")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ValidFrom { get; init; }

    /// <summary>
    /// Specifies the date until which the restriction is valid.
    /// </summary>
    [IsoId("_kpU3ou5NEeCisYr99QEiWA_1295382546")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidTo { get; init; }

    /// <summary>
    /// Specifies the identification of a restriction.
    /// </summary>
    [IsoId("_kpU3o-5NEeCisYr99QEiWA_1881329572")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }
}
