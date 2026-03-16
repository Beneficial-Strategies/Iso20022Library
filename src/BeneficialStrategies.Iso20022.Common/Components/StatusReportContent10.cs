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
[IsoId("_w2W44Si0Eeurkfo6MpvKDA")]
[DisplayName("Status Report Content")]
public record StatusReportContent10
{
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_xERZESi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Capabilities")]
    [IsoXmlTag("POICpblties")]
    public PointOfInteractionCapabilities9? POICapabilities { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_xERZEyi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent11? POIComponent { get; init; }

    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_fCj4YTANEeugIJ3Gvoevmg")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; }

    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    [IsoId("_xERZFSi0Eeurkfo6MpvKDA")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; }

    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_xERZFyi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_xERZGSi0Eeurkfo6MpvKDA")]
    [DisplayName("Data Set Required")]
    [IsoXmlTag("DataSetReqrd")]
    public DataSetRequest2? DataSetRequired { get; init; }

    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_xERZGyi0Eeurkfo6MpvKDA")]
    [DisplayName("Event")]
    [IsoXmlTag("Evt")]
    public TMSEvent8? Event { get; init; }

    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_xERZHSi0Eeurkfo6MpvKDA")]
    [DisplayName("Errors")]
    [IsoXmlTag("Errs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Errors { get; init; }
}
