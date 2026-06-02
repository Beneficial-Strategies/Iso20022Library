// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the report.
/// </summary>
[IsoId("_MMY5keFiEeWIA4E9cYSxxQ")]
[DisplayName("Intra Position Report4")]
public record IntraPositionReport4
{
    /// <summary>
    /// Identification of the query message sent to request this statement.
    /// </summary>
    [IsoId("_MVUMFeFiEeWIA4E9cYSxxQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a report.
    /// </summary>
    [IsoId("_MVUMHeFiEeWIA4E9cYSxxQ")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Defines the type of query.
    /// </summary>
    [IsoId("_MVUMH-FiEeWIA4E9cYSxxQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public required MovementResponseType1Code QueryType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_MVUMJ-FiEeWIA4E9cYSxxQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
