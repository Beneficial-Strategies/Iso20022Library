// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Diagnosis Response message.
/// </summary>
[IsoId("_99qRgQ0sEeqUVL7sB4m7NA")]
[DisplayName("Diagnosis Response")]
public record DiagnosisResponse2
{
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_-JB0AQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LoggedSaleIdentification { get; init; }

    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_-JB0Aw0sEeqUVL7sB4m7NA")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent9? POIStatus { get; init; }

    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_-JB0BQ0sEeqUVL7sB4m7NA")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public HostStatus1? HostStatus { get; init; }
}
