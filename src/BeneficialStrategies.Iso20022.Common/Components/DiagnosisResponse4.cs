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
[IsoId("_sVO1MU6rEeyGi9JAv6wq7Q")]
[DisplayName("Diagnosis Response")]
public record DiagnosisResponse4
{
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_sbX5cU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    public SimpleValueList<IsoMax35Text> LoggedSaleIdentification { get; init; } = [];

    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_sbX5c06rEeyGi9JAv6wq7Q")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent11? POIStatus { get; init; }

    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_sbX5dU6rEeyGi9JAv6wq7Q")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public ValueList<HostStatus1> HostStatus { get; init; } = [];
}
