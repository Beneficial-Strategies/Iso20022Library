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
[IsoId("_i19D4TV8EeODSIIQsYYKhw")]
[DisplayName("Status Report Content")]
public record StatusReportContent3
{
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_jGKqITV8EeODSIIQsYYKhw")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities2? POICapabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_jGKqIzV8EeODSIIQsYYKhw")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent4> POIComponent { get; init; } = [];

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    [IsoId("_jGKqJTV8EeODSIIQsYYKhw")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_jGKqJzV8EeODSIIQsYYKhw")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_jGKqKTV8EeODSIIQsYYKhw")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public TerminalManagementDataSet8? DataSetRequired { get; init; }

    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_jGKqKzV8EeODSIIQsYYKhw")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public ValueList<TMSEvent2> Event { get; init; } = [];

    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_jGKqLTV8EeODSIIQsYYKhw")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    public SimpleValueList<IsoMax140Text> Errors { get; init; } = [];
}
