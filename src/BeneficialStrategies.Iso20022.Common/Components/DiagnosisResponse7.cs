// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnosis Response7.
/// </summary>
[IsoId("_OTK5caE8Ee-MRKYsaX6JDg")]
[DisplayName("Diagnosis Response7")]
public record DiagnosisResponse7
{
    /// <summary>
    /// Host Status.
    /// </summary>
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public ValueList<HostStatus1> HostStatus { get; init; } = [];

    /// <summary>
    /// Logged Sale Identification.
    /// </summary>
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    public ValueList<IsoMax35Text> LoggedSaleIdentification { get; init; } = [];

    /// <summary>
    /// POI Status.
    /// </summary>
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent14? POIStatus { get; init; }
}
