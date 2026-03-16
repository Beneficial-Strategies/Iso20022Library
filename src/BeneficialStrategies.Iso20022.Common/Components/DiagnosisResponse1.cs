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
[IsoId("__oeZQN6LEeiwsev40qZGEQ")]
[DisplayName("Diagnosis Response")]
public record DiagnosisResponse1
{
    /// <summary>
    /// Sale Terminal logged to.
    /// </summary>
    [IsoId("_HRIMsN6MEeiwsev40qZGEQ")]
    [DisplayName("Logged Sale Identification")]
    [IsoXmlTag("LggdSaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LoggedSaleIdentification { get; init; }

    /// <summary>
    /// Status of the POI.
    /// </summary>
    [IsoId("_J_dbMN6MEeiwsev40qZGEQ")]
    [DisplayName("POI Status")]
    [IsoXmlTag("POISts")]
    public StatusReportContent8? POIStatus { get; init; }

    /// <summary>
    /// State of a Host.
    /// </summary>
    [IsoId("_NPDjsN6MEeiwsev40qZGEQ")]
    [DisplayName("Host Status")]
    [IsoXmlTag("HstSts")]
    public HostStatus1? HostStatus { get; init; }
}
