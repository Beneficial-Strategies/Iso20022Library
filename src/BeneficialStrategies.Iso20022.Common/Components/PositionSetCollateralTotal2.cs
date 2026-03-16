// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Collateral Total2.
/// </summary>
[IsoId("_HkzsQRc0Ee6tpciIp9JEYw")]
[DisplayName("Position Set Collateral Total2")]
public record PositionSetCollateralTotal2
{
    /// <summary>
    /// Number Of Reports.
    /// </summary>
    [DisplayName("Number Of Reports")]
    [IsoXmlTag("NbOfRpts")]
    public IsoMax20PositiveNumber? NumberOfReports { get; init; }

    /// <summary>
    /// Posted Margin Or Collateral.
    /// </summary>
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; }

    /// <summary>
    /// Received Margin Or Collateral.
    /// </summary>
    [DisplayName("Received Margin Or Collateral")]
    [IsoXmlTag("RcvdMrgnOrColl")]
    public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; }
}
