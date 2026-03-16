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
[IsoId("_-cMvAWpKEeSR-ZWLvO-1dg")]
[DisplayName("Status Report Content")]
public record StatusReportContent4
{
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_-othAWpKEeSR-ZWLvO-1dg")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities3? POICapabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_-othA2pKEeSR-ZWLvO-1dg")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent5? POIComponent { get; init; }

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    [IsoId("_-othBWpKEeSR-ZWLvO-1dg")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_-othB2pKEeSR-ZWLvO-1dg")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_-othCWpKEeSR-ZWLvO-1dg")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public TerminalManagementDataSet12? DataSetRequired { get; init; }

    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_-othC2pKEeSR-ZWLvO-1dg")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public TMSEvent3? Event { get; init; }

    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_-othDWpKEeSR-ZWLvO-1dg")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Errors { get; init; }
}
