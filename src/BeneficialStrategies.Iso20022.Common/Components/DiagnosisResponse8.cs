// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the diagnosis response message.
/// </summary>
[IsoId("_nZ2K8c-gEfCTVKnQ8NFKFg")]
[DisplayName("Diagnosis Response8")]
public record DiagnosisResponse8
{
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_nawJ5c-gEfCTVKnQ8NFKFg")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    public SimpleValueList<IsoMax35Text> LoggedSaleIdentification { get; init; } = [];

    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_nawJ68-gEfCTVKnQ8NFKFg")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent15? POIStatus { get; init; }

    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_naww9c-gEfCTVKnQ8NFKFg")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public ValueList<HostStatus1> HostStatus { get; init; } = [];
}
