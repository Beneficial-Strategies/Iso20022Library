// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the status report.
/// </summary>
[IsoId("_XfzTIbYEEfCUZfsQO4rYeA")]
[DisplayName("Status Report Content15")]
public record StatusReportContent15
{
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_Xg4RNbYEEfCUZfsQO4rYeA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities11? POICapabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_Xg4RO7YEEfCUZfsQO4rYeA")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent18> POIComponent { get; init; } = [];

    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_Xg4RQbYEEfCUZfsQO4rYeA")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    public SimpleValueList<IsoMax35Text> POIGroupIdentification { get; init; } = [];

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    [IsoId("_Xg4RR7YEEfCUZfsQO4rYeA")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_Xg4RTbYEEfCUZfsQO4rYeA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_Xg4RU7YEEfCUZfsQO4rYeA")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public ValueList<DataSetRequest7> DataSetRequired { get; init; } = [];

    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_Xg4RWbYEEfCUZfsQO4rYeA")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public ValueList<TMSEvent13> Event { get; init; } = [];

    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_Xg4RX7YEEfCUZfsQO4rYeA")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    public SimpleValueList<IsoMax140Text> Errors { get; init; } = [];
}
