// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
[IsoId("_plMAxzi7Eeydid5dcNPKvg")]
[DisplayName("Total Eligible Balance Format")]
public record TotalEligibleBalanceFormat11
{
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_plMAyTi7Eeydid5dcNPKvg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public Quantity80Choice_? Balance { get; init; }

    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_plMAyzi7Eeydid5dcNPKvg")]
    [DisplayName("Full Period Units")]
    [IsoXmlTag("FullPrdUnits")]
    public SignedQuantityFormat13? FullPeriodUnits { get; init; }

    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    [IsoId("_plMAzTi7Eeydid5dcNPKvg")]
    [DisplayName("Part Way Period Units")]
    [IsoXmlTag("PartWayPrdUnits")]
    public SignedQuantityFormat13? PartWayPeriodUnits { get; init; }
}
