// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about reported derivatives and reported derivatives with outliers.
/// </summary>
[IsoId("_x4xX8VyGEe24CqbZJK5XxA")]
[DisplayName("Detailed Transaction Statistics")]
public record DetailedTransactionStatistics28
{
    /// <summary>
    /// Number of reported derivatives.
    /// </summary>
    [IsoId("_x5wPYVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported")]
    [IsoXmlTag("NbOfDerivsRptd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDerivativesReported { get; init; }

    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    [IsoId("_x5wPY1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported With Outliers")]
    [IsoXmlTag("NbOfDerivsRptdWthOtlrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; }

    /// <summary>
    /// Details of abnormal values.
    /// </summary>
    [IsoId("_x5wPZVyGEe24CqbZJK5XxA")]
    [DisplayName("Warnings")]
    [IsoXmlTag("Wrnngs")]
    public ValueList<AbnormalValuesData4> Warnings { get; init; } = [];
    // ID for the above is _x5wPZVyGEe24CqbZJK5XxA
}
