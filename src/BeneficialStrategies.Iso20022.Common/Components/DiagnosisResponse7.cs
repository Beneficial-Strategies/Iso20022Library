// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnosis Response7.
/// </summary>
[IsoId("_OTK5caE8Ee-MRKYsaX6JDg")]
[DisplayName("Diagnosis Response7")]
public partial record DiagnosisResponse7
{
    #nullable enable

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

    
    #nullable disable
    
}
