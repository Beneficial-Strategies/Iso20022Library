// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnosis Response6.
/// </summary>
[IsoId("_YyjzMZTfEe6sd81HehWb6w")]
[DisplayName("Diagnosis Response6")]
public partial record DiagnosisResponse6
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
    public StatusReportContent13? POIStatus { get; init; } 

    
    #nullable disable
    
}
