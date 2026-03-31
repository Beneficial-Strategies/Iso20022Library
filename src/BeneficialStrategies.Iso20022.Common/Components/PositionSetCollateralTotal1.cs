// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_9h9p58WLEeiRga8tPu1L4Q")]
[DisplayName("Position Set Collateral Total")]
public record PositionSetCollateralTotal1
{
    /// <summary>
    /// Refers to the number of reports used for calculating the position set.
    /// </summary>
    [IsoId("_9h9p6sWLEeiRga8tPu1L4Q")]
    [DisplayName("Number Of Reports")]
    [IsoXmlTag("NbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public IsoMax20PositiveNumber? NumberOfReports { get; init; }

    /// <summary>
    /// Values of the initial margin for the portfolio.
    /// </summary>
    [IsoId("_9h9p6MWLEeiRga8tPu1L4Q")]
    [DisplayName("Initial Margin")]
    [IsoXmlTag("InitlMrgn")]
    public PositionSetPostedAndReceived1? InitialMargin { get; init; }

    /// <summary>
    /// Values of the variation margin for the portfolio.
    /// </summary>
    [IsoId("_9h9p6cWLEeiRga8tPu1L4Q")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public PositionSetPostedAndReceived1? VariationMargin { get; init; }

    /// <summary>
    /// Values of the excess cash for the portfolio.
    /// </summary>
    [IsoId("_9drxYcWMEeiRga8tPu1L4Q")]
    [DisplayName("Excess Cash")]
    [IsoXmlTag("XcssCsh")]
    public PositionSetPostedAndReceived1? ExcessCash { get; init; }
}
